﻿using Microsoft.EntityFrameworkCore;
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
        public string Title { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string Author { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string ISBN { get; set; } = string.Empty;
        public int PublishedYear { get; set; }
        public int Quantity { get; set; } // Stock
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [InverseProperty("Book")]
        public virtual List<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>();

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = new Category();
        public override string ToString()
        {
            return $"{Category.Name}";
        }
    }
}
