using libraryManagementSystem.Forms.CommonFroms;
using libraryManagementSystem.Models;
using libraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem.Forms.Librarian
{
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            loadData();

        }
        private void loadData()
        {
            dvg_books.DataSource = BookService.getAllBooks();
            dvg_books.Columns["CategoryId"].Visible = false;
            cb_category.DataSource = CategoryService.GetCategories();
            cb_category.DisplayMember = "Name";
            cb_category.ValueMember = "CategoryId";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Book newBook = new Book()
                {
                    Title = txt_title.Text.Trim(),
                    Author = txt_auther.Text.Trim(),
                    ISBN = txt_isbn.Text.Trim(),
                    PublishedYear = dt_publishedYear.Value.Year,
                    Quantity = (int)nud_quantity.Value,
                    CategoryId = Convert.ToInt32(cb_category.SelectedValue),
                    CreatedAt = DateTime.Now
                };
                if (BookService.addBook(newBook))
                {
                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log log = new Log()
                    {
                        UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                        Action = $"Admin Name {UserService.CurrentUser.Username} Add Book {txt_title.Text}"
                    };
                    logService.AddLog(log);
                    ClearInputs();
                    loadData();
                }

            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_title.Text))
            {
                MessageBox.Show("Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_auther.Text))
            {
                MessageBox.Show("Author is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_isbn.Text))
            {
                MessageBox.Show("ISBN is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dt_publishedYear.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Published year cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nud_quantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_category.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
        private void ClearInputs()
        {
            txt_title.Clear();
            txt_auther.Clear();
            txt_isbn.Clear();
            dt_publishedYear.Value = DateTime.Now;
            nud_quantity.Value = 1;
            cb_category.SelectedIndex = -1;
        }
        int selectedBookId;
        private void dvg_books_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvg_books.Rows[e.RowIndex];
                txt_title.Text = row.Cells["Title"].Value.ToString();
                txt_auther.Text = row.Cells["Author"].Value.ToString();
                txt_isbn.Text = row.Cells["ISBN"].Value.ToString();
                dt_publishedYear.Value = new DateTime(Convert.ToInt32(row.Cells["PublishedYear"].Value), 1, 1);
                nud_quantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
                cb_category.SelectedValue = row.Cells["CategoryId"].Value;
                selectedBookId = Convert.ToInt32(row.Cells["BookId"].Value);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedBookId <= 0)
            {
                MessageBox.Show("Please select a book to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ValidateInputs())
            {
                Book bookToUpdate = BookService.GetBook(selectedBookId);
                if (bookToUpdate != null)
                {

                    bookToUpdate.Title = txt_title.Text.Trim();
                    bookToUpdate.Author = txt_auther.Text.Trim();
                    bookToUpdate.ISBN = txt_isbn.Text.Trim();
                    bookToUpdate.PublishedYear = dt_publishedYear.Value.Year; // Only store year
                    bookToUpdate.Quantity = (int)nud_quantity.Value;
                    bookToUpdate.CategoryId = Convert.ToInt32(cb_category.SelectedValue);
                    if (BookService.updateBook(bookToUpdate))
                    {
                        MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Log log = new Log()
                        {
                            UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                            Action = $"Admin Name {UserService.CurrentUser.Username}   update Book {txt_title.Text}"
                        };
                        logService.AddLog(log);
                        ClearInputs();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedBookId <= 0)
            {
                MessageBox.Show("Please select a book to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                var bookToDelete = BookService.GetBook(selectedBookId);

                if (bookToDelete != null)
                {
                    if (BookService.deleteBook(selectedBookId))
                    {
                        if (BookService.deleteBook(selectedBookId))
                        {
                            MessageBox.Show("Book deleted successfully!",               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Log log = new Log()
                        {
                            UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                            Action = $"Admin Name {UserService.CurrentUser.Username} Delete Book {txt_title.Text}"
                        };
                        logService.AddLog(log);
                        ClearInputs();
                            loadData();


                        }


                    
                    }



                }
                else
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dvg_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm frm = new AdminDashBoardForm();
            frm.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageLoginForm frm = new ManageLoginForm();
            frm.Show();
            this.Hide();
        }
    }
}
