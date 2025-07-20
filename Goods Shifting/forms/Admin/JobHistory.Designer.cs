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
            From = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1045, 655);
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
            btnOngoingJobPDF.Location = new Point(14, 838);
            btnOngoingJobPDF.Name = "btnOngoingJobPDF";
            btnOngoingJobPDF.Size = new Size(202, 47);
            btnOngoingJobPDF.TabIndex = 54;
            btnOngoingJobPDF.Text = "Ongoing job report";
            btnOngoingJobPDF.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(90, 99);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(262, 33);
            cmbStatus.TabIndex = 56;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(399, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(298, 31);
            dateTimePicker1.TabIndex = 58;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(14, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(39, 42);
            panel1.TabIndex = 59;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(735, 101);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(298, 31);
            dateTimePicker2.TabIndex = 60;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // From
            // 
            From.AutoSize = true;
            From.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            From.ForeColor = SystemColors.ControlDarkDark;
            From.Location = new Point(399, 68);
            From.Name = "From";
            From.Size = new Size(64, 30);
            From.TabIndex = 61;
            From.Text = "From";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(735, 68);
            label1.Name = "label1";
            label1.Size = new Size(36, 30);
            label1.TabIndex = 62;
            label1.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(90, 68);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 63;
            label2.Text = "Status";
            // 
            // JobHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 897);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(From);
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
        private Label From;
        private Label label1;
        private Label label2;
    }
}