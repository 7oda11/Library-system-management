namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageLibrarianProfile
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
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_userName = new TextBox();
            btn_update = new Button();
            btn_changePassword = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 206);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 31;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 149);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 81);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 26;
            label1.Text = "User Name";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(189, 202);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(125, 27);
            txt_phone.TabIndex = 25;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(189, 149);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(125, 27);
            txt_email.TabIndex = 24;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(189, 73);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(125, 27);
            txt_userName.TabIndex = 18;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(64, 351);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 32;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_changePassword
            // 
            btn_changePassword.Location = new Point(253, 351);
            btn_changePassword.Name = "btn_changePassword";
            btn_changePassword.Size = new Size(163, 29);
            btn_changePassword.TabIndex = 33;
            btn_changePassword.Text = "Change Password";
            btn_changePassword.UseVisualStyleBackColor = true;
            btn_changePassword.Click += btn_changePassword_Click;
            // 
            // ManageLibrarianProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 509);
            Controls.Add(btn_changePassword);
            Controls.Add(btn_update);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_userName);
            Name = "ManageLibrarianProfile";
            Text = "ManageLibrarianProfile";
            Load += ManageLibrarianProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox txt_phone;
        private TextBox txt_email;
        private TextBox txt_userName;
        private Button btn_update;
        private Button btn_changePassword;
    }
}