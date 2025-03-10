﻿using ClosedXML.Excel;
using FastMember;
using libraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem.Forms.Librarian
{
    public partial class ManageReportsForm : Form
    {
        public ManageReportsForm()
        {
            InitializeComponent();
        }

        private void ManageReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            ManageAvaliableBooks frm = new ManageAvaliableBooks();  
            frm.ShowDialog();
           
        }




        private void btnborrowedbooks_Click(object sender, EventArgs e)
        {

            ManageBorrowedBooks frm = new ManageBorrowedBooks();
            frm.ShowDialog();
        }





        private void btnoverduebooks_Click(object sender, EventArgs e)
        {
            ManageOverdueBooks frm = new ManageOverdueBooks();
            frm.ShowDialog();

           
        }
    }
}








