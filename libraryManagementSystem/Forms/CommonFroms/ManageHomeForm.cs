using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void ManageHomeForm_Paint(object sender, PaintEventArgs e)
        {

            //LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
            //    Color.FromArgb(85, 26, 139), // بنفسجي غامق
            //    Color.FromArgb(170, 85, 255), // بنفسجي فاتح
            //    LinearGradientMode.Vertical);
            //e.Graphics.FillRectangle(brush, this.ClientRectangle);


        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            ManageLoginForm LoginForm = new ManageLoginForm();
            this.Hide();
            LoginForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ManageHomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
