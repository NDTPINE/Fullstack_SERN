<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BanhangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiNhanhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonAnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMucToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTinTaiKhoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        Me.BanhangToolStripMenuItem.Name = "BanhangToolStripMenuItem"
        Me.BanhangToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.BanhangToolStripMenuItem.Text = "Bán hàng"
        '
        'QuanlyToolStripMenuItem
        '
        Me.QuanlyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChiNhanhToolStripMenuItem, Me.MonAnToolStripMenuItem, Me.DanhMucToolStripMenuItem})
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
        'ThongTinTaiKhoanToolStripMenuItem
        '
        Me.ThongTinTaiKhoanToolStripMenuItem.Name = "ThongTinTaiKhoanToolStripMenuItem"
        Me.ThongTinTaiKhoanToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ThongTinTaiKhoanToolStripMenuItem.Text = "Tài khoản"
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
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Quán Ăn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
End Class
