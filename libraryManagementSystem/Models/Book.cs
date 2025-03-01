using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Models
{
    [Index(nameof(ISBN), IsUnique = true)]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(50)]
        public string Author { get; set; }
        [Required, StringLength(20)]
        public string ISBN { get; set; }
        public string Category { get; set; }
        public int PublishedYear { get; set; }
        public int Quantity { get; set; } // Stock
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [InverseProperty("Book")]
        public virtual List<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>();
    }
}
