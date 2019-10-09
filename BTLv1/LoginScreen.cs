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
    public partial class LoginScreen : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CTJL81R;Database=BTL44a;Integrated Security=False;User Id=sa;Password=31051999;");
        Classv1 connv1 = new Classv1();

        public static string ID_USER = "";
        List<string> list_detail;
        public LoginScreen()
        {
            InitializeComponent();
        }
        private string getID()
        {
            string id = "";
            try
            {
                conn.Open();
                DataTable dt = connv1.readdata("SELECT * FROM User_Login WHERE name_user ='" + txtID.Text + "' AND pass_user = '" + txtPass.Text + "' ");
                
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu hoặc kết nối SQL");
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private string id_CV(string id_user)
        {
            string id = "";
            try
            {
                conn.Open();
                DataTable dt = connv1.readdata("SELECT * FROM User_CHUCVU WHERE id_user_rel = '" + id_user + "'");

                if (dt != null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        if(dr["TrangThai"].ToString() == "True")
                        {
                            id = dr["id_CV_rel"].ToString();
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private List<string> list_CV(string id_CV)
        {
            List<string> termsList = new List<string>();
            try
            {
                conn.Open();
                DataTable dt = connv1.readdata("SELECT * FROM CHUCVU_detail WHERE id_CV ='" + id_CV + "'");
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        termsList.Add(dr["code_action"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return termsList;
        }

        private Boolean checkCV(string code)
        {
            Boolean check = false;
            foreach (string item in list_detail)
            {
                if (item == code)
                {
                    check = true;
                }
            }
            return check;
        }



        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ID_USER = getID();
            if(ID_USER != "")
            {
                MessageBox.Show("Đăng nhập thành công với ID : "+ID_USER+"\n Với phân quyền " + id_CV(ID_USER));
                StaticDataClassv2.classv2s.ID_USER1 = ID_USER;
                Permission per1 = new Permission();
                per1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            list_detail = list_CV(id_CV(ID_USER));
        }

        private void BtnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(null, null);
            }
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(null, null);
            }
        }

        private void ĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnLogin_Click(null, null);
        }

        private void ĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDangKy_Click(null, null);
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnThoat_Click(null, null);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm được làm bởi \n - Nguyễn Quang Anh");
        }
    }
}
