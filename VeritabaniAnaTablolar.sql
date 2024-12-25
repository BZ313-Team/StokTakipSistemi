CREATE TABLE Stok
(UrunID int identity(1,1) primary key not null,
StokDurum nvarchar(10) not null,
StokTur nvarchar(10) not null,
StokMiktar int null
);

CREATE TABLE Urun 

(UrunID int identity(1,1) primary key not null ,
UrunBarkod int not null,
UrunAd nvarchar(50) not null,
UrunGKategori int not null,
UrunKategori int not null,
UrunUreticiFirma nvarchar(50) not null,
UrunTip nvarchar(50) not null,
UrunModel nvarchar(50) not null,
UrunBoyut decimal(18,2) not null,
UrunMensei nvarchar(50) not null,
UrunFiyatAlis float not null,
UrunFiyatSatis float not null,
UrunGTarih date not null,
UrunMarka nvarchar(50) not null,
CONSTRAINT UQ_UrunUnique UNIQUE (UrunAd)
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



CREATE TABLE Users (UserId INT IDENTITY(1,1) PRIMARY KEY, Username NVARCHAR(50) NOT NULL UNIQUE, Password NVARCHAR(255) NOT NULL, CreatedAt DATETIME DEFAULT GETDATE());


INSERT INTO Users (Username, Password) VALUES ('dayi', '123456');
