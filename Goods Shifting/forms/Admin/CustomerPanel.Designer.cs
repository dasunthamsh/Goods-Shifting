namespace Goods_Shifting.forms.Admin
{
    partial class CustomerPanel
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
            btnCustomerReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1037, 683);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(22, 24);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(135, 32);
            lblDashboard.TabIndex = 21;
            lblDashboard.Text = "Customers";
            // 
            // btnCustomerReport
            // 
            btnCustomerReport.BackColor = Color.SeaGreen;
            btnCustomerReport.ForeColor = SystemColors.ButtonHighlight;
            btnCustomerReport.Location = new Point(22, 819);
            btnCustomerReport.Name = "btnCustomerReport";
            btnCustomerReport.Size = new Size(202, 43);
            btnCustomerReport.TabIndex = 55;
            btnCustomerReport.Text = "Customer Report";
            btnCustomerReport.UseVisualStyleBackColor = false;
            btnCustomerReport.Click += btnCustomerReport_Click;
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 897);
            Controls.Add(btnCustomerReport);
            Controls.Add(dataGridView1);
            Controls.Add(lblDashboard);
            Name = "CustomerPanel";
            Text = "CustomerPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblDashboard;
        private Button btnCustomerReport;
    }
}