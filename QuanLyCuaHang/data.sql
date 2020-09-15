CREATE DATABASE QLCuaHangApp;
GO

USE QLCuaHangApp;
GO

-- Creat Table with the primary key and foreign key on delete and update casecade

CREATE TABLE Customers
(
    Id INT NOT NULL PRIMARY KEY IDENTITY,
	Customer NVARCHAR(50) NOT NULL,
    NameCus NVARCHAR(50) NOT NULL,
    Adress NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(50),
    Email NVARCHAR(50)
);
GO

CREATE TABLE Goods
(
    Id INT NOT NULL PRIMARY KEY IDENTITY,
	Good NVARCHAR(50) NOT NULL,
    NameGoo NVARCHAR(50) NOT NULL,
    Producer NVARCHAR(50) NOT NULL,
    Numbers INT NOT NULL,
    Warranty NVARCHAR(100),
    Unit NVARCHAR(50),
    Statuss NVARCHAR(50)
);
GO

CREATE TABLE Supliers
(
    Id INT NOT NULL PRIMARY KEY IDENTITY,
	Suplier NVARCHAR(50) NOT NULL,
    NameSup NVARCHAR(50) NOT NULL,
    AddressSup NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(50)
);
GO

CREATE TABLE Staffs
(
    Id INT NOT NULL PRIMARY KEY IDENTITY,
	Staff NVARCHAR(50) NOT NULL,
    NameSta NVARCHAR(50) NOT NULL,
    YearBirth INT NOT NULL,
    Sex CHAR(10) NOT NULL,
    AddressSta NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20),
    Position NVARCHAR(50) NOT NULL,
	 Email NVARCHAR(50),
    Salary INT NOT NULL
);
GO

CREATE TABLE Inputs
(
    Id INT NOT NULL IDENTITY PRIMARY KEY,
	InputCode NVARCHAR(50) NOT NULL ,
    DateIn DATETIME NOT NULL,
    IdStaffs INT NOT NULL
        FOREIGN KEY REFERENCES dbo.Staffs (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    IdSupliers INT NOT NULL
        FOREIGN KEY REFERENCES dbo.Supliers (Id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE Outputs
(
    Id INT NOT NULL  IDENTITY PRIMARY KEY,
	OutputCode NVARCHAR(50) NOT NULL,
    DateOut DATETIME NOT NULL,
    IdStaffs INT NOT NULL
        FOREIGN KEY REFERENCES dbo.Staffs (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    IdCustomers INT NOT NULL
        FOREIGN KEY REFERENCES dbo.Customers (Id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE InputInfo
(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	IdInput INT NOT NULL,
    IdGood INT NOT NULL,
    NumberInput INT NOT NULL,
    PricesInput FLOAT(8) NOT NULL,
    Tax FLOAT(8),
    FOREIGN KEY (IdGood) REFERENCES dbo.Goods (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (IdInput) REFERENCES dbo.Inputs(Id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE OutputInfo
(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	IdOutput INT NOT NULL,
    IdGood INT NOT NULL,
    NumberOutput INT NOT NULL,
    PricesOutput FLOAT(8) NOT NULL,
    Tax FLOAT(8),
    FOREIGN KEY (IdGood) REFERENCES dbo.Goods (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (IdOutput) REFERENCES dbo.Outputs (Id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE Users
(
    Account NVARCHAR(50) NOT NULL PRIMARY KEY,
    Passwords VARCHAR(MAX) NOT NULL,
    Phone NVARCHAR(20),
    AddressUser NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50),
    Permission NVARCHAR(50) NOT NULL
);
GO

-- CREATE THE PROCEDURE --
--Suplier Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Suplier
	@Id INT,
    @Suplier NVARCHAR(50),
    @NameSup NVARCHAR(50),
    @AddressSup NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Id = @Id))
    INSERT INTO dbo.Supliers
    VALUES
    (@Suplier, @NameSup, @AddressSup, @Phone, @Email);
ELSE
    RAISERROR('It"s EXISTS', 12, 1);
GO

--Procedure Edit Table
CREATE PROC Sp_Update_Suplier
	@Id INT,
    @Suplier NVARCHAR(50),
    @NameSup NVARCHAR(50),
    @AddressSup NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.Supliers
    SET Suplier = @Suplier,
		NameSup = @NameSup,
        AddressSup = @AddressSup,
        Phone = @Phone,
        Email = @Email
    WHERE Id = @Id;
GO

--Procedure Delete Table
CREATE PROC Sp_Delete_Suplier 
@Id INT
AS
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Supliers
    WHERE Id = @Id;
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
IF (NOT EXISTS
(
    SELECT Customer
    FROM dbo.Customers
    WHERE Customer = @Customer
)
   )
    INSERT INTO dbo.Customers
    VALUES
    (@Customer, @NameCus, @Adress, @Phone, @Email);
ELSE
    RAISERROR('It"s EXISTS', 12, 1);
GO
--Procedure Edit Table
CREATE PROC Sp_Update_Customer
	@Id INT,
    @Customer NVARCHAR(50),
    @NameCus NVARCHAR(50),
    @Adress NVARCHAR(50),
    @Phone NVARCHAR(50),
    @Email NVARCHAR(50)
AS
IF (NOT EXISTS(SELECT Customer FROM dbo.Customers WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.Customers
    SET Customer = @Customer,
        NameCus = @NameCus,
        Adress = @Adress,
        Phone = @Phone,
        Email = @Email
	WHERE Id = @Id
GO
--Procedure Delete Table
CREATE PROC Sp_Delete_Customer @Id INT
AS
IF (NOT EXISTS
(
    SELECT Customer
    FROM dbo.Customers
    WHERE Id = @Id
)
   )
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Customers
    WHERE Id = @Id;
GO
--Staff Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Staff
	@Id INT,
    @Staff NVARCHAR(50),
    @NameSta NVARCHAR(50),
    @YearBirth INT,
    @Sex CHAR(10),
    @AddressSta NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Position NVARCHAR(50),
	@Email NVARCHAR(50),
    @Salary NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Id = @Id))
    INSERT INTO dbo.Staffs
    VALUES
    (@Staff, @NameSta, @YearBirth, @Sex, @AddressSta, @Phone, @Position,@Email, @Salary);
ELSE
    RAISERROR('Not Exists', 12, 1);
GO
-- Procedure Update table
CREATE PROC Sp_Update_Staff
	@Id INT,
    @Staff NVARCHAR(50),
    @NameSta NVARCHAR(50),
    @YearBirth INT,
    @Sex CHAR(10),
    @AddressSta NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Position NVARCHAR(50),
	@Email NVARCHAR(50),
    @Salary INT
AS
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.Staffs
    SET Staff = @Staff,
        NameSta = @NameSta,
        YearBirth = @YearBirth,
        Sex = @Sex,
        AddressSta = @AddressSta,
        Phone = @Phone,
        Position = @Position,
		Email = @Email,
        Salary = @Salary
	WHERE Id = @Id;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Staff @Id INT
AS
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Staffs
    WHERE Id = @Id;
GO
--Goods Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Good
	@Id INT,
    @Good NVARCHAR(50),
    @NameGoo NVARCHAR(50),
    @Producer NVARCHAR(50),
    @Numbers INT,
    @Warranty NVARCHAR(100),
    @Unit NVARCHAR(50),
    @Statuss NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Id = @Id))
    INSERT INTO dbo.Goods
    VALUES
    (@Good, @NameGoo, @Producer, @Numbers, @Warranty, @Unit, @Statuss);
ELSE
    RAISERROR('Not Exists', 12, 1);
GO
-- Procedure Update table
CREATE PROC Sp_Update_Good
	@Id INT,
    @Good NVARCHAR(50),
    @NameGoo NVARCHAR(50),
    @Producer NVARCHAR(50),
    @Numbers INT,
    @Warranty NVARCHAR(100),
    @Unit NVARCHAR(50),
    @Statuss NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.Goods
    SET Good = @Good,
        NameGoo = @NameGoo,
        Producer = @Producer,
        Numbers = @Numbers,
        Warranty = @Warranty,
        Unit = @Unit,
        Statuss = @Statuss
	WHERE Id = @Id;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Good @Id INT
AS
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Goods
    WHERE Id = @Id;
GO

--Input Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Input
	@Id INT,
    @InputCode NVARCHAR(50),
    @DateIn DATETIME,
    @IdStaffs NVARCHAR(50),
    @IdSupliers NVARCHAR(50)
AS
IF (EXISTS (SELECT Id FROM dbo.Inputs WHERE Id = @Id))
    RAISERROR('It"s Exists the Input Code', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Staffs WHERE Id = @IdStaffs))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Supliers WHERE Id = @IdSupliers))
    RAISERROR('It"s not Exists the Suplier', 12, 1);
IF (@DateIn > GETDATE())
    RAISERROR('The Date Input is wrong', 12, 1);
ELSE
    INSERT INTO dbo.Inputs
    VALUES
    (@InputCode, @DateIn, @IdStaffs, @IdSupliers);
GO
-- Procedure Update table
CREATE PROC Sp_Update_Input
	@Id INT,
    @InputCode NVARCHAR(50),
    @DateIn DATETIME,
    @IdStaffs NVARCHAR(50),
    @IdSupliers NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Id FROM dbo.Inputs WHERE Id = @Id))
    RAISERROR('Not Exists the Input Code', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Staffs WHERE Id = @IdStaffs))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Supliers WHERE Id = @IdSupliers))
    RAISERROR('It"s not Exists the Suplier', 12, 1);
IF (@DateIn > GETDATE())
    RAISERROR('The Date Input is wrong', 12, 1);
ELSE
    UPDATE dbo.Inputs
    SET InputCode = @InputCode,
        DateIn = @DateIn,
        IdStaffs = @IdStaffs,
        IdSupliers = @IdSupliers
	WHERE Id = @Id;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Input @Id INT
AS
IF (NOT EXISTS (SELECT Id FROM dbo.Inputs WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Inputs
    WHERE Id = @Id;
GO

--Output Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Output
	@Id INT,
    @OutputCode NVARCHAR(50),
    @DateOut DATETIME,
    @IdStaffs NVARCHAR(50),
    @IdCustomers NVARCHAR(50)
AS
IF (EXISTS (SELECT Id FROM dbo.Outputs WHERE Id = @Id))
    RAISERROR('It"s Exists the Output Code', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Staffs WHERE Id = @IdStaffs))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS(SELECT Id FROM dbo.Customers WHERE Id = @IdCustomers))
    RAISERROR('It"s not Exists the Customer', 12, 1);
IF (@DateOut > GETDATE())
    RAISERROR('The Date Output is wrong', 12, 1);
ELSE
    INSERT INTO dbo.Outputs VALUES (@OutputCode, @DateOut, @IdStaffs, @IdCustomers);
GO
-- Procedure Update table
CREATE PROC Sp_Update_Output
	@Id INT,
    @OutputCode NVARCHAR(50),
    @DateOut DATETIME,
    @IdStaffs NVARCHAR(50),
    @IdCustomers NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Id FROM dbo.Outputs WHERE Id = @Id))
    RAISERROR('It"s not Exists the Output Code', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Staffs WHERE Id = @IdStaffs	))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS(SELECT Id FROM dbo.Customers WHERE Id = @IdCustomers))
    RAISERROR('It"s not Exists the Customer', 12, 1);
IF (@DateOut > GETDATE())
    RAISERROR('The Date Output is wrong', 12, 1);
ELSE
    UPDATE dbo.Outputs
    SET OutputCode = @OutputCode,
        DateOut = @DateOut,
        IdStaffs = @IdStaffs,
        IdCustomers = @IdCustomers
	WHERE Id = @Id;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Output @Id INT
AS
IF (NOT EXISTS (SELECT Id FROM dbo.Outputs WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Outputs
     WHERE Id = @Id;
GO

--InputInfo Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_InputInfo
	@Id INT,
    @IdInput INT,
    @IdGood INT,
    @NumberInput INT,
    @PricesInput FLOAT(8),
    @Tax FLOAT(8)
AS
IF (NOT EXISTS (SELECT Id FROM dbo.Goods WHERE Id = @IdGood))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Inputs WHERE Id = @IdInput))
    RAISERROR('It"s not Exists the Input', 12, 1);
IF (@NumberInput < 0)
    RAISERROR('The NumberInput is Wrong', 12, 1);
IF (@PricesInput < 0)
    RAISERROR('The PricesInput is Wrong', 12, 1);
IF (NOT EXISTS(SELECT Id FROM dbo.InputInfo WHERE Id = @Id))
    INSERT INTO dbo.InputInfo
    VALUES
    (@IdInput, @IdGood, @NumberInput, @PricesInput, @Tax);
ELSE
    RAISERROR('Not Exists', 12, 1);
GO
-- Procedure Update table
CREATE PROC Sp_Update_InputInfo
	@Id INT,
    @IdInput INT,
    @IdGood INT,
    @NumberInput INT,
    @PricesInput FLOAT(8),
    @Tax FLOAT(8)
AS
IF (NOT EXISTS (SELECT Id FROM dbo.Goods WHERE Id = @IdGood))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Inputs WHERE Id = @IdInput))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (@NumberInput < 0)
    RAISERROR('The NumberInput is Wrong', 12, 1);
IF (@PricesInput < 0)
    RAISERROR('The PricesInput is Wrong', 12, 1);
IF (NOT EXISTS(SELECT Id FROM dbo.InputInfo WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.InputInfo
    SET IdInput = @IdInput,
        IdGood = @IdGood,
        NumberInput = @NumberInput,
        PricesInput = @PricesInput,
        Tax = @Tax
	WHERE Id = @Id;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_InputInfo @Id INT
AS
IF (NOT EXISTS(SELECT Id FROM dbo.InputInfo WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.InputInfo
    WHERE Id = @Id;
GO

--OutputInfo Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_OutputInfo
	@Id INT,
    @IdOutput INT,
    @IdGood INT,
    @NumberOutput INT,
    @PricesOutput FLOAT(8),
    @Tax FLOAT(8)
AS
IF (NOT EXISTS (SELECT Id FROM dbo.Goods WHERE Id = @IdGood))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Outputs WHERE Id = @IdOutput))
    RAISERROR('It"s not Exists the Output', 12, 1);
IF (@NumberOutput > (SELECT Numbers FROM dbo.Goods WHERE Id = @IdGood))
    RAISERROR('The NumberOutput cannot be greater the number of good', 12, 1);
IF (@PricesOutput < 0)
    RAISERROR('The PricesOutput is Wrong', 12, 1);
IF (NOT EXISTS(SELECT Id FROM dbo.OutputInfo WHERE Id = @Id))
    INSERT INTO dbo.OutputInfo
    VALUES (@IdOutput, @IdGood, @NumberOutput, @PricesOutput, @Tax);
ELSE
    RAISERROR('Its Exists', 12, 1);
GO
-- Procedure Update table
CREATE PROC Sp_Update_OutputInfo
    @Id INT,
    @IdOutput INT,
    @IdGood INT,
    @NumberOutput INT,
    @PricesOutput FLOAT(8),
    @Tax FLOAT(8)
AS
IF (@NumberOutput > (SELECT (dbo.Goods.Numbers + dbo.OutputInfo.NumberOutput) 
						FROM dbo.Goods INNER JOIN dbo.OutputInfo               
						ON OutputInfo.IdGood = Goods.Id WHERE Goods.Id = @IdGood AND dbo.OutputInfo.IdOutput = @IdOutput))
    RAISERROR('NumberOutput is not greater number of Goods', 12, 1);
IF (@PricesOutput < 0)
    RAISERROR('The PricesOutput is Wrong', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Goods WHERE Id = @IdGood))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (NOT EXISTS (SELECT Id FROM dbo.Outputs WHERE Id = @IdOutput))
    RAISERROR('It"s not Exists the Output', 12, 1);
IF (EXISTS(SELECT Id FROM dbo.OutputInfo WHERE Id = @Id))
    UPDATE dbo.OutputInfo
    SET IdOutput = @IdOutput,
        IdGood = @IdGood,
        NumberOutput = @NumberOutput,
        PricesOutput = @PricesOutput,
        Tax = @Tax
	WHERE Id = @Id;
ELSE RAISERROR('Not Exists', 12, 1);
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_OutputInfo @Id INT
AS
IF (NOT EXISTS(SELECT Id FROM dbo.OutputInfo  WHERE Id = @Id))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.OutputInfo
    WHERE Id = @Id
GO
-- Procedure ChangePassword User
CREATE PROC Sp_ChangePass_User 
	@OldPass NVARCHAR(MAX),
	@NewPass NVARCHAR(MAX),
	@RepeatPass NVARCHAR(MAX),
	@UserName NVARCHAR(50)
AS
IF (NOT	EXISTS (SELECT Account FROM dbo.Users WHERE Account = @UserName AND Passwords = @OldPass) AND @NewPass = @RepeatPass)
	RAISERROR('Password is Wrong', 12, 1)
ELSE UPDATE dbo.Users
	SET Passwords = @NewPass
	WHERE Account = @UserName;
GO	

-- CREATE THE VIEW
-- View of the List of input
CREATE VIEW v_ListInput
AS
SELECT TOP 100 PERCENT
       dbo.Inputs.InputCode AS [Maphieunhap],
	   inputs.DateIn AS Ngaynhap,
       MONTH(dbo.Inputs.DateIn) AS Thang,
       YEAR(dbo.Inputs.DateIn) AS Nam,
       CONVERT(CHAR(10), dbo.Inputs.DateIn, 103) AS Ngay,
	   dbo.Goods.Good AS Mahang,
       dbo.Goods.NameGoo AS Tenhang,
       NumberInput AS Soluongnhap,
       PricesInput AS Dongianhap,
       Tax AS Thue,
       (Tax / 100) * NumberInput * PricesInput + PricesInput * NumberInput AS Thanhtien
FROM(dbo.Goods
    INNER JOIN dbo.InputInfo
        ON InputInfo.IdGood = Goods.Id)
    INNER JOIN dbo.Inputs
        ON dbo.Inputs.Id = InputInfo.IdInput
ORDER BY YEAR(dbo.Inputs.DateIn),
         MONTH(dbo.Inputs.DateIn);
GO


-- View of the List of output
CREATE VIEW v_ListOutput
AS 
SELECT TOP 100 PERCENT
	dbo.Outputs.OutputCode AS Maphieuxuat,
	dbo.Outputs.DateOut AS Ngayxuat,
	CONVERT(CHAR(10),dbo.Outputs.DateOut,103) AS Ngay,
	MONTH(dbo.Outputs.DateOut) AS Thang,
	YEAR(dbo.Outputs.DateOut) AS Nam,
	dbo.Goods.Good AS Mahang,
	dbo.Goods.NameGoo AS Tenhang,
	NumberOutput AS Soluongxuat,
	PricesOutput AS Giaxuat,
	Tax AS Thue,
	((Tax/100)*NumberOutput*PricesOutput + NumberOutput*PricesOutput) AS Thanhtien
FROM (dbo.Goods INNER JOIN dbo.OutputInfo ON Goods.Id = OutputInfo.IdGood) INNER JOIN dbo.Outputs ON dbo.Outputs.Id = dbo.OutputInfo.IdOutput
ORDER BY YEAR(dbo.Outputs.DateOut),MONTH(dbo.Outputs.DateOut)
GO

-- CHƯA CHỈNH SỦA CÁC ID CỦA TABLE
---- View of the Revenue (Doanh thu)
--CREATE VIEW v_Doanhthu
--AS
--SELECT 
--	TOP 100 PERCENT MONTH(inputs.DateIn) AS Thang, YEAR(Inputs.DateIn) AS Nam,
--	SUM(InputInfo.Tax/100*NumberInput*PricesInput + NumberInput*PricesInput) AS Tongnhap,
--	SUM(dbo.OutputInfo.Tax/100*NumberOutput*PricesOutput + NumberOutput*PricesOutput) AS Tongxuat,
--	(SUM(dbo.OutputInfo.Tax/100*NumberOutput*PricesOutput + NumberOutput*PricesOutput) - SUM(InputInfo.Tax/100*NumberInput*PricesInput + NumberInput*PricesInput)) AS Doanhthu,
--	Tinhtrang = CASE
--		WHEN (SUM(NumberOutput*PricesOutput) - SUM(NumberInput*PricesInput) < 0) THEN N'Lỗ'
--		WHEN (SUM(NumberOutput*PricesOutput) - SUM(NumberInput*PricesInput) = 0) THEN N'Hòa'
--		WHEN (SUM(NumberOutput*PricesOutput) - SUM(NumberInput*PricesInput) > 0) THEN N'Lời'
--	END
--FROM dbo.Inputs,dbo.InputInfo,dbo.OutputInfo,dbo.Outputs WHERE MONTH(inputs.DateIn) = MONTH(dbo.Outputs.DateOut) AND YEAR(dbo.Inputs.DateIn) = YEAR(outputs.DateOut)
--GROUP BY MONTH(inputs.DateIn), YEAR(dbo.Inputs.DateIn)
--ORDER BY YEAR(dbo.Inputs.DateIn), MONTH(inputs.DateIn)
--GO
	
---- View of the Input
--CREATE	VIEW v_Input
--AS 
--SELECT staffs.NameSta AS Tennhanvien, Supliers.NameSup AS Nhacungcap, Supliers.AddressSup AS DiachiNCC, Supliers.Phone AS Dienthoai,
--		Supliers.Email AS [Email], inputs.Input AS Maphieunhap, CONVERT(CHAR(10),inputs.DateIn,103) AS Ngaynhap, goods.NameGoo AS Tenhang,
--		dbo.Goods.Statuss AS Mota,dbo.Goods.Unit AS Donvitinh, InputInfo.Tax AS Thuenhap, (dbo.InputInfo.NumberInput*PricesInput*InputInfo.Tax/100) AS Tienthue,
--		(NumberInput*PricesInput) + (dbo.InputInfo.NumberInput*PricesInput*InputInfo.Tax/100) AS Tongiatri
--FROM (((dbo.Goods INNER JOIN dbo.InputInfo ON	goods.Good = dbo.InputInfo.Goods) INNER JOIN dbo.Inputs
--	ON Inputs.Input = InputInfo.InputInfos) INNER JOIN dbo.Supliers
--	ON dbo.Supliers.Suplier = inputs.Supliers) INNER JOIN dbo.Staffs 
--	ON Staffs.Staff = Inputs.Staffs

---- View of the Output
--CREATE VIEW v_Output
--AS 
--SELECT staffs.NameSta AS Tennhanvien, dbo.Customers.NameCus AS Khachhang, dbo.Customers.Adress	 AS DiachiKhachhang, dbo.Customers.Phone AS Dienthoai,
--		dbo.Customers.Email AS [Email], dbo.Outputs.Output AS Maphieuxuat, CONVERT(CHAR(10),dbo.Outputs.DateOut,103) AS Ngayxuat, goods.NameGoo AS Tenhang,
--		dbo.Goods.Statuss AS Mota,dbo.Goods.Unit AS Donvitinh, dbo.OutputInfo.Tax AS Thuexuat, (dbo.OutputInfo.NumberOutput*PricesOutput*OutputInfo.Tax/100) AS Tienthue,
--		(dbo.OutputInfo.NumberOutput*PricesOutput) + (dbo.OutputInfo.NumberOutput*PricesOutput*OutputInfo.Tax/100) AS Tonggiatri
--FROM (((dbo.Goods INNER JOIN dbo.OutputInfo ON	goods.Good = dbo.OutputInfo.Goods) INNER JOIN dbo.Outputs
--	ON Outputs.Output = OutputInfo.OutputInfos) INNER JOIN dbo.Customers
--	ON dbo.Customers.Customer = dbo.Outputs.Customers) INNER JOIN dbo.Staffs 
--	ON Staffs.Staff = dbo.Outputs.Staffs
--GO

-- CREATE THE TRIGGER
	--Trigger for InputInfo
	--Trigger to Add the number good
CREATE TRIGGER TG_Insert_InputInfo ON dbo.InputInfo
FOR	INSERT
AS
UPDATE dbo.Goods SET Goods.Numbers = dbo.Goods.Numbers + Inserted.NumberInput 
	FROM dbo.Goods INNER JOIN Inserted ON Inserted.IdGood = Goods.Id
GO	
	--Trigger to Update the number good
CREATE TRIGGER TG_Update_InputInfo ON dbo.InputInfo
FOR UPDATE
AS
IF UPDATE(NumberInput)
BEGIN
	DECLARE @IdGood INT
	DECLARE @numberinput INT	
	DECLARE contro CURSOR FOR 
		SELECT Inserted.IdGood, Inserted.NumberInput - Deleted.NumberInput AS NumberInput
		FROM Inserted INNER JOIN Deleted ON Deleted.IdGood = Inserted.IdGood AND Deleted.IdInput = Inserted.IdInput
	OPEN contro
	FETCH NEXT FROM contro INTO @IdGood,@numberinput
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.Goods SET Numbers = Numbers + @numberinput WHERE goods.Id = @IdGood
		FETCH NEXT FROM contro INTO @IdGood, @numberinput
	END
	CLOSE contro
	DEALLOCATE contro
END
GO	
	-- Trigger to Delete the number good
CREATE TRIGGER TG_Delete_InputInfo ON dbo.InputInfo
FOR DELETE
AS
IF UPDATE(NumberInput)
BEGIN
	DECLARE @idgood NVARCHAR(50)
	DECLARE @numberinput INT	
	DECLARE contro CURSOR FOR 
		SELECT Deleted.Id, Deleted.NumberInput AS NumberInput
		FROM Deleted
	OPEN contro
	FETCH NEXT FROM contro INTO @idgood,@numberinput
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.Goods SET Numbers = Numbers - @numberinput WHERE goods.Id = @idgood
		FETCH NEXT FROM contro INTO @idgood, @numberinput
	END
	CLOSE contro
	DEALLOCATE contro
END
GO

--Trigger for OutputInfo
	--Trigger to Add the number good
CREATE TRIGGER TG_Insert_OutputInfo ON dbo.OutputInfo
FOR	INSERT
AS
UPDATE dbo.Goods SET Goods.Numbers = goods.Numbers - Inserted.NumberOutput
	FROM dbo.Goods INNER JOIN Inserted ON Inserted.IdGood = Goods.Id
GO	
	--Trigger to Update the number good
CREATE TRIGGER TG_Update_OutputInfo ON dbo.OutputInfo
FOR UPDATE
AS
IF UPDATE(NumberOutput)
BEGIN
	DECLARE @idgood NVARCHAR(50)
	DECLARE @numberoutput INT
	DECLARE @loi nvarchar(100)
	DECLARE contro CURSOR FOR 
		SELECT Inserted.IdGood, Inserted.NumberOutput - Deleted.NumberOutput AS Numberoutput
		FROM Inserted INNER JOIN Deleted ON Deleted.IdGood = Inserted.IdGood AND Deleted.IdOutput = Inserted.IdOutput
	IF (@numberoutput > (SELECT Numbers FROM Inserted,dbo.Goods WHERE goods.Id = Inserted.IdGood))
	BEGIN 
		SET @loi = N'Số lượng xuất lớn hơn số lượng tồn kho, không thể xuất'
		RAISERROR(@loi,16,1)
		RETURN
	END
	ELSE
	BEGIN	
		OPEN contro
		FETCH NEXT FROM contro INTO @idgood,@numberoutput
		WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE dbo.Goods SET Numbers = Numbers - @numberoutput WHERE goods.Id = @idgood
			FETCH NEXT FROM contro INTO @idgood, @numberoutput
		END
		CLOSE contro
		DEALLOCATE contro
	END
END	
GO	
	-- Trigger to Delete the number good
CREATE TRIGGER TG_Delete_OutputInfo ON dbo.OutputInfo
FOR DELETE
AS
IF UPDATE(NumberOutput)
BEGIN
	DECLARE @idgood NVARCHAR(50)
	DECLARE @numberoutput INT	
	DECLARE contro CURSOR FOR 
		SELECT Deleted.IdGood, Deleted.NumberOutput AS Numberoutput
		FROM Deleted
	OPEN contro
	FETCH NEXT FROM contro INTO @idgood,@numberoutput
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.Goods SET Numbers = Numbers + @numberoutput WHERE goods.Id = @idgood
		FETCH NEXT FROM contro INTO @idgood, @numberoutput
	END
	CLOSE contro
	DEALLOCATE contro
END
GO

--Insert User

INSERT INTO dbo.Users(Account,    Passwords,    Phone,    AddressUser,    Email,    Permission)
VALUES
(   N'admin', -- Account - nvarchar(50)
    N'db69fc039dcbd2962cb4d28f5891aae1', -- Passwords - nvarchar(max)
    N'123456789', -- Phone - nvarchar(20)
    N'admin', -- AddressUser - nvarchar(50)
    N'admin@gmail.com', -- Email - nvarchar(50)
    N'admin'  -- Permission - nvarchar(50)
)
GO
INSERT INTO dbo.Users(Account,    Passwords,    Phone,    AddressUser,    Email,    Permission)
VALUES
(   N'staff', -- Account - nvarchar(50)
    N'978aae9bb6bee8fb75de3e4830a1be46', -- Passwords - nvarchar(max)
    N'123456789', -- Phone - nvarchar(20)
    N'staff', -- AddressUser - nvarchar(50)
    N'staff@gmail.com', -- Email - nvarchar(50)
    N'staff'  -- Permission - nvarchar(50)
    )
GO 
INSERT INTO dbo.Users(Account,    Passwords,    Phone,    AddressUser,    Email,    Permission)
VALUES
(   N'orther', -- Account - nvarchar(50)
    N'f1bca034ec451bd9dafbbeaac9fece35', -- Passwords - nvarchar(max)
    N'123456789', -- Phone - nvarchar(20)
    N'orther', -- AddressUser - nvarchar(50)
    N'orther@gmail.com', -- Email - nvarchar(50)
    N'orther'  -- Permission - nvarchar(50)
)
GO 