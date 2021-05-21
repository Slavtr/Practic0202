
namespace WindowsFormsApp1.Forms
{
    partial class personalForm
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
            this.enterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.AutoRoundedCorners = true;
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.BorderColor = System.Drawing.Color.Silver;
            this.enterButton.BorderRadius = 21;
            this.enterButton.CheckedState.Parent = this.enterButton;
            this.enterButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.enterButton.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.enterButton.CustomImages.Parent = this.enterButton;
            this.enterButton.FillColor = System.Drawing.Color.DarkGray;
            this.enterButton.FillColor2 = System.Drawing.Color.LightGray;
            this.enterButton.Font = new System.Drawing.Font("Furore", 10F, System.Drawing.FontStyle.Italic);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.HoverState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.enterButton.HoverState.FillColor2 = System.Drawing.SystemColors.ControlDark;
            this.enterButton.HoverState.Parent = this.enterButton;
            this.enterButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.enterButton.Location = new System.Drawing.Point(280, 448);
            this.enterButton.Name = "enterButton";
            this.enterButton.PressedColor = System.Drawing.Color.DimGray;
            this.enterButton.ShadowDecoration.Parent = this.enterButton;
            this.enterButton.Size = new System.Drawing.Size(246, 45);
            this.enterButton.TabIndex = 20;
            this.enterButton.Text = "Изменить";
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.AutoRoundedCorners = true;
            this.textBox4.BackColor = System.Drawing.Color.Transparent;
            this.textBox4.BorderRadius = 17;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.DefaultText = "Имя";
            this.textBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox4.DisabledState.Parent = this.textBox4;
            this.textBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox4.FocusedState.Parent = this.textBox4;
            this.textBox4.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox4.ForeColor = System.Drawing.Color.Silver;
            this.textBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox4.HoverState.Parent = this.textBox4;
            this.textBox4.Location = new System.Drawing.Point(143, 234);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '\0';
            this.textBox4.PlaceholderText = "";
            this.textBox4.SelectedText = "";
            this.textBox4.SelectionStart = 3;
            this.textBox4.ShadowDecoration.Parent = this.textBox4;
            this.textBox4.Size = new System.Drawing.Size(241, 37);
            this.textBox4.TabIndex = 33;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AutoRoundedCorners = true;
            this.textBox3.BackColor = System.Drawing.Color.Transparent;
            this.textBox3.BorderRadius = 17;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.DefaultText = "Фамилия";
            this.textBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox3.DisabledState.Parent = this.textBox3;
            this.textBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox3.FocusedState.Parent = this.textBox3;
            this.textBox3.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox3.HoverState.Parent = this.textBox3;
            this.textBox3.Location = new System.Drawing.Point(143, 292);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.PlaceholderText = "";
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionStart = 7;
            this.textBox3.ShadowDecoration.Parent = this.textBox3;
            this.textBox3.Size = new System.Drawing.Size(241, 37);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AutoRoundedCorners = true;
            this.textBox5.BackColor = System.Drawing.Color.Transparent;
            this.textBox5.BorderRadius = 17;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.DefaultText = "Отчество";
            this.textBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox5.DisabledState.Parent = this.textBox5;
            this.textBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox5.FocusedState.Parent = this.textBox5;
            this.textBox5.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox5.ForeColor = System.Drawing.Color.Silver;
            this.textBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox5.HoverState.Parent = this.textBox5;
            this.textBox5.Location = new System.Drawing.Point(143, 348);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '\0';
            this.textBox5.PlaceholderText = "";
            this.textBox5.SelectedText = "";
            this.textBox5.SelectionStart = 8;
            this.textBox5.ShadowDecoration.Parent = this.textBox5;
            this.textBox5.Size = new System.Drawing.Size(241, 37);
            this.textBox5.TabIndex = 34;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.AutoRoundedCorners = true;
            this.textBox8.BackColor = System.Drawing.Color.Transparent;
            this.textBox8.BorderRadius = 17;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox8.DefaultText = "Повторите пароль";
            this.textBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox8.DisabledState.Parent = this.textBox8;
            this.textBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox8.FocusedState.Parent = this.textBox8;
            this.textBox8.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox8.ForeColor = System.Drawing.Color.Silver;
            this.textBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox8.HoverState.Parent = this.textBox8;
            this.textBox8.Location = new System.Drawing.Point(445, 348);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.PasswordChar = '\0';
            this.textBox8.PlaceholderText = "";
            this.textBox8.SelectedText = "";
            this.textBox8.SelectionStart = 16;
            this.textBox8.ShadowDecoration.Parent = this.textBox8;
            this.textBox8.Size = new System.Drawing.Size(241, 37);
            this.textBox8.TabIndex = 31;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.AutoRoundedCorners = true;
            this.textBox7.BackColor = System.Drawing.Color.Transparent;
            this.textBox7.BorderRadius = 17;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.DefaultText = "Пароль";
            this.textBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox7.DisabledState.Parent = this.textBox7;
            this.textBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox7.FocusedState.Parent = this.textBox7;
            this.textBox7.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox7.ForeColor = System.Drawing.Color.Silver;
            this.textBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox7.HoverState.Parent = this.textBox7;
            this.textBox7.Location = new System.Drawing.Point(445, 292);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '\0';
            this.textBox7.PlaceholderText = "";
            this.textBox7.SelectedText = "";
            this.textBox7.SelectionStart = 6;
            this.textBox7.ShadowDecoration.Parent = this.textBox7;
            this.textBox7.Size = new System.Drawing.Size(241, 37);
            this.textBox7.TabIndex = 29;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.AutoRoundedCorners = true;
            this.textBox6.BackColor = System.Drawing.Color.Transparent;
            this.textBox6.BorderRadius = 17;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.DefaultText = "Логин";
            this.textBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox6.DisabledState.Parent = this.textBox6;
            this.textBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox6.FocusedState.Parent = this.textBox6;
            this.textBox6.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox6.ForeColor = System.Drawing.Color.Silver;
            this.textBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox6.HoverState.Parent = this.textBox6;
            this.textBox6.Location = new System.Drawing.Point(445, 234);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '\0';
            this.textBox6.PlaceholderText = "";
            this.textBox6.SelectedText = "";
            this.textBox6.SelectionStart = 5;
            this.textBox6.ShadowDecoration.Parent = this.textBox6;
            this.textBox6.Size = new System.Drawing.Size(241, 37);
            this.textBox6.TabIndex = 30;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AutoRoundedCorners = true;
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.BorderRadius = 17;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.DefaultText = "Пароль";
            this.textBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.DisabledState.Parent = this.textBox2;
            this.textBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.FocusedState.Parent = this.textBox2;
            this.textBox2.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.HoverState.Parent = this.textBox2;
            this.textBox2.Location = new System.Drawing.Point(285, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.PlaceholderText = "";
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionStart = 6;
            this.textBox2.ShadowDecoration.Parent = this.textBox2;
            this.textBox2.Size = new System.Drawing.Size(241, 37);
            this.textBox2.TabIndex = 35;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AutoRoundedCorners = true;
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.BorderRadius = 17;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "Логин";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.Parent = this.textBox1;
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.FocusedState.Parent = this.textBox1;
            this.textBox1.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.HoverState.Parent = this.textBox1;
            this.textBox1.Location = new System.Drawing.Point(285, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderText = "";
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionStart = 5;
            this.textBox1.ShadowDecoration.Parent = this.textBox1;
            this.textBox1.Size = new System.Drawing.Size(241, 37);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.textBox1);
            this.guna2GradientPanel1.Controls.Add(this.textBox2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(818, 156);
            this.guna2GradientPanel1.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(818, 561);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.enterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton enterButton;
        private Guna.UI2.WinForms.Guna2TextBox textBox4;
        private Guna.UI2.WinForms.Guna2TextBox textBox3;
        private Guna.UI2.WinForms.Guna2TextBox textBox5;
        private Guna.UI2.WinForms.Guna2TextBox textBox8;
        private Guna.UI2.WinForms.Guna2TextBox textBox7;
        private Guna.UI2.WinForms.Guna2TextBox textBox6;
        private Guna.UI2.WinForms.Guna2TextBox textBox2;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}