using libraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Services
{
    public static class BookService
    {
        public static LibraryDbContext LibraryDbContext = new LibraryDbContext();
        static BookService()
        {
            
        }
        public static List<Book> getAllBooks()
        {
            return LibraryDbContext.Books.ToList();
        }
        public static bool addBook(Book book)
        {
            if (checkBookISBN(book))
            {
                LibraryDbContext.Books.Add(book);
                LibraryDbContext.SaveChanges();
                return true;
            }
            else
            {
                MessageBox.Show("Book with this ISBN already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static bool checkBookISBN(Book book)
        {
            if (LibraryDbContext.Books.Where(b => b.ISBN == book.ISBN).Any())
            {
                return false;
            }
            return true;
        }
        public static bool checkBookISBNForUpdate(Book book)
        {
            if (LibraryDbContext.Books.Where(b => b.ISBN == book.ISBN && b.BookId!=book.BookId).Any())
            {
                return false;
            }
            return true;
        }
        public static Book? GetBook(int id)
        {
            return LibraryDbContext.Books.Where(b => b.BookId == id).FirstOrDefault();
        }
        public static bool updateBook(Book book)
        {
            if (checkBookISBNForUpdate(book))
            {
                LibraryDbContext.SaveChanges();
                return true;
            }
            else
            {
                MessageBox.Show("Book with this ISBN already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static bool deleteBook(int id) 
        {
            Book? book=LibraryDbContext.Books.Where(b=>b.BookId==id).FirstOrDefault();
            if (book == null)
            {
                MessageBox.Show("Nook not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            LibraryDbContext.Books.Remove(book);
            LibraryDbContext.SaveChanges();
            return true;
        }
        public static void updateBookQuantity(int bookId, int newQuantity)
        {
            using (var db = new LibraryDbContext())
            {
                var book = db.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    book.Quantity = newQuantity;
                    db.SaveChanges();
                }
            }
        }

        public static void IncreaseStock(int bookId)
        {
            using (var db = new LibraryDbContext())
            {
                var book = db.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    book.Quantity += 1;
                    db.SaveChanges();
                }
            }
        }

    }

}
