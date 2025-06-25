namespace Goods_Shifting.forms.Auth
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            btnAdminLogin = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(45, 43);
            label1.Name = "label1";
            label1.Size = new Size(248, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome to";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(285, 43);
            label2.Name = "label2";
            label2.Size = new Size(150, 54);
            label2.TabIndex = 1;
            label2.Text = "e-Shift";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(469, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 525);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(34, 497);
            label4.Name = "label4";
            label4.Size = new Size(420, 28);
            label4.TabIndex = 4;
            label4.Text = "Need help? Contact us at support@e-shift.com";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(114, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(260, 68);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(434, 90);
            label3.TabIndex = 2;
            label3.Text = "e-Shift made our family move completely\r\n hassle-free! Their team handled everything\r\n with care and professionalism.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdminLogin.BackColor = SystemColors.InactiveBorder;
            btnAdminLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdminLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminLogin.Location = new Point(1108, 840);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(208, 53);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
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
            label5.TabIndex = 5;
            label5.Text = "E-Shift";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1378, 926);
            Controls.Add(label5);
            Controls.Add(btnAdminLogin);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Button btnLogin;
        private Label label4;
        private Button btnAdminLogin;
        private Label label5;
    }
}