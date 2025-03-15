namespace libraryManagementSystem.Forms.CommonFroms
{
    partial class ManageLoginForm
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
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnRegister = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(242, 237);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(234, 26);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(83, 245);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(242, 312);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(234, 26);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(85, 320);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(142, 68, 173);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(266, 417);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(10, 5, 10, 5);
            btnLogin.Size = new Size(169, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(44, 62, 80);
            checkBox1.Location = new Point(356, 356);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show_Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 48);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(641, 9);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 0;
            label3.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inscription_110219041;
            pictureBox1.Location = new Point(284, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 44, 111);
            label4.Location = new Point(271, 167);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 8;
            label4.Text = "Login Form";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(142, 68, 173);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(266, 496);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(10, 5, 10, 5);
            btnRegister.Size = new Size(169, 43);
            btnRegister.TabIndex = 27;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // ManageLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(671, 551);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManageLoginForm";
            Text = "CommonFroms";
            Load += CommonFroms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnRegister;
    }
}