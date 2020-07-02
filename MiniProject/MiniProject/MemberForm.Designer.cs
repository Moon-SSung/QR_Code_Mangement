namespace MiniProject
{
    partial class MemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrdMemberTBL = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMemberID = new System.Windows.Forms.TextBox();
            this.TxtMemberName = new System.Windows.Forms.TextBox();
            this.TxtMemberAddress = new System.Windows.Forms.TextBox();
            this.TxtMemberMobile = new System.Windows.Forms.TextBox();
            this.TxtMemberEmail = new System.Windows.Forms.TextBox();
            this.CboMemberPosition = new System.Windows.Forms.ComboBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMemberTBL)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdMemberTBL
            // 
            this.GrdMemberTBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMemberTBL.Location = new System.Drawing.Point(12, 12);
            this.GrdMemberTBL.Name = "GrdMemberTBL";
            this.GrdMemberTBL.RowHeadersWidth = 51;
            this.GrdMemberTBL.RowTemplate.Height = 27;
            this.GrdMemberTBL.Size = new System.Drawing.Size(458, 426);
            this.GrdMemberTBL.TabIndex = 0;
            this.GrdMemberTBL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMemberTBL_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "사원번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "성명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "직급";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "주소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "휴대폰";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "이메일";
            // 
            // TxtMemberID
            // 
            this.TxtMemberID.Location = new System.Drawing.Point(577, 51);
            this.TxtMemberID.Name = "TxtMemberID";
            this.TxtMemberID.Size = new System.Drawing.Size(211, 25);
            this.TxtMemberID.TabIndex = 1;
            // 
            // TxtMemberName
            // 
            this.TxtMemberName.Location = new System.Drawing.Point(577, 84);
            this.TxtMemberName.Name = "TxtMemberName";
            this.TxtMemberName.Size = new System.Drawing.Size(211, 25);
            this.TxtMemberName.TabIndex = 2;
            // 
            // TxtMemberAddress
            // 
            this.TxtMemberAddress.Location = new System.Drawing.Point(577, 150);
            this.TxtMemberAddress.Name = "TxtMemberAddress";
            this.TxtMemberAddress.Size = new System.Drawing.Size(211, 25);
            this.TxtMemberAddress.TabIndex = 4;
            // 
            // TxtMemberMobile
            // 
            this.TxtMemberMobile.Location = new System.Drawing.Point(577, 183);
            this.TxtMemberMobile.Name = "TxtMemberMobile";
            this.TxtMemberMobile.Size = new System.Drawing.Size(211, 25);
            this.TxtMemberMobile.TabIndex = 5;
            // 
            // TxtMemberEmail
            // 
            this.TxtMemberEmail.Location = new System.Drawing.Point(577, 216);
            this.TxtMemberEmail.Name = "TxtMemberEmail";
            this.TxtMemberEmail.Size = new System.Drawing.Size(211, 25);
            this.TxtMemberEmail.TabIndex = 6;
            // 
            // CboMemberPosition
            // 
            this.CboMemberPosition.FormattingEnabled = true;
            this.CboMemberPosition.Location = new System.Drawing.Point(577, 117);
            this.CboMemberPosition.Name = "CboMemberPosition";
            this.CboMemberPosition.Size = new System.Drawing.Size(211, 23);
            this.CboMemberPosition.TabIndex = 3;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(479, 283);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(71, 57);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(560, 283);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 57);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(641, 283);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 57);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(722, 283);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 57);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.CboMemberPosition);
            this.Controls.Add(this.TxtMemberEmail);
            this.Controls.Add(this.TxtMemberMobile);
            this.Controls.Add(this.TxtMemberAddress);
            this.Controls.Add(this.TxtMemberName);
            this.Controls.Add(this.TxtMemberID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdMemberTBL);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMemberTBL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdMemberTBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMemberID;
        private System.Windows.Forms.TextBox TxtMemberName;
        private System.Windows.Forms.TextBox TxtMemberAddress;
        private System.Windows.Forms.TextBox TxtMemberMobile;
        private System.Windows.Forms.TextBox TxtMemberEmail;
        private System.Windows.Forms.ComboBox CboMemberPosition;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
    }
}