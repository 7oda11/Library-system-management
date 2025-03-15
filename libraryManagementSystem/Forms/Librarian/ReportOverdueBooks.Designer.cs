namespace libraryManagementSystem.Forms.Librarian
{
    partial class ReportOverdueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOverdueBooks));
            btnoverduebooks = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnoverduebooks
            // 
            btnoverduebooks.FlatStyle = FlatStyle.Flat;
            btnoverduebooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnoverduebooks.ForeColor = Color.White;
            btnoverduebooks.Location = new Point(32, 208);
            btnoverduebooks.Name = "btnoverduebooks";
            btnoverduebooks.Size = new Size(167, 41);
            btnoverduebooks.TabIndex = 5;
            btnoverduebooks.Text = "Generate_Report";
            btnoverduebooks.UseVisualStyleBackColor = true;
            btnoverduebooks.Click += btnoverduebooks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 189);
            dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 35, 90);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnoverduebooks);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 532);
            panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(70, 434);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(32, 120);
            label7.Name = "label7";
            label7.Size = new Size(175, 30);
            label7.TabIndex = 9;
            label7.Text = "Welcome,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(74, 35, 90);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(224, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(573, 45);
            panel3.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(543, 13);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 1;
            label3.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(230, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 283);
            panel2.TabIndex = 34;
            // 
            // ReportOverdueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(797, 532);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ReportOverdueBooks";
            Text = "ManageOverdueBooks";
            Load += ManageOverdueBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnoverduebooks;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
    }
}