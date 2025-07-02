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
            LoadEmployeeData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
            }
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
                            'Driver' AS 'Role',
                            CASE 
                                WHEN j.jobId IS NOT NULL AND j.status != 'completed' THEN 'Assigned'
                                ELSE 'Available'
                            END AS 'Availability'
                        FROM drivers d
                        LEFT JOIN jobs j ON d.driverid = j.driverid 
                            AND (j.status = 'assigned' OR j.status = 'in-progress')";

                // Query to get all assistants with their availability status
                string assistantsQuery = @"SELECT 
                                a.assistantid AS 'Employee ID',
                                a.name AS 'Name',
                                a.phone AS 'Contact',
                                'Assistant' AS 'Role',
                                CASE 
                                    WHEN j.jobId IS NOT NULL AND j.status != 'completed' THEN 'Assigned'
                                    ELSE 'Available'
                                END AS 'Availability'
                            FROM assistants a
                            LEFT JOIN jobs j ON a.assistantid = j.assistantid 
                                AND (j.status = 'assigned' OR j.status = 'in-progress')";

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
    }
}
