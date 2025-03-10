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
            btnoverduebooks = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnoverduebooks
            // 
            btnoverduebooks.Location = new Point(257, 73);
            btnoverduebooks.Name = "btnoverduebooks";
            btnoverduebooks.Size = new Size(149, 41);
            btnoverduebooks.TabIndex = 5;
            btnoverduebooks.Text = "Generate_Report";
            btnoverduebooks.UseVisualStyleBackColor = true;
            btnoverduebooks.Click += btnoverduebooks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(713, 189);
            dataGridView1.TabIndex = 6;
            // 
            // ManageOverdueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnoverduebooks);
            Name = "ManageOverdueBooks";
            Text = "ManageOverdueBooks";
            Load += ManageOverdueBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnoverduebooks;
        private DataGridView dataGridView1;
    }
}