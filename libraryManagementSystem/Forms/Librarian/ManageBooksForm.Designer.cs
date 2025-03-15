namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageBooksForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooksForm));
            txt_title = new TextBox();
            txt_auther = new TextBox();
            txt_isbn = new TextBox();
            dt_publishedYear = new DateTimePicker();
            nud_quantity = new NumericUpDown();
            cb_category = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            dvg_books = new DataGridView();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nud_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_books).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_title
            // 
            txt_title.Location = new Point(95, 72);
            txt_title.Margin = new Padding(3, 2, 3, 2);
            txt_title.Multiline = true;
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(124, 23);
            txt_title.TabIndex = 0;
            // 
            // txt_auther
            // 
            txt_auther.Location = new Point(95, 131);
            txt_auther.Margin = new Padding(3, 2, 3, 2);
            txt_auther.Multiline = true;
            txt_auther.Name = "txt_auther";
            txt_auther.Size = new Size(124, 23);
            txt_auther.TabIndex = 1;
            // 
            // txt_isbn
            // 
            txt_isbn.BackColor = Color.White;
            txt_isbn.BorderStyle = BorderStyle.FixedSingle;
            txt_isbn.Location = new Point(95, 20);
            txt_isbn.Margin = new Padding(3, 2, 3, 2);
            txt_isbn.Multiline = true;
            txt_isbn.Name = "txt_isbn";
            txt_isbn.Size = new Size(124, 23);
            txt_isbn.TabIndex = 2;
            // 
            // dt_publishedYear
            // 
            dt_publishedYear.CustomFormat = "yyyy";
            dt_publishedYear.Format = DateTimePickerFormat.Custom;
            dt_publishedYear.Location = new Point(377, 128);
            dt_publishedYear.Margin = new Padding(3, 2, 3, 2);
            dt_publishedYear.Name = "dt_publishedYear";
            dt_publishedYear.ShowUpDown = true;
            dt_publishedYear.Size = new Size(174, 23);
            dt_publishedYear.TabIndex = 3;
            // 
            // nud_quantity
            // 
            nud_quantity.Location = new Point(377, 20);
            nud_quantity.Margin = new Padding(3, 2, 3, 2);
            nud_quantity.Name = "nud_quantity";
            nud_quantity.Size = new Size(174, 23);
            nud_quantity.TabIndex = 4;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(377, 72);
            cb_category.Margin = new Padding(3, 2, 3, 2);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(174, 23);
            cb_category.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 44, 111);
            label1.Location = new Point(17, 74);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 6;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(91, 44, 111);
            label2.Location = new Point(14, 133);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 7;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(91, 44, 111);
            label3.Location = new Point(14, 22);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 8;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(91, 44, 111);
            label4.Location = new Point(248, 130);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 9;
            label4.Text = "Published Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(91, 44, 111);
            label5.Location = new Point(275, 20);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 10;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(91, 44, 111);
            label6.Location = new Point(275, 74);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 11;
            label6.Text = "Category";
            // 
            // btn_delete
            // 
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(11, 192);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(159, 39);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.WhiteSmoke;
            btn_update.Location = new Point(11, 272);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(159, 39);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(787, 155);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(82, 22);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dvg_books
            // 
            dvg_books.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(142, 68, 173);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvg_books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvg_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_books.EnableHeadersVisualStyles = false;
            dvg_books.Location = new Point(-1, 39);
            dvg_books.Margin = new Padding(3, 2, 3, 2);
            dvg_books.Name = "dvg_books";
            dvg_books.RowHeadersWidth = 51;
            dvg_books.Size = new Size(574, 180);
            dvg_books.TabIndex = 15;
            dvg_books.CellContentClick += dvg_books_CellContentClick;
            dvg_books.RowHeaderMouseDoubleClick += dvg_books_RowHeaderMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 532);
            panel1.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(51, 456);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 117);
            label7.Name = "label7";
            label7.Size = new Size(175, 30);
            label7.TabIndex = 9;
            label7.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dvg_books);
            panel2.Location = new Point(196, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 255);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(nud_quantity);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cb_category);
            panel3.Controls.Add(dt_publishedYear);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txt_auther);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txt_isbn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txt_title);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(196, 284);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 236);
            panel3.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 356);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ManageBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(786, 532);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_add);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageBooksForm";
            Text = "ManageBooksForm";
            Load += ManageBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_books).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_title;
        private TextBox txt_auther;
        private TextBox txt_isbn;
        private DateTimePicker dt_publishedYear;
        private NumericUpDown nud_quantity;
        private ComboBox cb_category;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dvg_books;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}