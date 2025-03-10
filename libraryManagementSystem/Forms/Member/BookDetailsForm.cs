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
    public partial class BookDetailsForm : Form
    {
        public BookDetailsForm()
        {
            InitializeComponent();
        }
        private Book book;

        public BookDetailsForm(Book selectedBook)
        {
            InitializeComponent();
            book = selectedBook;
            DisplayBookDetails();
        }

        private void DisplayBookDetails()
        {
            lblTitle.Text = book.Title;
            lblAuthor.Text = book.Author;
            lblCategory.Text = book.Category.Name;
            lblQuantity.Text = book.Quantity.ToString();
        }


        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (book.Quantity > 0)
            {
                bool alreadyBorrowed = BorrowService.IsBookAlreadyBorrowed(book.BookId, UserService.CurrentUser.UserId);
                if (alreadyBorrowed)
                {
                    MessageBox.Show("You have already borrowed this book! Please return it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                book.Quantity -= 1;
                BookService.updateBookQuantity(book.BookId, book.Quantity);

                BorrowService.addBorrowRecord(book.BookId, UserService.CurrentUser.UserId, DateTime.Now);

                MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblQuantity.Text = book.Quantity.ToString();

                //UpdateAllForms();
            }
            else
            {
                MessageBox.Show("Sorry, no copies available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public static void UpdateAllForms()
        {
            var viewBooksForm = Application.OpenForms.OfType<ViewBooksForm>().FirstOrDefault();
            var borrowedBooksForm = Application.OpenForms.OfType<BorrowedBooksForm>().FirstOrDefault();

            viewBooksForm?.LoadBooks();
            borrowedBooksForm?.LoadBorrowedBooks();
        }




        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
