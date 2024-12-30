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
using Microsoft.Data.SqlClient;
using StokTakipSistemi.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipSistemi
{
    public partial class ZamEkrani : Form
    {
        UrunIslemleri urunIslemleri = new UrunIslemleri();
        SQLIslemleri sqlIslemleri = new SQLIslemleri();
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Tek bir sabit boyut
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlat

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

            txtBoxBarkod.Enabled = true; // TextBox'ı etkinleştir
            txtBoxBarkod.BackColor = SystemColors.Window; // Sistem arka plan rengini kullan
            txtBoxBarkod.ForeColor = SystemColors.ControlText; // Sistem metin rengini kullan

            cmbBoxZamTuru.SelectedIndex = 0; // ComboBox'ı ilk elemana ayarla
            txtBoxBarkod.TextChanged += txtBoxBarkod_TextChanged;
            // Zam oranı girişine TextChanged olayını bağlama
            txtBoxZam.TextChanged += txtBoxZam_TextChanged;

            FillAllComboBoxes();
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
        private void cmbBoxZamTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelUruneZam.Visible = false;//Urune zam paneli kullanılmıyor.
            panelKategoriZam.Visible = false;
            panelMarkaZam.Visible = false;
            if (cmbBoxZamTuru.SelectedIndex == 0)
            {
                panelUruneZam.Visible = false;
                panelKategoriZam.Visible = false;
                panelKategoriZam.Visible = false;
                panelEkran.Visible = true;

            }
            else if (cmbBoxZamTuru.SelectedIndex == 1)
            {
                panelKategoriZam.Visible = true;
                panelUruneZam.Visible = false;
                panelMarkaZam.Visible = false; 
                panelEkran.Visible = false;

            }
            else if(cmbBoxZamTuru.SelectedIndex == 2)
            {
                panelMarkaZam.Visible = true;
                panelUruneZam.Visible = false;
                panelKategoriZam.Visible = false;
                panelEkran.Visible = false;

            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunIslemleri.zamEkle(cmbBoxZamTuru, txtBoxBarkod,cmbBoxGenelKategori2, cmbBoxUrunKategori2,
                                  cmbBoxMarka3, cmbBoxFirmaAdi3, txtBoxZam, txtBoxZam2, txtBoxZam3);
        }

        // Barkod girişine TextChanged olayını bağlama
        private void txtBoxBarkod_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxBarkod.Text.Length == 13)
            {
                urunIslemleri.barkodChanged(txtBoxBarkod, txtBoxEskiFiyat, cmbBoxUrunKategori, cmbBoxUrunAdi, cmbBoxMarka);
            }
            else if (txtBoxBarkod.Text.Length < 13)
            {
                txtBoxEskiFiyat.Text = "Ürün Bulunamadı.";
                cmbBoxUrunKategori.SelectedIndex = -1;
                cmbBoxUrunAdi.SelectedIndex = -1;
                cmbBoxMarka.SelectedIndex = -1;
            }
        }

        // Zam oranı girişine TextChanged olayını bağlama
        private void txtBoxZam_TextChanged(object sender, EventArgs e)
        {
            urunIslemleri.zamChanged(txtBoxZam, txtBoxEskiFiyat, txtBoxYeniFiyat);
        }

        // Combobox'lar dolduruluyor
        private void FillAllComboBoxes()
        {
            urunIslemleri.comboBoxDoldur("SELECT DISTINCT UrunGKategori FROM Urun;", cmbBoxGenelKategori2);// Genel kategori ComboBox'u doldur
            urunIslemleri.comboBoxDoldur("SELECT DISTINCT UrunKategori FROM Urun;", cmbBoxUrunKategori2);// Ürün kategori ComboBox'u doldur
            urunIslemleri.comboBoxDoldur("SELECT DISTINCT UrunMarka FROM Urun;", cmbBoxMarka3);// Marka ComboBox'u doldu
            urunIslemleri.comboBoxDoldur("SELECT DISTINCT UrunUreticiFirma FROM Urun;", cmbBoxFirmaAdi3);// Firma ComboBox'u doldur
        }
        
    }
}
