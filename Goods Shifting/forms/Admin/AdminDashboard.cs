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
    public partial class AdminDashboard : Form
    {

        private string managerId;

        private System.Windows.Forms.Timer timerDateTime;

        public AdminDashboard(string managerId, string managerName)
        {
            InitializeComponent();

            this.managerId = managerId;


            timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000; // 1 second
            timerDateTime.Tick += timer1_Tick;
            timerDateTime.Start();


            this.panelFormLoader.Controls.Clear();
            DashboardPanel panel = new DashboardPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(panel);
            panel.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            DashboardPanel panel = new DashboardPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(panel);
            panel.Show();

        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            
            this.panelFormLoader.Controls.Clear();
            NewJobsPanel newJobs = new NewJobsPanel(managerId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            newJobs.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(newJobs);
            newJobs.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
}
