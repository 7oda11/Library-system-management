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
    public partial class ManageRegisterForm : Form
    {
        public ManageRegisterForm()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
            txtConfirmPassword.UseSystemPasswordChar = !checkBox2.Checked;

        }

        private void ManageRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhone.Text.Trim();


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Username, password, and email are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserService userService = new UserService();

            if (userService.IsUsernameTaken(username))
            {
                MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userService.IsEmailTaken(email))
            {
                MessageBox.Show("Email is already in use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            string result = userService.Register(username, password, confirmPassword, email, phoneNumber, UserRole.Member);

            if (result == "User registered successfully!")
            {
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ManageLoginForm manageLoginForm = new ManageLoginForm();
                this.Hide();
                manageLoginForm.Show();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ManageLoginForm manageLoginForm = new ManageLoginForm();
            this.Hide();
            manageLoginForm.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
