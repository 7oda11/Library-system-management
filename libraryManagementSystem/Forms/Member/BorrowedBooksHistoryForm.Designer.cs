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
            btn_logout = new Button();
            btn_back = new Button();
            dgv_history = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_history).BeginInit();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(676, 9);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(82, 22);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(10, 9);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(82, 22);
            btn_back.TabIndex = 1;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // dgv_history
            // 
            dgv_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history.Location = new Point(10, 232);
            dgv_history.Margin = new Padding(3, 2, 3, 2);
            dgv_history.Name = "dgv_history";
            dgv_history.RowHeadersWidth = 51;
            dgv_history.Size = new Size(747, 141);
            dgv_history.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 112);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 3;
            label1.Text = "Borrowed Bocks History";
            // 
            // BorrowedBooksHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 382);
            Controls.Add(label1);
            Controls.Add(dgv_history);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BorrowedBooksHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowedBooksHistoryForm";
            Load += BorrowedBooksHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_history).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logout;
        private Button btn_back;
        private DataGridView dgv_history;
        private Label label1;
    }
}