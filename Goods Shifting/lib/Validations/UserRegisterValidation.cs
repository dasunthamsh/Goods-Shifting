using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods_Shifting.lib.Validations
{
    class UserRegisterValidation
    {
        public static bool ValidateRegistrationForm(
           TextBox txtName,
           TextBox txtEmail,
           TextBox txtPassword,
           Form form,
           ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool isValid = true;

            // Name validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Full name is required");
                isValid = false;
            }
            else if (txtName.Text.Length < 3)
            {
                errorProvider.SetError(txtName, "Name must be at least 3 characters");
                isValid = false;
            }
            else if (txtName.Text.Length > 50)
            {
                errorProvider.SetError(txtName, "Name cannot exceed 50 characters");
                isValid = false;
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Email is required");
                isValid = false;
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Please enter a valid email address");
                isValid = false;
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password is required");
                isValid = false;
            }
            else if (txtPassword.Text.Length < 8)
            {
                errorProvider.SetError(txtPassword, "Password must be at least 8 characters");
                isValid = false;
            }
           

            return isValid;
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

       
    }
}
