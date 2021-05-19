using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_0202
{
    public delegate void LoadFormDotShowHere();
    public class LGPlmrch
    {
        event LoadFormDotShowHere SbstvLG;
        void ShwSbstvLG()
        {
            if (SbstvLG != null)
                SbstvLG();
        }
        public LGPlmrch(string login, string password, string sql, LoadFormDotShowHere lfdsh)
        {
            SbstvLG += lfdsh;
            CtvFrm(LG(login, Gthshps(password), sql));
        }
        int Gthshps(string password)
        {
            PSCPlmrch.password = password;
            return PSCPlmrch.PasCrypt;
        }
        int LG(string login, int password, string sql)
        {
            int rowsaff = -1;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select ID from dbo.[User] where Login = @LG and Password = @PS", sq);
            cm.Parameters.AddWithValue("@LG", login);
            cm.Parameters.AddWithValue("@PS", password);
            try
            {
                sq.Open();
                if(cm.ExecuteScalar()!= null)
                {
                    rowsaff = (int)cm.ExecuteScalar();
                }
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            UsID.ID = rowsaff;
            return rowsaff;
        }
        void CtvFrm(int strCnt)
        {
            if (strCnt != -1) ShwSbstvLG();
            else MessageBox.Show("Неправильный логин или пароль.\nПовторите ввод.");
        }
    }
    public static class PSCPlmrch
    {
        public static string password;
        public static int PasCrypt
        {
            get { return password.GetHashCode(); }
        }
    }
    public class RGPlmrch
    {
        public RGPlmrch(string surname, string name, string patronus, string login, string password, string secret_word, int access_lvl, string sql)
        {
            UsReg(surname, name, patronus, login, Gthshps(password), secret_word, access_lvl, sql);
        }
        int Gthshps(string password)
        {
            PSCPlmrch.password = password;
            return PSCPlmrch.PasCrypt;
        }
        bool RGCheck(string login, int password, string sql)
        {
            bool ret = false;
            int rowsaff = 0;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select count(*) from dbo.[User] where Login = @LG or Password = @PS", sq);
            cm.Parameters.AddWithValue("@LG", login);
            cm.Parameters.AddWithValue("@PS", password);
            try
            {
                sq.Open();
                rowsaff = (int)cm.ExecuteScalar();
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (rowsaff != -1 && rowsaff != 0) ret = true;
            return ret;
        }
        int LstUsNmbr(string sql)
        {
            int lastind = -1;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select top 1 ID from dbo.[User] order by ID DESC", sq);
            try
            {
                sq.Open();
                lastind = (int)cm.ExecuteScalar();
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return lastind + 1;
        }
        void UsReg(string surname, string name, string patronus, string login, int password, string secret_word, int access_lvl, string sql)
        {
            if (!RGCheck(login, password, sql))
            {
                int id = LstUsNmbr(sql);
                SqlConnection sq = new SqlConnection(sql);
                SqlCommand cm = new SqlCommand(@"insert into dbo.[User] values (@id, @sur, @nam, @patr, @log, @pas, @sw, @acc) ", sq);
                cm.Parameters.AddWithValue("@id", id);
                cm.Parameters.AddWithValue("@sur", surname);
                cm.Parameters.AddWithValue("@nam", name);
                cm.Parameters.AddWithValue("@patr", patronus);
                cm.Parameters.AddWithValue("@log", login);
                cm.Parameters.AddWithValue("@pas", password);
                cm.Parameters.AddWithValue("@sw", secret_word);
                cm.Parameters.AddWithValue("@acc", access_lvl);
                try
                {
                    sq.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Регистрация удачна");
                    sq.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Регистрация неудачна из-за следующей ошибки:\n" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Такой логин или пароль уже зарегистрирован");
            }
        }
    }
    public static class CnStrPlmrch
    {
        public static string sql
        {
            get { return @"Data Source=sql;Initial Catalog=2021-МДК02.02-УП-Паламарчук;Integrated Security=True"; }
        }
        public static string xcl
        {
            get { return ""; }
        }
    }
    public static class UsID
    {
        public static int ID;
    }
    public class ZpLstBxPsn
    {
        public List<string> RtStrMs(string sql)
        {
            SqlConnection sq = new SqlConnection(sql);
            SqlDataAdapter cm = new SqlDataAdapter(@"select * from dbo.[Training]", sq);
            DataTable dt = new DataTable();
            try
            {
                sq.Open();
                cm.Fill(dt);
                sq.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            List<string> ls = new List<string>();
            foreach(DataRow dr in dt.Rows)
            {
                ls.Add(dr[1].ToString());
            }
            return ls;
        }
        public DataTable FllDGV(string sql, int user)
        {
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand c = new SqlCommand(@"select * from dbo.[TrDiary] where UsID = @U", sq);
            c.Parameters.AddWithValue("@U", user);
            SqlDataAdapter cm = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            try
            {
                sq.Open();
                cm.Fill(dt);
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
        public string FllPsn(string sql, string train_name)
        {
            string ret = "";
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"Select Describ from dbo.[Training] where Name = @N", sq);
            cm.Parameters.AddWithValue("@N", train_name);

            try
            {
                sq.Open();
                ret = (string)cm.ExecuteScalar();
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ret;
        }
    }
    public class ZpsNTrn
    {
        public bool chk(string dtSt, string tm, string sql)
        {
            int rowsaff = 0;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"Select count(*) from dbo.[Timetable] where Date = @Dt and Time = @Tm", sq);
            cm.Parameters.AddWithValue("@Dt", dtSt);
            cm.Parameters.AddWithValue("@Tm", tm);
            try
            {
                sq.Open();
                rowsaff = (int)cm.ExecuteScalar();
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (rowsaff != -1 && rowsaff != 0) return true;
            else return false;
        }
        int lstid(string sql)
        {
            int ret = -1;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select top 1 ID from dbo.[Timetable] order by ID DESC", sq);
            try
            {
                sq.Open();
                ret = (int)cm.ExecuteScalar();
                sq.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            ret++;
            return ret;
        }
        public void Zps(string dtSt, string tm, string sql, int user)
        {
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"Insert into dbo.[Timetable] values (@ID, @UsID, @Date, @Time)", sq);
            cm.Parameters.AddWithValue("@ID", lstid(sql));
            cm.Parameters.AddWithValue("@UsID", user);
            cm.Parameters.AddWithValue("@Date", dtSt);
            cm.Parameters.AddWithValue("@Time", tm);
            try
            {
                sq.Open();
                cm.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("Запись успешна");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
    public class CchZp
    {
        public int[] IDMs;
        public CchZp(string sql)
        {
            this.IDMs = IDMsZp(sql);
        }
        int[] IDMsZp(string sql)
        {
            int[] ret = new int[0];
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select ID from dbo.[Coach]", sq);
            SqlDataReader dr = cm.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    Array.Resize(ref ret, ret.Length + 1);
                    ret[ret.Length - 1] = (int)dr[ret.Length - 1];
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ret;
        }
        public string FllPsn(string sql, int CID)
        {
            string ret = "";
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"Select Describtion from dbo.[Coach] where ID = @N", sq);
            cm.Parameters.AddWithValue("@N", CID);
            try
            {
                sq.Open();
                ret = (string)cm.ExecuteScalar();
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ret;
        }
        public string FIOZp(string sql, int CID)
        {
            string ret = "";
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"Select concat(Surname, ' ', Name, ' ', Patronym) from dbo.[Coach] where ID = @N", sq);
            cm.Parameters.AddWithValue("@N", CID);
            try
            {
                sq.Open();
                ret = (string)cm.ExecuteScalar();
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ret;
        }
        public object PhZp(string sql, int CID)
        {
            object ph = null;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select Photo from dbo.[Coach] where ID = @N", sq);
            cm.Parameters.AddWithValue("@N", CID);
            try
            {
                sq.Open();
                ph = (string)cm.ExecuteScalar();
                sq.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ph;
        }
    }
}
