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
    public partial class ManageReturnedBooks : Form
    {
        public ManageReturnedBooks()
        {
            InitializeComponent();
        }

        //private void btn_logout_Click(object sender, EventArgs e)
        //{
        //    ManageLoginForm loginForm = new ManageLoginForm();
        //    loginForm.Show();
        //    this.Hide();
        //}

        //private void btn_back_Click(object sender, EventArgs e)
        //{
        //    ManageLogs manageLogs = new ManageLogs();
        //    manageLogs.Show();
        //    this.Hide();
        //}

        private void ManageReturnedBooks_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            dgv_logs.DataSource = logService.getAllReturnedBooks();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Step 1: Validate input
            string bookName = txt_bookName.Text.Trim();
            string userName = txt_userName.Text.Trim();

            if (string.IsNullOrWhiteSpace(bookName) && string.IsNullOrWhiteSpace(userName))
            {
                loadData();
                return;
            }

            List<Log> searchResults = logService.SearchReturnedLogs(bookName, userName);

            if (searchResults.Count == 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Message", typeof(string));
                dt.Rows.Add("No data available");
                dgv_logs.DataSource = dt;
                MessageBox.Show("No books found .", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_logs.DataSource = searchResults;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_bookName.Text = txt_userName.Text = "";
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageLoginForm loginForm = new ManageLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageLogs manageLogs = new ManageLogs();
            manageLogs.Show();
            this.Hide();
        }
    }
}
