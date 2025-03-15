using DocumentFormat.OpenXml.Math;
using libraryManagementSystem.Services;
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
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=LAPTOP-JMGMI5SB\\DEV;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Default Admin User
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId=1,
                Username = "admin",
                Email = "admin@library.com",
                PasswordHash = HashService.HashPassword("Admin@123"), // Use HashService to hash the password
                PhoneNumber="12345678978",
                Role = UserRole.Admin,
                CreatedAt = new DateTime(2024, 1, 1) // ✅ Fixed DateTime

            });
        }

        }
}
