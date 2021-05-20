
namespace WindowsFormsApp1.Forms
{
    partial class aboutusForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.button5 = new Guna.UI2.WinForms.Guna2Button();
            this.button4 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Furore", 24F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(46, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Furore", 24F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(43, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox2.Location = new System.Drawing.Point(49, 31);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(325, 325);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BorderColor = System.Drawing.Color.Khaki;
            this.guna2RatingStar1.Location = new System.Drawing.Point(484, 372);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Khaki;
            this.guna2RatingStar1.Size = new System.Drawing.Size(200, 40);
            this.guna2RatingStar1.TabIndex = 7;
            this.guna2RatingStar1.Value = 3.5F;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.CheckedState.Parent = this.button5;
            this.button5.CustomImages.Parent = this.button5;
            this.button5.FillColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.HoverState.Parent = this.button5;
            this.button5.Image = global::WindowsFormsApp1.Properties.Resources.double_right;
            this.button5.ImageSize = new System.Drawing.Size(40, 40);
            this.button5.Location = new System.Drawing.Point(624, 469);
            this.button5.Name = "button5";
            this.button5.PressedColor = System.Drawing.Color.Transparent;
            this.button5.ShadowDecoration.Parent = this.button5;
            this.button5.Size = new System.Drawing.Size(60, 57);
            this.button5.TabIndex = 9;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.CheckedState.Parent = this.button4;
            this.button4.CustomImages.Parent = this.button4;
            this.button4.FillColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.HoverState.Parent = this.button4;
            this.button4.Image = global::WindowsFormsApp1.Properties.Resources.double_left;
            this.button4.ImageSize = new System.Drawing.Size(40, 40);
            this.button4.Location = new System.Drawing.Point(484, 469);
            this.button4.Name = "button4";
            this.button4.PressedColor = System.Drawing.Color.Transparent;
            this.button4.ShadowDecoration.Parent = this.button4;
            this.button4.Size = new System.Drawing.Size(60, 57);
            this.button4.TabIndex = 8;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Location = new System.Drawing.Point(425, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 325);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Furore", 14F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(48, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Furore", 14F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(45, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Цена";
            // 
            // aboutusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(818, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aboutusForm";
            this.Text = "aboutusForm";
            this.Load += new System.EventHandler(this.aboutusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2Button button4;
        private Guna.UI2.WinForms.Guna2Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}