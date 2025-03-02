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
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Location = new Point(12, 347);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(974, 218);
            dgv_users.TabIndex = 0;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(224, 49);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(125, 27);
            txt_userName.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(224, 102);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(125, 27);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(224, 159);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(125, 27);
            txt_confirmPassword.TabIndex = 3;
            txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // ck_showPassword
            // 
            ck_showPassword.AutoSize = true;
            ck_showPassword.Location = new Point(265, 135);
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
            ck_showConfirmPassword.Location = new Point(265, 201);
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
            cb_role.Location = new Point(532, 48);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(151, 28);
            cb_role.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(532, 106);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(125, 27);
            txt_email.TabIndex = 7;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(532, 159);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(125, 27);
            txt_phone.TabIndex = 8;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(537, 245);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(689, 245);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 10;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(823, 245);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 12;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(55, 176);
            label.Name = "label";
            label.Size = new Size(127, 20);
            label.TabIndex = 14;
            label.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 51);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 15;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 108);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 165);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 17;
            label6.Text = "Phone";
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 577);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(cb_role);
            Controls.Add(ck_showConfirmPassword);
            Controls.Add(ck_showPassword);
            Controls.Add(txt_confirmPassword);
            Controls.Add(txt_password);
            Controls.Add(txt_userName);
            Controls.Add(dgv_users);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}