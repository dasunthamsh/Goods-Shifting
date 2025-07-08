namespace Goods_Shifting.forms.Customer
{
    partial class Notifications
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
            listBoxNotifications = new ListBox();
            SuspendLayout();
            // 
            // listBoxNotifications
            // 
            listBoxNotifications.FormattingEnabled = true;
            listBoxNotifications.ItemHeight = 25;
            listBoxNotifications.Location = new Point(12, 15);
            listBoxNotifications.Name = "listBoxNotifications";
            listBoxNotifications.Size = new Size(490, 229);
            listBoxNotifications.TabIndex = 0;
            // 
            // Notifications
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 267);
            Controls.Add(listBoxNotifications);
            Name = "Notifications";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Notifications";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxNotifications;
    }
}