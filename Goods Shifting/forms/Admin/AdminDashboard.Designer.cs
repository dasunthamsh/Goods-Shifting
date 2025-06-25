namespace Goods_Shifting.forms.Admin
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnVehicles = new Button();
            btnEmployees = new Button();
            btnJobs = new Button();
            label5 = new Label();
            btnDashboard = new Button();
            panelFormLoader = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnVehicles);
            panel1.Controls.Add(btnEmployees);
            panel1.Controls.Add(btnJobs);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 928);
            panel1.TabIndex = 0;
            // 
            // btnVehicles
            // 
            btnVehicles.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehicles.Location = new Point(0, 385);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(292, 78);
            btnVehicles.TabIndex = 13;
            btnVehicles.Text = "Vehicles";
            btnVehicles.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployees.Location = new Point(0, 301);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(292, 78);
            btnEmployees.TabIndex = 12;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnJobs
            // 
            btnJobs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJobs.Location = new Point(0, 217);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(292, 78);
            btnJobs.TabIndex = 11;
            btnJobs.Text = "Jobs";
            btnJobs.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(60, 40);
            label5.Name = "label5";
            label5.Size = new Size(149, 54);
            label5.TabIndex = 10;
            label5.Text = "E-Shift";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(0, 133);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(292, 78);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelFormLoader
            // 
            panelFormLoader.Location = new Point(299, 12);
            panelFormLoader.Name = "panelFormLoader";
            panelFormLoader.Size = new Size(1067, 902);
            panelFormLoader.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 926);
            Controls.Add(panelFormLoader);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDashboard;
        private Label label5;
        private Button btnEmployees;
        private Button btnJobs;
        private Button btnVehicles;
        private Panel panelFormLoader;
    }
}