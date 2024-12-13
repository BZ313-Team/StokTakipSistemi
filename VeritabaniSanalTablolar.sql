

-- UrunStok tablosunu çeken sql
Select * from Urun JOIN Stok ON Urun.UrunID=Stok.UrunID 


-- Tüm tablolarý ayrý ayrý çeken sql
select * from Stok -- stok tablosunu çeker
select * from Urun --urun tablosunu çeker
select * from Satis -- satýþ tablosunu çeker
select * from UrunSatis -- UrunSatýþ tablosunu çeker


--SANAL TABLO UrunSatis ÇEKEN SQL
SELECT UrunBarkod,UrunAd,Miktar,UrunFiyatSatis FROM 
(select UrunBarkod,UrunAd,UrunFiyatSatis,SatýsID from Urun JOIN UrunSatis ON Urun.UrunID=UrunSatis.UrunID)tablo1 
JOIN satis ON tablo1.SatýsID=Satis.SatýsID

