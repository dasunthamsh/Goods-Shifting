namespace Goods_Shifting.forms.Customer
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label5 = new Label();
            panel1 = new Panel();
            btnLogin = new Label();
            label6 = new Label();
            btnRgister = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnRgister);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(393, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 755);
            panel1.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Highlight;
            btnLogin.Location = new Point(351, 680);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 28);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Log in here";
            btnLogin.TextAlign = ContentAlignment.TopCenter;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(115, 679);
            label6.Name = "label6";
            label6.Size = new Size(239, 28);
            label6.TabIndex = 16;
            label6.Text = "Already have an account? ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRgister
            // 
            btnRgister.BackColor = SystemColors.MenuHighlight;
            btnRgister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRgister.ForeColor = SystemColors.Control;
            btnRgister.Location = new Point(163, 534);
            btnRgister.Name = "btnRgister";
            btnRgister.Size = new Size(260, 68);
            btnRgister.TabIndex = 15;
            btnRgister.Text = "Create account";
            btnRgister.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(64, 412);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(471, 37);
            txtPassword.TabIndex = 14;
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
            label4.Location = new Point(141, 102);
            label4.Name = "label4";
            label4.Size = new Size(311, 28);
            label4.TabIndex = 12;
            label4.Text = "Create your account to get started";
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
            label1.Location = new Point(216, 31);
            label1.Name = "label1";
            label1.Size = new Size(178, 54);
            label1.TabIndex = 7;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1378, 926);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private Label btnLogin;
        private Label label6;
        private Button btnRgister;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Button btnBack;
    }
}