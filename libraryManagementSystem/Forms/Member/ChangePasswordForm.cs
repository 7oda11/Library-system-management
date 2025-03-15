using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryManagementSystem.Models;
using libraryManagementSystem.Services;

namespace libraryManagementSystem.Forms.Member
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
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

                string oldPassword = txtOldPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                // ✅ التحقق من كلمة المرور القديمة
                if (user.PasswordHash != HashService.HashPassword(oldPassword))
                {
                    MessageBox.Show("Incorrect old password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ التحقق من تطابق كلمة المرور الجديدة والتأكيد
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New password and confirmation do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ تحديث كلمة المرور
                user.PasswordHash = HashService.HashPassword(newPassword);
                dbContext.SaveChanges();

                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = chkShowPassword.Checked;
            txtOldPassword.PasswordChar = showPassword ? '\0' : '●';
            txtNewPassword.PasswordChar = showPassword ? '\0' : '●';
            txtConfirmPassword.PasswordChar = showPassword ? '\0' : '●';
        }

       

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            txtOldPassword.PasswordChar = '●';
            txtNewPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
