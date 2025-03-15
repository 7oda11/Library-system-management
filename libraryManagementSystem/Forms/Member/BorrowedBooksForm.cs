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
using Microsoft.EntityFrameworkCore;
using QRCoder;

namespace libraryManagementSystem.Forms.Member
{

    public partial class BorrowedBooksForm : Form
    {
        private BorrowingRecord? selectedRecord = null!;
        private Label lblBookDetails;
        private Button btnReturn, btnCancel;

        public BorrowedBooksForm()
        {
            InitializeComponent();
            //InitializeHiddenControls();
        }

        private void BorrowedBooksForm_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        public void LoadBorrowedBooks()
        {
            var borrowedBooks = BorrowService.onBorrowRecord();
            dgvBorrowedBooks.DataSource = null;
            dgvBorrowedBooks.DataSource = borrowedBooks;

            foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
            {
                if (row.Cells["DueDate"].Value is DateTime dueDate)
                {
                    if (dueDate < DateTime.Now && row.Cells["Status"].Value.ToString() == "Borrowed")
                    {

                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        //if we mant to give option to the user to retrurn book by him self

        //private void btnReturn_Click(object? sender, EventArgs e)
        //{
        //    if (selectedRecord == null || selectedRecord.Status != BorrowStatus.Borrowed)
        //        return;

        //    BorrowService.ReturnBook(selectedRecord.BorrowingId);

        //    MessageBox.Show("Book Returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    HideReturnSection();
            
        //}



        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    HideReturnSection();
        //}
        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        //private void InitializeHiddenControls()
        //{
        //    lblBookDetails = new Label
        //    {
        //        AutoSize = true,
        //        Font = new Font("Arial", 10, FontStyle.Bold),
        //        ForeColor = Color.White,
        //        Visible = false
        //    };

        //    btnReturn = new Button
        //    {
        //        Text = "Return Book",
        //        Size = new Size(120, 35),
        //        BackColor = Color.Purple,
        //        ForeColor = Color.White,
        //        Visible = false
        //    };
        //    btnReturn.Click += btnReturn_Click;

        //    btnCancel = new Button
        //    {
        //        Text = "Cancel",
        //        Size = new Size(120, 35),
        //        BackColor = Color.Gray,
        //        ForeColor = Color.White,
        //        Visible = false
        //    };
        //    btnCancel.Click += btnCancel_Click;

        //    Controls.Add(lblBookDetails);
        //    Controls.Add(btnReturn);
        //    Controls.Add(btnCancel);
        //}

        //private void ShowReturnSection()
        //{
        //    lblBookDetails.Text = $"Book: {selectedRecord.BookId}\n Borrowed Date: {selectedRecord.BorrowDate}\n Due Date: {selectedRecord.DueDate}";
        //    lblBookDetails.Visible = true;
        //    lblBookDetails.Location = new Point(20, dgvBorrowedBooks.Bottom + 40);
        //    lblBookDetails.BackColor = Color.FromArgb(110, 75, 125);
        //    lblBookDetails.BringToFront();

        //    btnReturn.Visible = true;
        //    btnReturn.Location = new Point(20, lblBookDetails.Bottom + 20);
        //    btnReturn.BringToFront();

        //    btnCancel.Visible = true;
        //    btnCancel.Location = new Point(150, lblBookDetails.Bottom + 20);
        //    btnCancel.BringToFront();
        //}

        //private void HideReturnSection()
        //{
        //    lblBookDetails.Visible = false;
        //    btnReturn.Visible = false;
        //    btnCancel.Visible = false;
        //    selectedRecord = null;
        //}

        private void dgvBorrowedBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRecord = dgvBorrowedBooks.Rows[e.RowIndex].DataBoundItem as BorrowingRecord;

                if (selectedRecord != null)
                {
                    //ShowReturnSection();
                    LoadQRCodeFromDirectory(selectedRecord);

                }
            }

        }
        private void LoadQRCodeFromDirectory(BorrowingRecord record)
        {
            if (record != null && record.Book != null && record.User != null)
            {
                string qrFileName = $"QR_{record.User.Username}_{record.Book.Title}.png";
                string qrDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string qrPath = Path.Combine(qrDirectory, qrFileName);
                if (File.Exists(qrPath))
                {
                    pictureBox_QRCode.Size = new Size(150, 150);
                    pictureBox_QRCode.SizeMode = PictureBoxSizeMode.StretchImage; 
                    pictureBox_QRCode.Image = Image.FromFile(qrPath);
                }
                else
                {
                    MessageBox.Show("QR Code not found for this book!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox_QRCode.Image = null;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}