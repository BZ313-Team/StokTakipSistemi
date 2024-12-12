using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;

namespace StokTakipSistemi
{
    public partial class Sayfalar : Form
    {
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



        public Sayfalar()
        {
            InitializeComponent();

            ApplyRoundedCornersToPanel(pnlSatisbtn, 5);
            ApplyRoundedCornersToPanel(pnlUrunlerbtn, 5);
            ApplyRoundedCornersToPanel(pnlGecmisbtn, 5);
            ApplyRoundedCornersToPanel(pnlStokbtn, 5);
            ApplyRoundedCornersToPanel(pnlIstatistikbtn, 5);

            ApplyRoundedCornersToPanel(pnlUrunEklebtn, 5);
            ApplyRoundedCornersToPanel(pnlUrunSilbtn, 5);
            ApplyRoundedCornersToPanel(pnlTemizlebtn, 5);
            ApplyRoundedCornersToPanel(pnlUrunGuncellebtn, 5);
            ApplyRoundedCornersToPanel(pnlZamEklebtn, 5);

            cmbBoxUrunSFiltre.Text = "Günlük";
            cmbBoxStokSFiltre.Text = "Günlük";
            cmbBoxGecmisSFiltre.Text = "Günlük";
            cmbBoxIstFiltre.Text = "Günlük";

            cmbBoxUrunSFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");
            cmbBoxStokSFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");
            cmbBoxGecmisSFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");
            cmbBoxIstFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Fontu tüm kontrolleri için uygulamak:
            string fontFamilyName = "Inter"; // Kendi font isminizi buraya yazýn
            float fontSize = 10; // Ýstediðiniz font boyutunu buraya yazýn

            // Utility sýnýfýndan font uygulama metodunu çaðýrýn
            FontUtility.ApplyCustomFontToAllControls(this, fontFamilyName, fontSize);
            btnDEL.Font = new Font(btnUrunler.Font.FontFamily, 9f);
            lblTutar.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblBileme.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblIndirimTL.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblIndirimYuzde.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblToplamTutar.Font = new Font(btnUrunler.Font.FontFamily, 11f);

            //Buttonlarýn kenar kývrýmý deðiþimi
            btnSatis.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnSatis.Width,
              btnSatis.Height,
              5,
              5));

            btnUrunler.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnUrunler.Width,
              btnUrunler.Height,
              5,
              5));

            btnStok.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnStok.Width,
              btnStok.Height,
              5,
              5));

            btnGecmis.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnGecmis.Width,
              btnGecmis.Height,
              5,
              5));

            btnIstatistik.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnIstatistik.Width,
              btnIstatistik.Height,
              5,
              5));


            btnSatisYap.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnSatisYap.Width,
              btnSatisYap.Height,
              5,
              5));

            btnUrunEkle.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnUrunEkle.Width,
              btnUrunEkle.Height,
              5,
              5));

            btnUrunSil.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnUrunEkle.Width,
              btnUrunEkle.Height,
              5,
              5));

            btnTemizle.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnUrunEkle.Width,
              btnUrunEkle.Height,
              5,
              5));

            btnUrunGuncelle.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnUrunEkle.Width,
              btnUrunEkle.Height,
              5,
              5));

            btnZamEkle.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnZamEkle.Width,
              btnZamEkle.Height,
              5,
              5));
            // panellerin renk deðiþimi
            pnlSatisbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlUrunlerbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlGecmisbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlStokbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlIstatistikbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");


            // Buttonlarýn renk deðiþmi
            btnSatis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnUrunler.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnStok.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnGecmis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnIstatistik.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnSatisYap.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnSatisYap.BackColor = ColorTranslator.FromHtml("#005EFC");
            btnSatisYap.ForeColor = ColorTranslator.FromHtml("#FFFFFF");



            // Chartýn gözükmesi için ürün eklenmesi gerekiyor Ürün ekleme denemesi silinecek
            chartSatis.Series[0].Points.Clear(); // Mevcut verileri temizler
            chartSatis.Series[0].Points.AddXY("Kategori 1", 40);
            chartSatis.Series[0].Points.AddXY("Kategori 2", 30);


        }

        // Panel kenarlarýný kývýrmak için kullanýlacak metod
        private void ApplyRoundedCornersToPanel(Panel panel, int radius)
        {
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(
                0,
                0,
                panel.Width,
                panel.Height,
                radius,
                radius
        ));
        }

        private void Sayfalar_Load(object sender, EventArgs e)
        {
            
            int xPosition = 150; // Yatay (X) pozisyonu
            int yPosition = 175;  // Dikey (Y) pozisyonu

            // Formun baþlangýç pozisyonunu elle ayarlayýn
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);


            // Formun baþlangýç pozisyonunu elle ayarlayýn
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);

            //urun ekle butonu
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.FlatAppearance.BorderSize = 3; // Kenarlýk kalýnlýðý
            btnUrunEkle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlýk rengi
            btnUrunEkle.BackColor = Color.White;

            //urun sil butonu
            btnUrunSil.FlatStyle = FlatStyle.Flat;
            btnUrunSil.FlatAppearance.BorderSize = 3; // Kenarlýk kalýnlýðý
            btnUrunSil.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlýk rengi
            btnUrunSil.BackColor = Color.White;

            //temizle butonu
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.FlatAppearance.BorderSize = 3; // Kenarlýk kalýnlýðý
            btnTemizle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlýk rengi
            btnTemizle.BackColor = Color.White;

            //ürün güncelle
            btnUrunGuncelle.FlatStyle = FlatStyle.Flat;
            btnUrunGuncelle.FlatAppearance.BorderSize = 3; // Kenarlýk kalýnlýðý
            btnUrunGuncelle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlýk rengi
            btnUrunGuncelle.BackColor = Color.White;

            //zam ekle
            btnZamEkle.FlatStyle = FlatStyle.Flat;
            btnZamEkle.FlatAppearance.BorderSize = 3; // Kenarlýk kalýnlýðý
            btnZamEkle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlýk rengi
            btnZamEkle.BackColor = Color.White;

            //ileri butonu
            btnIleri.FlatStyle = FlatStyle.Flat;
            btnIleri.FlatAppearance.BorderSize = 2; // Kenarlýk kalýnlýðý
            btnIleri.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlýk rengi
            btnIleri.BackColor = Color.White;

        }





        // buttonlarýn renk ayarlarý

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

            panelButtons.BackColor = ColorTranslator.FromHtml("#EAEAEA");
        }

        private void tLayoutPButtonSayfa_Paint(object sender, PaintEventArgs e)
        {
            tLayoutPButtonSayfa.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }
        private void tLayoutPSatisSayfaSol_Paint(object sender, PaintEventArgs e)
        {
            tLayoutPSatisSayfaSol.BackColor = ColorTranslator.FromHtml("#FFFFF");

        }
        private void tLayoutPSatisEkrani_Paint(object sender, PaintEventArgs e)
        {
            tLayoutPSatisEkrani.BackColor = ColorTranslator.FromHtml("#FFFFF");

        }
        // buttonlarýn font ayarlarý
        private void LoginNew_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            PrivateFontCollection pfc = new PrivateFontCollection();

            // Font dosyasýný yükleme
            string fontFilePath = Path.Combine(Application.StartupPath, @"Resources\Inter-VariableFont_opsz,wght.ttf");
            if (File.Exists(fontFilePath))
            {
                pfc.AddFontFile(fontFilePath);
                Font customFont = new Font(pfc.Families[0], 20, FontStyle.Bold);

                // Tüm butonlar için yazý tipini ayarla
                ApplyFont(this, customFont);
            }
            else
            {
                MessageBox.Show("Font dosyasý bulunamadý. Lütfen font dosyasýnýn doðru yerde olduðundan emin olun.");
            }
        }

        // Alt kontroller dahil tüm yazý tiplerini uygular
        private void ApplyFont(Control parent, Font font)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    btn.Font = font; // Button'lara özel yazý tipi uygula
                }

                // Eðer kontrolün alt kontrolleri varsa onlarý da kontrol et
                if (c.Controls.Count > 0)
                {
                    ApplyFont(c, font);
                }
            }
        }


        private void btnSatis_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageSatis;

            //font renk deðiþimi
            btnSatis.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");


            // Sadece Satýþ için olan PictureBox'larý göster
            pBoxSecilmisSatis.Visible = true;
            pBoxSecilmemisSatis.Visible = false;

            // Diðer sekmelere ait PictureBox'larý gizle
            pBoxSecilmisUrun.Visible = false;
            pBoxSecilmemisUrun.Visible = true;

            pBoxSecilmemisGecmis.Visible = true;
            pBoxSecilmisGecmis.Visible = false;

            pBoxSecilmemisStok.Visible = true;
            pBoxSecilmisStok.Visible = false;

            pBoxSecilmemisIstatistik.Visible = true;
            pBoxSecilmisIstatistik.Visible = false;
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageUrun;

            //font renk deðiþimi
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece Ürün için olan PictureBox'larý göster
            pBoxSecilmisUrun.Visible = true;
            pBoxSecilmemisUrun.Visible = false;

            // Diðer sekmelere ait PictureBox'larý gizle
            pBoxSecilmisSatis.Visible = false;
            pBoxSecilmemisSatis.Visible = true;

            pBoxSecilmemisGecmis.Visible = true;
            pBoxSecilmisGecmis.Visible = false;

            pBoxSecilmemisStok.Visible = true;
            pBoxSecilmisStok.Visible = false;

            pBoxSecilmemisIstatistik.Visible = true;
            pBoxSecilmisIstatistik.Visible = false;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageStok;

            //font renk deðiþimi
            btnStok.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece Stok için olan PictureBox'larý göster
            pBoxSecilmisStok.Visible = true;
            pBoxSecilmemisStok.Visible = false;

            // Diðer sekmelere ait PictureBox'larý gizle
            pBoxSecilmisSatis.Visible = false;
            pBoxSecilmemisSatis.Visible = true;

            pBoxSecilmisUrun.Visible = false;
            pBoxSecilmemisUrun.Visible = true;

            pBoxSecilmemisGecmis.Visible = true;
            pBoxSecilmisGecmis.Visible = false;

            pBoxSecilmemisIstatistik.Visible = true;
            pBoxSecilmisIstatistik.Visible = false;
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageGecmis;

            //font renk deðiþimi
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece Geçmiþ için olan PictureBox'larý göster
            pBoxSecilmisGecmis.Visible = true;
            pBoxSecilmemisGecmis.Visible = false;

            // Diðer sekmelere ait PictureBox'larý gizle
            pBoxSecilmisSatis.Visible = false;
            pBoxSecilmemisSatis.Visible = true;

            pBoxSecilmisUrun.Visible = false;
            pBoxSecilmemisUrun.Visible = true;

            pBoxSecilmemisStok.Visible = true;
            pBoxSecilmisStok.Visible = false;

            pBoxSecilmemisIstatistik.Visible = true;
            pBoxSecilmisIstatistik.Visible = false;
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageIstatistik;

            //font renk deðiþimi
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece Ýstatistik için olan PictureBox'larý göster
            pBoxSecilmisIstatistik.Visible = true;
            pBoxSecilmemisIstatistik.Visible = false;

            // Diðer sekmelere ait PictureBox'larý gizle
            pBoxSecilmisSatis.Visible = false;
            pBoxSecilmemisSatis.Visible = true;

            pBoxSecilmisUrun.Visible = false;
            pBoxSecilmemisUrun.Visible = true;

            pBoxSecilmemisStok.Visible = true;
            pBoxSecilmisStok.Visible = false;

            pBoxSecilmemisGecmis.Visible = true;
            pBoxSecilmisGecmis.Visible = false;
        }



        private void btnIleri_Click(object sender, EventArgs e)
        {
            Istatistik2 istatistik2 = new Istatistik2();
            istatistik2.Show();


        }

        private void btnZamEkle_Click(object sender, EventArgs e)
        {
            ZamEkrani zamekrani = new ZamEkrani();
            zamekrani.Show();
        }

        
    }
}
