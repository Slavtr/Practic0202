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
            texts.Add(nameTextBox.Text);
            texts.Add(thirdNameTextBox.Text);
            texts.Add(secondNameTextBox.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passTextBox1.Text != passTextBox2.Text)
                {
                    throw new Exception("Пароль не совпадает");
                }
                RGPlmrch rg = new RGPlmrch(secondNameTextBox.Text, nameTextBox.Text, thirdNameTextBox.Text, emailTextBox.Text, passTextBox1.Text, "a", 0, CnStrPlmrch.sql);
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
            emailTextBox.ForeColor = Color.DimGray;
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Length == 0)
            {
                emailTextBox.ForeColor = Color.Silver;
                emailTextBox.Text = (string)texts[0];
            }
        }

        private void passTextBox1_Enter(object sender, EventArgs e)
        {
            if (passTextBox1.Text == (string)texts[1])
            {
                passTextBox1.Clear();
            }
            passTextBox1.ForeColor = Color.DimGray;
        }

        private void passTextBox1_Leave(object sender, EventArgs e)
        {
            if (passTextBox1.Text.Length == 0)
            {
                passTextBox1.ForeColor = Color.Silver;
                passTextBox1.Text = (string)texts[1];
            }
        }

        private void passTextBox2_Enter(object sender, EventArgs e)
        {
            if (passTextBox2.Text == (string)texts[2])
            {
                passTextBox2.Clear();
            }
            passTextBox2.ForeColor = Color.DimGray;
        }

        private void passTextBox2_Leave(object sender, EventArgs e)
        {
            if (passTextBox2.Text.Length == 0)
            {
                passTextBox2.ForeColor = Color.Silver;
                passTextBox2.Text = (string)texts[2];
            }
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == (string)texts[3])
            {
                nameTextBox.Clear();
            }
            nameTextBox.ForeColor = Color.DimGray;
        }
        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                nameTextBox.ForeColor = Color.Silver;
                nameTextBox.Text = (string)texts[3];
            }
        }

        private void secondNameTextBox_Enter(object sender, EventArgs e)
        {
            if (secondNameTextBox.Text == (string)texts[5])
            {
                secondNameTextBox.Clear();
            }
            secondNameTextBox.ForeColor = Color.DimGray;
        }

        private void secondNameTextBox_Leave(object sender, EventArgs e)
        {
            if (secondNameTextBox.Text.Length == 0)
            {
                secondNameTextBox.ForeColor = Color.Silver;
                secondNameTextBox.Text = (string)texts[5];
            }
        }

        private void thirdNameTextBox_Enter(object sender, EventArgs e)
        {
            if (thirdNameTextBox.Text == (string)texts[4])
            {
                thirdNameTextBox.Clear();
            }
            thirdNameTextBox.ForeColor = Color.DimGray;
        }

        private void thirdNameTextBox_Leave(object sender, EventArgs e)
        {
            if (thirdNameTextBox.Text.Length == 0)
            {
                thirdNameTextBox.ForeColor = Color.Silver;
                thirdNameTextBox.Text = (string)texts[4];
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
