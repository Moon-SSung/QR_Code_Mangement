using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class MemberForm : Form
    {
        string mode = "";
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기
            UpdateCboMemberPosition();
        }

        private void UpdateCboMemberPosition()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT memberID, Position FROM memberTBL";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> position = new Dictionary<string, string>();
                while(reader.Read())
                {
                    position.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboMemberPosition.DataSource = new BindingSource(position, null);
                CboMemberPosition.DisplayMember = "Value";
                CboMemberPosition.ValueMember = "Key";
                CboMemberPosition.SelectedIndex = -1;
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))   //using이 없으면 conn.Close() 해줘야함
            {
                conn.Open(); //DB 열기
                string strQuery = "SELECT memberID ,Name ,Position ,Address ,Mobile ,Email " +
                                  "  FROM dbo.memberTBL ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);  //sql문을 실행할때는 SqlCommand가 꼭 필요하다! update할때는 필요없음
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "membertbl");

                GrdMemberTBL.DataSource = ds;
                GrdMemberTBL.DataMember = "membertbl";
            }
        }

        private void GrdMemberTBL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdMemberTBL.Rows[e.RowIndex];
                TxtMemberID.ReadOnly = true; //Division이 PK라서 변경하면 안 된다.
                TxtMemberID.BackColor = Color.Red;
                TxtMemberID.Text = data.Cells[0].Value.ToString(); //MemberTbl의 ID
                TxtMemberName.Text = data.Cells[1].Value.ToString(); //MemberTbl의 Name
                CboMemberPosition.SelectedIndex = CboMemberPosition.FindString(data.Cells[2].Value.ToString()); //콤보박스의 인덱스 0번을 출력
                TxtMemberAddress.Text = data.Cells[3].Value.ToString();  //MemberTbl의 Address
                TxtMemberMobile.Text = data.Cells[4].Value.ToString();  //MemberTbl의 Mobile
                TxtMemberEmail.Text = data.Cells[5].Value.ToString(); //MemberTbl의 Email


                mode = "UPDATE"; // 수정은 UPDATE
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT"; // 신규는 INSERT
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMemberID.Text) || (string.IsNullOrEmpty(TxtMemberName.Text))
                 || (string.IsNullOrEmpty(TxtMemberMobile.Text)) || (string.IsNullOrEmpty(TxtMemberAddress.Text))
                 || (string.IsNullOrEmpty(TxtMemberEmail.Text)))
            {
                MessageBox.Show(this, "빈값을 저장할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }

            SaveProcess();
            UpdateData();

           ClearTextControls();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(TxtMemberID.Text) || string.IsNullOrEmpty(TxtMemberName.Text) ||
                string.IsNullOrEmpty(TxtMemberAddress.Text) || string.IsNullOrEmpty(TxtMemberMobile.Text) || string.IsNullOrEmpty(TxtMemberEmail.Text))
            {
                MessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            DeleteProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }



        // *********************************** 취소 ***********************************
        private void ClearTextControls()
        {
            TxtMemberID.Text = TxtMemberName.Text = TxtMemberAddress.Text = TxtMemberMobile.Text = TxtMemberEmail.Text = "";
            CboMemberPosition.SelectedIndex = -1;
            TxtMemberID.ReadOnly = true;
            TxtMemberID.BackColor = Color.Beige;
            TxtMemberName.Focus();
        }

        // *********************************** 저장 ***********************************
        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //DB저장프로세스
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.memberTBL " +
                               "   SET memberID = @memberID, " +
                               "       Name = @Name, " +
                               "       Position = @Position, " +
                               "       Address = @Address, " +
                               "       Mobile = @Mobile, " +
                               "       Email = @Email " +
                               " WHERE memberID = @memberID ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.membertbl (memberID, Name, Position, Address, Mobile, Email) " +
                              " VALUES (@memberID, @Name, @Position, @Address, @Mobile, @Email) ";
                }
                cmd.CommandText = strQuery;

                if (mode == "UPDATE")
                {
                    // TxtID 설정 
                    SqlParameter pramID = new SqlParameter("@memberID", System.Data.SqlDbType.VarChar, 12);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                    pramID.Value = TxtMemberID.Text;
                    cmd.Parameters.Add(pramID);
                }

                // TxtName 설정 
                SqlParameter pramName = new SqlParameter("@Name", System.Data.SqlDbType.VarChar, 10);//Names 속성 글자타입을 NVarChar, 길이를 45로 지정했음
                pramName.Value = TxtMemberName.Text;
                cmd.Parameters.Add(pramName);

                //CboPosition 설정
                SqlParameter parmPosition = new SqlParameter("@Position", System.Data.SqlDbType.VarChar, 5);//Levels 속성 글자타입을 Char, 길이를 1로 지정했음
                parmPosition.Value = CboMemberPosition.SelectedItem;
                cmd.Parameters.Add(parmPosition);

                // TxtAddress 설정 
                SqlParameter pramAddress = new SqlParameter("@Address", System.Data.SqlDbType.VarChar, 100);//Address 속성 글자타입을 VarChar, 길이를 100로 지정했음
                pramAddress.Value = TxtMemberAddress.Text;
                cmd.Parameters.Add(pramAddress);

                // TxtMobile 설정 
                SqlParameter pramMobile = new SqlParameter("@Mobile", System.Data.SqlDbType.VarChar, 13);//Mobile 속성 글자타입을 VarChar, 길이를 13로 지정했음
                pramMobile.Value = TxtMemberMobile.Text;
                cmd.Parameters.Add(pramMobile);

                // TxtEmail 설정 
                SqlParameter pramEmail = new SqlParameter("@Email", System.Data.SqlDbType.VarChar, 50);//Email 속성 글자타입을 VarChar, 길이를 50로 지정했음
                pramEmail.Value = TxtMemberEmail.Text;
                cmd.Parameters.Add(pramEmail);

                cmd.ExecuteNonQuery();  //쿼리문을 실행 시켜주기 위해서, NonQuery를 사용하는것은 값을 돌려받지 않기 위해서
            }
        }
        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)    // enter키 적용
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        // *********************************** 삭제 ***********************************

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.memberTBL WHERE memberID = @memberID";
                SqlParameter parmMemberID = new SqlParameter("@memberID", SqlDbType.VarChar, 12);
                parmMemberID.Value = TxtMemberID.Text;
                cmd.Parameters.Add(parmMemberID);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }
    }
}
