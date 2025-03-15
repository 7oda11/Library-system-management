using ClosedXML.Excel;
using FastMember;
using libraryManagementSystem.Forms.CommonFroms;
using libraryManagementSystem.Models;
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
    public partial class ReportBorrowedBooks : Form
    {
        // public static List<BorrowingRecord> booksList;
        public ReportBorrowedBooks()
        {
            InitializeComponent();

        }

        private void btnborrowedbooks_Click(object sender, EventArgs e)
        {
            try
            {
                var booksList = ReportService.GetBorrowedBooks().Select(b => new
                {
                    b.BorrowingId,
                    b.UserId,
                    Username = b.User.Username,
                    b.BookId,
                    b.BorrowDate,
                    b.DueDate,
                    b.Status
                }).ToList();
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "BorrowedBooksReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = new DataTable();
                        using (var reader = ObjectReader.Create(booksList))
                        {
                            dt.Load(reader);
                        }

                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Borrowed Books");
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

        private void ManageBorrowedBooks_Load(object sender, EventArgs e)
        {
            var booksList = ReportService.GetBorrowedBooks().Select(b => new
            {
                b.BorrowingId,
                b.UserId,
                Username = b.User.Username,
                b.BookId,
                b.BorrowDate,
                b.DueDate,
                b.Status
            }).ToList();
            dataGridView1.DataSource = booksList;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageLoginForm manageLoginForm = new ManageLoginForm();
            manageLoginForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageReportsForm form = new ManageReportsForm();   
            form.Show();
            this.Hide();
        }
    }
}
