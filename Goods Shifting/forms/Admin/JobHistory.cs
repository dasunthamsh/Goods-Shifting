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
    public partial class JobHistory : Form
    {
        public JobHistory()
        {
            InitializeComponent();
            cmbStatus.Items.AddRange(new string[] { "assigned", "cancelled", "completed" });

            cmbStatus.SelectedIndex = 0; // Select "All" by default
            dateTimePicker1.Value = DateTime.Today.AddMonths(-1); // Default to last month
            dateTimePicker2.Value = DateTime.Today; // Default to today

            LoadJobHistory(); // Load data when form opens
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadJobHistory()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    string query = @"SELECT j.jobId, j.customerid, j.contact, 
                                   j.destination_address, j.destination_city,
                                   j.origin_address, j.origin_city, 
                                   j.Moving_date, j.create_date, j.status,
                                   m.name as manager_name
                            FROM jobs j
                            LEFT JOIN managers m ON j.managerid = m.managerid
                            WHERE DATE(j.Moving_date) BETWEEN @startDate AND @endDate";

                    // Add status filter if not "All"
                    if (cmbStatus.SelectedItem?.ToString() != "All")
                    {
                        query += " AND j.status = @status";
                    }

                    query += " ORDER BY j.Moving_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Always add date parameters
                    cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", dateTimePicker2.Value.Date);

                    if (cmbStatus.SelectedItem?.ToString() != "All")
                    {
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormatDataGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                // Set column headers
                dataGridView1.Columns["jobId"].HeaderText = "Job ID";
                dataGridView1.Columns["customerid"].HeaderText = "Customer ID";
                dataGridView1.Columns["contact"].HeaderText = "Contact";
                dataGridView1.Columns["destination_address"].HeaderText = "Destination Address";
                dataGridView1.Columns["destination_city"].HeaderText = "Destination City";
                dataGridView1.Columns["origin_address"].HeaderText = "Origin Address";
                dataGridView1.Columns["origin_city"].HeaderText = "Origin City";
                dataGridView1.Columns["Moving_date"].HeaderText = "Moving Date";
                dataGridView1.Columns["create_date"].HeaderText = "Created Date";
                dataGridView1.Columns["status"].HeaderText = "Status";
                dataGridView1.Columns["manager_name"].HeaderText = "Manager";

                // Set column widths
                dataGridView1.Columns["jobId"].Width = 80;
                dataGridView1.Columns["customerid"].Width = 80;
                dataGridView1.Columns["contact"].Width = 100;
                dataGridView1.Columns["destination_address"].Width = 150;
                dataGridView1.Columns["origin_address"].Width = 150;
                dataGridView1.Columns["Moving_date"].Width = 100;
                dataGridView1.Columns["create_date"].Width = 100;
                dataGridView1.Columns["status"].Width = 80;
                dataGridView1.Columns["manager_name"].Width = 120;

                // Format date columns
                dataGridView1.Columns["Moving_date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dataGridView1.Columns["create_date"].DefaultCellStyle.Format = "yyyy-MM-dd";

                // Make the grid read-only
                dataGridView1.ReadOnly = true;
            }
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadJobHistory();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadJobHistory();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJobHistory();
        }
    }
}
