namespace libraryManagementSystem.Forms.Librarian
{
    partial class ReportAvaliableBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAvaliableBooks));
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            txtCategory = new TextBox();
            txtTitle = new TextBox();
            btnbooks = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(91, 44, 111);
            label2.Location = new Point(67, 31);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 15;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 44, 111);
            label1.Location = new Point(78, 89);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 14;
            label1.Text = "Title";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(85, 26, 139);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(182, 146);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(207, 36);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(208, 29);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(163, 23);
            txtCategory.TabIndex = 12;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(208, 87);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(163, 23);
            txtTitle.TabIndex = 11;
            // 
            // btnbooks
            // 
            btnbooks.FlatStyle = FlatStyle.Flat;
            btnbooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbooks.ForeColor = Color.White;
            btnbooks.Location = new Point(32, 203);
            btnbooks.Name = "btnbooks";
            btnbooks.Size = new Size(160, 41);
            btnbooks.TabIndex = 10;
            btnbooks.Text = "Generate_Report";
            btnbooks.UseVisualStyleBackColor = true;
            btnbooks.Click += btnbooks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(142, 68, 173);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(564, 192);
            dataGridView1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnbooks);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 532);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(70, 434);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(32, 120);
            label7.Name = "label7";
            label7.Size = new Size(175, 30);
            label7.TabIndex = 9;
            label7.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 13);
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
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(230, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 261);
            panel2.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtCategory);
            panel3.Controls.Add(txtTitle);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(230, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 209);
            panel3.TabIndex = 31;
            // 
            // ReportAvaliableBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(797, 532);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportAvaliableBooks";
            Text = "ReportAvaliableBookss";
            Load += ReportAvaliableBookss_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TextBox txtCategory;
        private TextBox txtTitle;
        private Button btnbooks;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
    }
}