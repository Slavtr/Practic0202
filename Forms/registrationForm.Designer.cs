
namespace WindowsFormsApp1.Forms
{
    partial class registrationForm
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.enterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(240, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox2.TabIndex = 18;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(276, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 17;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.AutoRoundedCorners = true;
            this.emailTextBox.BorderRadius = 17;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "Логин";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.Parent = this.emailTextBox;
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.FocusedState.Parent = this.emailTextBox;
            this.emailTextBox.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(38, 139);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionStart = 5;
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(241, 37);
            this.emailTextBox.TabIndex = 21;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // passTextBox1
            // 
            this.passTextBox1.AutoRoundedCorners = true;
            this.passTextBox1.BorderRadius = 17;
            this.passTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox1.DefaultText = "Пароль";
            this.passTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox1.DisabledState.Parent = this.passTextBox1;
            this.passTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox1.FocusedState.Parent = this.passTextBox1;
            this.passTextBox1.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.passTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox1.HoverState.Parent = this.passTextBox1;
            this.passTextBox1.Location = new System.Drawing.Point(38, 197);
            this.passTextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.PasswordChar = '\0';
            this.passTextBox1.PlaceholderText = "";
            this.passTextBox1.SelectedText = "";
            this.passTextBox1.SelectionStart = 6;
            this.passTextBox1.ShadowDecoration.Parent = this.passTextBox1;
            this.passTextBox1.Size = new System.Drawing.Size(241, 37);
            this.passTextBox1.TabIndex = 20;
            this.passTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox1.Enter += new System.EventHandler(this.passTextBox1_Enter);
            this.passTextBox1.Leave += new System.EventHandler(this.passTextBox1_Leave);
            // 
            // enterButton
            // 
            this.enterButton.AutoRoundedCorners = true;
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.BorderColor = System.Drawing.Color.Silver;
            this.enterButton.BorderRadius = 21;
            this.enterButton.BorderThickness = 3;
            this.enterButton.CheckedState.Parent = this.enterButton;
            this.enterButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.enterButton.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.enterButton.CustomImages.Parent = this.enterButton;
            this.enterButton.FillColor = System.Drawing.Color.Empty;
            this.enterButton.FillColor2 = System.Drawing.Color.Empty;
            this.enterButton.Font = new System.Drawing.Font("Furore", 10F, System.Drawing.FontStyle.Italic);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.HoverState.FillColor = System.Drawing.Color.Silver;
            this.enterButton.HoverState.FillColor2 = System.Drawing.Color.DimGray;
            this.enterButton.HoverState.Parent = this.enterButton;
            this.enterButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.enterButton.Location = new System.Drawing.Point(33, 389);
            this.enterButton.Name = "enterButton";
            this.enterButton.PressedColor = System.Drawing.Color.DarkGray;
            this.enterButton.ShadowDecoration.Parent = this.enterButton;
            this.enterButton.Size = new System.Drawing.Size(246, 45);
            this.enterButton.TabIndex = 19;
            this.enterButton.Text = "Зарегистрироваться";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passTextBox2
            // 
            this.passTextBox2.AutoRoundedCorners = true;
            this.passTextBox2.BorderRadius = 17;
            this.passTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox2.DefaultText = "Повторите пароль";
            this.passTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox2.DisabledState.Parent = this.passTextBox2;
            this.passTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox2.FocusedState.Parent = this.passTextBox2;
            this.passTextBox2.Font = new System.Drawing.Font("Furore", 10F, System.Drawing.FontStyle.Italic);
            this.passTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox2.HoverState.Parent = this.passTextBox2;
            this.passTextBox2.Location = new System.Drawing.Point(38, 253);
            this.passTextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.PasswordChar = '\0';
            this.passTextBox2.PlaceholderText = "";
            this.passTextBox2.SelectedText = "";
            this.passTextBox2.ShadowDecoration.Parent = this.passTextBox2;
            this.passTextBox2.Size = new System.Drawing.Size(241, 37);
            this.passTextBox2.TabIndex = 22;
            this.passTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox2.Enter += new System.EventHandler(this.passTextBox2_Enter);
            this.passTextBox2.Leave += new System.EventHandler(this.passTextBox2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Furore", 24F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 36);
            this.label4.TabIndex = 24;
            this.label4.Text = "Регистрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(102, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Пароль правильный?";
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passTextBox2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(320, 480);
            this.MinimumSize = new System.Drawing.Size(320, 480);
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passTextBox1;
        private Guna.UI2.WinForms.Guna2GradientButton enterButton;
        private Guna.UI2.WinForms.Guna2TextBox passTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}