namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageReturnedUserBooksForm
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
            dgv_books = new DataGridView();
            btn_return = new Button();
            lbl_message = new Label();
            txt_userName = new TextBox();
            label2 = new Label();
            btn_search = new Button();
            btn_logout = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            SuspendLayout();
            // 
            // dgv_books
            // 
            dgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_books.Location = new Point(12, 378);
            dgv_books.Name = "dgv_books";
            dgv_books.RowHeadersWidth = 51;
            dgv_books.Size = new Size(1128, 236);
            dgv_books.TabIndex = 0;
            dgv_books.RowHeaderMouseDoubleClick += dgv_books_RowHeaderMouseDoubleClick;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(36, 300);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(94, 29);
            btn_return.TabIndex = 1;
            btn_return.Text = "Return";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Location = new Point(145, 304);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(50, 20);
            lbl_message.TabIndex = 2;
            lbl_message.Text = "label1";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(463, 240);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(125, 27);
            txt_userName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 247);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(639, 238);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 5;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(1046, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ManageReturnedUserBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 626);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_search);
            Controls.Add(label2);
            Controls.Add(txt_userName);
            Controls.Add(lbl_message);
            Controls.Add(btn_return);
            Controls.Add(dgv_books);
            Name = "ManageReturnedUserBooksForm";
            Text = "ManageReturnedUserBooksForm";
            Load += ManageReturnedUserBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_books;
        private Button btn_return;
        private Label lbl_message;
        private TextBox txt_userName;
        private Label label2;
        private Button btn_search;
        private Button btn_logout;
        private Button btn_back;
    }
}