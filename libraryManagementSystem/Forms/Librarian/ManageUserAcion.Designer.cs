﻿namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageUserAcion
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
            label1 = new Label();
            txt_userName = new TextBox();
            btn_reset = new Button();
            btn_logout = new Button();
            btn_back = new Button();
            btn_search = new Button();
            btn = new Label();
            txt_bookName = new TextBox();
            dgv_logs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 66);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 26;
            label1.Text = "User Name";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(160, 63);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(125, 27);
            txt_userName.TabIndex = 25;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(473, 11);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 29);
            btn_reset.TabIndex = 24;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(865, 13);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 23;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(865, 217);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 22;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(344, 11);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 21;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn
            // 
            btn.AutoSize = true;
            btn.Location = new Point(18, 16);
            btn.Name = "btn";
            btn.Size = new Size(87, 20);
            btn.TabIndex = 20;
            btn.Text = "Book Name";
            // 
            // txt_bookName
            // 
            txt_bookName.Location = new Point(160, 13);
            txt_bookName.Name = "txt_bookName";
            txt_bookName.Size = new Size(125, 27);
            txt_bookName.TabIndex = 19;
            // 
            // dgv_logs
            // 
            dgv_logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_logs.Location = new Point(18, 252);
            dgv_logs.Name = "dgv_logs";
            dgv_logs.RowHeadersWidth = 51;
            dgv_logs.Size = new Size(941, 188);
            dgv_logs.TabIndex = 18;
            // 
            // ManageUserAcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 450);
            Controls.Add(label1);
            Controls.Add(txt_userName);
            Controls.Add(btn_reset);
            Controls.Add(btn_logout);
            Controls.Add(btn_back);
            Controls.Add(btn_search);
            Controls.Add(btn);
            Controls.Add(txt_bookName);
            Controls.Add(dgv_logs);
            Name = "ManageUserAcion";
            Text = "ManageUserAcion";
            Load += ManageUserAcion_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_logs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_userName;
        private Button btn_reset;
        private Button btn_logout;
        private Button btn_back;
        private Button btn_search;
        private Label btn;
        private TextBox txt_bookName;
        private DataGridView dgv_logs;
    }
}