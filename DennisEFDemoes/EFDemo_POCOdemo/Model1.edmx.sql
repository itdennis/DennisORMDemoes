
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/01/2019 18:10:40
-- Generated from EDMX file: C:\Users\v-yanywu\Source\Repos\DennisEFDemoes\DennisEFDemoes\EFDemo_POCOdemo\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Flights]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Flights];
GO
IF OBJECT_ID(N'[dbo].[Rankers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rankers];
GO
IF OBJECT_ID(N'[dbo].[Slots]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Slots];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Flights'
CREATE TABLE [dbo].[Flights] (
    [FlightId] bigint  NOT NULL,
    [FlightName] nvarchar(max)  NOT NULL,
    [FlightOwner] nvarchar(max)  NOT NULL,
    [FlightPara1] nvarchar(max)  NULL,
    [FlightPara3] nvarchar(max)  NULL
);
GO

-- Creating table 'Rankers'
CREATE TABLE [dbo].[Rankers] (
    [RankerId] bigint  NOT NULL,
    [RankerName] nvarchar(max)  NOT NULL,
    [RankerPath] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Slots'
CREATE TABLE [dbo].[Slots] (
    [SlotId] bigint  NOT NULL,
    [SlotName] nvarchar(max)  NOT NULL,
    [SlotOwner] nvarchar(max)  NOT NULL,
    [FlightUsage] nvarchar(max)  NOT NULL,
    [RankerUsage] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [FlightId] in table 'Flights'
ALTER TABLE [dbo].[Flights]
ADD CONSTRAINT [PK_Flights]
    PRIMARY KEY CLUSTERED ([FlightId] ASC);
GO

-- Creating primary key on [RankerId] in table 'Rankers'
ALTER TABLE [dbo].[Rankers]
ADD CONSTRAINT [PK_Rankers]
    PRIMARY KEY CLUSTERED ([RankerId] ASC);
GO

-- Creating primary key on [SlotId] in table 'Slots'
ALTER TABLE [dbo].[Slots]
ADD CONSTRAINT [PK_Slots]
    PRIMARY KEY CLUSTERED ([SlotId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------