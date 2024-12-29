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
            var donusturulmusParametreler = parametreleriDonustur(urunBarkodTextBox.Text, urunBoyutComboBox.Text, urunFiyatAlisTextBox.Text,
                urunFiyatSatisTextBox.Text, urunGirisTarihiMaskedTextBox.Text, urunStokMiktarTextBox.Text);
            //MessageBox.Show("Dönüştürülme işlemi yapıldı eklemeYap fonksiyonuna girilecek");

            // eklenecek ürün ile aynı barkoda sahip ürün veritabanında var mı onu kontrol ediyoruz burada
            if(!urunVarMi(donusturulmusParametreler.Item1))
            {
                MessageBox.Show("Aynı barkodda başka bir ürün zaten mevcut");
                return;
            }

            eklemeyiYap(donusturulmusParametreler.Item1, urunAdTextBox.Text, urunGKategoriComboBox.Text, urunKategoriComboBox.Text,
            urunUreticiFirmaComboBox.Text, urunTipComboBox.Text, urunModelComboBox.Text, donusturulmusParametreler.Item2, urunMenseiComboBox.Text,
            donusturulmusParametreler.Item3, donusturulmusParametreler.Item4, donusturulmusParametreler.Item5, urunMarkaTextBox.Text,
            donusturulmusParametreler.Item6);

            //MessageBox.Show("EklemeyiYap fonksiyonundan çıkıldı ");
        }

        // ürün ekleme işlemini gerçekleştirecek asıl fonksiyon. urunEkle tarafından çağrılacak
        private void eklemeyiYap(int urunBarkod, string urunAd, string urunGKategori, string urunKategori, string urunUreticiFirma, string urunTip, 
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
            int stokMiktarInt, urunBarkoduInt;
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

            // textbox'dan gelen ürün barkodunu int'e çevrilmezse kullanıcıya doğru veri girmesi için uyarı gönderdik
            if (!int.TryParse(urunBarkoduTextBox.Text, out urunBarkoduInt))
            {
                MessageBox.Show("Ürün barkodu yalnızca sayı olabilir");
                urunBarkoduTextBox.Focus();
                return false;
            }

            // textbox'dan gelen ürün barkodunun 8 haneli olup olmadığına baktık 8 haneli değilse kullanıcıya uyarı gönderdik
            if (urunBarkoduTextBox.Text.Length != 8)
            {
                MessageBox.Show("Ürün barkodu 8 haneli olmalıdır");
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
        private (int, decimal, float, float, DateTime, int) parametreleriDonustur(string urunBarkodString,string urunBoyutString, 
            string urunFiyatAlisString, string urunFiyatSatisString, string urunGirisTarihiString, string urunStokMiktarString)
        {
            int donusturulmusUrunBarkod = int.Parse(urunBarkodString);
            decimal donusturulmusUrunBoyut = decimal.Parse(urunBoyutString);
            float donusturulmusUrunFiyatAlis = float.Parse(urunFiyatAlisString);
            float donusturulmusUrunFiyatSatis = float.Parse(urunFiyatSatisString);
            DateTime donusturulmusUrunGirisTarihi = DateTime.Parse(urunGirisTarihiString);
            int donusturulmusStokMiktar = int.Parse(urunStokMiktarString);

            return(donusturulmusUrunBarkod, donusturulmusUrunBoyut, donusturulmusUrunFiyatAlis, donusturulmusUrunFiyatSatis,
                   donusturulmusUrunGirisTarihi, donusturulmusStokMiktar);

        }

        // ürün silme fonksiyonu
        public void urunSil(int urunBarkod)
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
        public bool urunVarMi(int urunBarkodu)
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

    }
}
