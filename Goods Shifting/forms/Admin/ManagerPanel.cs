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
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
            loadDataToTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtContact.Text = row.Cells["phone"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtID.Text = row.Cells["id_number"].Value.ToString();
                lblID.Text = row.Cells["managerid"].Value.ToString();
            }
        }

        private void loadDataToTable()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            string query = "SELECT managerid, name, email, phone, address, id_number FROM managers ";

            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            conn.Open();
            adapter.Fill(dataTable);


            dataGridView1.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtContact.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtAddress.Text) ||
               string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate random password
            string password = GenerateRandomPassword();

            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                string query = "INSERT INTO managers (name, email, phone, address, id_number, password) " +
                              "VALUES (@name, @email, @phone, @address, @id_number, @password)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@phone", txtContact.Text);
                command.Parameters.AddWithValue("@address", txtAddress.Text);
                command.Parameters.AddWithValue("@id_number", txtID.Text);
                command.Parameters.AddWithValue("@password", password); // Note: In real app, hash the password

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                // Simulate sending email to admin
                SimulateEmailSending(txtEmail.Text, txtName.Text, password);

                MessageBox.Show("Manager added successfully! Password has been sent to admin email.",
                              "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data grid
                loadDataToTable();

                // Clear fields
                txtName.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtID.Clear();
                lblID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding manager: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private string GenerateRandomPassword(int length = 8)
        {
            // Create a random password with letters and numbers
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }

        private void SimulateEmailSending(string toEmail, string managerName, string password)
        {
            // In a real application, you would use an email service here
            // For this assignment, we'll just show a message box with the email details

            string emailContent = $"To: tunathamash@gmail.com (Admin)\n" +
                                $"Subject: New Manager Account Created\n\n" +
                                $"Dear Admin,\n\n" +
                                $"A new manager account has been created for {managerName}.\n" +
                                $"Email: {toEmail}\n" +
                                $"Temporary Password: {password}\n\n" +
                                $"Please inform the manager to change their password after first login.\n\n" +
                                $"Regards,\nGoods Shifting System";

            // In a real application, you would send the email here
            // For this assignment, we'll just show what would be sent
            MessageBox.Show("Email would be sent with following content:\n\n" + emailContent,
                          "Email Simulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
