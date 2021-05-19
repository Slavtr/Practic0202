﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Guna2GradientButton currentButton;
        private Guna2TrackBar currentTrackBar;
        private Form activeForm;
        
        public Form1()
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

        private void SetPositionOfTrackBar(Guna2TrackBar trackBar)
        {
            if (trackBar != null)
            {
            }
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
    }
}