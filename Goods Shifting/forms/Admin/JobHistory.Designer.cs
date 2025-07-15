namespace Goods_Shifting.forms.Admin
{
    partial class JobHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobHistory));
            dataGridView1 = new DataGridView();
            lblDashboard = new Label();
            btnOngoingJobPDF = new Button();
            cmbStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1019, 583);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(14, 15);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(157, 32);
            lblDashboard.TabIndex = 21;
            lblDashboard.Text = "Jobs History";
            // 
            // btnOngoingJobPDF
            // 
            btnOngoingJobPDF.BackColor = Color.SeaGreen;
            btnOngoingJobPDF.ForeColor = SystemColors.ButtonHighlight;
            btnOngoingJobPDF.Location = new Point(14, 800);
            btnOngoingJobPDF.Name = "btnOngoingJobPDF";
            btnOngoingJobPDF.Size = new Size(202, 34);
            btnOngoingJobPDF.TabIndex = 54;
            btnOngoingJobPDF.Text = "Ongoing job report";
            btnOngoingJobPDF.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(90, 83);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(262, 33);
            cmbStatus.TabIndex = 56;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(399, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(298, 31);
            dateTimePicker1.TabIndex = 58;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(14, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(39, 42);
            panel1.TabIndex = 59;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(735, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(298, 31);
            dateTimePicker2.TabIndex = 60;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // JobHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 846);
            Controls.Add(dateTimePicker2);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbStatus);
            Controls.Add(btnOngoingJobPDF);
            Controls.Add(dataGridView1);
            Controls.Add(lblDashboard);
            Name = "JobHistory";
            Text = "JobHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblDashboard;
        private Button btnOngoingJobPDF;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private DateTimePicker dateTimePicker2;
    }
}