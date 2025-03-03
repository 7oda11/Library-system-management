using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace libraryManagementSystem.Models
{
    public class LibraryDbContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BorrowingRecord> BorrowingRecords { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.\\DEV;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
