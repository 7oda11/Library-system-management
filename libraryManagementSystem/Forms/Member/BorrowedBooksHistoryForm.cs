using libraryManagementSystem.Forms.CommonFroms;
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

namespace libraryManagementSystem.Forms.Member
{
    public partial class BorrowedBooksHistoryForm : Form
    {
        public BorrowedBooksHistoryForm()
        {
            InitializeComponent();
        }

        private void BorrowedBooksHistoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgv_history.DataSource = BorrowService.BorrowedHistory();
            foreach (DataGridViewRow row in dgv_history.Rows)
            {
                if (row.Cells["DueDate"].Value != null && row.Cells["ReturnDate"].Value == null)
                {
                    DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
                    if (dueDate < DateTime.Now) 
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ManageLoginForm manageLoginForm = new ManageLoginForm();
            manageLoginForm.Show();
            this.Hide();
        }
    }
}
