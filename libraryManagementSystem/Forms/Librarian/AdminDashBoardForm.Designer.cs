namespace libraryManagementSystem.Forms.Librarian
{
    partial class AdminDashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoardForm));
            btn_manageBooks = new Button();
            btn_manageUsers = new Button();
            btn_viewLogs = new Button();
            btn_generateReports = new Button();
            btn_manageProfile = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_returnedBooks = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_manageBooks
            // 
            btn_manageBooks.FlatStyle = FlatStyle.Flat;
            btn_manageBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_manageBooks.ForeColor = Color.White;
            btn_manageBooks.Location = new Point(30, 276);
            btn_manageBooks.Name = "btn_manageBooks";
            btn_manageBooks.Size = new Size(237, 49);
            btn_manageBooks.TabIndex = 1;
            btn_manageBooks.Text = "Manage Books";
            btn_manageBooks.UseVisualStyleBackColor = true;
            btn_manageBooks.Click += btn_manageBooks_Click;
            // 
            // btn_manageUsers
            // 
            btn_manageUsers.FlatStyle = FlatStyle.Flat;
            btn_manageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_manageUsers.ForeColor = Color.White;
            btn_manageUsers.Location = new Point(30, 192);
            btn_manageUsers.Name = "btn_manageUsers";
            btn_manageUsers.Size = new Size(237, 53);
            btn_manageUsers.TabIndex = 2;
            btn_manageUsers.Text = "Manage Users";
            btn_manageUsers.UseVisualStyleBackColor = true;
            btn_manageUsers.Click += btn_manageUsers_Click;
            // 
            // btn_viewLogs
            // 
            btn_viewLogs.FlatStyle = FlatStyle.Flat;
            btn_viewLogs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_viewLogs.ForeColor = Color.White;
            btn_viewLogs.Location = new Point(30, 367);
            btn_viewLogs.Name = "btn_viewLogs";
            btn_viewLogs.Size = new Size(237, 45);
            btn_viewLogs.TabIndex = 3;
            btn_viewLogs.Text = "View Logs";
            btn_viewLogs.UseVisualStyleBackColor = true;
            btn_viewLogs.Click += btn_viewLogs_Click;
            // 
            // btn_generateReports
            // 
            btn_generateReports.FlatStyle = FlatStyle.Flat;
            btn_generateReports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_generateReports.ForeColor = Color.White;
            btn_generateReports.Location = new Point(30, 533);
            btn_generateReports.Name = "btn_generateReports";
            btn_generateReports.Size = new Size(237, 45);
            btn_generateReports.TabIndex = 4;
            btn_generateReports.Text = "Generate Reports";
            btn_generateReports.UseVisualStyleBackColor = true;
            btn_generateReports.Click += btn_generateReports_Click;
            // 
            // btn_manageProfile
            // 
            btn_manageProfile.FlatStyle = FlatStyle.Flat;
            btn_manageProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_manageProfile.ForeColor = Color.White;
            btn_manageProfile.Location = new Point(30, 456);
            btn_manageProfile.Name = "btn_manageProfile";
            btn_manageProfile.Size = new Size(237, 45);
            btn_manageProfile.TabIndex = 5;
            btn_manageProfile.Text = "Manage Profile";
            btn_manageProfile.UseVisualStyleBackColor = true;
            btn_manageProfile.Click += btn_manageProfile_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.Controls.Add(btn_returnedBooks);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_generateReports);
            panel1.Controls.Add(btn_manageUsers);
            panel1.Controls.Add(btn_viewLogs);
            panel1.Controls.Add(btn_manageBooks);
            panel1.Controls.Add(btn_manageProfile);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 774);
            panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(115, 692);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 128);
            label4.Name = "label4";
            label4.Size = new Size(228, 37);
            label4.TabIndex = 9;
            label4.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(94, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.still_life_books_versus_technology1;
            pictureBox1.Location = new Point(303, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(601, 774);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_returnedBooks
            // 
            btn_returnedBooks.FlatStyle = FlatStyle.Flat;
            btn_returnedBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_returnedBooks.ForeColor = Color.White;
            btn_returnedBooks.Location = new Point(30, 608);
            btn_returnedBooks.Name = "btn_returnedBooks";
            btn_returnedBooks.Size = new Size(237, 45);
            btn_returnedBooks.TabIndex = 13;
            btn_returnedBooks.Text = "Return Books";
            btn_returnedBooks.UseVisualStyleBackColor = true;
            btn_returnedBooks.Click += btn_returnedBooks_Click_1;
            // 
            // AdminDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(907, 775);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "AdminDashBoardForm";
            Text = "AdminDashBoardForm";
            Load += AdminDashBoardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_manageBooks;
        private Button btn_manageUsers;
        private Button btn_viewLogs;
        private Button btn_generateReports;
        private Button btn_manageProfile;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox3;
        private Button btn_returnedBooks;
    }
}