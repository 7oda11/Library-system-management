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

namespace libraryManagementSystem.Forms.Member
{
    public partial class ViewBooksForm : Form
    {
        public ViewBooksForm()
        {
            InitializeComponent();
        }

        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        public void LoadBooks()
        {
            LoadBooks("");
        }
        public void LoadBooks(string searchQuery = "")
        {

            List<Book> books = BookService.getAllBooks();

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                books = books.Where(b =>
                    b.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    b.Author.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    b.Category.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }


            dgvBooks.DataSource = books;

            if (books.Count == 0)
            {
                MessageBox.Show("Book not found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            LoadBooks(searchText);
            txtSearch.Text = "";

        }

        private void dgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int bookId = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["BookId"].Value);
                Book selectedBook = BookService.GetBook(bookId);

                BookDetailsForm bookDetailsForm = new BookDetailsForm(selectedBook);
                bookDetailsForm.ShowDialog();

                LoadBooks();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

