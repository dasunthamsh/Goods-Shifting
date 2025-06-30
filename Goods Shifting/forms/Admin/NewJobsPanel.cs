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
        public NewJobsPanel()
        {
            InitializeComponent();
            loadDataToTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row, not on the header
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming txtJobId is the name of your TextBox control
                txtJobId.Text = row.Cells["jobId"].Value.ToString();
            }
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {

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

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
