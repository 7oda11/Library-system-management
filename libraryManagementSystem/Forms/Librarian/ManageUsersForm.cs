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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace libraryManagementSystem.Forms.Librarian
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            var roles = new List<KeyValuePair<int, string>>();

            if (UserService.CurrentUser.Role == UserRole.Admin)
            {
                roles = new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(0, "Librarian"),
            new KeyValuePair<int, string>(1, "Member"),
            new KeyValuePair<int, string>(2, "Admin")
        };
            }
            else if (UserService.CurrentUser.Role == UserRole.Librarian)
            {
                roles = new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(0, "Librarian"),
            new KeyValuePair<int, string>(1, "Member")
        };
            }

            cb_role.DataSource = roles;
            cb_role.DisplayMember = "Value";
            cb_role.ValueMember = "Key";

            dgv_users.DataSource = null; // Reset DataSource**
            dgv_users.DataSource = UserService.getAllUsers(); // Reload users
            dgv_users.Columns["confirmPasswordHash"].Visible = false;
            dgv_users.Refresh(); // Ensure UI refresh

            btn_add.Show();
            btn_delete.Hide();
            btn_update.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string userName = txt_userName.Text.Trim();
                string phone = txt_phone.Text.Trim();
                string email = txt_email.Text.Trim();
                string password = txt_password.Text.Trim();
                string confirmPassword = txt_confirmPassword.Text.Trim();
                int role = Convert.ToInt32(cb_role.SelectedValue);
                User user = new User()
                {
                    Username = userName,
                    PhoneNumber = phone,
                    Email = email,
                    PasswordHash = HashService.HashPassword(password),
                    ConfirmPasswordHash = HashService.HashPassword(confirmPassword),
                    Role = (UserRole)role,
                    CreatedAt = DateTime.Now
                };
                if (UserService.addUser(user))
                {
                    Log log = new Log()
                    {
                        UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                        Action = $"Admin Name {UserService.CurrentUser.Username} Add {(UserRole)role} {userName}"
                    };
                    logService.AddLog(log);
                    MessageBox.Show("User added successfully!");
                    ClearInputs();
                    loadData();
                }
            }

        }

        private bool ValidateInputs()
        {
            string userName = txt_userName.Text.Trim();
            string phone = txt_phone.Text.Trim();
            string email = txt_email.Text.Trim();
            string password = txt_password.Text.Trim();
            string confirmPassword = txt_confirmPassword.Text.Trim();
            int selectedRole = cb_role.SelectedIndex;
            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                selectedRole == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (HashService.HashPassword(password) != HashService.HashPassword(confirmPassword))
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void ClearInputs()
        {
            txt_userName.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_password.Clear();
            txt_confirmPassword.Clear();
            cb_role.SelectedIndex = -1;
            ck_showPassword.Checked = false;
            ck_showConfirmPassword.Checked = false;
        }
        private void ck_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !ck_showPassword.Checked;

        }

        private void ck_showConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_confirmPassword.UseSystemPasswordChar = !ck_showConfirmPassword.Checked;
        }
        int userId;
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_users.Rows[e.RowIndex];
                userId = Convert.ToInt32(row.Cells[0].Value);
                txt_userName.Text = row.Cells["Username"].Value.ToString();
                txt_phone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                cb_role.SelectedValue = Convert.ToInt32(row.Cells["Role"].Value);
                //MessageBox.Show($"Assigned Role: {userId}");
                btn_add.Hide();
                btn_update.Show();
                btn_delete.Show();
            }
        }
        int role;
        string userName;
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                userName = txt_userName.Text.Trim();
                string phone = txt_phone.Text.Trim();
                string email = txt_email.Text.Trim();
                string password = txt_password.Text.Trim();
                string confirmPassword = txt_confirmPassword.Text.Trim();
                role = Convert.ToInt32(cb_role.SelectedValue);

                User user = UserService.getUserById(userId);

                // Prevent logged-in admin from changing their own role
                if (user.UserId == UserService.CurrentUser.UserId && UserService.CurrentUser.Role == UserRole.Admin)
                {
                    role = (int)UserRole.Admin;  // Ensure role stays Admin
                }

                user.Username = userName;
                user.PhoneNumber = phone;
                user.Email = email;
                user.PasswordHash = HashService.HashPassword(password);
                user.ConfirmPasswordHash = HashService.HashPassword(confirmPassword);
                user.Role = (UserRole)role;  // Assign the validated role
                user.CreatedAt = DateTime.Now;

                if (UserService.updateUser(user))
                {
                    //Log log = new Log()
                    //{
                    //    UserId = UserService.CurrentUser.UserId,
                    //    Action = $"Admin Name {UserService.CurrentUser.Username} Updated {(UserRole)role} {userName}"
                    //};
                    MessageBox.Show(UserService. CurrentUser.Role.ToString());

                    //logService.AddLog(log);

                    MessageBox.Show("User updated successfully!");

                    dgv_users.DataSource = null;  // Clear the current data source
                    loadData(); // Reload updated data
                    dgv_users.Refresh(); // Refresh the UI
                    ClearInputs();
                }
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (userId <= 0)
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (UserService.deleteUser(userId))
                {
                    Log log = new Log()
                    {
                        UserId = UserService.CurrentUser.UserId,  // Ensure CurrentUser is properly set
                        Action = $"Admin Name {UserService.CurrentUser.Username} Delete {(UserRole)role} {userName}"
                    };
                    logService.AddLog(log);
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    ClearInputs();
                }
            }
        }

        //private void btn_back_Click(object sender, EventArgs e)
        //{
        //    AdminDashBoardForm dashboardForm = new AdminDashBoardForm();
        //    dashboardForm.Show();
        //    this.Hide();
        //}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm dashboardForm = new AdminDashBoardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



