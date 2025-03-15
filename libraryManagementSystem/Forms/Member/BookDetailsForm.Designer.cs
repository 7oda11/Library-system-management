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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailsForm));
            btnBorrow = new Button();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            lblQuantity = new Label();
            btnBack = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBorrow
            // 
            btnBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(463, 425);
            btnBorrow.Margin = new Padding(3, 2, 3, 2);
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
            lblCategory.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(527, 231);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "label2";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(494, 347);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(55, 20);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "label3";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(466, 194);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "label4";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(509, 266);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 20);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "label5";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(659, 425);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 36);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(494, 327);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 8;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(438, 231);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(429, 266);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 10;
            label5.Text = "Quentity:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 464);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(lblQuantity);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(lblCategory);
            Controls.Add(btnBorrow);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookDetailsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBorrow;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblQuantity;
        private Button btnBack;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}