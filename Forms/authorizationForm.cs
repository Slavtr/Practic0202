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


        private void enterButton_Click(object sender, EventArgs e)
        {
            menuForm ms = new menuForm();
            LoadFormDotShowHere fs = ms.Show;
            fs += this.Hide;
            LGPlmrch lg = new LGPlmrch(emailTextBox.Text, passTextBox.Text, CnStrPlmrch.sql, fs);
        }

        private void registationLabel_Click(object sender, EventArgs e)
        {
            new registrationForm().Show();
            this.Hide();
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if(emailTextBox.Text == (string)texts[0])
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

        private void passTextBox_Enter(object sender, EventArgs e)
        {
            if (passTextBox.Text== (string)texts[1])
            {
                passTextBox.Clear();
            }
            passTextBox.ForeColor = Color.DimGray;

        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text.Length == 0)
            {
                passTextBox.ForeColor = Color.Silver;
                passTextBox.Text = (string)texts[1];
            }

        }

        private void registationLabel_MouseEnter(object sender, EventArgs e)
        {
            registationLabel.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline);
        }

        private void registationLabel_MouseLeave(object sender, EventArgs e)
        {
            registationLabel.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
