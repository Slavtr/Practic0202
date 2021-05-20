using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class calendarForm : Form
    {
        public calendarForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string time = "08:00:00";
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            ZpsNTrn zp = new ZpsNTrn();
            zp.Zps(date, time, CnStrPlmrch.sql, UsID.ID);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string time = "09:30:00";
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            ZpsNTrn zp = new ZpsNTrn();
            zp.Zps(date, time, CnStrPlmrch.sql, UsID.ID);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string time = "11:00:00";
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            ZpsNTrn zp = new ZpsNTrn();
            zp.Zps(date, time, CnStrPlmrch.sql, UsID.ID);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string time = "12:30:00";
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            ZpsNTrn zp = new ZpsNTrn();
            zp.Zps(date, time, CnStrPlmrch.sql, UsID.ID);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string time = "14:00:00";
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            ZpsNTrn zp = new ZpsNTrn();
            zp.Zps(date, time, CnStrPlmrch.sql, UsID.ID);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string time = "15:30:00";
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            ZpsNTrn zp = new ZpsNTrn();
            zp.Zps(date, time, CnStrPlmrch.sql, UsID.ID);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            groupBox4.Visible = true;
            groupBox4.Text = e.Start.ToShortDateString();
            ZpsNTrn zp = new ZpsNTrn();
            if (zp.chk(monthCalendar1.SelectionStart.ToShortDateString(), "08:00:00", CnStrPlmrch.sql)) button7.Visible = false;
            else button7.Visible = true;
            if (zp.chk(monthCalendar1.SelectionStart.ToShortDateString(), "09:30:00", CnStrPlmrch.sql)) button8.Visible = false;
            else button8.Visible = true;
            if (zp.chk(monthCalendar1.SelectionStart.ToShortDateString(), "11:00:00", CnStrPlmrch.sql)) button9.Visible = false;
            else button9.Visible = true;
            if (zp.chk(monthCalendar1.SelectionStart.ToShortDateString(), "12:30:00", CnStrPlmrch.sql)) button10.Visible = false;
            else button10.Visible = true;
            if (zp.chk(monthCalendar1.SelectionStart.ToShortDateString(), "14:00:00", CnStrPlmrch.sql)) button11.Visible = false;
            else button11.Visible = true;
            if (zp.chk(monthCalendar1.SelectionStart.ToShortDateString(), "15:30:00", CnStrPlmrch.sql)) button12.Visible = false;
            else button12.Visible = true;
        }

        private void calendarForm_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }
    }
}
