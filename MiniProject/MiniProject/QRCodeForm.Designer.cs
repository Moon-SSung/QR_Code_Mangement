namespace MiniProject
{
    partial class QRCodeForm
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
            this.components = new System.ComponentModel.Container();
            this.QRCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportData = new MiniProject.ReportData();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PbxQRCode = new System.Windows.Forms.PictureBox();
            this.TxtQRCode1 = new System.Windows.Forms.TextBox();
            this.TxtQRCode3 = new System.Windows.Forms.TextBox();
            this.LblQR1 = new System.Windows.Forms.Label();
            this.LblQR2 = new System.Windows.Forms.Label();
            this.LblQR3 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblQR6 = new System.Windows.Forms.Label();
            this.LblQR5 = new System.Windows.Forms.Label();
            this.LblQR4 = new System.Windows.Forms.Label();
            this.TxtQRCode6 = new System.Windows.Forms.TextBox();
            this.TxtQRCode4 = new System.Windows.Forms.TextBox();
            this.DtpQRCode = new System.Windows.Forms.DateTimePicker();
            this.CboQRCode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodeBindingSource
            // 
            this.QRCodeBindingSource.DataMember = "QRCode";
            this.QRCodeBindingSource.DataSource = this.ReportData;
            // 
            // ReportData
            // 
            this.ReportData.DataSetName = "ReportData";
            this.ReportData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(157, 314);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(165, 31);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "만들기";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR Code";
            // 
            // PbxQRCode
            // 
            this.PbxQRCode.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PbxQRCode.Location = new System.Drawing.Point(12, 38);
            this.PbxQRCode.Name = "PbxQRCode";
            this.PbxQRCode.Size = new System.Drawing.Size(246, 233);
            this.PbxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxQRCode.TabIndex = 2;
            this.PbxQRCode.TabStop = false;
            // 
            // TxtQRCode1
            // 
            this.TxtQRCode1.Location = new System.Drawing.Point(371, 38);
            this.TxtQRCode1.Multiline = true;
            this.TxtQRCode1.Name = "TxtQRCode1";
            this.TxtQRCode1.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode1.TabIndex = 1;
            // 
            // TxtQRCode3
            // 
            this.TxtQRCode3.Location = new System.Drawing.Point(371, 126);
            this.TxtQRCode3.Multiline = true;
            this.TxtQRCode3.Name = "TxtQRCode3";
            this.TxtQRCode3.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode3.TabIndex = 3;
            // 
            // LblQR1
            // 
            this.LblQR1.Location = new System.Drawing.Point(311, 41);
            this.LblQR1.Name = "LblQR1";
            this.LblQR1.Size = new System.Drawing.Size(54, 15);
            this.LblQR1.TabIndex = 4;
            this.LblQR1.Text = "번호";
            this.LblQR1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR2
            // 
            this.LblQR2.Location = new System.Drawing.Point(266, 85);
            this.LblQR2.Name = "LblQR2";
            this.LblQR2.Size = new System.Drawing.Size(100, 15);
            this.LblQR2.TabIndex = 4;
            this.LblQR2.Text = "일자";
            this.LblQR2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR3
            // 
            this.LblQR3.Location = new System.Drawing.Point(281, 129);
            this.LblQR3.Name = "LblQR3";
            this.LblQR3.Size = new System.Drawing.Size(85, 15);
            this.LblQR3.TabIndex = 4;
            this.LblQR3.Text = "품목코드";
            this.LblQR3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(371, 314);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(165, 31);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "저장하기";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblQR6
            // 
            this.LblQR6.Location = new System.Drawing.Point(281, 260);
            this.LblQR6.Name = "LblQR6";
            this.LblQR6.Size = new System.Drawing.Size(85, 15);
            this.LblQR6.TabIndex = 8;
            this.LblQR6.Text = "거래처번호";
            this.LblQR6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR5
            // 
            this.LblQR5.Location = new System.Drawing.Point(266, 216);
            this.LblQR5.Name = "LblQR5";
            this.LblQR5.Size = new System.Drawing.Size(100, 15);
            this.LblQR5.TabIndex = 9;
            this.LblQR5.Text = "창고";
            this.LblQR5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR4
            // 
            this.LblQR4.Location = new System.Drawing.Point(284, 173);
            this.LblQR4.Name = "LblQR4";
            this.LblQR4.Size = new System.Drawing.Size(82, 15);
            this.LblQR4.TabIndex = 10;
            this.LblQR4.Text = "수량";
            this.LblQR4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtQRCode6
            // 
            this.TxtQRCode6.Location = new System.Drawing.Point(372, 258);
            this.TxtQRCode6.Multiline = true;
            this.TxtQRCode6.Name = "TxtQRCode6";
            this.TxtQRCode6.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode6.TabIndex = 7;
            // 
            // TxtQRCode4
            // 
            this.TxtQRCode4.Location = new System.Drawing.Point(372, 170);
            this.TxtQRCode4.Multiline = true;
            this.TxtQRCode4.Name = "TxtQRCode4";
            this.TxtQRCode4.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode4.TabIndex = 5;
            // 
            // DtpQRCode
            // 
            this.DtpQRCode.Location = new System.Drawing.Point(371, 82);
            this.DtpQRCode.Name = "DtpQRCode";
            this.DtpQRCode.Size = new System.Drawing.Size(290, 25);
            this.DtpQRCode.TabIndex = 11;
            // 
            // CboQRCode
            // 
            this.CboQRCode.FormattingEnabled = true;
            this.CboQRCode.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CboQRCode.Location = new System.Drawing.Point(373, 216);
            this.CboQRCode.Name = "CboQRCode";
            this.CboQRCode.Size = new System.Drawing.Size(288, 23);
            this.CboQRCode.TabIndex = 12;
            // 
            // QRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 405);
            this.Controls.Add(this.CboQRCode);
            this.Controls.Add(this.DtpQRCode);
            this.Controls.Add(this.LblQR6);
            this.Controls.Add(this.LblQR5);
            this.Controls.Add(this.LblQR4);
            this.Controls.Add(this.TxtQRCode6);
            this.Controls.Add(this.TxtQRCode4);
            this.Controls.Add(this.LblQR3);
            this.Controls.Add(this.LblQR2);
            this.Controls.Add(this.LblQR1);
            this.Controls.Add(this.TxtQRCode3);
            this.Controls.Add(this.TxtQRCode1);
            this.Controls.Add(this.PbxQRCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "QRCodeForm";
            this.Text = "QRCodeForm";
            this.Load += new System.EventHandler(this.QRCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbxQRCode;
        private System.Windows.Forms.TextBox TxtQRCode1;
        private System.Windows.Forms.TextBox TxtQRCode3;
        private System.Windows.Forms.Label LblQR1;
        private System.Windows.Forms.Label LblQR2;
        private System.Windows.Forms.Label LblQR3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.BindingSource QRCodeBindingSource;
        private ReportData ReportData;
        private System.Windows.Forms.Label LblQR6;
        private System.Windows.Forms.Label LblQR5;
        private System.Windows.Forms.Label LblQR4;
        private System.Windows.Forms.TextBox TxtQRCode6;
        private System.Windows.Forms.TextBox TxtQRCode4;
        private System.Windows.Forms.DateTimePicker DtpQRCode;
        private System.Windows.Forms.ComboBox CboQRCode;
    }
}