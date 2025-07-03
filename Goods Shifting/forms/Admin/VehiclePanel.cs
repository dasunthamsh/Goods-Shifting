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
    public partial class VehiclePanel : Form
    {
        public VehiclePanel()
        {
            InitializeComponent();
            cmbVhicleType.Items.AddRange(new string[] { "Small Truck", "Medium Truck", "Large Truck", "Container Truck", "Pickup Truck" });
            LoadVehicleData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtNumber.Text = row.Cells["Vehicle Number"].Value.ToString();
                cmbVhicleType.Text = row.Cells["Type"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                lblID.Text = row.Cells["Vehicle ID"].Value.ToString();
            }
        }

        private void LoadVehicleData()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                // Query to get all vehicles with their status and availability
                string query = @"SELECT 
                                v.vehicleid AS 'Vehicle ID',
                                v.type AS 'Type',
                                v.brand AS 'Brand',
                                v.vehicle_number AS 'Vehicle Number',
                                v.name AS 'Name',
                                j.containerid AS 'Container ID',
                                CASE 
                                    WHEN j.jobId IS NOT NULL AND j.status IN ('assigned', 'in-progress') THEN 'Assigned'
                                    WHEN v.status = 'in' THEN 'Available'
                                    WHEN v.status = 'Maintenance' THEN 'In Maintenance'
                                    ELSE v.status
                                END AS 'Availability'
                            FROM vehicles v
                            LEFT JOIN jobs j ON v.vehicleid = j.vehicleid 
                                AND j.status IN ('assigned', 'in-progress')";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = dataTable;

                // Format the DataGridView
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["Availability"].DefaultCellStyle.ForeColor = Color.White;

                // Apply color coding after data is loaded
                dataGridView1.DataBindingComplete += (s, e) =>
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow || row.Cells["Availability"].Value == null)
                            continue;

                        string availability = row.Cells["Availability"].Value.ToString();
                        if (availability == "Assigned")
                        {
                            row.Cells["Availability"].Style.BackColor = Color.IndianRed;
                        }
                        else if (availability == "Available")
                        {
                            row.Cells["Availability"].Style.BackColor = Color.MediumSeaGreen;
                        }
                        else if (availability == "In Maintenance")
                        {
                            row.Cells["Availability"].Style.BackColor = Color.LightSlateGray;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicle data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAddToMaintenace_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a vehicle first");
                return;
            }

            string vehicleId = dataGridView1.CurrentRow.Cells["Vehicle ID"].Value.ToString();
            UpdateVehicleStatus(vehicleId, "Maintenance");
        }

        private void btnBackToProduction_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a vehicle first");
                return;
            }

            string vehicleId = dataGridView1.CurrentRow.Cells["Vehicle ID"].Value.ToString();
            UpdateVehicleStatus(vehicleId, "in");
        }

        private void UpdateVehicleStatus(string vehicleId, string status)
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = "UPDATE vehicles SET status = @status WHERE vehicleid = @vehicleId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@vehicleId", vehicleId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vehicle status updated successfully!");
                    LoadVehicleData();
                }
                else
                {
                    MessageBox.Show("Failed to update vehicle status");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vehicle status: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
       string.IsNullOrWhiteSpace(txtNumber.Text) ||
       string.IsNullOrWhiteSpace(cmbVhicleType.Text) ||
       string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Please fill all required fields (Name, Vehicle Number, Type, Brand)");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                // Insert into vehicles table
                string query = @"INSERT INTO vehicles 
                        (name, vehicle_number, type, brand, status) 
                        VALUES 
                        (@name, @vehicle_number, @type, @brand, 'in')";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@vehicle_number", txtNumber.Text);
                cmd.Parameters.AddWithValue("@type", cmbVhicleType.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vehicle added successfully!");

                    // Refresh the vehicle list
                    LoadVehicleData();

                    // Clear the form
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add vehicle");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error
                {
                    MessageBox.Show("A vehicle with this number already exists");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblID.Text))
            {
                MessageBox.Show("Please select a vehicle to edit");
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(cmbVhicleType.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Please fill all required fields (Name, Vehicle Number, Type, Brand)");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = @"UPDATE vehicles SET 
                        name = @name,
                        vehicle_number = @vehicle_number,
                        type = @type,
                        brand = @brand
                        WHERE vehicleid = @vehicleId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@vehicle_number", txtNumber.Text);
                cmd.Parameters.AddWithValue("@type", cmbVhicleType.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@vehicleId", lblID.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vehicle updated successfully!");
                    LoadVehicleData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("No changes were made or vehicle not found");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error
                {
                    MessageBox.Show("A vehicle with this number already exists");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtNumber.Clear();
            cmbVhicleType.SelectedIndex = -1;
            txtBrand.Clear();
            lblID.Text = "";
        }
    }
}
