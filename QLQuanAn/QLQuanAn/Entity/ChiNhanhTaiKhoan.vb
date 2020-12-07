Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("ChiNhanhTaiKhoan")>
Partial Public Class ChiNhanhTaiKhoan
    <Key>
    Public Property Ma As Long

    Public Property MaChiNhanh As Long?

    Public Property MaTaiKhoan As Long?

    Public Overridable Property ChiNhanh As ChiNhanh

    Public Overridable Property TaiKhoan As TaiKhoan
End Class
