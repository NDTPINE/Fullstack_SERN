Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("LoaiTaiKhoan")>
Partial Public Class LoaiTaiKhoan
    Public Sub New()
        TaiKhoans = New HashSet(Of TaiKhoan)()
    End Sub

    <Key>
    Public Property Ma As Long

    Public Property MoTa As String

    Public Property NgayTao As Date?

    Public Property NgayCapNhat As Date?

    Public Overridable Property TaiKhoans As ICollection(Of TaiKhoan)
End Class
