namespace Goods_Shifting.forms.Admin
{
    partial class ContainerPanel
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
            cmbContainerType = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            lblID = new Label();
            cmbSize = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            txtContainerNumber = new TextBox();
            btnAddToMaintenace = new Button();
            btnBackToProduction = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
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
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(22, 24);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(236, 32);
            lblDashboard.TabIndex = 19;
            lblDashboard.Text = "Manage Containers";
            // 
            // cmbContainerType
            // 
            cmbContainerType.FormattingEnabled = true;
            cmbContainerType.Location = new Point(388, 525);
            cmbContainerType.Name = "cmbContainerType";
            cmbContainerType.Size = new Size(265, 33);
            cmbContainerType.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 494);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 43;
            label1.Text = "Container Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(60, 523);
            label6.Name = "label6";
            label6.Size = new Size(134, 32);
            label6.TabIndex = 57;
            label6.Text = "Vehicle ID :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblID.Location = new Point(187, 523);
            lblID.Name = "lblID";
            lblID.Size = new Size(53, 32);
            lblID.TabIndex = 56;
            lblID.Text = "000";
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(712, 523);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(265, 33);
            cmbSize.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(712, 493);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 58;
            label2.Text = "Size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(388, 587);
            label5.Name = "label5";
            label5.Size = new Size(181, 28);
            label5.TabIndex = 61;
            label5.Text = "Container Number";
            // 
            // txtContainerNumber
            // 
            txtContainerNumber.Font = new Font("Segoe UI", 11F);
            txtContainerNumber.Location = new Point(388, 618);
            txtContainerNumber.Name = "txtContainerNumber";
            txtContainerNumber.Size = new Size(260, 37);
            txtContainerNumber.TabIndex = 60;
            // 
            // btnAddToMaintenace
            // 
            btnAddToMaintenace.BackColor = SystemColors.InactiveCaption;
            btnAddToMaintenace.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddToMaintenace.ForeColor = SystemColors.ActiveCaptionText;
            btnAddToMaintenace.Location = new Point(12, 732);
            btnAddToMaintenace.Name = "btnAddToMaintenace";
            btnAddToMaintenace.Size = new Size(218, 48);
            btnAddToMaintenace.TabIndex = 63;
            btnAddToMaintenace.Text = "Add To Maintenance";
            btnAddToMaintenace.UseVisualStyleBackColor = false;
            btnAddToMaintenace.Click += btnAddToMaintenace_Click;
            // 
            // btnBackToProduction
            // 
            btnBackToProduction.BackColor = SystemColors.InactiveCaption;
            btnBackToProduction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBackToProduction.ForeColor = SystemColors.ActiveCaptionText;
            btnBackToProduction.Location = new Point(12, 786);
            btnBackToProduction.Name = "btnBackToProduction";
            btnBackToProduction.Size = new Size(218, 48);
            btnBackToProduction.TabIndex = 62;
            btnBackToProduction.Text = "Back to production";
            btnBackToProduction.UseVisualStyleBackColor = false;
            btnBackToProduction.Click += btnBackToProduction_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(369, 778);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 56);
            btnAdd.TabIndex = 66;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.MenuHighlight;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(593, 778);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.No;
            btnEdit.Size = new Size(218, 56);
            btnEdit.TabIndex = 65;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(817, 778);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(218, 56);
            btnDelete.TabIndex = 64;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ContainerPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 846);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAddToMaintenace);
            Controls.Add(btnBackToProduction);
            Controls.Add(label5);
            Controls.Add(txtContainerNumber);
            Controls.Add(cmbSize);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(lblID);
            Controls.Add(cmbContainerType);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(lblDashboard);
            Name = "ContainerPanel";
            Text = "ContainerPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblDashboard;
        private ComboBox cmbContainerType;
        private Label label1;
        private Label label6;
        private Label lblID;
        private ComboBox cmbSize;
        private Label label2;
        private Label label5;
        private TextBox txtContainerNumber;
        private Button btnAddToMaintenace;
        private Button btnBackToProduction;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}