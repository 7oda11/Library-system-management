using libraryManagementSystem.Forms.CommonFroms;
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
    public partial class ManageLogs : Form
    {
        public ManageLogs()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm adminDashBoardForm = new AdminDashBoardForm();
            adminDashBoardForm.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ManageLoginForm loginForm = new ManageLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btn_borrowedBook_Click(object sender, EventArgs e)
        {
            ManageBorrowedBooks bookForm = new ManageBorrowedBooks();
            bookForm.Show();
            this.Hide();
        }

        private void btn_returningBooks_Click(object sender, EventArgs e)
        {
            ManageReturnedBooks bookForm = new ManageReturnedBooks();
            bookForm.Show();
            this.Hide();
        }

        private void btn_userAction_Click(object sender, EventArgs e)
        {
            ManageUserAcion manageUserAcion = new ManageUserAcion();
            manageUserAcion.Show();
            this.Hide();
        }
    }
}
