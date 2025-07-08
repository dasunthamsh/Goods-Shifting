using Goods_Shifting.forms.Auth;
using Goods_Shifting.lib;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home();
            homeForm.FormClosed += (s, args) => this.Close();
            homeForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.FormClosed += (s, args) => this.Close(); // Close the Home form when Login is closed
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {

                conn.Open();
                string query = "SELECT customerid, name, email FROM customers WHERE email = @email AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // send user data to dashboard
                            string customerId = reader.GetString("customerid");
                            string userName = reader.GetString("name");
                            string userEmail = reader.GetString("email");



                            ToastMessage.Show(this, $"Welcome back, {userName}!");

                            this.Hide();
                            CreateJob dashboardForm = new CreateJob(customerId, userName);
                            dashboardForm.FormClosed += (s, args) => this.Close();
                            dashboardForm.Show();

                        }
                        else
                        {
                            ToastMessage.Show(this, "Invalid email or password", true);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                ToastMessage.Show(this, "Error: " + ex.Message, true);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ResatPassword resetPasswordForm = new ResatPassword();
            resetPasswordForm.FormClosed += (s, args) => this.Close();
            resetPasswordForm.Show();
        }
    }
        
}
