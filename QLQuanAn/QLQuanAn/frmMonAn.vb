Public Class frmMonAn
    Private dsmonan As DataTable
    Private dsmonankhoiphuc As DataTable
    Private dsdanhmuc As DataTable
    Private Sub frmMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsmonan = DuLieu.DocDuLieu("SELECT dbo.MonAn.*,dbo.DanhMuc.Ten AS TenDanhMuc FROM	dbo.MonAn, dbo.DanhMuc WHERE dbo.MonAn.Xoa = 0 AND MonAn.MaDanhMuc = dbo.DanhMuc.Ma")
        dsmonankhoiphuc = DuLieu.DocDuLieu("Select* from MonAn where Xoa = 1")
        dsdanhmuc = DuLieu.DocDuLieu("Select* from DanhMuc where Xoa = 0")
        dtgvMonAn.DataSource = dsmonan

        cbDanhMucMonAn.DataSource = dsdanhmuc
        cbDanhMucMonAn.DisplayMember = "Ten"
        cbDanhMucMonAn.ValueMember = "Ma"

        dtgvMonAn.Columns("Xoa").Visible = False
        dtgvMonAn.Columns("Ma").Visible = False
        dtgvMonAn.Columns("MaDanhMuc").Visible = False

        dtgvKhoiphuc.DataSource = dsmonankhoiphuc
        dtgvKhoiphuc.Columns("Xoa").Visible = False
        dtgvKhoiphuc.Columns("Ma").Visible = False
        dtgvKhoiphuc.Columns("NgayTao").Visible = False
        dtgvKhoiphuc.Columns("NgayCapNhat").Visible = False

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

        Dim monan As DataRow = dsmonan.NewRow()
        monan("Ten") = txbTenMonAn.Text
        monan("Gia") = txbGiaMonAn.Text
        monan("MoTa") = txbMotaMonAn.Text
        monan("MaDanhMuc") = cbDanhMucMonAn.SelectedValue
        dsmonan.Rows.Add(monan)

        DuLieu.GhiDuLieu("MonAn", dsmonan)
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
        If dtgvMonAn.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvMonAn.SelectedCells(0).RowIndex
            Dim MonAnView As DataRowView = dtgvMonAn.Rows(i).DataBoundItem
            Dim MonAn As DataRow = MonAnView.Row

            MonAn("Ten") = txbTenMonAn.Text
            MonAn("Gia") = txbGiaMonAn.Text
            MonAn("MaDanhMuc") = cbDanhMucMonAn.SelectedValue
            MonAn("MoTa") = txbMotaMonAn.Text
            MonAn("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("MonAn", dsmonan)
        End If
        frmMonAn_Load(sender, e)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dtgvMonAn.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvMonAn.SelectedCells(0).RowIndex
            Dim MonAnView As DataRowView = dtgvMonAn.Rows(i).DataBoundItem
            Dim MonAn As DataRow = MonAnView.Row

            MonAn("Xoa") = 1
            MonAn("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("MonAn", dsmonan)

            MonAn.Delete()
        End If
        frmMonAn_Load(sender, e)
    End Sub

    Private Sub btnKhoiPhu_Click(sender As Object, e As EventArgs) Handles btnKhoiPhuc.Click
        If dtgvKhoiphuc.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvKhoiphuc.SelectedCells(0).RowIndex
            Dim MonAnView As DataRowView = dtgvKhoiphuc.Rows(i).DataBoundItem
            Dim MonAn As DataRow = MonAnView.Row

            MonAn("Xoa") = 0
            MonAn("NgayCapNhat") = DateTime.Now
            DuLieu.GhiDuLieu("MonAn", dsmonankhoiphuc)

        End If
        frmMonAn_Load(sender, e)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        dsmonan = DuLieu.DocDuLieu("Select * from MonAn where Ten Like N'%" + txbTenMonAn.Text + "%'")
        dtgvMonAn.DataSource = dsmonan
        dtgvMonAn.Columns("Xoa").Visible = False
    End Sub

End Class