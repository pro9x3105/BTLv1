namespace BTLv1
{
    partial class SignUp
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPassCheck = new System.Windows.Forms.Label();
            this.txtPassCheck = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(135, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(108, 20);
            this.txtPass.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(135, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 6;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(39, 67);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(52, 13);
            this.lbPass.TabIndex = 5;
            this.lbPass.Text = "Mật khẩu";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(39, 32);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(81, 13);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "Tên đăng nhập";
            // 
            // lbPassCheck
            // 
            this.lbPassCheck.AutoSize = true;
            this.lbPassCheck.Location = new System.Drawing.Point(39, 102);
            this.lbPassCheck.Name = "lbPassCheck";
            this.lbPassCheck.Size = new System.Drawing.Size(50, 13);
            this.lbPassCheck.TabIndex = 8;
            this.lbPassCheck.Text = "Nhập Lại";
            // 
            // txtPassCheck
            // 
            this.txtPassCheck.Location = new System.Drawing.Point(135, 99);
            this.txtPassCheck.Name = "txtPassCheck";
            this.txtPassCheck.Size = new System.Drawing.Size(108, 20);
            this.txtPassCheck.TabIndex = 9;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(277, 27);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(277, 62);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 11;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.BtnLamLai_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(277, 96);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtPassCheck);
            this.Controls.Add(this.lbPassCheck);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbID);
            this.Name = "SignUp";
            this.Text = "Đăng Ký";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPassCheck;
        private System.Windows.Forms.TextBox txtPassCheck;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnBack;
    }
}