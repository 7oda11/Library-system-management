using ClosedXML.Excel;
using FastMember;
using libraryManagementSystem.Forms.CommonFroms;
using libraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem.Forms.Librarian
{
    public partial class ReportAvaliableBooks : Form
    {
        public ReportAvaliableBooks()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string category = txtCategory.Text.Trim();
            LoadBooks(title, category);
        }
        private void LoadBooks(string title = null, string category = null)
        {
            var books = ReportService.GetBooks(title, category);
            dataGridView1.DataSource = books;
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text.Trim();
                string category = txtCategory.Text.Trim();

                var books = ReportService.GetBooks(title, category);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "BooksReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = new DataTable();
                        using (var reader = ObjectReader.Create(books.Select(b => new
                        {
                            b.BookId,
                            b.Title,
                            b.Author,
                            b.ISBN,
                            b.PublishedYear,
                            b.Quantity,
                            b.CreatedAt,
                            b.Category,
                            b.CategoryId
                        })))
                        {
                            dt.Load(reader);
                        }

                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Books");
                            worksheet.Cell(1, 1).InsertTable(dt);

                            worksheet.Columns().AdjustToContents();
                            worksheet.Row(1).Height = 20;

                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Data successfully exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportAvaliableBookss_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageReportsForm frm = new ManageReportsForm();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageLoginForm manageLoginForm = new ManageLoginForm();
            manageLoginForm.Show();
            this.Hide();
        }
    }
}
