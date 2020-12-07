Public Class frmTaiKhoan
    Dim dsTaiKhoan As DataTable
    Dim dsLoaiTaiKhoan As DataTable
    Dim userlogin As String
    Dim passlogin As String
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim sql As String = String.Format("EXEC dbo.Sp_Insert_Taikhoan @TenDangNhap , @Matkhau , @HoTen , @NgaySinh , @MaLoaiTaiKhoan , @HoatDong")
        If userlogin <> "admin" Then
            lbresult.Text = $"Bạn không phải admin"
        Else
            Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {txbUser.Text, txbPass.Text, txbName.Text, dtpNgaySinh.Value, cbTypeUser.SelectedValue, txbActive.Text})
            If count > 0 Then
                lbresult.Text = $"Thêm thành công"
            End If
            frmTaiKhoan_Load(sender, e)
            ResetImformation(sender, e)
        End If
    End Sub

    Private Sub frmTaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "select * from TaiKhoan"
        dsTaiKhoan = Dulieu.DocDuLieu(sql)
        dtgvTaiKhoan.DataSource = dsTaiKhoan
        dsLoaiTaiKhoan = Dulieu.DocDuLieu("Select * from LoaiTaiKhoan")
        cbTypeUser.DataSource = dsLoaiTaiKhoan
        cbTypeUser.DisplayMember = "MoTa"
        cbTypeUser.ValueMember = "Ma"
        dtgvTaiKhoan.Columns(0).Visible = False
        dtgvTaiKhoan.Columns(2).Visible = False
        dtgvTaiKhoan.Columns(5).Visible = False

        userlogin = MainWindow.username
        passlogin = MainWindow.password

    End Sub
    Private Sub ResetImformation(sender As Object, e As EventArgs)
        txbIdTaikhoan.Text = ""
        txbUser.Text = ""
        txbName.Text = ""
        txbPass.Text = ""
        txbActive.Text = ""
        dtpNgaySinh.Text = DateTime.Now
    End Sub
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim SearchText As String = txbSearch.Text
        Dim sql = "select * from TaiKhoan where TenDangNhap like '%" + SearchText + "%'"
        dsTaiKhoan = Dulieu.DocDuLieu(sql)
        dtgvTaiKhoan.DataSource = dsTaiKhoan
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim index As Integer
        Dim check As Boolean = False
        If dtgvTaiKhoan.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvTaiKhoan.SelectedCells(0).RowIndex
            Dim taikhoanView As DataRowView = dtgvTaiKhoan.Rows(i).DataBoundItem
            Dim taikhoan As DataRow = taikhoanView.Row
            If userlogin = taikhoan("TenDangNhap") And passlogin = taikhoan("Matkhau") Then
                check = True
            End If
            index = Convert.ToInt32(taikhoan("Ma"))
        End If
        Dim Sql As String = "EXEC dbo.Sp_Delete_Taikhoan @Ma"

        If check Then
            lbresult.Text = "Không thể xóa tài khoản đăng nhập"
        Else
            Dim count As Integer = Dulieu.ExecuteNonQuery(Sql, New Object() {index})
            If count > 0 Then
                lbresult.Text = $"Xóa thành công"
                frmTaiKhoan_Load(sender, e)
            End If
        End If


    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim index As Integer
        If dtgvTaiKhoan.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvTaiKhoan.SelectedCells(0).RowIndex
            Dim taikhoanView As DataRowView = dtgvTaiKhoan.Rows(i).DataBoundItem
            Dim taikhoan As DataRow = taikhoanView.Row
            index = Convert.ToInt32(taikhoan("Ma"))
        End If
        Dim sql As String = String.Format("EXEC dbo.Sp_Update_Taikhoan @Ma , @TenDangNhap , @Matkhau , @HoTen , @NgaySinh , @MaLoaiTaiKhoan , @HoatDong")
        Dim count As Integer = Dulieu.ExecuteNonQuery(sql, New Object() {index, txbUser.Text, txbPass.Text, txbName.Text, dtpNgaySinh.Value, cbTypeUser.SelectedValue, txbActive.Text})
        If count > 0 Then
            lbresult.Text = $"Sửa thành công "
        End If
        frmTaiKhoan_Load(sender, e)
        ResetImformation(sender, e)
    End Sub

    Private Sub dtgvTaiKhoan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvTaiKhoan.CellClick
        If dtgvTaiKhoan.SelectedCells.Count > 0 Then
            Dim i As Integer = dtgvTaiKhoan.SelectedCells(0).RowIndex
            Dim taikhoanView As DataRowView = dtgvTaiKhoan.Rows(i).DataBoundItem
            Dim taikhoan As DataRow = taikhoanView.Row
            txbIdTaikhoan.Text = taikhoan("Ma")
            txbUser.Text = taikhoan("TenDangNhap")
            txbName.Text = taikhoan("HoTen")
            cbTypeUser.SelectedValue = taikhoan("MaLoaiTaiKhoan")
            txbActive.Text = taikhoan("HoatDong")
            dtpNgaySinh.Text = taikhoan("NgaySinh")
            txbNgayTao.Text = taikhoan("NgayTao")
            txbNgayCapNhat.Text = taikhoan("NgayCapNhat")
        End If
    End Sub
End Class