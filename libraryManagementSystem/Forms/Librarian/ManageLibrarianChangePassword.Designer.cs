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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLibrarianChangePassword));
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
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(74, 35, 90);
            label.Location = new Point(28, 203);
            label.Name = "label";
            label.Size = new Size(148, 21);
            label.TabIndex = 20;
            label.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(74, 35, 90);
            label2.Location = new Point(28, 151);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 19;
            label2.Text = "New Password";
            // 
            // ck_showConfirmPassword
            // 
            ck_showConfirmPassword.AutoSize = true;
            ck_showConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ck_showConfirmPassword.ForeColor = Color.FromArgb(74, 35, 90);
            ck_showConfirmPassword.Location = new Point(360, 238);
            ck_showConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            ck_showConfirmPassword.Name = "ck_showConfirmPassword";
            ck_showConfirmPassword.Size = new Size(112, 19);
            ck_showConfirmPassword.TabIndex = 18;
            ck_showConfirmPassword.Text = "Show Password";
            ck_showConfirmPassword.UseVisualStyleBackColor = true;
            ck_showConfirmPassword.CheckedChanged += ck_showConfirmPassword_CheckedChanged;
            // 
            // ck_showNewPassword
            // 
            ck_showNewPassword.AutoSize = true;
            ck_showNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ck_showNewPassword.ForeColor = Color.FromArgb(74, 35, 90);
            ck_showNewPassword.Location = new Point(360, 183);
            ck_showNewPassword.Margin = new Padding(3, 2, 3, 2);
            ck_showNewPassword.Name = "ck_showNewPassword";
            ck_showNewPassword.Size = new Size(112, 19);
            ck_showNewPassword.TabIndex = 17;
            ck_showNewPassword.Text = "Show Password";
            ck_showNewPassword.UseVisualStyleBackColor = true;
            ck_showNewPassword.CheckedChanged += ck_showNewPassword_CheckedChanged;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confirmPassword.Location = new Point(182, 203);
            txt_confirmPassword.Margin = new Padding(3, 2, 3, 2);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(181, 29);
            txt_confirmPassword.TabIndex = 16;
            txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // txt_newPassword
            // 
            txt_newPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_newPassword.Location = new Point(182, 150);
            txt_newPassword.Margin = new Padding(3, 2, 3, 2);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(181, 29);
            txt_newPassword.TabIndex = 15;
            txt_newPassword.UseSystemPasswordChar = true;
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_oldPassword.Location = new Point(182, 95);
            txt_oldPassword.Margin = new Padding(3, 2, 3, 2);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.Size = new Size(181, 29);
            txt_oldPassword.TabIndex = 21;
            txt_oldPassword.UseSystemPasswordChar = true;
            // 
            // cb_showOldPassword
            // 
            cb_showOldPassword.AutoSize = true;
            cb_showOldPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_showOldPassword.ForeColor = Color.FromArgb(74, 35, 90);
            cb_showOldPassword.Location = new Point(360, 127);
            cb_showOldPassword.Margin = new Padding(3, 2, 3, 2);
            cb_showOldPassword.Name = "cb_showOldPassword";
            cb_showOldPassword.Size = new Size(112, 19);
            cb_showOldPassword.TabIndex = 22;
            cb_showOldPassword.Text = "Show Password";
            cb_showOldPassword.UseVisualStyleBackColor = true;
            cb_showOldPassword.CheckedChanged += cb_showOldPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 35, 90);
            label1.Location = new Point(28, 103);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 23;
            label1.Text = "Old Password";
            // 
            // btn_updatePassword
            // 
            btn_updatePassword.BackColor = Color.FromArgb(74, 35, 90);
            btn_updatePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_updatePassword.ForeColor = SystemColors.ButtonHighlight;
            btn_updatePassword.Location = new Point(28, 270);
            btn_updatePassword.Margin = new Padding(3, 2, 3, 2);
            btn_updatePassword.Name = "btn_updatePassword";
            btn_updatePassword.Size = new Size(134, 32);
            btn_updatePassword.TabIndex = 24;
            btn_updatePassword.Text = "Update Password";
            btn_updatePassword.UseVisualStyleBackColor = false;
            btn_updatePassword.Click += btn_updatePassword_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Purple;
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(571, 365);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 33);
            btn_back.TabIndex = 25;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Gray;
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = SystemColors.ButtonFace;
            btn_logout.Location = new Point(603, 66);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(92, 32);
            btn_logout.TabIndex = 26;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 58);
            panel1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(74, 35, 90);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(259, 16);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 28;
            label3.Text = "Change Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // ManageLibrarianChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 409);
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
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageLibrarianChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageLibrarianChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}