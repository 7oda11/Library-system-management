using Dapper;
using libraryManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Services
{
    public static class ReportService
    {

        private static string connectionString = "Data Source=LAPTOP-JMGMI5SB\\DEV;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //public static List<Book> GetBooks()
        //{
        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        string query = @"
        //            SELECT b.BookId,b.Title,b.Author,b.ISBN,b.PublishedYear,b.Quantity,b.CreatedAt,b.CategoryId ,c.Name AS CategoryName 
        //            FROM Books b
        //            JOIN Categories c ON b.CategoryId = c.CategoryId";

        //        var books = connection.Query<Book, string, Book>(
        //            query,
        //            (book, categoryName) =>
        //            {
        //                book.Category = new Category { Name = categoryName };
        //                return book;
        //            },
        //            splitOn: "CategoryName"
        //        ).ToList();

        //        return books;
        //    }
        //}


        public static List<Book> GetBooks(string title = null, string category = null)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT b.BookId, b.Title, b.Author, b.ISBN, b.PublishedYear, 
                       b.Quantity, b.CreatedAt, b.CategoryId, c.Name AS CategoryName 
                FROM Books b
                JOIN Categories c ON b.CategoryId = c.CategoryId
                WHERE (@Title IS NULL OR b.Title LIKE '%' + @Title + '%')
                AND (@Category IS NULL OR c.Name LIKE '%' + @Category + '%')";

                var books = connection.Query<Book, string, Book>(
                    query,
                    (book, categoryName) =>
                    {
                        book.Category = new Category { Name = categoryName };
                        return book;
                    },
                    new { Title = title, Category = category },
                    splitOn: "CategoryName"
                ).ToList();

                return books;
            }
        }





        public static List<BorrowingRecord> GetBorrowedBooks()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = @"
              SELECT 
              b.*,
              u.Username  
                FROM BorrowingRecords b
                JOIN Users u ON b.UserId = u.UserId
                WHERE b.Status = 0";


                var books = connection.Query<BorrowingRecord, User, BorrowingRecord>(
                query,
                (borrowing, user) =>
                {
                     borrowing.User = user;
                     return borrowing;
                },
                   splitOn: "Username"
                 ).ToList();

           
                return books;

            }
        }

        public static List<BorrowingRecord> GetOverdueBooks()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = @"
              SELECT 
              b.*,
              u.Username  
                FROM BorrowingRecords b
                JOIN Users u ON b.UserId = u.UserId
                WHERE b.Status = 2";


                var books = connection.Query<BorrowingRecord, User, BorrowingRecord>(
                query,
                (borrowing, user) =>
                {
                    borrowing.User = user;
                    return borrowing;
                },
                   splitOn: "Username"
                 ).ToList();

                return books;
            }
        }

    }





}
