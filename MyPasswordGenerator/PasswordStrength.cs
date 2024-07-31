using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            {
                return 0;
            }

            int strength = 0;

            //Increase strength for length
            strength += Math.Min(10 * password.Length, 60);

            if (password.Length == 8)
            {
                strength -= 40;
            }
            else if(password.Length == 9)
            {
                strength -= 35;
            }
            else if(password.Length == 10)
            {
                strength -= 30;
            }
            else if(password.Length == 11)
            {
                strength -= 25;
            }
            else if (password.Length == 12)
            {
                strength -= 20;
            }
            else
            {
                strength += 60;
            }

            //Increase strength for character types
            if (password.Any(char.IsUpper))
            {
                strength += 10;
            }
            if (password.Any(char.IsLower))
            {
                strength += 10;
            }
            if (password.Any(char.IsDigit))
            {
                strength += 10;
            }
            if (password.Any(ch => "!@#$%^&*()_+-=[]{}|;':\",./<>?".Contains(ch)))
            {
                strength += 10;
            }

            return Math.Min(MaxStrength, strength);
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
    }
}
