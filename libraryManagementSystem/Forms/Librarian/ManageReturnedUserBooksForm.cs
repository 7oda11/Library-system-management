using libraryManagementSystem.Forms.CommonFroms;
using libraryManagementSystem.Models;
using libraryManagementSystem.Services;
using libraryManagementSystem.GmailServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace libraryManagementSystem.Forms.Librarian
{
    public partial class ManageReturnedUserBooksForm : Form
    {
        private BorrowingRecord? selectedRecord = null!;
        private System.Windows.Forms.Timer overdueTimer;

        public ManageReturnedUserBooksForm()
        {
            InitializeComponent();
        }
        private void ManageReturnedUserBooksForm_Load(object sender, EventArgs e)
        {
            //overdueTimer = new System.Windows.Forms.Timer();
            //overdueTimer.Interval = 86400000; // 24 hours (in milliseconds)
            //overdueTimer.Tick += OverdueTimer_Tick;
            //overdueTimer.Start();
            NotificationService notificationService = new NotificationService(new LibraryDbContext(), new GmailService());
            notificationService.SendOverdueNotifications();
            Console.WriteLine("📢 Overdue notification timer started.");
            loadData();

        }
        private void OverdueTimer_Tick(object sender, EventArgs e)
        {
            
                NotificationService notificationService = new NotificationService(new LibraryDbContext(), new GmailService());
                notificationService.SendOverdueNotifications();
            
        }

        private void loadData()
        {
            lbl_message.Visible = false;
            btn_return.Hide();

            var borrowRecords = BorrowService.onBorrowRecord();
            dgv_books.DataSource = borrowRecords;

            // Apply conditional formatting
            foreach (DataGridViewRow row in dgv_books.Rows)
            {
                if (row.Cells["DueDate"].Value != null && DateTime.TryParse(row.Cells["DueDate"].Value.ToString(), out DateTime dueDate))
                {
                    if (dueDate < DateTime.Now) // Check if overdue
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;    // Change row color
                        row.DefaultCellStyle.ForeColor = Color.White;  // Change text color
                    }
                }
            }
        }
        private void dgv_books_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRecord = dgv_books.Rows[e.RowIndex].DataBoundItem as BorrowingRecord;

                if (selectedRecord != null)
                {
                    ShowReturnSection();
                }
            }
        }
        private void ShowReturnSection()
        {
            lbl_message.Text = $"Book: {selectedRecord.BookId}\n Borrowed Date: {selectedRecord.BorrowDate}\n Due Date: {selectedRecord.DueDate}";
            lbl_message.Visible = true;
            btn_return.Show();

        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                var result = BorrowService.searchBorrowingRecord(txt_userName.Text);
                if (result == null || result.Count == 0)
                {
                    var emptyData = new DataTable();
                    emptyData.Columns.Add("Message", typeof(string));
                    emptyData.Rows.Add("No Data Found");

                    dgv_books.DataSource = emptyData;
                }
                else
                {
                    dgv_books.DataSource = result;
                }
            }
            else
            {
                MessageBox.Show("User Name Is Empty");
                loadData();
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (selectedRecord == null || selectedRecord.Status != BorrowStatus.Borrowed)
                return;
            BorrowService.ReturnBook(selectedRecord.BorrowingId);
            MessageBox.Show("Book Returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
            Log log = new Log()
            {
                UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                Action = "Book Returned: Book Name " + selectedRecord.Book.Title
            };
            logService.AddLog(log);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ManageLoginForm form = new ManageLoginForm();
            form.Show();
            this.Hide();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm adminDashBoardForm = new AdminDashBoardForm();
            adminDashBoardForm.Show();
            this.Hide();
        }
    }
}
