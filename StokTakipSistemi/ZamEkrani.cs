using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class ZamEkrani : Form
    {
        // Yuvarlatılmış dikdörtgen için gerekli WinAPI fonksiyonu
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public ZamEkrani()
        {
            InitializeComponent();

            // Fontu tüm kontrolleri için uygulamak:
            string fontFamilyName = "Inter"; // Kendi font isminizi buraya yazın
            float fontSize = 10; // İstediğiniz font boyutunu buraya yazın

            // Utility sınıfından font uygulama metodunu çağırın
            FontUtility.ApplyCustomFontToAllControls(this, fontFamilyName, fontSize);

            //buton köşeleri yuvarlama
            btnEkle.Region = Region.FromHrgn(CreateRoundRectRgn(
             0,
             0,
             btnEkle.Width,
             btnEkle.Height,
             5,
             5));
        }


        private void ZamEkrani_Load(object sender, EventArgs e)
        {
            btnEkle.BackColor = ColorTranslator.FromHtml("#005EFC");
            btnEkle.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            //label yazılarının rengini değiştir
            //lblEskiFiyat.ForeColor = ColorTranslator.FromHtml("#1D212E");

            // Renkleri ayarla
            Color newForeColor = ColorTranslator.FromHtml("#1D212E"); 
            Color newBackColor = Color.Transparent;

            // Formun tüm Label kontrollerini değiştir
            ChangeAllLabelsColorRecursive(this, newForeColor, newBackColor);

            //formun rengini değştir
            this.BackColor = ColorTranslator.FromHtml("#F8F8FA");
        }
        private void ChangeAllLabelsColorRecursive(Control parent, Color foreColor, Color backColor)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = ColorTranslator.FromHtml("#1D212E");
                    label.BackColor = backColor;
                }
                else if (control.HasChildren)
                {
                    ChangeAllLabelsColorRecursive(control, foreColor, backColor); // Alt kontrolleri kontrol et
                }
            }
        }
    }
}
