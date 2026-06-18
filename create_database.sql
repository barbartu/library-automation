-- Create database if it does not exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'kutuphane')
BEGIN
    CREATE DATABASE kutuphane;
END
GO

USE kutuphane;
GO

-- Create turler table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[turler]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[turler] (
        [tur_id] INT IDENTITY(1,1) PRIMARY KEY,
        [tur_adi] NVARCHAR(100) NOT NULL
    );
END
GO

-- Create ogrenciler table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ogrenciler]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[ogrenciler] (
        [ogrenci_no] INT PRIMARY KEY,
        [ad] NVARCHAR(100) NOT NULL,
        [soyad] NVARCHAR(100) NOT NULL,
        [sinif] INT NULL,
        [cinsiyet] NVARCHAR(10) NULL,
        [telefon] NVARCHAR(20) NULL
    );
END
GO

-- Create kitaplar table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kitaplar]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[kitaplar] (
        [kitap_id] INT IDENTITY(1,1) PRIMARY KEY,
        [kitap_adi] NVARCHAR(150) NOT NULL,
        [yazar] NVARCHAR(100) NULL,
        [yayin_evi] NVARCHAR(100) NULL,
        [sayfa_sayisi] INT NULL,
        [tur_id] INT NULL,
        FOREIGN KEY (tur_id) REFERENCES [dbo].[turler](tur_id) ON DELETE SET NULL
    );
END
GO

-- Create odunc table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[odunc]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[odunc] (
        [odunc_id] INT IDENTITY(1,1) PRIMARY KEY,
        [ogrenci_no] INT NOT NULL,
        [kitap_id] INT NOT NULL,
        [aciklama] NVARCHAR(MAX) NULL,
        [verilis_tarihi] DATETIME NOT NULL,
        FOREIGN KEY (ogrenci_no) REFERENCES [dbo].[ogrenciler](ogrenci_no) ON DELETE CASCADE,
        FOREIGN KEY (kitap_id) REFERENCES [dbo].[kitaplar](kitap_id) ON DELETE CASCADE
    );
END
GO
