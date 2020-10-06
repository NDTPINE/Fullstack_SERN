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
        dsDonHang = DuLieu.DocDuLieu("Select * from DonHang where MaChiNhanh = " + machinhanh.ToString())
        dsDonHangView = New DataView(dsDonHang)
        dtgvDanhSachDonHang.DataSource = dsDonHangView
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As frmDonHang = New frmDonHang()
        frm.WindowState = WindowState.Maximized
        Dim temp As DataRowView = cbDSChiNhanh.SelectedItem
        frm.KhoiTaoChiNhanh(temp.Row)
        frm.ShowDialog()
        DocDSDonHang(Integer.Parse(cbDSChiNhanh.SelectedValue))
    End Sub
End Class