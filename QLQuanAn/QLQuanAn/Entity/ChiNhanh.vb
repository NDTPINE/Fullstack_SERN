Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("ChiNhanh")>
Partial Public Class ChiNhanh
    Public Sub New()
        ChiNhanhTaiKhoans = New HashSet(Of ChiNhanhTaiKhoan)()
        DonHangs = New HashSet(Of DonHang)()
        Menus = New HashSet(Of Menu)()
        Nhanviens = New HashSet(Of Nhanvien)()
        PhieuNhaps = New HashSet(Of PhieuNhap)()
    End Sub

    <Key>
    Public Property Ma As Long

    <Required>
    Public Property Ten As String

    <Required>
    Public Property Diachi As String

    Public Property Xoa As Boolean

    Public Property NgayTao As Date

    Public Property NgayCapNhat As Date

    Public Overridable Property ChiNhanhTaiKhoans As ICollection(Of ChiNhanhTaiKhoan)

    Public Overridable Property DonHangs As ICollection(Of DonHang)

    Public Overridable Property Menus As ICollection(Of Menu)

    Public Overridable Property Nhanviens As ICollection(Of Nhanvien)

    Public Overridable Property PhieuNhaps As ICollection(Of PhieuNhap)
End Class
