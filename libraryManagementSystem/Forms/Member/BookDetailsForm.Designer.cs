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
            label1.Location = new Point(130, 25);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "Book Details";
            // 
            // btnBorrow
            // 
            btnBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(112, 176);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(75, 36);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(346, 79);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(57, 21);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "label2";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(130, 118);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 21);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "label3";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(130, 79);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(57, 21);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "label4";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(346, 118);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(57, 21);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "label5";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(298, 176);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 36);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 79);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 7;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 118);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 8;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(256, 79);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 9;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(254, 118);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 10;
            label5.Text = "Quentity:";
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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