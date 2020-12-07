<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonHang
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
        Me.dtgvDSMonAn = New System.Windows.Forms.DataGridView()
        Me.dtgvChiTietDonHang = New System.Windows.Forms.DataGridView()
        Me.btnThemMonAn = New System.Windows.Forms.Button()
        Me.btnXoaMonAn = New System.Windows.Forms.Button()
        Me.nmSoLuong = New System.Windows.Forms.NumericUpDown()
        Me.txbTimKiem = New System.Windows.Forms.TextBox()
        Me.Tên = New System.Windows.Forms.Label()
        Me.txbTen = New System.Windows.Forms.TextBox()
        Me.txbDienThoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txbPhuPhi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbTongMonAn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbGiamGia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbTongTien = New System.Windows.Forms.TextBox()
        Me.btnTaoDonHang = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnXoaTatCa = New System.Windows.Forms.Button()
        Me.lbChiNhanh = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbGiamGiaMonAn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txbTongGiamGia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbKhuyenMai = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgvDSMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvChiTietDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvDSMonAn
        '
        Me.dtgvDSMonAn.AllowUserToAddRows = False
        Me.dtgvDSMonAn.AllowUserToDeleteRows = False
        Me.dtgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvDSMonAn.Location = New System.Drawing.Point(12, 40)
        Me.dtgvDSMonAn.MultiSelect = False
        Me.dtgvDSMonAn.Name = "dtgvDSMonAn"
        Me.dtgvDSMonAn.ReadOnly = True
        Me.dtgvDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvDSMonAn.Size = New System.Drawing.Size(248, 398)
        Me.dtgvDSMonAn.TabIndex = 0
        '
        'dtgvChiTietDonHang
        '
        Me.dtgvChiTietDonHang.AllowUserToAddRows = False
        Me.dtgvChiTietDonHang.AllowUserToDeleteRows = False
        Me.dtgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvChiTietDonHang.Location = New System.Drawing.Point(378, 83)
        Me.dtgvChiTietDonHang.MultiSelect = False
        Me.dtgvChiTietDonHang.Name = "dtgvChiTietDonHang"
        Me.dtgvChiTietDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvChiTietDonHang.Size = New System.Drawing.Size(410, 281)
        Me.dtgvChiTietDonHang.TabIndex = 1
        '
        'btnThemMonAn
        '
        Me.btnThemMonAn.Location = New System.Drawing.Point(281, 148)
        Me.btnThemMonAn.Name = "btnThemMonAn"
        Me.btnThemMonAn.Size = New System.Drawing.Size(75, 23)
        Me.btnThemMonAn.TabIndex = 5
        Me.btnThemMonAn.Text = ">"
        Me.btnThemMonAn.UseVisualStyleBackColor = True
        '
        'btnXoaMonAn
        '
        Me.btnXoaMonAn.Location = New System.Drawing.Point(281, 177)
        Me.btnXoaMonAn.Name = "btnXoaMonAn"
        Me.btnXoaMonAn.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaMonAn.TabIndex = 6
        Me.btnXoaMonAn.Text = "<"
        Me.btnXoaMonAn.UseVisualStyleBackColor = True
        '
        'nmSoLuong
        '
        Me.nmSoLuong.Location = New System.Drawing.Point(281, 119)
        Me.nmSoLuong.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nmSoLuong.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmSoLuong.Name = "nmSoLuong"
        Me.nmSoLuong.Size = New System.Drawing.Size(75, 20)
        Me.nmSoLuong.TabIndex = 6
        Me.nmSoLuong.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txbTimKiem
        '
        Me.txbTimKiem.Location = New System.Drawing.Point(12, 12)
        Me.txbTimKiem.Name = "txbTimKiem"
        Me.txbTimKiem.Size = New System.Drawing.Size(167, 20)
        Me.txbTimKiem.TabIndex = 12
        '
        'Tên
        '
        Me.Tên.AutoSize = True
        Me.Tên.Location = New System.Drawing.Point(430, 7)
        Me.Tên.Name = "Tên"
        Me.Tên.Size = New System.Drawing.Size(26, 13)
        Me.Tên.TabIndex = 8
        Me.Tên.Text = "Tên"
        '
        'txbTen
        '
        Me.txbTen.Location = New System.Drawing.Point(472, 4)
        Me.txbTen.Name = "txbTen"
        Me.txbTen.Size = New System.Drawing.Size(196, 20)
        Me.txbTen.TabIndex = 1
        Me.txbTen.Text = " "
        '
        'txbDienThoai
        '
        Me.txbDienThoai.Location = New System.Drawing.Point(472, 57)
        Me.txbDienThoai.Name = "txbDienThoai"
        Me.txbDienThoai.Size = New System.Drawing.Size(196, 20)
        Me.txbDienThoai.TabIndex = 3
        Me.txbDienThoai.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Điện thoại"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(185, 10)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btnTimKiem.TabIndex = 13
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txbPhuPhi
        '
        Me.txbPhuPhi.Location = New System.Drawing.Point(472, 370)
        Me.txbPhuPhi.Name = "txbPhuPhi"
        Me.txbPhuPhi.Size = New System.Drawing.Size(114, 20)
        Me.txbPhuPhi.TabIndex = 10
        Me.txbPhuPhi.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Phụ phí"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(598, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tổng món ăn"
        '
        'txbTongMonAn
        '
        Me.txbTongMonAn.Location = New System.Drawing.Point(674, 370)
        Me.txbTongMonAn.Name = "txbTongMonAn"
        Me.txbTongMonAn.ReadOnly = True
        Me.txbTongMonAn.Size = New System.Drawing.Size(114, 20)
        Me.txbTongMonAn.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(375, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Giảm giá hóa đơn"
        '
        'txbGiamGia
        '
        Me.txbGiamGia.Location = New System.Drawing.Point(472, 396)
        Me.txbGiamGia.Name = "txbGiamGia"
        Me.txbGiamGia.Size = New System.Drawing.Size(114, 20)
        Me.txbGiamGia.TabIndex = 11
        Me.txbGiamGia.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(598, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tổng tiền"
        '
        'txbTongTien
        '
        Me.txbTongTien.Location = New System.Drawing.Point(674, 422)
        Me.txbTongTien.Name = "txbTongTien"
        Me.txbTongTien.ReadOnly = True
        Me.txbTongTien.Size = New System.Drawing.Size(114, 20)
        Me.txbTongTien.TabIndex = 21
        '
        'btnTaoDonHang
        '
        Me.btnTaoDonHang.Location = New System.Drawing.Point(281, 285)
        Me.btnTaoDonHang.Name = "btnTaoDonHang"
        Me.btnTaoDonHang.Size = New System.Drawing.Size(75, 23)
        Me.btnTaoDonHang.TabIndex = 8
        Me.btnTaoDonHang.Text = "Tạo Đơn"
        Me.btnTaoDonHang.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(281, 341)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Hủy"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnXoaTatCa
        '
        Me.btnXoaTatCa.Location = New System.Drawing.Point(281, 206)
        Me.btnXoaTatCa.Name = "btnXoaTatCa"
        Me.btnXoaTatCa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaTatCa.TabIndex = 7
        Me.btnXoaTatCa.Text = "<<"
        Me.btnXoaTatCa.UseVisualStyleBackColor = True
        '
        'lbChiNhanh
        '
        Me.lbChiNhanh.AutoSize = True
        Me.lbChiNhanh.Location = New System.Drawing.Point(289, 57)
        Me.lbChiNhanh.Name = "lbChiNhanh"
        Me.lbChiNhanh.Size = New System.Drawing.Size(0, 13)
        Me.lbChiNhanh.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(289, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Chi nhánh"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(375, 429)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Giảm giá món ăn"
        '
        'txbGiamGiaMonAn
        '
        Me.txbGiamGiaMonAn.Location = New System.Drawing.Point(472, 422)
        Me.txbGiamGiaMonAn.Name = "txbGiamGiaMonAn"
        Me.txbGiamGiaMonAn.ReadOnly = True
        Me.txbGiamGiaMonAn.Size = New System.Drawing.Size(114, 20)
        Me.txbGiamGiaMonAn.TabIndex = 30
        Me.txbGiamGiaMonAn.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(598, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Tổng giảm giá"
        '
        'txbTongGiamGia
        '
        Me.txbTongGiamGia.Location = New System.Drawing.Point(674, 396)
        Me.txbTongGiamGia.Name = "txbTongGiamGia"
        Me.txbTongGiamGia.ReadOnly = True
        Me.txbTongGiamGia.Size = New System.Drawing.Size(114, 20)
        Me.txbTongGiamGia.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(394, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Khuyến mãi"
        '
        'cbKhuyenMai
        '
        Me.cbKhuyenMai.FormattingEnabled = True
        Me.cbKhuyenMai.Location = New System.Drawing.Point(472, 30)
        Me.cbKhuyenMai.Name = "cbKhuyenMai"
        Me.cbKhuyenMai.Size = New System.Drawing.Size(196, 21)
        Me.cbKhuyenMai.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Số lượng"
        '
        'frmDonHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbKhuyenMai)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txbTongGiamGia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txbGiamGiaMonAn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbChiNhanh)
        Me.Controls.Add(Me.btnXoaTatCa)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTaoDonHang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbTongTien)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbGiamGia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbTongMonAn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbPhuPhi)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txbDienThoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbTen)
        Me.Controls.Add(Me.Tên)
        Me.Controls.Add(Me.txbTimKiem)
        Me.Controls.Add(Me.nmSoLuong)
        Me.Controls.Add(Me.btnXoaMonAn)
        Me.Controls.Add(Me.btnThemMonAn)
        Me.Controls.Add(Me.dtgvChiTietDonHang)
        Me.Controls.Add(Me.dtgvDSMonAn)
        Me.Name = "frmDonHang"
        Me.Text = "frmDonHang"
        CType(Me.dtgvDSMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvChiTietDonHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmSoLuong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvDSMonAn As DataGridView
    Friend WithEvents dtgvChiTietDonHang As DataGridView
    Friend WithEvents btnThemMonAn As Button
    Friend WithEvents btnXoaMonAn As Button
    Friend WithEvents nmSoLuong As NumericUpDown
    Friend WithEvents txbTimKiem As TextBox
    Friend WithEvents Tên As Label
    Friend WithEvents txbTen As TextBox
    Friend WithEvents txbDienThoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txbPhuPhi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbTongMonAn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbGiamGia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbTongTien As TextBox
    Friend WithEvents btnTaoDonHang As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnXoaTatCa As Button
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txbGiamGiaMonAn As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txbTongGiamGia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbKhuyenMai As ComboBox
    Friend WithEvents Label2 As Label
End Class
