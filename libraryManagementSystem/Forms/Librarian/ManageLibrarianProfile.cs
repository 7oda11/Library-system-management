using libraryManagementSystem.Models;
using libraryManagementSystem.Services;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace libraryManagementSystem.Forms.Librarian
{
    public partial class ManageLibrarianProfile : Form
    {
        public ManageLibrarianProfile()
        {
            InitializeComponent();
        }

        private void ManageLibrarianProfile_Load(object sender, EventArgs e)
        {
            loadData();

        }
        private void loadData()
        {
            txt_userName.Text = UserService.CurrentUser.Username;
            txt_phone.Text = UserService.CurrentUser.PhoneNumber;
            txt_email.Text = UserService.CurrentUser.Email;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(txt_phone.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Invalid phone number! Please enter a 10-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(txt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format! Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {

                var user = UserService.getUserById(UserService.CurrentUser.UserId);

                if (user == null)
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user.Username = txt_userName.Text.Trim();
                user.PhoneNumber = txt_phone.Text.Trim();
                user.Email = txt_email.Text.Trim();

                if (UserService.updateUser(user))
                {
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log log = new Log()
                    {
                        UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                        Action = $"Admin Name {UserService.CurrentUser.Username} Update His Profile "
                    };
                    logService.AddLog(log);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            ManageLibrarianChangePassword manageLibrarianChangePassword = new ManageLibrarianChangePassword();
            manageLibrarianChangePassword.Show();
            this.Hide();
        }
    }
}
