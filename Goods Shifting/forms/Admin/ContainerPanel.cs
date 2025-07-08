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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Goods_Shifting.lib;

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
    CASE 
        WHEN EXISTS (
            SELECT 1 FROM job_containers jc 
            JOIN jobs j ON jc.job_id = j.jobId 
            WHERE jc.container_id = c.containerid 
            AND j.status IN ('assigned', 'in-progress')
        ) THEN 'Assigned'
        WHEN c.status = 'in' THEN 'Available'
        WHEN c.status = 'Maintenance' THEN 'In Maintenance'
        ELSE c.status
    END AS 'Availability',
    CASE 
        WHEN EXISTS (
            SELECT 1 FROM job_containers jc 
            JOIN jobs j ON jc.job_id = j.jobId 
            WHERE jc.container_id = c.containerid 
            AND j.status IN ('assigned', 'in-progress')
        ) THEN (
            SELECT jv.vehicle_id 
            FROM job_vehicles jv 
            JOIN jobs j ON jv.job_id = j.jobId
            JOIN job_containers jc ON jc.job_id = j.jobId
            WHERE jc.container_id = c.containerid
            AND j.status IN ('assigned', 'in-progress')
            LIMIT 1
        )
        ELSE NULL
    END AS 'Vehicle ID'
FROM containers c";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // bind the data to the DataGridView
                dataGridView1.DataSource = dataTable;

                // format the DataGridView
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["Availability"].DefaultCellStyle.ForeColor = Color.White;

                // apply color coding after data is loaded
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
                ToastMessage.Show(this, "Error loading vehicle data: " + ex.Message, true);
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
                    ToastMessage.Show(this, "Container status updated successfully!");
                    LoadContainerData();
                }
                else
                {
                    MessageBox.Show("Container to update vehicle status");
                }
            }
            catch (Exception ex)
            {
                ToastMessage.Show(this, "Error updating Container status: " + ex.Message,true);
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
                    ToastMessage.Show(this, "Container added successfully!");
                    LoadContainerData();
                    ClearForm();
                }
                else
                {
                    ToastMessage.Show(this, "Failed to add container",true);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error
                {
                    ToastMessage.Show(this, "A container with this number already exists", true);
                }
                else
                {
                    ToastMessage.Show(this, "Database error: " + ex.Message, true);
                }
            }
            catch (Exception ex)
            {
                ToastMessage.Show(this, "Error: " + ex.Message, true);
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
                ToastMessage.Show(this, "Please select a container to edit",true);
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(cmbContainerType.Text) ||
                string.IsNullOrWhiteSpace(cmbSize.Text) ||
                string.IsNullOrWhiteSpace(txtContainerNumber.Text))
            {
                ToastMessage.Show(this, "Please fill all required fields (Type, Size, Container Number)",true);
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
                    ToastMessage.Show(this, "Container updated successfully!");
                    LoadContainerData();
                    ClearForm();
                }
                else
                {
                    ToastMessage.Show(this, "No changes were made or container not found",true);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error
                {
                    ToastMessage.Show(this, "A container with this number already exists",true);
                }
                else
                {
                    ToastMessage.Show(this, "Database error: " + ex.Message, true);
                }
            }
            catch (Exception ex)
            {
                ToastMessage.Show(this, "Error: " + ex.Message,true);
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
                    ToastMessage.Show(this, "Container deleted successfully!");
                    LoadContainerData();
                    ClearForm();
                }
                else
                {
                    ToastMessage.Show(this, "Container not found or could not be deleted",true);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451) // Foreign key constraint violation
                {
                    ToastMessage.Show(this, "Cannot delete container because it is referenced in job records.",true);
                }
                else
                {
                    ToastMessage.Show(this, "Database error: " + ex.Message,true);
                }
            }
            catch (Exception ex)
            {
                ToastMessage.Show(this, "Error: " + ex.Message,true);
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

        private void btnContainerPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask user where to save the file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.Title = "SaveContainer Report";
                saveDialog.FileName = "Container.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create the PDF
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Add a title
                    doc.Add(new Paragraph("Container Report"));
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
                ToastMessage.Show(this, "Error creating PDF: " + ex.Message,true);
            }
        }
    }
}
