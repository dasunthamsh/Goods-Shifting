using Goods_Shifting.lib;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goods_Shifting.forms.Customer
{
    public partial class ResatPassword : Form
    {
        public ResatPassword()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnResat_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // 1. Verify email exists
                    string checkQuery = "SELECT COUNT(*) FROM customers WHERE email = @email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("No account found with this email address.", "Reset Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 2. Update password
                    string updateQuery = "UPDATE customers SET password = @password WHERE email = @email";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        
                        updateCmd.Parameters.AddWithValue("@password", txtNewPassword.Text);
                        updateCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            ToastMessage.Show(this, "Password reset successfully!");

                            // Return to login page
                            this.Hide();
                            Login loginForm = new Login();
                            loginForm.FormClosed += (s, args) => this.Close();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password reset failed. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting password: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
