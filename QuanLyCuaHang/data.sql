CREATE DATABASE QLCuaHangApp
GO

USE QLCuaHangApp
GO

-- Creat Table with the primary key and foreign key on delete and update casecade

CREATE TABLE Customers
(
	Customer NVARCHAR(50) NOT NULL PRIMARY KEY,
	NameCus NVARCHAR(50) NOT NULL,
	Adress NVARCHAR(50) NOT NULL,
	Phone NVARCHAR(50),
	Email NVARCHAR(50)
)
GO	

CREATE TABLE Goods
(
	Good NVARCHAR(50) NOT NULL PRIMARY KEY,
	NameGoo NVARCHAR(50) NOT NULL,
	Producer NVARCHAR(50) NOT NULL,
	Numbers INT NOT NULL,
	Warranty NVARCHAR(100),
	Unit NVARCHAR(50),
	Statuss NVARCHAR(50)
)
GO	

CREATE TABLE Supliers
(
	Suplier NVARCHAR(50) NOT NULL PRIMARY KEY,
	NameSup NVARCHAR(50) NOT NULL,
	AddressSup NVARCHAR(50) NOT NULL,
	Phone NVARCHAR(20),
	Email NVARCHAR(50)
)
GO	

CREATE TABLE Staffs
(
	Staff NVARCHAR(50) NOT NULL PRIMARY KEY,
	NameSta NVARCHAR(50) NOT NULL,
	YearBirth INT NOT NULL,
	Sex CHAR(10) NOT NULL,
	AddressSta NVARCHAR(50) NOT NULL,
	Phone NVARCHAR(20),
	Position NVARCHAR(50) NOT NULL,
	Salary NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE Inputs
(
	Input NVARCHAR(50) NOT NULL PRIMARY KEY,
	DateIn DATETIME NOT NULL,
	Staffs NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES dbo.Staffs(Staff) ON DELETE CASCADE ON UPDATE CASCADE,
	Supliers NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES dbo.Supliers(Suplier) ON DELETE CASCADE ON UPDATE CASCADE
)
GO	

CREATE TABLE Outputs
(
	Output NVARCHAR(50) NOT NULL PRIMARY KEY,
	DateOut DATETIME NOT NULL,
	Staffs NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES dbo.Staffs(Staff) ON DELETE CASCADE ON UPDATE CASCADE,
	Customers NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES dbo.Customers(Customer) ON DELETE CASCADE ON UPDATE CASCADE
)
GO	

CREATE TABLE InputInfo
(
	InputInfos NVARCHAR(50) NOT NULL,
	Goods NVARCHAR(50) NOT NULL,
	NumberInput INT NOT NULL,
	PricesInput FLOAT(8) NOT NULL,
	Tax FLOAT(8),
	PRIMARY KEY (InputInfos,Goods),
	FOREIGN KEY (Goods) REFERENCES dbo.Goods(Good) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (InputInfos) REFERENCES dbo.Inputs(Input) ON DELETE CASCADE ON UPDATE CASCADE
)
GO	

CREATE TABLE OutputInfo
(
	OutputInfos NVARCHAR(50) NOT NULL,
	Goods NVARCHAR(50) NOT NULL,
	NumberOutput INT NOT NULL,
	PricesOutput FLOAT(8) NOT NULL,
	Tax FLOAT(8),
	PRIMARY KEY (OutputInfos, Goods), 
	FOREIGN KEY (Goods) REFERENCES dbo.Goods(Good) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (OutputInfos) REFERENCES dbo.Outputs(Output) ON DELETE CASCADE ON UPDATE CASCADE
)
GO	

CREATE TABLE Users
(
	Account NVARCHAR(50) NOT NULL PRIMARY KEY,
	Passwords NVARCHAR NOT NULL,
	Phone NVARCHAR(20),
	AddressUser NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50),
	Permission NVARCHAR(50) NOT NULL
)
GO	

-- CREATE THE PROCEDURE --
--Suplier Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_Suplier
@Suplier NVARCHAR(50),
@NameSup NVARCHAR(50),
@AddressSup NVARCHAR(50),
@Phone NVARCHAR(20),
@Email NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Suplier))
		INSERT INTO dbo.Supliers VALUES
		(@Suplier, @NameSup, @AddressSup, @Phone, @Email)
	ELSE RAISERROR ('It"s EXISTS',12,1)
GO	

	--Procedure Edit Table
CREATE PROC Sp_Update_Suplier
@Suplier NVARCHAR(50),
@NameSup NVARCHAR(50),
@AddressSup NVARCHAR(50),
@Phone NVARCHAR(20),
@Email NVARCHAR(50)
AS
	IF (NOT	EXISTS ( SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Suplier))
		RAISERROR ('Not Exists',12,1)
	ELSE
		UPDATE dbo.Supliers SET NameSup = @NameSup, AddressSup = @AddressSup, Phone = @Phone, Email = @Email WHERE Suplier = @Suplier
GO

--Procedure Delete Table
CREATE PROC Sp_Delete_Suplier
@Suplier NVARCHAR(50)
AS
	IF (NOT	EXISTS ( SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Suplier))
		RAISERROR ('Not Exists',12,1)
	ELSE
		DELETE FROM dbo.Supliers WHERE Suplier = @Suplier	
GO	

--Customer Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_Customer
@Customer NVARCHAR(50),
@NameCus NVARCHAR(50),
@Adress NVARCHAR(50),
@Phone NVARCHAR(50),
@Email NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Customer FROM dbo.Customers WHERE Customer = @Customer))
		INSERT INTO	 dbo.Customers VALUES (@Customer, @NameCus, @Adress, @Phone, @Email)
	ELSE 
		RAISERROR ('It"s EXISTS',12,1)
GO	
	--Procedure Edit Table
CREATE PROC Sp_Update_Customer
@Customer NVARCHAR(50),
@NameCus NVARCHAR(50),
@Adress NVARCHAR(50),
@Phone NVARCHAR(50),
@Email NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Customer FROM dbo.Customers WHERE Customer = @Customer))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		UPDATE dbo.Customers SET Customer = @Customer, NameCus = @NameCus, Adress = @Adress, Phone = @Phone, Email = @Email
GO	
	--Procedure Delete Table
CREATE PROC Sp_Delete_Customer
@Customer NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Customer FROM dbo.Customers WHERE Customer = @Customer))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		DELETE FROM	dbo.Customers WHERE Customer = @Customer
GO
--Staff Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_Staff
@Staff NVARCHAR(50),
@NameSta NVARCHAR(50),
@YearBirth INT ,
@Sex CHAR(10),
@AddressSta NVARCHAR(50),
@Phone NVARCHAR(20),
@Position NVARCHAR(50),
@Salary NVARCHAR(50)
AS 
	IF (NOT EXISTS ( SELECT Staff FROM dbo.Staffs WHERE Staff = @Staff))
		INSERT INTO dbo.Staffs	VALUES (@Staff, @NameSta, @YearBirth, @Sex, @AddressSta, @Phone, @Position, @Salary)
	ELSE	
		RAISERROR ('Not Exists',12,1)
GO	
	-- Procedure Update table
CREATE PROC Sp_Update_Staff
@Staff NVARCHAR(50),
@NameSta NVARCHAR(50),
@YearBirth INT ,
@Sex CHAR(10),
@AddressSta NVARCHAR(50),
@Phone NVARCHAR(20),
@Position NVARCHAR(50),
@Salary NVARCHAR(50)
AS 
	IF (NOT EXISTS ( SELECT Staff FROM dbo.Staffs WHERE Staff = @Staff))
		RAISERROR ('Not Exists',12,1)
	ELSE	
		UPDATE dbo.Staffs SET Staff = @Staff, NameSta = @NameSta, YearBirth = @YearBirth, Sex = @Sex, AddressSta = @AddressSta, Phone = @Phone, Position = @Position, Salary = @Salary
GO	
	-- Procedure Delete table
CREATE PROC Sp_Delete_Staff
@Staff NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Staff FROM dbo.Staffs WHERE Staff = @Staff))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		DELETE FROM	dbo.Staffs WHERE Staff = @Staff
GO
--Goods Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_Good
@Good NVARCHAR(50),
@NameGoo NVARCHAR(50),
@Producer NVARCHAR(50),
@Numbers INT,
@Warranty NVARCHAR(100),
@Unit NVARCHAR(50),
@Statuss NVARCHAR(50)
AS 
	IF (NOT EXISTS ( SELECT Good FROM dbo.Goods WHERE Good = @Good))
		INSERT INTO dbo.Goods VALUES (@Good, @NameGoo, @Producer, @Numbers, @Warranty, @Unit, @Statuss)
	ELSE	
		RAISERROR ('Not Exists',12,1)
GO	
	-- Procedure Update table
CREATE PROC Sp_Update_Good
@Good NVARCHAR(50),
@NameGoo NVARCHAR(50),
@Producer NVARCHAR(50),
@Numbers INT,
@Warranty NVARCHAR(100),
@Unit NVARCHAR(50),
@Statuss NVARCHAR(50)
AS 
	IF (NOT EXISTS ( SELECT Good FROM dbo.Goods WHERE Good = @Good))
		RAISERROR ('Not Exists',12,1)
	ELSE	
		UPDATE dbo.Goods SET Good = @Good, NameGoo = @NameGoo, Producer =@Producer, Numbers = @Numbers, Warranty = @Warranty, Unit = @Unit,Statuss = @Statuss
GO	
	-- Procedure Delete table
CREATE PROC Sp_Delete_Good
@Good NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Good FROM dbo.Goods WHERE Good = @Good))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		DELETE FROM	dbo.Goods WHERE Good = @Good
GO

--Input Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_Input
@Input NVARCHAR(50),
@DateIn DATETIME,
@Staffs NVARCHAR(50),
@Supliers NVARCHAR(50)
AS 
	IF (EXISTS ( SELECT Input FROM dbo.Inputs WHERE Input = @Input))
		RAISERROR ('It"s Exists the Input Code',12,1)
	IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE	Staff = @Staffs))
		RAISERROR ('It"s not Exists the Staff',12,1)
	IF (NOT	 EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Supliers))
		RAISERROR ('It"s not Exists the Suplier',12,1)
	IF (@DateIn > GETDATE())
		RAISERROR ('The Date Input is wrong',12,1)
	ELSE	
		INSERT INTO dbo.Inputs VALUES (@Input, @DateIn , @Staffs, @Supliers)
GO	
	-- Procedure Update table
CREATE PROC Sp_Update_Input
@Input NVARCHAR(50),
@DateIn DATETIME,
@Staffs NVARCHAR(50),
@Supliers NVARCHAR(50)
AS 
	IF (NOT EXISTS ( SELECT Input FROM dbo.Inputs WHERE Input = @Input))
		RAISERROR ('Not Exists the Input Code',12,1)
	IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE	Staff = @Staffs))
		RAISERROR ('It"s not Exists the Staff',12,1)
	IF (NOT	 EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Supliers))
		RAISERROR ('It"s not Exists the Suplier',12,1)
	IF (@DateIn > GETDATE())
		RAISERROR ('The Date Input is wrong',12,1)	
	ELSE	
		UPDATE dbo.Inputs SET Input = @Input, DateIn = @DateIn, Staffs =@Staffs, Supliers = @Supliers
GO	
	-- Procedure Delete table
CREATE PROC Sp_Delete_Input
@Input NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Input FROM dbo.Inputs WHERE Input = @Input))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		DELETE FROM	dbo.Inputs WHERE Input = @Input
GO

--Output Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_Output
@Output NVARCHAR(50),
@DateOut DATETIME,
@Staffs NVARCHAR(50),
@Customers NVARCHAR(50)
AS 
	IF (EXISTS ( SELECT Output FROM dbo.Outputs WHERE Output = @Output))
		RAISERROR ('It"s Exists the Output Code',12,1)
	IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE	Staff = @Staffs))
		RAISERROR ('It"s not Exists the Staff',12,1)
	IF (NOT	 EXISTS (SELECT Customer FROM dbo.Customers WHERE Customer = @Customers))
		RAISERROR ('It"s not Exists the Customer',12,1)
	IF (@DateOut > GETDATE())
		RAISERROR ('The Date Output is wrong',12,1)
	ELSE	
		INSERT INTO dbo.Inputs VALUES (@Output, @DateOut , @Staffs, @Customers)
GO	
	-- Procedure Update table
CREATE PROC Sp_Update_Output
@Output NVARCHAR(50),
@DateOut DATETIME,
@Staffs NVARCHAR(50),
@Customers NVARCHAR(50)
AS 
	IF (NOT	EXISTS ( SELECT Output FROM dbo.Outputs WHERE Output = @Output))
		RAISERROR ('It"s not Exists the Output Code',12,1)
	IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE	Staff = @Staffs))
		RAISERROR ('It"s not Exists the Staff',12,1)
	IF (NOT	 EXISTS (SELECT Customer FROM dbo.Customers WHERE Customer = @Customers))
		RAISERROR ('It"s not Exists the Customer',12,1)
	IF (@DateOut > GETDATE())
		RAISERROR ('The Date Output is wrong',12,1)
	ELSE	
		UPDATE dbo.Outputs SET Output = @Output, DateOut = @DateOut, Staffs =@Staffs, Customers = @Customers
GO	
	-- Procedure Delete table
CREATE PROC Sp_Delete_Output
@Output NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT Output FROM dbo.Outputs WHERE Output = @Output))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		DELETE FROM	dbo.Outputs WHERE Output = @Output
GO

--InputInfo Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_InputInfo
@InputInfos NVARCHAR(50),
@Goods NVARCHAR(50),
@NumberInput INT,
@PricesInput FLOAT(8),
@Tax FLOAT(8)
AS 
	IF (NOT EXISTS (SELECT Good	 FROM	dbo.Goods WHERE	Good = @Goods))
		RAISERROR ('It"s not Exists the Good',12,1)
	IF (@NumberInput < 0) RAISERROR ('The NumberInput is Wrong',12,1)
	IF (@PricesInput < 0) RAISERROR ('The PricesInput is Wrong',12,1)
	IF (NOT EXISTS ( SELECT InputInfos FROM dbo.InputInfo WHERE InputInfos = @InputInfos))
		INSERT INTO dbo.InputInfo VALUES (@InputInfos,@Goods , @NumberInput, @PricesInput, @Tax)
	ELSE	
		RAISERROR ('Not Exists',12,1)
GO	
	-- Procedure Update table
CREATE PROC Sp_Update_InputInfo
@InputInfos NVARCHAR(50),
@Goods NVARCHAR(50),
@NumberInput INT,
@PricesInput FLOAT(8),
@Tax FLOAT(8)
AS 
	IF (NOT EXISTS (SELECT Good	 FROM	dbo.Goods WHERE	Good = @Goods))
		RAISERROR ('It"s not Exists the Good',12,1)
	IF (@NumberInput < 0) RAISERROR ('The NumberInput is Wrong',12,1)
	IF (@PricesInput < 0) RAISERROR ('The PricesInput is Wrong',12,1)
	IF (NOT EXISTS ( SELECT InputInfos FROM dbo.InputInfo WHERE InputInfos = @InputInfos))
		RAISERROR ('Not Exists',12,1)
	ELSE	
		UPDATE dbo.InputInfo SET InputInfos = @InputInfos, Goods = @Goods, NumberInput = @NumberInput, PricesInput = @PricesInput, Tax = @Tax
GO	
	-- Procedure Delete table
CREATE PROC Sp_Delete_InputInfo
@InputInfos NVARCHAR(50),
@Goods NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT InputInfos FROM dbo.InputInfo WHERE InputInfos = @InputInfos))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		DELETE FROM	dbo.InputInfo WHERE InputInfos = @InputInfos AND Goods = @Goods
GO

--OutputInfo Procedure
	-- Procedure Insert table
CREATE PROC Sp_Insert_OutputInfo
@OutputInfos NVARCHAR(50),
@Goods NVARCHAR(50),
@NumberOutput INT,
@PricesOutput FLOAT(8),
@Tax FLOAT(8)
AS 
	IF (NOT EXISTS (SELECT Good	 FROM	dbo.Goods WHERE	Good = @Goods))
		RAISERROR ('It"s not Exists the Good',12,1)
	IF (@NumberOutput > (SELECT Numbers FROM dbo.Goods WHERE Good = @Goods)) 
		RAISERROR ('The NumberOutput cannot be greater the number of good',12,1)
	IF (@PricesOutput < 0) RAISERROR ('The PricesOutput is Wrong',12,1)
	IF (NOT EXISTS ( SELECT OutputInfos FROM dbo.OutputInfo WHERE OutputInfos = @OutputInfos) AND NOT EXISTS (SELECT Good	 FROM	dbo.Goods WHERE	Good = @Goods))
		INSERT INTO dbo.OutputInfo VALUES (@OutputInfos, @Goods, @NumberOutput, @PricesOutput, @Tax)
	ELSE	
		RAISERROR ('Its Exists',12,1)
GO	
	-- Procedure Update table
CREATE PROC Sp_Update_OutputInfo
@OutputInfos NVARCHAR(50),
@Goods NVARCHAR(50),
@NumberOutput INT,
@PricesOutput FLOAT(8),
@Tax FLOAT(8)
AS 
	IF (@NumberOutput > ( SELECT (dbo.Goods.Numbers + dbo.OutputInfo.NumberOutput) FROM dbo.Goods
			INNER JOIN dbo.OutputInfo ON OutputInfo.Goods = Goods.Good WHERE Goods.Good = @Goods AND OutputInfos = @OutputInfos))
		RAISERROR ('NumberOutput is not greater number of Goods',12,1)
	ELSE	
		UPDATE dbo.OutputInfo SET OutputInfos = @OutputInfos, Goods = @Goods, NumberOutput = @NumberOutput, PricesOutput = @PricesOutput, Tax = @Tax
GO	
	-- Procedure Delete table
CREATE PROC Sp_Delete_OutputInfo
@OutputInfos NVARCHAR(50),
@Goods NVARCHAR(50)
AS 
	IF (NOT	EXISTS(SELECT OutputInfos FROM dbo.OutputInfo WHERE OutputInfos = @OutputInfos))
		RAISERROR ('Not Exists',12,1)	
	ELSE 
		DELETE FROM	dbo.OutputInfo WHERE OutputInfos = @OutputInfos AND	Goods = @Goods
GO

-- CREATE THE VIEW
	-- View of the List of input
CREATE VIEW v_ListInput
AS 
SELECT TOP 100 PERCENT dbo.Inputs.Input AS [Mã phiếu nhập], MONTH(dbo.Inputs.DateIn) AS Tháng, YEAR(dbo.Inputs.DateIn) AS Năm, CONVERT(CHAR(10),dbo.Inputs.DateIn,103) AS Ngày,dbo.Goods.Good AS [Tên hàng], NumberInput AS [Số lượng], PricesInput AS [Đơn giá nhập], Tax AS [Thuế], (Tax/100)*NumberInput*PricesInput + PricesInput*NumberInput AS [Thành tiền]
FROM (dbo.Goods INNER JOIN dbo.InputInfo ON InputInfo.Goods = Goods.Good) INNER JOIN dbo.Inputs ON dbo.Inputs.Input = InputInfo.InputInfos
ORDER BY YEAR(dbo.Inputs.DateIn),MONTH(dbo.Inputs.DateIn)

	-- View of the List of output
