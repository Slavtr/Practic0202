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
    public partial class registrationForm : Form
    {
        ArrayList texts = new ArrayList();

        public registrationForm()
        {
            InitializeComponent();
            texts.Add(emailTextBox.Text);
            texts.Add(passTextBox1.Text);
            texts.Add(passTextBox2.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            new menuForm().Show();
            this.Hide();
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == (string)texts[0])
            {
                emailTextBox.Clear();
            }

        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Length == 0)
            {
                emailTextBox.Text = (string)texts[0];
            }

        }

        private void passTextBox1_Enter(object sender, EventArgs e)
        {
            if (passTextBox1.Text == (string)texts[1])
            {
                passTextBox1.Clear();
            }

        }

        private void passTextBox1_Leave(object sender, EventArgs e)
        {
            if (passTextBox1.Text.Length == 0)
            {
                passTextBox1.Text = (string)texts[1];
            }

        }

        private void passTextBox2_Enter(object sender, EventArgs e)
        {
            if (passTextBox2.Text == (string)texts[2])
            {
                passTextBox2.Clear();
            }

        }

        private void passTextBox2_Leave(object sender, EventArgs e)
        {
            if (passTextBox2.Text.Length == 0)
            {
                passTextBox2.Text = (string)texts[2];
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
