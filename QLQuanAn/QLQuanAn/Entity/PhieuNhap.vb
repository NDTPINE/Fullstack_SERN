Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("PhieuNhap")>
Partial Public Class PhieuNhap
    Public Sub New()
        ChiTietPhieuNhaps = New HashSet(Of ChiTietPhieuNhap)()
    End Sub

    <Key>
    Public Property Ma As Long

    Public Property MaChiNhanh As Long?

    Public Property MaNhanVien As Long?

    Public Property Ngay As Date?

    Public Property TongTien As Double?

    Public Property Xoa As Boolean?

    Public Property GhiChu As String

    Public Overridable Property ChiNhanh As ChiNhanh

    Public Overridable Property ChiTietPhieuNhaps As ICollection(Of ChiTietPhieuNhap)

    Public Overridable Property Nhanvien As Nhanvien
End Class
