<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaiKhoan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbresult = New System.Windows.Forms.Label()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txbActive = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTypeUser = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txbNgayCapNhat = New System.Windows.Forms.TextBox()
        Me.txbNgayTao = New System.Windows.Forms.TextBox()
        Me.txbPass = New System.Windows.Forms.TextBox()
        Me.txbUser = New System.Windows.Forms.TextBox()
        Me.txbIdTaikhoan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgvTaiKhoan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbresult)
        Me.Panel1.Controls.Add(Me.txbSearch)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dtpNgaySinh)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txbActive)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbTypeUser)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txbName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnTimKiem)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.txbNgayCapNhat)
        Me.Panel1.Controls.Add(Me.txbNgayTao)
        Me.Panel1.Controls.Add(Me.txbPass)
        Me.Panel1.Controls.Add(Me.txbUser)
        Me.Panel1.Controls.Add(Me.txbIdTaikhoan)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(487, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 450)
        Me.Panel1.TabIndex = 3
        '
        'lbresult
        '
        Me.lbresult.AutoSize = True
        Me.lbresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbresult.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbresult.Location = New System.Drawing.Point(30, 392)
        Me.lbresult.Name = "lbresult"
        Me.lbresult.Size = New System.Drawing.Size(0, 17)
        Me.lbresult.TabIndex = 49
        Me.lbresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbSearch
        '
        Me.txbSearch.Location = New System.Drawing.Point(59, 348)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(167, 20)
        Me.txbSearch.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 351)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Search"
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(124, 210)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(171, 20)
        Me.dtpNgaySinh.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Ngày sinh"
        '
        'txbActive
        '
        Me.txbActive.Location = New System.Drawing.Point(124, 181)
        Me.txbActive.Name = "txbActive"
        Me.txbActive.Size = New System.Drawing.Size(172, 20)
        Me.txbActive.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Hoạt động"
        '
        'cbTypeUser
        '
        Me.cbTypeUser.FormattingEnabled = True
        Me.cbTypeUser.Location = New System.Drawing.Point(124, 124)
        Me.cbTypeUser.Name = "cbTypeUser"
        Me.cbTypeUser.Size = New System.Drawing.Size(172, 21)
        Me.cbTypeUser.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Loại tài khoản"
        '
        'txbName
        '
        Me.txbName.Location = New System.Drawing.Point(124, 153)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(172, 20)
        Me.txbName.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Họ tên"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(232, 348)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(72, 23)
        Me.btnTimKiem.TabIndex = 11
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(228, 302)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(72, 23)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(116, 302)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(72, 23)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(4, 302)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(72, 23)
        Me.btnThem.TabIndex = 7
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txbNgayCapNhat
        '
        Me.txbNgayCapNhat.Location = New System.Drawing.Point(124, 265)
        Me.txbNgayCapNhat.Name = "txbNgayCapNhat"
        Me.txbNgayCapNhat.ReadOnly = True
        Me.txbNgayCapNhat.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayCapNhat.TabIndex = 39
        '
        'txbNgayTao
        '
        Me.txbNgayTao.Location = New System.Drawing.Point(124, 237)
        Me.txbNgayTao.Name = "txbNgayTao"
        Me.txbNgayTao.ReadOnly = True
        Me.txbNgayTao.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayTao.TabIndex = 38
        '
        'txbPass
        '
        Me.txbPass.Location = New System.Drawing.Point(124, 96)
        Me.txbPass.Name = "txbPass"
        Me.txbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPass.Size = New System.Drawing.Size(172, 20)
        Me.txbPass.TabIndex = 2
        Me.txbPass.UseSystemPasswordChar = True
        '
        'txbUser
        '
        Me.txbUser.Location = New System.Drawing.Point(124, 68)
        Me.txbUser.Name = "txbUser"
        Me.txbUser.Size = New System.Drawing.Size(172, 20)
        Me.txbUser.TabIndex = 1
        '
        'txbIdTaikhoan
        '
        Me.txbIdTaikhoan.Location = New System.Drawing.Point(124, 40)
        Me.txbIdTaikhoan.Name = "txbIdTaikhoan"
        Me.txbIdTaikhoan.ReadOnly = True
        Me.txbIdTaikhoan.Size = New System.Drawing.Size(172, 20)
        Me.txbIdTaikhoan.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Ngày tạo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Ngày cập nhật"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Tên đăng nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Thông tin tài khoản"
        '
        'dtgvTaiKhoan
        '
        Me.dtgvTaiKhoan.AllowDrop = True
        Me.dtgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgvTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvTaiKhoan.Location = New System.Drawing.Point(0, 0)
        Me.dtgvTaiKhoan.Name = "dtgvTaiKhoan"
        Me.dtgvTaiKhoan.Size = New System.Drawing.Size(800, 450)
        Me.dtgvTaiKhoan.TabIndex = 2
        '
        'frmTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgvTaiKhoan)
        Me.Name = "frmTaiKhoan"
        Me.Text = "frmTaiKhoan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgvTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txbName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents txbNgayCapNhat As TextBox
    Friend WithEvents txbNgayTao As TextBox
    Friend WithEvents txbPass As TextBox
    Friend WithEvents txbUser As TextBox
    Friend WithEvents txbIdTaikhoan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgvTaiKhoan As DataGridView
    Friend WithEvents txbActive As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTypeUser As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbresult As Label
End Class
