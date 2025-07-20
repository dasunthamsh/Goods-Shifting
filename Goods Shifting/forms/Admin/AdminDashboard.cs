using Goods_Shifting.forms.Auth;
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
        private string managerName;

        private System.Windows.Forms.Timer timerDateTime;

        public AdminDashboard(string managerId, string managerName)
        {
            InitializeComponent();

            this.managerId = managerId;
            this.managerName = managerName;


            timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000; // 1 second
            timerDateTime.Tick += timer1_Tick;
            timerDateTime.Start();


            this.panelFormLoader.Controls.Clear();
            DashboardPanel panel = new DashboardPanel(managerName) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(panel);
            panel.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            DashboardPanel panel = new DashboardPanel(managerName) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            EmployeePanel employeePanel = new EmployeePanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            employeePanel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(employeePanel);
            employeePanel.Show();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            VehiclePanel vehiclePanel = new VehiclePanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vehiclePanel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(vehiclePanel);
            vehiclePanel.Show();
        }

        private void btnContainer_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            ContainerPanel containerPanel = new ContainerPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            containerPanel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(containerPanel);
            containerPanel.Show();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            ManagerPanel managerPanel = new ManagerPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            managerPanel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(managerPanel);
            managerPanel.Show();
        }

        private void btnOngoingJobs_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            OngingJobsPanel ongingJobsPanel = new OngingJobsPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ongingJobsPanel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(ongingJobsPanel);
            ongingJobsPanel.Show();
        }

        private void JobHistory_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            JobHistory jobHistoryPanel = new JobHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            jobHistoryPanel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(jobHistoryPanel);
            jobHistoryPanel.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home form = new Home();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            CustomerPanel customerPanel = new CustomerPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            customerPanel.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(customerPanel);
            customerPanel.Show();
        }
    }
}
