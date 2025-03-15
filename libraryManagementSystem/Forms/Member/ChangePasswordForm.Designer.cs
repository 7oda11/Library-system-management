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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            label1 = new Label();
            btnSave = new Button();
            chkShowPassword = new CheckBox();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 35, 90);
            label1.Location = new Point(35, 108);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Purple;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(97, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 39);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.FromArgb(74, 35, 90);
            chkShowPassword.Location = new Point(370, 238);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(71, 25);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Show";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(189, 199);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(181, 33);
            txtConfirmPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(74, 35, 90);
            label3.Location = new Point(35, 205);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(74, 35, 90);
            label4.Location = new Point(35, 153);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 6;
            label4.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(189, 153);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(181, 33);
            txtNewPassword.TabIndex = 7;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPassword.Location = new Point(189, 108);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(181, 33);
            txtOldPassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(286, 282);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 54);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(218, 10);
            label2.Name = "label2";
            label2.Size = new Size(176, 30);
            label2.TabIndex = 11;
            label2.Text = "Change Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(684, 461);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtOldPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtConfirmPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}