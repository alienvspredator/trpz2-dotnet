
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/22/2019 08:16:26
-- Generated from EDMX file: C:\Users\sheva\source\repos\trpz2-dotnet\WpfApp4\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [trpz];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_bookauthor_book]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[bookauthor] DROP CONSTRAINT [FK_bookauthor_book];
GO
IF OBJECT_ID(N'[dbo].[FK_bookauthor_author]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[bookauthor] DROP CONSTRAINT [FK_bookauthor_author];
GO
IF OBJECT_ID(N'[dbo].[FK_readerbook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Books1] DROP CONSTRAINT [FK_readerbook];
GO
IF OBJECT_ID(N'[dbo].[FK_historybook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Histories1] DROP CONSTRAINT [FK_historybook];
GO
IF OBJECT_ID(N'[dbo].[FK_historyreader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Histories1] DROP CONSTRAINT [FK_historyreader];
GO
IF OBJECT_ID(N'[dbo].[FK_Author_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People1_Author] DROP CONSTRAINT [FK_Author_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Reader_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People1_Reader] DROP CONSTRAINT [FK_Reader_inherits_Person];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[People1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People1];
GO
IF OBJECT_ID(N'[dbo].[Books1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Books1];
GO
IF OBJECT_ID(N'[dbo].[Histories1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Histories1];
GO
IF OBJECT_ID(N'[dbo].[People1_Author]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People1_Author];
GO
IF OBJECT_ID(N'[dbo].[People1_Reader]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People1_Reader];
GO
IF OBJECT_ID(N'[dbo].[bookauthor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[bookauthor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ReleaseDate] datetime  NOT NULL,
    [reader_Id] int  NULL
);
GO

-- Creating table 'Histories'
CREATE TABLE [dbo].[Histories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ReturnedDate] datetime  NOT NULL,
    [RealReturnedDate] datetime  NULL,
    [TakenDate] datetime  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [book_Id] int  NOT NULL,
    [reader_Id] int  NOT NULL
);
GO

-- Creating table 'People_Author'
CREATE TABLE [dbo].[People_Author] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'People_Reader'
CREATE TABLE [dbo].[People_Reader] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'bookauthor'
CREATE TABLE [dbo].[bookauthor] (
    [books_Id] int  NOT NULL,
    [authors_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Histories'
ALTER TABLE [dbo].[Histories]
ADD CONSTRAINT [PK_Histories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People_Author'
ALTER TABLE [dbo].[People_Author]
ADD CONSTRAINT [PK_People_Author]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People_Reader'
ALTER TABLE [dbo].[People_Reader]
ADD CONSTRAINT [PK_People_Reader]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [books_Id], [authors_Id] in table 'bookauthor'
ALTER TABLE [dbo].[bookauthor]
ADD CONSTRAINT [PK_bookauthor]
    PRIMARY KEY CLUSTERED ([books_Id], [authors_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [books_Id] in table 'bookauthor'
ALTER TABLE [dbo].[bookauthor]
ADD CONSTRAINT [FK_bookauthor_book]
    FOREIGN KEY ([books_Id])
    REFERENCES [dbo].[Books]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [authors_Id] in table 'bookauthor'
ALTER TABLE [dbo].[bookauthor]
ADD CONSTRAINT [FK_bookauthor_author]
    FOREIGN KEY ([authors_Id])
    REFERENCES [dbo].[People_Author]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_bookauthor_author'
CREATE INDEX [IX_FK_bookauthor_author]
ON [dbo].[bookauthor]
    ([authors_Id]);
GO

-- Creating foreign key on [reader_Id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [FK_readerbook]
    FOREIGN KEY ([reader_Id])
    REFERENCES [dbo].[People_Reader]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_readerbook'
CREATE INDEX [IX_FK_readerbook]
ON [dbo].[Books]
    ([reader_Id]);
GO

-- Creating foreign key on [book_Id] in table 'Histories'
ALTER TABLE [dbo].[Histories]
ADD CONSTRAINT [FK_historybook]
    FOREIGN KEY ([book_Id])
    REFERENCES [dbo].[Books]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_historybook'
CREATE INDEX [IX_FK_historybook]
ON [dbo].[Histories]
    ([book_Id]);
GO

-- Creating foreign key on [reader_Id] in table 'Histories'
ALTER TABLE [dbo].[Histories]
ADD CONSTRAINT [FK_historyreader]
    FOREIGN KEY ([reader_Id])
    REFERENCES [dbo].[People_Reader]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_historyreader'
CREATE INDEX [IX_FK_historyreader]
ON [dbo].[Histories]
    ([reader_Id]);
GO

-- Creating foreign key on [Id] in table 'People_Author'
ALTER TABLE [dbo].[People_Author]
ADD CONSTRAINT [FK_Author_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'People_Reader'
ALTER TABLE [dbo].[People_Reader]
ADD CONSTRAINT [FK_Reader_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------