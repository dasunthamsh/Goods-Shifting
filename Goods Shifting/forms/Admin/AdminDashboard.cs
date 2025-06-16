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
        public AdminDashboard()
        {
            InitializeComponent();

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
    }
}
