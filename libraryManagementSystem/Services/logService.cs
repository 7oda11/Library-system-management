using libraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Services
{
    public static class logService
    {
        public static LibraryDbContext LibraryDbContext = new LibraryDbContext();
        public static void AddLog(Log log)
        {
            LibraryDbContext.Logs.Add(log);
            LibraryDbContext.SaveChanges();
        }
        public static List<Log> GetLogsByUser(int userId)
        {
          
                return LibraryDbContext.Logs.Where(l => l.UserId == userId).OrderByDescending(l => l.PerformedAt).ToList();
            
        }
        public static List<Log> GetAllLogs()
        {

            return LibraryDbContext.Logs.Include(l => l.User).OrderByDescending(l => l.PerformedAt).ToList();

        }
        public static List<Log> getAllBorrowedBooks()
        {
            return LibraryDbContext.Logs.Where(l => l.Action.Contains("Borrowed")).OrderByDescending(l => l.PerformedAt).ToList();
        }
        public static List<Log> SearchLogs(string bookName,string userName)
        {
            if (!string.IsNullOrWhiteSpace(bookName) && !string.IsNullOrWhiteSpace(userName))
            {

                return LibraryDbContext.Logs
                              .Where(b => b.Action.Contains (bookName) && b.Action.Contains("Borrowed")&& b.User.Username.Contains(userName)).OrderByDescending(l=>l.PerformedAt)
                              .ToList();
            }else if (!string.IsNullOrWhiteSpace(bookName))
            {
                return LibraryDbContext.Logs
                          .Where(b => b.Action.Contains(bookName) && b.Action.Contains("Borrowed") ).OrderByDescending(l => l.PerformedAt)
                          .ToList();
            }
            else
            {
                return LibraryDbContext.Logs
                          .Where(b => b.Action.Contains("Borrowed") && b.User.Username.Contains(userName)).OrderByDescending(l => l.PerformedAt)
                          .ToList();
            }
        }
        public static List<Log> getAllReturnedBooks()
        {
            return LibraryDbContext.Logs.Where(l => l.Action.Contains("Returned")).OrderByDescending(l => l.PerformedAt).ToList();
        }
        public static List<Log> SearchReturnedLogs(string bookName, string userName)
        {
            if (!string.IsNullOrWhiteSpace(bookName) && !string.IsNullOrWhiteSpace(userName))
            {
                return LibraryDbContext.Logs
                              .Where(b => b.Action.Contains(bookName) && b.Action.Contains("Returned") && b.User.Username.Contains(userName)).OrderByDescending(l => l.PerformedAt)
                              .ToList();
            }
            else if (!string.IsNullOrWhiteSpace(bookName))
            {
                return LibraryDbContext.Logs
                          .Where(b => b.Action.Contains(bookName) && b.Action.Contains("Returned")).OrderByDescending(l => l.PerformedAt)
                          .ToList();
            }
            else
            {
                return LibraryDbContext.Logs
                          .Where(b => b.Action.Contains("Returned") && b.User.Username.Contains(userName)).OrderByDescending(l => l.PerformedAt)
                          .ToList();
            }
        }
        public static List<Log> getAllUserActions()
        {
            return LibraryDbContext.Logs.OrderByDescending(l => l.PerformedAt).ToList();
        }
        public static List<Log> SearchUserActionLogs(string bookName, string userName)
        {
            if (!string.IsNullOrWhiteSpace(bookName) && !string.IsNullOrWhiteSpace(userName))
            {
                return LibraryDbContext.Logs
                              .Where(b => b.Action.Contains(bookName) && b.User.Username.Contains(userName)).OrderByDescending(l => l.PerformedAt)
                              .ToList();
            }
            else if (!string.IsNullOrWhiteSpace(bookName))
            {
                return LibraryDbContext.Logs
                          .Where(b => b.Action.Contains(bookName)).OrderByDescending(l => l.PerformedAt)
                          .ToList();
            }
            else
            {
                return LibraryDbContext.Logs
                          .Where(b => b.User.Username.Contains(userName)).OrderByDescending(l => l.PerformedAt)
                          .ToList();
            }
        }


    }
}
