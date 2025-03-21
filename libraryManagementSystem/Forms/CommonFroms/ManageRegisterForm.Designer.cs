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
            checkBox1.Location = new Point(317, 416);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "ShowPassword";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(317, 505);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(128, 24);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "ShowPassword";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 60);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(792, 15);
            label3.Name = "label3";
            label3.Size = new Size(23, 22);
            label3.TabIndex = 0;
            label3.Text = "X";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(190, 287);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 34);
            txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(190, 369);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 34);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(190, 459);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(247, 34);
            txtConfirmPassword.TabIndex = 16;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(543, 376);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(269, 34);
            txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(543, 296);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 34);
            txtEmail.TabIndex = 18;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(44, 62, 80);
            lblUsername.Location = new Point(14, 296);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(103, 22);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblPassword.Location = new Point(17, 376);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 22);
            lblPassword.TabIndex = 20;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(44, 62, 80);
            lblConfirmPassword.Location = new Point(1, 465);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(177, 22);
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
            lblEmail.Location = new Point(462, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 22);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(44, 62, 80);
            lblPhone.Location = new Point(462, 385);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 22);
            lblPhone.TabIndex = 23;
            lblPhone.Text = "Phone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inscription_11021904;
            pictureBox1.Location = new Point(337, 65);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 44, 111);
            label4.Location = new Point(321, 201);
            label4.Name = "label4";
            label4.Size = new Size(159, 32);
            label4.TabIndex = 25;
            label4.Text = "Registration ";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(142, 68, 173);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(282, 571);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(11, 7, 11, 7);
            btnRegister.Size = new Size(254, 57);
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
            btnLogin.Location = new Point(282, 675);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(11, 7, 11, 7);
            btnLogin.Size = new Size(254, 56);
            btnLogin.TabIndex = 27;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // ManageRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(826, 735);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
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