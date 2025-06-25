namespace Goods_Shifting.forms.Customer
{
    partial class ResatPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResatPassword));
            btnBack = new Button();
            label5 = new Label();
            panel1 = new Panel();
            btnResat = new Button();
            txtNewPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(195, 36);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(42, 34);
            btnBack.TabIndex = 9;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(25, 24);
            label5.Name = "label5";
            label5.Size = new Size(149, 54);
            label5.TabIndex = 8;
            label5.Text = "E-Shift";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btnResat);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(390, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 755);
            panel1.TabIndex = 10;
            // 
            // btnResat
            // 
            btnResat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnResat.BackColor = SystemColors.MenuHighlight;
            btnResat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResat.ForeColor = SystemColors.Control;
            btnResat.Location = new Point(163, 534);
            btnResat.Name = "btnResat";
            btnResat.Size = new Size(260, 68);
            btnResat.TabIndex = 15;
            btnResat.Text = "Resat";
            btnResat.UseVisualStyleBackColor = false;
            btnResat.Click += btnResat_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 11F);
            txtNewPassword.Location = new Point(64, 412);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Enter your new password";
            txtNewPassword.Size = new Size(471, 37);
            txtNewPassword.TabIndex = 14;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(64, 370);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(124, 104);
            label4.Name = "label4";
            label4.Size = new Size(349, 28);
            label4.TabIndex = 12;
            label4.Text = "Login to manage your moving services";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(64, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(471, 37);
            txtEmail.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(64, 235);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 8;
            label2.Text = "Email Address";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(140, 31);
            label1.Name = "label1";
            label1.Size = new Size(316, 54);
            label1.TabIndex = 7;
            label1.Text = "Resat Password";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResatPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1378, 926);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Name = "ResatPassword";
            Text = "ResatPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label5;
        private Panel panel1;
        private Label btnRegister;
        private Label label6;
        private Button btnResat;
        private TextBox txtNewPassword;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}