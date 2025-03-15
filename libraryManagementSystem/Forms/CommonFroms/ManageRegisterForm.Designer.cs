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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1 = new Panel();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(214, 305);
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
            checkBox2.Location = new Point(214, 384);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "ShowPassword";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 45);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(633, 11);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 0;
            label3.Text = "X";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(149, 212);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 22);
            txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(149, 277);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(170, 22);
            txtPassword.TabIndex = 15;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(149, 347);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(170, 22);
            txtConfirmPassword.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(503, 280);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 22);
            txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(503, 217);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 22);
            txtEmail.TabIndex = 18;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(44, 62, 80);
            lblUsername.Location = new Point(17, 217);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 17);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblPassword.Location = new Point(17, 282);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 17);
            lblPassword.TabIndex = 20;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblConfirmPassword.Location = new Point(1, 349);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(142, 17);
            lblConfirmPassword.TabIndex = 21;
            lblConfirmPassword.Text = "Confirm Password";
            lblConfirmPassword.TextAlign = ContentAlignment.MiddleCenter;
            lblConfirmPassword.Click += lblConfirmPassword_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmail.Location = new Point(393, 222);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 17);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(44, 62, 80);
            lblPhone.Location = new Point(393, 285);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 17);
            lblPhone.TabIndex = 23;
            lblPhone.Text = "Phone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inscription_11021904;
            pictureBox1.Location = new Point(295, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(91, 44, 111);
            label4.Location = new Point(258, 142);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 25;
            label4.Text = "Registration Form";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(142, 68, 173);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(247, 418);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(10, 5, 10, 5);
            btnRegister.Size = new Size(222, 43);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(142, 68, 173);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(247, 497);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(10, 5, 10, 5);
            btnLogin.Size = new Size(222, 42);
            btnLogin.TabIndex = 27;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // ManageRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(671, 551);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManageRegisterForm";
            Text = "ManageRegisterForm";
            Load += ManageRegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtPhone;
        private TextBox txtEmail;
       // private Label lblUsername;
        private Label lblPassword;
        private Label lblUsername;
       // private Label lblPhone;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnRegister;
        private Label lblConfirmPassword;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel1;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblEmail;
        private Label lblPhone;
        private Button btnLogin;
    }
}