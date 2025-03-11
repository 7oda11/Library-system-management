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
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            txtCategory = new TextBox();
            txtTitle = new TextBox();
            btnbooks = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(620, 99);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 15;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(620, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 14;
            label1.Text = "Title";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(742, 171);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(726, 88);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(114, 27);
            txtCategory.TabIndex = 12;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(726, 8);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(114, 27);
            txtTitle.TabIndex = 11;
            // 
            // btnbooks
            // 
            btnbooks.Location = new Point(385, 203);
            btnbooks.Margin = new Padding(3, 4, 3, 4);
            btnbooks.Name = "btnbooks";
            btnbooks.Size = new Size(170, 55);
            btnbooks.TabIndex = 10;
            btnbooks.Text = "Generate_Report";
            btnbooks.UseVisualStyleBackColor = true;
            btnbooks.Click += btnbooks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 304);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 256);
            dataGridView1.TabIndex = 9;
            // 
            // ReportAvaliableBookss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 519);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtCategory);
            Controls.Add(txtTitle);
            Controls.Add(btnbooks);
            Controls.Add(dataGridView1);
            Name = "ReportAvaliableBookss";
            Text = "ReportAvaliableBookss";
            Load += ReportAvaliableBookss_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TextBox txtCategory;
        private TextBox txtTitle;
        private Button btnbooks;
        private DataGridView dataGridView1;
    }
}