using Goods_Shifting.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods_Shifting.lib.Validations
{
    class CreateJobValidation
    {
        public static bool ValidateCreateJobForm(
             TextBox txtNumber,
             TextBox txtDestinationCity,
             TextBox txtDestinationAddress,
             TextBox txtOriginCity,
             TextBox txtOriginAddress,
             ComboBox cmbSize,
             Form form,
             ErrorProvider errorProvider) 
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                errorProvider.SetError(txtNumber, "Contact number is required");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtNumber.Text, @"^[0-9]{10}$"))
            {
                errorProvider.SetError(txtNumber, "Contact number should contain only digits");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDestinationCity.Text))
            {
                errorProvider.SetError(txtDestinationCity, "Destination city is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDestinationAddress.Text))
            {
                errorProvider.SetError(txtDestinationAddress, "Destination address is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtOriginCity.Text))
            {
                errorProvider.SetError(txtOriginCity, "Origin city is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtOriginAddress.Text))
            {
                errorProvider.SetError(txtOriginAddress, "Origin address is required");
                isValid = false;
            }

            if (cmbSize.SelectedIndex < 0)
            {
                errorProvider.SetError(cmbSize, "Please select a truck size");
                isValid = false;
            }

            return isValid;
        }
    }
}
