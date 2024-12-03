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

            //Buttonlarýn kenar kývrýmý deðiþimi
            btnSatis.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnSatis.Width,
              btnSatis.Height,
              5,
              5));

            btnUrun.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnUrun.Width,
              btnUrun.Height,
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

            // Buttonlarýn renk deðiþmi
            btnSatis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnUrun.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnStok.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnGecmis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnIstatistik.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnSatisYap.BackColor = ColorTranslator.FromHtml("#F8F8FA");




            // Chartýn gözükmesi için ürün eklenmesi gerekiyor Ürün ekleme denemesi 
            chartSatis.Series[0].Points.Clear(); // Mevcut verileri temizler
            chartSatis.Series[0].Points.AddXY("Kategori 1", 40);
            chartSatis.Series[0].Points.AddXY("Kategori 2", 30);


        }

        private void Sayfalar_Load(object sender, EventArgs e)
        {
            int xPosition = 150; // Yatay (X) pozisyonu
            int yPosition = 175;  // Dikey (Y) pozisyonu

            // Formun baþlangýç pozisyonunu elle ayarlayýn
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);
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

                // Buttonlarýn FlatStyle ve diðer özelliklerini ayarlayýn
                foreach (Control c in this.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.FlatStyle = FlatStyle.Flat; // Flat style için ayar yap
                        btn.FlatAppearance.BorderSize = 0; // Kenarlýk görünmesin
                        btn.Font = customFont; // Fontu uygula
                        btn.BackColor = ColorTranslator.FromHtml("#F8F8FA"); // Arka plan rengini ayarla
                    }
                }
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


        private void btnSatis_Click(object sender, EventArgs e) => tabControl1.SelectedTab = tabPageSatis;

        private void btnUrun_Click(object sender, EventArgs e) => tabControl1.SelectedTab = tabPageUrun;

        private void btnStok_Click(object sender, EventArgs e) => tabControl1.SelectedTab = tabPageStok;

        private void btnGecmis_Click(object sender, EventArgs e) => tabControl1.SelectedTab = tabPageGecmis;

        private void btnIstatistik_Click(object sender, EventArgs e) => tabControl1.SelectedTab = tabPageIstatistik;



        private void btnIleri_Click(object sender, EventArgs e)
        {
            Istatistik2 istatistik2 = new Istatistik2();
            istatistik2.Show();
            

        }

        
    }
}
