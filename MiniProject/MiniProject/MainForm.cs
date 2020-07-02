using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }


        //private void InitChildForm(Form form, string strFormTitle)
        //{
        //    form.Text = strFormTitle;
        //    form.Dock = DockStyle.Fill; //화면을 꽉 채움
        //    form.MdiParent = this;  //
        //    form.Show();
        //    form.WindowState = FormWindowState.Maximized;
        //}

        private void BtnMember_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm();
            memberForm.ShowDialog();
        }

        private void BtnQRCode_Click(object sender, EventArgs e)
        {
            QRCodeForm QR = new QRCodeForm();
            QR.ShowDialog();
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog();
        }
    }
}

