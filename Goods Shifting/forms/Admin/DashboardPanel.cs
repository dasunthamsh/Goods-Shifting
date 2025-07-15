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
    public partial class DashboardPanel: Form
    {

        private string managerName;
        public DashboardPanel(string managerName)
        {
            InitializeComponent();
            LoadDashboardStatistics();
            lblName.Text = managerName;
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Load total revenue
                    string totalRevenueQuery = "SELECT SUM(amount) FROM payments";
                    lblTotalaRevenue.Text = ExecuteScalarQuery(conn, totalRevenueQuery).ToString();

                    // Load daily revenue (today's payments)
                    string dailyRevenueQuery = "SELECT SUM(amount) FROM payments WHERE DATE(date) = CURDATE()";
                    object dailyRevenue = ExecuteScalarQuery(conn, dailyRevenueQuery);
                    lblDailyRevenue.Text = dailyRevenue != DBNull.Value ? Convert.ToDecimal(dailyRevenue).ToString("C") : "0.00";

                    // Load customer count
                    string customerCountQuery = "SELECT COUNT(*) FROM customers";
                    lblCustomers.Text = ExecuteScalarQuery(conn, customerCountQuery).ToString();

                    // Load completed jobs count
                    string completedJobsQuery = "SELECT COUNT(*) FROM jobs WHERE status = 'completed'";
                    lblCompleteJobs.Text = ExecuteScalarQuery(conn, completedJobsQuery).ToString();

                    // Load ongoing jobs count
                    string ongoingJobsQuery = "SELECT COUNT(*) FROM jobs WHERE status = 'assigned'";
                    lblOngoingJobs.Text = ExecuteScalarQuery(conn, ongoingJobsQuery).ToString();

                    // Load drivers count
                    string driversCountQuery = "SELECT COUNT(*) FROM drivers";
                    lblDrivers.Text = ExecuteScalarQuery(conn, driversCountQuery).ToString();

                    // Load assistants count
                    string assistantsCountQuery = "SELECT COUNT(*) FROM assistants";
                    lblAssisants.Text = ExecuteScalarQuery(conn, assistantsCountQuery).ToString();

                    // Load vehicles count
                    string vehiclesCountQuery = "SELECT COUNT(*) FROM vehicles";
                    lblVehicles.Text = ExecuteScalarQuery(conn, vehiclesCountQuery).ToString();

                    // Load containers count
                    string containersCountQuery = "SELECT COUNT(*) FROM containers";
                    lblContainers.Text = ExecuteScalarQuery(conn, containersCountQuery).ToString();
                }
            }
            catch (Exception ex)
            {
                ToastMessage.Show(this, "Error loading dashboard statistics: " + ex.Message, true);
            }
        }

        private object ExecuteScalarQuery(MySqlConnection conn, string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return cmd.ExecuteScalar();
            }
        }

    
    }
}
