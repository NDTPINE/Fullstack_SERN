Public Class FrmKhuyenMai
    Dim dsKhuyenMai As DataTable
    Dim dsChiNhanh As DataTable
    Private Sub FrmKhuyenMai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query1 As String = "Select * from KhuyenMaiTheoChiNhanh"
        dsKhuyenMai = Dulieu.DocDuLieu(query1)
        dtgvKhuyenMai.DataSource = dsKhuyenMai
        Dim query2 As String = "Select * from ChiNhanh"
        dsChiNhanh = Dulieu.DocDuLieu(query2)
        cbChiNhanh.DataSource = dsChiNhanh
        cbChiNhanh.DisplayMember = "Ten"
        cbChiNhanh.ValueMember = "Ma"
        dtgvKhuyenMai.Columns("Ma").Visible = False
    End Sub

    Private Sub dtgvKhuyenMai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvKhuyenMai.CellClick
        If dtgvKhuyenMai.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvKhuyenMai.SelectedCells(0).RowIndex
            Dim kmview As DataRowView = dtgvKhuyenMai.Rows(i).DataBoundItem
            Dim km As DataRow = kmview.Row
            txbMaKhuyenMai.Text = km("Code")
            dtpNgayBatDau.Text = km("NgayBatDau")
            dtpNgayKetThuc.Text = km("NgayKetThuc")
            nmGioBatDau.Value = km("GioBatDau")
            nmGioKetThuc.Value = km("GioKetThuc")
            nmPhanTram.Value = km("PhanTram")
            nmSoTienToiDa.Value = km("SoTienToiDa")
            nmSoTienToiThieu.Value = km("SoTienToiThieuApDung")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SearchText As String = txbSearch.Text
        Dim sql = "select * from KhuyenMaiTheoChiNhanh where Code like '%" + SearchText + "%'"
        dsKhuyenMai = Dulieu.DocDuLieu(sql)
        dtgvKhuyenMai.DataSource = dsKhuyenMai
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = String.Format("EXEC dbo.Sp_Insert_KhuyenMai @Code , @NgayBatDau , @NgayKetThuc , @GioBatDau , @GioKetThuc , @PhanTram , @SoTienToiDa , @SoTienToiThieuApDung , @MaChiNhanh")
        Dim count As Integer = Dulieu.ExecuteNonQuery(query, New Object() {txbMaKhuyenMai.Text, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, nmGioBatDau.Value, nmGioKetThuc.Value, nmPhanTram.Value, nmSoTienToiDa.Value, nmSoTienToiThieu.Value, cbChiNhanh.SelectedValue})
        If count > 0 Then
            lbresult.Text = $"Thêm thành công"
        End If
        FrmKhuyenMai_Load(sender, e)
        ResetImformation(sender, e)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim index As Integer
        If dtgvKhuyenMai.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvKhuyenMai.SelectedCells(0).RowIndex
            Dim kmview As DataRowView = dtgvKhuyenMai.Rows(i).DataBoundItem
            Dim km As DataRow = kmview.Row
            index = Convert.ToInt32(km("Ma"))
        End If
        Dim sql As String = "EXEC Sp_Update_KhuyenMai @Ma , @Code , @NgayBatDau , @NgayKetThuc , @GioBatDau , @GioKetThuc , @SoTien , @SoTienToiDa , @SoTienToiThieuApDung , @MaChiNhanh"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index, txbMaKhuyenMai.Text, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, nmGioBatDau.Value, nmGioKetThuc.Value, nmPhanTram.Value, nmSoTienToiDa.Value, nmSoTienToiThieu.Value, cbChiNhanh.SelectedValue})
        If count > 0 Then
            lbresult.Text = $"Sửa thành công"
            FrmKhuyenMai_Load(sender, e)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim index As Integer
        If dtgvKhuyenMai.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvKhuyenMai.SelectedCells(0).RowIndex
            Dim kmview As DataRowView = dtgvKhuyenMai.Rows(i).DataBoundItem
            Dim km As DataRow = kmview.Row
            index = Convert.ToInt32(km("Ma"))
        End If
        Dim sql As String = "EXEC Sp_Delete_KhuyenMai @Ma"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index})
        If count > 0 Then
            lbresult.Text = $"Xóa thành công"
            FrmKhuyenMai_Load(sender, e)
        End If
    End Sub
    Private Sub ResetImformation(sender As Object, e As EventArgs)
        txbMaKhuyenMai.Text = ""
        nmGioBatDau.Value = 0
        nmGioKetThuc.Value = 0
        nmPhanTram.Value = 0
        nmSoTienToiDa.Value = 0
        nmSoTienToiThieu.Value = 0
        dtpNgayBatDau.Value = DateTime.Now
        dtpNgayKetThuc.Value = DateTime.Now
    End Sub
End Class