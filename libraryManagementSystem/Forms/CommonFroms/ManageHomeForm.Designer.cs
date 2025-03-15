namespace libraryManagementSystem.Forms.CommonFroms
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
            btnRegister.Location = new Point(77, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(10, 5, 10, 5);
            btnRegister.Size = new Size(183, 40);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "SignUp";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_library_100px;
            pictureBox1.Location = new Point(246, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 203);
            label1.Name = "label1";
            label1.Size = new Size(470, 24);
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
            btnLogin.Location = new Point(427, 368);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(10, 5, 10, 5);
            btnLogin.Size = new Size(182, 40);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // ManageHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(74, 35, 90);
            ClientSize = new Size(658, 524);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManageHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageHomeForm";
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