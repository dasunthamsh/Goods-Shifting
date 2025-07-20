using iTextSharp.text.pdf;
using iTextSharp.text;
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
using Goods_Shifting.lib;

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

            checkedListBoxDrivers.CheckOnClick = true;
            checkedListBoxAssistants.CheckOnClick = true;
            checkedListBoxVehicles.CheckOnClick = true;
            checkedListBoxContainers.CheckOnClick = true;
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
                    LoadAvailableContainers();

                }
            }
        }

        private void LoadAvailableDrivers()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT d.driverid, d.name 
                            FROM drivers d
                            LEFT JOIN job_drivers jd ON d.driverid = jd.driver_id 
                                AND jd.job_id IN (
                                    SELECT jobId FROM jobs 
                                    WHERE DATE(Moving_date) = DATE(@movingDate))
                            LEFT JOIN jobs j ON jd.job_id = j.jobId
                            WHERE jd.driver_id IS NULL
                            AND d.status = 'in'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@movingDate", selectedJobMovingDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        checkedListBoxDrivers.Items.Clear();

                        while (reader.Read())
                        {
                            checkedListBoxDrivers.Items.Add(
                                new KeyValuePair<string, string>(
                                    reader["driverid"].ToString(),
                                    $"{reader["driverid"]} - {reader["name"]}"
                                )
                            );
                        }

                        if (checkedListBoxDrivers.Items.Count == 0)
                        {
                            ToastMessage.Show(this, "No available drivers for the selected date.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading drivers: " + ex.Message);
                }
            }
        }


        private void LoadAvailableAssistants()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT a.assistantid, a.name 
                            FROM assistants a
                            LEFT JOIN job_assistants ja ON a.assistantid = ja.assistant_id 
                                AND ja.job_id IN (
                                    SELECT jobId FROM jobs 
                                    WHERE DATE(Moving_date) = DATE(@movingDate))
                            LEFT JOIN jobs j ON ja.job_id = j.jobId
                            WHERE ja.assistant_id IS NULL
                            AND a.status = 'in'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@movingDate", selectedJobMovingDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        checkedListBoxAssistants.Items.Clear();

                        while (reader.Read())
                        {
                            checkedListBoxAssistants.Items.Add(
                                new KeyValuePair<string, string>(
                                    reader["assistantid"].ToString(),
                                    $"{reader["assistantid"]} - {reader["name"]}"
                                )
                            );
                        }

                        if (checkedListBoxAssistants.Items.Count == 0)
                        {
                            ToastMessage.Show(this, "No available assistants for the selected date.", true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assistants: " + ex.Message);
                }
            }
        }



        private void LoadAvailableVehicles()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT v.vehicleid, v.name 
                            FROM vehicles v
                            LEFT JOIN job_vehicles jv ON v.vehicleid = jv.vehicle_id 
                                AND jv.job_id IN (
                                    SELECT jobId FROM jobs 
                                    WHERE DATE(Moving_date) = DATE(@movingDate))
                            LEFT JOIN jobs j ON jv.job_id = j.jobId
                            WHERE jv.vehicle_id IS NULL
                            AND v.status = 'in'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@movingDate", selectedJobMovingDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        checkedListBoxVehicles.Items.Clear();

                        while (reader.Read())
                        {
                            checkedListBoxVehicles.Items.Add(
                                new KeyValuePair<string, string>(
                                    reader["vehicleid"].ToString(),
                                    $"{reader["vehicleid"]} - {reader["name"]}"
                                )
                            );
                        }

                        if (checkedListBoxVehicles.Items.Count == 0)
                        {
                            ToastMessage.Show(this, "No available vehicles for the selected date.", true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading vehicles: " + ex.Message);
                }
            }
        }




        private void LoadAvailableContainers()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT c.containerid, c.type 
                            FROM containers c
                            LEFT JOIN job_containers jc ON c.containerid = jc.container_id 
                                AND jc.job_id IN (
                                    SELECT jobId FROM jobs 
                                    WHERE DATE(Moving_date) = DATE(@movingDate))
                            LEFT JOIN jobs j ON jc.job_id = j.jobId
                            WHERE jc.container_id IS NULL
                            AND c.status = 'in'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@movingDate", selectedJobMovingDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        checkedListBoxContainers.Items.Clear();

                        while (reader.Read())
                        {
                            checkedListBoxContainers.Items.Add(
                                new KeyValuePair<string, string>(
                                    reader["containerid"].ToString(),
                                    $"{reader["containerid"]} - {reader["type"]}"
                                )
                            );
                        }

                        if (checkedListBoxContainers.Items.Count == 0)
                        {
                            MessageBox.Show("No available containers for the selected date.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading containers: " + ex.Message);
                }
            }
        }



        private void loadDataToTable()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
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
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text) ||
               checkedListBoxDrivers.CheckedItems.Count == 0 ||
               checkedListBoxVehicles.CheckedItems.Count == 0 ||
               checkedListBoxAssistants.CheckedItems.Count == 0 ||
               checkedListBoxContainers.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a job and ensure all fields have at least one selection.");
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    string jobId = txtJobId.Text;

                    // Update job status and manager
                    string updateJobQuery = @"UPDATE jobs 
                                        SET managerid = @managerId, 
                                            status = 'assigned' 
                                        WHERE jobId = @jobId";

                    MySqlCommand updateJobCmd = new MySqlCommand(updateJobQuery, conn, transaction);
                    updateJobCmd.Parameters.AddWithValue("@managerId", managerId);
                    updateJobCmd.Parameters.AddWithValue("@jobId", jobId);
                    updateJobCmd.ExecuteNonQuery();

                    // Assign multiple drivers
                    foreach (var item in checkedListBoxDrivers.CheckedItems)
                    {
                        var driver = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_drivers (job_id, driver_id) VALUES (@jobId, @driverId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@driverId", driver.Key);
                        cmd.ExecuteNonQuery();
                    }

                    // Assign multiple assistants
                    foreach (var item in checkedListBoxAssistants.CheckedItems)
                    {
                        var assistant = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_assistants (job_id, assistant_id) VALUES (@jobId, @assistantId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@assistantId", assistant.Key);
                        cmd.ExecuteNonQuery();
                    }

                    // Assign multiple vehicles
                    foreach (var item in checkedListBoxVehicles.CheckedItems)
                    {
                        var vehicle = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_vehicles (job_id, vehicle_id) VALUES (@jobId, @vehicleId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@vehicleId", vehicle.Key);
                        cmd.ExecuteNonQuery();
                    }

                    // Assign multiple containers
                    foreach (var item in checkedListBoxContainers.CheckedItems)
                    {
                        var container = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_containers (job_id, container_id) VALUES (@jobId, @containerId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@containerId", container.Key);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    ToastMessage.Show(this, "Job assigned successfully with all resources!");

                    loadDataToTable();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    ToastMessage.Show(this, "Error assigning job: " + ex.Message);
                }
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
                    ToastMessage.Show(this, "Job has been cancelled successfully!");

                    // Refresh the data grid
                    loadDataToTable();


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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text))
            {
                MessageBox.Show("Please enter a Job ID to search.");
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // First check if the job exists and get its moving date
                    string jobQuery = "SELECT jobId, Moving_date FROM jobs WHERE jobId = @jobId";
                    MySqlCommand jobCmd = new MySqlCommand(jobQuery, conn);
                    jobCmd.Parameters.AddWithValue("@jobId", txtJobId.Text);

                    using (MySqlDataReader jobReader = jobCmd.ExecuteReader())
                    {
                        if (jobReader.Read())
                        {
                            selectedJobMovingDate = jobReader["Moving_date"].ToString();
                            jobReader.Close(); // Close the reader before executing new queries

                            // Load available resources
                            LoadAvailableDrivers();
                            LoadAvailableAssistants();
                            LoadAvailableVehicles();
                            LoadAvailableContainers();

                            // Load currently assigned resources
                            LoadAssignedDrivers();
                            LoadAssignedAssistants();
                            LoadAssignedVehicles();
                            LoadAssignedContainers();
                        }
                        else
                        {
                            MessageBox.Show("Job not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching for job: " + ex.Message);
                }
            }
        }


        private void LoadAssignedDrivers()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT d.driverid, d.name 
                    FROM drivers d
                    JOIN job_drivers jd ON d.driverid = jd.driver_id
                    WHERE jd.job_id = @jobId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@jobId", txtJobId.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new KeyValuePair<string, string>(
                                reader["driverid"].ToString(),
                                $"{reader["driverid"]} - {reader["name"]}"
                            );

                            // Check if this item exists in the list and check it
                            for (int i = 0; i < checkedListBoxDrivers.Items.Count; i++)
                            {
                                var currentItem = (KeyValuePair<string, string>)checkedListBoxDrivers.Items[i];
                                if (currentItem.Key == item.Key)
                                {
                                    checkedListBoxDrivers.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assigned drivers: " + ex.Message);
                }
            }
        }

        private void LoadAssignedAssistants()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT a.assistantid, a.name 
                    FROM assistants a
                    JOIN job_assistants ja ON a.assistantid = ja.assistant_id
                    WHERE ja.job_id = @jobId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@jobId", txtJobId.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new KeyValuePair<string, string>(
                                reader["assistantid"].ToString(),
                                $"{reader["assistantid"]} - {reader["name"]}"
                            );

                            for (int i = 0; i < checkedListBoxAssistants.Items.Count; i++)
                            {
                                var currentItem = (KeyValuePair<string, string>)checkedListBoxAssistants.Items[i];
                                if (currentItem.Key == item.Key)
                                {
                                    checkedListBoxAssistants.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assigned assistants: " + ex.Message);
                }
            }
        }

        private void LoadAssignedVehicles()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT v.vehicleid, v.name 
                    FROM vehicles v
                    JOIN job_vehicles jv ON v.vehicleid = jv.vehicle_id
                    WHERE jv.job_id = @jobId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@jobId", txtJobId.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new KeyValuePair<string, string>(
                                reader["vehicleid"].ToString(),
                                $"{reader["vehicleid"]} - {reader["name"]}"
                            );

                            for (int i = 0; i < checkedListBoxVehicles.Items.Count; i++)
                            {
                                var currentItem = (KeyValuePair<string, string>)checkedListBoxVehicles.Items[i];
                                if (currentItem.Key == item.Key)
                                {
                                    checkedListBoxVehicles.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assigned vehicles: " + ex.Message);
                }
            }
        }

        private void LoadAssignedContainers()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT c.containerid, c.type 
                    FROM containers c
                    JOIN job_containers jc ON c.containerid = jc.container_id
                    WHERE jc.job_id = @jobId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@jobId", txtJobId.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new KeyValuePair<string, string>(
                                reader["containerid"].ToString(),
                                $"{reader["containerid"]} - {reader["type"]}"
                            );

                            for (int i = 0; i < checkedListBoxContainers.Items.Count; i++)
                            {
                                var currentItem = (KeyValuePair<string, string>)checkedListBoxContainers.Items[i];
                                if (currentItem.Key == item.Key)
                                {
                                    checkedListBoxContainers.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assigned containers: " + ex.Message);
                }
            }
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text))
            {
                MessageBox.Show("Please select a job to edit.");
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    string jobId = txtJobId.Text;

                    // First, remove all existing assignments
                    string[] deleteQueries = {
                "DELETE FROM job_drivers WHERE job_id = @jobId",
                "DELETE FROM job_assistants WHERE job_id = @jobId",
                "DELETE FROM job_vehicles WHERE job_id = @jobId",
                "DELETE FROM job_containers WHERE job_id = @jobId"
            };

                    foreach (var query in deleteQueries)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.ExecuteNonQuery();
                    }

                    // Now add the new selections (same as in your btnAssignJob_Click)
                    // Assign multiple drivers
                    foreach (var item in checkedListBoxDrivers.CheckedItems)
                    {
                        var driver = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_drivers (job_id, driver_id) VALUES (@jobId, @driverId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@driverId", driver.Key);
                        cmd.ExecuteNonQuery();
                    }

                    // Assign multiple assistants
                    foreach (var item in checkedListBoxAssistants.CheckedItems)
                    {
                        var assistant = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_assistants (job_id, assistant_id) VALUES (@jobId, @assistantId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@assistantId", assistant.Key);
                        cmd.ExecuteNonQuery();
                    }

                    // Assign multiple vehicles
                    foreach (var item in checkedListBoxVehicles.CheckedItems)
                    {
                        var vehicle = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_vehicles (job_id, vehicle_id) VALUES (@jobId, @vehicleId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@vehicleId", vehicle.Key);
                        cmd.ExecuteNonQuery();
                    }

                    // Assign multiple containers
                    foreach (var item in checkedListBoxContainers.CheckedItems)
                    {
                        var container = (KeyValuePair<string, string>)item;
                        string insertQuery = "INSERT INTO job_containers (job_id, container_id) VALUES (@jobId, @containerId)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        cmd.Parameters.AddWithValue("@containerId", container.Key);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    ToastMessage.Show(this, "Job assignments updated successfully!");

                    // Refresh the data
                    loadDataToTable();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Error updating job assignments: " + ex.Message);
                }
            }
        }

        private void btnJobPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask user where to save the file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.Title = "Save New Jobs Report";
                saveDialog.FileName = "New Jobs.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create the PDF
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Add a title
                    doc.Add(new Paragraph("New Jobs Report"));
                    doc.Add(new Paragraph($"Generated on: {DateTime.Now.ToShortDateString()}"));
                    doc.Add(new Paragraph("\n"));

                    // Create a table with the same columns as the DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);

                    // Add column headers
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        pdfTable.AddCell(column.HeaderText);
                    }

                    // Add data rows
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }

                    // Add the table to the document
                    doc.Add(pdfTable);
                    doc.Close();

                    ToastMessage.Show(this, "PDF saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating PDF: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtJobId.Clear();
            checkedListBoxDrivers.Items.Clear();
            checkedListBoxAssistants.Items.Clear();
            checkedListBoxVehicles.Items.Clear();
            checkedListBoxContainers.Items.Clear();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                UpdateDatabaseFromGridChange(e.RowIndex, e.ColumnIndex);
            }
        }


        private void UpdateDatabaseFromGridChange(int rowIndex, int columnIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string jobId = row.Cells["jobId"].Value.ToString();
            string columnName = dataGridView1.Columns[columnIndex].Name;
            string newValue = row.Cells[columnIndex].Value?.ToString();

            // Map DataGridView column names to database column names if they're different
            Dictionary<string, string> columnMapping = new Dictionary<string, string>
    {
        {"customerid", "customerid"},
        {"contact", "contact"},
        {"destination_address", "destination_address"},
        {"destination_city", "destination_city"},
        {"origin_address", "origin_address"},
        {"origin_city", "origin_city"},
        {"Moving_date", "Moving_date"},
        {"create_date", "create_date"}
    };

            if (columnMapping.TryGetValue(columnName, out string dbColumnName))
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = $"UPDATE jobs SET {dbColumnName} = @value WHERE jobId = @jobId";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@value", newValue);
                        cmd.Parameters.AddWithValue("@jobId", jobId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            ToastMessage.Show(this, "Update successful!", false);
                        }
                        else
                        {
                            ToastMessage.Show(this, "No changes were made to the database.", true);
                            // Revert the change in the grid
                            loadDataToTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        ToastMessage.Show(this, $"Error updating database: {ex.Message}", true);
                        // Revert the change in the grid
                        loadDataToTable();
                    }
                }
            }
        }
    }
}
