CREATE DATABASE SMarketDB;
GO

USE SMarketDB
GO

CREATE TABLE CategoryTbl
(
	CatId int not null primary key Identity(1,1),
	CatName varchar(50) not null,
	CatDesc varchar(100) not null
)
GO
CREATE TABLE ProductTbl
(
	ProductId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ProductName varchar(50) not null,
	ProductQty int not null,
	ProductPrice int not null,
	ProductCatId int not null FOREIGN KEY REFERENCES CategoryTbl(CatId)
)
GO
CREATE TABLE SellerTbl
(
	 SellerId int not null primary key IDENTITY(1,1),
	 SellerName varchar(50) not null,
	 SellerAge int not null,
	 SellerPhone varchar(50) not null,
	 SellerPass varchar(50) not null
)
GO

CREATE TABLE BillTbl
(
	BillId int not null primary key,
	SellerName varchar(50) not null,
	BillDate varchar(50) not null,
	ToAmt int not null
)
GO
