﻿using libraryManagementSystem.Models;
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
        public static LibraryDbContext LibraryDbContext=new LibraryDbContext();
        public static User user = new User()
        {
            UserId = 8,
            Username = "mahmoud",
            PasswordHash = "123456789",
            Role = 0,
            Email = "mahmoud@gmail.com",
            PhoneNumber = "1234567890"

        };
         static UserService()
        {
            
        }
        public static List<User> getAllUsers()
        {
            return LibraryDbContext.Users.Where(u=>u.UserId!=user.UserId).ToList();
        }
        public static bool addUser(User user)
        {
            if (checkUniqueEmail(user))
            {

                if (checkUniquePhone(user))
                {
                    LibraryDbContext.Users.Add(user);
                    LibraryDbContext.SaveChanges();
                    return true;

                }
                else
                {
                    MessageBox.Show("User with this Phone already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("User with this email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static bool checkUniqueEmail(User user) {
            if (LibraryDbContext.Users.Where(u => u.Email == user.Email).Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool checkUniquePhone(User user)
        {
            if (LibraryDbContext.Users.Where(u => u.PhoneNumber == user.PhoneNumber).Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool checkUniqueEmailForUpdateUser(User user)
        {
            if (LibraryDbContext.Users.Where(u => u.Email == user.Email && u.UserId!=user.UserId).Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool checkUniquePhoneForUpdateUser(User user)
        {
            if (LibraryDbContext.Users.Where(u => u.PhoneNumber == user.PhoneNumber && u.UserId != user.UserId).Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static User getUserById(int id)
        {
            return LibraryDbContext.Users.Where(u=>u.UserId==id).FirstOrDefault();
        }
        public static bool updateUser(User user)
        {
            if (checkUniqueEmailForUpdateUser(user))
            {
                if (checkUniquePhoneForUpdateUser(user)) {
                    LibraryDbContext.SaveChanges();
                    return true;
                }
                else
                {
                   
                        MessageBox.Show("User with this Phone already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    
                }
            }
            else
            {
                MessageBox.Show("User with this email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        public static bool deleteUser(int id)
        {
            User user = LibraryDbContext.Users.FirstOrDefault(u => u.UserId == id);
            if (user == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            LibraryDbContext.Users.Remove(user);
            LibraryDbContext.SaveChanges();
            return true;
        }
    }
}
