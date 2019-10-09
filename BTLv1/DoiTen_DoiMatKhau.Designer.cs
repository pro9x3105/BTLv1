namespace BTLv1
{
    partial class DoiTen_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNguoiDungHienTai = new System.Windows.Forms.TextBox();
            this.txbMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.txbNguoiDungThayDoi = new System.Windows.Forms.TextBox();
            this.txbMatKhauThayDoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txbNguoiDungHienTai
            // 
            this.txbNguoiDungHienTai.Enabled = false;
            this.txbNguoiDungHienTai.Location = new System.Drawing.Point(99, 43);
            this.txbNguoiDungHienTai.Name = "txbNguoiDungHienTai";
            this.txbNguoiDungHienTai.Size = new System.Drawing.Size(100, 20);
            this.txbNguoiDungHienTai.TabIndex = 5;
            // 
            // txbMatKhauHienTai
            // 
            this.txbMatKhauHienTai.Enabled = false;
            this.txbMatKhauHienTai.Location = new System.Drawing.Point(99, 69);
            this.txbMatKhauHienTai.Name = "txbMatKhauHienTai";
            this.txbMatKhauHienTai.Size = new System.Drawing.Size(100, 20);
            this.txbMatKhauHienTai.TabIndex = 5;
            // 
            // txbNguoiDungThayDoi
            // 
            this.txbNguoiDungThayDoi.Location = new System.Drawing.Point(213, 43);
            this.txbNguoiDungThayDoi.Name = "txbNguoiDungThayDoi";
            this.txbNguoiDungThayDoi.Size = new System.Drawing.Size(100, 20);
            this.txbNguoiDungThayDoi.TabIndex = 1;
            // 
            // txbMatKhauThayDoi
            // 
            this.txbMatKhauThayDoi.Location = new System.Drawing.Point(213, 69);
            this.txbMatKhauThayDoi.Name = "txbMatKhauThayDoi";
            this.txbMatKhauThayDoi.Size = new System.Drawing.Size(100, 20);
            this.txbMatKhauThayDoi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hiện tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thay đổi";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(180, 112);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 8;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Location = new System.Drawing.Point(261, 112);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(75, 23);
            this.btnQuayVe.TabIndex = 9;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(99, 112);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(75, 23);
            this.btnThayDoi.TabIndex = 10;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.BtnThayDoi_Click);
            // 
            // DoiTen_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMatKhauThayDoi);
            this.Controls.Add(this.txbNguoiDungThayDoi);
            this.Controls.Add(this.txbMatKhauHienTai);
            this.Controls.Add(this.txbNguoiDungHienTai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiTen_DoiMatKhau";
            this.Text = "DoiTen_DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiTen_DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNguoiDungHienTai;
        private System.Windows.Forms.TextBox txbMatKhauHienTai;
        private System.Windows.Forms.TextBox txbNguoiDungThayDoi;
        private System.Windows.Forms.TextBox txbMatKhauThayDoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Button btnThayDoi;
    }
}