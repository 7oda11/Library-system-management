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
                var user = dbContext.Users.Find(userId);
                if (user != null)
                {
                    txtUsername.Text = user.Username;
                    txtEmail.Text = user.Email;
                    txtPhone.Text = user.PhoneNumber;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var user = dbContext.Users.Find(userId);
                if (user != null)
                {
                    user.Email = txtEmail.Text;
                    user.PhoneNumber = txtPhone.Text;

                    dbContext.SaveChanges();
                    MessageBox.Show("Updated Successfully!");
                }
            }
        }
    }
}
