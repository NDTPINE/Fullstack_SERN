Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("DonHang")>
Partial Public Class DonHang
    Public Sub New()
        ChiTietDonHangs = New HashSet(Of ChiTietDonHang)()
    End Sub

    <Key>
    Public Property Ma As Long

    Public Property Ngay As Date

    Public Property Ten As String

    Public Property DienThoai As Integer

    Public Property MaChiNhanh As Long

    Public Property TongMonAn As Integer?

    Public Property GiamGia As Integer?

    Public Property TongTien As Double?

    Public Property TrangThai As Integer

    Public Property Phuphi As Integer?

    Public Overridable Property ChiNhanh As ChiNhanh

    Public Overridable Property ChiTietDonHangs As ICollection(Of ChiTietDonHang)

    Public Overridable Property TrangThaiDonHang As TrangThaiDonHang
End Class
