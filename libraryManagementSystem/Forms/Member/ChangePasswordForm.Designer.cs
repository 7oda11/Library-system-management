namespace libraryManagementSystem.Forms.Member
{
    partial class ChangePasswordForm
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
            btnSave = new Button();
            chkShowPassword = new CheckBox();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 78);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(200, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(470, 190);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(71, 25);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Show";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(331, 184);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(100, 23);
            txtConfirmPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 186);
            label3.Name = "label3";
            label3.Size = new Size(187, 21);
            label3.TabIndex = 5;
            label3.Text = "Confirm New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(137, 134);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 6;
            label4.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(331, 136);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(100, 23);
            txtNewPassword.TabIndex = 7;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(331, 76);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(100, 23);
            txtOldPassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(356, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtOldPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtConfirmPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private CheckBox chkShowPassword;
        private TextBox txtConfirmPassword;
        private Label label3;
        private Label label4;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Button button1;
    }
}