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

namespace Goods_Shifting.forms.Customer
{
    public partial class Notifications: Form
    {

        private string customerId;
        public Notifications(string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT jobid, status, Moving_date 
                                    FROM jobs 
                                    WHERE customerid = @customerId 
                                    AND status IN ('assigned', 'cancelled')
                                    ORDER BY Moving_date DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);

                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        if (dt.Rows.Count > 0)
                        {
                            listBoxNotifications.DrawMode = DrawMode.OwnerDrawVariable;
                            listBoxNotifications.DrawItem += ListBoxNotifications_DrawItem;

                            foreach (DataRow row in dt.Rows)
                            {
                                string jobId = row["jobid"].ToString();
                                string status = row["status"].ToString();
                                DateTime movingDate = Convert.ToDateTime(row["Moving_date"]);

                                string statusMessage = status == "assigned"
                                    ? "Job request accepted"
                                    : "Job request cancelled";

                                string notificationText = $"[{movingDate:dd-MMM-yyyy}] Job #{jobId}: {statusMessage}";

                                // Store the status with each item using the Tag property
                                var item = new ListBoxItem(notificationText, status);
                                listBoxNotifications.Items.Add(item);
                            }
                        }
                        else
                        {
                            listBoxNotifications.Items.Add("No notifications found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxNotifications.Items.Add("Error loading notifications");
            }
        }

        private void ListBoxNotifications_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            if (listBoxNotifications.Items[e.Index] is ListBoxItem item)
            {
                Color textColor = item.Status == "assigned" ? Color.Green : Color.Red;
                using (Brush brush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(item.Text, e.Font, brush, e.Bounds);
                }
            }
            else
            {
                using (Brush brush = new SolidBrush(listBoxNotifications.ForeColor))
                {
                    e.Graphics.DrawString(listBoxNotifications.Items[e.Index].ToString(),
                                        e.Font, brush, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Helper class to store both text and status
    public class ListBoxItem
    {
        public string Text { get; set; }
        public string Status { get; set; }

        public ListBoxItem(string text, string status)
        {
            Text = text;
            Status = status;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
