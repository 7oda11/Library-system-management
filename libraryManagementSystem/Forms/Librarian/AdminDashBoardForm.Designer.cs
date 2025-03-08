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
            btn_manageBooks = new Button();
            btn_manageUsers = new Button();
            btn_viewLogs = new Button();
            btn_generateReports = new Button();
            btn_manageProfile = new Button();
            SuspendLayout();
            // 
            // btn_manageBooks
            // 
            btn_manageBooks.Location = new Point(261, 125);
            btn_manageBooks.Name = "btn_manageBooks";
            btn_manageBooks.Size = new Size(237, 45);
            btn_manageBooks.TabIndex = 1;
            btn_manageBooks.Text = "Manage Books";
            btn_manageBooks.UseVisualStyleBackColor = true;
            btn_manageBooks.Click += btn_manageBooks_Click;
            // 
            // btn_manageUsers
            // 
            btn_manageUsers.Location = new Point(261, 57);
            btn_manageUsers.Name = "btn_manageUsers";
            btn_manageUsers.Size = new Size(237, 45);
            btn_manageUsers.TabIndex = 2;
            btn_manageUsers.Text = "Manage Users";
            btn_manageUsers.UseVisualStyleBackColor = true;
            btn_manageUsers.Click += btn_manageUsers_Click;
            // 
            // btn_viewLogs
            // 
            btn_viewLogs.Location = new Point(261, 197);
            btn_viewLogs.Name = "btn_viewLogs";
            btn_viewLogs.Size = new Size(237, 45);
            btn_viewLogs.TabIndex = 3;
            btn_viewLogs.Text = "View Logs";
            btn_viewLogs.UseVisualStyleBackColor = true;
            btn_viewLogs.Click += btn_viewLogs_Click;
            // 
            // btn_generateReports
            // 
            btn_generateReports.Location = new Point(261, 272);
            btn_generateReports.Name = "btn_generateReports";
            btn_generateReports.Size = new Size(237, 45);
            btn_generateReports.TabIndex = 4;
            btn_generateReports.Text = "Generate Reports";
            btn_generateReports.UseVisualStyleBackColor = true;
            // 
            // btn_manageProfile
            // 
            btn_manageProfile.Location = new Point(261, 347);
            btn_manageProfile.Name = "btn_manageProfile";
            btn_manageProfile.Size = new Size(237, 45);
            btn_manageProfile.TabIndex = 5;
            btn_manageProfile.Text = "Manage Profile";
            btn_manageProfile.UseVisualStyleBackColor = true;
            btn_manageProfile.Click += btn_manageProfile_Click;
            // 
            // AdminDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btn_manageProfile);
            Controls.Add(btn_generateReports);
            Controls.Add(btn_viewLogs);
            Controls.Add(btn_manageUsers);
            Controls.Add(btn_manageBooks);
            Name = "AdminDashBoardForm";
            Text = "AdminDashBoardForm";
            Load += AdminDashBoardForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_manageBooks;
        private Button btn_manageUsers;
        private Button btn_viewLogs;
        private Button btn_generateReports;
        private Button btn_manageProfile;
    }
}