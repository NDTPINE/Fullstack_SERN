Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("TaiKhoan")>
Partial Public Class TaiKhoan
    Public Sub New()
        ChiNhanhTaiKhoans = New HashSet(Of ChiNhanhTaiKhoan)()
    End Sub

    <Key>
    Public Property Ma As Long

    Public Property TenDangNhap As String

    Public Property Matkhau As String

    <StringLength(200)>
    Public Property HoTen As String

    Public Property NgaySinh As Date?

    Public Property MaLoaiTaiKhoan As Long?

    <StringLength(200)>
    Public Property HoatDong As String

    Public Property NgayTao As Date?

    Public Property NgayCapNhat As Date?

    Public Overridable Property ChiNhanhTaiKhoans As ICollection(Of ChiNhanhTaiKhoan)

    Public Overridable Property LoaiTaiKhoan As LoaiTaiKhoan
End Class
