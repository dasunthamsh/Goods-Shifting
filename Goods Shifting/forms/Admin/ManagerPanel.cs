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
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
            loadDataToTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtContact.Text = row.Cells["phone"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtID.Text = row.Cells["id_number"].Value.ToString();
                lblID.Text = row.Cells["managerid"].Value.ToString();
            }
        }

        private void loadDataToTable()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            string query = "SELECT managerid, name, email, phone, address, id_number FROM managers ";

            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            conn.Open();
            adapter.Fill(dataTable);


            dataGridView1.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


    }
}
