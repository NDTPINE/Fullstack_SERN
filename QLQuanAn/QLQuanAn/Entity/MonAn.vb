Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("MonAn")>
Partial Public Class MonAn
    Public Sub New()
        ChiTietDonHangs = New HashSet(Of ChiTietDonHang)()
        Menus = New HashSet(Of Menu)()
    End Sub

    <Key>
    Public Property Ma As Long

    Public Property MaDanhMuc As Long

    <Required>
    Public Property Ten As String

    Public Property Gia As Decimal

    Public Property MoTa As String

    Public Property Xoa As Boolean

    Public Property NgayTao As Date

    Public Property NgayCapNhat As Date

    Public Overridable Property ChiTietDonHangs As ICollection(Of ChiTietDonHang)

    Public Overridable Property DanhMuc As DanhMuc

    Public Overridable Property Menus As ICollection(Of Menu)
End Class
