

-- UrunStok tablosunu �eken sql
Select * from Urun JOIN Stok ON Urun.UrunID=Stok.UrunID 


-- T�m tablolar� ayr� ayr� �eken sql
select * from Stok -- stok tablosunu �eker
select * from Urun --urun tablosunu �eker
select * from Satis -- sat�� tablosunu �eker
select * from UrunSatis -- UrunSat�� tablosunu �eker


--SANAL TABLO UrunSatis �EKEN SQL
SELECT UrunBarkod,UrunAd,Miktar,UrunFiyatSatis FROM 
(select UrunBarkod,UrunAd,UrunFiyatSatis,Sat�sID from Urun JOIN UrunSatis ON Urun.UrunID=UrunSatis.UrunID)tablo1 
JOIN satis ON tablo1.Sat�sID=Satis.Sat�sID

