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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            label1 = new Label();
            btnLogout = new Button();
            btnManageProfile = new Button();
            btnBorrowedBooks = new Button();
            btnViewBooks = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(194, 7);
            label1.Name = "label1";
            label1.Size = new Size(459, 19);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Library management System";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(0, 309);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(192, 36);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageProfile
            // 
            btnManageProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProfile.Location = new Point(0, 197);
            btnManageProfile.Margin = new Padding(3, 2, 3, 2);
            btnManageProfile.Name = "btnManageProfile";
            btnManageProfile.Size = new Size(192, 28);
            btnManageProfile.TabIndex = 3;
            btnManageProfile.Text = "Manage Profile";
            btnManageProfile.UseVisualStyleBackColor = true;
            btnManageProfile.Click += btnManageProfile_Click;
            // 
            // btnBorrowedBooks
            // 
            btnBorrowedBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrowedBooks.Location = new Point(0, 167);
            btnBorrowedBooks.Margin = new Padding(3, 2, 3, 2);
            btnBorrowedBooks.Name = "btnBorrowedBooks";
            btnBorrowedBooks.Size = new Size(190, 26);
            btnBorrowedBooks.TabIndex = 2;
            btnBorrowedBooks.Text = " Borrowed Books";
            btnBorrowedBooks.UseVisualStyleBackColor = true;
            btnBorrowedBooks.Click += btnBorrowedBooks_Click;
            // 
            // btnViewBooks
            // 
            btnViewBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBooks.Location = new Point(0, 137);
            btnViewBooks.Margin = new Padding(3, 2, 3, 2);
            btnViewBooks.Name = "btnViewBooks";
            btnViewBooks.Size = new Size(190, 26);
            btnViewBooks.TabIndex = 1;
            btnViewBooks.Text = "Available Books";
            btnViewBooks.UseVisualStyleBackColor = true;
            btnViewBooks.Click += btnViewBooks_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnViewBooks);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnManageProfile);
            panel1.Controls.Add(btnBorrowedBooks);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 345);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 230);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(192, 28);
            button1.TabIndex = 6;
            button1.Text = "Book History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 30);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 64);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 347);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePageForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Button btnManageProfile;
        private Button btnBorrowedBooks;
        private Button btnViewBooks;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}