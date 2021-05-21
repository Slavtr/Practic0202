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
    public partial class aboutusForm : Form
    {
        CchZp cz = new CchZp(CnStrPlmrch.sql);
        int Cnb = 0;
        public aboutusForm()
        {
            InitializeComponent();
        }

        private void aboutusForm_Load(object sender, EventArgs e)
        {
            this.Cnb = cz.IDMs[0];
            if (Cnb > cz.IDMs.Last()) this.Cnb = cz.IDMs[0];
            if (Cnb < cz.IDMs[0]) this.Cnb = cz.IDMs.Last();
            try
            {
                pictureBox1.Image = Image.FromStream(cz.PhZp(CnStrPlmrch.sql, Cnb));
            }
            catch
            { }
            label1.Text = cz.FIOZp(CnStrPlmrch.sql, Cnb);
            richTextBox2.Text = cz.FllPsn(CnStrPlmrch.sql, Cnb);
            label2.Text = cz.CZp(CnStrPlmrch.sql, Cnb).ToString() + " руб";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Cnb++;
            if (Cnb > cz.IDMs.Last()) Cnb = cz.IDMs[0];
            if (Cnb < cz.IDMs[0]) this.Cnb = cz.IDMs.Last();
            try
            {
                pictureBox1.Image = Image.FromStream(cz.PhZp(CnStrPlmrch.sql, Cnb));
            }
            catch
            { }
            label1.Text = cz.FIOZp(CnStrPlmrch.sql, Cnb);
            richTextBox2.Text = cz.FllPsn(CnStrPlmrch.sql, Cnb);
            label2.Text = cz.CZp(CnStrPlmrch.sql, Cnb).ToString() + " руб";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Cnb--;
            if (Cnb > cz.IDMs.Last()) this.Cnb = cz.IDMs[0];
            if (Cnb < cz.IDMs[0]) this.Cnb = cz.IDMs.Last();
            try
            {
                pictureBox1.Image = Image.FromStream(cz.PhZp(CnStrPlmrch.sql, Cnb));
            }
            catch
            { }
            label1.Text = cz.FIOZp(CnStrPlmrch.sql, Cnb);
            richTextBox2.Text = cz.FllPsn(CnStrPlmrch.sql, Cnb);
            label2.Text = cz.CZp(CnStrPlmrch.sql, Cnb).ToString() + " руб";
        }
    }
}
