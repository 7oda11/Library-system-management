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
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(276, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(147, 23);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 59);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(276, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(147, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 135);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(303, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(488, 136);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show_Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ManageLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "ManageLoginForm";
            Text = "CommonFroms";
            Load += CommonFroms_Load;
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
    }
}