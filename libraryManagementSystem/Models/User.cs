using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace libraryManagementSystem.Models
{
    public enum UserRole { Librarian=0, Member=1 }
    [Index(nameof(Username), IsUnique = true)]  
    [Index(nameof(Email), IsUnique = true)]    
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required, StringLength(50)]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [NotMapped]
        public string confirmPasswordHash { get; set; }
        [Required]
        public UserRole Role { get; set; } 
        [Required, EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual List<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>();
        public virtual List<Log> Logs { get; set; } = new List<Log>();
    }
}
