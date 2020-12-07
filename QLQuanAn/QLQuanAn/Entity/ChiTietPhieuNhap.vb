Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("ChiTietPhieuNhap")>
Partial Public Class ChiTietPhieuNhap
    <Key>
    Public Property Ma As Long

    Public Property MaPhieuNhap As Long?

    Public Property MaNguyenLieu As Long?

    Public Property TongNguyenLieu As Integer?

    Public Property Soluong As Integer?

    Public Property Gia As Double?

    Public Property GiamGia As Integer?

    Public Property TongTien As Double?

    Public Overridable Property PhieuNhap As PhieuNhap
End Class
