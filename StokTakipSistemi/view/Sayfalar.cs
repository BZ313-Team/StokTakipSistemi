using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using StokTakipSistemi.utils;
using Microsoft.Data.SqlClient;
using System.Data;
using StokTakipSistemi.controller;

namespace StokTakipSistemi
{
    public partial class Sayfalar : Form
    {
        UrunIslemleri urunIslemleri = new UrunIslemleri();
        SQLIslemleri sqlIslemleri = new SQLIslemleri();


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

        //Sayfalar Form
        public Sayfalar()
        {
            InitializeComponent();
            this.Resize += new EventHandler(tabControl1_Resize);

            ApplyRoundedCornersToPanel(pnlSatisbtn, 5);
            ApplyRoundedCornersToPanel(pnlUrunlerbtn, 5);
            ApplyRoundedCornersToPanel(pnlGecmisbtn, 5);
            ApplyRoundedCornersToPanel(pnlStokbtn, 5);
            ApplyRoundedCornersToPanel(pnlIstatistikbtn, 5);

            ApplyRoundedCornersToPanel(pnlUrunEklebtn, 5);
            ApplyRoundedCornersToPanel(pnlUrunSilbtn, 5);
            ApplyRoundedCornersToPanel(pnlTemizlebtn, 5);
            ApplyRoundedCornersToPanel(pnlZamEklebtn, 5);



            //ComboBoxlarýn içinde günlük olarak baþlangýç atama

            //cmbBoxGecmisSFiltre.Text = "Günlük";
            //products.Text = "Günlük";
            //cmbBoxFiltre2.Text = "Günlük";

            cmbBoxGecmisSFiltre.ForeColor = ColorTranslator.FromHtml("#80818B");
            products.ForeColor = ColorTranslator.FromHtml("#80818B");
            cmbBoxFiltre2.ForeColor = ColorTranslator.FromHtml("#80818B");


            // Fontu tüm kontrolleri için uygulamak:
            string fontFamilyName = "Inter"; // Kendi font isminizi buraya yazýn
            float fontSize = 10; // Ýstediðiniz font boyutunu buraya yazýn

            // Utility sýnýfýndan font uygulama metodunu çaðýrýn
            FontUtility.ApplyCustomFontToAllControls(this, fontFamilyName, fontSize);
            btnDEL.Font = new Font(btnUrunler.Font.FontFamily, 9f);
            lblTutar.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            //lblBileme.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            //lblIndirimTL.Font = new Font(btnUrunler.Font.FontFamily, 11f);
            //lblIndirimYuzde.Font = new Font(btnUrunler.Font.FontFamily, 11f);
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
              btnUrunGuncelle.Width,
              btnUrunGuncelle.Height,
              5,
              5));

            btnZamEkle.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnZamEkle.Width,
              btnZamEkle.Height,
              5,
              5));

            btnSonraki.Region = Region.FromHrgn(CreateRoundRectRgn(
          0,
          0,
          btnSonraki.Width,
          btnSonraki.Height,
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
            btnUrunGuncelle.BackColor = ColorTranslator.FromHtml("#005EFC");
            btnUrunGuncelle.ForeColor = ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            btnSonraki.BackColor = ColorTranslator.FromHtml("#005EFC");
            btnSonraki.ForeColor = ForeColor = ColorTranslator.FromHtml("#FFFFFF");


            List<String> distinctCategories = new StatisticController().getDistinctCategories();
            foreach (var item in distinctCategories) products.Items.Add(item);

            if(products.Items.Count > 0) products.SelectedIndex = 0;
            grafikOpsiyon.SelectedIndex = 0;

            resetChart();
        }

        private void resetChart()
        {
            String selectedOption = grafikOpsiyon.GetItemText(grafikOpsiyon.SelectedItem);

            if (selectedOption == "Haftalýk Ciro" || selectedOption == "Haftalýk Satýlan Urun")
            {
                setWeeklyChart();
            }
            else
            {
                setMonthlyChart();
            }
        }

        private void setMonthlyChart()
        {
            chartUrunBazindaSatis.Series.Clear();

            DateTime today = DateTime.Now;
            List<DateTime> columnLabels = new List<DateTime>();

            for (int i = 0; i < 12; i++)
            {
                columnLabels.Add(today.AddDays(-i));
            }

            for (int i = 0; i < 12; i++)
            {
                var date = columnLabels[i];
                var series = new Series
                {
                    Name = date.Day + " / " + date.Month + " / " + date.Year,
                    ChartType = SeriesChartType.Column
                };

                chartUrunBazindaSatis.Series.Add(series);
            }
            String selectedCategory = products.GetItemText(products.SelectedItem);
            String selectedOption = grafikOpsiyon.GetItemText(grafikOpsiyon.SelectedItem);

            if (selectedOption == "Aylýk Ciro")
            {
                for (int i = 0; i < 12; i++)
                {
                    double sum = new StatisticController().getMonthSalesData(-i, selectedCategory).getSumOfSalesPrices();
                    chartUrunBazindaSatis.Series[i].Points.AddXY(i.ToString(), sum);
                }
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    double sum = new StatisticController().getMonthSalesData(-i, selectedCategory).getSumOfSalesQuantity();
                    chartUrunBazindaSatis.Series[i].Points.AddXY(i.ToString(), sum);
                }
            }
        }

        private void setWeeklyChart()
        {
            chartUrunBazindaSatis.Series.Clear();

            DateTime today = DateTime.Now;
            List<DateTime> columnLabels = new List<DateTime>();

            for (int i = 0; i < 7; i++)
            {
                columnLabels.Add(today.AddDays(-i));
            }

            for (int i = 0; i < 7; i++)
            {
                var date = columnLabels[i];
                var series = new Series
                {
                    Name = date.Day + " / " + date.Month + " / " + date.Year,
                    ChartType = SeriesChartType.Column
                };

                chartUrunBazindaSatis.Series.Add(series);
            }

            String selectedCategory = products.GetItemText(products.SelectedItem);
            String selectedOption = grafikOpsiyon.GetItemText(grafikOpsiyon.SelectedItem);

            if (selectedOption == "Haftalýk Ciro")
            {

                for (int i = 0; i < 7; i++)
                {
                    double sum = new StatisticController().getDaySalesData(-i, selectedCategory).getSumOfSalesPrices();
                    chartUrunBazindaSatis.Series[i].Points.AddXY(i.ToString(), sum);
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    double sum = new StatisticController().getDaySalesData(-i, selectedCategory).getSumOfSalesQuantity();
                    chartUrunBazindaSatis.Series[i].Points.AddXY(i.ToString(), sum);
                }
            }
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

        // Sayfalar_Load ile alakalý kodlar
        private void Sayfalar_Load(object sender, EventArgs e)
        {

            // program açýldýðýnda stok ekranýna bütün verileri getir ilk baþta
            urunIslemleri.urunleriCek(string.Empty, dataGViewStok);


            // istatistik ekraný için 
            panelUrunBazindaSatis.Visible = true;
            panelUrunKarOraný.Visible = false;
            panel1.Width = (int)(this.ClientSize.Width * 0.7);

            // burda bitiyor

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



            //zam ekle
            btnZamEkle.FlatStyle = FlatStyle.Flat;
            btnZamEkle.FlatAppearance.BorderSize = 3; // Kenarlýk kalýnlýðý
            btnZamEkle.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#D8D8DA"); // Kenarlýk rengi
            btnZamEkle.BackColor = Color.White;



            //combobox'larýn bazýlarýna default deðer atama
            comboboxDefaultDegerAta();

            //combobox'larýn bazýlarýna tag atýyoruz
            comboboxTagAta();

            textBoxTagAta();

            grafikOpsiyon.Tag = "Mod seçiniz";
            products.Tag = "Ürün Seçiniz";

            //combobox'lara týklandýgýnda içinin boþaltýlmasý
            tiklandigindaSil();

            dataGViewStok.DefaultCellStyle.ForeColor = Color.Black; // Yazý rengi
            dataGViewStok.DefaultCellStyle.BackColor = Color.White; // Arka plan
            dataGViewStok.RowsDefaultCellStyle.BackColor = Color.White;
            dataGViewStok.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Alternatif satýr rengi

            this.BeginInvoke((Action)delegate
            {
                tabControl1.SelectedTab = tabPageSatis; // tabPageSatis sekmesine geçiþ yaptýk
                textBoxBarkodGorunmez.Focus(); // Ardýndan textBoxBileme'ye odaklandýk
            });

        }

        //combobox'lara default deðer atayan fonksiyon
        private void comboboxDefaultDegerAta()
        {
            cmbBoxGenelK.Text = "Genel Kategori";
            cmbBoxUrunK.Text = "Ürün Kategorisi";
            cmbBoxFirmaAdi.Text = "Firma Adý";
            cmbBoxUrunTipi.Text = "Ürün Tipi";
            cmbBoxUrunModeli.Text = "Ürün Modeli";
            cmbBoxBoyut.Text = "Boyut";
            cmbBoxMensei.Text = "Mensei";
        }

        private void comboboxTagAta()
        {
            cmbBoxGenelK.Tag = "Genel Kategori";
            cmbBoxUrunK.Tag = "Ürün Kategorisi";
            cmbBoxFirmaAdi.Tag = "Firma Adý";
            cmbBoxUrunTipi.Tag = "Ürün Tipi";
            cmbBoxUrunModeli.Tag = "Ürün Modeli";
            cmbBoxBoyut.Tag = "Boyut";
            cmbBoxMensei.Tag = "Mensei";
        }

        private void textBoxTagAta()
        {
            txtBoxUBarkodu.Tag = "Ürün Barkodu";
            txtBoxUAdi.Tag = "Ürün Adý";
            cmbBoxAlisFiyati.Tag = "Alýþ Fiyatý";
            cmbBoxSatisFiyati.Tag = "Satýþ Fiyatý";
            txtBoxStok.Tag = "Stok";
            txtBoxMarka.Tag = "Marka";
            mtxtBoxGTarihi.Tag = "Ürün Giriþ Tarihi";
        }

        //combobox'a týklandýðýnda default veriyi silen veya geri getiren fonksiyon
        private void tiklandigindaSil()
        {
            cmbBoxGenelK.Enter += new EventHandler(ComboBoxDefaultVeriyiSil);
            cmbBoxGenelK.Leave += new EventHandler(ComboBoxDefaultVeriyiYukle);

            cmbBoxUrunK.Enter += new EventHandler(ComboBoxDefaultVeriyiSil);
            cmbBoxUrunK.Leave += new EventHandler(ComboBoxDefaultVeriyiYukle);

            cmbBoxFirmaAdi.Enter += new EventHandler(ComboBoxDefaultVeriyiSil);
            cmbBoxFirmaAdi.Leave += new EventHandler(ComboBoxDefaultVeriyiYukle);

            cmbBoxUrunTipi.Enter += new EventHandler(ComboBoxDefaultVeriyiSil);
            cmbBoxUrunTipi.Leave += new EventHandler(ComboBoxDefaultVeriyiYukle);

            cmbBoxUrunModeli.Enter += new EventHandler(ComboBoxDefaultVeriyiSil);
            cmbBoxUrunModeli.Leave += new EventHandler(ComboBoxDefaultVeriyiYukle);

            cmbBoxBoyut.Enter += new EventHandler(ComboBoxDefaultVeriyiSil);
            cmbBoxBoyut.Leave += new EventHandler(ComboBoxDefaultVeriyiYukle);

            cmbBoxMensei.Enter += new EventHandler(ComboBoxDefaultVeriyiSil);
            cmbBoxMensei.Leave += new EventHandler(ComboBoxDefaultVeriyiYukle);
        }

        //combobox'a týklandýðýnda default veriyi silen fonksiyon
        private void ComboBoxDefaultVeriyiSil(object? sender, EventArgs e)
        {
            // sender'ýn null olmadýðýný garanti etmemiz lazým yoksa uyarý veriyor
            if (sender is ComboBox cmbBox)
            {
                // ComboBox'ýn metni belirli bir deðere sahipse ve öðeleri yoksa, metni temizle
                if (cmbBox.Items.Count == 0 &&
                    (cmbBox.Text == "Genel Kategori" ||
                    cmbBox.Text == "Ürün Kategorisi" ||
                    cmbBox.Text == "Firma Adý" ||
                    cmbBox.Text == "Ürün Tipi" ||
                    cmbBox.Text == "Ürün Modeli" ||
                    cmbBox.Text == "Boyut" ||
                    cmbBox.Text == "Mensei"))
                {
                    cmbBox.Text = "";
                }
            }
        }

        //combobox'a týklandýðýnda default veriyi geri getiren fonksiyon
        private void ComboBoxDefaultVeriyiYukle(object? sender, EventArgs e)
        {
            // sender'ýn null olmadýðýný garanti etmemiz lazým yoksa uyarý veriyor
            if (sender is ComboBox cmbBox)
            {
                if (cmbBox.Items.Count == 0 && string.IsNullOrWhiteSpace(cmbBox.Text))
                {
                    if (cmbBox == cmbBoxGenelK) cmbBox.Text = "Genel Kategori";
                    else if (cmbBox == cmbBoxUrunK) cmbBox.Text = "Ürün Kategorisi";
                    else if (cmbBox == cmbBoxFirmaAdi) cmbBox.Text = "Firma Adý";
                    else if (cmbBox == cmbBoxUrunTipi) cmbBox.Text = "Ürün Tipi";
                    else if (cmbBox == cmbBoxUrunModeli) cmbBox.Text = "Ürün Modeli";
                    else if (cmbBox == cmbBoxBoyut) cmbBox.Text = "Boyut";
                    else if (cmbBox == cmbBoxMensei) cmbBox.Text = "Mensei";
                }
            }
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


        // btnSatis_Click içindeki iþlevler
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

        //btnUrunler_Click içindeki iþlevler
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

        //btnStok_Click içindeki iþlevler
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

        //btnGecmis_Click içindeki iþlevler
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

        //btnIstatistik_Click içindeki iþlevler
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

        //btnZamEkle_Click içindeki iþlevler
        private void btnZamEkle_Click(object sender, EventArgs e)
        {
            ZamEkrani zamekrani = new ZamEkrani();
            zamekrani.Show();
        }

        //btnUrunEkle_Click içindeki iþlevler
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            UrunIslemleri urunIslemleri = new UrunIslemleri();

            TextBox[] textBoxBosMu = { cmbBoxAlisFiyati, cmbBoxSatisFiyati, txtBoxUBarkodu, txtBoxUAdi, txtBoxStok, txtBoxMarka };
            ComboBox[] comboBoxBosMu = { cmbBoxBoyut, cmbBoxGenelK, cmbBoxUrunK, cmbBoxFirmaAdi, cmbBoxUrunTipi, cmbBoxUrunModeli, cmbBoxMensei };

            urunIslemleri.urunEkle(txtBoxUBarkodu, txtBoxUAdi, cmbBoxGenelK, cmbBoxUrunK, cmbBoxFirmaAdi, cmbBoxUrunTipi, cmbBoxUrunModeli,
            cmbBoxBoyut, cmbBoxMensei, cmbBoxAlisFiyati, cmbBoxSatisFiyati, mtxtBoxGTarihi, txtBoxMarka, txtBoxStok, textBoxBosMu,
            comboBoxBosMu);

        }


        // ürün eklendikten sonra eklenen verilerin ayný zamanda combobox'lara eklenmesi için fonksiyon
        public void urunEkleArayuzGuncelle(string GenelKategori, string urunKategori, string firmaAdi, string urunTipi,
                                           string urunModeli, string urunBoyut, string urunMensei)
        {
            cmbBoxGenelK.Items.Add(GenelKategori);
            cmbBoxUrunK.Items.Add(urunKategori);
            cmbBoxFirmaAdi.Items.Add(firmaAdi);
            cmbBoxUrunTipi.Items.Add(urunTipi);
            cmbBoxUrunModeli.Items.Add(urunModeli);
            cmbBoxBoyut.Items.Add(urunBoyut);
            cmbBoxMensei.Items.Add(urunMensei);
        }

        //Sayfalar_FormClosed fonksiyonu içindeki iþlevler, yani sayfalar kapandýktan sonra yapýlacak fonksiyonlar burada
        private void Sayfalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Sayfalar_FormClosing fonksiyonu içindeki iþlevler, yani sayfalar kapanýrken sonra yapýlacak fonksiyonlar burada
        private void Sayfalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //btnUrunSil_Click fonksiyonu içindeki iþlevler
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            UrunIslemleri urunIslemleri = new UrunIslemleri();

            //urunIslemleri.urunSil(txtBoxUBarkodu.Text);
        }

        //btnTemizle_Click fonksiyonu içindeki iþlevler
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBoxUBarkodu.Clear();
            txtBoxUAdi.Clear();
            cmbBoxGenelK.SelectedIndex = 0;
            cmbBoxUrunK.SelectedIndex = 0;
            cmbBoxFirmaAdi.SelectedIndex = 0;
            cmbBoxUrunTipi.SelectedIndex = 0;
            cmbBoxUrunModeli.SelectedIndex = 0;
            cmbBoxBoyut.SelectedIndex = 0;
            cmbBoxMensei.SelectedIndex = 0;
            cmbBoxAlisFiyati.Clear();
            cmbBoxSatisFiyati.Clear();
            txtBoxStok.Clear();
            txtBoxMarka.Clear();
            mtxtBoxGTarihi.Clear();

        }

        //btnUrunGuncelle_Click fonksiyonu içindeki iþlevler
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGViewStok.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dataGViewStok.SelectedRows[0];
                string urunID = selectedRow.Cells["UrunID"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(urunID))
                {
                    MessageBox.Show("Seçilen ürünün ID bilgisi bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SQLIslemleri sqlIslemleri = new SQLIslemleri();
                string baglanti = sqlIslemleri.GetBaglanti();
                string query = @"
            SELECT Urun.UrunBarkod, Urun.UrunAd, Urun.UrunGKategori, Urun.UrunKategori, 
                   Urun.UrunUreticiFirma, Urun.UrunTip, Urun.UrunModel, Urun.UrunBoyut, 
                   Urun.UrunMensei, Urun.UrunFiyatAlis, Urun.UrunFiyatSatis, Urun.UrunMarka, 
                   Stok.StokMiktar 
            FROM Urun 
            JOIN Stok ON Urun.UrunID = Stok.UrunID 
            WHERE Urun.UrunID = @UrunID";

                using (SqlConnection connection = new SqlConnection(baglanti))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UrunID", urunID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // SQL'den gelen deðerleri string olarak al
                                string urunBarkodu = reader["UrunBarkod"].ToString();
                                string urunAdi = reader["UrunAd"].ToString();
                                string urunGKategori = reader["UrunGKategori"].ToString();
                                string urunKategori = reader["UrunKategori"].ToString();
                                string urunFirma = reader["UrunUreticiFirma"].ToString();
                                string urunTip = reader["UrunTip"].ToString();
                                string urunModel = reader["UrunModel"].ToString();
                                string urunBoyut = reader["UrunBoyut"].ToString();
                                string urunMensei = reader["UrunMensei"].ToString();
                                string urunFiyatAlis = reader["UrunFiyatAlis"].ToString();
                                string urunFiyatSatis = reader["UrunFiyatSatis"].ToString();
                                string urunStok = reader["StokMiktar"].ToString();
                                string urunMarka = reader["UrunMarka"].ToString();

                                // Guncelle sýnýfýný aç ve verileri gönder
                                Guncelle guncellemeForm = new Guncelle();
                                guncellemeForm.setTxtCmb(
                                    urunID,
                                    urunBarkodu,
                                    urunAdi,
                                    urunGKategori,
                                    urunKategori,
                                    urunFirma,
                                    urunTip,
                                    urunModel,
                                    urunBoyut,
                                    urunMensei,
                                    urunFiyatAlis,
                                    urunFiyatSatis,
                                    urunStok,
                                    urunMarka
                                );

                                guncellemeForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Seçilen ürüne ait bilgiler bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //btnSonraki_Click fonksiyonu içindeki iþlevler
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true && panelUrunBazindaSatis.Visible == true)
            {
                panel1.Visible = false;
                panelUrunBazindaSatis.Visible = false;
                panel2.Visible = true;
                panelUrunKarOraný.Visible = true;
            }
            else if (panel2.Visible == true && panelUrunKarOraný.Visible == true)
            {
                panel1.Visible = true;
                panelUrunBazindaSatis.Visible = true;
                panel2.Visible = false;
                panelUrunKarOraný.Visible = false;
            }
        }

        //Pencere büyüdüðünde onunla orantýlý þekilde istatistik ekranýnýn da büyümesi ile alakalý kodlar tabControll_Resize
        private void tabControl1_Resize(object sender, EventArgs e)
        {
            TabPage tabistatistikPage = tabControl1.TabPages["tabPageIstatistik"]; // tabIstatistik yerine sizin tab page isminizi yazýn

            if (this.WindowState == FormWindowState.Maximized)
            {
                // Tam ekran durumunda panelleri daha geniþ yap
                panelUrunBazindaSatis.Width = (int)(tabistatistikPage.Width * 0.9);
                panelUrunKarOraný.Width = (int)(tabistatistikPage.Width * 0.9);
            }
            else
            {
                panelUrunBazindaSatis.Width = tabistatistikPage.Width / 2;
                panelUrunKarOraný.Width = tabistatistikPage.Width / 2;
            }
        }

        //Stok ekranýndaki txtBoxStokSFiltre textbox'u her deðiþtiðinde çalýþacak fonksiyon
        private void txtBoxStokSFiltre_TextChanged(object sender, EventArgs e)
        {
            UrunIslemleri urunIslemleri = new UrunIslemleri();

            urunIslemleri.urunleriCek(txtBoxStokSFiltre.Text, dataGViewStok);
        }

        private void textBoxBarkodGorunmez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxBarkodGorunmez.Text.Length < 13)
            {
                textBoxBarkodGorunmez.Text += e.KeyChar;
            }

            foreach (char c in textBoxBarkodGorunmez.Text)
            {
                if (!char.IsDigit(c))
                {
                    textBoxBarkodGorunmez.Clear();
                    textBoxBarkodGorunmez.Focus();
                    return;
                }
            }

            // Barkod verisi tamamlandýktan sonra iþlem yapýn
            if (textBoxBarkodGorunmez.Text.Length == 13)
            {

                urunIslemleri.urunuSatisEkraninaTasi(textBoxBarkodGorunmez.Text, listViewSatisEkrani, textBoxBarkodGorunmez,
                    txtBoxTutar, txtBoxToplamTutar);
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            SatisTamamla satisTamamla = new SatisTamamla();
            satisTamamla.Show();

            satisTamamla.verileriYukle(txtBoxToplamTutar.Text, listViewSatisEkrani, txtBoxTutar, txtBoxToplamTutar, textBoxBarkodGorunmez);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageSatis)
                textBoxBarkodGorunmez.Focus();
        }

        private void satisiIptalEtButon_Click(object sender, EventArgs e)
        {
            urunIslemleri.satisEkraniVeriTemizle(txtBoxTutar, txtBoxToplamTutar, textBoxBarkodGorunmez, listViewSatisEkrani);
        }

        private void grafikOpsiyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetChart();
        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetChart();
        }
    }
}
