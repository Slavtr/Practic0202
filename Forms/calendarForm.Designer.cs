
namespace WindowsFormsApp1.Forms
{
    partial class calendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button8 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button10 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button9 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button11 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button12 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(96, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 426);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расписание тренировок";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(62, 59);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button7
            // 
            this.button7.Animated = true;
            this.button7.CheckedState.Parent = this.button7;
            this.button7.CustomImages.Parent = this.button7;
            this.button7.FillColor = System.Drawing.Color.DarkGray;
            this.button7.FillColor2 = System.Drawing.Color.Silver;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.HoverState.Parent = this.button7;
            this.button7.Location = new System.Drawing.Point(300, 19);
            this.button7.Name = "button7";
            this.button7.ShadowDecoration.Parent = this.button7;
            this.button7.Size = new System.Drawing.Size(300, 60);
            this.button7.TabIndex = 12;
            this.button7.Text = "8:00 -9:30";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Animated = true;
            this.button8.CheckedState.Parent = this.button8;
            this.button8.CustomImages.Parent = this.button8;
            this.button8.FillColor = System.Drawing.Color.DarkGray;
            this.button8.FillColor2 = System.Drawing.Color.Silver;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.HoverState.Parent = this.button8;
            this.button8.Location = new System.Drawing.Point(300, 85);
            this.button8.Name = "button8";
            this.button8.ShadowDecoration.Parent = this.button8;
            this.button8.Size = new System.Drawing.Size(300, 60);
            this.button8.TabIndex = 13;
            this.button8.Text = "9:30 -11:00";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Animated = true;
            this.button10.CheckedState.Parent = this.button10;
            this.button10.CustomImages.Parent = this.button10;
            this.button10.FillColor = System.Drawing.Color.DarkGray;
            this.button10.FillColor2 = System.Drawing.Color.Silver;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.HoverState.Parent = this.button10;
            this.button10.Location = new System.Drawing.Point(300, 217);
            this.button10.Name = "button10";
            this.button10.ShadowDecoration.Parent = this.button10;
            this.button10.Size = new System.Drawing.Size(300, 60);
            this.button10.TabIndex = 15;
            this.button10.Text = "12:30 -14:00";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Animated = true;
            this.button9.CheckedState.Parent = this.button9;
            this.button9.CustomImages.Parent = this.button9;
            this.button9.FillColor = System.Drawing.Color.DarkGray;
            this.button9.FillColor2 = System.Drawing.Color.Silver;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.HoverState.Parent = this.button9;
            this.button9.Location = new System.Drawing.Point(300, 151);
            this.button9.Name = "button9";
            this.button9.ShadowDecoration.Parent = this.button9;
            this.button9.Size = new System.Drawing.Size(300, 60);
            this.button9.TabIndex = 14;
            this.button9.Text = "11:00-12:30";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.Animated = true;
            this.button11.CheckedState.Parent = this.button11;
            this.button11.CustomImages.Parent = this.button11;
            this.button11.FillColor = System.Drawing.Color.DarkGray;
            this.button11.FillColor2 = System.Drawing.Color.Silver;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.HoverState.Parent = this.button11;
            this.button11.Location = new System.Drawing.Point(300, 283);
            this.button11.Name = "button11";
            this.button11.ShadowDecoration.Parent = this.button11;
            this.button11.Size = new System.Drawing.Size(300, 60);
            this.button11.TabIndex = 16;
            this.button11.Text = "14:00 -15:30";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Статистика";
            // 
            // button12
            // 
            this.button12.Animated = true;
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.CheckedState.Parent = this.button12;
            this.button12.CustomImages.Parent = this.button12;
            this.button12.FillColor = System.Drawing.Color.DarkGray;
            this.button12.FillColor2 = System.Drawing.Color.Silver;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.HoverState.Parent = this.button12;
            this.button12.Location = new System.Drawing.Point(300, 349);
            this.button12.Name = "button12";
            this.button12.ShadowDecoration.Parent = this.button12;
            this.button12.Size = new System.Drawing.Size(300, 60);
            this.button12.TabIndex = 17;
            this.button12.Text = "15:30 -17:00";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 426);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дата:";
            // 
            // calendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(818, 561);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calendarForm";
            this.Text = "calendarForm";
            this.Load += new System.EventHandler(this.calendarForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Guna.UI2.WinForms.Guna2GradientButton button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2GradientButton button12;
        private Guna.UI2.WinForms.Guna2GradientButton button11;
        private Guna.UI2.WinForms.Guna2GradientButton button10;
        private Guna.UI2.WinForms.Guna2GradientButton button9;
        private Guna.UI2.WinForms.Guna2GradientButton button8;
        private System.Windows.Forms.Label label6;
    }
}