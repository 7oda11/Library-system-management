﻿namespace libraryManagementSystem.Forms.CommonFroms
{
    partial class ManageHomeForm
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
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(85, 26, 139);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(88, 491);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(11, 7, 11, 7);
            btnRegister.Size = new Size(209, 53);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "SignUp";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_library_100px;
            pictureBox1.Location = new Point(281, 36);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 269);
            label1.Name = "label1";
            label1.Size = new Size(616, 32);
            label1.TabIndex = 9;
            label1.Text = "Welcome To Our Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(85, 26, 139);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(488, 491);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(11, 7, 11, 7);
            btnLogin.Size = new Size(208, 53);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // ManageHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(74, 35, 90);
            ClientSize = new Size(752, 699);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "c";
            Load += ManageHomeForm_Load;
            Paint += ManageHomeForm_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // private Button btnLogin;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLogin;
    }
}