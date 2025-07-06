namespace Goods_Shifting.forms.Admin
{
    partial class OngingJobsPanel
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
            lblDashboard = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            txtJobId = new TextBox();
            label1 = new Label();
            txtAmount = new TextBox();
            btnCompleteJob = new Button();
            btnCancleJob = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(23, 19);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(269, 32);
            lblDashboard.TabIndex = 21;
            lblDashboard.Text = "Manage Ongoing Task";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1021, 560);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 661);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 48;
            label4.Text = "Job ID";
            // 
            // txtJobId
            // 
            txtJobId.Font = new Font("Segoe UI", 11F);
            txtJobId.Location = new Point(54, 692);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(262, 37);
            txtJobId.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 661);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 50;
            label1.Text = "Payment";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 11F);
            txtAmount.Location = new Point(379, 692);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(262, 37);
            txtAmount.TabIndex = 49;
            // 
            // btnCompleteJob
            // 
            btnCompleteJob.BackColor = SystemColors.MenuHighlight;
            btnCompleteJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCompleteJob.ForeColor = SystemColors.Control;
            btnCompleteJob.Location = new Point(591, 778);
            btnCompleteJob.Name = "btnCompleteJob";
            btnCompleteJob.RightToLeft = RightToLeft.No;
            btnCompleteJob.Size = new Size(218, 56);
            btnCompleteJob.TabIndex = 52;
            btnCompleteJob.Text = "Complete";
            btnCompleteJob.UseVisualStyleBackColor = false;
            btnCompleteJob.Click += btnCompleteJob_Click;
            // 
            // btnCancleJob
            // 
            btnCancleJob.BackColor = Color.Brown;
            btnCancleJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancleJob.ForeColor = SystemColors.Control;
            btnCancleJob.Location = new Point(815, 778);
            btnCancleJob.Name = "btnCancleJob";
            btnCancleJob.Size = new Size(218, 56);
            btnCancleJob.TabIndex = 51;
            btnCancleJob.Text = "Close";
            btnCancleJob.UseVisualStyleBackColor = false;
            btnCancleJob.Click += btnCancleJob_Click;
            // 
            // OngingJobsPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 846);
            Controls.Add(btnCompleteJob);
            Controls.Add(btnCancleJob);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(txtJobId);
            Controls.Add(dataGridView1);
            Controls.Add(lblDashboard);
            Name = "OngingJobsPanel";
            Text = "OngingJobsPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDashboard;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtJobId;
        private Label label1;
        private TextBox txtAmount;
        private Button btnCompleteJob;
        private Button btnCancleJob;
    }
}