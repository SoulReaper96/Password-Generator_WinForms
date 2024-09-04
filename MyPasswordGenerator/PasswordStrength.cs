using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPasswordGenerator
{
    internal class PasswordStrength
    {
        private const int MaxStrength = 100;

        /// <summary>
        /// Calculates the strength of a given password based on various criteria.
        /// </summary>
        /// <param name="password">The password to calculate strength for.</param>
        /// <returns>The strength value of the password.</returns>
        public int CalculateStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
                return 0;

            int score = 0;

            // Length
            if (password.Length >= 8)
                score += 25;
            else if (password.Length >= 6)
                score += 10;
            else
                score += 5;

            // Lowercase letters
            if (Regex.IsMatch(password, @"[a-z]"))
                score += 15;

            // Uppercase letters
            if (Regex.IsMatch(password, @"[A-Z]"))
                score += 15;

            // Digits
            if (Regex.IsMatch(password, @"[0-9]"))
                score += 20;

            // Special characters
            if (Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]"))
                score += 25;

            // Common patterns or dictionary words (optional)
            if (ContainsCommonPatterns(password))
                score -= 20;

            return Math.Min(score, MaxStrength); // Ensure the score does not exceed 100%
        }

        /// <summary>
        /// Visualizes the strength of a given password using a progress bar.
        /// </summary>
        /// <param name="password">The password to visualize the strength for.</param>
        public void VisualizePasswordStrength(string password)
        {
            int strength = CalculateStrength(password);
            int barLength = 50; // Length of the visualization bar
            int filledLength = (strength * barLength) / MaxStrength;
            string strengthBar = new string('#', filledLength) + new string('-', barLength - filledLength);

            Console.WriteLine($"Password Strength: {strength}%");
            Console.WriteLine($"[{strengthBar}]");
        }

        private static bool ContainsCommonPatterns(string password)
        {
            // This is a simple example. You can expand this list or use a more comprehensive dictionary.
            string[] commonPatterns = new string[]
            {
                "123456", "password", "123456789", "12345678", "12345",
                "1234567", "1234567890", "qwerty", "abc123", "111111",
                "123123", "admin", "letmein", "welcome", "monkey",
                "1234", "1q2w3e4r", "password1", "123qwe", "iloveyou",
                "sunshine", "football", "123", "000000", "qwerty123",
                "1qaz2wsx", "qazwsx", "trustno1", "baseball", "dragon",
                "superman", "123321", "password123", "654321", "1qazxsw2",
                "master", "michael", "qwertyuiop", "starwars", "123qaz",
                "hello", "charlie", "aaaaaa", "donald", "letmein123",
                "flower", "loveyou", "zxcvbnm", "123654", "bismillah",
                "hunter", "tigger", "shadow", "123abc", "passw0rd",
                "freedom", "whatever", "q1w2e3r4", "baseball1", "football1",
                "password2", "1111", "mypass", "asdfgh", "1qaz",
                "asdf", "pass123", "asdfghjkl", "p@ssw0rd", "login",
                "batman", "123456a", "zaq12wsx", "password4", "zxcvbn",
                "google", "qwerty1", "hello123", "welcome1", "football2",
                "superuser", "11111111", "666666", "summer", "pokemon",
                "letmein1", "jordan23", "secret", "master123", "1q2w3e",
                "qwer1234", "password5", "liverpool", "admin123", "golf",
                "superman1", "michael1", "chocolate", "password6", "starwars1"
            };


            foreach (string pattern in commonPatterns)
            {
                if (password.ToLower().Contains(pattern))
                    return true;
            }

            return false;
        }
    }
}
