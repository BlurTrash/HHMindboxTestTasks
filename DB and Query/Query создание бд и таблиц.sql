CREATE DATABASE HHTask2MindboxDB
go

use HHTask2MindboxDB
go

CREATE TABLE Products(
Id int PRIMARY KEY IDENTITY(1,1),
Name NVARCHAR(50) NOT NULL)

CREATE TABLE Categories(
Id int PRIMARY KEY IDENTITY(1,1),
Name NVARCHAR(50) NOT NULL)

CREATE TABLE ProductsCategories(
ProductId int NOT NULL,
CategoryId int NOT NULL,
CONSTRAINT PK_ProductId_CategoryId PRIMARY KEY CLUSTERED(ProductId, CategoryId),
CONSTRAINT FK_ProductsCategories_Products FOREIGN KEY(ProductId) REFERENCES Products(Id),
CONSTRAINT FK_ProductsCategories_Categories FOREIGN KEY(CategoryId) REFERENCES Categories(Id))
go