
namespace WindowsFormsApp1.Forms
{
    partial class workoutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Упражнение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДопВес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КолВоПодходов = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.П1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.П2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.П3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.table.ColumnHeadersHeight = 40;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.Упражнение,
            this.Цель,
            this.ДопВес,
            this.КолВоПодходов,
            this.П1,
            this.П2,
            this.П3});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle12;
            this.table.EnableHeadersVisualStyles = false;
            this.table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.table.Location = new System.Drawing.Point(309, 10);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(467, 540);
            this.table.TabIndex = 12;
            this.table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table.ThemeStyle.HeaderStyle.Height = 40;
            this.table.ThemeStyle.ReadOnly = true;
            this.table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.table.ThemeStyle.RowsStyle.Height = 22;
            this.table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Номер
            // 
            this.Номер.HeaderText = "1";
            this.Номер.Name = "Номер";
            this.Номер.ReadOnly = true;
            this.Номер.Width = 40;
            // 
            // Упражнение
            // 
            this.Упражнение.HeaderText = "Упражнение";
            this.Упражнение.Name = "Упражнение";
            this.Упражнение.ReadOnly = true;
            this.Упражнение.Width = 111;
            // 
            // Цель
            // 
            this.Цель.HeaderText = "Цель";
            this.Цель.Name = "Цель";
            this.Цель.ReadOnly = true;
            this.Цель.Width = 63;
            // 
            // ДопВес
            // 
            this.ДопВес.HeaderText = "Доп. вес";
            this.ДопВес.Name = "ДопВес";
            this.ДопВес.ReadOnly = true;
            this.ДопВес.Width = 78;
            // 
            // КолВоПодходов
            // 
            this.КолВоПодходов.HeaderText = "Кол-во подходов";
            this.КолВоПодходов.Name = "КолВоПодходов";
            this.КолВоПодходов.ReadOnly = true;
            this.КолВоПодходов.Width = 129;
            // 
            // П1
            // 
            this.П1.HeaderText = "П1";
            this.П1.Name = "П1";
            this.П1.ReadOnly = true;
            this.П1.Width = 50;
            // 
            // П2
            // 
            this.П2.HeaderText = "П2";
            this.П2.Name = "П2";
            this.П2.ReadOnly = true;
            this.П2.Width = 50;
            // 
            // П3
            // 
            this.П3.HeaderText = "П3";
            this.П3.Name = "П3";
            this.П3.ReadOnly = true;
            this.П3.Width = 50;
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.FillColor = System.Drawing.Color.Silver;
            this.guna2TrackBar1.HoverState.Parent = this.guna2TrackBar1;
            this.guna2TrackBar1.IndicateFocus = false;
            this.guna2TrackBar1.Location = new System.Drawing.Point(32, 270);
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(230, 23);
            this.guna2TrackBar1.TabIndex = 10;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(32, 315);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(230, 230);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2PictureBox1.Location = new System.Drawing.Point(32, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(230, 230);
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // workoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(818, 561);
            this.Controls.Add(this.table);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2TrackBar1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "workoutForm";
            this.Text = "workoutForm";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Упражнение;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цель;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДопВес;
        private System.Windows.Forms.DataGridViewTextBoxColumn КолВоПодходов;
        private System.Windows.Forms.DataGridViewTextBoxColumn П1;
        private System.Windows.Forms.DataGridViewTextBoxColumn П2;
        private System.Windows.Forms.DataGridViewTextBoxColumn П3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}