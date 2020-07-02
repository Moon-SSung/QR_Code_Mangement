using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
           
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginProcess()
        {
            if (string.IsNullOrEmpty(TxtID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show(this, "아이디 또는 패스워드를 입력하세요!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strUserID = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID FROM dbo.userTBL " +
                                      " WHERE userID = @userID and password = @password ";

                    //ID 설정
                    SqlParameter parmUserId = new SqlParameter("@userID", SqlDbType.VarChar, 15);
                    parmUserId.Value = TxtID.Text;
                    cmd.Parameters.Add(parmUserId);

                    //Password 설정
                    SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                    parmPassword.Value = TxtPassword.Text;
                    cmd.Parameters.Add(parmPassword);

                    SqlDataReader reader = cmd.ExecuteReader();                     
                    reader.Read();
                    strUserID = reader["userID"] != null ? reader["userID"].ToString() : "";

                    if(strUserID != "") // 로그인 성공
                    {
                        Commons.LOGINUSERID = strUserID;
                        MessageBox.Show(this, "접속성공", "로그인 성공");
                        this.Close();
                    }
                    else // 로그인 실패
                    {
                        MessageBox.Show(this, "접속실패", "로그인 실패",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "접속실패\n아이디 또는 비밀번호를 확인해주세요.", "로그인 실패",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show(this, $"ERROR : {ex.StackTrace}", "오류",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                TxtPassword.Focus();
            }
        }
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoginProcess();
            }
        }

    }
}
