using StokTakipSistemi.utils;
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
    public partial class Guncelle : Form
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

        public Guncelle()
        {
            InitializeComponent();



            // Fontu tüm kontrolleri için uygulamak:
            string fontFamilyName = "Inter"; // Kendi font isminizi buraya yazın
            float fontSize = 10; // İstediğiniz font boyutunu buraya yazın

            // Utility sınıfından font uygulama metodunu çağırın
            FontUtility.ApplyCustomFontToAllControls(this, fontFamilyName, fontSize);

            //buton köşeleri yuvarlama
            btnGuncelleEkrani.Region = Region.FromHrgn(CreateRoundRectRgn(
             0,
             0,
             btnGuncelleEkrani.Width,
             btnGuncelleEkrani.Height,
             5,
             5));
        }
        private void Guncelleme_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Tek bir sabit boyut
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlat


            btnGuncelleEkrani.BackColor = ColorTranslator.FromHtml("#005EFC");
            btnGuncelleEkrani.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            //label yazılarının rengini değiştir
            //lblEskiFiyat.ForeColor = ColorTranslator.FromHtml("#1D212E");

            // Renkleri ayarla
            Color newForeColor = ColorTranslator.FromHtml("#1D212E");
            Color newBackColor = Color.Transparent;

            // Formun tüm Label kontrollerini değiştir
            //ChangeAllLabelsColorRecursive(this, newForeColor, newBackColor);

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

 
            private int _urunID; // Sınıf değişkeni olarak urunID'yi tanımla

        // Bu metod ürün güncelleme ile ilişkilidir. Sayfalar sınıfından gelen parametreleri alır ve text boxlara doldurur.  
        public void setTxtCmb(
          string urunID,
          string urunBarkodu,
          string urunAdi,
          string urunGKategori,
          string urunKategori,
          string urunFirma,
          string urunTipi,
          string urunModeli,
          string urunBoyutu,
          string urunMensei,
          string urunAlisFiyat,
          string urunSatisFiyat,
          string urunStok,
          string urunMarka)
        {
            // _urunID'yi dönüştür ve sınıf değişkenine ata
            if (int.TryParse(urunID, out int parsedUrunID))
            {
                _urunID = parsedUrunID;
            }
            else
            {
                MessageBox.Show("Geçersiz ürün ID.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kontrollere değerleri atayalım
            txtBoxUBarkodu2.Text = urunBarkodu;
            txtBoxUAdi2.Text = urunAdi;
            cmbBoxGenelK2.Text = urunGKategori;
            cmbBoxUrunK2.Text = urunKategori;
            cmbBoxFirmaAdi2.Text = urunFirma;
            cmbBoxUrunTipi2.Text = urunTipi;
            cmbBoxUrunModeli2.Text = urunModeli;
            cmbBoxBoyut2.Text = urunBoyutu;
            cmbBoxMensei2.Text = urunMensei;
            txtBoxAlisFiyati2.Text = urunAlisFiyat;
            txtBoxSatisFiyati2.Text = urunSatisFiyat;
            txtBoxStok2.Text = urunStok;
            txtBoxMarka2.Text = urunMarka;

            // Güncelleme butonunu aktif hale getir
            btnGuncelleEkrani.Enabled = true;
        }

        private void btnGuncelleEkrani_Click(object sender, EventArgs e)
        {
            try
            {
                // Parametreleri uygun tiplere dönüştürme
                string urunBarkodu = txtBoxUBarkodu2.Text;
                string urunAdi = txtBoxUAdi2.Text;
                string urunGKategori = cmbBoxGenelK2.Text;
                string urunKategori = cmbBoxUrunK2.Text;
                string urunFirma = cmbBoxFirmaAdi2.Text;
                string urunTipi = cmbBoxUrunTipi2.Text;
                string urunModeli = cmbBoxUrunModeli2.Text;
                if (!decimal.TryParse(cmbBoxBoyut2.Text, out decimal urunBoyutu))
                {
                    MessageBox.Show("Geçersiz ürün boyutu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string urunMensei = cmbBoxMensei2.Text;
                if (!decimal.TryParse(txtBoxAlisFiyati2.Text, out decimal urunAlisFiyat))
                {
                    MessageBox.Show("Geçersiz alış fiyatı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtBoxSatisFiyati2.Text, out decimal urunSatisFiyat))
                {
                    MessageBox.Show("Geçersiz satış fiyatı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtBoxStok2.Text, out int urunStok))
                {
                    MessageBox.Show("Geçersiz stok miktarı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string urunMarka = txtBoxMarka2.Text;

                // Güncelleme işlemini gerçekleştirelim
                UrunIslemleri urunIslemleri = new UrunIslemleri();
                bool guncellendi = urunIslemleri.UrunGuncelle(_urunID, urunBarkodu, urunAdi, urunGKategori,
                    urunKategori, urunFirma, urunTipi, urunModeli, urunBoyutu,
                    urunMensei, urunAlisFiyat, urunSatisFiyat, urunStok, urunMarka);

                if (guncellendi)
                {
                    MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuncelleEkrani.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

