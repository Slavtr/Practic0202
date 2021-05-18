﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_0202
{
    public delegate void LoadFormDotShowHere();
    public class LGPlmrch
    {
        public event LoadFormDotShowHere SbstvLG;
        void ShwSbstvLG()
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
            PSCPlmrch ps = new PSCPlmrch(password);
            return ps.PasCrypt;
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
    public class PSCPlmrch
    {
        string password;
        public int PasCrypt
        {
            get { return password.GetHashCode(); }
        }
        public PSCPlmrch(string password)
        {
            this.password = password;
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
            PSCPlmrch ps = new PSCPlmrch(password);
            return ps.PasCrypt;
        }
        bool RGCheck(string login, int password, string sql)
        {
            bool ret = false;
            int rowsaff = 0;
            SqlConnection sq = new SqlConnection(sql);
            SqlCommand cm = new SqlCommand(@"select count(*) from User where Login = @LG or Password = @PS", sq);
            cm.Parameters.AddWithValue("@LG", login);
            cm.Parameters.AddWithValue("@PS", password);
            try
            {
                using (SqlDataReader sr = cm.ExecuteReader())
                {
                    rowsaff = (int)cm.ExecuteScalar();
                }
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
            SqlCommand cm = new SqlCommand(@"select ID from User", sq);
            try
            {
                using (SqlDataReader sr = cm.ExecuteReader())
                {
                    lastind = (int)cm.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return lastind + 1;
        }
        void UsReg(string surname, string name, string patronus, string login, int password, string secret_word, int access_lvl, string sql)
        {
            if(RGCheck(login, password, sql))
            {
                int id = LstUsNmbr(sql);
                SqlConnection sq = new SqlConnection(sql);
                SqlCommand cm = new SqlCommand(@"insert into User values (@id, @sur, @nam, @patr, @log, @pas, @sw, @acc) ", sq);
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
                    using (SqlDataReader sr = cm.ExecuteReader())
                    {
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Регистрация удачна");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Регистрация неудачна из-за следующей ошибки:\n"+e.Message);
                }
            }
            else
            {
                MessageBox.Show("Такой логин или пароль уже зарегистрирован");
            }
        }
    }
}
