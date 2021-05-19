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
    public partial class authorizationForm : Form
    {
        ArrayList texts = new ArrayList();
        public authorizationForm()
        {
            InitializeComponent();
            texts.Add(emailTextBox.Text);
            texts.Add(passTextBox.Text);
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void workoutButton_Click(object sender, EventArgs e)
        {
            new menuForm().Show();
            this.Hide();
        }

    }
}
