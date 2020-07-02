using Microsoft.Reporting.WinForms;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniProject
{
    public partial class QRCodeForm : Form
    {
        string mode = "";
        public QRCodeForm()
        {
            InitializeComponent();
        }


        public void initializeDateTimePicker()
        {
            DtpQRCode.CustomFormat = "yyyy-MM-dd";
            DtpQRCode.Format = DateTimePickerFormat.Custom;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            //QRCodeData data = qr.CreateQrCode(LblQR1.Text + " : " + TxtQRCode1.Text + " / " +
            //                                  LblQR2.Text + " : " + TxtQRCode2.Text + " / " +
            //                                  LblQR3.Text + " : " + TxtQRCode3.Text + " / ",
            //                                  QRCodeGenerator.ECCLevel.Q); //ECCLevel 오류복원 등급

            QRCodeData data = qr.CreateQrCode( TxtQRCode1.Text + "/" +
                                               DtpQRCode.Text + "/" +
                                               TxtQRCode3.Text + "/" +
                                               TxtQRCode4.Text + "/" +
                                               CboQRCode.Text + "/" +
                                               TxtQRCode6.Text + "/" ,
                                               QRCodeGenerator.ECCLevel.Q); //ECCLevel 오류복원 등급
            //string temp = data2.ToString();
            //string[] reuslt = temp.Split(new string[] { "\n" }, StringSplitOptions.None);
            //for(int i=0; i < result.Length; i++)
            //{

            //}

            QRCode code = new QRCode(data);


            PbxQRCode.Image = code.GetGraphic(5);

            //using(MemoryStream ms = new MemoryStream())
            //{
            //    bmp.Save(ms, ImageFormat.Bmp);
            //    ReportData reportData = new ReportData();
            //    ReportData.QRCodeRow qRCodeRow = reportData.QRCode.NewQRCodeRow();
            //    qRCodeRow.Image = ms.ToArray();
            //    reportData.QRCode.AddQRCodeRow(qRCodeRow);

            //    ReportDataSource reportDataSource = new ReportDataSource();
            //    reportDataSource.Name = "ReportData";
            //    reportDataSource.Value = reportData.QRCode;
            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //    reportViewer1.RefreshReport();
            //}
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "다른 이름으로 저장";
            dlg.DefaultExt = "png";
            dlg.Filter = "JPEG (*.jpg) | *.jpg | Bitmap (*.bmp)|*.bmp | GIF (*.gif)|*.gif | Png (*.png)|*.png";
            dlg.FilterIndex = 0;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
                PbxQRCode.Image.Save(dlg.FileName);
            }


            //if (MessageBox.Show(this, "저장하시겠습니까?", "저장",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    string saveFolder = @"C:\miniPDF\SaveJPG\";
            //    PbxQRCode.Image.Save(saveFolder + "\\test_QR.png", ImageFormat.Png);
            //}

        }



        private void QRCodeForm_Load(object sender, EventArgs e)
        {
            initializeDateTimePicker();
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();

            }
        }
    }
}
