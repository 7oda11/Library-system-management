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
            btnBack = new Button();
            pictureBox_QRCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QRCode).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(29, 120);
            dgvBorrowedBooks.Margin = new Padding(3, 4, 3, 4);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.Size = new Size(486, 297);
            dgvBorrowedBooks.TabIndex = 0;
            dgvBorrowedBooks.RowHeaderMouseDoubleClick += dgvBorrowedBooks_RowHeaderMouseDoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(429, 437);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 55);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 53);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 2;
            label1.Text = "Borrowed Books";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(815, 512);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 55);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox_QRCode
            // 
            pictureBox_QRCode.Location = new Point(521, 120);
            pictureBox_QRCode.Name = "pictureBox_QRCode";
            pictureBox_QRCode.Size = new Size(381, 313);
            pictureBox_QRCode.TabIndex = 4;
            pictureBox_QRCode.TabStop = false;
            // 
            // BorrowedBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox_QRCode);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvBorrowedBooks);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BorrowedBooksForm";
            Text = "BorrowedBooksForm";
            Load += BorrowedBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Button btnRefresh;
        private Label label1;
        private Button btnBack;
        private PictureBox pictureBox_QRCode;
    }
}