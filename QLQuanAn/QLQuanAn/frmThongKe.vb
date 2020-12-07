Public Class frmThongKe
    Private dsDonHang As DataTable
    Private dsChiNhanh As DataTable



    Private Sub frmThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query2 As String = String.Format("select * from ChiNhanh")
        dsChiNhanh = Dulieu.DocDuLieu(query2)
        cbChiNhanh.DataSource = dsChiNhanh
        cbChiNhanh.DisplayMember = "Ten"
        cbChiNhanh.ValueMember = "Ma"

        Dim query As String = String.Format($"select * from DonHang")
        dsDonHang = Dulieu.DocDuLieu(query)
        dtgvThongKe.DataSource = dsDonHang

    End Sub

    Private Sub TongTien(dsdh As DataView)
        Dim TongTien As Integer
        For Each item As DataRowView In dsdh
            TongTien = TongTien + Int32.Parse(item("Tongtien"))
        Next
        txbTongTien.Text = TongTien
    End Sub
    Private Sub TongKhuyenMai(dsdh As DataView)
        Dim TongKhuyenMai As Integer = 0
        For Each item As DataRowView In dsdh
            TongKhuyenMai = TongKhuyenMai + Int32.Parse(item("TongMonAn")) - Int32.Parse(item("TongTien")) - Int32.Parse(item("Phuphi")) + Int32.Parse(item("GiamGia"))
        Next
        txbTongKhuyenMai.Text = TongKhuyenMai
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim TuNgay As DateTime = dtpFrom.Value
        Dim DenNgay As DateTime = dtpTo.Value
        Dim TC_H As Integer = 0
        Dim query As String = String.Format($"Select * from DonHang where MaChiNhanh = {cbChiNhanh.SelectedValue} and Ngay <= '{DenNgay}' and Ngay >= '{TuNgay}'")
        If chbThanhCong.Checked = True Then
            TC_H = 2
        End If
        If cbHuy.Checked = True Then
            TC_H = 3
        End If
        If cbHuy.Checked = True And chbThanhCong.Checked = True Then
            TC_H = 0
        End If
        If TC_H <> 0 Then
            query = String.Format($"Select * from DonHang where MaChiNhanh = {cbChiNhanh.SelectedValue} and TrangThai = {TC_H} and Ngay <= '{DenNgay}' and Ngay >= '{TuNgay}'")
        End If
        dsDonHang = Dulieu.DocDuLieu(query)
        dtgvThongKe.DataSource = dsDonHang
        Dim temp As DataView = New DataView(dsDonHang)
        TongTien(temp)
        txbSoLuongDH.Text = dsDonHang.Rows.Count
        TongKhuyenMai(temp)
    End Sub

    Private Sub cbChiNhanh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChiNhanh.SelectedIndexChanged
        Dim TuNgay As DateTime = dtpFrom.Value
        Dim DenNgay As DateTime = dtpTo.Value
        Dim query As String = String.Format($"Select * from DonHang where MaChiNhanh = {cbChiNhanh.SelectedValue} and Ngay <= '{DenNgay}' and Ngay >= '{TuNgay}'")
        Dim dsdonhang As DataTable = New DataTable()
        dsdonhang = Dulieu.DocDuLieu(query)
        dtgvThongKe.DataSource = dsdonhang
    End Sub
End Class