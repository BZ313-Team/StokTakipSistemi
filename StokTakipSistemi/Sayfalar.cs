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

            cmbBoxUrunSFiltre.Text = "G�nl�k";
            cmbBoxStokSFiltre.Text = "G�nl�k";
            cmbBoxGecmisSFiltre.Text = "G�nl�k";
            cmbBoxIstFiltre.Text = "G�nl�k";

            cmbBoxUrunSFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");
            cmbBoxStokSFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");
            cmbBoxGecmisSFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");
            cmbBoxIstFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Fontu t�m kontrolleri i�in uygulamak:
            string fontFamilyName = "Inter"; // Kendi font isminizi buraya yaz�n
            float fontSize = 10; // �stedi�iniz font boyutunu buraya yaz�n

            // Utility s�n�f�ndan font uygulama metodunu �a��r�n
            FontUtility.ApplyCustomFontToAllControls(this, fontFamilyName, fontSize);
            btnDEL.Font = new Font(btnUrunler.Font.FontFamily, 9f);
            lblTutar.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblBileme.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblIndirimTL.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblIndirimYuzde.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            lblToplamTutar.Font = new Font(btnUrunler.Font.FontFamily, 11f);

            //Buttonlar�n kenar k�vr�m� de�i�imi
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
            // panellerin renk de�i�imi
            pnlSatisbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlUrunlerbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlGecmisbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlStokbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            pnlIstatistikbtn.BackColor = ColorTranslator.FromHtml("#F8F8FA");


            // Buttonlar�n renk de�i�mi
            btnSatis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnUrunler.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnStok.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnGecmis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnIstatistik.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnSatisYap.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnSatisYap.BackColor = ColorTranslator.FromHtml("#005EFC");
            btnSatisYap.ForeColor = ColorTranslator.FromHtml("#FFFFFF");



            // Chart�n g�z�kmesi i�in �r�n eklenmesi gerekiyor �r�n ekleme denemesi silinecek
            chartSatis.Series[0].Points.Clear(); // Mevcut verileri temizler
            chartSatis.Series[0].Points.AddXY("Kategori 1", 40);
            chartSatis.Series[0].Points.AddXY("Kategori 2", 30);


        }

        // Panel kenarlar�n� k�v�rmak i�in kullan�lacak metod
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

            // Formun ba�lang�� pozisyonunu elle ayarlay�n
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);


            // Formun ba�lang�� pozisyonunu elle ayarlay�n
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);

            //urun ekle butonu
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.FlatAppearance.BorderSize = 3; // Kenarl�k kal�nl���
            btnUrunEkle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarl�k rengi
            btnUrunEkle.BackColor = Color.White;

            //urun sil butonu
            btnUrunSil.FlatStyle = FlatStyle.Flat;
            btnUrunSil.FlatAppearance.BorderSize = 3; // Kenarl�k kal�nl���
            btnUrunSil.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarl�k rengi
            btnUrunSil.BackColor = Color.White;

            //temizle butonu
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.FlatAppearance.BorderSize = 3; // Kenarl�k kal�nl���
            btnTemizle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarl�k rengi
            btnTemizle.BackColor = Color.White;

            //�r�n g�ncelle
            btnUrunGuncelle.FlatStyle = FlatStyle.Flat;
            btnUrunGuncelle.FlatAppearance.BorderSize = 3; // Kenarl�k kal�nl���
            btnUrunGuncelle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarl�k rengi
            btnUrunGuncelle.BackColor = Color.White;

            //zam ekle
            btnZamEkle.FlatStyle = FlatStyle.Flat;
            btnZamEkle.FlatAppearance.BorderSize = 3; // Kenarl�k kal�nl���
            btnZamEkle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarl�k rengi
            btnZamEkle.BackColor = Color.White;

            //ileri butonu
            btnIleri.FlatStyle = FlatStyle.Flat;
            btnIleri.FlatAppearance.BorderSize = 2; // Kenarl�k kal�nl���
            btnIleri.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarl�k rengi
            btnIleri.BackColor = Color.White;

        }





        // buttonlar�n renk ayarlar�

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
        // buttonlar�n font ayarlar�
        private void LoginNew_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            PrivateFontCollection pfc = new PrivateFontCollection();

            // Font dosyas�n� y�kleme
            string fontFilePath = Path.Combine(Application.StartupPath, @"Resources\Inter-VariableFont_opsz,wght.ttf");
            if (File.Exists(fontFilePath))
            {
                pfc.AddFontFile(fontFilePath);
                Font customFont = new Font(pfc.Families[0], 20, FontStyle.Bold);

                // T�m butonlar i�in yaz� tipini ayarla
                ApplyFont(this, customFont);
            }
            else
            {
                MessageBox.Show("Font dosyas� bulunamad�. L�tfen font dosyas�n�n do�ru yerde oldu�undan emin olun.");
            }
        }

        // Alt kontroller dahil t�m yaz� tiplerini uygular
        private void ApplyFont(Control parent, Font font)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    btn.Font = font; // Button'lara �zel yaz� tipi uygula
                }

                // E�er kontrol�n alt kontrolleri varsa onlar� da kontrol et
                if (c.Controls.Count > 0)
                {
                    ApplyFont(c, font);
                }
            }
        }


        private void btnSatis_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageSatis;

            //font renk de�i�imi
            btnSatis.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");


            // Sadece Sat�� i�in olan PictureBox'lar� g�ster
            pBoxSecilmisSatis.Visible = true;
            pBoxSecilmemisSatis.Visible = false;

            // Di�er sekmelere ait PictureBox'lar� gizle
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

            //font renk de�i�imi
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece �r�n i�in olan PictureBox'lar� g�ster
            pBoxSecilmisUrun.Visible = true;
            pBoxSecilmemisUrun.Visible = false;

            // Di�er sekmelere ait PictureBox'lar� gizle
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

            //font renk de�i�imi
            btnStok.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece Stok i�in olan PictureBox'lar� g�ster
            pBoxSecilmisStok.Visible = true;
            pBoxSecilmemisStok.Visible = false;

            // Di�er sekmelere ait PictureBox'lar� gizle
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

            //font renk de�i�imi
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece Ge�mi� i�in olan PictureBox'lar� g�ster
            pBoxSecilmisGecmis.Visible = true;
            pBoxSecilmemisGecmis.Visible = false;

            // Di�er sekmelere ait PictureBox'lar� gizle
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

            //font renk de�i�imi
            btnIstatistik.ForeColor = ColorTranslator.FromHtml("#1D212E");
            btnSatis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnGecmis.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnStok.ForeColor = ColorTranslator.FromHtml("#80818B");
            btnUrunler.ForeColor = ColorTranslator.FromHtml("#80818B");

            // Sadece �statistik i�in olan PictureBox'lar� g�ster
            pBoxSecilmisIstatistik.Visible = true;
            pBoxSecilmemisIstatistik.Visible = false;

            // Di�er sekmelere ait PictureBox'lar� gizle
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
