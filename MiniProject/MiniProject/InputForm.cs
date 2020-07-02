using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace MiniProject
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public void initializeDateTimePicker()
        {
            DtpQRCode.CustomFormat = "yyyy-MM-dd";
            DtpQRCode.Format = DateTimePickerFormat.Custom;          
        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PbxInput.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PbxInput.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)PbxInput.Image);

                if (result != null)
                {

                    //PbxInput.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    QRCodeDecoder decoder = new QRCodeDecoder();
                    string decoded = decoder.Decode(new QRCodeBitmapImage(PbxInput.Image as Bitmap));
                    string[] temp = decoded.Split(new char[] { '/' }, StringSplitOptions.None);

                    TxtQRCode1.Text = temp[0];
                    DtpQRCode.Text = temp[1];
                    TxtQRCode3.Text = temp[2];
                    TxtQRCode4.Text = temp[3];
                    CboQRCode.Text = temp[4];
                    TxtQRCode6.Text = temp[5];

                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
        private void BtnInput_Click(object sender, EventArgs e)
        {
            //CaptureDevice = new VideoCaptureDevice(FilterInfoCollection[CboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            initializeDateTimePicker();
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();

            }
        }


        private void BtnDecode_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "이미지 파일(.jpg)|*.jpg|모든 파일(*.*)|*.*";
                ofd.ValidateNames = true;
                ofd.Multiselect = false;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    

                    PbxInput.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    QRCodeDecoder decoder = new QRCodeDecoder();
                    string decoded = decoder.Decode(new QRCodeBitmapImage(PbxInput.Image as Bitmap));
                    string[] temp = decoded.Split(new char[] {'/'}, StringSplitOptions.None);
                    
                    TxtQRCode1.Text = temp[0];
                    DtpQRCode.Text = temp[1];
                    TxtQRCode3.Text = temp[2];
                    TxtQRCode4.Text = temp[3];
                    CboQRCode.Text = temp[4];
                    TxtQRCode6.Text = temp[5];                
                }
 
            }
        }
    }
}
