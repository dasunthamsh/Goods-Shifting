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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblTime = new Label();
            lblDate = new Label();
            btnVehicles = new Button();
            btnEmployees = new Button();
            btnJobs = new Button();
            label5 = new Label();
            btnDashboard = new Button();
            panelFormLoader = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblDate);
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
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTime.Location = new Point(11, 42);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(62, 25);
            lblTime.TabIndex = 15;
            lblTime.Text = "label2";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDate.Location = new Point(11, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 25);
            lblDate.TabIndex = 14;
            lblDate.Text = "label1";
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
            btnJobs.Click += btnJobs_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(70, 72);
            label5.Name = "label5";
            label5.Size = new Size(135, 48);
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
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
        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}