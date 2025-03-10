namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageAvaliableBooks
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
            dataGridView1 = new DataGridView();
            btnbooks = new Button();
            txtTitle = new TextBox();
            txtCategory = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 192);
            dataGridView1.TabIndex = 0;
            // 
            // btnbooks
            // 
            btnbooks.Location = new Point(256, 170);
            btnbooks.Name = "btnbooks";
            btnbooks.Size = new Size(149, 41);
            btnbooks.TabIndex = 3;
            btnbooks.Text = "Generate_Report";
            btnbooks.UseVisualStyleBackColor = true;
            btnbooks.Click += btnbooks_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(555, 24);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(555, 84);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(569, 146);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 32);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 7;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 92);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Category";
            // 
            // ManageAvaliableBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtCategory);
            Controls.Add(txtTitle);
            Controls.Add(btnbooks);
            Controls.Add(dataGridView1);
            Name = "ManageAvaliableBooks";
            Text = "ManageAvaliableBooks";
            Load += ManageAvaliableBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnbooks;
        private TextBox txtTitle;
        private TextBox txtCategory;
        private Button btnSearch;
        private Label label1;
        private Label label2;
    }
}