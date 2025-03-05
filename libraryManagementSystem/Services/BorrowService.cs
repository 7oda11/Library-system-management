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

        public static List<BorrowingRecord> onBorrowRecord()
        {
            List<BorrowingRecord> borrowedBooks = dbContext.BorrowingRecords
                .Where(b => b.UserId == UserService.CurrentUser.UserId)
                .ToList();

            return borrowedBooks;
        }
        
    }
   
}
