using Goods_Shifting.lib;
using Goods_Shifting.lib.Validations;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Goods_Shifting.forms.Customer
{

    public partial class previousJobs : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        string customerId = "123";
        string userName = "dasun";


        public previousJobs()
        {
            InitializeComponent();
            LoadJobsData();
            AddTruckTypes();
        }

        private void AddTruckTypes()
        {
            cmbSize.Items.Clear();


            cmbSize.Items.Add("Few Items");
            cmbSize.Items.Add("1 BHK");
            cmbSize.Items.Add("2 BHK");
            cmbSize.Items.Add("3 BHK");
            cmbSize.Items.Add("4 BHK");
            cmbSize.Items.Add("5 BHK");


            // set a default selected item
            cmbSize.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string jobIdcustomerId = txtJobId.Text = row.Cells["Job ID"].Value.ToString();
                cmbSize.Text = row.Cells["Truck Size"].Value.ToString();
                txtNumber.Text = row.Cells["Contact"].Value.ToString();
                txtOriginCity.Text = row.Cells["Origin City"].Value.ToString();
                txtDestinationCity.Text = row.Cells["Destination City"].Value.ToString();
                txtDestinationAddress.Text = row.Cells["Destination Address"].Value.ToString();
                txtOriginAddress.Text = row.Cells["Origin Address"].Value.ToString();
                txtMessage.Text = row.Cells["Description"].Value.ToString();
                dateTimePicker1.Text = row.Cells["Moving Date"].Value.ToString();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text))
            {
                ToastMessage.Show(this, "Please select a job to edit.");
                return;
            }

            if (ValidateForm())
            {
                UpdateJobInDatabase();
            }
        }




        private void UpdateJobInDatabase()
        {


            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();
                string query = @"UPDATE jobs SET
                                size = @truckSize,
                                Moving_date = @pickupDate,
                                contact = @contactNumber,
                                destination_city = @destinationCity,
                                destination_address = @destinationAddress,
                                origin_city = @originCity,
                                origin_address = @originAddress,
                                description = @specialInstructions
                                WHERE jobid = @jobId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jobId", txtJobId.Text);
                    cmd.Parameters.AddWithValue("@truckSize", cmbSize.Text);
                    cmd.Parameters.AddWithValue("@pickupDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@contactNumber", txtNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@destinationCity", txtDestinationCity.Text.Trim());
                    cmd.Parameters.AddWithValue("@destinationAddress", txtDestinationAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@originCity", txtOriginCity.Text.Trim());
                    cmd.Parameters.AddWithValue("@originAddress", txtOriginAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@specialInstructions", txtMessage.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ToastMessage.Show(this, "Job updated successfully!");
                        LoadJobsData();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made to the job.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating job: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadJobsData()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();
                string query = @"SELECT 
                                    jobid AS 'Job ID',
                                    customer_name AS 'Customer Name',
                                    size AS 'Truck Size',
                                    Moving_date AS 'Moving Date',
                                    contact AS 'Contact',
                                    origin_city AS 'Origin City',
                                    destination_city AS 'Destination City',
                                    destination_address AS 'Destination Address',
                                    origin_address AS 'Origin Address',
                                    description AS 'Description'
                                    FROM jobs
                                    WHERE status = 'pending'
                                    ORDER BY Moving_date DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;


                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridView1.Columns["Moving Date"] != null)
                {
                    dataGridView1.Columns["Moving Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading jobs: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateJob form = new CreateJob(customerId, userName);
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private bool ValidateForm()
        {
            return CreateJobValidation.ValidateCreateJobForm(
                txtNumber,
                txtDestinationCity,
                txtDestinationAddress,
                txtOriginCity,
                txtOriginAddress,
                cmbSize,
                this,
                errorProvider);
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text))
            {
                ToastMessage.Show(this, "Please select a job to delete.");
                return;
            }

            // Confirm deletion with user
            var confirmResult = MessageBox.Show("Are you sure you want to delete this job?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                DeleteJobFromDatabase();
            }
        }

        private void DeleteJobFromDatabase()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();
                string query = "DELETE FROM jobs WHERE jobid = @jobId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jobId", txtJobId.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ToastMessage.Show(this, "Job deleted successfully!");
                        ClearForm();
                        LoadJobsData(); // Refresh the data grid
                    }
                    else
                    {
                        MessageBox.Show("Job not found or already deleted.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting job: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ClearForm()
        {
            txtJobId.Text = "";
            cmbSize.SelectedIndex = 0;
            txtNumber.Text = "";
            txtOriginCity.Text = "";
            txtDestinationCity.Text = "";
            txtDestinationAddress.Text = "";
            txtOriginAddress.Text = "";
            txtMessage.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
