using Goods_Shifting.lib;
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

namespace Goods_Shifting.forms.Admin
{
    public partial class CustomerPanel : Form
    {
        public CustomerPanel()
        {
            InitializeComponent();
            LoadCustomerData();
            ConfigureDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask user where to save the file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.Title = "Save Customer Report";
                saveDialog.FileName = "Customer.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create the PDF
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Add a title
                    doc.Add(new Paragraph("Customer Report"));
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

        private void LoadCustomerData()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    string query = "SELECT customerid, name, email FROM customers";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Optional: Format column headers
                    dataGridView1.Columns["customerid"].HeaderText = "Customer ID";
                    dataGridView1.Columns["name"].HeaderText = "Name";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            // Set up DataGridView properties
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Add columns with proper configuration
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "customerid",
                HeaderText = "Customer ID",
                DataPropertyName = "customerid",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "name",
                HeaderText = "Full Name",
                DataPropertyName = "name",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "email",
                HeaderText = "Email Address",
                DataPropertyName = "email",
                Width = 180
            });

           

        }
        }
}
