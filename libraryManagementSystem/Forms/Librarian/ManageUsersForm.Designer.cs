namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageUsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            dgv_users = new DataGridView();
            txt_userName = new TextBox();
            txt_password = new TextBox();
            txt_confirmPassword = new TextBox();
            ck_showPassword = new CheckBox();
            ck_showConfirmPassword = new CheckBox();
            cb_role = new ComboBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(142, 68, 173);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Location = new Point(-1, 45);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(696, 219);
            dgv_users.TabIndex = 0;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(201, 64);
            txt_userName.Multiline = true;
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(154, 35);
            txt_userName.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(201, 147);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(154, 29);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(201, 241);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(154, 27);
            txt_confirmPassword.TabIndex = 3;
            txt_confirmPassword.UseSystemPasswordChar = true;
            txt_confirmPassword.TextChanged += txt_confirmPassword_TextChanged;
            // 
            // ck_showPassword
            // 
            ck_showPassword.AutoSize = true;
            ck_showPassword.Location = new Point(232, 188);
            ck_showPassword.Name = "ck_showPassword";
            ck_showPassword.Size = new Size(132, 24);
            ck_showPassword.TabIndex = 4;
            ck_showPassword.Text = "Show Password";
            ck_showPassword.UseVisualStyleBackColor = true;
            ck_showPassword.CheckedChanged += ck_showPassword_CheckedChanged;
            // 
            // ck_showConfirmPassword
            // 
            ck_showConfirmPassword.AutoSize = true;
            ck_showConfirmPassword.Location = new Point(232, 283);
            ck_showConfirmPassword.Name = "ck_showConfirmPassword";
            ck_showConfirmPassword.Size = new Size(132, 24);
            ck_showConfirmPassword.TabIndex = 5;
            ck_showConfirmPassword.Text = "Show Password";
            ck_showConfirmPassword.UseVisualStyleBackColor = true;
            ck_showConfirmPassword.CheckedChanged += ck_showConfirmPassword_CheckedChanged;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(543, 244);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(151, 28);
            cb_role.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(543, 147);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(151, 35);
            txt_email.TabIndex = 7;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(543, 67);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(151, 35);
            txt_phone.TabIndex = 8;
            // 
            // btn_delete
            // 
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(25, 469);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(171, 41);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(25, 367);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(171, 44);
            btn_update.TabIndex = 10;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(25, 279);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(171, 40);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 44, 111);
            label1.Location = new Point(27, 72);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 12;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(91, 44, 111);
            label2.Location = new Point(27, 157);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label
            // 
            label.AutoSize = true;
            label.FlatStyle = FlatStyle.Flat;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(91, 44, 111);
            label.Location = new Point(14, 239);
            label.Name = "label";
            label.Size = new Size(183, 28);
            label.TabIndex = 14;
            label.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 44, 111);
            label4.Location = new Point(456, 239);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 15;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(91, 44, 111);
            label5.Location = new Point(446, 155);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(91, 44, 111);
            label6.Location = new Point(439, 75);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 17;
            label6.Text = "Phone";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_delete);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 709);
            panel1.TabIndex = 28;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(56, 609);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 155);
            label7.Name = "label7";
            label7.Size = new Size(228, 37);
            label7.TabIndex = 9;
            label7.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 17);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgv_users);
            panel2.Location = new Point(221, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 323);
            panel2.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_phone);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txt_email);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label);
            panel3.Controls.Add(ck_showPassword);
            panel3.Controls.Add(ck_showConfirmPassword);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txt_password);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cb_role);
            panel3.Controls.Add(txt_confirmPassword);
            panel3.Controls.Add(txt_userName);
            panel3.Location = new Point(221, 368);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 341);
            panel3.TabIndex = 30;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(930, 709);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsersForm";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_users;
        private TextBox txt_userName;
        private TextBox txt_password;
        private TextBox txt_confirmPassword;
        private CheckBox ck_showPassword;
        private CheckBox ck_showConfirmPassword;
        private ComboBox cb_role;
        private TextBox txt_email;
        private TextBox txt_phone;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label label1;
        private Label label2;
        private Label label;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
    }
}