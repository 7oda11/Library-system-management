using System;
using System.Security.Cryptography;
using System.Text;

namespace libraryManagementSystem.Services
{
    public static class HashService
    {
        /// <summary>
        /// Hashes a password using SHA-256 encryption.
        /// </summary>
        /// <param name="password">The plain text password.</param>
        /// <returns>Hashed password as a Base64 string.</returns>
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Verifies if the provided password matches the hashed password.
        /// </summary>
        /// <param name="inputPassword">Plain text password.</param>
        /// <param name="hashedPassword">Hashed password from the database.</param>
        /// <returns>True if the password matches, false otherwise.</returns>
        public static bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            return HashPassword(inputPassword) == hashedPassword;
        }
    }
}
