namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageLogs
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
            btn_borrowedBook = new Button();
            btn_returningBooks = new Button();
            btn_userAction = new Button();
            btn_logout = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btn_borrowedBook
            // 
            btn_borrowedBook.Location = new Point(244, 115);
            btn_borrowedBook.Name = "btn_borrowedBook";
            btn_borrowedBook.Size = new Size(214, 29);
            btn_borrowedBook.TabIndex = 0;
            btn_borrowedBook.Text = "Borrowed Books";
            btn_borrowedBook.UseVisualStyleBackColor = true;
            btn_borrowedBook.Click += btn_borrowedBook_Click;
            // 
            // btn_returningBooks
            // 
            btn_returningBooks.Location = new Point(244, 187);
            btn_returningBooks.Name = "btn_returningBooks";
            btn_returningBooks.Size = new Size(214, 29);
            btn_returningBooks.TabIndex = 1;
            btn_returningBooks.Text = "Returned Books";
            btn_returningBooks.UseVisualStyleBackColor = true;
            btn_returningBooks.Click += btn_returningBooks_Click;
            // 
            // btn_userAction
            // 
            btn_userAction.Location = new Point(244, 262);
            btn_userAction.Name = "btn_userAction";
            btn_userAction.Size = new Size(214, 29);
            btn_userAction.TabIndex = 2;
            btn_userAction.Text = "User Action";
            btn_userAction.UseVisualStyleBackColor = true;
            btn_userAction.Click += btn_userAction_Click;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(694, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(694, 409);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 4;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ManageLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_userAction);
            Controls.Add(btn_returningBooks);
            Controls.Add(btn_borrowedBook);
            Name = "ManageLogs";
            Text = "ManageLogs";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_borrowedBook;
        private Button btn_returningBooks;
        private Button btn_userAction;
        private Button btn_logout;
        private Button btn_back;
    }
}