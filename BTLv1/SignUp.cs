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
    public partial class SignUp : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CTJL81R;Database=BTL44a;Integrated Security=False;User Id=sa;Password=31051999;");
        Classv1 connv1 = new Classv1();

        public SignUp()
        {
            InitializeComponent();
        }


        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            DataTable dt = connv1.readdata("SELECT * FROM User_Login");
            int check = 1;
            if (txtID.Text == "" || txtPass.Text == "" || txtPassCheck.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin", "Thông báo");
                check = 0;
            }
            if (txtPass.Text != txtPassCheck.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại chưa đúng");
                txtPassCheck.Text = "";
                txtPassCheck.Focus();
                check = 0;
            }
            else
            {
                if (check != 0 && dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtID.Text == dr["name_user"].ToString())
                        {
                            check = 2;
                        }
                    }


                    if (check == 1 && connv1.exedata("INSERT INTO User_Login (id_user,name_user,pass_user) VALUES ('" + (dt.Rows.Count + 1) + "', '" + txtID.Text + "','" + txtPass.Text + "')") == true)
                    {
                        MessageBox.Show("Đăng Ký Thành Công");
                    }
                    else if(check == 2)
                    {
                        MessageBox.Show("Đăng Ký Thất Bại do đã có tên trong CSDL");
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LoginScreen main1 = new LoginScreen();
            this.Hide();
            main1.Show();
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPass.Text = "";
            txtPassCheck.Text = "";
        }
    }
}
