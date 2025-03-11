using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Models
{
    public enum BorrowStatus { Borrowed, Returned, Overdue }

    public class BorrowingRecord
    {
        [Key]
        public int BorrowingId { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("BorrowingRecords")]
        public virtual User? User { get; set; }
            //= new User(); 
        [Required]
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        [InverseProperty("BorrowingRecords")]
        public virtual Book? Book { get; set; } 
            //= new Book();
        [Required]
        public DateTime BorrowDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [Required]
        public BorrowStatus Status { get; set; } = BorrowStatus.Borrowed;

       
    }
}
