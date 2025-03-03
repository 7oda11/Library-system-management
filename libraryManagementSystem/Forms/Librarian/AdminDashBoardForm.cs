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
    }
}
