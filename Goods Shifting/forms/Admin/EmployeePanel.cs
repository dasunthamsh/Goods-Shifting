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
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
            cmdEmployees.Items.AddRange(new string[] { "Driver", "Assistant" });
            LoadEmployeeData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

              
                cmdEmployees.Text = row.Cells["Role"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDrivingLicense.Text = row.Cells["Driving License"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtIDNumber.Text = row.Cells["ID Number"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();

               
            }
        }


        private void ClearForm()
        {
            cmdEmployees.SelectedIndex = -1;
            txtName.Clear();
            txtEmail.Clear();
            txtDrivingLicense.Clear();
            txtContact.Clear();
            txtIDNumber.Clear();
            txtAddress.Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadEmployeeData()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                // Query to get all drivers with their availability status
                string driversQuery = @"SELECT 
                                d.driverid AS 'Employee ID',
                                d.name AS 'Name',
                                d.phone AS 'Contact',
                                d.email AS 'Email',
                                d.address AS 'Address',
                                d.id_number AS 'ID Number',
                                d.driving_license AS 'Driving License',
                                'Driver' AS 'Role',
                                CASE 
                                    WHEN EXISTS (
                                        SELECT 1 FROM job_drivers jd 
                                        JOIN jobs j ON jd.job_id = j.jobId 
                                        WHERE jd.driver_id = d.driverid 
                                        AND j.status IN ('assigned', 'in-progress')
                                    ) THEN 'Assigned'
                                    ELSE 'Available'
                                END AS 'Availability'
                            FROM drivers d";

                // Query to get all assistants with their availability status
                string assistantsQuery = @"SELECT 
                                    a.assistantid AS 'Employee ID',
                                    a.name AS 'Name',
                                    a.phone AS 'Contact',
                                    a.email AS 'Email',
                                    a.address AS 'Address',
                                    a.id_number AS 'ID Number',
                                    a.driving_license AS 'Driving License',
                                    'Assistant' AS 'Role',
                                    CASE 
                                        WHEN EXISTS (
                                            SELECT 1 FROM job_assistants ja 
                                            JOIN jobs j ON ja.job_id = j.jobId 
                                            WHERE ja.assistant_id = a.assistantid 
                                            AND j.status IN ('assigned', 'in-progress')
                                        ) THEN 'Assigned'
                                        ELSE 'Available'
                                    END AS 'Availability'
                                FROM assistants a";

                // Combine both queries with UNION
                string combinedQuery = driversQuery + " UNION " + assistantsQuery + " ORDER BY 'Role', 'Name'";

                MySqlCommand cmd = new MySqlCommand(combinedQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = dataTable;

                // Format the DataGridView
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Add null checks before formatting
                if (dataGridView1.Columns.Contains("Availability"))
                {
                    dataGridView1.Columns["Availability"].DefaultCellStyle.ForeColor = Color.White;

                    // Apply formatting after data is loaded
                    dataGridView1.DataBindingComplete += (s, e) =>
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            // Skip header row and null rows
                            if (row.IsNewRow || row.Cells["Availability"].Value == null)
                                continue;

                            string availability = row.Cells["Availability"].Value.ToString();
                            if (availability == "Assigned")
                            {
                                row.Cells["Availability"].Style.BackColor = Color.IndianRed;
                            }
                            else
                            {
                                row.Cells["Availability"].Style.BackColor = Color.MediumSeaGreen;
                            }
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmdEmployees.Text) ||
      string.IsNullOrWhiteSpace(txtName.Text) ||
      string.IsNullOrWhiteSpace(txtContact.Text) ||
      string.IsNullOrWhiteSpace(txtIDNumber.Text) ||
      string.IsNullOrWhiteSpace(txtDrivingLicense.Text))
            {
                MessageBox.Show("Please fill all required fields (Role, Name, Contact, ID Number, Driving License)");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string employeeId;
                string role = cmdEmployees.Text;

                if (role == "Driver")
                {
                    
                    string query = @"INSERT INTO drivers 
                            (name, phone, email, address, id_number, driving_license) 
                            VALUES 
                            (@name, @phone, @email, @address, @id_number, @driving_license);
                            SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtContact.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@id_number", txtIDNumber.Text);
                    cmd.Parameters.AddWithValue("@driving_license", txtDrivingLicense.Text);

                    employeeId = cmd.ExecuteScalar().ToString();
                }
                else if (role == "Assistant")
                {
                    
                    string query = @"INSERT INTO assistants 
                            (name, phone, email, address, id_number, driving_license) 
                            VALUES 
                            (@name, @phone, @email, @address, @id_number, @driving_license);
                            SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtContact.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@id_number", txtIDNumber.Text);
                    cmd.Parameters.AddWithValue("@driving_license", txtDrivingLicense.Text);

                    employeeId = cmd.ExecuteScalar().ToString();
                }
                else
                {
                    MessageBox.Show("Please select a valid role (Driver or Assistant)");
                    return;
                }

                MessageBox.Show($"{role} added successfully ");

                // Refresh the employee list
                LoadEmployeeData();

                
                ClearForm();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an employee to edit");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            string employeeId = selectedRow.Cells["Employee ID"].Value.ToString();
            string currentRole = selectedRow.Cells["Role"].Value.ToString();

            // Validate required fields
            if (string.IsNullOrWhiteSpace(cmdEmployees.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtIDNumber.Text) ||
                string.IsNullOrWhiteSpace(txtDrivingLicense.Text))
            {
                MessageBox.Show("Please fill all required fields (Role, Name, Contact, ID Number, Driving License)");
                return;
            }

            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();
                string newRole = cmdEmployees.Text;

                // Check if role has changed
                if (currentRole != newRole)
                {
                    // Role changed - we need to delete from old table and insert into new table
                    DialogResult result = MessageBox.Show(
                        $"Changing role from {currentRole} to {newRole}. This will create a new employee record. Continue?",
                        "Confirm Role Change",
                        MessageBoxButtons.YesNo);

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }

                    // First delete from old table
                    string deleteQuery = currentRole == "Driver"
                        ? "DELETE FROM drivers WHERE driverid = @id"
                        : "DELETE FROM assistants WHERE assistantid = @id";

                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@id", employeeId);
                    deleteCmd.ExecuteNonQuery();

                    // Then insert into new table
                    if (newRole == "Driver")
                    {
                        string insertQuery = @"INSERT INTO drivers 
                        (name, phone, email, address, id_number, driving_license) 
                        VALUES 
                        (@name, @phone, @email, @address, @id_number, @driving_license);
                        SELECT LAST_INSERT_ID();";

                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@name", txtName.Text);
                        insertCmd.Parameters.AddWithValue("@phone", txtContact.Text);
                        insertCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        insertCmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        insertCmd.Parameters.AddWithValue("@id_number", txtIDNumber.Text);
                        insertCmd.Parameters.AddWithValue("@driving_license", txtDrivingLicense.Text);

                        employeeId = insertCmd.ExecuteScalar().ToString();
                    }
                    else if (newRole == "Assistant")
                    {
                        string insertQuery = @"INSERT INTO assistants 
                        (name, phone, email, address, id_number, driving_license) 
                        VALUES 
                        (@name, @phone, @email, @address, @id_number, @driving_license);
                        SELECT LAST_INSERT_ID();";

                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@name", txtName.Text);
                        insertCmd.Parameters.AddWithValue("@phone", txtContact.Text);
                        insertCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        insertCmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        insertCmd.Parameters.AddWithValue("@id_number", txtIDNumber.Text);
                        insertCmd.Parameters.AddWithValue("@driving_license", txtDrivingLicense.Text);

                        employeeId = insertCmd.ExecuteScalar().ToString();
                    }
                }
                else
                {
                    // Role remains the same - just update the record
                    if (currentRole == "Driver")
                    {
                        string updateQuery = @"UPDATE drivers SET 
                            name = @name, 
                            phone = @phone, 
                            email = @email, 
                            address = @address, 
                            id_number = @id_number, 
                            driving_license = @driving_license
                        WHERE driverid = @id";

                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@phone", txtContact.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@id_number", txtIDNumber.Text);
                        cmd.Parameters.AddWithValue("@driving_license", txtDrivingLicense.Text);

                        cmd.ExecuteNonQuery();
                    }
                    else if (currentRole == "Assistant")
                    {
                        string updateQuery = @"UPDATE assistants SET 
                            name = @name, 
                            phone = @phone, 
                            email = @email, 
                            address = @address, 
                            id_number = @id_number, 
                            driving_license = @driving_license
                        WHERE assistantid = @id";

                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@phone", txtContact.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@id_number", txtIDNumber.Text);
                        cmd.Parameters.AddWithValue("@driving_license", txtDrivingLicense.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee updated successfully");
                LoadEmployeeData();
                ClearForm();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an employee to delete");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            string employeeId = selectedRow.Cells["Employee ID"].Value.ToString();
            string role = selectedRow.Cells["Role"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            string availability = selectedRow.Cells["Availability"].Value?.ToString();

            // Check if employee is currently assigned to a job
            if (availability == "Assigned")
            {
                MessageBox.Show($"Cannot delete {name} because they are currently assigned to a job. Please complete or reassign the job first.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {name} ({role})? This action cannot be undone.",
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

                // Delete from the appropriate table based on role
                if (role == "Driver")
                {
                    string query = "DELETE FROM drivers WHERE driverid = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.ExecuteNonQuery();
                }
                else if (role == "Assistant")
                {
                    string query = "DELETE FROM assistants WHERE assistantid = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"{role} deleted successfully");

                // Refresh the employee list
                LoadEmployeeData();

                // Clear the form
                ClearForm();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451) // Foreign key constraint violation
                {
                    MessageBox.Show($"Cannot delete {name} because they are referenced in job records. Please delete or update related jobs first.");
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
    }
}
