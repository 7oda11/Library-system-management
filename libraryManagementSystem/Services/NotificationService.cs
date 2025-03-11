using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using libraryManagementSystem.Models;
using libraryManagementSystem.GmailServices;
namespace libraryManagementSystem.Services
{
    public class NotificationService
    {
        private readonly LibraryDbContext _context;
        private readonly GmailService _gmailService;

        public NotificationService(LibraryDbContext context, GmailService gmailService)
        {
            _context = context;
            _gmailService = gmailService;
        }

        public void SendOverdueNotifications()
        {
            var overdueRecords = _context.BorrowingRecords
                .Include(b => b.User)
                .Include(b => b.Book)
                .Where(b => b.DueDate < DateTime.Now && b.Status != BorrowStatus.Returned)
                .ToList();

            if (overdueRecords.Any())
            {
                foreach (var record in overdueRecords)
                {
                    string email = record.User.Email;
                    string subject = "📢 Library Overdue Notice!";
                    string body = $@"
                        <p>Dear {record.User.Username},</p>
                        <p>The book <strong>{record.Book.Title}</strong> was due on <strong>{record.DueDate:dd/MM/yyyy}</strong>.</p>
                        <p>Please return it as soon as possible to avoid penalties.</p>
                        <p>Thank you for using our library services!</p>";

                    _gmailService.SendNotificationDueBorrowDate(email, body);

                    // Update status to Overdue
                    record.Status = BorrowStatus.Overdue;
                }

                _context.SaveChanges();
                Console.WriteLine("✅ Overdue notifications sent successfully.");
            }
            else
            {
                Console.WriteLine("✅ No overdue books found.");
            }
        }
    }
}
