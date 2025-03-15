namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLogs));
            btn_borrowedBook = new Button();
            btn_returningBooks = new Button();
            btn_userAction = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btn_borrowedBook
            // 
            btn_borrowedBook.FlatStyle = FlatStyle.Flat;
            btn_borrowedBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_borrowedBook.ForeColor = Color.White;
            btn_borrowedBook.Location = new Point(22, 180);
            btn_borrowedBook.Margin = new Padding(3, 2, 3, 2);
            btn_borrowedBook.Name = "btn_borrowedBook";
            btn_borrowedBook.Size = new Size(187, 37);
            btn_borrowedBook.TabIndex = 0;
            btn_borrowedBook.Text = "Borrowed Books";
            btn_borrowedBook.UseVisualStyleBackColor = true;
            btn_borrowedBook.Click += btn_borrowedBook_Click;
            // 
            // btn_returningBooks
            // 
            btn_returningBooks.FlatStyle = FlatStyle.Flat;
            btn_returningBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_returningBooks.ForeColor = Color.White;
            btn_returningBooks.Location = new Point(23, 259);
            btn_returningBooks.Margin = new Padding(3, 2, 3, 2);
            btn_returningBooks.Name = "btn_returningBooks";
            btn_returningBooks.Size = new Size(187, 36);
            btn_returningBooks.TabIndex = 1;
            btn_returningBooks.Text = "Returned Books";
            btn_returningBooks.UseVisualStyleBackColor = true;
            btn_returningBooks.Click += btn_returningBooks_Click;
            // 
            // btn_userAction
            // 
            btn_userAction.FlatStyle = FlatStyle.Flat;
            btn_userAction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_userAction.ForeColor = Color.White;
            btn_userAction.Location = new Point(23, 337);
            btn_userAction.Margin = new Padding(3, 2, 3, 2);
            btn_userAction.Name = "btn_userAction";
            btn_userAction.Size = new Size(187, 37);
            btn_userAction.TabIndex = 2;
            btn_userAction.Text = "User Action";
            btn_userAction.UseVisualStyleBackColor = true;
            btn_userAction.Click += btn_userAction_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_userAction);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_returningBooks);
            panel1.Controls.Add(btn_borrowedBook);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 532);
            panel1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 445);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 445);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 117);
            label7.Name = "label7";
            label7.Size = new Size(175, 30);
            label7.TabIndex = 9;
            label7.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Top;
            pictureBox4.Image = Properties.Resources.processed_image;
            pictureBox4.Location = new Point(240, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(546, 532);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // ManageLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(786, 532);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageLogs";
            Text = "ManageLogs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_borrowedBook;
        private Button btn_returningBooks;
        private Button btn_userAction;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}