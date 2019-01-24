
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/29/2018 06:51:56
-- Generated from EDMX file: C:\Users\v-yanywu\Source\Repos\DennisEFDemoes\DennisEFDemoes_ConsoleApp\EFdemo_LoadMechanism\LoadMechanismModel.edmx
-- --------------------------------------------------

--SET QUOTED_IDENTIFIER OFF;
GO
USE [EF6Recipes];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CustomerTypeId] nvarchar(max)  NOT NULL,
    [CustomerType_CustomerTypeId] int  NOT NULL
);
GO

-- Creating table 'CustomerTypes'
CREATE TABLE [dbo].[CustomerTypes] (
    [CustomerTypeId] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CustomerCustomerId] int  NOT NULL
);
GO

-- Creating table 'CustomerEmails'
CREATE TABLE [dbo].[CustomerEmails] (
    [CustomerEmailId] int IDENTITY(1,1) NOT NULL,
    [CustomerId] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [CustomerCustomerId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CustomerId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- Creating primary key on [CustomerTypeId] in table 'CustomerTypes'
ALTER TABLE [dbo].[CustomerTypes]
ADD CONSTRAINT [PK_CustomerTypes]
    PRIMARY KEY CLUSTERED ([CustomerTypeId] ASC);
GO

-- Creating primary key on [CustomerEmailId] in table 'CustomerEmails'
ALTER TABLE [dbo].[CustomerEmails]
ADD CONSTRAINT [PK_CustomerEmails]
    PRIMARY KEY CLUSTERED ([CustomerEmailId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerType_CustomerTypeId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_CustomerCustomerType]
    FOREIGN KEY ([CustomerType_CustomerTypeId])
    REFERENCES [dbo].[CustomerTypes]
        ([CustomerTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerCustomerType'
CREATE INDEX [IX_FK_CustomerCustomerType]
ON [dbo].[Customers]
    ([CustomerType_CustomerTypeId]);
GO

-- Creating foreign key on [CustomerCustomerId] in table 'CustomerEmails'
ALTER TABLE [dbo].[CustomerEmails]
ADD CONSTRAINT [FK_CustomerCustomerEmail]
    FOREIGN KEY ([CustomerCustomerId])
    REFERENCES [dbo].[Customers]
        ([CustomerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerCustomerEmail'
CREATE INDEX [IX_FK_CustomerCustomerEmail]
ON [dbo].[CustomerEmails]
    ([CustomerCustomerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------