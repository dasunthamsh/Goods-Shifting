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
    public partial class NewJobsPanel : Form
    {

        private string managerId;
        private string selectedJobMovingDate;
        public NewJobsPanel(string managerId)
        {
            InitializeComponent();
            loadDataToTable();
            this.managerId = managerId;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                txtJobId.Text = row.Cells["jobId"].Value.ToString();


                if (DateTime.TryParse(row.Cells["Moving_date"].Value.ToString(), out DateTime movingDate))

                {
                    selectedJobMovingDate = movingDate.ToString("yyyy-MM-dd");
                    LoadAvailableDrivers();
                    LoadAvailableAssistants();
                    LoadAvailableVehicles();

                  
                }
            }
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtJobId.Text) ||
            cmbDriver.SelectedItem == null ||
            cmbVehicle.SelectedItem == null ||
            cmbAssistant.SelectedItem == null)
            {
                MessageBox.Show("Please select a job and ensure all fields (Driver, Vehicle, Assistant) are selected.");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();
            MySqlTransaction transaction = null;

            try
            {
                conn.Open();


                string jobId = txtJobId.Text;
                string driverId = cmbDriver.SelectedItem.ToString();
                string vehicleId = cmbVehicle.SelectedItem.ToString();
                string assistantId = cmbAssistant.SelectedItem.ToString();
                

                // Update the jobs table
                string updateJobQuery = @"UPDATE jobs 
                                SET managerid = @managerId, 
                                    driverid = @driverId, 
                                    vehicleid = @vehicleId, 
                                    assistantid = @assistantId, 
                                    status = 'assigned' 
                                WHERE jobId = @jobId";

                MySqlCommand updateJobCmd = new MySqlCommand(updateJobQuery, conn, transaction);
                updateJobCmd.Parameters.AddWithValue("@managerId", managerId);
                updateJobCmd.Parameters.AddWithValue("@driverId", driverId);
                updateJobCmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                updateJobCmd.Parameters.AddWithValue("@assistantId", assistantId);
                updateJobCmd.Parameters.AddWithValue("@jobId", jobId);
                updateJobCmd.ExecuteNonQuery();



                MessageBox.Show("Job assigned successfully!");

                // Refresh the data grid
                loadDataToTable();

                // Clear the form
                txtJobId.Clear();
                cmbDriver.Items.Clear();
                cmbVehicle.Items.Clear();
                cmbAssistant.Items.Clear();
            }
            catch (Exception ex)
            {
                // Roll back the transaction if any error occurs


                MessageBox.Show("Error assigning job: " + ex.Message);

                conn.Close();
            }
        }

        private void loadDataToTable()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            string query = "SELECT jobId, customerid, contact, destination_address, destination_city, " +
                                 "origin_address, origin_city, Moving_date, create_date " +
                                 "FROM jobs WHERE status = 'pending'";

            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            conn.Open();
            adapter.Fill(dataTable);


            dataGridView1.DataSource = dataTable;
        }


        private void LoadAvailableDrivers()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                // Query to get all drivers who are not assigned to any job on the selected moving date
                string query = @"SELECT d.driverid 
                    FROM drivers d
                    LEFT JOIN jobs j ON d.driverid = j.driverid 
                        AND DATE(j.Moving_date) = DATE(@movingDate)
                        AND j.status != 'completed'
                    WHERE j.driverid IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@movingDate", selectedJobMovingDate);


                MySqlDataReader reader = cmd.ExecuteReader();

                cmbDriver.Items.Clear();

                while (reader.Read())
                {
                    cmbDriver.Items.Add(reader["driverid"].ToString());

                }

                if (cmbDriver.Items.Count > 0)
                {
                    cmbDriver.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No available drivers for the selected date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading drivers: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }




        private void LoadAvailableAssistants()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                // Query to get all assistants who are not assigned to any job on the selected moving date
                string query = @"SELECT a.assistantid 
                    FROM assistants a
                    LEFT JOIN jobs j ON a.assistantid = j.assistantid 
                        AND DATE(j.Moving_date) = DATE(@movingDate)
                        AND j.status != 'completed'
                    WHERE j.assistantid IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@movingDate", selectedJobMovingDate);

                MySqlDataReader reader = cmd.ExecuteReader();

                cmbAssistant.Items.Clear();

                while (reader.Read())
                {
                    cmbAssistant.Items.Add(reader["assistantid"].ToString());
                }

                if (cmbAssistant.Items.Count > 0)
                {
                    cmbAssistant.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No available assistants for the selected date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assistants: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void LoadAvailableVehicles()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                // Query to get all vehicles that are not assigned to any job on the selected moving date
                string query = @"SELECT v.vehicleid 
                    FROM vehicles v
                    LEFT JOIN jobs j ON v.vehicleid = j.vehicleid 
                        AND DATE(j.Moving_date) = DATE(@movingDate)
                        AND j.status != 'completed'
                    WHERE j.vehicleid IS NULL
                    AND v.status = 'in'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@movingDate", selectedJobMovingDate);

                MySqlDataReader reader = cmd.ExecuteReader();

                cmbVehicle.Items.Clear();

                while (reader.Read())
                {
                    cmbVehicle.Items.Add(reader["vehicleId"].ToString());
                }

                if (cmbVehicle.Items.Count > 0)
                {
                    cmbVehicle.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No available vehicles for the selected date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRemoveJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text))
            {
                MessageBox.Show("Please select a job to cancel.");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string jobId = txtJobId.Text;

                // Update the job status to cancelled
                string updateJobQuery = @"UPDATE jobs 
                                SET status = 'cancelled' 
                                WHERE jobId = @jobId";

                MySqlCommand updateJobCmd = new MySqlCommand(updateJobQuery, conn);
                updateJobCmd.Parameters.AddWithValue("@jobId", jobId);

                int rowsAffected = updateJobCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Job has been cancelled successfully!");

                    // Refresh the data grid
                    loadDataToTable();

                    // Clear the form
                    txtJobId.Clear();
                    cmbDriver.Items.Clear();
                    cmbVehicle.Items.Clear();
                    cmbAssistant.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No job was cancelled. Please check the job ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling job: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
