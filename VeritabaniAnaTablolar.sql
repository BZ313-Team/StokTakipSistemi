CREATE TABLE Stok
(UrunID int identity(1,1) primary key not null,
StokDurum nvarchar(10) not null,
StokTur nvarchar(10) not null,
StokMiktar int null
);

CREATE TABLE Urun 

(UrunID int identity(1,1) primary key not null ,
UrunBarkod int not null,
UrunAd nvarchar(10) not null,
UrunGKategori int not null,
UrunKategori int not null,
UrunUreticiFirma nvarchar not null,
UrunTip nvarchar not null,
UrunModel nvarchar not null,
UrunBoyut decimal(18,2) not null,
UrunMensei nvarchar not null,
UrunFiyatAlis float not null,
UrunFiyatSatis float not null,
UrunGTarih date not null,
UrunMarka nvarchar not null,
);

select * from Stok



CREATE TABLE Satis
(
SatýsID int identity (1,1) primary key not null,
Indirimtur nvarchar not null,
Miktar int not null,

);




CREATE TABLE UrunSatis

(
UrunID  int  not null,
SatýsID int   not null,
);

