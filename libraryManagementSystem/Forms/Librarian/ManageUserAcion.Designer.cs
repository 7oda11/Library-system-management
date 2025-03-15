﻿namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageUserAcion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserAcion));
            label1 = new Label();
            txt_userName = new TextBox();
            btn_reset = new Button();
            btn_search = new Button();
            btn = new Label();
            txt_bookName = new TextBox();
            dgv_logs = new DataGridView();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 44, 111);
            label1.Location = new Point(104, 44);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 26;
            label1.Text = "User Name";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(249, 38);
            txt_userName.Margin = new Padding(3, 2, 3, 2);
            txt_userName.Multiline = true;
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(181, 27);
            txt_userName.TabIndex = 25;
            // 
            // btn_reset
            // 
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(11, 293);
            btn_reset.Margin = new Padding(3, 2, 3, 2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(155, 33);
            btn_reset.TabIndex = 24;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(11, 219);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(155, 32);
            btn_search.TabIndex = 21;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn
            // 
            btn.AutoSize = true;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.FromArgb(91, 44, 111);
            btn.Location = new Point(104, 113);
            btn.Name = "btn";
            btn.Size = new Size(99, 21);
            btn.TabIndex = 20;
            btn.Text = "Book Name";
            // 
            // txt_bookName
            // 
            txt_bookName.Location = new Point(249, 107);
            txt_bookName.Margin = new Padding(3, 2, 3, 2);
            txt_bookName.Multiline = true;
            txt_bookName.Name = "txt_bookName";
            txt_bookName.Size = new Size(181, 27);
            txt_bookName.TabIndex = 19;
            txt_bookName.TextChanged += txt_bookName_TextChanged;
            // 
            // dgv_logs
            // 
            dgv_logs.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(142, 68, 173);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_logs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_logs.Location = new Point(-1, 62);
            dgv_logs.Margin = new Padding(3, 2, 3, 2);
            dgv_logs.Name = "dgv_logs";
            dgv_logs.RowHeadersWidth = 51;
            dgv_logs.Size = new Size(574, 141);
            dgv_logs.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_reset);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_search);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 532);
            panel1.TabIndex = 27;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 459);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 117);
            label7.Name = "label7";
            label7.Size = new Size(175, 30);
            label7.TabIndex = 9;
            label7.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgv_logs);
            panel2.Location = new Point(196, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 292);
            panel2.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txt_userName);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(btn);
            panel4.Controls.Add(txt_bookName);
            panel4.Location = new Point(196, 320);
            panel4.Name = "panel4";
            panel4.Size = new Size(578, 200);
            panel4.TabIndex = 29;
            // 
            // ManageUserAcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(786, 532);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageUserAcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUserAcion";
            Load += ManageUserAcion_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_logs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_userName;
        private Button btn_reset;
        private Button btn_search;
        private Label btn;
        private TextBox txt_bookName;
        private DataGridView dgv_logs;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel4;
    }
}