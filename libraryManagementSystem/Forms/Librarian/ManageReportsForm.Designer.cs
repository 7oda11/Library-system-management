namespace libraryManagementSystem.Forms.Librarian
{
    partial class ManageReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReportsForm));
            btnbooks = new Button();
            btnborrowedbooks = new Button();
            btnoverduebooks = new Button();
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
            // btnbooks
            // 
            btnbooks.FlatStyle = FlatStyle.Flat;
            btnbooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbooks.ForeColor = Color.White;
            btnbooks.Location = new Point(33, 190);
            btnbooks.Name = "btnbooks";
            btnbooks.Size = new Size(175, 42);
            btnbooks.TabIndex = 2;
            btnbooks.Text = "Available_Books";
            btnbooks.UseVisualStyleBackColor = true;
            btnbooks.Click += btnbooks_Click;
            // 
            // btnborrowedbooks
            // 
            btnborrowedbooks.FlatStyle = FlatStyle.Flat;
            btnborrowedbooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnborrowedbooks.ForeColor = Color.White;
            btnborrowedbooks.Location = new Point(33, 273);
            btnborrowedbooks.Name = "btnborrowedbooks";
            btnborrowedbooks.Size = new Size(175, 38);
            btnborrowedbooks.TabIndex = 3;
            btnborrowedbooks.Text = " Borrowed_Books";
            btnborrowedbooks.UseVisualStyleBackColor = true;
            btnborrowedbooks.Click += btnborrowedbooks_Click;
            // 
            // btnoverduebooks
            // 
            btnoverduebooks.FlatStyle = FlatStyle.Flat;
            btnoverduebooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnoverduebooks.ForeColor = Color.White;
            btnoverduebooks.Location = new Point(33, 349);
            btnoverduebooks.Name = "btnoverduebooks";
            btnoverduebooks.Size = new Size(175, 43);
            btnoverduebooks.TabIndex = 4;
            btnoverduebooks.Text = "Overdue_Books";
            btnoverduebooks.UseVisualStyleBackColor = true;
            btnoverduebooks.Click += btnoverduebooks_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnoverduebooks);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnborrowedbooks);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnbooks);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 532);
            panel1.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 445);
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
            pictureBox1.Location = new Point(145, 445);
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
            label7.Location = new Point(33, 117);
            label7.Name = "label7";
            label7.Size = new Size(175, 30);
            label7.TabIndex = 9;
            label7.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Top;
            pictureBox4.Image = Properties.Resources.photorealistic_colorful_smoke;
            pictureBox4.Location = new Point(240, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(546, 532);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // ManageReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(786, 532);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Name = "ManageReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageReportsForm";
            Load += ManageReportsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnbooks;
        private Button btnborrowedbooks;
        private Button btnoverduebooks;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}