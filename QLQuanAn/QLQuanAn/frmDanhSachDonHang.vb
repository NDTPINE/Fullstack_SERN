Public Class frmDanhSachDonHang
    Dim dsChiNhanh As DataTable
    Dim dsDonHangView As DataView
    Dim dsDonHang As DataTable
    Private Sub frmDanhSachDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocDSChiNhanh()
        DocDSDonHang(Integer.Parse(cbDSChiNhanh.SelectedValue))
    End Sub
    Private Sub DocDSChiNhanh()
        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where Xoa = 0")
        cbDSChiNhanh.DataSource = dsChiNhanh
        cbDSChiNhanh.DisplayMember = "Ten"
        cbDSChiNhanh.ValueMember = "Ma"
        cbDSChiNhanh.SelectedIndex = 0
    End Sub
    Private Sub DocDSDonHang(ByVal machinhanh As Integer)
        dsDonHang = DuLieu.DocDuLieu("Select * from DonHang where TrangThai = 1 and MaChiNhanh = " + machinhanh.ToString())
        dsDonHangView = New DataView(dsDonHang)
        dtgvDanhSachDonHang.DataSource = dsDonHangView
    End Sub
    Private Sub DocDSTatCaDonHang(ByVal machinhanh As Integer)
        dsDonHang = DuLieu.DocDuLieu("Select * from DonHang where MaChiNhanh = " + machinhanh.ToString())
        dsDonHangView = New DataView(dsDonHang)
        dtgvDanhSachDonHang.DataSource = dsDonHangView
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As frmDonHang = New frmDonHang()

        Dim temp As DataRowView = cbDSChiNhanh.SelectedItem
        frm.KhoiTao(temp.Row, 0, frmDonHang.type_Creat)
        frm.ShowDialog()
        DocDSDonHang(Integer.Parse(cbDSChiNhanh.SelectedValue))
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        If dtgvDanhSachDonHang.SelectedRows.Count > 0 Then
            Dim i As Integer = dtgvDanhSachDonHang.SelectedRows(0).Index
            Dim dhv As DataRowView = dtgvDanhSachDonHang.Rows(i).DataBoundItem
            Dim dh As DataRow = dhv.Row

            Dim frm As frmDonHang = New frmDonHang()

            Dim temp2 As DataRowView = cbDSChiNhanh.SelectedItem
            frm.KhoiTao(temp2.Row, dh("Ma"), frmDonHang.type_View)
            frm.ShowDialog()
        Else MessageBox.Show("Vui long chon don hang")
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If dtgvDanhSachDonHang.SelectedRows.Count > 0 Then
            Dim i As Integer = dtgvDanhSachDonHang.SelectedRows(0).Index
            Dim dhv As DataRowView = dtgvDanhSachDonHang.Rows(i).DataBoundItem
            Dim dh As DataRow = dhv.Row

            Dim frm As frmDonHang = New frmDonHang()

            Dim temp2 As DataRowView = cbDSChiNhanh.SelectedItem
            frm.KhoiTao(temp2.Row, dh("Ma"), frmDonHang.type_Update)
            frm.ShowDialog()
            DocDSDonHang(Integer.Parse(cbDSChiNhanh.SelectedValue))
        Else MessageBox.Show("Vui long chon don hang")
        End If
    End Sub

    Private Sub btnHoanTat_Click(sender As Object, e As EventArgs) Handles btnHoanTat.Click
        If dtgvDanhSachDonHang.SelectedRows.Count > 0 Then
            Dim i As Integer = dtgvDanhSachDonHang.SelectedRows(0).Index
            Dim dhv As DataRowView = dtgvDanhSachDonHang.Rows(i).DataBoundItem
            Dim dh As DataRow = dhv.Row
            dh("TrangThai") = 2
            DuLieu.GhiDuLieu("DonHang", dsDonHang)
            DocDSDonHang(Integer.Parse(cbDSChiNhanh.SelectedValue))

        End If
    End Sub

    Private Sub btnDocTatCaDH_Click(sender As Object, e As EventArgs) Handles btnDocTatCaDH.Click
        DocDSTatCaDonHang(Integer.Parse(cbDSChiNhanh.SelectedValue))
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        If dtgvDanhSachDonHang.SelectedRows.Count > 0 Then
            Dim i As Integer = dtgvDanhSachDonHang.SelectedRows(0).Index
            Dim dhv As DataRowView = dtgvDanhSachDonHang.Rows(i).DataBoundItem
            Dim dh As DataRow = dhv.Row
            dh("TrangThai") = 3
            DuLieu.GhiDuLieu("DonHang", dsDonHang)
            DocDSDonHang(Integer.Parse(cbDSChiNhanh.SelectedValue))

        End If
    End Sub
End Class