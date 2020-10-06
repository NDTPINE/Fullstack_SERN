<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BanhangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiNhanhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonAnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMucToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTinTaiKhoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinTàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐổiMậtKhẩuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýTàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbTenDangNhap = New System.Windows.Forms.TextBox()
        Me.txbMatKhau = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.pnlogin = New System.Windows.Forms.Panel()
        Me.BanHangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanhangToolStripMenuItem, Me.QuanlyToolStripMenuItem, Me.ThongTinTaiKhoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BanhangToolStripMenuItem
        '
        Me.BanhangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanHangToolStripMenuItem1})
        Me.BanhangToolStripMenuItem.Name = "BanhangToolStripMenuItem"
        Me.BanhangToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.BanhangToolStripMenuItem.Text = "Bán hàng"
        '
        'QuanlyToolStripMenuItem
        '
        Me.QuanlyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChiNhanhToolStripMenuItem, Me.MonAnToolStripMenuItem, Me.DanhMucToolStripMenuItem, Me.MenuToolStripMenuItem})
        Me.QuanlyToolStripMenuItem.Name = "QuanlyToolStripMenuItem"
        Me.QuanlyToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuanlyToolStripMenuItem.Text = "Quản lý"
        '
        'ChiNhanhToolStripMenuItem
        '
        Me.ChiNhanhToolStripMenuItem.Image = CType(resources.GetObject("ChiNhanhToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChiNhanhToolStripMenuItem.Name = "ChiNhanhToolStripMenuItem"
        Me.ChiNhanhToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q"
        Me.ChiNhanhToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ChiNhanhToolStripMenuItem.Text = "Chi Nhánh"
        '
        'MonAnToolStripMenuItem
        '
        Me.MonAnToolStripMenuItem.Image = Global.QLQuanAn.My.Resources.Resources.StarFishPorcelaine_Mac_Archigraphs_512x512
        Me.MonAnToolStripMenuItem.Name = "MonAnToolStripMenuItem"
        Me.MonAnToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MonAnToolStripMenuItem.Text = "Món Ăn"
        '
        'DanhMucToolStripMenuItem
        '
        Me.DanhMucToolStripMenuItem.Image = Global.QLQuanAn.My.Resources.Resources.BullPorcelaine_Mac_Archigraphs_512x512
        Me.DanhMucToolStripMenuItem.Name = "DanhMucToolStripMenuItem"
        Me.DanhMucToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DanhMucToolStripMenuItem.Text = "Danh Mục"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Image = Global.QLQuanAn.My.Resources.Resources.CowBrownPorcelaine_Mac_Archigraphs_512x512
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ThongTinTaiKhoanToolStripMenuItem
        '
        Me.ThongTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinTàiKhoảnToolStripMenuItem, Me.ĐổiMậtKhẩuToolStripMenuItem, Me.QuảnLýTàiKhoảnToolStripMenuItem})
        Me.ThongTinTaiKhoanToolStripMenuItem.Name = "ThongTinTaiKhoanToolStripMenuItem"
        Me.ThongTinTaiKhoanToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ThongTinTaiKhoanToolStripMenuItem.Text = "Tài khoản"
        '
        'ThôngTinTàiKhoảnToolStripMenuItem
        '
        Me.ThôngTinTàiKhoảnToolStripMenuItem.Name = "ThôngTinTàiKhoảnToolStripMenuItem"
        Me.ThôngTinTàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ThôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản"
        '
        'ĐổiMậtKhẩuToolStripMenuItem
        '
        Me.ĐổiMậtKhẩuToolStripMenuItem.Name = "ĐổiMậtKhẩuToolStripMenuItem"
        Me.ĐổiMậtKhẩuToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ĐổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu"
        '
        'QuảnLýTàiKhoảnToolStripMenuItem
        '
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Name = "QuảnLýTàiKhoảnToolStripMenuItem"
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(272, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Tên đăng nhập:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mật khẩu:"
        '
        'txbTenDangNhap
        '
        Me.txbTenDangNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbTenDangNhap.Location = New System.Drawing.Point(362, 144)
        Me.txbTenDangNhap.Name = "txbTenDangNhap"
        Me.txbTenDangNhap.Size = New System.Drawing.Size(166, 20)
        Me.txbTenDangNhap.TabIndex = 1
        '
        'txbMatKhau
        '
        Me.txbMatKhau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbMatKhau.Location = New System.Drawing.Point(362, 181)
        Me.txbMatKhau.Name = "txbMatKhau"
        Me.txbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbMatKhau.Size = New System.Drawing.Size(166, 20)
        Me.txbMatKhau.TabIndex = 2
        Me.txbMatKhau.UseSystemPasswordChar = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDangNhap.Location = New System.Drawing.Point(311, 227)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(79, 11)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Location = New System.Drawing.Point(413, 227)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(79, 11)
        Me.btnThoat.TabIndex = 22
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'pnlogin
        '
        Me.pnlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlogin.Controls.Add(Me.btnThoat)
        Me.pnlogin.Controls.Add(Me.btnDangNhap)
        Me.pnlogin.Controls.Add(Me.txbMatKhau)
        Me.pnlogin.Controls.Add(Me.txbTenDangNhap)
        Me.pnlogin.Controls.Add(Me.Label2)
        Me.pnlogin.Controls.Add(Me.Label1)
        Me.pnlogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlogin.Location = New System.Drawing.Point(-1, 27)
        Me.pnlogin.Name = "pnlogin"
        Me.pnlogin.Size = New System.Drawing.Size(800, 398)
        Me.pnlogin.TabIndex = 5
        '
        'BanHangToolStripMenuItem1
        '
        Me.BanHangToolStripMenuItem1.Name = "BanHangToolStripMenuItem1"
        Me.BanHangToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.BanHangToolStripMenuItem1.Text = "Bán Hàng"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlogin)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Quán Ăn"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlogin.ResumeLayout(False)
        Me.pnlogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BanhangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuanlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiNhanhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonAnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhMucToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThongTinTaiKhoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbTenDangNhap As TextBox
    Friend WithEvents txbMatKhau As TextBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents pnlogin As Panel
    Friend WithEvents ThôngTinTàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐổiMậtKhẩuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýTàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BanHangToolStripMenuItem1 As ToolStripMenuItem
End Class
