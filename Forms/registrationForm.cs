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
            texts.Add(guna2TextBox2.Text);
            texts.Add(guna2TextBox1.Text);
            texts.Add(guna2TextBox3.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passTextBox1.Text != passTextBox2.Text)
                {
                    throw new Exception("Пароль не совпадает");
                }
                RGPlmrch rg = new RGPlmrch(guna2TextBox3.Text, guna2TextBox2.Text, guna2TextBox1.Text, emailTextBox.Text, passTextBox1.Text, "a", 0, CnStrPlmrch.sql);
            }
            catch(Exception exc)
            {
                label1.Text = exc.Message;
            }
            menuForm au = new menuForm();
            LoadFormDotShowHere fs = au.Show;
            fs += this.Hide;
            LGPlmrch lg = new LGPlmrch(emailTextBox.Text, passTextBox1.Text, CnStrPlmrch.sql, fs);
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

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == (string)texts[3])
            {
                guna2TextBox2.Clear();
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length == 0)
            {
                guna2TextBox1.Text = (string)texts[4];
            }
        }

        private void guna2TextBox3_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == (string)texts[5])
            {
                guna2TextBox3.Clear();
            }
        }

        private void guna2TextBox3_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text.Length == 0)
            {
                guna2TextBox3.Text = (string)texts[5];
            }
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == (string)texts[4])
            {
                guna2TextBox1.Clear();
            }
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text.Length == 0)
            {
                guna2TextBox2.Text = (string)texts[3];
            }
        }
    }
}
