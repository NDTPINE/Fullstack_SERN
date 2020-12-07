Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Nhanvien")>
Partial Public Class Nhanvien
    Public Sub New()
        PhieuNhaps = New HashSet(Of PhieuNhap)()
    End Sub

    <Key>
    Public Property Ma As Long

    <Required>
    Public Property HoTen As String

    Public Property MaChiNhanh As Long?

    Public Property NgaySinh As Date?

    Public Property DiaChi As String

    Public Property DienThoai As Integer

    Public Property MoTo As String

    Public Overridable Property ChiNhanh As ChiNhanh

    Public Overridable Property PhieuNhaps As ICollection(Of PhieuNhap)
End Class
