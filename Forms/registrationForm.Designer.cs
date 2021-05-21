
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.enterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thirdNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.secondNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.GradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.GradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(560, 12);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(596, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 17;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.AutoRoundedCorners = true;
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
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
            this.emailTextBox.ForeColor = System.Drawing.Color.Silver;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(349, 37);
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
            this.passTextBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.passTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.passTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox1.HoverState.Parent = this.passTextBox1;
            this.passTextBox1.Location = new System.Drawing.Point(349, 95);
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
            this.enterButton.Location = new System.Drawing.Point(180, 389);
            this.enterButton.Name = "enterButton";
            this.enterButton.PressedColor = System.Drawing.Color.DimGray;
            this.enterButton.ShadowDecoration.Parent = this.enterButton;
            this.enterButton.Size = new System.Drawing.Size(246, 45);
            this.enterButton.TabIndex = 19;
            this.enterButton.Text = "Зарегистрироваться";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passTextBox2
            // 
            this.passTextBox2.AutoRoundedCorners = true;
            this.passTextBox2.BackColor = System.Drawing.Color.Transparent;
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
            this.passTextBox2.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.passTextBox2.ForeColor = System.Drawing.Color.Silver;
            this.passTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox2.HoverState.Parent = this.passTextBox2;
            this.passTextBox2.Location = new System.Drawing.Point(349, 151);
            this.passTextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.PasswordChar = '\0';
            this.passTextBox2.PlaceholderText = "";
            this.passTextBox2.SelectedText = "";
            this.passTextBox2.SelectionStart = 16;
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
            this.label4.Location = new System.Drawing.Point(174, 53);
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
            this.label1.Location = new System.Drawing.Point(246, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // thirdNameTextBox
            // 
            this.thirdNameTextBox.AutoRoundedCorners = true;
            this.thirdNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.thirdNameTextBox.BorderRadius = 17;
            this.thirdNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thirdNameTextBox.DefaultText = "Отчество";
            this.thirdNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thirdNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thirdNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdNameTextBox.DisabledState.Parent = this.thirdNameTextBox;
            this.thirdNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdNameTextBox.FocusedState.Parent = this.thirdNameTextBox;
            this.thirdNameTextBox.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.thirdNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.thirdNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdNameTextBox.HoverState.Parent = this.thirdNameTextBox;
            this.thirdNameTextBox.Location = new System.Drawing.Point(47, 151);
            this.thirdNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.thirdNameTextBox.Name = "thirdNameTextBox";
            this.thirdNameTextBox.PasswordChar = '\0';
            this.thirdNameTextBox.PlaceholderText = "";
            this.thirdNameTextBox.SelectedText = "";
            this.thirdNameTextBox.SelectionStart = 8;
            this.thirdNameTextBox.ShadowDecoration.Parent = this.thirdNameTextBox;
            this.thirdNameTextBox.Size = new System.Drawing.Size(241, 37);
            this.thirdNameTextBox.TabIndex = 28;
            this.thirdNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thirdNameTextBox.Enter += new System.EventHandler(this.thirdNameTextBox_Enter);
            this.thirdNameTextBox.Leave += new System.EventHandler(this.thirdNameTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoRoundedCorners = true;
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.BorderRadius = 17;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "Имя";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.Parent = this.nameTextBox;
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.FocusedState.Parent = this.nameTextBox;
            this.nameTextBox.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.nameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.HoverState.Parent = this.nameTextBox;
            this.nameTextBox.Location = new System.Drawing.Point(47, 37);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionStart = 3;
            this.nameTextBox.ShadowDecoration.Parent = this.nameTextBox;
            this.nameTextBox.Size = new System.Drawing.Size(241, 37);
            this.nameTextBox.TabIndex = 27;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.AutoRoundedCorners = true;
            this.secondNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.secondNameTextBox.BorderRadius = 17;
            this.secondNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondNameTextBox.DefaultText = "Фамилия";
            this.secondNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.secondNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.secondNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secondNameTextBox.DisabledState.Parent = this.secondNameTextBox;
            this.secondNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secondNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondNameTextBox.FocusedState.Parent = this.secondNameTextBox;
            this.secondNameTextBox.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.secondNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.secondNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondNameTextBox.HoverState.Parent = this.secondNameTextBox;
            this.secondNameTextBox.Location = new System.Drawing.Point(47, 95);
            this.secondNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.PasswordChar = '\0';
            this.secondNameTextBox.PlaceholderText = "";
            this.secondNameTextBox.SelectedText = "";
            this.secondNameTextBox.SelectionStart = 7;
            this.secondNameTextBox.ShadowDecoration.Parent = this.secondNameTextBox;
            this.secondNameTextBox.Size = new System.Drawing.Size(241, 37);
            this.secondNameTextBox.TabIndex = 26;
            this.secondNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondNameTextBox.Enter += new System.EventHandler(this.secondNameTextBox_Enter);
            this.secondNameTextBox.Leave += new System.EventHandler(this.secondNameTextBox_Leave);
            // 
            // GradientPanel
            // 
            this.GradientPanel.Controls.Add(this.nameTextBox);
            this.GradientPanel.Controls.Add(this.secondNameTextBox);
            this.GradientPanel.Controls.Add(this.thirdNameTextBox);
            this.GradientPanel.Controls.Add(this.passTextBox2);
            this.GradientPanel.Controls.Add(this.passTextBox1);
            this.GradientPanel.Controls.Add(this.emailTextBox);
            this.GradientPanel.FillColor = System.Drawing.Color.DarkGray;
            this.GradientPanel.Location = new System.Drawing.Point(0, 119);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.ShadowDecoration.Parent = this.GradientPanel;
            this.GradientPanel.Size = new System.Drawing.Size(642, 220);
            this.GradientPanel.TabIndex = 29;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.GradientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.GradientPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passTextBox1;
        private Guna.UI2.WinForms.Guna2GradientButton enterButton;
        private Guna.UI2.WinForms.Guna2TextBox passTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox thirdNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox secondNameTextBox;
        private Guna.UI2.WinForms.Guna2GradientPanel GradientPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}