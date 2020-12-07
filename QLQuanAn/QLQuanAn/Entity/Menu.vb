Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Menu")>
Partial Public Class Menu
    <Key>
    Public Property Ma As Long

    Public Property MaMon As Long?

    Public Property Gia As Decimal?

    Public Property MaChiNhanh As Long?

    Public Overridable Property ChiNhanh As ChiNhanh

    Public Overridable Property MonAn As MonAn
End Class
