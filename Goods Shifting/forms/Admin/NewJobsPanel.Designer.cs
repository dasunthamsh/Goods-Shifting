namespace Goods_Shifting.forms.Admin
{
    partial class NewJobsPanel
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
            dataGridView1 = new DataGridView();
            lblDashboard = new Label();
            label2 = new Label();
            txtJobId = new TextBox();
            cmbVehicle = new ComboBox();
            label3 = new Label();
            cmbDriver = new ComboBox();
            label1 = new Label();
            cmbAssistant = new ComboBox();
            label4 = new Label();
            btnAssignJob = new Button();
            btnRemoveJob = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1021, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(22, 24);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(66, 32);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Jobs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(125, 502);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 11;
            label2.Text = "JobID";
            // 
            // txtJobId
            // 
            txtJobId.Font = new Font("Segoe UI", 11F);
            txtJobId.Location = new Point(125, 535);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(365, 37);
            txtJobId.TabIndex = 10;
            // 
            // cmbVehicle
            // 
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(562, 535);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(365, 33);
            cmbVehicle.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(562, 500);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 30;
            label3.Text = "Vehicle";
            // 
            // cmbDriver
            // 
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(125, 639);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(365, 33);
            cmbDriver.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(125, 604);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 32;
            label1.Text = "Driver";
            // 
            // cmbAssistant
            // 
            cmbAssistant.FormattingEnabled = true;
            cmbAssistant.Location = new Point(562, 639);
            cmbAssistant.Name = "cmbAssistant";
            cmbAssistant.Size = new Size(365, 33);
            cmbAssistant.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(562, 604);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 34;
            label4.Text = "Assistant";
            // 
            // btnAssignJob
            // 
            btnAssignJob.BackColor = SystemColors.MenuHighlight;
            btnAssignJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAssignJob.ForeColor = SystemColors.Control;
            btnAssignJob.Location = new Point(806, 769);
            btnAssignJob.Name = "btnAssignJob";
            btnAssignJob.Size = new Size(218, 56);
            btnAssignJob.TabIndex = 36;
            btnAssignJob.Text = "Assign Job";
            btnAssignJob.UseVisualStyleBackColor = false;
            btnAssignJob.Click += btnAssignJob_Click;
            // 
            // btnRemoveJob
            // 
            btnRemoveJob.BackColor = SystemColors.MenuHighlight;
            btnRemoveJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveJob.ForeColor = SystemColors.Control;
            btnRemoveJob.Location = new Point(573, 769);
            btnRemoveJob.Name = "btnRemoveJob";
            btnRemoveJob.Size = new Size(218, 56);
            btnRemoveJob.TabIndex = 37;
            btnRemoveJob.Text = "Remove Job";
            btnRemoveJob.UseVisualStyleBackColor = false;
            // 
            // NewJobsPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 846);
            Controls.Add(btnRemoveJob);
            Controls.Add(btnAssignJob);
            Controls.Add(cmbAssistant);
            Controls.Add(label4);
            Controls.Add(cmbDriver);
            Controls.Add(label1);
            Controls.Add(cmbVehicle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtJobId);
            Controls.Add(lblDashboard);
            Controls.Add(dataGridView1);
            Name = "NewJobsPanel";
            Text = "NewJobsPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblDashboard;
        private Label label2;
        private TextBox txtJobId;
        private ComboBox cmbVehicle;
        private Label label3;
        private ComboBox cmbDriver;
        private Label label1;
        private ComboBox cmbAssistant;
        private Label label4;
        private Button btnAssignJob;
        private Button btnRemoveJob;
    }
}