using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.InkML;
using libraryManagementSystem.Forms.Member;
using libraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
//using Microsoft.VisualBasic.ApplicationServices;

namespace libraryManagementSystem.Services
{
    public static class BorrowService
    {
        public static LibraryDbContext dbContext = new LibraryDbContext();

        public static List<BorrowingRecord> onBorrowRecord()
        {
            List<BorrowingRecord> borrowedBooks = dbContext.BorrowingRecords
                .Where(b => b.Status == 0 && b.UserId==UserService.CurrentUser.UserId)
                .ToList();

            return borrowedBooks;
        }
        public static List<BorrowingRecord> onBorrowRecordDataForReturn()
        {
            List<BorrowingRecord> borrowedBooks = dbContext.BorrowingRecords
                .Where(b => b.Status !=BorrowStatus.Returned  )
                .ToList();

            return borrowedBooks;
        }
        public static List<BorrowingRecord> BorrowedHistory()
        {
            return dbContext.BorrowingRecords.ToList();
        }

        public static List<BorrowingRecord> searchBorrowingRecord(string userName)
        {
            return dbContext.BorrowingRecords.Where(b=>b.User.Username.Contains(userName) &&b.Status==0).ToList();
        }
        public static void addBorrowRecord(int bookId, int userId, DateTime borrowDate)
        {
            using (var db = new LibraryDbContext())
            {
                
                bool alreadyBorrowed = db.BorrowingRecords.Any(r => r.BookId == bookId && r.UserId == userId && r.Status == BorrowStatus.Borrowed);
                if (alreadyBorrowed)
                {
                    MessageBox.Show("You have already borrowed this book! Please return it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                BorrowingRecord record = new BorrowingRecord
                {
                    BookId = bookId,
                    UserId = userId,
                    BorrowDate = borrowDate,
                    DueDate = borrowDate.AddDays(14),
                    //DueDate = borrowDate.AddSeconds(5),
                    Status = BorrowStatus.Borrowed
                };
                User user = db.Users.Find(userId);
                var book = db.Books.Find(bookId);

                if (book == null || user == null)
                {
                    MessageBox.Show("Invalid user or book selection.");
                    return;
                }

                db.BorrowingRecords.Add(record);
                db.SaveChanges();
                MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                QRcodeDisplay(user, book,record);

            }


        }
        private static void QRcodeDisplay(User user,Book book, BorrowingRecord record)
        {
            string qrData = $"User: {user.Username}\n" +
                   $"Email: {user.Email}\n" +
                   $"Book: {book.Title}\n" +
                   $"Borrow Date: {record.BorrowDate:yyyy-MM-dd}\n" +
                   $"Due Date: {record.DueDate:yyyy-MM-dd}";

            Bitmap qrCodeImage = QRCodeService.GenerateQRCode(qrData);

            // Save QR Code as Image
            string qrPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"QR_{user.Username}_{book.Title}.png");
            QRCodeService.SaveQRCode(qrCodeImage, qrPath);

            // Show success message
            MessageBox.Show($"Book borrowed successfully!\nQR Code saved at: {qrPath}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void ReturnBook(int borrowId)
        {
            using (var db = new LibraryDbContext())
            {
                var record = db.BorrowingRecords.FirstOrDefault(b => b.BorrowingId == borrowId);

                if (record != null && record.Status == BorrowStatus.Borrowed)
                {
                    record.Status = BorrowStatus.Returned;
                    record.ReturnDate = DateTime.Now;

                    if (record != null)
                    {
                        record.Book.Quantity += 1;
                    }

                    db.SaveChanges();

                    RefreshDataGrids();
                    //var borrowedBooksForm = Application.OpenForms.OfType<BorrowedBooksForm>().FirstOrDefault();
                    //var booksForm = Application.OpenForms.OfType<ViewBooksForm>().FirstOrDefault();

                    //borrowedBooksForm?.LoadBorrowedBooks();
                    //booksForm?.LoadBooks();

                }
            }
        }
        private static void RefreshDataGrids()
        {
            var borrowedBooksForm = Application.OpenForms.OfType<BorrowedBooksForm>().FirstOrDefault();
            var booksForm = Application.OpenForms.OfType<ViewBooksForm>().FirstOrDefault();

            borrowedBooksForm?.LoadBorrowedBooks();
            booksForm?.LoadBooks();
        }


        public static bool IsBookAlreadyBorrowed(int bookId, int userId)
        {
            using (var db = new LibraryDbContext())
            {
                return db.BorrowingRecords.Any(r => r.BookId == bookId && r.UserId == userId && r.Status == BorrowStatus.Borrowed);
            }
        }

        public static void AddBorrowRecord(int bookId, int userId, DateTime borrowDate)
        {
            using (var db = new LibraryDbContext())
            {
                
                if (IsBookAlreadyBorrowed(bookId, userId))
                {
                    MessageBox.Show("You have already borrowed this book! Please return it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                BorrowingRecord record = new BorrowingRecord
                {
                    BookId = bookId,
                    UserId = userId,
                    BorrowDate = borrowDate,
                    DueDate = borrowDate.AddDays(14),
                    Status = BorrowStatus.Borrowed
                };

                db.BorrowingRecords.Add(record);
                db.SaveChanges(); 

                
                BorrowedBooksForm borrowedBooksForm = Application.OpenForms.OfType<BorrowedBooksForm>().FirstOrDefault();
                if (borrowedBooksForm != null)
                {
                    borrowedBooksForm.LoadBorrowedBooks(); 
                }
            }
        }


    }

}
