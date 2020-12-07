Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("ChiTietDonHang")>
Partial Public Class ChiTietDonHang
    <Key>
    Public Property Ma As Long

    Public Property MaDonHang As Long?

    Public Property MaMonAn As Long?

    Public Property TongMonAn As Integer?

    Public Property Soluong As Integer?

    Public Property Gia As Integer?

    Public Property Giamgia As Integer?

    Public Property TongTien As Double?

    Public Overridable Property DonHang As DonHang

    Public Overridable Property MonAn As MonAn
End Class
