Imports System.Data
Imports System.Data.SqlClient

Module Dulieu
    Dim strConnect As String = "Data Source=DESKTOP-5KGL5VG\SQLEXPRESS;Initial Catalog=QLQuanAn;Integrated Security=True"
    Public Function DocDuLieu(sql As String) As DataTable
        Try
            Dim connection As SqlConnection = New SqlConnection(strConnect)
            Dim conmand As SqlCommand = New SqlCommand(sql, connection)
            Dim dt As DataTable = New DataTable()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(conmand)
            adapter.Fill(dt)
            Return dt
        Catch
            Dim dt As DataTable = New DataTable()
            Return dt
        End Try
    End Function
    Public Function DocCauTruc(sql As String) As DataTable
        Dim connection As SqlConnection = New SqlConnection(strConnect)
        Dim conmand As SqlCommand = New SqlCommand(sql, connection)
        Dim dt As DataTable = New DataTable()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(conmand)
        adapter.FillSchema(dt, SchemaType.Source)
        Return dt
    End Function

    Public Sub GhiDuLieu(TenBang As String, DuLieu As DataTable)
        Dim connection As SqlConnection = New SqlConnection(strConnect)
        Dim sql As String = "Select * from " + TenBang.ToString()
        Dim command As SqlCommand = New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        adapter.Update(DuLieu)
    End Sub
    Public Function ExecuteNonQuery(ByVal query As String, ParamArray para As Object()) As Integer
        Dim kq As Integer = 0
        Dim connection As SqlConnection = New SqlConnection(strConnect)
        connection.Open()
        Dim command As SqlCommand = New SqlCommand(query, connection)

        If Not IsDBNull(para) Then
            Dim listPara As String() = query.Split(" ")
            Dim i As Integer = 0
            Dim item As String
            For Each item In listPara
                If item.Contains("@") Then
                    command.Parameters.AddWithValue(item, para(i))
                    i = i + 1
                End If
            Next
        End If
        kq = command.ExecuteNonQuery()
        connection.Close()
        Return kq
    End Function

    Public Function ExecuteScalar(ByVal query As String, ParamArray para As Object()) As Object
        Dim kq As Object
        Dim connection As SqlConnection = New SqlConnection(strConnect)
        connection.Open()
        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.CommandType = CommandType.StoredProcedure
        If Not IsDBNull(para) Then
            Dim listPara As String() = query.Split(" ")
            Dim i As Integer = 0
            Dim item As String
            For Each item In listPara
                If item.Contains("@") Then
                    command.Parameters.AddWithValue(item, para(i))
                    i = i + 1
                End If
            Next
        End If
        kq = command.ExecuteScalar()
        connection.Close()
        Return kq
    End Function
End Module
