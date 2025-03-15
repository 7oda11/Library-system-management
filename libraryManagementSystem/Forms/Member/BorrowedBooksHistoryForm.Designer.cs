namespace libraryManagementSystem.Forms.Member
{
    partial class BorrowedBooksHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowedBooksHistoryForm));
            btn_logout = new Button();
            btn_back = new Button();
            dgv_history = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_history).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(74, 35, 90);
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = SystemColors.ButtonHighlight;
            btn_logout.Location = new Point(569, 3);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(112, 37);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(74, 35, 90);
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(3, 3);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 37);
            btn_back.TabIndex = 1;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // dgv_history
            // 
            dgv_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history.Location = new Point(3, 221);
            dgv_history.Margin = new Padding(3, 2, 3, 2);
            dgv_history.Name = "dgv_history";
            dgv_history.RowHeadersWidth = 51;
            dgv_history.Size = new Size(678, 239);
            dgv_history.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(678, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BorrowedBooksHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(dgv_history);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BorrowedBooksHistoryForm";
            Text = "BorrowedBooksHistoryForm";
            Load += BorrowedBooksHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_history).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_logout;
        private Button btn_back;
        private DataGridView dgv_history;
        private PictureBox pictureBox1;
    }
}