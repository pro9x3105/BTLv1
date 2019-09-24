using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTLv1
{
    class Classv1
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CTJL81R;Database=BTL44a;Integrated Security=False;User Id=sa;Password=31051999;");

        public Boolean exedata(string cmd)
        {
            conn.Open();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            conn.Close();
            return check;
        }

        public DataTable readdata(string cmd)
        {
            conn.Open();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            conn.Close();
            return da;
        }

    }
}
