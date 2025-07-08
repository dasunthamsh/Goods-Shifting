using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Goods_Shifting.lib
{
    public class ToastMessage
    {

        public static void Show(Form form, string message, bool isError = false, int displayTime = 3000)
        {
            // Create a new label for the toast message
            Label toastLabel = new Label();
            toastLabel.Text = message;
            toastLabel.AutoSize = true;
            toastLabel.ForeColor = Color.White;
            toastLabel.Font = new Font("Segoe UI", 14);
            toastLabel.Padding = new Padding(10, 5, 10, 5);

            // Set background color based on error/success
            toastLabel.BackColor = isError ? Color.FromArgb(192, 0, 0) : Color.FromArgb(0, 128, 0);

            // Position in top-right corner with some margin
            // Need to add to form first to calculate proper width
            form.Controls.Add(toastLabel);

            int cornerRadius = 6; // Adjust this value to change the roundness
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90); // Top-left
            path.AddArc(toastLabel.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90); // Top-right
            path.AddArc(toastLabel.Width - (cornerRadius * 2), toastLabel.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 0, 90); // Bottom-right
            path.AddArc(0, toastLabel.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90); // Bottom-left
            path.CloseFigure();

            toastLabel.Region = new Region(path);

            toastLabel.Location = new Point(
                form.ClientSize.Width - toastLabel.Width - 30,
                30);

            // Make sure it stays on top
            toastLabel.BringToFront();

            // Explicitly use Windows Forms Timer
            System.Windows.Forms.Timer toastTimer = new System.Windows.Forms.Timer();
            toastTimer.Interval = displayTime;
            toastTimer.Tick += (sender, e) =>
            {
                toastTimer.Stop();
                form.Controls.Remove(toastLabel);
                toastLabel.Dispose();
                toastTimer.Dispose();
            };

            toastTimer.Start();
        }
    }

}
