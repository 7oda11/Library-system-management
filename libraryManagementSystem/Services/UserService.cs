using libraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Services
{
    public static class UserService
    {
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
