using System;
using System.Drawing; // Add the necessary namespace for Color and Pen
using System.Windows.Forms;

namespace StokTakipSistemi.view
{
    public class CustomPanel : Panel
    {
        public string BorderColorHtml { get; set; } = "#000000";
        public int BorderWidth { get; set; } = 2; // Çerçeve genişliği

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // HTML renk kodunu Color türüne çevir
            Color borderColor = ColorTranslator.FromHtml(BorderColorHtml);

            // Çerçeve çizimi
            using (Pen pen = new Pen(borderColor, BorderWidth))
            {
                // Draw the rectangle
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}
