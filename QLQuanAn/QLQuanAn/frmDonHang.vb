Public Class frmDonHang
    Private ChiNhanh As DataRow
    Private dsMonAn As DataTable
    Private dsMonAnView As DataView
    Private dsChiTietDonHang As DataTable
    Public Sub KhoiTaoChiNhanh(cn As DataRow)
        ChiNhanh = cn
    End Sub

    Private Sub frmDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbChiNhanh.Text = ChiNhanh("Ten")

        Dim str As String = String.Format("Select MonAn.Ma, MonAn.Ten, Menu.Gia from Menu, MonAn where Menu.MaChiNhanh = {0} and Menu.MaMon = MonAn.Ma", ChiNhanh(0))
        DocDs(str, dtgvDSMonAn)
        Dim str2 As String = String.Format("SELECT ct.Ma,dbo.MonAn.Ten,ct.Soluong,ct.Gia,ct.TongMonAn, ct.Giamgia,ct.TongTien FROM dbo.ChiTietDonHang AS ct, dbo.MonAn WHERE ct.MaMonAn = MonAn.Ma")
        DocDs(str2, dtgvChiTietDonHang)
        dtgvChiTietDonHang.Columns("Ma").Visible = False
        dsMonAn = DuLieu.DocDuLieu(String.Format("Select MonAn.Ma, MonAn.Ten, Menu.Gia from Menu, MonAn where Menu.MaChiNhanh = {0} and Menu.MaMon = MonAn.Ma", ChiNhanh(0)))
        dsChiTietDonHang = DuLieu.DocDuLieu("SELECT ct.Ma,ct.MaMonAn,dbo.MonAn.Ten,ct.Soluong,ct.Gia,ct.TongMonAn, ct.Giamgia,ct.TongTien FROM dbo.ChiTietDonHang AS ct, dbo.MonAn, dbo.DonHang WHERE ct.MaMonAn = MonAn.Ma")
    End Sub
    Public Sub DocDs(str As String, dtgv As DataGridView)
        Dim ds As DataTable = DuLieu.DocDuLieu(str)
        Dim dsView As DataView = New DataView(ds)
        dtgv.DataSource = dsView
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim str As String = String.Format("Select MonAn.Ma, MonAn.Ten, Menu.Gia from Menu, MonAn where Menu.MaChiNhanh = {0} and Menu.MaMon = MonAn.Ma and MonAn.Ten Like N'%{1}%'", ChiNhanh(0), txbTimKiem.Text)
        DocDs(str, dtgvDSMonAn)
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
                    ctma("TongTien") = ctma("TongMonAn") = ctma("GiamGia")
                    dsChiTietDonHang.Rows.Add(ctma)
                Else
                    Dim ctma = dsChiTietDonHang.Rows(vitri)
                    ctma("Soluong") = ctma("Soluong") + nmSoLuong.Value
                    ctma("TongMonAn") = ctma("Gia") * ctma("SoLuong")
                    ctma("Giamgia") = 0
                    ctma("TongTien") = ctma("TongMonAn") = ctma("GiamGia")
                End If
            Next
            dtgvChiTietDonHang.DataSource = dsChiTietDonHang

        Else
            MessageBox.Show("Vui lòng chọn món ăn", "Thông báo")
        End If
    End Sub
End Class