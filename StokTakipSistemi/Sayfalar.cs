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
            btnDEL.Font = new Font(btnUrun.Font.FontFamily, 9f);
            lblTutar.Font = new Font(btnUrun.Font.FontFamily, 11f);
            lblBileme.Font = new Font(btnUrun.Font.FontFamily, 11f);
            lblIndirimTL.Font = new Font(btnUrun.Font.FontFamily, 11f);
            lblIndirimYuzde.Font = new Font(btnUrun.Font.FontFamily, 11f);
            lblToplamTutar.Font = new Font(btnUrun.Font.FontFamily, 11f);

            //Buttonlar�n kenar k�vr�m� de�i�imi
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


            btnSatisYap.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnSatisYap.Width,
              btnSatisYap.Height,
              5,
              5));





            // Buttonlar�n renk de�i�mi
            btnSatis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnUrun.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnStok.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnGecmis.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnIstatistik.BackColor = ColorTranslator.FromHtml("#F8F8FA");
            btnSatisYap.BackColor = ColorTranslator.FromHtml("#F8F8FA");

            btnSatisYap.BackColor = ColorTranslator.FromHtml("#005EFC");
            btnSatisYap.ForeColor = ColorTranslator.FromHtml("#FFFFFF");



            // Chart�n g�z�kmesi i�in �r�n eklenmesi gerekiyor �r�n ekleme denemesi 
            chartSatis.Series[0].Points.Clear(); // Mevcut verileri temizler
            chartSatis.Series[0].Points.AddXY("Kategori 1", 40);
            chartSatis.Series[0].Points.AddXY("Kategori 2", 30);


        }

        private void Sayfalar_Load(object sender, EventArgs e)
        {
            int xPosition = 150; // Yatay (X) pozisyonu
            int yPosition = 175;  // Dikey (Y) pozisyonu

            // Formun ba�lang�� pozisyonunu elle ayarlay�n
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);
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

                // Buttonlar�n FlatStyle ve di�er �zelliklerini ayarlay�n
                foreach (Control c in this.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.FlatStyle = FlatStyle.Flat; // Flat style i�in ayar yap
                        btn.FlatAppearance.BorderSize = 0; // Kenarl�k g�r�nmesin
                        btn.Font = customFont; // Fontu uygula
                        btn.BackColor = ColorTranslator.FromHtml("#F8F8FA"); // Arka plan rengini ayarla
                    }
                }
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
