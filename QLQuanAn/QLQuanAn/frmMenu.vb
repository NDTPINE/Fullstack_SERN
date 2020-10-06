Public Class frmMenu
    Private dsChiNhanh As DataTable
    Private dsChiNhanhView As DataView
    Private dsMonAn As DataTable
    Private dsMonAnView As DataView
    Private dsMonAnChiNhanh As DataTable
    Private dsmenu As DataTable


    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsChiNhanh = DuLieu.DocDuLieu("select * from ChiNhanh")
        dtgvMenuChiNhanh.DataSource = dsChiNhanh
        dtgvMenuChiNhanh.Columns("Ma").Visible = False
        dtgvMenuChiNhanh.Columns("Xoa").Visible = False
        dtgvMenuChiNhanh.Columns("NgayTao").Visible = False
        dtgvMenuChiNhanh.Columns("NgayCapNhat").Visible = False

        dsMonAn = DuLieu.DocDuLieu("select * from MonAn where Xoa = 0")
        dtgvMenuMonAn.DataSource = dsMonAn
        dsMonAnView = New DataView(dsMonAn)
        dtgvMenuMonAn.Columns("Ma").Visible = False
        dtgvMenuMonAn.Columns("Xoa").Visible = False
        dtgvMenuMonAn.Columns("MaDanhMuc").Visible = False
        dtgvMenuMonAn.Columns("NgayTao").Visible = False
        dtgvMenuMonAn.Columns("NgayCapNhat").Visible = False

        dsmenu = DuLieu.DocDuLieu("select * from Menu")
    End Sub


    Private Sub BtnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        If txbTenMonAn.Text <> "" Then
            dsMonAn = DuLieu.DocDuLieu("Select * from MonAn where Ten Like N'%" + txbTenMonAn.Text + "%'")
            dtgvMenuMonAn.DataSource = dsMonAn
            dtgvMenuMonAn.Columns("Ma").Visible = False
            dtgvMenuMonAn.Columns("Xoa").Visible = False
            dtgvMenuMonAn.Columns("MaDanhMuc").Visible = False
            dtgvMenuMonAn.Columns("NgayTao").Visible = False
            dtgvMenuMonAn.Columns("NgayCapNhat").Visible = False
        End If
    End Sub

    Private Sub BtnTimKiemChiNhanh_Click(sender As Object, e As EventArgs) Handles btnTimKiemChiNhanh.Click
        If txbTenChiNhanh.Text <> "" Then
            dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where Ten Like N'%" + txbTenChiNhanh.Text + "%'")
            dtgvMenuChiNhanh.DataSource = dsChiNhanh
            dtgvMenuChiNhanh.Columns("Ma").Visible = False
            dtgvMenuChiNhanh.Columns("Xoa").Visible = False
            dtgvMenuChiNhanh.Columns("NgayTao").Visible = False
            dtgvMenuChiNhanh.Columns("NgayCapNhat").Visible = False
        End If
    End Sub

    Private Sub TxbTenMonAn_MouseEnter(sender As Object, e As EventArgs) Handles txbTenMonAn.MouseEnter
        txbTenMonAn.Text = ""
    End Sub

    Private Sub TxbTenChiNhanh_MouseEnter(sender As Object, e As EventArgs) Handles txbTenChiNhanh.MouseEnter
        txbTenChiNhanh.Text = ""
    End Sub
    Private Sub TxbTenMonAn_MouseLeave(sender As Object, e As EventArgs) Handles txbTenMonAn.MouseLeave
        If txbTenMonAn.Text = "" Then
            txbTenMonAn.Text = "Tên món ăn"
        End If
    End Sub

    Private Sub TxbTenChiNhanh_MouseLeave(sender As Object, e As EventArgs) Handles txbTenChiNhanh.MouseLeave
        If txbTenChiNhanh.Text = "" Then
            txbTenChiNhanh.Text = "Tên chi nhánh"
        End If
    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If dtgvMenuChiNhanh.SelectedCells.Count = 0 Or dtgvMenuMonAn.SelectedCells.Count = 0 Then
            MessageBox.Show("Vui lòng chọn chi nhánh và món ăn", "Thông báo")
        End If
        Dim macn As DataRow = dsMonAnChiNhanh.NewRow()

        Dim monan As DataRowView = dtgvMenuMonAn.Rows(dtgvMenuMonAn.SelectedCells(0).RowIndex).DataBoundItem
        Dim monanrow As DataRow = monan.Row
        macn("MaMonAn") = monanrow("Ma")
        macn("Gia") = monanrow("Gia")
        macn("TenMonAn") = monanrow("Ten")
        Dim chinhanh As DataRowView = dtgvMenuChiNhanh.Rows(dtgvMenuChiNhanh.SelectedCells(0).RowIndex).DataBoundItem
        Dim chinhanhrow As DataRow = chinhanh.Row
        macn("TenChiNhanh") = chinhanhrow("Ten")
        macn("MaChiNhanh") = chinhanhrow("Ma")
        'kiem tra da ton tai ma mon an va ma chi nhanh chua????
        Dim sql As String = "SELECT * FROM dbo.Menu WHERE MaChiNhanh =" + chinhanhrow("Ma").ToString() + " AND MaMon = " + monanrow("Ma").ToString()
        Dim count As DataTable = DuLieu.DocDuLieu(sql)

        If count.Rows.Count() = 0 Then
            dsMonAnChiNhanh.Rows.Add(macn)
            dtgvMenuMonAnChiNhanh.DataSource = dsMonAnChiNhanh

            Dim menu As DataRow = dsmenu.NewRow()
            menu("MaMon") = monanrow("Ma")
            menu("MaChiNhanh") = chinhanhrow("Ma")
            menu("Gia") = monanrow("Gia")
            dsmenu.Rows.Add(menu)
            DuLieu.GhiDuLieu("Menu", dsmenu)
        End If
        FrmMenu_Load(sender, e)
    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dtgvMenuMonAnChiNhanh.SelectedCells.Count <> 0 Then
            Dim i As Integer = dtgvMenuMonAnChiNhanh.SelectedCells(0).RowIndex
            Dim MonAnChiNhanhView As DataRowView = dtgvMenuMonAnChiNhanh.Rows(i).DataBoundItem
            Dim MonAnChiNhanh As DataRow = MonAnChiNhanhView.Row
            MonAnChiNhanh("Gia") = nmGia.Value

            dsmenu = DuLieu.DocDuLieu("Select * from Menu")
            For Each rows As DataRow In dsmenu.Rows
                If rows("Ma").ToString() = MonAnChiNhanh("Ma").ToString() Then
                    rows("Gia") = nmGia.Value
                End If
            Next
            DuLieu.GhiDuLieu("Menu", dsmenu)
        End If
        FrmMenu_Load(sender, e)
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dtgvMenuMonAnChiNhanh.SelectedCells.Count <> 0 Then
            Dim i As Integer = dtgvMenuMonAnChiNhanh.SelectedCells(0).RowIndex
            Dim MonAnChiNhanhView As DataRowView = dtgvMenuMonAnChiNhanh.Rows(i).DataBoundItem
            Dim MonAnChiNhanh As DataRow = MonAnChiNhanhView.Row

            dsmenu = DuLieu.DocDuLieu("Select * from Menu")
            For j = 0 To dsmenu.Rows.Count - 1
                If dsmenu.Rows(j)("Ma").ToString() = MonAnChiNhanh("Ma").ToString() Then
                    dsmenu.Rows(j).Delete()
                End If
            Next
            MonAnChiNhanh.Delete()
            DuLieu.GhiDuLieu("Menu", dsmenu)
        End If
        FrmMenu_Load(sender, e)
    End Sub


    Private Sub DtgvMenuChiNhanh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvMenuChiNhanh.CellClick
        If dtgvMenuChiNhanh.SelectedCells.Count <> 0 And dtgvMenuMonAn.SelectedCells.Count <> 0 Then
            Dim i As Integer = dtgvMenuChiNhanh.SelectedCells(0).RowIndex
            Dim ChiNhanhView As DataRowView = dtgvMenuChiNhanh.Rows(i).DataBoundItem
            Dim ChiNhanh As DataRow = ChiNhanhView.Row

            Dim j As Integer = dtgvMenuMonAn.SelectedCells(0).RowIndex
            Dim MonAnView As DataRowView = dtgvMenuMonAn.Rows(j).DataBoundItem
            Dim MonAn As DataRow = MonAnView.Row

            Dim sql = "Select mn.Ma, mon.Ten As TenMonAn,mn.Gia, cn.Ten As TenChiNhanh, mn.MaMon As MaMonAn,mn.MaChiNhanh As MaChiNhanh FROM dbo.Menu As mn, dbo.ChiNhanh As cn, dbo.MonAn As mon WHERE cn.Ma = " + ChiNhanh("Ma").ToString() + " And cn.Ma = mn.MaChiNhanh And mon.Ma = mn.MaMon"
            dsMonAnChiNhanh = DuLieu.DocDuLieu(sql)
            dtgvMenuMonAnChiNhanh.DataSource = dsMonAnChiNhanh
            dtgvMenuMonAnChiNhanh.Columns("Ma").Visible = False
            dtgvMenuMonAnChiNhanh.Columns("MaMonAn").Visible = False
            dtgvMenuMonAnChiNhanh.Columns("MaChiNhanh").Visible = False
        End If
    End Sub

    Private Sub dtgvMenuMonAnChiNhanh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvMenuMonAnChiNhanh.CellClick
        If dtgvMenuMonAnChiNhanh.SelectedCells.Count <> 0 Then
            Dim i As Integer = dtgvMenuMonAnChiNhanh.SelectedCells(0).RowIndex
            Dim MonAnChiNhanhView As DataRowView = dtgvMenuMonAnChiNhanh.Rows(i).DataBoundItem
            Dim MonAnChiNhanh As DataRow = MonAnChiNhanhView.Row

            nmGia.Value = MonAnChiNhanh("Gia")
        End If
    End Sub
End Class