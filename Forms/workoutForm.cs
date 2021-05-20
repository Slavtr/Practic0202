using System;
using System.Collections;
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
    public partial class workoutForm : Form
    {
        ArrayList images = new ArrayList();
        public workoutForm()
        {
            CreateBitmapList();
            InitializeComponent();
        }

        private ArrayList CreateBitmapList()
        {
            images.Add(Properties.Resources.calendar__v1);
            return images;
        }

        private void workoutForm_Load(object sender, EventArgs e)
        {
            ZpLstBxPsn zp = new ZpLstBxPsn();
            try
            {
                guna2PictureBox1.Image = Image.FromStream(zp.PhZp(CnStrPlmrch.sql, guna2ComboBox1.SelectedText));
            }
            catch { }
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.DataSource = zp.RtStrMs(CnStrPlmrch.sql);
            table.DataSource = zp.FllDGV(CnStrPlmrch.sql, UsID.ID);
            guna2TextBox1.Text = zp.FllPsn(CnStrPlmrch.sql, guna2ComboBox1.SelectedItem.ToString());
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZpLstBxPsn zp = new ZpLstBxPsn();
            guna2TextBox1.Text = zp.FllPsn(CnStrPlmrch.sql, guna2ComboBox1.SelectedItem.ToString());
        }
    }
}
