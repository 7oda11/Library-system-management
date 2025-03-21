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
    public partial class AdminDashBoardForm : Form
    {
        public AdminDashBoardForm()
        {
            InitializeComponent();
        }

        private void btn_manageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm frm = new ManageUsersForm();
            frm.Show();
            this.Hide();
        }

        private void btn_manageBooks_Click(object sender, EventArgs e)
        {
            ManageBooksForm frm = new ManageBooksForm();
            frm.Show();
            this.Hide();
        }

        private void AdminDashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_manageProfile_Click(object sender, EventArgs e)
        {
            ManageLibrarianProfile frm = new ManageLibrarianProfile();
            frm.Show();
            this.Hide();
        }

        private void btn_viewLogs_Click(object sender, EventArgs e)
        {
            ManageLogs manageLogs = new ManageLogs();
            manageLogs.Show();
            this.Hide();
        }
        private void btn_generateReports_Click(object sender, EventArgs e)
        {
            ManageReportsForm manageReportsForm = new ManageReportsForm();
            manageReportsForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageLoginForm frm = new ManageLoginForm();
            frm.Show();
            this.Hide();
        }
        private void btn_returnedBooks_Click(object sender, EventArgs e)
        {
            ManageReturnedUserBooksForm man = new ManageReturnedUserBooksForm();
            man.Show();
            this.Hide();
        }

        private void btn_returnedBooks_Click_1(object sender, EventArgs e)
        {
            ManageReturnedUserBooksForm frm = new ManageReturnedUserBooksForm();
            frm.Show();
            this.Hide();
        }
    }
}
