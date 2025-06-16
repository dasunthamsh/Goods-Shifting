using System;
using System.Text.RegularExpressions;

namespace Goods_Shifting.Utilities
{
    public static class ValidationUtils
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Use simple regex pattern for basic email validation
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPassword(string password)
        {
            // Minimum 8 characters, at least one letter and one number
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            // Check for at least one digit and one letter
            bool hasLetter = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasNumber = true;

                if (hasLetter && hasNumber)
                    return true;
            }

            return false;
        }

        public static bool ValidateRegistrationFields(string name, string email, string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Please enter your name.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Please enter your email address.";
                return false;
            }

            if (!IsValidEmail(email))
            {
                errorMessage = "Please enter a valid email address.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please enter a password.";
                return false;
            }

            if (!IsValidPassword(password))
            {
                errorMessage = "Password must be at least 8 characters long and contain both letters and numbers.";
                return false;
            }

            return true;
        }
    }
}