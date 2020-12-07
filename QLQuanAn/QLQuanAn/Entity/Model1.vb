Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property ChiNhanhs As DbSet(Of ChiNhanh)
    Public Overridable Property ChiNhanhTaiKhoans As DbSet(Of ChiNhanhTaiKhoan)
    Public Overridable Property ChiTietDonHangs As DbSet(Of ChiTietDonHang)
    Public Overridable Property ChiTietPhieuNhaps As DbSet(Of ChiTietPhieuNhap)
    Public Overridable Property DanhMucs As DbSet(Of DanhMuc)
    Public Overridable Property DonHangs As DbSet(Of DonHang)
    Public Overridable Property LoaiTaiKhoans As DbSet(Of LoaiTaiKhoan)
    Public Overridable Property Menus As DbSet(Of Menu)
    Public Overridable Property MonAns As DbSet(Of MonAn)
    Public Overridable Property Nhanviens As DbSet(Of Nhanvien)
    Public Overridable Property PhieuNhaps As DbSet(Of PhieuNhap)
    Public Overridable Property TaiKhoans As DbSet(Of TaiKhoan)
    Public Overridable Property TrangThaiDonHangs As DbSet(Of TrangThaiDonHang)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of ChiNhanh)() _
            .Property(Function(e) e.Ten) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ChiNhanh)() _
            .HasMany(Function(e) e.ChiNhanhTaiKhoans) _
            .WithOptional(Function(e) e.ChiNhanh) _
            .HasForeignKey(Function(e) e.MaChiNhanh) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of ChiNhanh)() _
            .HasMany(Function(e) e.DonHangs) _
            .WithRequired(Function(e) e.ChiNhanh) _
            .HasForeignKey(Function(e) e.MaChiNhanh)

        modelBuilder.Entity(Of ChiNhanh)() _
            .HasMany(Function(e) e.Menus) _
            .WithOptional(Function(e) e.ChiNhanh) _
            .HasForeignKey(Function(e) e.MaChiNhanh) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of ChiNhanh)() _
            .HasMany(Function(e) e.Nhanviens) _
            .WithOptional(Function(e) e.ChiNhanh) _
            .HasForeignKey(Function(e) e.MaChiNhanh) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of ChiNhanh)() _
            .HasMany(Function(e) e.PhieuNhaps) _
            .WithOptional(Function(e) e.ChiNhanh) _
            .HasForeignKey(Function(e) e.MaChiNhanh)

        modelBuilder.Entity(Of DanhMuc)() _
            .Property(Function(e) e.Ten) _
            .IsUnicode(False)

        modelBuilder.Entity(Of DanhMuc)() _
            .HasMany(Function(e) e.MonAns) _
            .WithRequired(Function(e) e.DanhMuc) _
            .HasForeignKey(Function(e) e.MaDanhMuc)

        modelBuilder.Entity(Of DonHang)() _
            .HasMany(Function(e) e.ChiTietDonHangs) _
            .WithOptional(Function(e) e.DonHang) _
            .HasForeignKey(Function(e) e.MaDonHang) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of LoaiTaiKhoan)() _
            .HasMany(Function(e) e.TaiKhoans) _
            .WithOptional(Function(e) e.LoaiTaiKhoan) _
            .HasForeignKey(Function(e) e.MaLoaiTaiKhoan) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of Menu)() _
            .Property(Function(e) e.Gia) _
            .HasPrecision(18, 0)

        modelBuilder.Entity(Of MonAn)() _
            .Property(Function(e) e.Ten) _
            .IsUnicode(False)

        modelBuilder.Entity(Of MonAn)() _
            .Property(Function(e) e.Gia) _
            .HasPrecision(18, 0)

        modelBuilder.Entity(Of MonAn)() _
            .HasMany(Function(e) e.ChiTietDonHangs) _
            .WithOptional(Function(e) e.MonAn) _
            .HasForeignKey(Function(e) e.MaMonAn) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of MonAn)() _
            .HasMany(Function(e) e.Menus) _
            .WithOptional(Function(e) e.MonAn) _
            .HasForeignKey(Function(e) e.MaMon) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of Nhanvien)() _
            .HasMany(Function(e) e.PhieuNhaps) _
            .WithOptional(Function(e) e.Nhanvien) _
            .HasForeignKey(Function(e) e.MaNhanVien) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of PhieuNhap)() _
            .HasMany(Function(e) e.ChiTietPhieuNhaps) _
            .WithOptional(Function(e) e.PhieuNhap) _
            .HasForeignKey(Function(e) e.MaPhieuNhap) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of TaiKhoan)() _
            .Property(Function(e) e.TenDangNhap) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TaiKhoan)() _
            .Property(Function(e) e.Matkhau) _
            .IsUnicode(False)

        modelBuilder.Entity(Of TaiKhoan)() _
            .HasMany(Function(e) e.ChiNhanhTaiKhoans) _
            .WithOptional(Function(e) e.TaiKhoan) _
            .HasForeignKey(Function(e) e.MaTaiKhoan) _
            .WillCascadeOnDelete()

        modelBuilder.Entity(Of TrangThaiDonHang)() _
            .HasMany(Function(e) e.DonHangs) _
            .WithRequired(Function(e) e.TrangThaiDonHang) _
            .HasForeignKey(Function(e) e.TrangThai)
    End Sub
End Class
