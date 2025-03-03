namespace libraryManagementSystem.Forms.CommonFroms
{
    partial class ManageRegisterForm
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
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtConfirmPassword = new TextBox();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblPhone = new Label();
            lblConfirmPassword = new Label();
            btnRegister = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(176, 62);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(109, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(562, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(109, 23);
            txtPhone.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(109, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(562, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(109, 23);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(176, 182);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(109, 23);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(47, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(472, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(47, 116);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(472, 137);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(47, 182);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(101, 15);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "ConfirmPassword";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(297, 290);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(106, 39);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(329, 120);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "ShowPassword";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(329, 186);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "ShowPassword";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // ManageRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnRegister);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPhone);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Name = "ManageRegisterForm";
            Text = "ManageRegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtConfirmPassword;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblPhone;
        private Label lblConfirmPassword;
        private Button btnRegister;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}