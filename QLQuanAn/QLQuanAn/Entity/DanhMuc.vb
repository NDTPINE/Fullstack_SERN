Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("DanhMuc")>
Partial Public Class DanhMuc
    Public Sub New()
        MonAns = New HashSet(Of MonAn)()
    End Sub

    <Key>
    Public Property Ma As Long

    <Required>
    Public Property Ten As String

    Public Property Xoa As Boolean

    Public Property NgayTao As Date

    Public Property NgayCapNhat As Date

    Public Overridable Property MonAns As ICollection(Of MonAn)
End Class
