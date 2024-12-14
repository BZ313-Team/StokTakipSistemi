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
    public partial class Istatistik2 : Form
    {
        public Istatistik2()
        {
            InitializeComponent();
            // Fontu tüm kontrolleri için uygulamak:
            string fontFamilyName = "Inter"; // Kendi font isminizi buraya yazın
            float fontSize = 9; // İstediğiniz font boyutunu buraya yazın

            // Utility sınıfından font uygulama metodunu çağırın
            FontUtility.ApplyCustomFontToAllControls(this, fontFamilyName, fontSize);




        }

        private void Istatistik2_Load(object sender, EventArgs e)
        {
            int xPosition = 425; // Yatay (X) pozisyonu
            int yPosition = 50;  // Dikey (Y) pozisyonu

            // Formun başlangıç pozisyonunu elle ayarlayın
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);

            //geri butonu
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.FlatAppearance.BorderSize = 2; // Kenarlık kalınlığı
            btnGeri.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlık rengi
            btnGeri.BackColor = Color.White;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
               
            this.Hide();
        }
    }
}
