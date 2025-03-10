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
            var roles = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(0, "Librarian"),
                new KeyValuePair<int, string>(1, "Member")
            };
            cb_role.DataSource = roles;
            cb_role.DisplayMember = "Value";
            cb_role.ValueMember = "Key";
            dgv_users.DataSource = UserService.getAllUsers();
            dgv_users.Columns["confirmPasswordHash"].Visible = false;
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
                    PasswordHash = HashPassword(password),
                    ConfirmPasswordHash = HashPassword(confirmPassword),
                    Role = (UserRole)role,
                    CreatedAt = DateTime.Now
                };
                if (UserService.addUser(user))
                {
                    MessageBox.Show("User added successfully!");
                    ClearInputs();
                    loadData();
                }
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
            if (HashPassword(password) != HashPassword(confirmPassword))
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string userName = txt_userName.Text.Trim();
                string phone = txt_phone.Text.Trim();
                string email = txt_email.Text.Trim();
                string password = txt_password.Text.Trim();
                string confirmPassword = txt_confirmPassword.Text.Trim();
                int role = Convert.ToInt32(cb_role.SelectedValue);
                User user = UserService.getUserById(userId);

                user.Username = userName;
                user.PhoneNumber = phone;
                user.Email = email;
                user.PasswordHash = HashPassword(password);
                user.ConfirmPasswordHash = HashPassword(confirmPassword);
                user.Role = (UserRole)role;
                user.CreatedAt = DateTime.Now;
                if (UserService.updateUser(user))
                {
                    MessageBox.Show("User updated successfully!");
                    ClearInputs();
                    loadData();
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
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    ClearInputs();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashBoardForm dashboardForm = new AdminDashBoardForm();
            dashboardForm.Show();
            this.Hide();
        }
    }
}



