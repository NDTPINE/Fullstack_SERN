Public Class frmChiNhanh
    Dim dschinhanh As DataTable

    Private Sub frmChiNhanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dschinhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where Xoa = 0")
        dtgvChiNhanh.DataSource = dschinhanh
        dtgvChiNhanh.Columns("Xoa").Visible = False
    End Sub

    Private Sub dtgvChiNhanh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvChiNhanh.CellClick
        If dtgvChiNhanh.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvChiNhanh.SelectedCells(0).RowIndex
            Dim ChiNhanhView As DataRowView = dtgvChiNhanh.Rows(i).DataBoundItem
            Dim ChiNhanh As DataRow = ChiNhanhView.Row
            txbIdChiNhanh.Text = ChiNhanh("Ma")
            txbTenChiNhanh.Text = ChiNhanh("Ten")
            txbDiaChiChiNhanh.Text = ChiNhanh("DiaChi")
            txbNgayTaoChiNhanh.Text = ChiNhanh("NgayTao")
            txbNgayCapNhatChiNhanh.Text = ChiNhanh("NgayCapNhat")
        End If
    End Sub


    Private Sub btnThemChiNhanh_Click_1(sender As Object, e As EventArgs) Handles btnThemChiNhanh.Click
        If txbTenChiNhanh.Text = "" Then
            MessageBox.Show("Tên không được rỗng !", "Thông Báo", MessageBoxButtons.OK)
            txbTenChiNhanh.Select()
            Return
        End If
        If txbDiaChiChiNhanh.Text = "" Then
            MessageBox.Show("Địa chỉ không được rỗng !", "Thông Báo", MessageBoxButtons.OK)
            txbDiaChiChiNhanh.Select()
            Return
        End If

        Dim sql As String = "EXEC Sp_Insert_ChiNhanh @Ten , @Diachi , @Xoa"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {txbTenChiNhanh.Text, txbDiaChiChiNhanh.Text, 0})
        If count > 0 Then
            lbresult.Text = $"Thêm thành công "
        End If
        frmChiNhanh_Load(sender, e)
    End Sub

    Private Sub btnSuaChiNhanh_Click_1(sender As Object, e As EventArgs) Handles btnSuaChiNhanh.Click
        Dim index As Integer = -1
        If dtgvChiNhanh.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvChiNhanh.SelectedCells(0).RowIndex
            Dim ChiNhanhView As DataRowView = dtgvChiNhanh.Rows(i).DataBoundItem
            Dim ChiNhanh As DataRow = ChiNhanhView.Row
            Int32.TryParse(ChiNhanh("Ma"), index)
        End If
        Dim sql As String = "EXEC Sp_Update_ChiNhanh @Ma , @Ten , @Diachi , @Xoa"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index, txbTenChiNhanh.Text, txbDiaChiChiNhanh.Text, 0})
        If count > 0 Then
            lbresult.Text = $"Sửa thành công "
        End If
        frmChiNhanh_Load(sender, e)
    End Sub

    Private Sub btnXoaChiNhanh_Click_1(sender As Object, e As EventArgs) Handles btnXoaChiNhanh.Click
        Dim index As Integer = -1
        If dtgvChiNhanh.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvChiNhanh.SelectedCells(0).RowIndex
            Dim ChiNhanhView As DataRowView = dtgvChiNhanh.Rows(i).DataBoundItem
            Dim ChiNhanh As DataRow = ChiNhanhView.Row
            Int32.TryParse(ChiNhanh("Ma"), index)
        End If
        Dim sql As String = "EXEC Sp_Delete_ChiNhanh @Ma"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index})
        If count > 0 Then
            lbresult.Text = $"Xóa thành công "
        End If
        frmChiNhanh_Load(sender, e)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim check As Integer = 0
        If chbXoa.Checked = True Then
            check = 1
        End If
        dschinhanh = Dulieu.DocDuLieu(String.Format("Select * from ChiNhanh where Ten Like N'%" + txbSearch.Text + "%' and Xoa =  {0}", check))
        dtgvChiNhanh.DataSource = dschinhanh
        dtgvChiNhanh.Columns("Xoa").Visible = False
    End Sub
End Class