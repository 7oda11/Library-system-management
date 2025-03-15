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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowedBooksForm));
            dgvBorrowedBooks = new DataGridView();
            btnRefresh = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox_QRCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QRCode).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(36, 95);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.Size = new Size(343, 267);
            dgvBorrowedBooks.TabIndex = 0;
            dgvBorrowedBooks.RowHeaderMouseDoubleClick += dgvBorrowedBooks_RowHeaderMouseDoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Purple;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(444, 324);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(218, 46);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Purple;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(598, 34);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 34);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 75, 125);
            panel1.Controls.Add(pictureBox_QRCode);
            panel1.Location = new Point(2, 394);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 121);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(681, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox_QRCode
            // 
            pictureBox_QRCode.Location = new Point(457, 16);
            pictureBox_QRCode.Name = "pictureBox_QRCode";
            pictureBox_QRCode.Size = new Size(180, 96);
            pictureBox_QRCode.TabIndex = 0;
            pictureBox_QRCode.TabStop = false;
            // 
            // BorrowedBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 518);
            Controls.Add(btnBack);
            Controls.Add(dgvBorrowedBooks);
            Controls.Add(btnRefresh);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "BorrowedBooksForm";
            Text = "BorrowedBooksForm";
            Load += BorrowedBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Button btnRefresh;
        private Button btnBack;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_QRCode;
    }
}