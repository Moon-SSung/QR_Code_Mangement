namespace MiniProject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.BtnMember = new System.Windows.Forms.Button();
            this.BtnInput = new System.Windows.Forms.Button();
            this.BtnFactory = new System.Windows.Forms.Button();
            this.BtnOutput = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnQRCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxLogo
            // 
            this.PbxLogo.Location = new System.Drawing.Point(86, 12);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(595, 139);
            this.PbxLogo.TabIndex = 1;
            this.PbxLogo.TabStop = false;
            // 
            // BtnMember
            // 
            this.BtnMember.Location = new System.Drawing.Point(86, 193);
            this.BtnMember.Name = "BtnMember";
            this.BtnMember.Size = new System.Drawing.Size(235, 61);
            this.BtnMember.TabIndex = 1;
            this.BtnMember.Text = "사원관리";
            this.BtnMember.UseVisualStyleBackColor = true;
            this.BtnMember.Click += new System.EventHandler(this.BtnMember_Click);
            // 
            // BtnInput
            // 
            this.BtnInput.Location = new System.Drawing.Point(446, 193);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(235, 61);
            this.BtnInput.TabIndex = 2;
            this.BtnInput.Text = "입고관리";
            this.BtnInput.UseVisualStyleBackColor = true;
            this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // BtnFactory
            // 
            this.BtnFactory.Location = new System.Drawing.Point(86, 293);
            this.BtnFactory.Name = "BtnFactory";
            this.BtnFactory.Size = new System.Drawing.Size(235, 61);
            this.BtnFactory.TabIndex = 3;
            this.BtnFactory.Text = "거래처관리";
            this.BtnFactory.UseVisualStyleBackColor = true;
            // 
            // BtnOutput
            // 
            this.BtnOutput.Location = new System.Drawing.Point(446, 293);
            this.BtnOutput.Name = "BtnOutput";
            this.BtnOutput.Size = new System.Drawing.Size(235, 61);
            this.BtnOutput.TabIndex = 4;
            this.BtnOutput.Text = "출고관리";
            this.BtnOutput.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            this.BtnProduct.Location = new System.Drawing.Point(86, 390);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(235, 61);
            this.BtnProduct.TabIndex = 5;
            this.BtnProduct.Text = "품목관리";
            this.BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnQRCode
            // 
            this.BtnQRCode.Location = new System.Drawing.Point(446, 390);
            this.BtnQRCode.Name = "BtnQRCode";
            this.BtnQRCode.Size = new System.Drawing.Size(235, 61);
            this.BtnQRCode.TabIndex = 6;
            this.BtnQRCode.Text = "QR코드관리";
            this.BtnQRCode.UseVisualStyleBackColor = true;
            this.BtnQRCode.Click += new System.EventHandler(this.BtnQRCode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(767, 535);
            this.Controls.Add(this.BtnQRCode);
            this.Controls.Add(this.BtnOutput);
            this.Controls.Add(this.BtnInput);
            this.Controls.Add(this.BtnProduct);
            this.Controls.Add(this.BtnFactory);
            this.Controls.Add(this.BtnMember);
            this.Controls.Add(this.PbxLogo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Button BtnMember;
        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Button BtnFactory;
        private System.Windows.Forms.Button BtnOutput;
        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button BtnQRCode;
    }
}

