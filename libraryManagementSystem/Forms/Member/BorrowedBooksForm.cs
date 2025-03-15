using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryManagementSystem.Models;
using libraryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;

namespace libraryManagementSystem.Forms.Member
{

    public partial class BorrowedBooksForm : Form
    {
        private BorrowingRecord? selectedRecord = null!;
        private Label lblBookDetails;
        private Button btnReturn, btnCancel;

        public BorrowedBooksForm()
        {
            InitializeComponent();
            InitializeHiddenControls();
        }

        private void BorrowedBooksForm_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        public void LoadBorrowedBooks()
        {
            var borrowedBooks = BorrowService.onBorrowRecord();
            dgvBorrowedBooks.DataSource = null;
            dgvBorrowedBooks.DataSource = borrowedBooks;

            foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
            {
                if (row.Cells["DueDate"].Value is DateTime dueDate)
                {
                    if (dueDate < DateTime.Now && row.Cells["Status"].Value.ToString() == "Borrowed")
                    {

                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }


        private void btnReturn_Click(object? sender, EventArgs e)
        {
            if (selectedRecord == null || selectedRecord.Status != BorrowStatus.Borrowed)
                return;

            BorrowService.ReturnBook(selectedRecord.BorrowingId);

            MessageBox.Show("Book Returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //BookDetailsForm.UpdateAllForms();
            HideReturnSection();
            //LoadBorrowedBooks();
            //BookService.getAllBooks();

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideReturnSection();
        }
        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void InitializeHiddenControls()
        {
            lblBookDetails = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                Visible = false
            };

            btnReturn = new Button
            {
                Text = "Return Book",
                Size = new Size(120, 35),
                BackColor = Color.Green,
                ForeColor = Color.White,
                Visible = false
            };
            btnReturn.Click += btnReturn_Click;

            btnCancel = new Button
            {
                Text = "Cancel",
                Size = new Size(120, 35),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                Visible = false
            };
            btnCancel.Click += btnCancel_Click;

            Controls.Add(lblBookDetails);
            Controls.Add(btnReturn);
            Controls.Add(btnCancel);
        }

        private void ShowReturnSection()
        {
            lblBookDetails.Text = $"Book: {selectedRecord.BookId}\n Borrowed Date: {selectedRecord.BorrowDate}\n Due Date: {selectedRecord.DueDate}";
            lblBookDetails.Visible = true;
            lblBookDetails.Location = new Point(20, dgvBorrowedBooks.Bottom + 20);

            btnReturn.Visible = true;
            btnReturn.Location = new Point(20, lblBookDetails.Bottom + 10);

            btnCancel.Visible = true;
            btnCancel.Location = new Point(150, lblBookDetails.Bottom + 10);
        }

        private void HideReturnSection()
        {
            lblBookDetails.Visible = false;
            btnReturn.Visible = false;
            btnCancel.Visible = false;
            selectedRecord = null;
        }

        private void dgvBorrowedBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRecord = dgvBorrowedBooks.Rows[e.RowIndex].DataBoundItem as BorrowingRecord;

                if (selectedRecord != null)
                {
                    ShowReturnSection();
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}