using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using Microsoft.IdentityModel.Tokens;


namespace StokTakipSistemi
{
    internal class UrunIslemleri
    {
        
        SQLIslemleri sqlIslemleri = new SQLIslemleri();
        // ürün ekleme fonksiyonu
        public void urunEkle(TextBox urunBarkodTextBox, TextBox urunAdTextBox, ComboBox urunGKategoriComboBox, ComboBox urunKategoriComboBox, 
        ComboBox urunUreticiFirmaComboBox, ComboBox urunTipComboBox, ComboBox urunModelComboBox, ComboBox urunBoyutComboBox,
        ComboBox urunMenseiComboBox, TextBox urunFiyatAlisTextBox, TextBox urunFiyatSatisTextBox, MaskedTextBox urunGirisTarihiMaskedTextBox, 
        TextBox urunMarkaTextBox, TextBox urunStokMiktarTextBox, TextBox[] textBoxlarBosMu, ComboBox[] comboBoxlarBosMu)
        {
            SQLIslemleri sqlIslemleri = new SQLIslemleri();

            //MessageBox.Show("bosYerVarmi'ya girilecek");
            // Eğer bütün textbox ve combobox'lar doldurulmadıysa işlem iptal olacak.
            if (!bosYerVarMi(textBoxlarBosMu, comboBoxlarBosMu))
                return;

            //MessageBox.Show(" bosyerVarmi dan çıkıldı girilenVerilerDogrumu'ya girilecek");
            // Eğer girilen bütün veriler doğru değilse işlem iptal olacak.
            if (!girilenVerilerDogruMu(urunStokMiktarTextBox, urunBarkodTextBox, urunFiyatAlisTextBox, urunFiyatSatisTextBox, 
                urunBoyutComboBox, urunGirisTarihiMaskedTextBox))
                return;
            //MessageBox.Show("girilenVerilerDogrumudan çıkıldı dönüştürülme işlemi yapılacak");

            //eklemeyiYap fonksiyonuna doğru verileri girmek için gerekli parametreleri parametreleriDonustur fonksiyonunu ile dönüştürüyoruz
            var donusturulmusParametreler = parametreleriDonustur(urunBoyutComboBox.Text, urunFiyatAlisTextBox.Text,
                urunFiyatSatisTextBox.Text, urunGirisTarihiMaskedTextBox.Text, urunStokMiktarTextBox.Text);
            //MessageBox.Show("Dönüştürülme işlemi yapıldı eklemeYap fonksiyonuna girilecek");

            // eklenecek ürün ile aynı barkoda sahip ürün veritabanında var mı onu kontrol ediyoruz burada
            if(!urunVarMi(urunBarkodTextBox.Text))
            {
                MessageBox.Show("Aynı barkodda başka bir ürün zaten mevcut");
                return;
            }

            eklemeyiYap(urunBarkodTextBox.Text, urunAdTextBox.Text, urunGKategoriComboBox.Text, urunKategoriComboBox.Text,
            urunUreticiFirmaComboBox.Text, urunTipComboBox.Text, urunModelComboBox.Text, donusturulmusParametreler.Item1, urunMenseiComboBox.Text,
            donusturulmusParametreler.Item2, donusturulmusParametreler.Item3, donusturulmusParametreler.Item4, urunMarkaTextBox.Text,
            donusturulmusParametreler.Item5);

            //MessageBox.Show("EklemeyiYap fonksiyonundan çıkıldı ");
        }

        // ürün ekleme işlemini gerçekleştirecek asıl fonksiyon. urunEkle tarafından çağrılacak
        private void eklemeyiYap(string urunBarkod, string urunAd, string urunGKategori, string urunKategori, string urunUreticiFirma, string urunTip, 
        string urunModel, decimal urunBoyut, string urunMensei, float urunFiyatAlis, float urunFiyatSatis, DateTime urunGirisTarihi, 
        string urunMarka, int stokMiktar)
        {
            string baglanti = sqlIslemleri.GetBaglanti();


            // Ürün tablosuna ürün eklemek için gerekli sorgu
            string urunSorgu = sqlIslemleri.GetUrunSorguEklemeyiYap();

            // Stok tablosuna veri eklemek için gerekli sorgu
            string stokSorgu = sqlIslemleri.GetStokSorguEklemeyiYap();

            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction()) // Transaction başlatılıyor
                {
                    try
                    {

                        // Ürün ekleme işlemi
                        using (SqlCommand urunCommand = new SqlCommand(urunSorgu, connection, transaction))
                        {
                            // Ürün tablosu için parametreler
                            urunCommand.Parameters.AddWithValue("@UrunBarkod", urunBarkod);
                            urunCommand.Parameters.AddWithValue("@UrunAd", urunAd);
                            urunCommand.Parameters.AddWithValue("@UrunGKategori", urunGKategori);
                            urunCommand.Parameters.AddWithValue("@UrunKategori", urunKategori);
                            urunCommand.Parameters.AddWithValue("@UrunUreticiFirma", urunUreticiFirma);
                            urunCommand.Parameters.AddWithValue("@UrunTip", urunTip);
                            urunCommand.Parameters.AddWithValue("@UrunModel", urunModel);
                            urunCommand.Parameters.AddWithValue("@UrunBoyut", urunBoyut);
                            urunCommand.Parameters.AddWithValue("@UrunMensei", urunMensei);
                            urunCommand.Parameters.AddWithValue("@UrunFiyatAlis", urunFiyatAlis);
                            urunCommand.Parameters.AddWithValue("@UrunFiyatSatis", urunFiyatSatis);
                            urunCommand.Parameters.AddWithValue("@UrunGTarih", urunGirisTarihi);
                            urunCommand.Parameters.AddWithValue("@UrunMarka", urunMarka);

                            urunCommand.ExecuteNonQuery();
                        }

                        // Stok ekleme işlemi
                        using (SqlCommand stokCommand = new SqlCommand(stokSorgu, connection, transaction))
                        {
                            string stokDurum = stokMiktar > 0 ? "Mevcut" : "Mevcut Değil";
                            string stokTur = urunAd;
                            // Stok tablosu için parametreler
                            //stokCommand.Parameters.AddWithValue("@UrunID", urunID);
                            stokCommand.Parameters.AddWithValue("@StokDurum", stokDurum);
                            stokCommand.Parameters.AddWithValue("@StokTur", stokTur);
                            stokCommand.Parameters.AddWithValue("@StokMiktar", stokMiktar);

                            stokCommand.ExecuteNonQuery();
                        }

                        // Eğer işlemler başarılıysa transaction tamamlanır
                        transaction.Commit();
                        MessageBox.Show("Ürün başarıyla eklendi.");
                        return;
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda işlemler geri alınır
                        transaction.Rollback();
                        MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
                        return;
                    }
                }
            }
        }

        // ürün eklerken textbox ve combobox'ların dolu olup olmadığını kontrol eden fonksiyon. urunEkle tarafından çağrılacak
        private bool bosYerVarMi(TextBox[] textBoxlar, ComboBox[] comboBoxlar)
        {
            foreach (TextBox textBox in textBoxlar)
            {
                if (textBoxlarDoldurulduMu(textBox))
                {
                    MessageBox.Show($"{textBox.Tag} alanı boş bırakılamaz");
                    textBox.Focus();
                    return false;
                }
            }

            foreach (ComboBox comboBox in comboBoxlar)
            {
                if (comboBoxDoldurulduMu(comboBox))
                {
                    MessageBox.Show($"{comboBox.Tag} alanı boş bırakılamaz");
                    comboBox.Focus();
                    return false;
                }
            }

            return true;
        }

        // ürün eklerken kullanıcı bütün textbox'ları' doldurmuş mu onu kontrol eden fonksiyon. bosYerVarMi tarafından çağrılacak
        private bool textBoxlarDoldurulduMu(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        // ürün eklerken kullanıcı bütün combobox'ları' doldurmuş mu onu kontrol eden fonksiyon. bosYerVarMi tarafından çağrılacak
        private bool comboBoxDoldurulduMu(ComboBox comboBox)
        {
            string defaultText = comboBox.Tag as string;

            if (string.IsNullOrWhiteSpace(comboBox.Text) || comboBox.Text == defaultText)
                return true;
            else
                return false;
        }

        // Kullanıcının girdiği verilerin doğruluğunu kontrol eden fonksiyon.
        private bool girilenVerilerDogruMu(TextBox stokMiktarTextBox, TextBox urunBarkoduTextBox, TextBox urunAlisFiyatiTextBox, 
            TextBox urunSatisFiyatiTextBox, ComboBox urunBoyutComboBox, MaskedTextBox urunGirisTarihiMaskedTextBox)
        {
            int stokMiktarInt;
            float alisFiyatiFloat, satisFiyatiFloat;
            decimal urunBoyutDecimal;
            DateTime urunGirisTarihiDateTime;
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            string format = "dd.MM.yyyy";

            // textbox'dan gelen stok bilgisini int'e çevrilmezse kullanıcıya doğru veri girmesi için uyarı gönderdik
            if (!int.TryParse(stokMiktarTextBox.Text, out stokMiktarInt))
            {
                MessageBox.Show("Stok değeri yalnızca sayı olabilir");
                stokMiktarTextBox.Focus();
                return false;
            }

            // textbox'dan gelen ürün barkodu string değilse  kullanıcıya doğru veri girmesi için uyarı gönderdik
            foreach (char c in urunBarkoduTextBox.Text)
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Ürün barkodu yalnızca sayı olmalıdır");
                    urunBarkoduTextBox.Focus();
                    return false;
                }

            

            // textbox'dan gelen ürün barkodunun 8 haneli olup olmadığına baktık 8 haneli değilse kullanıcıya uyarı gönderdik
            if (urunBarkoduTextBox.Text.Length != 13)
            {
                MessageBox.Show("Ürün barkodu 13 haneli olmalıdır");
                urunBarkoduTextBox.Focus();
                return false;
            }

            // combobox'dan gelen alış fiyatını float'a çevrilmezse kullanıcıya doğru veri girmesi için uyarı gönderdik
            if (!float.TryParse(urunAlisFiyatiTextBox.Text, out alisFiyatiFloat))
            {
                MessageBox.Show("Alış fiyatı yalnızca sayı olabilir");
                urunAlisFiyatiTextBox.Focus();
                return false;
            }

            // combobox'dan gelen satış fiyatını float'a çevrilmezse kullanıcıya doğru veri girmesi için uyarı gönderdik
            if (!float.TryParse(urunSatisFiyatiTextBox.Text, out satisFiyatiFloat))
            {
                MessageBox.Show("Satış fiyatı yalnızca sayı olabilir");
                urunSatisFiyatiTextBox.Focus();
                return false;
            }

            // combobox'dan gelen ürün boyutunu decimal'e çevrilmezse kullanıcıya doğru veri girmesi için uyarı gönderdik
            if (!decimal.TryParse(urunBoyutComboBox.Text, out urunBoyutDecimal))
            {
                MessageBox.Show("Ürün boyutu yalnızca sayı olabilir.");
                urunBoyutComboBox.Focus();
                return false;
            }

            // maskedTextBox'dan gelen date bilgisi DateTime'a çevrilmezse kullanıcıya doğru veri girmesi için uyarı gönderdik
            if(!DateTime.TryParseExact(urunGirisTarihiMaskedTextBox.Text, format, cultureInfo, DateTimeStyles.None, out urunGirisTarihiDateTime))
            {
                MessageBox.Show("Geçerli bir ürün giriş tarihi girin.");
                urunGirisTarihiMaskedTextBox.Focus();
                return false;
            }

            // geçersiz bir tarih aralığı girdiği zaman kullanıcıya doğru tarih girmesi için uyarı gönderilecek.


            // kullanıcı ürün giriş tarihini tam yazamadıysa kullanıcıya doğru veri girmesi için uyarı gönderiyoruz.
            if(urunGirisTarihiMaskedTextBox.Text.Contains("_"))
            {
                MessageBox.Show("Ürün tarihini boşluk bırakmadan eksiksiz girin.");
                urunGirisTarihiMaskedTextBox.Focus();
                return false;
            }

            return true;

        }

        // urunEkle fonksiyonu içine eklemeYap fonksiyonuna gönderilecek parametreleri dönüştürmek için kullanılan fonksiyon
        private (decimal, float, float, DateTime, int) parametreleriDonustur(string urunBoyutString, 
            string urunFiyatAlisString, string urunFiyatSatisString, string urunGirisTarihiString, string urunStokMiktarString)
        {
            decimal donusturulmusUrunBoyut = decimal.Parse(urunBoyutString);
            float donusturulmusUrunFiyatAlis = float.Parse(urunFiyatAlisString);
            float donusturulmusUrunFiyatSatis = float.Parse(urunFiyatSatisString);
            DateTime donusturulmusUrunGirisTarihi = DateTime.Parse(urunGirisTarihiString);
            int donusturulmusStokMiktar = int.Parse(urunStokMiktarString);

            return(donusturulmusUrunBoyut, donusturulmusUrunFiyatAlis, donusturulmusUrunFiyatSatis,
                   donusturulmusUrunGirisTarihi, donusturulmusStokMiktar);

        }

        // ürün silme fonksiyonu
        public void urunSil(string urunBarkod)
        {
            string baglanti = sqlIslemleri.GetBaglanti();
            string sorgu = sqlIslemleri.GetSorguUrunSil();
            string kontrolSorgu = sqlIslemleri.GetKontrolSorguUrunSil();

            using (SqlConnection connection = new SqlConnection(baglanti))
                using(SqlCommand command =  new SqlCommand(sorgu, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@UrunBarkod", urunBarkod);

                    connection.Open();

                    SqlCommand kontrolCommand = new SqlCommand(kontrolSorgu, connection);  // bu blokta gerçekten öyle bir ürün var mı diye
                    kontrolCommand.Parameters.AddWithValue("@UrunBarkod", urunBarkod);    // kontrol ediyoruz
                    int urunSayisi = (int)kontrolCommand.ExecuteScalar();                //

                    if(urunSayisi  == 0 )
                    {
                        MessageBox.Show("Bu barkoda sahip bir ürün mevcut değil");
                        return;
                    }

                    command.ExecuteNonQuery();

                    MessageBox.Show("Ürün başarıyla silindi");
                }
                catch(Exception)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu");
                }
            }
        }

        // aynı barkodlu ürün veritabanında halihazırda var mı yok mu onu kontrol eden fonksiyon
        public bool urunVarMi(string urunBarkodu)
        {
            string baglanti = sqlIslemleri.GetBaglanti();
            string sorgu = sqlIslemleri.GetUrunVarMiSorgu();
            int sayac;

            using (SqlConnection connection = new SqlConnection(baglanti))
            using (SqlCommand command = new SqlCommand(sorgu, connection))
            {
                command.Parameters.AddWithValue("@UrunBarkod", urunBarkodu);

                try
                {
                    connection.Open();
                    sayac = (int)command.ExecuteScalar();

                    if (sayac > 0)
                        return false;    // sayac > 0 ise aynı ürün isimli ya da barkodlu bir ürün eklenmeye çalışmıştır false döndürür
                    else
                        return true;     // aksi durumda true döndürür

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    return false;
                }

            }
        }

        // stok ekranına ürünleri çekmek için gerekli fonksiyon
        public void urunleriCek(string veri, DataGridView dataGridView)
        {
            string baglanti = sqlIslemleri.GetBaglanti();
            string arananVeri = veri;  // kullanıcının arama yerine yazdığı veriyi aranacakVeri değişkenine atıyoruz

            string sorgu;
            bool textBoxBosMu = string.IsNullOrWhiteSpace(arananVeri);

            if (textBoxBosMu)
                sorgu = sqlIslemleri.GetSorguUrunleriCekTextBoxBos();
            else
                sorgu = sqlIslemleri.GetSorguUrunleriCekTextBoxDolu();

            using (SqlConnection connection = new SqlConnection(baglanti))
            using (SqlCommand command = new SqlCommand(sorgu, connection))
            {
                try
                {

                    if(!textBoxBosMu)
                        command.Parameters.AddWithValue("@arananVeri", $"%{arananVeri}");

                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Veriler alınırken bir hata oluştu");
                }
            }
        }

        
        
        // Satış ekranı listview'ine ürünü çekmek için ürünleri önce bir DateTable'a atıyoruz
        public DataTable urunuSatisTablosunaCek(string urunBarkodu)
        {
            DataTable urunTablosu = new DataTable();

            using (SqlConnection connection = new SqlConnection(sqlIslemleri.GetBaglanti()))
            {
                string sorgu = sqlIslemleri.GetUrunSatisEkraniSorgu();

                using (SqlCommand command = new SqlCommand(sorgu, connection))
                {
                    command.Parameters.AddWithValue("@UrunBarkod", urunBarkodu);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(urunTablosu);
                }
            }

            return urunTablosu;
        }

        public void urunuSatisEkraninaTasi(string urunBarkodu, ListView listViewSatisEkrani, TextBox textBoxBarkodGorunmez,
            TextBox textBoxTutar, TextBox textBoxToplamTutar)
        {
            DataTable urunTablosu = urunuSatisTablosunaCek(urunBarkodu);

            if (urunTablosu.Rows.Count > 0)
            {
                bool urunVarMi = false;
                DataRow urun = urunTablosu.Rows[0];

                string urunBarkod = urun["UrunBarkod"]?.ToString() ?? string.Empty;
                string urunAdi = urun["UrunAd"]?.ToString() ?? string.Empty;
                decimal urunFiyat = Convert.ToDecimal(urun["UrunFiyatSatis"]);

                int mevcutAdet;

                foreach (ListViewItem item in listViewSatisEkrani.Items)
                {
                    if (item.SubItems[0].Text == urunBarkod)
                    {
                        mevcutAdet = Convert.ToInt32(item.SubItems[3].Text);
                        item.SubItems[3].Text = (mevcutAdet + 1).ToString();
                        urunVarMi = true;

                        // Mevcut tutarı güncelle
                        tutarVeToplamTutarGuncelle(urunFiyat, textBoxTutar, textBoxToplamTutar);
                        break;
                    }
                }

                if (!urunVarMi)
                {
                    // Yeni bir ürün ekle
                    ListViewItem newItem = new ListViewItem(urunBarkod);
                    newItem.SubItems.Add(urunAdi);
                    newItem.SubItems.Add(urunFiyat.ToString("F2"));
                    newItem.SubItems.Add("1");
                    listViewSatisEkrani.Items.Add(newItem);

                    // Yeni eklenen ürünün tutarını güncelle
                    tutarVeToplamTutarGuncelle(urunFiyat, textBoxTutar, textBoxToplamTutar);
                }

                textBoxBarkodGorunmez.Clear();
                textBoxBarkodGorunmez.Focus();
            }
            else
            {
                MessageBox.Show("Böyle bir ürün mevcut değil");
                textBoxBarkodGorunmez.Clear();
                textBoxBarkodGorunmez.Focus();
            }
        }

        private void tutarVeToplamTutarGuncelle(decimal urunFiyat, TextBox textBoxTutar, TextBox textBoxToplamTutar)
        {
            // Eklenen veya güncellenen ürünün fiyatını textBoxTutar'a yaz
            textBoxTutar.Text = urunFiyat.ToString("F2");

            // Mevcut toplam tutarı al ve eklenen ürünün fiyatını ekle
            decimal mevcutToplamTutar = 0;
            decimal.TryParse(textBoxToplamTutar.Text, out mevcutToplamTutar);
            mevcutToplamTutar += urunFiyat;

            // Yeni toplam tutarı textBoxToplamTutar'a yaz
            textBoxToplamTutar.Text = mevcutToplamTutar.ToString("F2");
        }

        public void tutarVeToplamTutariSatisTamamlayaAktar(string toplamTutar, TextBox toplamTutarTextbox)
        {
            toplamTutarTextbox.Text = toplamTutar;
        }

        public void satisTamamlaVerileriAktar(ListView satisEkraniListView, string indirimTur, string connectionString, float toplamTutar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (ListViewItem item in satisEkraniListView.Items)
                    {
                        string urunBarkod = item.SubItems[0].Text;
                        if (!int.TryParse(item.SubItems[3].Text, out int urunAdet))
                        {
                            throw new Exception($"UrunAdet geçersiz: {item.SubItems[3].Text}");
                        }
                        if (!float.TryParse(item.SubItems[2].Text, out float urunFiyatSatis))
                        {
                            throw new Exception($"UrunFiyatSatis geçersiz: {item.SubItems[2].Text}");
                        }

                        // Tek bir SQL sorgusuyla tüm işlemleri gerçekleştirin
                        string query = sqlIslemleri.GetSatisTamamlaVerileriAktarSorgu();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@UrunBarkod", urunBarkod);
                            cmd.Parameters.AddWithValue("@Indirimtur", indirimTur);
                            cmd.Parameters.AddWithValue("@Miktar", urunAdet);
                            cmd.Parameters.AddWithValue("@UrunFiyatSatis", urunFiyatSatis);
                            cmd.ExecuteNonQuery();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına veri aktarılırken bir hata oluştu: " + ex.Message);
            }
        }

        public void satisEkraniVeriTemizle(TextBox satisEkraniTutar, TextBox satisEkraniToplamTutar, TextBox textBoxBarodGorunmez, 
            ListView satisEkraniListView)
        {
            satisEkraniTutar.Clear();
            satisEkraniToplamTutar.Clear();
            textBoxBarodGorunmez.Clear();
            textBoxBarodGorunmez.Focus();
            satisEkraniListView.Items.Clear();
        }

        /*             ZAM İŞLEMERİ          */

        // Ürünlere zam yapmak için gerekli fonksiyon
        public void zamEkle(ComboBox zamTuru, TextBox barkod, ComboBox gKategori, ComboBox kategori, ComboBox marka,
                            ComboBox firma, TextBox zamOrani1, TextBox zamOrani2, TextBox zamOrani3)
        {
            if (zamTuru.SelectedIndex == 0) // Eğer ürüne göre zam yapılacaksa
            {
                if (!dogruMu(barkod.Text) || string.IsNullOrWhiteSpace(barkod.Text)) // Eğer barkod boşsa
                {
                    MessageBox.Show("Lütfen bir barkod giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // İşlemi durdur
                }
                else if (!dogruMu(zamOrani1.Text) || string.IsNullOrWhiteSpace(zamOrani1.Text)) // Eğer zam oranı boşsa veya sayıya dönüştürülemezse
                {
                    MessageBox.Show("Lütfen geçerli bir zam oranı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // İşlemi durdur
                }
                else // Eğer barkod ve zam oranı doğru girilmişse
                {
                    string barkodU = barkod.Text;
                    float zam = float.Parse(zamOrani1.Text);
                    uruneZamYap(barkodU, zam);
                }
            }
            else if (zamTuru.SelectedIndex == 1) // Eğer kategoriye göre zam yapılacaksa
            {
                if (string.IsNullOrWhiteSpace(gKategori.Text) || string.IsNullOrWhiteSpace(kategori.Text)) // Eğer genel kategori veya kategori seçilmediyse
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!dogruMu(zamOrani2.Text) || string.IsNullOrWhiteSpace(zamOrani2.Text)) // Eğer zam oranı boşsa veya sayıya dönüştürülemezse
                {
                    MessageBox.Show("Lütfen geçerli bir zam oranı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else // Eğer genel kategori ve kategori seçildiyse ve zam oranı doğru girildiyse
                {
                    string gKategori1 = gKategori.Text;
                    string kategori1 = kategori.Text;
                    float zam = float.Parse(zamOrani2.Text);
                    kategoriZamYap(gKategori1, kategori1, zam);
                }
            }
            else if (zamTuru.SelectedIndex == 2) // Eğer markaya göre zam yapılacaksa
            {
                if (string.IsNullOrWhiteSpace(marka.Text) || string.IsNullOrWhiteSpace(firma.Text)) // Eğer marka veya firma seçilmediyse
                {
                    MessageBox.Show("Lütfen bir marka ve firma seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // İşlemi durdur
                }
                else if (!dogruMu(zamOrani3.Text) || string.IsNullOrWhiteSpace(zamOrani3.Text)) // Eğer zam oranı boşsa veya sayıya dönüştürülemezse
                {
                    MessageBox.Show("Lütfen geçerli bir zam oranı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // İşlemi durdur
                }
                else // Eğer marka ve firma seçildiyse ve zam oranı doğru girildiyse
                {
                    string firma1 = firma.Text;
                    string marka1 = marka.Text;
                    float zam = float.Parse(zamOrani3.Text);
                    markaZamYap(firma1, marka1, zam);
                }
            }
        }

        // Ürüne zam yapmak için gerekli fonksiyon
        public void uruneZamYap(string urunBarkod, float zamOrani)
        {
            string baglanti = sqlIslemleri.GetBaglanti(); // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                string sorgu = sqlIslemleri.GetUrunZamSorgu();// SQL sorgusu: Urun tablosunda, belirtilen GenelKategori ve UrunKategori'ye göre zam yapılacak
                try
                {
                    using (SqlCommand command = new SqlCommand(sorgu, connection))// SQL komutu oluşturuluyor
                    {
                        command.Parameters.AddWithValue("@ZamOrani", zamOrani / 100); // Yüzdelik zam oranı
                        command.Parameters.AddWithValue("@UrunBarkod", urunBarkod);

                        int rowsAffected = command.ExecuteNonQuery();// Sorguyu çalıştır

                        if (rowsAffected > 0) // Eğer herhangi bir ürün güncellendiyse
                        {
                            MessageBox.Show("Urun bazında zam başarıyla uygulandı.");
                        }
                        else // Eğer ürün bulunamadıysa
                        {
                            MessageBox.Show("Belirtilen barkoda ait ürün bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıyı bilgilendir
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        // Kategoriye göre zam yapmak için gerekli fonksiyon
        public void kategoriZamYap(string genelKategori, string urunKategori, float zamOrani)
        {
            string baglanti = sqlIslemleri.GetBaglanti();
            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                // SQL sorgusu: Urun tablosunda, belirtilen GenelKategori ve UrunKategori'ye göre zam yapılacak
                string sorgu = sqlIslemleri.GetKategoriZamSorgu();
                try
                {
                    // SQL komutu oluşturuluyor
                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        // Parametrelerin eklenmesi
                        command.Parameters.AddWithValue("@ZamOrani", zamOrani / 100); // Yüzdelik zam oranı
                        command.Parameters.AddWithValue("@UrunGKategori", genelKategori);
                        command.Parameters.AddWithValue("@UrunKategori", urunKategori);

                        // Sorguyu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        // Eğer herhangi bir ürün güncellendiyse
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kategori bazında zam başarıyla uygulandı.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen kategoriye ait ürün bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıyı bilgilendir
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        // Markaya göre zam yapmak için gerekli fonksiyon
        public void markaZamYap(string firma, string marka, float zamOrani)
        {
            string baglanti = sqlIslemleri.GetBaglanti();
            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                // SQL sorgusu: Urun tablosunda, belirtilen GenelKategori ve UrunKategori'ye göre zam yapılacak
                string sorgu = sqlIslemleri.GetMarkaZamSorgu();
                try
                {
                    // SQL komutu oluşturuluyor
                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        // Parametrelerin eklenmesi
                        command.Parameters.AddWithValue("@ZamOrani", zamOrani / 100); // Yüzdelik zam oranı
                        command.Parameters.AddWithValue("@UrunUreticiFirma", firma);
                        command.Parameters.AddWithValue("@UrunMarka", marka);

                        int rowsAffected = command.ExecuteNonQuery(); // Sorguyu çalıştır

                        if (rowsAffected > 0) // Eğer herhangi bir ürün güncellendiyse
                        {
                            MessageBox.Show("Marka bazında zam başarıyla uygulandı.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen markaya ait ürün bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıyı bilgilendir
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        // Barkod değiştiğinde eski fiyatı getiren fonksiyon
        public void barkodChanged(TextBox barkod, TextBox eskiFiyat, TextBox kategori, TextBox urun, TextBox marka)
        {
            if (dogruMu(barkod.Text)) // Barkod doğru formatta ise
            {
                string urunBarkod = barkod.Text;
                string urunKategori = urunKategorisi(urunBarkod);// Barkod doğru formatta ise kategori bilgilerini getir
                string urunAdi = urununAdi(urunBarkod);// Barkod doğru formatta ise urun bilgilerini getir
                string urunMarka = urunMarkasi(urunBarkod);// Barkod doğru formatta ise marka bilgilerini getir
                float eskiFiyat1 = urunEskiFiyat(urunBarkod);// Barkod doğru formatta ise fiyat bilgilerini getir

                if (eskiFiyat1 >= 0) // Eğer ürün bulunmuşsa
                {
                    eskiFiyat.Text = eskiFiyat1.ToString("F2"); // Eski fiyatı göster
                    kategori.Text = urunKategori; // Kategoriyi göster
                    urun.Text = urunAdi; // Firmayı göster
                    marka.Text = urunMarka; // Markayı göster
                }
                else
                {
                    eskiFiyat.Text = "Ürün bulunamadı.";//Eski fiyat kısmına yazdır
                    kategori.Text = "Ürün bulunamadı.";//Kategori kısmına yazdır
                    urun.Text = "Ürün bulunamadı.";//Urun kısmına yazdır
                    marka.Text = "Ürün bulunamadı.";//Marka kısmına yazdır
                }
            }
            else
            {
                eskiFiyat.Text = string.Empty; // Barkod geçerli değilse temizle
                kategori.Text = string.Empty; // Kategori geçerli değilse temizle
                urun.Text = string.Empty; // Urun geçerli değilse temizle
                marka.Text = string.Empty; // Marka geçerli değilse temizle
            }
        }

        // Zam oranı değiştiğinde yeni fiyatı hesaplayan fonksiyon
        public void zamChanged(TextBox zamOrani, TextBox eskiFiyat, TextBox yeniFiyat)
        {
            if (float.TryParse(eskiFiyat.Text, out float eskiFiyat1) &&
                float.TryParse(zamOrani.Text, out float zamOrani1))// Eski fiyat ve zam oranı kontrolü
            {
                float yeniFiyat1 = eskiFiyat1 + (eskiFiyat1 * zamOrani1 / 100);// Yeni fiyat hesapla
                yeniFiyat.Text = yeniFiyat1.ToString("F2");// Yeni fiyatı göster
            }
            else
            {
                yeniFiyat.Text = string.Empty;// Eğer değerler geçersizse Yeni Fiyat TextBox'unu temizle
            }
        }

        // Barkod değiştiğinde eski fiyatı getiren fonksiyon
        private float urunEskiFiyat(string urunBarkod)
        {
            string baglanti = sqlIslemleri.GetBaglanti(); // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                string sorgu = sqlIslemleri.GetEskiFiyatSorgu(); // SQL sorgusu: Urun tablosundan belirtilen barkoda ait fiyatı getir
                using (SqlCommand command = new SqlCommand(sorgu, connection))
                    try
                    {
                        command.Parameters.AddWithValue("@UrunBarkod", urunBarkod);
                        object result = command.ExecuteScalar(); // Sorguyu çalıştır ve sonucu al
                        if (result != null && float.TryParse(result.ToString(), out float fiyat))
                        {
                            return fiyat; // Eski fiyatı döndür
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
            }
            return -1; // Ürün bulunamadığında
        }

        // Barkod değiştiğinde kategoriyi getiren fonksiyon
        private string urunKategorisi(string urunBarkod)
        {
            string baglanti = sqlIslemleri.GetBaglanti(); // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                string sorgu = sqlIslemleri.GetUrunKategoriSorgu(); // SQL sorgusu: Urun tablosundan belirtilen barkoda ait kategoriyi getir
                using (SqlCommand command = new SqlCommand(sorgu, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UrunBarkod", urunBarkod);
                        object result = command.ExecuteScalar(); // Sorguyu çalıştır ve sonucu al
                        if (result != null)
                        {
                            return result.ToString(); // Kategoriyi döndür
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            return string.Empty; // Ürün bulunamadığında
        }

        // Barkod değiştiğinde urunun adını getiren fonksiyon
        private string urununAdi(string urunBarkod)
        {
            string baglanti = sqlIslemleri.GetBaglanti(); // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                string sorgu = sqlIslemleri.GetUrunAdiSorgu(); // SQL sorgusu: Urun tablosundan belirtilen barkoda ait urun adını getir
                using (SqlCommand command = new SqlCommand(sorgu, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UrunBarkod", urunBarkod);
                        object result = command.ExecuteScalar(); // Sorguyu çalıştır ve sonucu al
                        if (result != null)
                        {
                            return result.ToString(); // Kategoriyi döndür
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            return string.Empty; // Ürün bulunamadığında
        }

        // Barkod değiştiğinde markayı getiren fonksiyon
        private string urunMarkasi(string urunBarkod)
        {
            string baglanti = sqlIslemleri.GetBaglanti(); // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                string sorgu = sqlIslemleri.GetUrunMarkaSorgu(); // SQL sorgusu: Urun tablosundan belirtilen barkoda ait markayı getir
                using (SqlCommand command = new SqlCommand(sorgu, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UrunBarkod", urunBarkod);
                        object result = command.ExecuteScalar(); // Sorguyu çalıştır ve sonucu al
                        if (result != null)
                        {
                            return result.ToString(); // Kategoriyi döndür
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            return string.Empty; // Ürün bulunamadığında
        }

        // Zam Ekranında ComboBox'ları doldurmak için gerekli fonksiyon
        public void comboBoxDoldur(string query, ComboBox comboBox)
        {
            string baglanti = sqlIslemleri.GetBaglanti(); // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            comboBox.Items.Clear(); // Önce temizle
                            while (reader.Read()) // Okuma işlemi
                            {
                                comboBox.Items.Add(reader[0].ToString()); // Sütundaki değeri ekle
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
            }
        }

        // Zam ekranında barkod girildiğinde ürün bilgilerini getiren fonksiyon
        public bool dogruMu(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Lütfen sadece sayısal değerler giriniz.");
                    return false;
                }
            }
            return true;
        }

    }
}
