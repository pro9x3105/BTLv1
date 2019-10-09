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
    public partial class DoiTen_DoiMatKhau : Form
    {
        Classv1 connv1 = new Classv1();
        private string a = "";
        private string mahoa = "";
        public static string ten = "";
        public static string mk = "";
        public DoiTen_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void BtnThayDoi_Click(object sender, EventArgs e)
        {
            ten = txbNguoiDungThayDoi.Text;
            mk = txbMatKhauThayDoi.Text;
            DoiTen_DoiMatKhau_Check formCheck1 = new DoiTen_DoiMatKhau_Check();
            formCheck1.Show();
            this.Close();
            
        }

        private void DoiTen_DoiMatKhau_Load(object sender, EventArgs e)
        {
            a = LoginScreen.ID_USER;
            DataTable dt = connv1.readdata("SELECT * FROM User_Login LEFT JOIN NHANVIEN ON id_user=MaNV WHERE id_user='" + a + "'");
            for (int i = 1; i <= dt.Rows[0]["pass_user"].ToString().Length; i++)
            {
                mahoa += "*";
            }
            txbNguoiDungHienTai.Text = dt.Rows[0]["TenNV"].ToString();
            txbMatKhauHienTai.Text = mahoa;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txbMatKhauThayDoi.Text = "";
            txbNguoiDungThayDoi.Text = "";
        }
    }
}
