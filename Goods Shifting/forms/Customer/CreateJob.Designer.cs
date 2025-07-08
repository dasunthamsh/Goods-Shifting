namespace Goods_Shifting.forms.Customer
{
    partial class CreateJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateJob));
            panel1 = new Panel();
            lblNotificationCount = new Label();
            btnNotifications = new Button();
            btnLogout = new Button();
            txtMessage = new RichTextBox();
            label5 = new Label();
            btnHistory = new Button();
            btnSubmit = new Button();
            label4 = new Label();
            label15 = new Label();
            txtNumber = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmbSize = new ComboBox();
            label13 = new Label();
            txtDestinationAddress = new TextBox();
            label14 = new Label();
            txtDestinationCity = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtOriginAddress = new TextBox();
            label10 = new Label();
            txtOriginCity = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label6 = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblNotificationCount);
            panel1.Controls.Add(btnNotifications);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(txtMessage);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cmbSize);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtDestinationAddress);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtDestinationCity);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtOriginAddress);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtOriginCity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1354, 902);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblNotificationCount
            // 
            lblNotificationCount.AutoSize = true;
            lblNotificationCount.BackColor = Color.Red;
            lblNotificationCount.ForeColor = SystemColors.ButtonHighlight;
            lblNotificationCount.Location = new Point(1094, 25);
            lblNotificationCount.Name = "lblNotificationCount";
            lblNotificationCount.Size = new Size(22, 25);
            lblNotificationCount.TabIndex = 42;
            lblNotificationCount.Text = "0";
            lblNotificationCount.Click += lblNotificationCount_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.BackgroundImage = (Image)resources.GetObject("btnNotifications.BackgroundImage");
            btnNotifications.BackgroundImageLayout = ImageLayout.Center;
            btnNotifications.Location = new Point(1044, 30);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(60, 47);
            btnNotifications.TabIndex = 43;
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Control;
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(1241, 28);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 49);
            btnLogout.TabIndex = 39;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(273, 611);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(805, 144);
            txtMessage.TabIndex = 38;
            txtMessage.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(12, 10);
            label5.Name = "label5";
            label5.Size = new Size(149, 54);
            label5.TabIndex = 37;
            label5.Text = "E-Shift";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = (Image)resources.GetObject("btnHistory.BackgroundImage");
            btnHistory.BackgroundImageLayout = ImageLayout.Center;
            btnHistory.Location = new Point(1140, 30);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(60, 47);
            btnHistory.TabIndex = 35;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.MenuHighlight;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(1106, 824);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(218, 56);
            btnSubmit.TabIndex = 34;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(273, 578);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 33;
            label4.Text = "Message";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.GrayText;
            label15.Location = new Point(709, 258);
            label15.Name = "label15";
            label15.Size = new Size(178, 30);
            label15.TabIndex = 32;
            label15.Text = "Contact Number";
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 11F);
            txtNumber.Location = new Point(709, 285);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(365, 37);
            txtNumber.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(273, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 31);
            dateTimePicker1.TabIndex = 30;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(709, 197);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(365, 33);
            cmbSize.TabIndex = 29;
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.GrayText;
            label13.Location = new Point(709, 464);
            label13.Name = "label13";
            label13.Size = new Size(213, 30);
            label13.TabIndex = 28;
            label13.Text = "Destination Address";
            // 
            // txtDestinationAddress
            // 
            txtDestinationAddress.Font = new Font("Segoe UI", 11F);
            txtDestinationAddress.Location = new Point(709, 497);
            txtDestinationAddress.Name = "txtDestinationAddress";
            txtDestinationAddress.Size = new Size(365, 37);
            txtDestinationAddress.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.GrayText;
            label14.Location = new Point(273, 464);
            label14.Name = "label14";
            label14.Size = new Size(173, 30);
            label14.TabIndex = 26;
            label14.Text = "Destination City";
            label14.Click += label14_Click;
            // 
            // txtDestinationCity
            // 
            txtDestinationCity.Font = new Font("Segoe UI", 11F);
            txtDestinationCity.Location = new Point(273, 497);
            txtDestinationCity.Name = "txtDestinationCity";
            txtDestinationCity.Size = new Size(365, 37);
            txtDestinationCity.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.GrayText;
            label12.Location = new Point(273, 262);
            label12.Name = "label12";
            label12.Size = new Size(142, 30);
            label12.TabIndex = 24;
            label12.Text = "Moving Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.GrayText;
            label11.Location = new Point(709, 354);
            label11.Name = "label11";
            label11.Size = new Size(161, 30);
            label11.TabIndex = 22;
            label11.Text = "Origin Address";
            // 
            // txtOriginAddress
            // 
            txtOriginAddress.Font = new Font("Segoe UI", 11F);
            txtOriginAddress.Location = new Point(709, 391);
            txtOriginAddress.Name = "txtOriginAddress";
            txtOriginAddress.Size = new Size(365, 37);
            txtOriginAddress.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.GrayText;
            label10.Location = new Point(273, 357);
            label10.Name = "label10";
            label10.Size = new Size(121, 30);
            label10.TabIndex = 20;
            label10.Text = "Origin City";
            // 
            // txtOriginCity
            // 
            txtOriginCity.Font = new Font("Segoe UI", 11F);
            txtOriginCity.Location = new Point(273, 390);
            txtOriginCity.Name = "txtOriginCity";
            txtOriginCity.Size = new Size(365, 37);
            txtOriginCity.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(709, 162);
            label3.Name = "label3";
            label3.Size = new Size(53, 30);
            label3.TabIndex = 11;
            label3.Text = "Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(273, 161);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(273, 194);
            txtName.Name = "txtName";
            txtName.Size = new Size(365, 37);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(273, 87);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 0;
            label1.Text = "Request Quote";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(163, 33);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 44;
            label6.Text = "Welcome Back";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblName.Location = new Point(298, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 25);
            lblName.TabIndex = 45;
            lblName.Text = "Name";
            // 
            // CreateJob
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 926);
            Controls.Add(panel1);
            Name = "CreateJob";
            Text = "CreateJob";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label11;
        private TextBox txtOriginAddress;
        private Label label10;
        private TextBox txtOriginCity;
        private Label label12;
        private Label label13;
        private TextBox txtDestinationAddress;
        private Label label14;
        private TextBox txtDestinationCity;
        private Label label15;
        private TextBox txtNumber;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbSize;
        private Label label4;
        private Button btnSubmit;
        private Button button1;
        private Button btnHistory;
        private Label label5;
        private RichTextBox txtMessage;
        private Button btnLogout;
        private Button button3;
        private Label lblNotificationCount;
        private Button btnNotifications;
        private Label lblName;
        private Label label6;
    }
}