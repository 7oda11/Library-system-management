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

        private void LoadBooks()
        {
            using (var dbContext = new LibraryDbContext())
            {
                var books = dbContext.Books.ToList();
                dgvBooks.DataSource = books;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();

        }
    }
}
