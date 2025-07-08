using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class OngingJobsPanel : Form
    {
        public OngingJobsPanel()
        {
            InitializeComponent();
            LoadJobData();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtJobId.Text = row.Cells["jobId"].Value.ToString();


            }
        }


        private void LoadJobData()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        j.jobId,
                        j.customerid,
                        j.managerid,
                        j.contact,
                        j.customer_name,
                        j.destination_city,
                        j.origin_city,
                        j.Moving_date,
                        GROUP_CONCAT(DISTINCT d.driverid) AS driver_ids,
                        GROUP_CONCAT(DISTINCT a.assistantid) AS assistant_ids,
                        GROUP_CONCAT(DISTINCT v.vehicleid) AS vehicle_ids,
                        GROUP_CONCAT(DISTINCT c.containerid) AS container_ids
                    FROM jobs j
                    LEFT JOIN job_drivers jd ON j.jobId = jd.job_id
                    LEFT JOIN drivers d ON jd.driver_id = d.driverid
                    LEFT JOIN job_assistants ja ON j.jobId = ja.job_id
                    LEFT JOIN assistants a ON ja.assistant_id = a.assistantid
                    LEFT JOIN job_vehicles jv ON j.jobId = jv.job_id
                    LEFT JOIN vehicles v ON jv.vehicle_id = v.vehicleid
                    LEFT JOIN job_containers jc ON j.jobId = jc.job_id
                    LEFT JOIN containers c ON jc.container_id = c.containerid
                    WHERE j.status IN ('assigned', 'in-progress')
                    GROUP BY j.jobId
                    ORDER BY j.Moving_date";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading job data: " + ex.Message);
                }
            }
        }

        private void btnCompleteJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text) || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please select a job and enter the payment amount");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid payment amount");
                return;
            }

            string jobId = txtJobId.Text;
            DialogResult result = MessageBox.Show($"Mark job {jobId} as completed and record payment of {amount}?",
                "Confirm Completion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CompleteJobWithPayment(jobId, amount);
            }
        }

        private void CompleteJobWithPayment(string jobId, decimal amount)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // 1. Update job status to completed
                    string updateJobQuery = "UPDATE jobs SET status = 'completed' WHERE jobId = @jobId";
                    MySqlCommand updateCmd = new MySqlCommand(updateJobQuery, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@jobId", jobId);
                    updateCmd.ExecuteNonQuery();

                    // 2. Insert payment record
                    string insertPaymentQuery = @"
                        INSERT INTO payments (jobId, amount) 
                        VALUES (@jobId, @amount)";

                    MySqlCommand paymentCmd = new MySqlCommand(insertPaymentQuery, conn, transaction);
                    paymentCmd.Parameters.AddWithValue("@jobId", jobId);
                    paymentCmd.Parameters.AddWithValue("@amount", amount);
                    paymentCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show($"Job {jobId} completed and payment recorded successfully");
                    LoadJobData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show($"Error completing job: {ex.Message}");
                }
            }
        }

        private void btnCancleJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobId.Text))
            {
                MessageBox.Show("Please select a job to cancel");
                return;
            }

            string jobId = txtJobId.Text;
            DialogResult result = MessageBox.Show($"Cancel job {jobId}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CancelJob(jobId);
            }
        }


        private void CancelJob(string jobId)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE jobs SET status = 'cancelled' WHERE jobId = @jobId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@jobId", jobId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Job {jobId} has been cancelled");
                        LoadJobData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("No job was cancelled. Please check the job ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error cancelling job: {ex.Message}");
                }
            }
        }

        private void ClearForm()
        {
            txtJobId.Clear();
            txtAmount.Clear();
        }

        private void btnOngoingJobPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask user where to save the file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.Title = "Save Ongoing Jobs Report";
                saveDialog.FileName = "OngoingJobs.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create the PDF
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Add a title
                    doc.Add(new Paragraph("Ongoing Jobs Report"));
                    doc.Add(new Paragraph($"Generated on: {DateTime.Now.ToShortDateString()}"));
                    doc.Add(new Paragraph("\n")); // Add some space

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

                    MessageBox.Show("PDF saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating PDF: " + ex.Message);
            }
        }



    }
}
