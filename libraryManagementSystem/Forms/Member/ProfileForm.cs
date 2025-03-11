using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryManagementSystem.Models;
using libraryManagementSystem.Services;
using libraryManagementSystem.Forms.Member;

namespace libraryManagementSystem.Forms.Member
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            using (var dbContext = new LibraryDbContext())
            {
                if (UserService.CurrentUser != null)
                {
                    var user = dbContext.Users.Find(UserService.CurrentUser.UserId);
                    if (user != null)
                    {
                        txtUsername.Text = user.Username;
                        txtEmail.Text = user.Email;
                        txtPhone.Text = user.PhoneNumber;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new LibraryDbContext())
            {
                if (UserService.CurrentUser == null)
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = dbContext.Users.Find(UserService.CurrentUser.UserId);
                if (user == null)
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newEmail = txtEmail.Text.Trim();
                string newUsername = txtUsername.Text.Trim();
                string newPhone = txtPhone.Text.Trim();

                // Validate email format using Regex
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(newEmail, emailPattern))
                {
                    MessageBox.Show("Please enter a valid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure email is unique (unless it's the same as the current one)
                if (newEmail != user.Email && dbContext.Users.Any(u => u.Email == newEmail))
                {
                    MessageBox.Show("This email is already in use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure username is unique
                if (newUsername != user.Username && dbContext.Users.Any(u => u.Username == newUsername))
                {
                    MessageBox.Show("This username is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure phone number contains only digits
                if (!Regex.IsMatch(newPhone, @"^\+?\d+$"))
                {
                    MessageBox.Show("Phone number should contain only digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update user details
                user.Username = newUsername;
                user.Email = newEmail;
                user.PhoneNumber = newPhone;



                Log log = new Log()
                {
                    UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                    Action = $"User Name {UserService.CurrentUser.Username} Update His Profile "
                };
                logService.AddLog(log);
                dbContext.SaveChanges();
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


