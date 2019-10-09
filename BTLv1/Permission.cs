using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTLv1
{
    public partial class Permission : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CTJL81R;Database=BTL44a;Integrated Security=False;User Id=sa;Password=31051999;");
        Classv1 connv1 = new Classv1();
        private string a = "";
        private string b = "";

        public Permission()
        {
            InitializeComponent();
        }

        private void BtnNhap_Click(object sender, EventArgs e)
        {
            a = LoginScreen.ID_USER;
            b = StaticDataClassv2.classv2s.ID_USER1;
            MessageBox.Show("" +a+" | "+b);
        }

        private void Permission_Load(object sender, EventArgs e)
        {
            a = LoginScreen.ID_USER;
            b = StaticDataClassv2.classv2s.ID_USER1;
            DataTable dt = connv1.readdata("SELECT * FROM User_Login LEFT JOIN NHANVIEN ON id_user=MaNV LEFT JOIN User_CHUCVU ON id_user=id_user_rel LEFT JOIN CHUCVU ON id_CV_rel=id_CV WHERE id_user='"+b+"'");
            if (dt != null)
            {
                label1.Text = "Bạn đã đăng nhập với tên : "+dt.Rows[0]["TenNV"].ToString();
                label2.Text = "Chức vụ : " + dt.Rows[0]["name_CV"].ToString();
            }
            else
            {
                MessageBox.Show("Lỗi r");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiTen_DoiMatKhau formThaydoi = new DoiTen_DoiMatKhau();
            formThaydoi.Show();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen formLogin = new LoginScreen();
            formLogin.Show();
            this.Close(); 
        }
    }
}
