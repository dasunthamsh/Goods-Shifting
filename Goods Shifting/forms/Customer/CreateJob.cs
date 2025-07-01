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
    public partial class CreateJob : Form
    {

        private string customerId;
        private string customerName;
        public CreateJob(string customerId, string customerName)
        {
            InitializeComponent();

           

            AddTruckTypes();
            this.customerId = customerId;
            this.customerName = customerName;

            txtName.Text = customerName;
        }

        private void AddTruckTypes()
        {
            // Clear existing items
            cmbSize.Items.Clear();

            // Add truck types to the combo box
            cmbSize.Items.Add("Few Items");
            cmbSize.Items.Add("1 BHK");
            cmbSize.Items.Add("2 BHK");
            cmbSize.Items.Add("3 BHK");
            cmbSize.Items.Add("4 BHK");
            cmbSize.Items.Add("5 BHK");


            // Optionally set a default selected item
            cmbSize.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveJobToDatabase();
            }
        }


        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(txtDestinationCity.Text) ||
                string.IsNullOrWhiteSpace(txtDestinationAddress.Text) ||
                string.IsNullOrWhiteSpace(txtOriginCity.Text) ||
                string.IsNullOrWhiteSpace(txtOriginAddress.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveJobToDatabase()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();
                string query = @"INSERT INTO jobs 
                                (customerid, size, Moving_date, contact, 
                                 destination_city, destination_address, origin_city, 
                                 origin_address, description, customer_name)
                                VALUES 
                                (@customerId, @truckSize, @pickupDate, @contactNumber, 
                                 @destinationCity, @destinationAddress, @originCity, 
                                 @originAddress, @specialInstructions, @customerName)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@truckSize", cmbSize.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@pickupDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@contactNumber", txtNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@destinationCity", txtDestinationCity.Text.Trim());
                    cmd.Parameters.AddWithValue("@destinationAddress", txtDestinationAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@originCity", txtOriginCity.Text.Trim());
                    cmd.Parameters.AddWithValue("@originAddress", txtOriginAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@specialInstructions", txtMessage.Text);
                    cmd.Parameters.AddWithValue("@customerName", txtName.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Job created successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("Failed to create job.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving job: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
