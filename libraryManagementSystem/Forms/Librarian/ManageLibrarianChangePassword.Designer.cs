namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageLibrarianChangePassword
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
            label = new Label();
            label2 = new Label();
            ck_showConfirmPassword = new CheckBox();
            ck_showNewPassword = new CheckBox();
            txt_confirmPassword = new TextBox();
            txt_newPassword = new TextBox();
            txt_oldPassword = new TextBox();
            cb_showOldPassword = new CheckBox();
            label1 = new Label();
            btn_updatePassword = new Button();
            btn_back = new Button();
            btn_logout = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(32, 192);
            label.Name = "label";
            label.Size = new Size(127, 20);
            label.TabIndex = 20;
            label.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 125);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 19;
            label2.Text = "New Password";
            // 
            // ck_showConfirmPassword
            // 
            ck_showConfirmPassword.AutoSize = true;
            ck_showConfirmPassword.Location = new Point(242, 217);
            ck_showConfirmPassword.Name = "ck_showConfirmPassword";
            ck_showConfirmPassword.Size = new Size(132, 24);
            ck_showConfirmPassword.TabIndex = 18;
            ck_showConfirmPassword.Text = "Show Password";
            ck_showConfirmPassword.UseVisualStyleBackColor = true;
            ck_showConfirmPassword.CheckedChanged += ck_showConfirmPassword_CheckedChanged;
            // 
            // ck_showNewPassword
            // 
            ck_showNewPassword.AutoSize = true;
            ck_showNewPassword.Location = new Point(242, 151);
            ck_showNewPassword.Name = "ck_showNewPassword";
            ck_showNewPassword.Size = new Size(132, 24);
            ck_showNewPassword.TabIndex = 17;
            ck_showNewPassword.Text = "Show Password";
            ck_showNewPassword.UseVisualStyleBackColor = true;
            ck_showNewPassword.CheckedChanged += ck_showNewPassword_CheckedChanged;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(201, 175);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(125, 27);
            txt_confirmPassword.TabIndex = 16;
            txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // txt_newPassword
            // 
            txt_newPassword.Location = new Point(201, 118);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(125, 27);
            txt_newPassword.TabIndex = 15;
            txt_newPassword.UseSystemPasswordChar = true;
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.Location = new Point(201, 44);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.Size = new Size(125, 27);
            txt_oldPassword.TabIndex = 21;
            txt_oldPassword.UseSystemPasswordChar = true;
            // 
            // cb_showOldPassword
            // 
            cb_showOldPassword.AutoSize = true;
            cb_showOldPassword.Location = new Point(242, 77);
            cb_showOldPassword.Name = "cb_showOldPassword";
            cb_showOldPassword.Size = new Size(132, 24);
            cb_showOldPassword.TabIndex = 22;
            cb_showOldPassword.Text = "Show Password";
            cb_showOldPassword.UseVisualStyleBackColor = true;
            cb_showOldPassword.CheckedChanged += cb_showOldPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 23;
            label1.Text = "Old Password";
            // 
            // btn_updatePassword
            // 
            btn_updatePassword.Location = new Point(58, 306);
            btn_updatePassword.Name = "btn_updatePassword";
            btn_updatePassword.Size = new Size(153, 29);
            btn_updatePassword.TabIndex = 24;
            btn_updatePassword.Text = "Update Password";
            btn_updatePassword.UseVisualStyleBackColor = true;
            btn_updatePassword.Click += btn_updatePassword_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(707, 409);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 25;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(707, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 26;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // ManageLibrarianChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_logout);
            Controls.Add(btn_back);
            Controls.Add(btn_updatePassword);
            Controls.Add(label1);
            Controls.Add(cb_showOldPassword);
            Controls.Add(txt_oldPassword);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(ck_showConfirmPassword);
            Controls.Add(ck_showNewPassword);
            Controls.Add(txt_confirmPassword);
            Controls.Add(txt_newPassword);
            Name = "ManageLibrarianChangePassword";
            Text = "ManageLibrarianChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label2;
        private CheckBox ck_showConfirmPassword;
        private CheckBox ck_showNewPassword;
        private TextBox txt_confirmPassword;
        private TextBox txt_newPassword;
        private TextBox txt_oldPassword;
        private CheckBox cb_showOldPassword;
        private Label label1;
        private Button btn_updatePassword;
        private Button btn_back;
        private Button btn_logout;
    }
}