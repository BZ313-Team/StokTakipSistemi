using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StokTakipSistemi
{
    internal class UrunIslemleri
    {
        //"Server=DESKTOP-IRAO93A\\SQLEXPRESS;Database=serkanDB;Integrated Security=True;TrustServerCertificate=True;"  baglanti adresi
        

        // ürün ekleme fonksiyonu
        public bool urunEkle(int urunBarkod, string urunAd, string urunKategori, string urunUreticiFirma, string urunTip, string urunModel,
        decimal urunBoyut, string urunMensei, float urunFiyatAlis, float urunFiyatSatis, DateTime urunGirisTarihi, string urunMarka,
        int stokMiktar)
        {
            string baglanti = "Server=AYDEMIR\\SQLEXPRESS;Database=berkayDB;Integrated Security=True;TrustServerCertificate=True;";


            // Ürün tablosuna ürün eklemek için gerekli sorgu
            string urunSorgu = @"INSERT INTO Urun       
                 (UrunBarkod, UrunAd, UrunGKategori, UrunKategori, UrunUreticiFirma, 
                  UrunTip, UrunModel, UrunBoyut, UrunMensei, UrunFiyatAlis, 
                  UrunFiyatSatis, UrunGTarih, UrunMarka) 
                 VALUES 
                 (@UrunBarkod, @UrunAd, @UrunGKategori, @UrunKategori, @UrunUreticiFirma, 
                  @UrunTip, @UrunModel, @UrunBoyut, @UrunMensei, @UrunFiyatAlis, 
                  @UrunFiyatSatis, @UrunGTarih, @UrunMarka);";

            // Stok tablosuna veri eklemek için gerekli sorgu
            string stokSorgu = @"INSERT INTO Stok 
                         (StokDurum, StokTur, StokMiktar) 
                         VALUES 
                         (@StokDurum, @StokTur, @StokMiktar);";

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
                            urunCommand.Parameters.AddWithValue("@UrunGKategori", urunKategori);
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
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda işlemler geri alınır
                        transaction.Rollback();
                        MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public void urunSil(int urunBarkod)
        {
            string baglanti = "Server=AYDEMIR\\SQLEXPRESS;Database=berkayDB;Integrated Security=True;TrustServerCertificate=True;";
            string sorgu = @"
                        BEGIN TRANSACTION;
    
                        DELETE FROM Stok
                            WHERE UrunID = (SELECT UrunID FROM Urun WHERE UrunBarkod = @UrunBarkod);
    
                        DELETE FROM Urun
                            WHERE UrunBarkod = @UrunBarkod;
    
                        COMMIT TRANSACTION;";
            string kontrolSorgu = "SELECT COUNT(*) FROM Urun WHERE UrunBarkod = @UrunBarkod";

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

    }
}
