Imports System.Data.SqlClient
Module DuLieu
    Dim strConnect As String = "Data Source=DESKTOP-5KGL5VG\SQLEXPRESS;Initial Catalog=QLQuanAn;Integrated Security=True"
    Public Function DocDuLieu(sql As String) As DataTable
        Dim connection As SqlConnection = New SqlConnection(strConnect)
        Dim command As SqlCommand = New SqlCommand(sql, connection)
        Dim dt As DataTable = New DataTable()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        adapter.Fill(dt)
        Return dt
    End Function

    Public Sub GhiDuLieu(table As String, dulieu As DataTable)
        Dim connection As SqlConnection = New SqlConnection(strConnect)
        Dim command As SqlCommand = New SqlCommand("select * from " + table, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        adapter.Update(dulieu)
    End Sub
End Module
