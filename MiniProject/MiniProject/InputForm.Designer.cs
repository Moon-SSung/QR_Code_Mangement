namespace MiniProject
{
    partial class InputForm
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
            this.BtnInput = new System.Windows.Forms.Button();
            this.BtnDecode = new System.Windows.Forms.Button();
            this.PbxInput = new System.Windows.Forms.PictureBox();
            this.CboQRCode = new System.Windows.Forms.ComboBox();
            this.DtpQRCode = new System.Windows.Forms.DateTimePicker();
            this.LblQR6 = new System.Windows.Forms.Label();
            this.LblQR5 = new System.Windows.Forms.Label();
            this.LblQR4 = new System.Windows.Forms.Label();
            this.TxtQRCode6 = new System.Windows.Forms.TextBox();
            this.TxtQRCode4 = new System.Windows.Forms.TextBox();
            this.LblQR3 = new System.Windows.Forms.Label();
            this.LblQR2 = new System.Windows.Forms.Label();
            this.LblQR1 = new System.Windows.Forms.Label();
            this.TxtQRCode3 = new System.Windows.Forms.TextBox();
            this.TxtQRCode1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbxInput)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInput
            // 
            this.BtnInput.Location = new System.Drawing.Point(205, 339);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(156, 36);
            this.BtnInput.TabIndex = 12;
            this.BtnInput.Text = "가져오기";
            this.BtnInput.UseVisualStyleBackColor = true;
            this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // BtnDecode
            // 
            this.BtnDecode.Location = new System.Drawing.Point(378, 339);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(156, 36);
            this.BtnDecode.TabIndex = 12;
            this.BtnDecode.Text = "테스트";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // PbxInput
            // 
            this.PbxInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PbxInput.Location = new System.Drawing.Point(22, 49);
            this.PbxInput.Name = "PbxInput";
            this.PbxInput.Size = new System.Drawing.Size(245, 203);
            this.PbxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxInput.TabIndex = 13;
            this.PbxInput.TabStop = false;
            // 
            // CboQRCode
            // 
            this.CboQRCode.FormattingEnabled = true;
            this.CboQRCode.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CboQRCode.Location = new System.Drawing.Point(411, 227);
            this.CboQRCode.Name = "CboQRCode";
            this.CboQRCode.Size = new System.Drawing.Size(288, 23);
            this.CboQRCode.TabIndex = 25;
            // 
            // DtpQRCode
            // 
            this.DtpQRCode.Location = new System.Drawing.Point(409, 93);
            this.DtpQRCode.Name = "DtpQRCode";
            this.DtpQRCode.Size = new System.Drawing.Size(290, 25);
            this.DtpQRCode.TabIndex = 24;
            // 
            // LblQR6
            // 
            this.LblQR6.Location = new System.Drawing.Point(319, 271);
            this.LblQR6.Name = "LblQR6";
            this.LblQR6.Size = new System.Drawing.Size(85, 15);
            this.LblQR6.TabIndex = 21;
            this.LblQR6.Text = "거래처번호";
            this.LblQR6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR5
            // 
            this.LblQR5.Location = new System.Drawing.Point(304, 227);
            this.LblQR5.Name = "LblQR5";
            this.LblQR5.Size = new System.Drawing.Size(100, 15);
            this.LblQR5.TabIndex = 22;
            this.LblQR5.Text = "창고";
            this.LblQR5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR4
            // 
            this.LblQR4.Location = new System.Drawing.Point(322, 184);
            this.LblQR4.Name = "LblQR4";
            this.LblQR4.Size = new System.Drawing.Size(82, 15);
            this.LblQR4.TabIndex = 23;
            this.LblQR4.Text = "수량";
            this.LblQR4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtQRCode6
            // 
            this.TxtQRCode6.Location = new System.Drawing.Point(410, 269);
            this.TxtQRCode6.Multiline = true;
            this.TxtQRCode6.Name = "TxtQRCode6";
            this.TxtQRCode6.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode6.TabIndex = 20;
            // 
            // TxtQRCode4
            // 
            this.TxtQRCode4.Location = new System.Drawing.Point(410, 181);
            this.TxtQRCode4.Multiline = true;
            this.TxtQRCode4.Name = "TxtQRCode4";
            this.TxtQRCode4.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode4.TabIndex = 19;
            // 
            // LblQR3
            // 
            this.LblQR3.Location = new System.Drawing.Point(319, 140);
            this.LblQR3.Name = "LblQR3";
            this.LblQR3.Size = new System.Drawing.Size(85, 15);
            this.LblQR3.TabIndex = 16;
            this.LblQR3.Text = "품목코드";
            this.LblQR3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR2
            // 
            this.LblQR2.Location = new System.Drawing.Point(304, 96);
            this.LblQR2.Name = "LblQR2";
            this.LblQR2.Size = new System.Drawing.Size(100, 15);
            this.LblQR2.TabIndex = 17;
            this.LblQR2.Text = "일자";
            this.LblQR2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR1
            // 
            this.LblQR1.Location = new System.Drawing.Point(349, 52);
            this.LblQR1.Name = "LblQR1";
            this.LblQR1.Size = new System.Drawing.Size(54, 15);
            this.LblQR1.TabIndex = 18;
            this.LblQR1.Text = "번호";
            this.LblQR1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtQRCode3
            // 
            this.TxtQRCode3.Location = new System.Drawing.Point(409, 137);
            this.TxtQRCode3.Multiline = true;
            this.TxtQRCode3.Name = "TxtQRCode3";
            this.TxtQRCode3.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode3.TabIndex = 15;
            // 
            // TxtQRCode1
            // 
            this.TxtQRCode1.Location = new System.Drawing.Point(409, 49);
            this.TxtQRCode1.Multiline = true;
            this.TxtQRCode1.Name = "TxtQRCode1";
            this.TxtQRCode1.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode1.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.PbxInput);
            this.Controls.Add(this.BtnDecode);
            this.Controls.Add(this.BtnInput);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.PictureBox PbxInput;
        private System.Windows.Forms.ComboBox CboQRCode;
        private System.Windows.Forms.DateTimePicker DtpQRCode;
        private System.Windows.Forms.Label LblQR6;
        private System.Windows.Forms.Label LblQR5;
        private System.Windows.Forms.Label LblQR4;
        private System.Windows.Forms.TextBox TxtQRCode6;
        private System.Windows.Forms.TextBox TxtQRCode4;
        private System.Windows.Forms.Label LblQR3;
        private System.Windows.Forms.Label LblQR2;
        private System.Windows.Forms.Label LblQR1;
        private System.Windows.Forms.TextBox TxtQRCode3;
        private System.Windows.Forms.TextBox TxtQRCode1;
        private System.Windows.Forms.Timer timer1;
    }
}