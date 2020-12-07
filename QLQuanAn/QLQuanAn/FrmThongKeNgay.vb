Public Class FrmThongKeNgay
    Private dsChiNhanh As DataTable
    Private dt As DataTable

    Private Sub FrmThongKeNgay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNgayTODAY.Text = Date.Now
        Dim query As String = String.Format($"Select * from DonHang where Ngay <= '{Date.Now}'")

        dt = Dulieu.DocDuLieu(query)
        dtgvThongKeNgay.DataSource = dt

        Dim query2 As String = String.Format("select * from ChiNhanh")
        dsChiNhanh = Dulieu.DocDuLieu(query2)
        cbChiNhanh.DataSource = dsChiNhanh
        cbChiNhanh.DisplayMember = "Ten"
        cbChiNhanh.ValueMember = "Ma"
    End Sub

    Private Sub cbChiNhanh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChiNhanh.SelectedIndexChanged
        Dim query As String = String.Format($"Select * from DonHang where Ngay > '{Date.Now.AddDays(-1)}' And MaChiNhanh = {cbChiNhanh.SelectedValue}")
        dt = Dulieu.DocDuLieu(query)
        dtgvThongKeNgay.DataSource = dt
    End Sub
End Class