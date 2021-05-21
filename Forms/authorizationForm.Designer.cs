
namespace WindowsFormsApp1.Forms
{
    partial class authorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorizationForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.enterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registationLabel = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
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
            this.enterButton.Location = new System.Drawing.Point(34, 346);
            this.enterButton.Name = "enterButton";
            this.enterButton.PressedColor = System.Drawing.Color.DimGray;
            this.enterButton.ShadowDecoration.Parent = this.enterButton;
            this.enterButton.Size = new System.Drawing.Size(246, 45);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.AutoRoundedCorners = true;
            this.passTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passTextBox.BorderRadius = 17;
            this.passTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.DefaultText = "Пароль";
            this.passTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox.DisabledState.Parent = this.passTextBox;
            this.passTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox.FocusedState.Parent = this.passTextBox;
            this.passTextBox.Font = new System.Drawing.Font("Furore", 12F, System.Drawing.FontStyle.Italic);
            this.passTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox.HoverState.Parent = this.passTextBox;
            this.passTextBox.Location = new System.Drawing.Point(39, 91);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '\0';
            this.passTextBox.PlaceholderText = "";
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionStart = 6;
            this.passTextBox.ShadowDecoration.Parent = this.passTextBox;
            this.passTextBox.Size = new System.Drawing.Size(241, 37);
            this.passTextBox.TabIndex = 8;
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox.Enter += new System.EventHandler(this.passTextBox_Enter);
            this.passTextBox.Leave += new System.EventHandler(this.passTextBox_Leave);
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
            this.emailTextBox.Location = new System.Drawing.Point(39, 33);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionStart = 5;
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(241, 37);
            this.emailTextBox.TabIndex = 10;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Furore", 24F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Авторизация";
            // 
            // registationLabel
            // 
            this.registationLabel.AutoSize = true;
            this.registationLabel.BackColor = System.Drawing.Color.Transparent;
            this.registationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.registationLabel.ForeColor = System.Drawing.Color.White;
            this.registationLabel.Location = new System.Drawing.Point(94, 413);
            this.registationLabel.Name = "registationLabel";
            this.registationLabel.Size = new System.Drawing.Size(127, 13);
            this.registationLabel.TabIndex = 13;
            this.registationLabel.Text = "Создать новый аккаунт";
            this.registationLabel.Click += new System.EventHandler(this.registationLabel_Click);
            this.registationLabel.MouseEnter += new System.EventHandler(this.registationLabel_MouseEnter);
            this.registationLabel.MouseLeave += new System.EventHandler(this.registationLabel_MouseLeave);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.emailTextBox);
            this.guna2GradientPanel1.Controls.Add(this.passTextBox);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 142);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(320, 156);
            this.guna2GradientPanel1.TabIndex = 16;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(246, 6);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox2.TabIndex = 15;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(282, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 14;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // authorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.registationLabel);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 480);
            this.MinimumSize = new System.Drawing.Size(320, 480);
            this.Name = "authorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "authorizationForm";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton enterButton;
        private Guna.UI2.WinForms.Guna2TextBox passTextBox;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label registationLabel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}