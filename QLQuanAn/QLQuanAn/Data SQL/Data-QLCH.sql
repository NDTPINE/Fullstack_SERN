CREATE DATABASE QLQuanAn
GO

USE QLQuanAn
GO

--Create table
CREATE TABLE LoaiTaiKhoan
(
	Ma BIGINT IDENTITY PRIMARY KEY,
	MoTa NVARCHAR(MAX),
	NgayTao DATETIME DEFAULT GETDATE(),
	NgayCapNhat DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE TaiKhoan
(
	Ma	BIGINT IDENTITY PRIMARY KEY,
	TenDangNhap VARCHAR(MAX),
	Matkhau VARCHAR(MAX),
	HoTen NVARCHAR(200),
	NgaySinh DATETIME CHECK (Year(getdate()) -  Year(Ngaysinh) >= 18),
	MaLoaiTaiKhoan BIGINT FOREIGN KEY REFERENCES dbo.LoaiTaiKhoan(Ma) ON UPDATE CASCADE ON DELETE CASCADE,
	HoatDong NVARCHAR(200),
	NgayTao DATETIME DEFAULT GETDATE(),
	NgayCapNhat DATETIME DEFAULT GETDATE()
)
GO	

CREATE TABLE DanhMuc
(
	Ma	BIGINT IDENTITY PRIMARY KEY NOT NULL,
	Ten VARCHAR(MAX) NOT NULL,
	Xoa BIT DEFAULT 0 NOT NULL,
	NgayTao DATETIME DEFAULT GETDATE() NOT NULL,
	NgayCapNhat DATETIME DEFAULT GETDATE() NOT NULL
)
GO	

CREATE TABLE MonAn
(
	Ma	BIGINT IDENTITY PRIMARY KEY NOT NULL,
	MaDanhMuc BIGINT NOT NULL FOREIGN KEY REFERENCES dbo.DanhMuc(Ma) ON UPDATE CASCADE ON DELETE CASCADE, 
	Ten VARCHAR(MAX) NOT NULL,
	Gia DECIMAL(18,0) NOT NULL,
	MoTa NVARCHAR(MAX),
	Xoa BIT DEFAULT 0 NOT NULL,
	NgayTao DATETIME DEFAULT GETDATE() NOT NULL,
	NgayCapNhat DATETIME DEFAULT GETDATE() NOT NULL
)
GO	

CREATE TABLE ChiNhanh 
(
	Ma	BIGINT IDENTITY PRIMARY KEY NOT NULL,
	Ten VARCHAR(MAX) NOT NULL,
	Diachi NVARCHAR(MAX) NOT NULL,
	Xoa BIT DEFAULT 0 NOT NULL,
	NgayTao DATETIME DEFAULT GETDATE() NOT NULL,
	NgayCapNhat DATETIME DEFAULT GETDATE() NOT NULL
)
GO	

CREATE TABLE Menu
(
	Ma	BIGINT IDENTITY PRIMARY KEY,
	MaMon BIGINT FOREIGN KEY REFERENCES dbo.MonAn(Ma) ON UPDATE CASCADE ON DELETE CASCADE,
	Gia DECIMAL(18,0),
	MaChiNhanh BIGINT FOREIGN KEY REFERENCES dbo.ChiNhanh(Ma) ON UPDATE CASCADE ON DELETE CASCADE	
)
GO	

CREATE TABLE NguyenLieu
(
	Ma	BIGINT IDENTITY PRIMARY KEY,
	Ten VARCHAR(MAX),
	MoTa NVARCHAR(MAX)
)
GO

CREATE TABLE NguyenLieuMonAn
(
		Ma	BIGINT IDENTITY PRIMARY KEY,
		MaNguyenLieu BIGINT FOREIGN KEY REFERENCES dbo.NguyenLieu(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
		MaMonAn BIGINT FOREIGN KEY REFERENCES dbo.MonAn(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
		Soluong INT,
		DonVi NVARCHAR(200)
)
GO	

CREATE TABLE ChiNhanhTaiKhoan
(
	Ma BIGINT IDENTITY PRIMARY KEY,
	MaChiNhanh BIGINT FOREIGN KEY REFERENCES dbo.ChiNhanh(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	MaTaiKhoan BIGINT FOREIGN KEY REFERENCES dbo.TaiKhoan(Ma) ON DELETE CASCADE ON UPDATE CASCADE
)
GO	

CREATE TABLE CaLamViec
(
	Ma BIGINT IDENTITY PRIMARY KEY,
	MaChiNhanh BIGINT FOREIGN KEY REFERENCES dbo.ChiNhanh(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	MaTaiKhoan BIGINT FOREIGN KEY REFERENCES dbo.TaiKhoan(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	Ngay datetime,
	Ca INT,
	ThoiGianBatDau DATETIME,
	ThoigianKetThuc DATETIME
)
GO	

CREATE TABLE Nhanvien
(
	Ma BIGINT IDENTITY PRIMARY KEY NOT NULL,
	HoTen NVARCHAR(MAX) NOT NULL,
	MaChiNhanh BIGINT FOREIGN KEY REFERENCES dbo.ChiNhanh(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	NgaySinh DATETIME,
	DiaChi NVARCHAR(MAX),
	DienThoai INT NOT NULL,
	MoTo NVARCHAR(MAX)
)
GO	

CREATE TABLE DonHang
(
	Ma BIGINT IDENTITY PRIMARY KEY NOT NULL,
	Ngay DATETIME NOT NULL DEFAULT GETDATE(),
	Ten NVARCHAR(MAX),
	DienThoai INT NOT NULL,
	MaChiNhanh BIGINT NOT NULL FOREIGN KEY REFERENCES dbo.ChiNhanh(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	TongMonAn INT,
	GiamGia INT,
	TongTien Float,
	TrangThai INT NOT NULL FOREIGN KEY REFERENCES dbo.TrangThaiDonHang(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	Phuphi INT
)
GO

CREATE TABLE ChiTietDonHang
(
	Ma BIGINT IDENTITY PRIMARY KEY NOT NULL,
	MaDonHang BIGINT FOREIGN KEY REFERENCES dbo.DonHang(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	MaMonAn BIGINT FOREIGN KEY REFERENCES dbo.MonAn(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	TongMonAn INT,
	Soluong INT,
	Gia INT,
	Giamgia INT,
	TongTien FLOAT
)
GO

CREATE TABLE  TrangThaiDonHang
(
	Ma INT PRIMARY KEY NOT NULL,
	Ten NVARCHAR(MAX)
)
GO	


CREATE TABLE PhieuNhap
(
	Ma BIGINT IDENTITY PRIMARY KEY NOT NULL,
	MaChiNhanh BIGINT FOREIGN KEY REFERENCES dbo.ChiNhanh(Ma),
	MaNhanVien BIGINT FOREIGN KEY REFERENCES dbo.NhanVien(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	Ngay DATETIME,
	TongTien FLOAT,
	Xoa BIT,
	GhiChu NVARCHAR(MAX)
)
GO	

CREATE TABLE ChiTietPhieuNhap
(
	Ma BIGINT IDENTITY PRIMARY KEY NOT NULL,
	MaPhieuNhap BIGINT FOREIGN KEY REFERENCES dbo.PhieuNhap(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	MaNguyenLieu BIGINT FOREIGN KEY REFERENCES dbo.NguyenLieu(Ma) ON DELETE CASCADE ON UPDATE CASCADE,
	TongNguyenLieu INT,
	Soluong INT,
	Gia FLOAT,
	GiamGia INT,
	TongTien FLOAT
)	
GO	
CREATE TABLE KhuyenMaiTheoChiNhanh
(
	Ma BIGINT IDENTITY PRIMARY KEY NOT NULL,
	Code Nvarchar(max) not null,
	NgayBatDau Date DEFAULT GETDATE() NOT NULL,
	NgayKetThuc Date DEFAULT GETDATE() NOT NULL,
	GioBatDau Int Default 0 Check (GioBatDau < 24 And GioBatDau >= 0) NOT NULL,
	GioKetThuc Int Default 0 Check (GioKetThuc < 24 And GioKetThuc >= 0) NOT NULL,
	PhanTram Int,
	SoTienToiDa Float,
	SoTienToiThieuApDung Float,
	MaChiNhanh BIGINT FOREIGN KEY REFERENCES dbo.ChiNhanh(Ma)
)
GO
--Insert default imformation
INSERT dbo.TrangThaiDonHang
(
    Ma,
    Ten
)
VALUES
(   1,  -- Ma - int
    N'Moi' -- Ten - nvarchar(max)
    )
GO
INSERT dbo.TrangThaiDonHang
(
    Ma,
    Ten
)
VALUES
(   2,  -- Ma - int
    N'Hoan Tat' -- Ten - nvarchar(max)
    )  
GO 
INSERT dbo.TrangThaiDonHang
(
    Ma,
    Ten
)
VALUES
(   3,  -- Ma - int
    N'Huy' -- Ten - nvarchar(max)
    )  
GO 
Insert dbo.LoaiTaiKhoan
(MoTa)
Values
(N'Admin')
Go
Insert dbo.LoaiTaiKhoan
(Mota)
Values
(N'Staff')
Go
Insert dbo.TaiKhoan
(TenDangNhap,Matkhau,HoTen,NgaySinh,MaLoaiTaiKhoan,HoatDong)
Values
(N'admin',N'admin',N'admin',01/01/2020,2,N'admin')
Go
--Create Produce
-- Create Produce KhuyenMai
CREATE PROC Sp_Insert_KhuyenMai
	@Code Nvarchar(max),
	@NgayBatDau Date,
	@NgayKetThuc Date,
	@GioBatDau Int,
	@GioKetThuc Int,
	@PhanTram Int,
	@SoTienToiDa Float,
	@SoTienToiThieuApDung Float,
	@MaChiNhanh BIGINT
As
BEGIN
	INSERT INTO dbo.KhuyenMaiTheoChiNhanh
	(Code,NgayBatDau,NgayKetThuc,GioBatDau,GioKetThuc,PhanTram,SoTienToiDa,SoTienToiThieuApDung,MaChiNhanh)
	VALUES 
	(@Code,@NgayBatDau,@NgayKetThuc,@GioBatDau,@GioKetThuc,@PhanTram,@SoTienToiDa,@SoTienToiThieuApDung,@MaChiNhanh)
END
GO
CREATE PROC Sp_Update_KhuyenMai
	@Ma BIGINT,
	@Code Nvarchar(max),
	@NgayBatDau Date,
	@NgayKetThuc Date,
	@GioBatDau Int,
	@GioKetThuc Int,
	@PhanTram Int,
	@SoTienToiDa Float,
	@SoTienToiThieuApDung Float,
	@MaChiNhanh BIGINT
As
IF (EXISTS (SELECT Ma FROM dbo.KhuyenMaiTheoChiNhanh WHERE Ma = @Ma))
BEGIN
	UPDATE dbo.KhuyenMaiTheoChiNhanh set Code=@Code,NgayBatDau=@NgayBatDau,NgayKetThuc=@NgayKetThuc,GioBatDau=@GioBatDau,GioKetThuc=@GioKetThuc,PhanTram=@PhanTram,SoTienToiDa=@SoTienToiDa,SoTienToiThieuApDung=@SoTienToiThieuApDung,MaChiNhanh=@MaChiNhanh Where Ma = @Ma
END
GO
CREATE PROC Sp_Delete_KhuyenMai
	@Ma	BIGINT
AS
	IF (EXISTS (SELECT Ma FROM dbo.KhuyenMaiTheoChiNhanh WHERE Ma = @Ma))
	BEGIN	
		DELETE FROM dbo.KhuyenMaiTheoChiNhanh WHERE Ma = @Ma
	END
GO	
-- Create Produce Taikhoan
CREATE PROC Sp_Insert_Taikhoan
	
	@TenDangNhap VARCHAR(MAX),
	@Matkhau VARCHAR(MAX),
	@HoTen NVARCHAR(200),
	@NgaySinh DATE,
	@MaLoaiTaiKhoan BIGINT,
	@HoatDong NVARCHAR(200)
AS
BEGIN	
	INSERT INTO	dbo.TaiKhoan
	(TenDangNhap, Matkhau, HoTen, NgaySinh, MaLoaiTaiKhoan, HoatDong)
	VALUES
	(@TenDangNhap,@Matkhau,@HoTen,@NgaySinh,@MaLoaiTaiKhoan, @HoatDong)
END
GO

CREATE PROC Sp_Update_Taikhoan
	@Ma	BIGINT,
	@TenDangNhap VARCHAR(MAX),
	@Matkhau VARCHAR(MAX),
	@HoTen NVARCHAR(200),
	@NgaySinh DATE,
	@MaLoaiTaiKhoan BIGINT,
	@HoatDong NVARCHAR(200)
AS
IF (EXISTS (SELECT Ma FROM dbo.TaiKhoan WHERE Ma = @Ma))
BEGIN	
	UPDATE dbo.TaiKhoan SET TenDangNhap = @TenDangNhap, Matkhau = @Matkhau, HoTen = @HoTen,Ngaysinh = @NgaySinh, MaLoaiTaiKhoan = @MaLoaiTaiKhoan,NgayCapNhat = getdate() WHERE Ma = @Ma
END
GO	

CREATE PROC Sp_Delete_Taikhoan
	@Ma	BIGINT
AS
	IF (EXISTS (SELECT Ma FROM dbo.TaiKhoan WHERE Ma = @Ma))
	BEGIN	
		DELETE FROM dbo.TaiKhoan WHERE Ma = @Ma
	END
GO	

--Create produce ChiNhanh

CREATE PROC Sp_Insert_ChiNhanh
	
	@Ten VARCHAR(MAX),
	@Diachi VARCHAR(MAX),
	@Xoa Bit
AS
BEGIN	
	INSERT INTO	dbo.ChiNhanh
	(Ten,Diachi,Xoa)
	VALUES
	(@Ten,@Diachi,@Xoa)
END
GO

CREATE PROC Sp_Update_ChiNhanh
	@Ma	BIGINT,
	@Ten VARCHAR(MAX),
	@Diachi VARCHAR(MAX),
	@Xoa Bit
AS 
IF (EXISTS (SELECT Ma FROM dbo.ChiNhanh WHERE Ma = @Ma))
BEGIN	
	UPDATE dbo.ChiNhanh SET Ten = @Ten, DiaChi = @DiaChi,Xoa = @Xoa, NgayCapNhat = getdate() WHERE Ma = @Ma
END
GO	

CREATE PROC Sp_Delete_ChiNhanh
	@Ma	BIGINT
AS
	IF (EXISTS (SELECT Ma FROM dbo.ChiNhanh WHERE Ma = @Ma))
	BEGIN	
		DELETE FROM dbo.ChiNhanh WHERE Ma = @Ma
	END
GO	
-- Creat produce DanhMuc
CREATE PROC Sp_Insert_DanhMuc
	@Ten VARCHAR(MAX),
	@Xoa Bit
AS
BEGIN	
	INSERT INTO	dbo.DanhMuc
	(Ten,Xoa)
	VALUES
	(@Ten,@Xoa)
END
GO

CREATE PROC Sp_Update_DanhMuc
	@Ma	BIGINT,
	@Ten VARCHAR(MAX),
	@Xoa Bit
AS
IF (EXISTS (SELECT Ma FROM dbo.DanhMuc WHERE Ma = @Ma))
BEGIN	
	UPDATE dbo.DanhMuc SET Ten = @Ten, Xoa = @Xoa,NgayCapNhat = getdate() WHERE Ma = @Ma
END
GO	

CREATE PROC Sp_Delete_DanhMuc
	@Ma	BIGINT
AS
	IF (EXISTS (SELECT Ma FROM dbo.DanhMuc WHERE Ma = @Ma))
	BEGIN	
		DELETE FROM dbo.DanhMuc WHERE Ma = @Ma
	END
GO
-- Create produre MonAn
CREATE PROC Sp_Insert_MonAn
	@MaDanhMuc BIGINT,
	@Ten VARCHAR(MAX),
	@Gia DECIMAL(18,0),
	@MoTa NVARCHAR(MAX),
	@Xoa Bit
AS

BEGIN	
	INSERT INTO	dbo.MonAn
	(MaDanhMuc,Ten,Gia,MoTa,Xoa)
	VALUES
	(@MaDanhMuc,@Ten,@Gia,@MoTa,@Xoa)
END
GO

CREATE PROC Sp_Update_MonAn
	@Ma	BIGINT,
	@MaDanhMuc BIGINT,
	@Ten VARCHAR(MAX),
	@Gia DECIMAL(18,0),
	@MoTa NVARCHAR(MAX),
	@Xoa Bit
AS
IF (EXISTS (SELECT Ma FROM dbo.MonAn WHERE Ma = @Ma))
BEGIN	
	UPDATE dbo.MonAn SET MaDanhMuc = @MaDanhMuc,Gia = @Gia,MoTa = @MoTa,Ten = @Ten, Xoa = @Xoa,NgayCapNhat = getdate() WHERE Ma = @Ma
END
GO	

CREATE PROC Sp_Delete_MonAn
	@Ma	BIGINT
AS
	IF (EXISTS (SELECT Ma FROM dbo.MonAn WHERE Ma = @Ma))
	BEGIN	
		Update dbo.MonAn set Xoa = 1 where Ma = @Ma
	END
GO
--Create produce ChiTietDonHang
CREATE PROC Sp_Insert_ChiTietDonHang
	@MaDonHang BIGINT,
	@MaMonAn BIGINT,
	@TongMonAn INT,
	@Soluong INT,
	@Gia INT,
	@Giamgia INT,
	@TongTien FLOAT
AS
BEGIN	
	INSERT INTO	dbo.ChiTietDonHang
	(MaDonHang,	MaMonAn,TongMonAn,Soluong,Gia,Giamgia,TongTien)
	VALUES
	(@MaDonHang,@MaMonAn,@TongMonAn,@Soluong,@Gia,@Giamgia,@TongTien)
END
GO

CREATE PROC Sp_Update_ChiTietDonHang
	@Ma	BIGINT,
	@MaDonHang BIGINT,
	@MaMonAn BIGINT,
	@TongMonAn INT,
	@Soluong INT,
	@Gia INT,
	@Giamgia INT,
	@TongTien FLOAT
AS
IF (EXISTS (SELECT Ma FROM dbo.ChiTietDonHang WHERE Ma = @Ma))
BEGIN	
	UPDATE dbo.ChiTietDonHang SET MaDonHang =@MaDonHang,MaMonAn=@MaMonAn,TongMonAn=@TongMonAn,Soluong=@Soluong,Gia=@Gia,Giamgia=@Giamgia,TongTien=@TongTien WHERE Ma = @Ma
END
GO	

CREATE PROC Sp_Delete_ChiTietDonHang
	@Ma	BIGINT
AS
	IF (EXISTS (SELECT Ma FROM dbo.ChiTietDonHang WHERE Ma = @Ma))
	BEGIN	
		DELETE FROM dbo.ChiTietDonHang WHERE Ma = @Ma
	END
GO
-- Create produre DonHang
CREATE PROC Sp_Insert_DonHang
	@Ten NVARCHAR(MAX),
	@DienThoai Int,
	@MaChiNhanh BIGINT,
	@TongMonAn INT,
	@Giamgia INT,
	@TongTien FLOAT,
	@TrangThai INT,
	@Phuphi INT
AS
BEGIN	
	INSERT INTO	dbo.DonHang
	(Ten,DienThoai,MaChiNhanh,TongMonAn,GiamGia,TongTien,TrangThai,Phuphi)
	VALUES
	(@Ten,@DienThoai,@MaChiNhanh,@TongMonAn,@GiamGia,@TongTien,@TrangThai,@Phuphi)
END
GO

CREATE PROC Sp_Update_DonHang
	@Ma	BIGINT,
	@Ten NVARCHAR(MAX),
	@DienThoai Int,
	@MaChiNhanh BIGINT,
	@TongMonAn INT,
	@Giamgia INT,
	@TongTien FLOAT,
	@TrangThai INT,
	@Phuphi INT
AS
IF (EXISTS (SELECT Ma FROM dbo.DonHang WHERE Ma = @Ma))
BEGIN	
	UPDATE dbo.DonHang SET Ten = @Ten,DienThoai = @DienThoai,MaChiNhanh=@MaChiNhanh,TongMonAn=@TongMonAn,TrangThai=@TrangThai,Phuphi=@Phuphi,Giamgia=@Giamgia,TongTien=@TongTien WHERE Ma = @Ma
END
GO	

CREATE PROC Sp_Delete_DonHang
	@Ma	BIGINT
AS
	IF (EXISTS (SELECT Ma FROM dbo.DonHang WHERE Ma = @Ma))
	BEGIN	
		DELETE FROM dbo.DonHang WHERE Ma = @Ma
	END
GO
