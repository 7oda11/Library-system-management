namespace libraryManagementSystem.Forms.Member
{
    partial class BookDetailsForm
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
            btnBorrow = new Button();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            lblQuantity = new Label();
            btnBack = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 33);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 0;
            label1.Text = "Book Details";
            // 
            // btnBorrow
            // 
            btnBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(128, 235);
            btnBorrow.Margin = new Padding(3, 4, 3, 4);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(86, 48);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(395, 105);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(70, 28);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "label2";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(149, 157);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(70, 28);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "label3";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(149, 105);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(70, 28);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "label4";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(395, 157);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 28);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "label5";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(341, 235);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 48);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 105);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 7;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 157);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 8;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(293, 105);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 9;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(290, 157);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 10;
            label5.Text = "Quentity:";
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(lblQuantity);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(lblCategory);
            Controls.Add(btnBorrow);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookDetailsForm";
            Text = "BookDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBorrow;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblQuantity;
        private Button btnBack;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}