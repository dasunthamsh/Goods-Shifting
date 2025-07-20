using Goods_Shifting.lib;
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
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string hashedPassword = Hasher.HashPassword(txtPassword.Text);

                    string insertQuery = @"INSERT INTO managers 
                                (name, email, phone, address, id_number, password) 
                                VALUES 
                                (@name, @email, @phone, @address, @id_number, @password)";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@name", txtName.Text);
                    insertCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    insertCmd.Parameters.AddWithValue("@phone", txtContact.Text);
                    insertCmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    insertCmd.Parameters.AddWithValue("@id_number", txtID.Text);
                    insertCmd.Parameters.AddWithValue("@password", hashedPassword);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ToastMessage.Show(this, "Manager added successfully!");


                        ClearFields();
                        loadDataToTable();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add manager", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtID.Clear();
            txtPassword.Clear();
            lblID.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblID.Text))
            {
                MessageBox.Show("Please select a manager to edit", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please fill all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string updateQuery = @"UPDATE managers SET 
                                        name = @name, 
                                        email = @email, 
                                        phone = @phone, 
                                        address = @address, 
                                        id_number = @id_number
                                        WHERE managerid = @managerid";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@name", txtName.Text);
                    updateCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    updateCmd.Parameters.AddWithValue("@phone", txtContact.Text);
                    updateCmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    updateCmd.Parameters.AddWithValue("@id_number", txtID.Text);
                    updateCmd.Parameters.AddWithValue("@managerid", lblID.Text);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ToastMessage.Show(this, "Manager updated successfully!");

                        ClearFields();
                        loadDataToTable();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update manager", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating manager: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblID.Text))
            {
                MessageBox.Show("Please select a manager to delete", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this manager?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DBConnection.GetConnection())
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM managers WHERE managerid = @managerid";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@managerid", lblID.Text);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            ToastMessage.Show(this, "Manager deleted successfully!");

                            ClearFields();
                            loadDataToTable();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete manager", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting manager: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
