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
        // SQL bağlantı cümlesi
        private string baglanti = "Server=YourDevice\\SQLEXPRESS;Database=yourDB;Integrated Security=True;TrustServerCertificate=True;";

        
        private string urunSorguEklemeyiYap = @"INSERT INTO Urun       
                 (UrunBarkod, UrunAd, UrunGKategori, UrunKategori, UrunUreticiFirma, 
                  UrunTip, UrunModel, UrunBoyut, UrunMensei, UrunFiyatAlis, 
                  UrunFiyatSatis, UrunGTarih, UrunMarka) 
                 VALUES 
                 (@UrunBarkod, @UrunAd, @UrunGKategori, @UrunKategori, @UrunUreticiFirma, 
                  @UrunTip, @UrunModel, @UrunBoyut, @UrunMensei, @UrunFiyatAlis, 
                  @UrunFiyatSatis, @UrunGTarih, @UrunMarka);";

        private string stokSorguEklemeyiYap = @"INSERT INTO Stok 
                         (StokDurum, StokTur, StokMiktar) 
                         VALUES 
                         (@StokDurum, @StokTur, @StokMiktar);";

        private static string[] aranacakSutunlar = {         // aranacak sütunları belirliyoruz, bazıları varchar olmadığı için geçici olarak
                "U.UrunBarkod",   
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

        private static string filtreliSorgu = string.Join(" OR ", aranacakSutunlar.Select(s => $"{s} LIKE '%' + @arananVeri + '%'"));

        string sorguUrunleriCekTextBoxDolu = $@"
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

        string sorguUrunleriCekTextBoxBos = @"
                    SELECT 
                        U.UrunID, U.UrunBarkod, U.UrunAd, U.UrunGKategori, U.UrunKategori, 
                        U.UrunUreticiFirma, U.UrunTip, U.UrunModel, U.UrunBoyut, 
                        U.UrunMensei, U.UrunFiyatAlis, U.UrunFiyatSatis, U.UrunGTarih, U.UrunMarka,
                        S.StokDurum, S.StokTur, S.StokMiktar
                    FROM 
                        Urun AS U
                    INNER JOIN 
                        Stok AS S ON U.UrunID = S.UrunID";

        private string urunVarMiSorgu = "SELECT COUNT(*) FROM Urun WHERE UrunBarkod = @UrunBarkod";

        private string sorguUrunSil = @"
                        BEGIN TRANSACTION;
    
                        DELETE FROM Stok
                            WHERE UrunID = (SELECT UrunID FROM Urun WHERE UrunBarkod = @UrunBarkod);
    
                        DELETE FROM Urun
                            WHERE UrunBarkod = @UrunBarkod;
    
                        COMMIT TRANSACTION;";

        private string kontrolSorguUrunSil = "SELECT COUNT(*) FROM Urun WHERE UrunBarkod = @UrunBarkod";

        private string sorguAuthentication = "SELECT * FROM Users";

        

        public string GetBaglanti()
        {
            return baglanti;
        }

        public string GetUrunSorguEklemeyiYap()
        {
            return urunSorguEklemeyiYap;
        }

        public string GetStokSorguEklemeyiYap()
        {
            return stokSorguEklemeyiYap;
        }

        public string[] GetAranacakSutunlar()
        {
            return aranacakSutunlar;
        }

        public string GetFiltreliSorgu()
        {
            return filtreliSorgu;
        }

        public string GetSorguUrunleriCekTextBoxDolu()
        {
            return sorguUrunleriCekTextBoxDolu;
        }

        public string GetSorguUrunleriCekTextBoxBos()
        {
            return sorguUrunleriCekTextBoxBos;
        }

        public string GetUrunVarMiSorgu()
        {
            return urunVarMiSorgu;
        }

        public string GetSorguUrunSil()
        {
            return sorguUrunSil;
        }

        public string GetKontrolSorguUrunSil()
        {
            return kontrolSorguUrunSil;
        }

        public string GetSorguAuthentication()
        {
            return sorguAuthentication;
        }







        /*        ZAM İŞLEMLERİ İÇİN SQL SORGULARI          */

        // Urun bazında zam yapmak için kullanılacak sorgu
        private string urunZamSorgu = "UPDATE Urun SET urunFiyatSatis = urunFiyatSatis + (urunFiyatSatis * @ZamOrani) " +
                                      "WHERE UrunBarkod = @UrunBarkod ";

        // Kategori bazında zam yapmak için kullanılacak sorgu
        private string kategoriZamSorgu = "UPDATE Urun SET urunFiyatSatis = urunFiyatSatis + (urunFiyatSatis * @ZamOrani) " +
                                          "WHERE UrunGKategori = @UrunGKategori AND UrunKategori = @UrunKategori";

        // Marka bazında zam yapmak için kullanılacak sorgu
        private string markaZamSorgu = "UPDATE Urun SET urunFiyatSatis = urunFiyatSatis + (urunFiyatSatis * @ZamOrani) " +
                                   "WHERE UrunUreticiFirma = @UrunUreticiFirma AND UrunMarka = @UrunMarka";

        //Barkoda göre urunun kategorisini çekmek için kullanılacak sorgu
        private string urunKategoriSorgu = "SELECT UrunKategori FROM Urun WHERE UrunBarkod = @UrunBarkod";

        //Barkoda göre urunun adını çekmek için kullanılacak sorgu
        private string urununAdiSorgu = "SELECT UrunAd FROM Urun WHERE UrunBarkod = @UrunBarkod";

        //Barkoda göre urunun markasını çekmek için kullanılacak sorgu
        private string urunMarkaSorgu = "SELECT  UrunMarka FROM Urun WHERE UrunBarkod = @UrunBarkod";

        //Barkoda göre urunun eski fiyatını çekmek için kullanılacak sorgu
        private string eskiFiyatSorgu = "SELECT urunFiyatSatis FROM Urun WHERE UrunBarkod = @UrunBarkod";

        public string GetUrunZamSorgu()
        {
            return urunZamSorgu;
        }

        public string GetKategoriZamSorgu()
        {
            return kategoriZamSorgu;
        }

        public string GetMarkaZamSorgu()
        {
            return markaZamSorgu;
        }

        public string GetUrunKategoriSorgu()
        {
            return urunKategoriSorgu;
        }

        public string GetUrunAdiSorgu()
        {
            return urununAdiSorgu;
        }

        public string GetUrunMarkaSorgu()
        {
            return urunMarkaSorgu;
        }
        public string GetEskiFiyatSorgu()
        {
            return eskiFiyatSorgu;
        }
    }
}
