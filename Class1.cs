using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_0202
{
    public delegate void Vobla();
    public class LGPlmrch
    {
        public event Vobla SbstvLG;
        public void ShwSbstvLG()
        {
            if (SbstvLG != null)
                SbstvLG();
        }
        public LGPlmrch(string login, string password, string sql)
        {
            CtvFrm(LG(login, Gthshps(password), sql));
        }
        int Gthshps(string password)
        {
            return password.GetHashCode();
        }
        int LG(string login, int password, string sql)
        {
            int rowsaff = 0;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select count(*) from User where Login = @LG and Password = @PS", sq);
            cm.Parameters.AddWithValue("@LG", login);
            cm.Parameters.AddWithValue("@PS", password);
            try
            {
                using (SqlDataReader sr = cm.ExecuteReader())
                {
                    rowsaff = (int)cm.ExecuteScalar();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return rowsaff;
        }
        void CtvFrm(int strCnt)
        {
            if (strCnt != 0 && strCnt != -1) ShwSbstvLG();
        }
    }

    public class RGPlmrch
    {

    }
}
