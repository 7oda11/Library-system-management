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


            var user = _userService.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Username}, login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (user.Role == UserRole.Librarian)
                {
                    AdminDashBoardForm adminDashBoardForm = new AdminDashBoardForm();
                    adminDashBoardForm.Show();
                    this.Hide();
                    //Librarian.Librarian adminForm = new Librarian.Librarian(user.UserId);
                    //this.Hide();
                    //adminForm.Show();
                    
                }
                else if (user.Role == UserRole.Member)
                {
                    UserService.assignUserData(user);
                    Member.Member member = new Member.Member(user.UserId);
                    this.Hide();
                    //member.Show();
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
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}
