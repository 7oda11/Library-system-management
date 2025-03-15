namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageReturnedBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReturnedBooks));
            label1 = new Label();
            txt_userName = new TextBox();
            btn_reset = new Button();
            btn_search = new Button();
            btn = new Label();
            txt_bookName = new TextBox();
            dgv_logs = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 44, 111);
            label1.Location = new Point(110, 92);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 17;
            label1.Text = "User Name";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(258, 89);
            txt_userName.Margin = new Padding(3, 2, 3, 2);
            txt_userName.Multiline = true;
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(168, 27);
            txt_userName.TabIndex = 16;
            // 
            // btn_reset
            // 
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(10, 296);
            btn_reset.Margin = new Padding(3, 2, 3, 2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(159, 31);
            btn_reset.TabIndex = 15;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(10, 221);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(159, 30);
            btn_search.TabIndex = 12;
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
            btn.Location = new Point(106, 31);
            btn.Name = "btn";
            btn.Size = new Size(99, 21);
            btn.TabIndex = 11;
            btn.Text = "Book Name";
            // 
            // txt_bookName
            // 
            txt_bookName.Location = new Point(258, 28);
            txt_bookName.Margin = new Padding(3, 2, 3, 2);
            txt_bookName.Multiline = true;
            txt_bookName.Name = "txt_bookName";
            txt_bookName.Size = new Size(168, 27);
            txt_bookName.TabIndex = 10;
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
            dgv_logs.Location = new Point(-1, 46);
            dgv_logs.Margin = new Padding(3, 2, 3, 2);
            dgv_logs.Name = "dgv_logs";
            dgv_logs.RowHeadersWidth = 51;
            dgv_logs.Size = new Size(578, 183);
            dgv_logs.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgv_logs);
            panel2.Location = new Point(196, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 292);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(btn_reset);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 532);
            panel1.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 458);
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
            pictureBox1.Location = new Point(49, 375);
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_bookName);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txt_userName);
            panel3.Controls.Add(btn);
            panel3.Location = new Point(196, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(578, 178);
            panel3.TabIndex = 21;
            // 
            // ManageReturnedBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(786, 532);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageReturnedBooks";
            Text = "ManageReturnedBooks";
            Load += ManageReturnedBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_logs).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}