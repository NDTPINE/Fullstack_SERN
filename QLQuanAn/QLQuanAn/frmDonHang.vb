Public Class frmDonHang
    Public Shared type_Update = 1
    Public Shared type_Creat = 2
    Public Shared type_View = 3

    Private ChiNhanh As DataRow
    Private dsMonAn As DataTable
    Private dsMonAnView As DataView
    Private dsKhuyenMai As DataTable
    Private dsChiTietDonHang As DataTable
    Public dsDonhang As DataTable
    Private TongMonAn As Integer = 0
    Private TongTien As Integer = 0
    Private giamgia As Integer = 0
    Private phuphi As Integer = 0
    Private LoaiThaoTac As Integer
    Private MaDonHang As Long

    Public Sub KhoiTao(cn As DataRow, madh As Long, loai As Integer)
        ChiNhanh = cn
        LoaiThaoTac = loai
        MaDonHang = madh
    End Sub

    Private Sub frmDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbChiNhanh.Text = ChiNhanh("Ten")
        DocDSMonAn()
        DocdsKhuyenMai()

        If LoaiThaoTac = type_View Then
            DocThongTinDonHang()
            DocChiTietDonHang()

            btnThemMonAn.Visible = False
            btnXoaMonAn.Visible = False
            btnXoaTatCa.Visible = False
            btnTaoDonHang.Visible = False
            txbPhuPhi.ReadOnly = True
            txbGiamGia.ReadOnly = True
        ElseIf LoaiThaoTac = type_Creat Then
            DocCauTrucDonHang()
            DocCauTrucChiTietDonHang()

        Else 'type = type_update
            DocThongTinDonHang()
            DocChiTietDonHang()

            btnTaoDonHang.Text = "Cập nhật"
        End If

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
        dtgvChiTietDonHang.Columns("Ma").Visible = False
        dtgvChiTietDonHang.Columns("MaDonHang").Visible = False
    End Sub
    Private Sub DocChiTietDonHang()
        Dim str As String = String.Format("SELECT ct.Ma,ct.MaMonAn,ct.MaDonHang,dbo.MonAn.Ten,ct.Soluong,ct.Gia,ct.TongMonAn, ct.Giamgia,ct.TongTien FROM dbo.ChiTietDonHang AS ct, dbo.MonAn WHERE ct.MaMonAn = MonAn.Ma and ct.MaDonHang = " + MaDonHang.ToString())
        dsChiTietDonHang = DuLieu.DocDuLieu(str)
        dtgvChiTietDonHang.DataSource = dsChiTietDonHang
        dtgvChiTietDonHang.Columns("Ma").Visible = False
        dtgvChiTietDonHang.Columns("MaDonHang").Visible = False

        TinhTongTien()
    End Sub
    Private Sub DocCauTrucDonHang()
        Dim str As String = String.Format("select * FROM dbo.DonHang")
        dsDonhang = DuLieu.DocCauTruc(str)
    End Sub
    Private Sub DocThongTinDonHang()
        Dim str As String = String.Format("select * FROM dbo.DonHang where ma = " + MaDonHang.ToString())
        dsDonhang = DuLieu.DocDuLieu(str)
        If dsDonhang.Rows.Count > 0 Then
            txbDienThoai.Text = dsDonhang(0)("DienThoai").ToString()
            txbTen.Text = dsDonhang(0)("Ten").ToString()
            txbPhuPhi.Text = dsDonhang(0)("Phuphi").ToString()
            txbGiamGia.Text = dsDonhang(0)("GiamGia").ToString()
        End If

    End Sub
    Private Sub DocdsKhuyenMai()
        Dim maChiNhanh As Integer = Int32.Parse(ChiNhanh("Ma"))
        Dim sql As String = String.Format($"Select * from KhuyenMaiTheoChiNhanh where MaChiNhanh = {maChiNhanh} and NgayKetThuc > '{DateTime.Now}'")
        dsKhuyenMai = Dulieu.DocDuLieu(sql)
        cbKhuyenMai.DataSource = dsKhuyenMai
        cbKhuyenMai.DisplayMember = "Code"
        cbKhuyenMai.ValueMember = "Ma"
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

        Dim TongGiamGiaMonAn As Integer = 0
        Dim TongGiamGia As Integer = 0
        TongMonAn = 0
        If Not (dsChiTietDonHang Is Nothing) Then
            For i = 0 To dsChiTietDonHang.Rows.Count - 1
                Dim ctma = dsChiTietDonHang.Rows(i)
                If ctma.RowState = DataRowState.Deleted Then
                    Continue For
                End If
                TongMonAn = TongMonAn + ctma("TongMonAn")
                TongGiamGiaMonAn = TongGiamGiaMonAn + ctma("Giamgia")
            Next
        End If
        giamgia = 0
        phuphi = 0
        TongTien = 0

        Integer.TryParse(txbGiamGia.Text, giamgia)
        TongGiamGia = TongGiamGiaMonAn + giamgia
        Integer.TryParse(txbPhuPhi.Text, phuphi)

        TongTien = TongMonAn - TongGiamGia
        TongTien = TongTien + phuphi

        If cbKhuyenMai.SelectedIndex <> -1 Then
            Dim km = dsKhuyenMai.Rows(cbKhuyenMai.SelectedIndex)
            Dim sotienKM As Integer = 0
            If TongTien > Int32.Parse(km("SoTienToiThieuApDung")) Then
                If (Int32.Parse(km("PhanTram") * TongTien) / 100 > Int32.Parse(km("SoTienToiDa"))) Then
                    sotienKM = Int32.Parse(km("SoTienToiDa"))
                Else
                    sotienKM = Int32.Parse(km("PhanTram") * TongTien) / 100
                End If
            End If
            TongGiamGia = TongGiamGia + sotienKM
            TongTien = TongMonAn - TongGiamGia
            TongTien = TongTien + phuphi
        End If
        txbTongGiamGia.Text = TongGiamGia.ToString()
        txbGiamGiaMonAn.Text = TongGiamGiaMonAn.ToString()
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
        If LoaiThaoTac = type_Creat Then
            Dim dh As DataRow = dsDonhang.NewRow()
            dh("Ngay") = DateTime.Now
            dh("Ten") = txbTen.Text
            dh("DienThoai") = txbDienThoai.Text
            dh("MaChiNhanh") = ChiNhanh("Ma")
            dh("TongMonAn") = TongMonAn
            dh("GiamGia") = giamgia
            dh("TongTien") = TongTien
            dh("TrangThai") = 1
            dh("Phuphi") = phuphi

            dsDonhang.Rows.Add(dh)
            DuLieu.GhiDuLieu("DonHang", dsDonhang)
            dsDonhang = DuLieu.DocDuLieu("SELECT MAX(Ma) FROM dbo.DonHang")
            Dim madonhang As Integer = dsDonhang.Rows(0)(0)
            For i = 0 To dsChiTietDonHang.Rows.Count - 1
                dsChiTietDonHang.Rows(i)("MaDonHang") = madonhang
            Next
            Dulieu.GhiDuLieu("ChiTietDonHang", dsChiTietDonHang)

            Dim frm = Me.Parent
            Me.Close()
        ElseIf LoaiThaoTac = type_Update Then
            Dim dh As DataRow = dsDonhang.Rows(0)
            dh("Ten") = txbTen.Text
            dh("DienThoai") = txbDienThoai.Text
            dh("MaChiNhanh") = ChiNhanh("Ma")
            dh("TongMonAn") = TongMonAn
            dh("GiamGia") = giamgia
            dh("TongTien") = TongTien
            dh("TrangThai") = 1
            dh("Phuphi") = phuphi
            DuLieu.GhiDuLieu("DonHang", dsDonhang)

            For i = 0 To dsChiTietDonHang.Rows.Count - 1
                If dsChiTietDonHang.Rows(i).RowState = DataRowState.Deleted Then
                    Continue For
                End If
                dsChiTietDonHang.Rows(i)("MaDonHang") = MaDonHang
            Next
            DuLieu.GhiDuLieu("ChiTietDonHang", dsChiTietDonHang)
            Me.Close()
        End If
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        If dtgvChiTietDonHang.SelectedRows.Count > 0 Then
            For j = 0 To dtgvChiTietDonHang.SelectedRows.Count - 1
                Dim i As Integer = dtgvChiTietDonHang.SelectedRows(j).Index
                Dim maview As DataRowView = dtgvChiTietDonHang.Rows(i).DataBoundItem
                Dim ma As DataRow = maview.Row
                If LoaiThaoTac = type_Creat Then
                    dsChiTietDonHang.Rows.Remove(ma)
                Else
                    ma.Delete()
                End If

            Next
        End If
        TinhTongTien()
    End Sub

    Private Sub btnXoaMonAn_Click(sender As Object, e As EventArgs) Handles btnXoaMonAn.Click
        If dtgvChiTietDonHang.SelectedRows.Count > 0 Then
            For j = 0 To dtgvChiTietDonHang.SelectedRows.Count - 1
                Dim i As Integer = dtgvChiTietDonHang.SelectedRows(j).Index
                Dim maview As DataRowView = dtgvChiTietDonHang.Rows(i).DataBoundItem
                Dim ma As DataRow = maview.Row
                Dim sl As Integer = ma("Soluong")
                sl = sl - nmSoLuong.Value
                If sl > 0 Then
                    ma("Soluong") = sl
                    ma("TongMonAn") = ma("Gia") * ma("SoLuong")

                    ma("TongTien") = ma("TongMonAn") - ma("GiamGia")

                Else
                    dsChiTietDonHang.Rows.Remove(ma)
                End If
            Next
            TinhTongTien()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class