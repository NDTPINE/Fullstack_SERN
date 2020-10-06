Public Class frmDonHang
    Private ChiNhanh As DataRow
    Private dsMonAn As DataTable
    Private dsMonAnView As DataView
    Private dsChiTietDonHang As DataTable
    Public dsDonhang As DataTable
    Private TongMonAn As Integer = 0
    Private TongTien As Integer = 0
    Private giamgia As Integer = 0
    Private phuphi As Integer = 0
    Public Sub KhoiTaoChiNhanh(cn As DataRow)
        ChiNhanh = cn
    End Sub

    Private Sub frmDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbChiNhanh.Text = ChiNhanh("Ten")
        DocDSMonAn()
        DocCauTrucChiTietDonHang()
        DocCauTrucDonHang()
    End Sub
    Public Sub DocDSMonAn()
        Dim str As String = String.Format("Select MonAn.Ma as Ma, MonAn.Ten as Ten, Menu.Gia from Menu, MonAn where Menu.MaChiNhanh = {0} and Menu.MaMon = MonAn.Ma", ChiNhanh(0))
        dsMonAn = DuLieu.DocDuLieu(str)
        dsMonAnView = New DataView(dsMonAn)
        dtgvDSMonAn.DataSource = dsMonAnView
    End Sub
    Private Sub DocCauTrucChiTietDonHang()
        Dim str As String = String.Format("SELECT ct.Ma,ct.MaMonAn,ct.MaDonHang,dbo.MonAn.Ten,ct.Soluong,ct.Gia,ct.TongMonAn, ct.Giamgia,ct.TongTien FROM dbo.ChiTietDonHang AS ct, dbo.MonAn WHERE ct.MaMonAn = MonAn.Ma")
        dsChiTietDonHang = DuLieu.DocCauTruc(str)
        dtgvChiTietDonHang.DataSource = dsChiTietDonHang
        dtgvChiTietDonHang.Columns("MaMonAn").Visible = False
    End Sub
    Private Sub DocCauTrucDonHang()
        Dim str As String = String.Format("select * FROM dbo.DonHang")
        dsDonhang = DuLieu.DocCauTruc(str)
    End Sub
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        If txbTimKiem.Text = "" Then
            dsMonAnView.RowFilter = ""
        Else
            dsMonAnView.RowFilter = "Ten like '%" + txbTimKiem.Text + "%'"
        End If
    End Sub
    Function TimViTriMonAnTrongDSChiTietMonAn(ByVal ma As DataRow) As Integer
        Dim kq As Integer = -1
        For i = 0 To dsChiTietDonHang.Rows.Count - 1
            If dsChiTietDonHang.Rows(i)("MaMonAn") = ma("Ma") Then
                kq = i
                Exit For
            End If
        Next
        Return kq
    End Function
    Private Sub TinhTongTien()

        Dim TongGiamGiaMonAn = 0
        TongMonAn = 0
        If Not (dsChiTietDonHang Is Nothing) Then
            For i = 0 To dsChiTietDonHang.Rows.Count - 1
                Dim ctma = dsChiTietDonHang.Rows(i)
                TongMonAn = TongMonAn + ctma("TongMonAn")
                TongGiamGiaMonAn = TongGiamGiaMonAn + ctma("Giamgia")
            Next
        End If
        giamgia = 0
        phuphi = 0
        TongTien = 0

        Integer.TryParse(txbGiamGia.Text, giamgia)
        Integer.TryParse(txbPhuPhi.Text, phuphi)

        TongTien = TongMonAn - TongGiamGiaMonAn
        TongTien = TongTien - giamgia * TongTien / 100
        TongTien = TongTien + phuphi

        txbTongMonAn.Text = TongMonAn.ToString()
        txbTongTien.Text = TongTien.ToString()

    End Sub
    Private Sub btnThemMonAn_Click(sender As Object, e As EventArgs) Handles btnThemMonAn.Click
        If dtgvDSMonAn.SelectedRows.Count > 0 Then
            For j = 0 To dtgvDSMonAn.SelectedRows.Count - 1
                Dim i As Integer = dtgvDSMonAn.SelectedRows(j).Index
                Dim maview As DataRowView = dtgvDSMonAn.Rows(i).DataBoundItem
                Dim ma As DataRow = maview.Row

                Dim vitri = TimViTriMonAnTrongDSChiTietMonAn(ma)
                If vitri = -1 Then
                    Dim ctma As DataRow = dsChiTietDonHang.NewRow()
                    ctma("MaMonAn") = ma("Ma")
                    ctma("Ten") = ma("Ten")
                    ctma("Soluong") = nmSoLuong.Value
                    ctma("Gia") = ma("Gia")
                    ctma("TongMonAn") = ctma("Gia") * ctma("Soluong")
                    ctma("Giamgia") = 0
                    ctma("TongTien") = ctma("TongMonAn") - ctma("GiamGia")
                    dsChiTietDonHang.Rows.Add(ctma)
                Else
                    Dim ctma = dsChiTietDonHang.Rows(vitri)
                    ctma("Soluong") = ctma("Soluong") + nmSoLuong.Value
                    ctma("TongMonAn") = ctma("Gia") * ctma("SoLuong")
                    ctma("Giamgia") = 0
                    ctma("TongTien") = ctma("TongMonAn") - ctma("GiamGia")
                End If
            Next
            TinhTongTien()

        Else
            MessageBox.Show("Vui lòng chọn món ăn", "Thông báo")
        End If
    End Sub

    Private Sub txbPhuPhi_TextChanged(sender As Object, e As EventArgs) Handles txbPhuPhi.TextChanged
        If Integer.TryParse(txbPhuPhi.Text, 0) Then
            TinhTongTien()
        Else
            txbPhuPhi.Undo()
        End If
    End Sub

    Private Sub txbGiamGia_TextChanged(sender As Object, e As EventArgs) Handles txbGiamGia.TextChanged
        If Integer.TryParse(txbGiamGia.Text, 0) Then
            TinhTongTien()
        Else
            txbGiamGia.Undo()
        End If
    End Sub

    Private Sub btnTaoDonHang_Click(sender As Object, e As EventArgs) Handles btnTaoDonHang.Click
        Dim dh As DataRow = dsDonhang.NewRow()
        dh("Ngay") = dtpNgay.Value
        dh("Ten") = txbTen.Text
        dh("DienThoai") = txbDienThoai.Text
        dh("MaChiNhanh") = ChiNhanh("Ma")
        dh("TongMonAn") = TongMonAn
        dh("GiamGia") = giamgia
        dh("TongTien") = TongTien
        dh("TrangThai") = txbTrangThai.Text
        dh("Phuphi") = phuphi
        dsDonhang.Rows.Add(dh)
        DuLieu.GhiDuLieu("DonHang", dsDonhang)
        dsDonhang = DuLieu.DocDuLieu("SELECT MAX(Ma) FROM dbo.DonHang")
        Dim madonhang As Integer = dsDonhang.Rows(0)(0)
        For i = 0 To dsChiTietDonHang.Rows.Count - 1
            dsChiTietDonHang.Rows(i)("MaDonHang") = madonhang
        Next
        DuLieu.GhiDuLieu("ChiTietDonHang", dsChiTietDonHang)
        Me.Close()
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        If dtgvChiTietDonHang.SelectedRows.Count > 0 Then
            For j = 0 To dtgvChiTietDonHang.SelectedRows.Count - 1
                Dim i As Integer = dtgvChiTietDonHang.SelectedRows(j).Index
                Dim maview As DataRowView = dtgvChiTietDonHang.Rows(i).DataBoundItem
                Dim ma As DataRow = maview.Row
                dsChiTietDonHang.Rows.Remove(ma)
            Next
        End If
        TinhTongTien()
    End Sub
End Class