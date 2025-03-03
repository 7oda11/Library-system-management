using libraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem.Services
{
    public class UserService
    {
        private readonly LibraryDbContext _context;

        public UserService()
        {
            _context = new LibraryDbContext();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User Login(string username, string password)
        {
            
            var user = _context.Users.FirstOrDefault(u => u.Username == username);

       
            if (user != null && user.PasswordHash == HashPassword(password))
            {
                return user; 
            }

            return null;
        }


        public string Register(string username, string password, string confirmPassword, string email, string phoneNumber, UserRole role)
        {


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                return "Username, password, and email are required!";
            }

            if (password != confirmPassword)
            {
                return "Passwords do not match!";
            }

            if (_context.Users.Any(u => u.Username == username))
            {
                return "Username already exists!";
            }

            if (_context.Users.Any(u => u.Email == email))
            {
                return "Email is already in use!";
            }

            var newUser = new User
            {
                Username = username,
                PasswordHash = HashPassword(password),
                Email = email,
                PhoneNumber = phoneNumber,
                Role = role,
                CreatedAt = DateTime.Now
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return "User registered successfully!";

        }





        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
