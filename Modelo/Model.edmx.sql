
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2015 20:13:45
-- Generated from EDMX file: C:\Users\Navegador\Downloads\Libros\Modelo\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Biblioteca];
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

-- Creating table 'Libros'
CREATE TABLE [dbo].[Libros] (
    [isbn] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Paginas] int  NOT NULL,
    [Precio] int  NOT NULL,
    [Autor_dni] int  NOT NULL
);
GO

-- Creating table 'Autores'
CREATE TABLE [dbo].[Autores] (
    [dni] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Editorial_Codigo] int  NOT NULL
);
GO

-- Creating table 'Editoriales'
CREATE TABLE [dbo].[Editoriales] (
    [Codigo] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [isbn] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [PK_Libros]
    PRIMARY KEY CLUSTERED ([isbn] ASC);
GO

-- Creating primary key on [dni] in table 'Autores'
ALTER TABLE [dbo].[Autores]
ADD CONSTRAINT [PK_Autores]
    PRIMARY KEY CLUSTERED ([dni] ASC);
GO

-- Creating primary key on [Codigo] in table 'Editoriales'
ALTER TABLE [dbo].[Editoriales]
ADD CONSTRAINT [PK_Editoriales]
    PRIMARY KEY CLUSTERED ([Codigo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Autor_dni] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [FK_LibroAutor]
    FOREIGN KEY ([Autor_dni])
    REFERENCES [dbo].[Autores]
        ([dni])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LibroAutor'
CREATE INDEX [IX_FK_LibroAutor]
ON [dbo].[Libros]
    ([Autor_dni]);
GO

-- Creating foreign key on [Editorial_Codigo] in table 'Autores'
ALTER TABLE [dbo].[Autores]
ADD CONSTRAINT [FK_AutorEditorial]
    FOREIGN KEY ([Editorial_Codigo])
    REFERENCES [dbo].[Editoriales]
        ([Codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AutorEditorial'
CREATE INDEX [IX_FK_AutorEditorial]
ON [dbo].[Autores]
    ([Editorial_Codigo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------