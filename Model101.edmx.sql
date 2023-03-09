
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/23/2022 16:26:43
-- Generated from EDMX file: C:\Proje_Dosyaları\Petrol_Sayac\Sayac_Proje\Model101.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Db_Sayac];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Tbl_MarketKasasi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tbl_MarketKasasi];
GO
IF OBJECT_ID(N'[dbo].[Tbl_YakitKasasi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tbl_YakitKasasi];
GO
IF OBJECT_ID(N'[dbo].[Tbl_YikamaKasasi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tbl_YikamaKasasi];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tbl_YakitKasasi'
CREATE TABLE [dbo].[Tbl_YakitKasasi] (
    [id] int IDENTITY(1,1) NOT NULL,
    [pompaci] nvarchar(50)  NULL,
    [muhasebeci] nvarchar(50)  NULL,
    [zRaporu] float  NULL,
    [otomasyon] float  NULL,
    [halkPos1] float  NULL,
    [halkPos2] float  NULL,
    [ziraatPos1] float  NULL,
    [ziraatPos2] float  NULL,
    [kart] float  NULL,
    [nakit] float  NULL,
    [veresiye] float  NULL,
    [pompacidanAlinan] float  NULL,
    [gider] float  NULL,
    [fisNo] nvarchar(50)  NULL,
    [giderAciklama] nvarchar(50)  NULL,
    [toplam] float  NULL,
    [acik] float  NULL,
    [fazla] float  NULL,
    [tahsilat] float  NULL,
    [tahsilatAciklama] nvarchar(50)  NULL,
    [benzin] float  NULL,
    [motorin] float  NULL,
    [lpg] float  NULL,
    [yakitLitre] float  NULL,
    [yakitTutar] float  NULL,
    [benzinStok] float  NULL,
    [motorinStok] float  NULL,
    [lpgStok] float  NULL,
    [tarih] datetime  NULL,
    [gelir] float  NULL,
    [gelirFisNo] nvarchar(50)  NULL,
    [gelirAciklama] nvarchar(50)  NULL,
    [tahsilatFisNo] nvarchar(50)  NULL
);
GO

-- Creating table 'Tbl_MarketKasasi'
CREATE TABLE [dbo].[Tbl_MarketKasasi] (
    [id] int IDENTITY(1,1) NOT NULL,
    [zRaporu] float  NULL,
    [otomasyonToplam] float  NULL,
    [gunSonu1] float  NULL,
    [gunSonu2] float  NULL,
    [kartToplam] float  NULL,
    [nakit] float  NULL,
    [veresiyeToplam] float  NULL,
    [muhasebeTeslim] float  NULL,
    [gider] float  NULL,
    [gelirFisNo] nvarchar(50)  NULL,
    [giderAciklama] nvarchar(50)  NULL,
    [gelir] float  NULL,
    [giderFisNo] nvarchar(50)  NULL,
    [gelirAciklama] nvarchar(50)  NULL,
    [toplam] float  NULL,
    [acik] float  NULL,
    [fazla] float  NULL,
    [tahsilat] float  NULL,
    [tahsilatFisNo] nvarchar(50)  NULL,
    [tahsilatAciklama] nvarchar(50)  NULL,
    [kasiyer] nvarchar(50)  NULL,
    [muhasebeci] nvarchar(50)  NULL,
    [vardiyaNotu] nvarchar(50)  NULL,
    [tarih] datetime  NULL
);
GO

-- Creating table 'Tbl_YikamaKasasi'
CREATE TABLE [dbo].[Tbl_YikamaKasasi] (
    [id] int IDENTITY(1,1) NOT NULL,
    [kart] float  NULL,
    [nakit] float  NULL,
    [veresiye] float  NULL,
    [kasaTeslim] float  NULL,
    [gider] float  NULL,
    [toplam] float  NULL,
    [giderFisNo] nvarchar(50)  NULL,
    [giderAciklama] nvarchar(50)  NULL,
    [tahsilat] float  NULL,
    [tahsilatFisNo] nvarchar(50)  NULL,
    [tahsilatAciklama] nvarchar(50)  NULL,
    [Aciklama] nvarchar(50)  NULL,
    [yikamaci] nvarchar(50)  NULL,
    [muhasebeci] nvarchar(50)  NULL,
    [tarih] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Tbl_YakitKasasi'
ALTER TABLE [dbo].[Tbl_YakitKasasi]
ADD CONSTRAINT [PK_Tbl_YakitKasasi]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Tbl_MarketKasasi'
ALTER TABLE [dbo].[Tbl_MarketKasasi]
ADD CONSTRAINT [PK_Tbl_MarketKasasi]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Tbl_YikamaKasasi'
ALTER TABLE [dbo].[Tbl_YikamaKasasi]
ADD CONSTRAINT [PK_Tbl_YikamaKasasi]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------