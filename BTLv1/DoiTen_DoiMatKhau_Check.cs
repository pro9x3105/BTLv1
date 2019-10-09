using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLv1
{
    public partial class DoiTen_DoiMatKhau_Check : Form
    {
        Classv1 connv1 = new Classv1();
        private string a = "";
        public static Boolean checkTKMK = false;
        private string ten = DoiTen_DoiMatKhau.ten;
        private string mk = DoiTen_DoiMatKhau.mk;

        public DoiTen_DoiMatKhau_Check()
        {
            InitializeComponent();
            a = LoginScreen.ID_USER;
            DataTable dt = connv1.readdata("SELECT * FROM User_Login WHERE id_user='" + a + "'");
            txbTaiKhoan.Text = dt.Rows[0]["name_user"].ToString();
        }



        private void BtnKiemTra_Click(object sender, EventArgs e)
        {
            DataTable dt = connv1.readdata("SELECT * FROM User_Login WHERE id_user='" + a + "'");
            if (txbMatKhau.Text.Equals(dt.Rows[0]["pass_user"].ToString()))
            {
                if (ten != "")
                {
                    connv1.exedata("UPDATE NHANVIEN SET TenNV='" + ten + "' WHERE MaNV='" + a + "'");
                }
                connv1.exedata("UPDATE User_Login SET pass_user='" + mk + "' WHERE id_user='" + a + "'");
                MessageBox.Show("Bạn đã thay đổi thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập sai mật khẩu hiện tại");
                txbMatKhau.Text = "";
                txbMatKhau.Focus();
            }
        }

        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            DoiTen_DoiMatKhau formmain1 = new DoiTen_DoiMatKhau();
            formmain1.Show();
            this.Close();
        }
    }
}
