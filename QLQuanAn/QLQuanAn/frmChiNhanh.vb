Public Class frmChiNhanh
    Dim dschinhanh As DataTable
    Dim dschinhanhkhoiphuc As DataTable
    Private Sub frmChiNhanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dschinhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where Xoa = 0")
        dschinhanhkhoiphuc = DuLieu.DocDuLieu("Select* from ChiNhanh where Xoa = 1")
        dtgvChiNhanh.DataSource = dschinhanh
        dtgvChiNhanh.Columns("Xoa").Visible = False

        dtgvKhoiphuc.DataSource = dschinhanhkhoiphuc
        dtgvKhoiphuc.Columns("Xoa").Visible = False
        dtgvKhoiphuc.Columns("Ma").Visible = False
        dtgvKhoiphuc.Columns("NgayTao").Visible = False
        dtgvKhoiphuc.Columns("NgayCapNhat").Visible = False

    End Sub

    Private Sub btnThemChiNhanh_Click(sender As Object, e As EventArgs)
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

        Dim cn As DataRow = dschinhanh.NewRow()
        cn("Ten") = txbTenChiNhanh.Text
        cn("DiaChi") = txbDiaChiChiNhanh.Text
        dschinhanh.Rows.Add(cn)

        DuLieu.GhiDuLieu("ChiNhanh", dschinhanh)
        frmChiNhanh_Load(sender, e)
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

    Private Sub btnSuaChiNhanh_Click(sender As Object, e As EventArgs)
        If dtgvChiNhanh.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvChiNhanh.SelectedCells(0).RowIndex
            Dim ChiNhanhView As DataRowView = dtgvChiNhanh.Rows(i).DataBoundItem
            Dim ChiNhanh As DataRow = ChiNhanhView.Row

            ChiNhanh("Ten") = txbTenChiNhanh.Text
            ChiNhanh("DiaChi") = txbDiaChiChiNhanh.Text
            ChiNhanh("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("ChiNhanh", dschinhanh)
        End If
        frmChiNhanh_Load(sender, e)
    End Sub

    Private Sub btnXoaChiNhanh_Click(sender As Object, e As EventArgs)
        If dtgvChiNhanh.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvChiNhanh.SelectedCells(0).RowIndex
            Dim ChiNhanhView As DataRowView = dtgvChiNhanh.Rows(i).DataBoundItem
            Dim ChiNhanh As DataRow = ChiNhanhView.Row

            ChiNhanh("Xoa") = 1
            ChiNhanh("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("ChiNhanh", dschinhanh)

            dschinhanh.Rows.Remove(ChiNhanh)
        End If
        frmChiNhanh_Load(sender, e)
    End Sub

    Private Sub btnKhoiPhucChiNhanh_Click(sender As Object, e As EventArgs)
        If dtgvKhoiphuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvKhoiphuc.SelectedCells(0).RowIndex
            Dim ChiNhanhView As DataRowView = dtgvKhoiphuc.Rows(i).DataBoundItem
            Dim ChiNhanh As DataRow = ChiNhanhView.Row

            ChiNhanh("Xoa") = 0
            ChiNhanh("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("ChiNhanh", dschinhanhkhoiphuc)

        End If
        frmChiNhanh_Load(sender, e)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs)
        dschinhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where Ten Like N'%" + txbTenChiNhanh.Text + "%'")
        dtgvChiNhanh.DataSource = dschinhanh
        dtgvChiNhanh.Columns("Xoa").Visible = False
    End Sub
End Class