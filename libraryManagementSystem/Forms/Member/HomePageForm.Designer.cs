namespace libraryManagementSystem.Forms.Member
{
    partial class HomePageForm
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
            label1 = new Label();
            btnViewBooks = new Button();
            btnBorrowedBooks = new Button();
            btnManageProfile = new Button();
            btnLogout = new Button();
            btn_BorrowedBooksHistory = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 99);
            label1.Name = "label1";
            label1.Size = new Size(396, 28);
            label1.TabIndex = 0;
            label1.Text = "Wecome to Library management System";
            // 
            // btnViewBooks
            // 
            btnViewBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBooks.Location = new Point(53, 199);
            btnViewBooks.Margin = new Padding(3, 4, 3, 4);
            btnViewBooks.Name = "btnViewBooks";
            btnViewBooks.Size = new Size(150, 45);
            btnViewBooks.TabIndex = 1;
            btnViewBooks.Text = "View Books";
            btnViewBooks.UseVisualStyleBackColor = true;
            btnViewBooks.Click += btnViewBooks_Click;
            // 
            // btnBorrowedBooks
            // 
            btnBorrowedBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrowedBooks.Location = new Point(53, 289);
            btnBorrowedBooks.Margin = new Padding(3, 4, 3, 4);
            btnBorrowedBooks.Name = "btnBorrowedBooks";
            btnBorrowedBooks.Size = new Size(237, 45);
            btnBorrowedBooks.TabIndex = 2;
            btnBorrowedBooks.Text = "View Borrowed Books";
            btnBorrowedBooks.UseVisualStyleBackColor = true;
            btnBorrowedBooks.Click += btnBorrowedBooks_Click;
            // 
            // btnManageProfile
            // 
            btnManageProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProfile.Location = new Point(53, 386);
            btnManageProfile.Margin = new Padding(3, 4, 3, 4);
            btnManageProfile.Name = "btnManageProfile";
            btnManageProfile.Size = new Size(237, 49);
            btnManageProfile.TabIndex = 3;
            btnManageProfile.Text = "Manage Profile";
            btnManageProfile.UseVisualStyleBackColor = true;
            btnManageProfile.Click += btnManageProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(767, 507);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 53);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btn_BorrowedBooksHistory
            // 
            btn_BorrowedBooksHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BorrowedBooksHistory.Location = new Point(53, 472);
            btn_BorrowedBooksHistory.Margin = new Padding(3, 4, 3, 4);
            btn_BorrowedBooksHistory.Name = "btn_BorrowedBooksHistory";
            btn_BorrowedBooksHistory.Size = new Size(327, 45);
            btn_BorrowedBooksHistory.TabIndex = 5;
            btn_BorrowedBooksHistory.Text = "View Borrowed Books History";
            btn_BorrowedBooksHistory.UseVisualStyleBackColor = true;
            btn_BorrowedBooksHistory.Click += btn_BorrowedBooksHistory_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_BorrowedBooksHistory);
            Controls.Add(btnLogout);
            Controls.Add(btnManageProfile);
            Controls.Add(btnBorrowedBooks);
            Controls.Add(btnViewBooks);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomePageForm";
            Text = "HomePageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnViewBooks;
        private Button btnBorrowedBooks;
        private Button btnManageProfile;
        private Button btnLogout;
        private Button btn_BorrowedBooksHistory;
    }
}