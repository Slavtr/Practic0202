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
        private int countOfWorkouts = 1;
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
       
    }
}
