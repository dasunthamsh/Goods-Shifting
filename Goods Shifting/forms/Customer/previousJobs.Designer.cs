namespace Goods_Shifting.forms.Customer
{
    partial class previousJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(previousJobs));
            dataGridView1 = new DataGridView();
            cmbSize = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtNumber = new TextBox();
            txtOriginCity = new TextBox();
            txtDestinationAddress = new TextBox();
            txtDestinationCity = new TextBox();
            txtOriginAddress = new TextBox();
            txtMessage = new RichTextBox();
            btnEdit = new Button();
            label4 = new Label();
            label15 = new Label();
            label13 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtJobId = new TextBox();
            btnBack = new Button();
            btnDeleteJob = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1336, 250);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(478, 408);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(365, 33);
            cmbSize.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(478, 609);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 31);
            dateTimePicker1.TabIndex = 32;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 11F);
            txtNumber.Location = new Point(894, 404);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(365, 37);
            txtNumber.TabIndex = 34;
            // 
            // txtOriginCity
            // 
            txtOriginCity.Font = new Font("Segoe UI", 11F);
            txtOriginCity.Location = new Point(59, 508);
            txtOriginCity.Name = "txtOriginCity";
            txtOriginCity.Size = new Size(365, 37);
            txtOriginCity.TabIndex = 33;
            // 
            // txtDestinationAddress
            // 
            txtDestinationAddress.Font = new Font("Segoe UI", 11F);
            txtDestinationAddress.Location = new Point(59, 603);
            txtDestinationAddress.Name = "txtDestinationAddress";
            txtDestinationAddress.Size = new Size(365, 37);
            txtDestinationAddress.TabIndex = 37;
            // 
            // txtDestinationCity
            // 
            txtDestinationCity.Font = new Font("Segoe UI", 11F);
            txtDestinationCity.Location = new Point(478, 508);
            txtDestinationCity.Name = "txtDestinationCity";
            txtDestinationCity.Size = new Size(365, 37);
            txtDestinationCity.TabIndex = 36;
            // 
            // txtOriginAddress
            // 
            txtOriginAddress.Font = new Font("Segoe UI", 11F);
            txtOriginAddress.Location = new Point(894, 508);
            txtOriginAddress.Name = "txtOriginAddress";
            txtOriginAddress.Size = new Size(365, 37);
            txtOriginAddress.TabIndex = 35;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(59, 708);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(805, 124);
            txtMessage.TabIndex = 39;
            txtMessage.Text = "";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.MenuHighlight;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(910, 858);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(218, 56);
            btnEdit.TabIndex = 40;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(58, 675);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 49;
            label4.Text = "Message";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.GrayText;
            label15.Location = new Point(894, 371);
            label15.Name = "label15";
            label15.Size = new Size(178, 30);
            label15.TabIndex = 48;
            label15.Text = "Contact Number";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.GrayText;
            label13.Location = new Point(59, 570);
            label13.Name = "label13";
            label13.Size = new Size(213, 30);
            label13.TabIndex = 47;
            label13.Text = "Destination Address";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.GrayText;
            label14.Location = new Point(478, 475);
            label14.Name = "label14";
            label14.Size = new Size(173, 30);
            label14.TabIndex = 46;
            label14.Text = "Destination City";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.GrayText;
            label12.Location = new Point(478, 578);
            label12.Name = "label12";
            label12.Size = new Size(142, 30);
            label12.TabIndex = 45;
            label12.Text = "Moving Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.GrayText;
            label11.Location = new Point(894, 475);
            label11.Name = "label11";
            label11.Size = new Size(161, 30);
            label11.TabIndex = 44;
            label11.Text = "Origin Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.GrayText;
            label10.Location = new Point(58, 475);
            label10.Name = "label10";
            label10.Size = new Size(121, 30);
            label10.TabIndex = 43;
            label10.Text = "Origin City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(478, 375);
            label3.Name = "label3";
            label3.Size = new Size(53, 30);
            label3.TabIndex = 42;
            label3.Text = "Size";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(73, 19);
            label1.Name = "label1";
            label1.Size = new Size(195, 38);
            label1.TabIndex = 50;
            label1.Text = "Previous Jobs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(57, 371);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 52;
            label2.Text = "Job ID";
            // 
            // txtJobId
            // 
            txtJobId.Font = new Font("Segoe UI", 11F);
            txtJobId.Location = new Point(58, 404);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(365, 37);
            txtJobId.TabIndex = 51;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(21, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(42, 34);
            btnBack.TabIndex = 53;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteJob
            // 
            btnDeleteJob.BackColor = Color.Brown;
            btnDeleteJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteJob.ForeColor = SystemColors.Control;
            btnDeleteJob.Location = new Point(1148, 858);
            btnDeleteJob.Name = "btnDeleteJob";
            btnDeleteJob.Size = new Size(218, 56);
            btnDeleteJob.TabIndex = 54;
            btnDeleteJob.Text = "Delete";
            btnDeleteJob.UseVisualStyleBackColor = false;
            btnDeleteJob.Click += btnDeleteJob_Click;
            // 
            // previousJobs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 926);
            Controls.Add(btnDeleteJob);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(txtJobId);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(btnEdit);
            Controls.Add(txtMessage);
            Controls.Add(txtDestinationAddress);
            Controls.Add(txtDestinationCity);
            Controls.Add(txtOriginAddress);
            Controls.Add(txtNumber);
            Controls.Add(txtOriginCity);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbSize);
            Controls.Add(dataGridView1);
            Name = "previousJobs";
            Text = "previousJobs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbSize;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNumber;
        private TextBox txtOriginCity;
        private TextBox txtDestinationAddress;
        private TextBox txtDestinationCity;
        private TextBox txtOriginAddress;
        private RichTextBox txtMessage;
        private Button btnEdit;
        private Label label4;
        private Label label15;
        private Label label13;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtJobId;
        private Button btnBack;
        private Button btnDeleteJob;
    }
}