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
    public partial class ManageHomeForm : Form
    {
        public ManageHomeForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ManageLoginForm LoginForm = new ManageLoginForm();
            this.Hide();
            LoginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ManageRegisterForm RegisterForm = new ManageRegisterForm();  
            this.Hide();    
            RegisterForm.Show();

        }
    }
}
