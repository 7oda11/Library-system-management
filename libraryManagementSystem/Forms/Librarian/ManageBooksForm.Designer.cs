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
            ((System.ComponentModel.ISupportInitialize)nud_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_books).BeginInit();
            SuspendLayout();
            // 
            // txt_title
            // 
            txt_title.Location = new Point(136, 40);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(125, 27);
            txt_title.TabIndex = 0;
            // 
            // txt_auther
            // 
            txt_auther.Location = new Point(136, 110);
            txt_auther.Name = "txt_auther";
            txt_auther.Size = new Size(125, 27);
            txt_auther.TabIndex = 1;
            // 
            // txt_isbn
            // 
            txt_isbn.Location = new Point(136, 172);
            txt_isbn.Name = "txt_isbn";
            txt_isbn.Size = new Size(125, 27);
            txt_isbn.TabIndex = 2;
            // 
            // dt_publishedYear
            // 
            dt_publishedYear.CustomFormat = "yyyy";
            dt_publishedYear.Format = DateTimePickerFormat.Custom;
            dt_publishedYear.Location = new Point(404, 40);
            dt_publishedYear.Name = "dt_publishedYear";
            dt_publishedYear.ShowUpDown = true;
            dt_publishedYear.Size = new Size(250, 27);
            dt_publishedYear.TabIndex = 3;
            // 
            // nud_quantity
            // 
            nud_quantity.Location = new Point(387, 110);
            nud_quantity.Name = "nud_quantity";
            nud_quantity.Size = new Size(150, 27);
            nud_quantity.TabIndex = 4;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(386, 171);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(151, 28);
            cb_category.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 6;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 113);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "Auther";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 179);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 8;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 43);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 9;
            label4.Text = "Published Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 113);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 10;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 175);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 11;
            label6.Text = "Category";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(630, 207);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(756, 207);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(899, 207);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dvg_books
            // 
            dvg_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_books.Location = new Point(12, 278);
            dvg_books.Name = "dvg_books";
            dvg_books.RowHeadersWidth = 51;
            dvg_books.Size = new Size(1039, 203);
            dvg_books.TabIndex = 15;
            dvg_books.RowHeaderMouseDoubleClick += dvg_books_RowHeaderMouseDoubleClick;
            // 
            // ManageBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 493);
            Controls.Add(dvg_books);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_category);
            Controls.Add(nud_quantity);
            Controls.Add(dt_publishedYear);
            Controls.Add(txt_isbn);
            Controls.Add(txt_auther);
            Controls.Add(txt_title);
            Name = "ManageBooksForm";
            Text = "ManageBooksForm";
            Load += ManageBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_books).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}