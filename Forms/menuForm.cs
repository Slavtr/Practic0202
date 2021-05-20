using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class menuForm : Form
    {
        private Guna2GradientButton currentButton;
        private Form activeForm;
        
        public menuForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender)
        {
            Reset();
            if (sender != null)
            {
                if (currentButton != (Guna2GradientButton)sender)
                {
                    currentButton = (Guna2GradientButton)sender;
                    currentButton.BackColor = Color.Gray;
                }
            }
        }
        private void Reset()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2GradientButton))
                {
                    previousBtn.BackColor = Color.Transparent;
                }
            }
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPannel.Controls.Add(childForm);
            childForm.Show();   
        }

        private void workoutButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.workoutForm(), sender);
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.calendarForm(), sender);
        }

        private void aboutusButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.aboutusForm(), sender);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new authorizationForm().Show();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            guna2Button2.Text = UsID.UsNm(CnStrPlmrch.sql);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
