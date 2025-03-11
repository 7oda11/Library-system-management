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
            btnbooks = new Button();
            btnborrowedbooks = new Button();
            btnoverduebooks = new Button();
            SuspendLayout();
            // 
            // btnbooks
            // 
            btnbooks.Location = new Point(253, 42);
            btnbooks.Name = "btnbooks";
            btnbooks.Size = new Size(168, 49);
            btnbooks.TabIndex = 2;
            btnbooks.Text = "Available_Books";
            btnbooks.UseVisualStyleBackColor = true;
            btnbooks.Click += btnbooks_Click;
            // 
            // btnborrowedbooks
            // 
            btnborrowedbooks.Location = new Point(253, 136);
            btnborrowedbooks.Name = "btnborrowedbooks";
            btnborrowedbooks.Size = new Size(168, 52);
            btnborrowedbooks.TabIndex = 3;
            btnborrowedbooks.Text = " Borrowed_Books";
            btnborrowedbooks.UseVisualStyleBackColor = true;
            btnborrowedbooks.Click += btnborrowedbooks_Click;
            // 
            // btnoverduebooks
            // 
            btnoverduebooks.Location = new Point(253, 241);
            btnoverduebooks.Name = "btnoverduebooks";
            btnoverduebooks.Size = new Size(168, 54);
            btnoverduebooks.TabIndex = 4;
            btnoverduebooks.Text = "Overdue_Books";
            btnoverduebooks.UseVisualStyleBackColor = true;
            btnoverduebooks.Click += btnoverduebooks_Click;
            // 
            // ManageReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnoverduebooks);
            Controls.Add(btnborrowedbooks);
            Controls.Add(btnbooks);
            Name = "ManageReportsForm";
            Text = "ManageReportsForm";
            Load += ManageReportsForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnbooks;
        private Button btnborrowedbooks;
        private Button btnoverduebooks;
    }
}