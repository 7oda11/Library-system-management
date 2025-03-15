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
    public partial class ManageLibrarianChangePassword : Form
    {
        public ManageLibrarianChangePassword()
        {
            InitializeComponent();
        }

        private void cb_showOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_oldPassword.UseSystemPasswordChar = !cb_showOldPassword.Checked;

        }

        private void ck_showNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_newPassword.UseSystemPasswordChar = !ck_showNewPassword.Checked;

        }

        private void ck_showConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_confirmPassword.UseSystemPasswordChar = !ck_showConfirmPassword.Checked;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManageLibrarianProfile manageLibrarianProfile = new ManageLibrarianProfile();
            manageLibrarianProfile.Show();
            this.Hide();
        }
        private static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
        private void btn_updatePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_oldPassword.Text) ||
              string.IsNullOrWhiteSpace(txt_newPassword.Text) ||
              string.IsNullOrWhiteSpace(txt_confirmPassword.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_newPassword.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!UserService.checkPassword(txt_oldPassword.Text))
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = UserService.getUserById(UserService.CurrentUser.UserId);
            if (user == null)
            {
                MessageBox.Show("User not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                user.PasswordHash = HashPassword(txt_newPassword.Text);
                if (UserService.updateUser(user))
                {
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInputes();
                }
            }

        }
        private void clearInputes()
        {
            txt_confirmPassword.Text = txt_newPassword.Text = txt_oldPassword.Text = "";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ManageLoginForm manageLoginForm = new ManageLoginForm();
            manageLoginForm.Show();
            this.Close();
        }
    }
}
