using Goods_Shifting.forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Goods_Shifting;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Goods_Shifting.Utilities;
using Goods_Shifting.lib;
using Goods_Shifting.lib.Validations;


namespace Goods_Shifting.forms.Customer
{
    public partial class Register : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) => this.Close(); // Close the Home form when Login is closed
            loginForm.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) => this.Close(); // Close the Home form when Login is closed
            loginForm.Show();
        }

        private void btnRgister_Click(object sender, EventArgs e)
        {

            if (!UserRegisterValidation.ValidateRegistrationForm(
                 txtName,
                 txtEmail,
                 txtPassword,
                 this,
                 errorProvider))
            {
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {

                conn.Open();

                // Check if email already exists
                string checkQuery = "SELECT COUNT(*) FROM customers WHERE email = @Email";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Email already registered.");
                    return;
                }

                string hashedPassword = Hasher.HashPassword(txtPassword.Text);

                string query = "INSERT INTO customers (name, email, password) VALUES (@name, @email, @password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    ToastMessage.Show(this, "Registration successful!");

                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.FormClosed += (s, args) => this.Close();
                    loginForm.Show();
                }
                else
                {
                    ToastMessage.Show(this, "Registration failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
