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
    public partial class Permission : Form
    {
        private string a = "";
        List<Classv2> classv2s = new List<Classv2>();
        
        public Permission()
        {
            InitializeComponent();
            classv2s = StaticDataClassv2.classv2s;
        }

        private void BtnNhap_Click(object sender, EventArgs e)
        {
            a = Convert.ToString(classv2s[0]);
            MessageBox.Show("" +a);
        }
    }
}
