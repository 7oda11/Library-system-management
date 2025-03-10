namespace libraryManagementSystem.Forms.Member
{
    partial class ViewBooksForm
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
            btnRefresh = new Button();
            label1 = new Label();
            dgvBooks = new DataGridView();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(154, 314);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 32);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "All Books";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 60);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(443, 248);
            dgvBooks.TabIndex = 2;
            dgvBooks.RowHeaderMouseDoubleClick += dgvBooks_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(583, 60);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 3;
            label2.Text = "Search for a Book";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(617, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(583, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(143, 23);
            txtSearch.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(365, 394);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 32);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ViewBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(dgvBooks);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Name = "ViewBooksForm";
            Text = "ViewBooksForm";
            Load += ViewBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Label label1;
        private DataGridView dgvBooks;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnBack;
    }
}