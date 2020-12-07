Public Class MainWindow
    Public username As String
    Public password As String
    Private Sub ChiNhanhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiNhanhToolStripMenuItem.Click
        Dim frmchinhanh As frmChiNhanh = New frmChiNhanh()
        frmchinhanh.MdiParent = Me
        frmchinhanh.Show()
    End Sub

    Private Sub MonAnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonAnToolStripMenuItem.Click
        Dim frmmonan As frmMonAn = New frmMonAn()
        frmmonan.MdiParent = Me
        frmmonan.Show()
    End Sub

    Private Sub DanhMucToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhMucToolStripMenuItem.Click
        Dim frmdanhmuc As frmDanhMuc = New frmDanhMuc()
        frmdanhmuc.MdiParent = Me
        frmdanhmuc.Show()
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Me.Text
        ToolStripStatusLabel2.Text = DateTime.Now.ToString()
        Dim frm As FrmThongKeNgay = New FrmThongKeNgay()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim frmmenu As frmMenu = New frmMenu()
        frmmenu.MdiParent = Me
        frmmenu.Show()
    End Sub
    Function login(username As String, password As String) As Boolean
        Dim str As String = "Select * from Taikhoan where TenDangNhap = '" + username + "' and Matkhau = '" + password + "'"
        Dim count As DataTable = DuLieu.DocDuLieu(str)
        If (count.Rows.Count > 0) Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        username = txbTenDangNhap.Text
        password = txbMatKhau.Text
        If (login(username, password) = True) Then
            pnlogin.Visible = False
        Else
            MessageBox.Show("Tài khoản hoặc mật khẩu khẩu không đúng! Vui lòng thử lại")
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub ThôngTinTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinTàiKhoảnToolStripMenuItem.Click
        Dim frmtaikhoan As frmTaiKhoan = New frmTaiKhoan()
        frmtaikhoan.MdiParent = Me
        frmtaikhoan.Show()
    End Sub

    Private Sub BanHangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BanHangToolStripMenuItem1.Click
        Dim frmbanhang As frmDanhSachDonHang = New frmDanhSachDonHang()
        frmbanhang.MdiParent = Me
        frmbanhang.WindowState = FormWindowState.Maximized
        frmbanhang.Show()
    End Sub

    Private Sub KhuyenMaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhuyenMaiToolStripMenuItem.Click
        Dim frm As FrmKhuyenMai = New FrmKhuyenMai()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub DangXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DangXuatToolStripMenuItem.Click
        pnlogin.Visible = True

        txbMatKhau.Text = ""
        txbTenDangNhap.Text = ""
    End Sub

    Private Sub ThongKeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongKeToolStripMenuItem.Click
        Dim frm As frmThongKe = New frmThongKe()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ThongkeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThongkeToolStripMenuItem1.Click
        Dim frm As FrmThongKeNgay = New FrmThongKeNgay()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub


End Class
