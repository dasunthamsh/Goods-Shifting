namespace Goods_Shifting.forms.Admin
{
    partial class EmployeePanel
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
            label1 = new Label();
            txtEmail = new TextBox();
            cmdEmployees = new ComboBox();
            txtName = new TextBox();
            txtDrivingLicense = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtIDNumber = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnEmplyeesJobPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(22, 24);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(235, 32);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Manage Employees";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 494);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 2;
            label1.Text = "Add Employees";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(709, 524);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 37);
            txtEmail.TabIndex = 3;
            // 
            // cmdEmployees
            // 
            cmdEmployees.FormattingEnabled = true;
            cmdEmployees.Location = new Point(58, 525);
            cmdEmployees.Name = "cmdEmployees";
            cmdEmployees.Size = new Size(265, 33);
            cmdEmployees.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(385, 525);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 37);
            txtName.TabIndex = 5;
            // 
            // txtDrivingLicense
            // 
            txtDrivingLicense.Font = new Font("Segoe UI", 11F);
            txtDrivingLicense.Location = new Point(58, 618);
            txtDrivingLicense.Name = "txtDrivingLicense";
            txtDrivingLicense.Size = new Size(260, 37);
            txtDrivingLicense.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(709, 493);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 685);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 8;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(385, 494);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 587);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 10;
            label5.Text = "Driving License";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(709, 587);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 11;
            label6.Text = "ID Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(391, 587);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 12;
            label7.Text = "Contact";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Font = new Font("Segoe UI", 11F);
            txtIDNumber.Location = new Point(709, 618);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(260, 37);
            txtIDNumber.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(385, 618);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(260, 37);
            txtContact.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(58, 716);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(589, 37);
            txtAddress.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(910, 380);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(815, 778);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(218, 56);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.MenuHighlight;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(591, 778);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.No;
            btnEdit.Size = new Size(218, 56);
            btnEdit.TabIndex = 38;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(367, 778);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 56);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEmplyeesJobPDF
            // 
            btnEmplyeesJobPDF.BackColor = Color.SeaGreen;
            btnEmplyeesJobPDF.ForeColor = SystemColors.ButtonHighlight;
            btnEmplyeesJobPDF.Location = new Point(9, 800);
            btnEmplyeesJobPDF.Name = "btnEmplyeesJobPDF";
            btnEmplyeesJobPDF.Size = new Size(202, 34);
            btnEmplyeesJobPDF.TabIndex = 54;
            btnEmplyeesJobPDF.Text = "Employees job report";
            btnEmplyeesJobPDF.UseVisualStyleBackColor = false;
            btnEmplyeesJobPDF.Click += btnEmplyeesJobPDF_Click;
            // 
            // EmployeePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 846);
            Controls.Add(btnEmplyeesJobPDF);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtIDNumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDrivingLicense);
            Controls.Add(txtName);
            Controls.Add(cmdEmployees);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(lblDashboard);
            Name = "EmployeePanel";
            Text = "EmployeePanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboard;
        private Label label1;
        private TextBox txtEmail;
        private ComboBox cmdEmployees;
        private TextBox txtName;
        private TextBox txtDrivingLicense;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtIDNumber;
        private TextBox txtContact;
        private TextBox txtAddress;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnEmplyeesJobPDF;
    }
}