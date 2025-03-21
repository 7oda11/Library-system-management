﻿using libraryManagementSystem.Forms.CommonFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem.Forms.Member
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            ViewBooksForm booksForm = new ViewBooksForm();
            booksForm.Show();
        }

        private void btnBorrowedBooks_Click(object sender, EventArgs e)
        {
            BorrowedBooksForm borrowedBooksForm = new BorrowedBooksForm();
            borrowedBooksForm.Show();
        }

        private void btnManageProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ManageLoginForm manageLoginForm = new ManageLoginForm();
            manageLoginForm.Show();
            this.Hide();
        }

        private void btn_BorrowedBooksHistory_Click(object sender, EventArgs e)
        {
            BorrowedBooksHistoryForm borrowedBooksHistoryForm = new BorrowedBooksHistoryForm();
            borrowedBooksHistoryForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowedBooksHistoryForm borrowedBooksHistoryForm1 = new BorrowedBooksHistoryForm();
            borrowedBooksHistoryForm1.Show();
            this.Hide();
        }
    }
}
