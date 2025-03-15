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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLibrarianProfile));
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_userName = new TextBox();
            btn_update = new Button();
            btn_changePassword = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(74, 35, 90);
            label6.Location = new Point(18, 190);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 31;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(74, 35, 90);
            label5.Location = new Point(18, 133);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 35, 90);
            label1.Location = new Point(18, 80);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 26;
            label1.Text = "User Name";
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_phone.Location = new Point(118, 187);
            txt_phone.Margin = new Padding(3, 2, 3, 2);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(162, 29);
            txt_phone.TabIndex = 25;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(118, 130);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(162, 29);
            txt_email.TabIndex = 24;
            // 
            // txt_userName
            // 
            txt_userName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_userName.Location = new Point(118, 77);
            txt_userName.Margin = new Padding(3, 2, 3, 2);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(162, 29);
            txt_userName.TabIndex = 18;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(74, 35, 90);
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(18, 288);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(106, 36);
            btn_update.TabIndex = 32;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_changePassword
            // 
            btn_changePassword.BackColor = Color.Purple;
            btn_changePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_changePassword.ForeColor = SystemColors.ButtonHighlight;
            btn_changePassword.Location = new Point(18, 239);
            btn_changePassword.Margin = new Padding(3, 2, 3, 2);
            btn_changePassword.Name = "btn_changePassword";
            btn_changePassword.Size = new Size(151, 35);
            btn_changePassword.TabIndex = 33;
            btn_changePassword.Text = "Change Password";
            btn_changePassword.UseVisualStyleBackColor = false;
            btn_changePassword.Click += btn_changePassword_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 60);
            panel1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(213, 21);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 0;
            label2.Text = "Manage Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // ManageLibrarianProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 382);
            Controls.Add(panel1);
            Controls.Add(btn_changePassword);
            Controls.Add(btn_update);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_userName);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageLibrarianProfile";
            Text = "ManageLibrarianProfile";
            Load += ManageLibrarianProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}