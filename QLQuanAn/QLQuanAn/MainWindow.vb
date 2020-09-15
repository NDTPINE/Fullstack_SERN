Public Class MainWindow
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

    End Sub
End Class
