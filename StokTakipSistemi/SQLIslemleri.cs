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
        private string baglanti = "Server=DESKTOP-IRAO93A\\SQLEXPRESS;Database=fatih;Integrated Security=True;TrustServerCertificate=True;";

        
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
    }
}
