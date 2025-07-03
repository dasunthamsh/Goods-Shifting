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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Goods_Shifting.forms.Admin
{
    public partial class ContainerPanel : Form
    {
        public ContainerPanel()
        {
            InitializeComponent();
            cmbContainerType.Items.AddRange(new string[] { "Standard", "Reefer", "Open Top", "Flat Rack", "Tank" });
            cmbSize.Items.AddRange(new string[] { "20ft", "40ft", "45ft", "53ft" });
            LoadContainerData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                cmbContainerType.Text = row.Cells["Type"].Value.ToString();
                cmbSize.Text = row.Cells["Size"].Value.ToString();
                txtContainerNumber.Text = row.Cells["Container Number"].Value.ToString();
                lblID.Text = row.Cells["Container ID"].Value.ToString();

            }

        }

        private void LoadContainerData()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                // Query to get all vehicles with their status and availability
                string query = @"SELECT 
                                c.containerid AS 'Container ID',
                                c.type AS 'Type',
                                c.container_number AS 'Container Number',
                                c.size AS 'Size',
                                j.vehicleid AS 'Vehicle ID',
                                CASE 
                                    WHEN j.jobId IS NOT NULL AND j.status IN ('assigned', 'in-progress') THEN 'Assigned'
                                    WHEN c.status = 'in' THEN 'Available'
                                    WHEN c.status = 'Maintenance' THEN 'In Maintenance'
                                    ELSE c.status
                                END AS 'Availability'
                            FROM containers c
                            LEFT JOIN jobs j ON c.containerid= j.containerid
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

            string containerid = dataGridView1.CurrentRow.Cells["Container ID"].Value.ToString();
            UpdateContainerStatus(containerid, "Maintenance");
        }

        private void btnBackToProduction_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a vehicle first");
                return;
            }

            string containerid = dataGridView1.CurrentRow.Cells["Container ID"].Value.ToString();
            UpdateContainerStatus(containerid, "in");
        }

        private void UpdateContainerStatus(string containerid, string status)
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = "UPDATE containers SET status = @status WHERE containerid= @containerid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@containerid", containerid);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Container status updated successfully!");
                    LoadContainerData();
                }
                else
                {
                    MessageBox.Show("Container to update vehicle status");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Container status: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbContainerType.Text) ||
       string.IsNullOrWhiteSpace(cmbSize.Text) ||
       string.IsNullOrWhiteSpace(txtContainerNumber.Text))
            {
                MessageBox.Show("Please fill all required fields (Type, Size, Container Number)");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = @"INSERT INTO containers 
                        (type, size, container_number, status) 
                        VALUES 
                        (@type, @size, @container_number, 'in')";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", cmbContainerType.Text);
                cmd.Parameters.AddWithValue("@size", cmbSize.Text);
                cmd.Parameters.AddWithValue("@container_number", txtContainerNumber.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Container added successfully!");
                    LoadContainerData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add container");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error
                {
                    MessageBox.Show("A container with this number already exists");
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
                MessageBox.Show("Please select a container to edit");
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(cmbContainerType.Text) ||
                string.IsNullOrWhiteSpace(cmbSize.Text) ||
                string.IsNullOrWhiteSpace(txtContainerNumber.Text))
            {
                MessageBox.Show("Please fill all required fields (Type, Size, Container Number)");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = @"UPDATE containers SET 
                        type = @type,
                        size = @size,
                        container_number = @container_number
                        WHERE containerid = @containerid";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", cmbContainerType.Text);
                cmd.Parameters.AddWithValue("@size", cmbSize.Text);
                cmd.Parameters.AddWithValue("@container_number", txtContainerNumber.Text);
                cmd.Parameters.AddWithValue("@containerid", lblID.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Container updated successfully!");
                    LoadContainerData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("No changes were made or container not found");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error
                {
                    MessageBox.Show("A container with this number already exists");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblID.Text))
            {
                MessageBox.Show("Please select a container to delete");
                return;
            }

            // Get the selected container's details for confirmation message
            string containerNumber = txtContainerNumber.Text;
            string containerType = cmbContainerType.Text;
            string containerSize = cmbSize.Text;

            // Check if container is currently assigned to a job
            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.Cells["Availability"].Value.ToString() == "Assigned")
            {
                MessageBox.Show($"Cannot delete container {containerNumber} because it is currently assigned to a job.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this container?\n\n" +
                $"Type: {containerType}\n" +
                $"Size: {containerSize}\n" +
                $"Number: {containerNumber}",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = "DELETE FROM containers WHERE containerid = @containerid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@containerid", lblID.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Container deleted successfully!");
                    LoadContainerData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Container not found or could not be deleted");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451) // Foreign key constraint violation
                {
                    MessageBox.Show("Cannot delete container because it is referenced in job records.");
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
            cmbContainerType.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            txtContainerNumber.Clear();
            lblID.Text = "";
        }
    }
}
