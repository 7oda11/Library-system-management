using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace libraryManagementSystem.Services
{
    public static class BorrowService
    {
        public static LibraryDbContext dbContext = new LibraryDbContext();

        public static List<object> onBorrowRecord()
        {
            var borrowedBooks = dbContext.BorrowingRecords
                .Where(b => b.UserId == UserService.CurrentUser.UserId)
                //.Select(b => new
                //{
                //    Title = b.Book.Title,
                //    BorrowDate = b.BorrowDate,
                //    DueDate = b.DueDate
                //})
                .ToList();

            return borrowedBooks.Cast<object>().ToList();
        }
    }
   
}
