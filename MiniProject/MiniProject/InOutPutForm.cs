﻿using MetroFramework.Forms;
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
    public partial class InOutForm : MetroForm
    {
        string mode = "";
        public InOutForm()
        {
            InitializeComponent();
        }

        private void In_Load(object sender, EventArgs e)
        {
            UpdateData();
            ClearTextControls();
        }

        private void UpdateData()
        {
            using(SqlConnection conn =new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                string strQuery = "SELECT I.IDX,I.DATE,P.ID,P.UNIT "+
                                    "  , I.WHEREHOUSE,C.IDX "+
                                   " FROM dbo.InOutTbl AS I "+
                                   " INNER jOIN dbo.ClientTbl AS C "+
                                   " ON I.CLIENTIDX = C.IDX "+
                                   " INNER JOIN dbo.EmployeeTbl AS E "+
                                   " ON I.EMPLOYEEIDX = E.IDX "+
                                   " INNER JOIN dbo.ProductTbl AS P "+
                                   "  ON I.PRODUCTIDX = P.IDX ";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "InOutTbl");
                GrdInOutTbl.DataSource = ds;
                GrdInOutTbl.DataMember = "InOutTbl";
            }
            //DataGridViewColumn column = GrdInOutTbl.Columns[2]; //id컬럼
            //column.Visible = false;
        }

        private void GrdInOutTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {   //var data
                DataGridViewRow data = GrdInOutTbl.Rows[e.RowIndex];
                Txtidx.Text = data.Cells[0].Value.ToString();
                Txtidx.ReadOnly = true;  
                Txtidx.BackColor = Color.Beige;

                DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
                DtpReleaseDate.Format = DateTimePickerFormat.Custom; // 값을 리셋해주는 방법
                DtpReleaseDate.Value = DateTime.Parse(data.Cells[1].Value.ToString());
                
                TxtProductidx.Text = data.Cells[2].Value.ToString();
                TxtProductUnit.Text = data.Cells[3].Value.ToString();
                CbowhereHouse.SelectedValue = data.Cells[4].Value;
                CbowhereHouse.SelectedIndex = CbowhereHouse.FindString(data.Cells[4].Value.ToString());  // 콤보 박스에서 찾은 인덱스는 = 데이터에서 2번값에서 가져온 값을 찾아라
                TxtClientidx.Text = data.Cells[5].Value.ToString();
                mode = "UPDATE"; //수정은 UPDATE
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT"; //신규는 INSERT
        }

        private void ClearTextControls()
        {
            TxtProductidx.Text = TxtClientidx.Text = Txtidx.Text = TxtProductidx.Text = TxtProductUnit.Text = "";
            Txtidx.ReadOnly = false;
            Txtidx.BackColor = Color.White;
            Txtidx.Focus();
            DtpReleaseDate.CustomFormat = " ";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
            CbowhereHouse.SelectedIndex = -1;
        }
    }
}
