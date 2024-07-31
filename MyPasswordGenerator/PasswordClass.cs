using System.Text;

namespace MyPasswordGenerator
{
    internal class PasswordClass
    {
        public string GeneratePassword(int length, bool includeUppercase = true, bool includeLowercase = true, bool includeDigits = true, bool includeSpecialCharacters = true, bool includeBrackets = true)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Password length must be greater than 0");
            }

            var characterSet = new StringBuilder();

            if (includeUppercase)
            {
                characterSet.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            }
            if (includeLowercase)
            {
                characterSet.Append("abcdefghijklmnopqrstuvwxyz");
            }
            if (includeDigits)
            {
                characterSet.Append("0123456789");
            }
            if (includeSpecialCharacters)
            {
                characterSet.Append("!@#$%^&*()_+-=[]{}|;':\",./<>?");
            }
            if (includeBrackets)
            {
                characterSet.Append("[]{}()");
            }
            if (characterSet.Length == 0)
            {
                throw new ArgumentException("At least one character set must be included");
            }

            var password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                var randomIndex = random.Next(characterSet.Length);
                password.Append(characterSet[randomIndex]);
            }

            return password.ToString();
        }
    }
}
