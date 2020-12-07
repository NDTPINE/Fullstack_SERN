Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("TrangThaiDonHang")>
Partial Public Class TrangThaiDonHang
    Public Sub New()
        DonHangs = New HashSet(Of DonHang)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Ma As Integer

    Public Property Ten As String

    Public Overridable Property DonHangs As ICollection(Of DonHang)
End Class
