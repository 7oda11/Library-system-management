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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReturnedUserBooksForm));
            dgv_books = new DataGridView();
            btn_return = new Button();
            txt_userName = new TextBox();
            label2 = new Label();
            btn_search = new Button();
            btn_logout = new Button();
            btn_back = new Button();
            pictureBox1 = new PictureBox();
            lbl_message = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_books
            // 
            dgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_books.Location = new Point(1, 257);
            dgv_books.Margin = new Padding(3, 2, 3, 2);
            dgv_books.Name = "dgv_books";
            dgv_books.RowHeadersWidth = 51;
            dgv_books.Size = new Size(978, 204);
            dgv_books.TabIndex = 0;
            dgv_books.RowHeaderMouseDoubleClick += dgv_books_RowHeaderMouseDoubleClick;
            // 
            // btn_return
            // 
            btn_return.BackColor = Color.FromArgb(74, 35, 90);
            btn_return.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_return.ForeColor = SystemColors.ButtonHighlight;
            btn_return.Location = new Point(897, 220);
            btn_return.Margin = new Padding(3, 2, 3, 2);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(82, 33);
            btn_return.TabIndex = 1;
            btn_return.Text = "Return";
            btn_return.UseVisualStyleBackColor = false;
            btn_return.Click += btn_return_Click;
            // 
            // txt_userName
            // 
            txt_userName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_userName.Location = new Point(95, 71);
            txt_userName.Margin = new Padding(3, 2, 3, 2);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(186, 29);
            txt_userName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 74);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(74, 35, 90);
            btn_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.ForeColor = SystemColors.ButtonHighlight;
            btn_search.Location = new Point(59, 122);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(106, 35);
            btn_search.TabIndex = 5;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(74, 35, 90);
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = SystemColors.ButtonHighlight;
            btn_logout.Location = new Point(897, 1);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(82, 34);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(74, 35, 90);
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(1, 1);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(82, 34);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(978, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Location = new Point(751, 56);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(38, 15);
            lbl_message.TabIndex = 9;
            lbl_message.Text = "label1";
            lbl_message.Click += label1_Click;
            // 
            // ManageReturnedUserBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(lbl_message);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_search);
            Controls.Add(label2);
            Controls.Add(txt_userName);
            Controls.Add(btn_return);
            Controls.Add(dgv_books);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageReturnedUserBooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageReturnedUserBooksForm";
            Load += ManageReturnedUserBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_books;
        private Button btn_return;
        private TextBox txt_userName;
        private Label label2;
        private Button btn_search;
        private Button btn_logout;
        private Button btn_back;
        private PictureBox pictureBox1;
        private Label lbl_message;
    }
}