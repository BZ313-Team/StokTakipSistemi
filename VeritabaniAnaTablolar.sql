-- Satis Tablosu
CREATE TABLE [dbo].[Satis](
    [SatýsID] [int] IDENTITY(1,1) NOT NULL,
    [UrunID] [int] NOT NULL,
    [Indirimtur] [nvarchar](30) NOT NULL,
    [Miktar] [int] NOT NULL,
    [CreatedAt] [datetime] NULL DEFAULT (getdate()),
    PRIMARY KEY CLUSTERED ([SatýsID])
)

-- Stok Tablosu
CREATE TABLE [dbo].[Stok](
    [UrunID] [int] IDENTITY(1,1) NOT NULL,
    [StokDurum] [nvarchar](20) NOT NULL,
    [StokTur] [nvarchar](20) NOT NULL,
    [StokMiktar] [int] NULL,
    PRIMARY KEY CLUSTERED ([UrunID])
)

-- Urun Tablosu
CREATE TABLE [dbo].[Urun](
    [UrunID] [int] IDENTITY(1,1) NOT NULL,
    [UrunBarkod] [int] NOT NULL,
    [UrunAd] [nvarchar](50) NOT NULL,
    [UrunGKategori] [nvarchar](50) NOT NULL,
    [UrunKategori] [nvarchar](50) NOT NULL,
    [UrunUreticiFirma] [nvarchar](50) NOT NULL,
    [UrunTip] [nvarchar](50) NOT NULL,
    [UrunModel] [nvarchar](50) NOT NULL,
    [UrunBoyut] [decimal](18, 2) NOT NULL,
    [UrunMensei] [nvarchar](50) NOT NULL,
    [UrunFiyatAlis] [float] NOT NULL,
    [UrunFiyatSatis] [float] NOT NULL,
    [UrunGTarih] [date] NOT NULL,
    [UrunMarka] [nvarchar](50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UrunID]),
    CONSTRAINT [UQ_UrunBarkod] UNIQUE NONCLUSTERED ([UrunBarkod])
)

-- Users Tablosu
CREATE TABLE [dbo].[Users](
    [UserId] [int] IDENTITY(1,1) NOT NULL,
    [Username] [nvarchar](50) NOT NULL,
    [Password] [nvarchar](255) NOT NULL,
    [CreatedAt] [datetime] NULL DEFAULT (getdate()),
    PRIMARY KEY CLUSTERED ([UserId]),
    UNIQUE NONCLUSTERED ([Username])
)

-- Users verisi
INSERT INTO [dbo].[Users] ([Username], [Password]) 
VALUES ('dayi', '123456')

-- Istatistik Satis Tablosu
CREATE TABLE [dbo].[IstatistikSatis](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [UrunGKategori] [nvarchar](50) NOT NULL,
    [Miktar] [int] NOT NULL,
    [UrunFiyatSatis] [float] NOT NULL,
    [CreatedAt] [datetime] NULL DEFAULT (getdate())
)

-- Istatistik Alis Tablosu
CREATE TABLE [dbo].[IstatistikAlis](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [UrunGKategori] [nvarchar](50) NOT NULL,
    [Miktar] [int] NOT NULL,
    [UrunFiyatAlis] [float] NOT NULL,
    [CreatedAt] [datetime] NULL DEFAULT (getdate())
)