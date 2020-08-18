CREATE DATABASE QLCuaHangApp;
GO

USE QLCuaHangApp;
GO

-- Creat Table with the primary key and foreign key on delete and update casecade

CREATE TABLE Customers
(
    Customer NVARCHAR(50) NOT NULL PRIMARY KEY,
    NameCus NVARCHAR(50) NOT NULL,
    Adress NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(50),
    Email NVARCHAR(50)
);
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
);
GO

CREATE TABLE Supliers
(
    Suplier NVARCHAR(50) NOT NULL PRIMARY KEY,
    NameSup NVARCHAR(50) NOT NULL,
    AddressSup NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(50)
);
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
);
GO

CREATE TABLE Inputs
(
    Input NVARCHAR(50) NOT NULL PRIMARY KEY,
    DateIn DATETIME NOT NULL,
    Staffs NVARCHAR(50) NOT NULL
        FOREIGN KEY REFERENCES dbo.Staffs (Staff) ON DELETE CASCADE ON UPDATE CASCADE,
    Supliers NVARCHAR(50) NOT NULL
        FOREIGN KEY REFERENCES dbo.Supliers (Suplier) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE Outputs
(
    Output NVARCHAR(50) NOT NULL PRIMARY KEY,
    DateOut DATETIME NOT NULL,
    Staffs NVARCHAR(50) NOT NULL
        FOREIGN KEY REFERENCES dbo.Staffs (Staff) ON DELETE CASCADE ON UPDATE CASCADE,
    Customers NVARCHAR(50) NOT NULL
        FOREIGN KEY REFERENCES dbo.Customers (Customer) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE InputInfo
(
    InputInfos NVARCHAR(50) NOT NULL,
    Goods NVARCHAR(50) NOT NULL,
    NumberInput INT NOT NULL,
    PricesInput FLOAT(8) NOT NULL,
    Tax FLOAT(8),
    PRIMARY KEY (
                    InputInfos,
                    Goods
                ),
    FOREIGN KEY (Goods) REFERENCES dbo.Goods (Good) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (InputInfos) REFERENCES dbo.Inputs (Input) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE OutputInfo
(
    OutputInfos NVARCHAR(50) NOT NULL,
    Goods NVARCHAR(50) NOT NULL,
    NumberOutput INT NOT NULL,
    PricesOutput FLOAT(8) NOT NULL,
    Tax FLOAT(8),
    PRIMARY KEY (
                    OutputInfos,
                    Goods
                ),
    FOREIGN KEY (Goods) REFERENCES dbo.Goods (Good) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (OutputInfos) REFERENCES dbo.Outputs (Output) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE Users
(
    Account NVARCHAR(50) NOT NULL PRIMARY KEY,
    Passwords NVARCHAR NOT NULL,
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
    @Suplier NVARCHAR(50),
    @NameSup NVARCHAR(50),
    @AddressSup NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Suplier))
    INSERT INTO dbo.Supliers
    VALUES
    (@Suplier, @NameSup, @AddressSup, @Phone, @Email);
ELSE
    RAISERROR('It"s EXISTS', 12, 1);
GO

--Procedure Edit Table
CREATE PROC Sp_Update_Suplier
    @Suplier NVARCHAR(50),
    @NameSup NVARCHAR(50),
    @AddressSup NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Suplier))
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.Supliers
    SET NameSup = @NameSup,
        AddressSup = @AddressSup,
        Phone = @Phone,
        Email = @Email
    WHERE Suplier = @Suplier;
GO

--Procedure Delete Table
CREATE PROC Sp_Delete_Suplier @Suplier NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Suplier))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Supliers
    WHERE Suplier = @Suplier;
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
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.Customers
    SET Customer = @Customer,
        NameCus = @NameCus,
        Adress = @Adress,
        Phone = @Phone,
        Email = @Email;
GO
--Procedure Delete Table
CREATE PROC Sp_Delete_Customer @Customer NVARCHAR(50)
AS
IF (NOT EXISTS
(
    SELECT Customer
    FROM dbo.Customers
    WHERE Customer = @Customer
)
   )
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Customers
    WHERE Customer = @Customer;
GO
--Staff Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Staff
    @Staff NVARCHAR(50),
    @NameSta NVARCHAR(50),
    @YearBirth INT,
    @Sex CHAR(10),
    @AddressSta NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Position NVARCHAR(50),
    @Salary NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Staff = @Staff))
    INSERT INTO dbo.Staffs
    VALUES
    (@Staff, @NameSta, @YearBirth, @Sex, @AddressSta, @Phone, @Position, @Salary);
ELSE
    RAISERROR('Not Exists', 12, 1);
GO
-- Procedure Update table
CREATE PROC Sp_Update_Staff
    @Staff NVARCHAR(50),
    @NameSta NVARCHAR(50),
    @YearBirth INT,
    @Sex CHAR(10),
    @AddressSta NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Position NVARCHAR(50),
    @Salary NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Staff = @Staff))
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
        Salary = @Salary;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Staff @Staff NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Staff = @Staff))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Staffs
    WHERE Staff = @Staff;
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
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Good = @Good))
    INSERT INTO dbo.Goods
    VALUES
    (@Good, @NameGoo, @Producer, @Numbers, @Warranty, @Unit, @Statuss);
ELSE
    RAISERROR('Not Exists', 12, 1);
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
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Good = @Good))
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.Goods
    SET Good = @Good,
        NameGoo = @NameGoo,
        Producer = @Producer,
        Numbers = @Numbers,
        Warranty = @Warranty,
        Unit = @Unit,
        Statuss = @Statuss;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Good @Good NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Good = @Good))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Goods
    WHERE Good = @Good;
GO

--Input Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Input
    @Input NVARCHAR(50),
    @DateIn DATETIME,
    @Staffs NVARCHAR(50),
    @Supliers NVARCHAR(50)
AS
IF (EXISTS (SELECT Input FROM dbo.Inputs WHERE Input = @Input))
    RAISERROR('It"s Exists the Input Code', 12, 1);
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Staff = @Staffs))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Supliers))
    RAISERROR('It"s not Exists the Suplier', 12, 1);
IF (@DateIn > GETDATE())
    RAISERROR('The Date Input is wrong', 12, 1);
ELSE
    INSERT INTO dbo.Inputs
    VALUES
    (@Input, @DateIn, @Staffs, @Supliers);
GO
-- Procedure Update table
CREATE PROC Sp_Update_Input
    @Input NVARCHAR(50),
    @DateIn DATETIME,
    @Staffs NVARCHAR(50),
    @Supliers NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Input FROM dbo.Inputs WHERE Input = @Input))
    RAISERROR('Not Exists the Input Code', 12, 1);
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Staff = @Staffs))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS (SELECT Suplier FROM dbo.Supliers WHERE Suplier = @Supliers))
    RAISERROR('It"s not Exists the Suplier', 12, 1);
IF (@DateIn > GETDATE())
    RAISERROR('The Date Input is wrong', 12, 1);
ELSE
    UPDATE dbo.Inputs
    SET Input = @Input,
        DateIn = @DateIn,
        Staffs = @Staffs,
        Supliers = @Supliers;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Input @Input NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Input FROM dbo.Inputs WHERE Input = @Input))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Inputs
    WHERE Input = @Input;
GO

--Output Procedure
-- Procedure Insert table
CREATE PROC Sp_Insert_Output
    @Output NVARCHAR(50),
    @DateOut DATETIME,
    @Staffs NVARCHAR(50),
    @Customers NVARCHAR(50)
AS
IF (EXISTS (SELECT Output FROM dbo.Outputs WHERE Output = @Output))
    RAISERROR('It"s Exists the Output Code', 12, 1);
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Staff = @Staffs))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS
(
    SELECT Customer
    FROM dbo.Customers
    WHERE Customer = @Customers
)
   )
    RAISERROR('It"s not Exists the Customer', 12, 1);
IF (@DateOut > GETDATE())
    RAISERROR('The Date Output is wrong', 12, 1);
ELSE
    INSERT INTO dbo.Inputs
    VALUES
    (@Output, @DateOut, @Staffs, @Customers);
GO
-- Procedure Update table
CREATE PROC Sp_Update_Output
    @Output NVARCHAR(50),
    @DateOut DATETIME,
    @Staffs NVARCHAR(50),
    @Customers NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Output FROM dbo.Outputs WHERE Output = @Output))
    RAISERROR('It"s not Exists the Output Code', 12, 1);
IF (NOT EXISTS (SELECT Staff FROM dbo.Staffs WHERE Staff = @Staffs))
    RAISERROR('It"s not Exists the Staff', 12, 1);
IF (NOT EXISTS
(
    SELECT Customer
    FROM dbo.Customers
    WHERE Customer = @Customers
)
   )
    RAISERROR('It"s not Exists the Customer', 12, 1);
IF (@DateOut > GETDATE())
    RAISERROR('The Date Output is wrong', 12, 1);
ELSE
    UPDATE dbo.Outputs
    SET Output = @Output,
        DateOut = @DateOut,
        Staffs = @Staffs,
        Customers = @Customers;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_Output @Output NVARCHAR(50)
AS
IF (NOT EXISTS (SELECT Output FROM dbo.Outputs WHERE Output = @Output))
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.Outputs
    WHERE Output = @Output;
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
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Good = @Goods))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (@NumberInput < 0)
    RAISERROR('The NumberInput is Wrong', 12, 1);
IF (@PricesInput < 0)
    RAISERROR('The PricesInput is Wrong', 12, 1);
IF (NOT EXISTS
(
    SELECT InputInfos
    FROM dbo.InputInfo
    WHERE InputInfos = @InputInfos
)
   )
    INSERT INTO dbo.InputInfo
    VALUES
    (@InputInfos, @Goods, @NumberInput, @PricesInput, @Tax);
ELSE
    RAISERROR('Not Exists', 12, 1);
GO
-- Procedure Update table
CREATE PROC Sp_Update_InputInfo
    @InputInfos NVARCHAR(50),
    @Goods NVARCHAR(50),
    @NumberInput INT,
    @PricesInput FLOAT(8),
    @Tax FLOAT(8)
AS
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Good = @Goods))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (@NumberInput < 0)
    RAISERROR('The NumberInput is Wrong', 12, 1);
IF (@PricesInput < 0)
    RAISERROR('The PricesInput is Wrong', 12, 1);
IF (NOT EXISTS
(
    SELECT InputInfos
    FROM dbo.InputInfo
    WHERE InputInfos = @InputInfos
)
   )
    RAISERROR('Not Exists', 12, 1);
ELSE
    UPDATE dbo.InputInfo
    SET InputInfos = @InputInfos,
        Goods = @Goods,
        NumberInput = @NumberInput,
        PricesInput = @PricesInput,
        Tax = @Tax;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_InputInfo
    @InputInfos NVARCHAR(50),
    @Goods NVARCHAR(50)
AS
IF (NOT EXISTS
(
    SELECT InputInfos
    FROM dbo.InputInfo
    WHERE InputInfos = @InputInfos
)
   )
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.InputInfo
    WHERE InputInfos = @InputInfos
          AND Goods = @Goods;
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
IF (NOT EXISTS (SELECT Good FROM dbo.Goods WHERE Good = @Goods))
    RAISERROR('It"s not Exists the Good', 12, 1);
IF (@NumberOutput > (SELECT Numbers FROM dbo.Goods WHERE Good = @Goods))
    RAISERROR('The NumberOutput cannot be greater the number of good', 12, 1);
IF (@PricesOutput < 0)
    RAISERROR('The PricesOutput is Wrong', 12, 1);
IF (
       NOT EXISTS
(
    SELECT OutputInfos
    FROM dbo.OutputInfo
    WHERE OutputInfos = @OutputInfos
)
       AND NOT EXISTS
(
    SELECT Good
    FROM dbo.Goods
    WHERE Good = @Goods
)
   )
    INSERT INTO dbo.OutputInfo
    VALUES
    (@OutputInfos, @Goods, @NumberOutput, @PricesOutput, @Tax);
ELSE
    RAISERROR('Its Exists', 12, 1);
GO
-- Procedure Update table
CREATE PROC Sp_Update_OutputInfo
    @OutputInfos NVARCHAR(50),
    @Goods NVARCHAR(50),
    @NumberOutput INT,
    @PricesOutput FLOAT(8),
    @Tax FLOAT(8)
AS
IF (@NumberOutput >
   (
       SELECT (dbo.Goods.Numbers + dbo.OutputInfo.NumberOutput)
       FROM dbo.Goods
           INNER JOIN dbo.OutputInfo
               ON OutputInfo.Goods = Goods.Good
       WHERE Goods.Good = @Goods
             AND OutputInfos = @OutputInfos
   )
   )
    RAISERROR('NumberOutput is not greater number of Goods', 12, 1);
ELSE
    UPDATE dbo.OutputInfo
    SET OutputInfos = @OutputInfos,
        Goods = @Goods,
        NumberOutput = @NumberOutput,
        PricesOutput = @PricesOutput,
        Tax = @Tax;
GO
-- Procedure Delete table
CREATE PROC Sp_Delete_OutputInfo
    @OutputInfos NVARCHAR(50),
    @Goods NVARCHAR(50)
AS
IF (NOT EXISTS
(
    SELECT OutputInfos
    FROM dbo.OutputInfo
    WHERE OutputInfos = @OutputInfos
)
   )
    RAISERROR('Not Exists', 12, 1);
ELSE
    DELETE FROM dbo.OutputInfo
    WHERE OutputInfos = @OutputInfos
          AND Goods = @Goods;
GO

-- CREATE THE VIEW
-- View of the List of input
CREATE VIEW v_ListInput
AS
SELECT TOP 100 PERCENT
       dbo.Inputs.Input AS [Mã phiếu nhập],
       MONTH(dbo.Inputs.DateIn) AS Tháng,
       YEAR(dbo.Inputs.DateIn) AS Năm,
       CONVERT(CHAR(10), dbo.Inputs.DateIn, 103) AS Ngày,
       dbo.Goods.Good AS [Tên hàng],
       NumberInput AS [Số lượng],
       PricesInput AS [Đơn giá nhập],
       Tax AS Thuế,
       (Tax / 100) * NumberInput * PricesInput + PricesInput * NumberInput AS [Thành tiền]
FROM(dbo.Goods
    INNER JOIN dbo.InputInfo
        ON InputInfo.Goods = Goods.Good)
    INNER JOIN dbo.Inputs
        ON dbo.Inputs.Input = InputInfo.InputInfos
ORDER BY YEAR(dbo.Inputs.DateIn),
         MONTH(dbo.Inputs.DateIn);
GO	
-- View of the List of output
CREATE VIEW v_ListOutput
AS 
SELECT TOP 100 PERCENT
	dbo.Outputs.Output AS [Mã phiếu xuất],
	CONVERT(CHAR(10),dbo.Outputs.DateOut,103) AS Ngày,
	MONTH(dbo.Outputs.DateOut) AS Tháng,
	YEAR(dbo.Outputs.DateOut) AS Năm,
	Good AS [Tên hàng],
	NumberOutput AS [Số lượng xuất],
	PricesOutput AS [Giá xuất],
	Tax AS [Thuế],
	((Tax/100)*NumberOutput*PricesOutput + NumberOutput*PricesOutput) AS [Thành tiền]
FROM (dbo.Goods INNER JOIN dbo.OutputInfo ON Goods.Good = OutputInfo.Goods) INNER JOIN dbo.Outputs ON dbo.Outputs.Output = OutputInfos
ORDER BY YEAR(dbo.Outputs.DateOut),MONTH(dbo.Outputs.DateOut)
GO

-- View of the Revenue (Doanh thu)
CREATE VIEW v_Revenue
AS
SELECT 
	TOP 100 PERCENT MONTH(inputs.DateIn) AS [Tháng], YEAR(Inputs.DateIn) AS [Năm],
	SUM(InputInfo.Tax/100*NumberInput*PricesInput + NumberInput*PricesInput) AS [Tổng nhập],
	SUM(dbo.OutputInfo.Tax/100*NumberOutput*PricesOutput + NumberOutput*PricesOutput) AS [Tổng xuất],
	(SUM(dbo.OutputInfo.Tax/100*NumberOutput*PricesOutput + NumberOutput*PricesOutput) -SUM(InputInfo.Tax/100*NumberInput*PricesInput + NumberInput*PricesInput)) AS [Doanh thu],
	tinhtrang = CASE
		WHEN (SUM(NumberOutput*PricesOutput) - SUM(NumberInput*PricesInput) < 0) THEN N'Lỗ'
		WHEN (SUM(NumberOutput*PricesOutput) - SUM(NumberInput*PricesInput) = 0) THEN N'Hòa'
		WHEN (SUM(NumberOutput*PricesOutput) - SUM(NumberInput*PricesInput) > 0) THEN N'Lời'
	END
FROM dbo.Inputs,dbo.InputInfo,dbo.OutputInfo,dbo.Outputs WHERE MONTH(inputs.DateIn) = MONTH(dbo.Outputs.DateOut) AND YEAR(dbo.Inputs.DateIn) = YEAR(outputs.DateOut)
GROUP BY MONTH(inputs.DateIn), YEAR(dbo.Inputs.DateIn)
ORDER BY YEAR(dbo.Inputs.DateIn), MONTH(inputs.DateIn) ASC
GO

-- View of the Input
CREATE	VIEW v_Input
AS 
SELECT staffs.NameSta AS [Tên nhân viên], Supliers.NameSup AS [Nhà cung cấp], Supliers.AddressSup AS [Địa chỉ NCC], Supliers.Phone AS [Điện Thoại],
		Supliers.Email AS [Email], inputs.Input AS [Mã phiếu nhập], CONVERT(CHAR(10),inputs.DateIn,103) AS [Ngày nhập], goods.NameGoo AS [Tên hàng],
		dbo.Goods.Statuss AS [Mô tả],dbo.Goods.Unit AS [Đơn vị tính], InputInfo.Tax AS [Thuế nhập], (dbo.InputInfo.NumberInput*PricesInput*InputInfo.Tax/100) AS [Tiền thuế],
		(NumberInput*PricesInput) + (dbo.InputInfo.NumberInput*PricesInput*InputInfo.Tax/100) AS [Tổng giá trị]
FROM (((dbo.Goods INNER JOIN dbo.InputInfo ON	goods.Good = dbo.InputInfo.Goods) INNER JOIN dbo.Inputs
	ON Inputs.Input = InputInfo.InputInfos) INNER JOIN dbo.Supliers
	ON dbo.Supliers.Suplier = inputs.Supliers) INNER JOIN dbo.Staffs 
	ON Staffs.Staff = Inputs.Staffs

-- View of the Output
CREATE VIEW v_Output
AS 
SELECT staffs.NameSta AS [Tên nhân viên], dbo.Customers.NameCus AS [Tên khách hàng], dbo.Customers.Adress	 AS [Địa chỉ khách hàng], dbo.Customers.Phone AS [Điện Thoại],
		dbo.Customers.Email AS [Email], dbo.Outputs.Output AS [Mã phiếu xuất], CONVERT(CHAR(10),dbo.Outputs.DateOut,103) AS [Ngày xuất], goods.NameGoo AS [Tên hàng],
		dbo.Goods.Statuss AS [Mô tả],dbo.Goods.Unit AS [Đơn vị tính], dbo.OutputInfo.Tax AS [Thuế xuất], (dbo.OutputInfo.NumberOutput*PricesOutput*OutputInfo.Tax/100) AS [Tiền thuế],
		(dbo.OutputInfo.NumberOutput*PricesOutput) + (dbo.OutputInfo.NumberOutput*PricesOutput*OutputInfo.Tax/100) AS [Tổng giá trị]
FROM (((dbo.Goods INNER JOIN dbo.OutputInfo ON	goods.Good = dbo.OutputInfo.Goods) INNER JOIN dbo.Outputs
	ON Outputs.Output = OutputInfo.OutputInfos) INNER JOIN dbo.Customers
	ON dbo.Customers.Customer = dbo.Outputs.Customers) INNER JOIN dbo.Staffs 
	ON Staffs.Staff = dbo.Outputs.Staffs
GO

-- CREATE THE TRIGGER
	--Trigger for InputInfo
	--Trigger to Add the number good
CREATE TRIGGER TG_Insert_InputInfo ON dbo.InputInfo
FOR	INSERT
AS
UPDATE dbo.Goods SET Goods.Numbers = goods.Numbers + Inserted.NumberInput
	FROM dbo.Goods INNER JOIN Inserted ON Inserted.Goods = Goods.Good
GO	
	--Trigger to Update the number good
CREATE TRIGGER TG_Update_InputInfo ON dbo.InputInfo
FOR UPDATE
AS
IF UPDATE(NumberInput)
BEGIN
	DECLARE @good NVARCHAR(50)
	DECLARE @numberinput INT	
	DECLARE contro CURSOR FOR 
		SELECT Inserted.Goods, Inserted.NumberInput - Deleted.NumberInput AS NumberInput
		FROM Inserted INNER JOIN Deleted ON Deleted.Goods = Inserted.Goods AND Deleted.InputInfos = Inserted.InputInfos
	OPEN contro
	FETCH NEXT FROM contro INTO @good,@numberinput
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.Goods SET Numbers = Numbers + @numberinput WHERE goods.Good = @good
		FETCH NEXT FROM contro INTO @good, @numberinput
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
	DECLARE @good NVARCHAR(50)
	DECLARE @numberinput INT	
	DECLARE contro CURSOR FOR 
		SELECT Deleted.Goods, Deleted.NumberInput AS NumberInput
		FROM Deleted
	OPEN contro
	FETCH NEXT FROM contro INTO @good,@numberinput
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.Goods SET Numbers = Numbers - @numberinput WHERE goods.Good = @good
		FETCH NEXT FROM contro INTO @good, @numberinput
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
	FROM dbo.Goods INNER JOIN Inserted ON Inserted.Goods = Goods.Good
GO	
	--Trigger to Update the number good
CREATE TRIGGER TG_Update_OutputInfo ON dbo.OutputInfo
FOR UPDATE
AS
IF UPDATE(NumberOutput)
BEGIN
	DECLARE @good NVARCHAR(50)
	DECLARE @numberoutput INT
	DECLARE @loi nvarchar(100)
	DECLARE contro CURSOR FOR 
		SELECT Inserted.Goods, Inserted.NumberOutput - Deleted.NumberOutput AS Numberoutput
		FROM Inserted INNER JOIN Deleted ON Deleted.Goods = Inserted.Goods AND Deleted.OutputInfos = Inserted.OutputInfos
	IF (@numberoutput > (SELECT Numbers FROM Inserted,dbo.Goods WHERE goods.Good = Inserted.Goods))
	BEGIN 
		SET @loi = N'Số lượng xuất lớn hơn số lượng tồn kho, không thể xuất'
		RAISERROR(@loi,16,1)
		RETURN
	END
	ELSE
	BEGIN	
		OPEN contro
		FETCH NEXT FROM contro INTO @good,@numberoutput
		WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE dbo.Goods SET Numbers = Numbers - @numberoutput WHERE goods.Good = @good
			FETCH NEXT FROM contro INTO @good, @numberoutput
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
	DECLARE @good NVARCHAR(50)
	DECLARE @numberoutput INT	
	DECLARE contro CURSOR FOR 
		SELECT Deleted.Goods, Deleted.NumberOutput AS Numberoutput
		FROM Deleted
	OPEN contro
	FETCH NEXT FROM contro INTO @good,@numberoutput
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.Goods SET Numbers = Numbers + @numberoutput WHERE goods.Good = @good
		FETCH NEXT FROM contro INTO @good, @numberoutput
	END
	CLOSE contro
	DEALLOCATE contro
END
GO

