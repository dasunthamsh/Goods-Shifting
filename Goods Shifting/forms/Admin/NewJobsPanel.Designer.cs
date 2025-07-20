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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewJobsPanel));
            lblDashboard = new Label();
            dataGridView1 = new DataGridView();
            lbl1 = new Label();
            txtJobId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkedListBoxDrivers = new CheckedListBox();
            checkedListBoxAssistants = new CheckedListBox();
            checkedListBoxContainers = new CheckedListBox();
            checkedListBoxVehicles = new CheckedListBox();
            btnRemoveJob = new Button();
            btnAssignJob = new Button();
            btnEditJob = new Button();
            btnSearch = new Button();
            btnJobPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(22, 24);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(66, 32);
            lblDashboard.TabIndex = 22;
            lblDashboard.Text = "Jobs";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1047, 462);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(12, 561);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(67, 28);
            lbl1.TabIndex = 63;
            lbl1.Text = "job ID";
            // 
            // txtJobId
            // 
            txtJobId.Font = new Font("Segoe UI", 11F);
            txtJobId.Location = new Point(12, 592);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(260, 37);
            txtJobId.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 561);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 65;
            label1.Text = "Drivers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(698, 561);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 67;
            label2.Text = "Assistants";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 674);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 69;
            label3.Text = "Vehicles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(350, 674);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 71;
            label4.Text = "Containers";
            // 
            // checkedListBoxDrivers
            // 
            checkedListBoxDrivers.FormattingEnabled = true;
            checkedListBoxDrivers.Location = new Point(350, 597);
            checkedListBoxDrivers.Name = "checkedListBoxDrivers";
            checkedListBoxDrivers.Size = new Size(260, 32);
            checkedListBoxDrivers.TabIndex = 72;
            // 
            // checkedListBoxAssistants
            // 
            checkedListBoxAssistants.FormattingEnabled = true;
            checkedListBoxAssistants.Location = new Point(698, 597);
            checkedListBoxAssistants.Name = "checkedListBoxAssistants";
            checkedListBoxAssistants.Size = new Size(260, 32);
            checkedListBoxAssistants.TabIndex = 73;
            // 
            // checkedListBoxContainers
            // 
            checkedListBoxContainers.FormattingEnabled = true;
            checkedListBoxContainers.Location = new Point(350, 705);
            checkedListBoxContainers.Name = "checkedListBoxContainers";
            checkedListBoxContainers.Size = new Size(260, 32);
            checkedListBoxContainers.TabIndex = 74;
            // 
            // checkedListBoxVehicles
            // 
            checkedListBoxVehicles.FormattingEnabled = true;
            checkedListBoxVehicles.Location = new Point(12, 705);
            checkedListBoxVehicles.Name = "checkedListBoxVehicles";
            checkedListBoxVehicles.Size = new Size(260, 32);
            checkedListBoxVehicles.TabIndex = 75;
            // 
            // btnRemoveJob
            // 
            btnRemoveJob.BackColor = Color.Brown;
            btnRemoveJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveJob.ForeColor = SystemColors.Control;
            btnRemoveJob.Location = new Point(830, 836);
            btnRemoveJob.Name = "btnRemoveJob";
            btnRemoveJob.Size = new Size(218, 56);
            btnRemoveJob.TabIndex = 76;
            btnRemoveJob.Text = "Remove";
            btnRemoveJob.UseVisualStyleBackColor = false;
            btnRemoveJob.Click += btnRemoveJob_Click;
            // 
            // btnAssignJob
            // 
            btnAssignJob.BackColor = SystemColors.Highlight;
            btnAssignJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignJob.ForeColor = SystemColors.ButtonHighlight;
            btnAssignJob.Location = new Point(382, 836);
            btnAssignJob.Name = "btnAssignJob";
            btnAssignJob.Size = new Size(218, 56);
            btnAssignJob.TabIndex = 77;
            btnAssignJob.Text = "Add";
            btnAssignJob.UseVisualStyleBackColor = false;
            btnAssignJob.Click += btnAssignJob_Click;
            // 
            // btnEditJob
            // 
            btnEditJob.BackColor = Color.FromArgb(0, 192, 0);
            btnEditJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditJob.ForeColor = SystemColors.ButtonHighlight;
            btnEditJob.Location = new Point(606, 836);
            btnEditJob.Name = "btnEditJob";
            btnEditJob.Size = new Size(218, 56);
            btnEditJob.TabIndex = 78;
            btnEditJob.Text = "Edit";
            btnEditJob.UseVisualStyleBackColor = false;
            btnEditJob.Click += btnEditJob_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Center;
            btnSearch.Location = new Point(278, 592);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 39);
            btnSearch.TabIndex = 79;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnJobPDF
            // 
            btnJobPDF.BackColor = Color.SeaGreen;
            btnJobPDF.ForeColor = SystemColors.ButtonHighlight;
            btnJobPDF.Location = new Point(19, 851);
            btnJobPDF.Name = "btnJobPDF";
            btnJobPDF.Size = new Size(202, 41);
            btnJobPDF.TabIndex = 80;
            btnJobPDF.Text = "Job report";
            btnJobPDF.UseVisualStyleBackColor = false;
            btnJobPDF.Click += btnJobPDF_Click;
            // 
            // NewJobsPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 897);
            Controls.Add(btnJobPDF);
            Controls.Add(btnSearch);
            Controls.Add(btnEditJob);
            Controls.Add(btnAssignJob);
            Controls.Add(btnRemoveJob);
            Controls.Add(checkedListBoxVehicles);
            Controls.Add(checkedListBoxContainers);
            Controls.Add(checkedListBoxAssistants);
            Controls.Add(checkedListBoxDrivers);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(txtJobId);
            Controls.Add(dataGridView1);
            Controls.Add(lblDashboard);
            Name = "NewJobsPanel";
            Text = "NewJobsPane";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboard;
        private DataGridView dataGridView1;
        private Label lbl1;
        private TextBox txtJobId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBoxDrivers;
        private CheckedListBox checkedListBoxAssistants;
        private CheckedListBox checkedListBoxContainers;
        private CheckedListBox checkedListBoxVehicles;
        private Button btnRemoveJob;
        private Button btnAssignJob;
        private Button btnEditJob;
        private Button btnSearch;
        private Button btnJobPDF;
    }
}