Public Class frmDanhMuc
    Dim dsdanhmuc As DataTable
    Dim dsdanhmuckhoiphuc As DataTable
    Private Sub frmDanhMuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsdanhmuc = DuLieu.DocDuLieu("Select * from DanhMuc where Xoa = 0")
        dsdanhmuckhoiphuc = DuLieu.DocDuLieu("Select* from DanhMuc where Xoa = 1")
        dtgvDanhMuc.DataSource = dsdanhmuc
        dtgvDanhMuc.Columns("Xoa").Visible = False

        dtgvKhoiphuc.DataSource = dsdanhmuckhoiphuc
        dtgvKhoiphuc.Columns("Xoa").Visible = False
        dtgvKhoiphuc.Columns("Ma").Visible = False
        dtgvKhoiphuc.Columns("NgayTao").Visible = False
        dtgvKhoiphuc.Columns("NgayCapNhat").Visible = False

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txbTenDanhMuc.Text = "" Then
            MessageBox.Show("Tên không được rỗng !", "Thông Báo", MessageBoxButtons.OK)
            txbTenDanhMuc.Select()
            Return
        End If

        Dim dm As DataRow = dsdanhmuc.NewRow()
        dm("Ten") = txbTenDanhMuc.Text
        dsdanhmuc.Rows.Add(dm)

        DuLieu.GhiDuLieu("DanhMuc", dsdanhmuc)
        frmDanhMuc_Load(sender, e)
    End Sub

    Private Sub dtgvChiNhanh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvDanhMuc.CellClick
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

    Private Sub btnSuaChiNhanh_Click(sender As Object, e As EventArgs)
        If dtgvDanhMuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvDanhMuc.SelectedCells(0).RowIndex
            Dim DanhMucView As DataRowView = dtgvDanhMuc.Rows(i).DataBoundItem
            Dim DanhMuc As DataRow = DanhMucView.Row

            DanhMuc("Ten") = txbTenDanhMuc.Text

            DanhMuc("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("DanhMuc", dsdanhmuc)
        End If
        frmDanhMuc_Load(sender, e)
    End Sub

    Private Sub btnXoaChiNhanh_Click(sender As Object, e As EventArgs)
        If dtgvDanhMuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvDanhMuc.SelectedCells(0).RowIndex
            Dim DanhMucView As DataRowView = dtgvDanhMuc.Rows(i).DataBoundItem
            Dim DanhMuc As DataRow = DanhMucView.Row

            DanhMuc("Xoa") = 1
            DanhMuc("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("DanhMuc", dsdanhmuc)

            dsdanhmuc.Rows.Remove(DanhMuc)
        End If
        frmDanhMuc_Load(sender, e)
    End Sub

    Private Sub btnKhoiPhucChiNhanh_Click(sender As Object, e As EventArgs)
        If dtgvKhoiphuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvKhoiphuc.SelectedCells(0).RowIndex
            Dim DanhMucView As DataRowView = dtgvKhoiphuc.Rows(i).DataBoundItem
            Dim DanhMuc As DataRow = DanhMucView.Row

            DanhMuc("Xoa") = 0
            DanhMuc("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("DanhMuc", dsdanhmuckhoiphuc)

        End If
        frmDanhMuc_Load(sender, e)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs)
        dsdanhmuc = DuLieu.DocDuLieu("Select * from DanhMuc where Ten Like N'%" + txbTenDanhMuc.Text + "%'" + "And Xoa = 0")
        dtgvDanhMuc.DataSource = dsdanhmuc
        dtgvDanhMuc.Columns("Xoa").Visible = False
    End Sub
End Class