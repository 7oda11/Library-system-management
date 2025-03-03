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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 74);
            label1.Name = "label1";
            label1.Size = new Size(320, 21);
            label1.TabIndex = 0;
            label1.Text = "Wecome to Library management System";
            // 
            // btnViewBooks
            // 
            btnViewBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBooks.Location = new Point(46, 149);
            btnViewBooks.Name = "btnViewBooks";
            btnViewBooks.Size = new Size(131, 34);
            btnViewBooks.TabIndex = 1;
            btnViewBooks.Text = "View Books";
            btnViewBooks.UseVisualStyleBackColor = true;
            btnViewBooks.Click += btnViewBooks_Click;
            // 
            // btnBorrowedBooks
            // 
            btnBorrowedBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrowedBooks.Location = new Point(46, 217);
            btnBorrowedBooks.Name = "btnBorrowedBooks";
            btnBorrowedBooks.Size = new Size(207, 34);
            btnBorrowedBooks.TabIndex = 2;
            btnBorrowedBooks.Text = "View Borrowed Books";
            btnBorrowedBooks.UseVisualStyleBackColor = true;
            btnBorrowedBooks.Click += btnBorrowedBooks_Click;
            // 
            // btnManageProfile
            // 
            btnManageProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProfile.Location = new Point(46, 284);
            btnManageProfile.Name = "btnManageProfile";
            btnManageProfile.Size = new Size(207, 37);
            btnManageProfile.TabIndex = 3;
            btnManageProfile.Text = "Manage Profile";
            btnManageProfile.UseVisualStyleBackColor = true;
            btnManageProfile.Click += btnManageProfile_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnManageProfile);
            Controls.Add(btnBorrowedBooks);
            Controls.Add(btnViewBooks);
            Controls.Add(label1);
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
    }
}