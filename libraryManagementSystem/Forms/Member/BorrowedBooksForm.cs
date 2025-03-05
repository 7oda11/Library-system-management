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

namespace libraryManagementSystem.Forms.Member
{
    public partial class BorrowedBooksForm : Form
    {
        public BorrowedBooksForm()
        {
            InitializeComponent();
        }

        private void BorrowedBooksForm_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            //using (var dbContext = new LibraryDbContext())
            //{
            //    var borrowedBooks = dbContext.BorrowingRecords
            //        .Where(b => b.UserId == userId)
            //        .Select(b => new { b.Book.Title, b.BorrowDate, b.DueDate })
            //        .ToList();

            //    dgvBorrowedBooks.DataSource = borrowedBooks;
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }
    }
}
