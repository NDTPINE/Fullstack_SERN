Public Class frmDanhMuc
    Dim dsdanhmuc As DataTable

    Private Sub frmDanhMuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsdanhmuc = DuLieu.DocDuLieu("Select * from DanhMuc where Xoa = 0")

        dtgvDanhMuc.DataSource = dsdanhmuc
        dtgvDanhMuc.Columns("Xoa").Visible = False

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txbTenDanhMuc.Text = "" Then
            MessageBox.Show("Tên không được rỗng !", "Thông Báo", MessageBoxButtons.OK)
            txbTenDanhMuc.Select()
            Return
        End If
        Dim sql As String = "EXEC Sp_InSert_DanhMuc @Ten , @Xoa"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {txbTenDanhMuc.Text, 0})
        If count > 0 Then
            lbresult.Text = $"Thêm thành công "
        End If
        frmDanhMuc_Load(sender, e)
    End Sub

    Private Sub dtgvDanhMuc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvDanhMuc.CellClick
        If dtgvDanhMuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvDanhMuc.SelectedCells(0).RowIndex
            Dim DanhMucView As DataRowView = dtgvDanhMuc.Rows(i).DataBoundItem
            Dim DanhMuc As DataRow = DanhMucView.Row

            txbIdDanhMuc.Text = DanhMuc("Ma")
            txbTenDanhMuc.Text = DanhMuc("Ten")
            txbNgayTaoDanhMuc.Text = DanhMuc("NgayTao")
            txbNgayCapNhatDanhMuc.Text = DanhMuc("NgayCapNhat")
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim index As Integer = -1
        If dtgvDanhMuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvDanhMuc.SelectedCells(0).RowIndex
            Dim DanhMucView As DataRowView = dtgvDanhMuc.Rows(i).DataBoundItem
            Dim DanhMuc As DataRow = DanhMucView.Row
            Int32.TryParse(DanhMuc("Ma"), index)
        End If
        Dim sql As String = "EXEC Sp_Update_DanhMuc @Ma , @Ten , @Xoa"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index, txbTenDanhMuc.Text, 0})
        If count > 0 Then
            lbresult.Text = $"Sửa thành công "
        End If
        frmDanhMuc_Load(sender, e)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim index As Integer = -1
        If dtgvDanhMuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvDanhMuc.SelectedCells(0).RowIndex
            Dim DanhMucView As DataRowView = dtgvDanhMuc.Rows(i).DataBoundItem
            Dim DanhMuc As DataRow = DanhMucView.Row

            Int32.TryParse(DanhMuc("Ma"), index)
        End If
        Dim sql As String = "EXEC Sp_Delete_DanhMuc @Ma"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index})
        If count > 0 Then
            lbresult.Text = $"Xóa thành công "
        End If
        frmDanhMuc_Load(sender, e)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim check As Integer = 0
        If chbXoa.Checked = True Then
            check = 1
        End If
        dsdanhmuc = Dulieu.DocDuLieu(String.Format("Select * from DanhMuc where Ten Like N'%" + txbSearch.Text + "%' and Xoa =  {0}", check))
        dtgvDanhMuc.DataSource = dsdanhmuc
        dtgvDanhMuc.Columns("Xoa").Visible = False
    End Sub
End Class