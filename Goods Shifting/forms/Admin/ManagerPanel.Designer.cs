namespace Goods_Shifting.forms.Admin
{
    partial class ManagerPanel
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
            label6 = new Label();
            lblID = new Label();
            label4 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtAddress = new TextBox();
            txtID = new TextBox();
            Contact = new Label();
            txtContact = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            Password = new Label();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1021, 438);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(22, 24);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(226, 32);
            lblDashboard.TabIndex = 19;
            lblDashboard.Text = "Manage Managers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(819, 24);
            label6.Name = "label6";
            label6.Size = new Size(156, 32);
            label6.TabIndex = 59;
            label6.Text = "Manager ID :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblID.Location = new Point(977, 24);
            lblID.Name = "lblID";
            lblID.Size = new Size(53, 32);
            lblID.TabIndex = 58;
            lblID.Text = "000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 553);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 63;
            label4.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(398, 552);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 62;
            label2.Text = "Email";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(61, 587);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 37);
            txtName.TabIndex = 61;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(393, 587);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 37);
            txtEmail.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 675);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 67;
            label1.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(717, 556);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 66;
            label3.Text = "ID Number";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(393, 709);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(262, 37);
            txtAddress.TabIndex = 65;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 11F);
            txtID.Location = new Point(717, 587);
            txtID.Name = "txtID";
            txtID.Size = new Size(262, 37);
            txtID.TabIndex = 64;
            // 
            // Contact
            // 
            Contact.AutoSize = true;
            Contact.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contact.Location = new Point(67, 675);
            Contact.Name = "Contact";
            Contact.Size = new Size(81, 28);
            Contact.TabIndex = 69;
            Contact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(61, 709);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(262, 37);
            txtContact.TabIndex = 68;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(377, 829);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 56);
            btnAdd.TabIndex = 72;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 192, 0);
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(601, 829);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.No;
            btnEdit.Size = new Size(218, 56);
            btnEdit.TabIndex = 71;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(825, 829);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(218, 56);
            btnDelete.TabIndex = 70;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(717, 677);
            Password.Name = "Password";
            Password.Size = new Size(97, 28);
            Password.TabIndex = 75;
            Password.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(717, 709);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 37);
            txtPassword.TabIndex = 74;
            // 
            // ManagerPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1071, 897);
            Controls.Add(Password);
            Controls.Add(txtPassword);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(Contact);
            Controls.Add(txtContact);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(lblID);
            Controls.Add(dataGridView1);
            Controls.Add(lblDashboard);
            Name = "ManagerPanel";
            Text = "ManagerPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblDashboard;
        private Label label6;
        private Label lblID;
        private Label label4;
        private Label label2;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label1;
        private Label label3;
        private TextBox txtAddress;
        private TextBox txtID;
        private Label Contact;
        private TextBox txtContact;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label Password;
        private TextBox txtPassword;
    }
}