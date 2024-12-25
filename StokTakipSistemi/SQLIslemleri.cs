using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi
{
    internal class SQLIslemleri
    {
        //"Server=AYDEMIR\SQLEXPRESS;Database=serkanDB;Integrated Security=True;TrustServerCertificate=True;";  // baglanti adresi


        // eklenen ürün daha önce eklenmiş mi onu kontrol eden urunVarMi fonksiyonu
        public bool urunVarMi(int urunBarkodu)
        {
            string baglanti = "Server=AYDEMIR\\SQLEXPRESS;Database=berkayDB;Integrated Security=True;TrustServerCertificate=True;";
            string sorgu = "SELECT COUNT(*) FROM Urun WHERE UrunBarkod = @UrunBarkod";
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
                    {
                        MessageBox.Show("Ürün daha zaten daha önce eklenmiş.");
                        return false;    // sayac > 0 ise aynı ürün isimli ya da barkodlu bir ürün eklenmeye çalışmıştır false döndürür
                    }
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
        
        public void urunleriCek(string veri, DataGridView dataGridView)
        {
            string baglanti = "Server=AYDEMIR\\SQLEXPRESS;Database=berkayDB;Integrated Security=True;TrustServerCertificate=True;";
            string arananVeri = veri;  // kullanıcının arama yerine yazdığı veriyi aranacakVeri değişkenine atıyoruz

            if(string.IsNullOrWhiteSpace(arananVeri))  // eğer arama kısmı boş ise ekranı temizlemek için bu if bloğunu yazdık
            {
                dataGridView.DataSource = null;
                return;
            }

            string[] aranacakSutunlar = {             // aranacak sütunları belirliyoruz, bazıları varchar olmadığı için geçici olarak
                "CONVERT(NVARCHAR, U.UrunBarkod)",   // varchar'a çeviriyoruz.
                "U.UrunAd",
                "U.UrunGKategori",
                "U.UrunKategori",
                "U.UrunUreticiFirma",
                "U.UrunTip",
                "U.UrunModel",
                "CONVERT(NVARCHAR, U.UrunBoyut)",
                "U.UrunMensei",
                "CONVERT(NVARCHAR, U.UrunFiyatAlis)",
                "CONVERT(NVARCHAR, U.UrunFiyatSatis)",
                "CONVERT(NVARCHAR, U.UrunGTarih, 120)",
                "U.UrunMarka",
                "S.StokDurum",
                "S.StokTur",
                "CONVERT(NVARCHAR, S.StokMiktar)"
            };

            string filtreliSorgu = string.Join(" OR ", aranacakSutunlar.Select(s => $"{s} LIKE @arananVeri"));
            string sorgu = $@"
            SELECT 
                U.UrunID, U.UrunBarkod, U.UrunAd, U.UrunGKategori, U.UrunKategori, 
                U.UrunUreticiFirma, U.UrunTip, U.UrunModel, U.UrunBoyut, 
                U.UrunMensei, U.UrunFiyatAlis, U.UrunFiyatSatis, U.UrunGTarih, U.UrunMarka,
                S.StokDurum, S.StokTur, S.StokMiktar
            FROM 
                Urun AS U
            INNER JOIN 
                Stok AS S ON U.UrunID = S.UrunID
            WHERE 
                {filtreliSorgu}";

            using (SqlConnection connection = new SqlConnection(baglanti))
            using(SqlCommand command = new SqlCommand(sorgu, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@arananVeri", $"%{arananVeri}");
                    connection.Open();

                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
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
