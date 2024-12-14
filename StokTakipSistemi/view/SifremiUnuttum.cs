using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakipSistemi.utils;

namespace StokTakipSistemi
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
            // Fontu tüm kontrolleri için uygulamak:
            string fontFamilyName = "Inter"; // Kendi font isminizi buraya yazın
            float fontSize = 10; // İstediğiniz font boyutunu buraya yazın

            // Utility sınıfından font uygulama metodunu çağırın
            FontUtility.ApplyCustomFontToAllControls(this, fontFamilyName, fontSize);


        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            int xPosition = 425; // Yatay (X) pozisyonu
            int yPosition = 517;  // Dikey (Y) pozisyonu

            // Formun başlangıç pozisyonunu elle ayarlayın
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);
        }
    }
}
