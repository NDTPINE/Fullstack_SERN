Public Class frmMonAn
    Private dsmonan As DataTable
    Private dsdanhmuc As DataTable
    Private Sub frmMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsmonan = Dulieu.DocDuLieu("SELECT dbo.MonAn.*,dbo.DanhMuc.Ten AS TenDanhMuc FROM	dbo.MonAn, dbo.DanhMuc WHERE dbo.MonAn.Xoa = 0 AND MonAn.MaDanhMuc = dbo.DanhMuc.Ma")
        dsdanhmuc = DuLieu.DocDuLieu("Select* from DanhMuc where Xoa = 0")
        dtgvMonAn.DataSource = dsmonan

        cbDanhMucMonAn.DataSource = dsdanhmuc
        cbDanhMucMonAn.DisplayMember = "Ten"
        cbDanhMucMonAn.ValueMember = "Ma"

        dtgvMonAn.Columns("Xoa").Visible = False
        dtgvMonAn.Columns("Ma").Visible = False
        dtgvMonAn.Columns("MaDanhMuc").Visible = False



    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txbTenMonAn.Text = "" Then
            MessageBox.Show("Tên không được rỗng !", "Thông Báo", MessageBoxButtons.OK)
            txbTenMonAn.Select()
            Return
        End If
        If txbGiaMonAn.Text = "" Then
            MessageBox.Show("Giá không được rỗng !", "Thông Báo", MessageBoxButtons.OK)
            txbGiaMonAn.Select()
            Return
        End If
        Dim sql As String = "EXEC Sp_InSert_MonAn @MaDanhMuc , @Ten , @Gia , @MoTa , @Xoa"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {cbDanhMucMonAn.SelectedValue, txbTenMonAn.Text, txbGiaMonAn.Text, txbMotaMonAn.Text, 0})
        If count > 0 Then
            lbresult.Text = $"Thêm thành công "
        End If

        frmMonAn_Load(sender, e)
    End Sub

    Private Sub dtgvMonAn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvMonAn.CellClick
        If dtgvMonAn.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvMonAn.SelectedCells(0).RowIndex
            Dim MonAnView As DataRowView = dtgvMonAn.Rows(i).DataBoundItem
            Dim MonAn As DataRow = MonAnView.Row
            txbIdMonAn.Text = MonAn("Ma")
            txbTenMonAn.Text = MonAn("Ten")
            txbGiaMonAn.Text = MonAn("Gia")
            cbDanhMucMonAn.SelectedValue = MonAn("MaDanhMuc")
            txbNgayTaoMonAn.Text = MonAn("NgayTao")
            txbNgayCapNhatMonAn.Text = MonAn("NgayCapNhat")
            If IsDBNull(MonAn("MoTa")) Then txbMotaMonAn.Text = "" Else txbMotaMonAn.Text = MonAn("MoTa")
        End If

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim index As Integer = -1
        If dtgvMonAn.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvMonAn.SelectedCells(0).RowIndex
            Dim MonAnView As DataRowView = dtgvMonAn.Rows(i).DataBoundItem
            Dim MonAn As DataRow = MonAnView.Row
            Int32.TryParse(MonAn("Ma"), index)
        End If
        Dim sql As String = "EXEC Sp_Update_MonAn @Ma , @MaDanhMuc , @Ten , @Gia , @MoTa , @Xoa"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index, cbDanhMucMonAn.SelectedValue, txbTenMonAn.Text, txbGiaMonAn.Text, txbMotaMonAn.Text, 0})
        If count > 0 Then
            lbresult.Text = $"Sửa thành công "
        End If
        frmMonAn_Load(sender, e)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim index As Integer = 0
        If dtgvMonAn.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvMonAn.SelectedCells(0).RowIndex
            Dim MonAnView As DataRowView = dtgvMonAn.Rows(i).DataBoundItem
            Dim MonAn As DataRow = MonAnView.Row
            index = MonAn("Ma")
        End If
        Dim sql As String = "EXEC Sp_Delete_MonAn @Ma"
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index})
        If count > 0 Then
            lbresult.Text = $"Xóa thành công "
        End If
        frmMonAn_Load(sender, e)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim check As Integer = 0
        If chbXoa.Checked = True Then
            check = 1
        End If
        dsmonan = Dulieu.DocDuLieu(String.Format($"Select * from MonAn where Ten Like N'%" + txbSearch.Text + "%' and Xoa =  {check}"))
        dtgvMonAn.DataSource = dsmonan
        dtgvMonAn.Columns("Xoa").Visible = False
    End Sub

End Class