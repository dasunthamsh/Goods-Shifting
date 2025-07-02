namespace Goods_Shifting.forms.Admin
{
    partial class VehiclePanel
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtBrand = new TextBox();
            txtName = new TextBox();
            cmbVhicleType = new ComboBox();
            txtNumber = new TextBox();
            label1 = new Label();
            btnBackToProduction = new Button();
            btnAddToMaintenace = new Button();
            label3 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(910, 380);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(22, 24);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(235, 32);
            lblDashboard.TabIndex = 17;
            lblDashboard.Text = "Manage Employees";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(370, 778);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 56);
            btnAdd.TabIndex = 50;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.MenuHighlight;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(594, 778);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.No;
            btnEdit.Size = new Size(218, 56);
            btnEdit.TabIndex = 49;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(818, 778);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(218, 56);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 587);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 47;
            label5.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(388, 494);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 46;
            label4.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(712, 493);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 45;
            label2.Text = "Number";
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 11F);
            txtBrand.Location = new Point(61, 618);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(260, 37);
            txtBrand.TabIndex = 44;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(388, 525);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 37);
            txtName.TabIndex = 43;
            // 
            // cmbVhicleType
            // 
            cmbVhicleType.FormattingEnabled = true;
            cmbVhicleType.Location = new Point(388, 618);
            cmbVhicleType.Name = "cmbVhicleType";
            cmbVhicleType.Size = new Size(265, 33);
            cmbVhicleType.TabIndex = 42;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 11F);
            txtNumber.Location = new Point(712, 524);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(262, 37);
            txtNumber.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 587);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 40;
            label1.Text = "Vehicle Type";
            // 
            // btnBackToProduction
            // 
            btnBackToProduction.BackColor = SystemColors.InactiveCaption;
            btnBackToProduction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBackToProduction.ForeColor = SystemColors.ActiveCaptionText;
            btnBackToProduction.Location = new Point(22, 784);
            btnBackToProduction.Name = "btnBackToProduction";
            btnBackToProduction.Size = new Size(218, 48);
            btnBackToProduction.TabIndex = 51;
            btnBackToProduction.Text = "Back to production";
            btnBackToProduction.UseVisualStyleBackColor = false;
            btnBackToProduction.Click += btnBackToProduction_Click;
            // 
            // btnAddToMaintenace
            // 
            btnAddToMaintenace.BackColor = SystemColors.InactiveCaption;
            btnAddToMaintenace.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddToMaintenace.ForeColor = SystemColors.ActiveCaptionText;
            btnAddToMaintenace.Location = new Point(22, 730);
            btnAddToMaintenace.Name = "btnAddToMaintenace";
            btnAddToMaintenace.Size = new Size(218, 48);
            btnAddToMaintenace.TabIndex = 52;
            btnAddToMaintenace.Text = "Add To Maintenance";
            btnAddToMaintenace.UseVisualStyleBackColor = false;
            btnAddToMaintenace.Click += btnAddToMaintenace_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 493);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 54;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 11F);
            txtID.Location = new Point(64, 524);
            txtID.Name = "txtID";
            txtID.Size = new Size(262, 37);
            txtID.TabIndex = 53;
            // 
            // VehiclePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 846);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(btnAddToMaintenace);
            Controls.Add(btnBackToProduction);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtBrand);
            Controls.Add(txtName);
            Controls.Add(cmbVhicleType);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(lblDashboard);
            Name = "VehiclePanel";
            Text = "VehiclePanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblDashboard;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtBrand;
        private TextBox txtName;
        private ComboBox cmbVhicleType;
        private TextBox txtNumber;
        private Label label1;
        private Button btnBackToProduction;
        private Button btnAddToMaintenace;
        private Label label3;
        private TextBox txtID;
    }
}