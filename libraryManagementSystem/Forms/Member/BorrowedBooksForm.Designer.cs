namespace libraryManagementSystem.Forms.Member
{
    partial class BorrowedBooksForm
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
            dgvBorrowedBooks = new DataGridView();
            btnRefresh = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(25, 90);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.Size = new Size(425, 223);
            dgvBorrowedBooks.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(130, 351);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(159, 41);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 2;
            label1.Text = "Borrowed Books";
            // 
            // BorrowedBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvBorrowedBooks);
            Name = "BorrowedBooksForm";
            Text = "BorrowedBooksForm";
            Load += BorrowedBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Button btnRefresh;
        private Label label1;
    }
}