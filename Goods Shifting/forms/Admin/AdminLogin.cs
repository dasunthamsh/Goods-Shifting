using Goods_Shifting.forms.Auth;
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

namespace Goods_Shifting.forms.Admin
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {

                conn.Open();

                string query = "SELECT managerid, name, email FROM managers WHERE managerid = @id AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            string managerId = reader.GetString("managerid");
                            string managerName = reader.GetString("name");

                            // Successful login
                            this.Hide();

                            // Pass admin info to dashboard
                            AdminDashboard dashboard = new AdminDashboard(managerId, managerName);
                            dashboard.FormClosed += (s, args) => this.Close();
                            dashboard.Show();
                        }
                        else
                        {
                            ToastMessage.Show(this, "Invalid username or password",true);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                ToastMessage.Show(this, "Error: " + ex.Message, true);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home();
            homeForm.FormClosed += (s, args) => this.Close();
            homeForm.Show();
        }
    }
}
