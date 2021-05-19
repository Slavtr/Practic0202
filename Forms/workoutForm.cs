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
    public partial class workoutForm : Form
    {
        private int countOfWorkouts = 1;
        public workoutForm()
        {
            InitializeComponent();
        }

        //private void CreateObjectList()
        
        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

            guna2TrackBar1.Value = 70;

        }
    }
}
