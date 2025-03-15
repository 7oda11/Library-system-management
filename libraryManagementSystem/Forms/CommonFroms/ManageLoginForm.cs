using libraryManagementSystem.Forms.Librarian;
using libraryManagementSystem.Forms.Member;
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

namespace libraryManagementSystem.Forms.CommonFroms
{
    public partial class ManageLoginForm : Form
    {
        private readonly UserService _userService;

        public ManageLoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CommonFroms_Load(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            var user = _userService.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Username}, login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (user.Role == UserRole.Librarian || user.Role==UserRole.Admin)
                {
                    AdminDashBoardForm adminDashBoardForm = new AdminDashBoardForm();
                    adminDashBoardForm.Show();
                    this.Hide();


                }
                else if (user.Role == UserRole.Member)
                {

                    Member.Member member = new Member.Member(user.UserId);
                    this.Hide();
                    HomePageForm homePageForm = new HomePageForm();
                    homePageForm.Show();
                }
            }

            else
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ManageRegisterForm manageRegisterForm = new ManageRegisterForm();
            manageRegisterForm.Show();
            this.Hide();
        }
    }
}
