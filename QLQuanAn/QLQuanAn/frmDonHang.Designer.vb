﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txbTrangThai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnXoaTatCa = New System.Windows.Forms.Button()
        Me.lbChiNhanh = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dtgvDSMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvChiTietDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvDSMonAn
        '
        Me.dtgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvDSMonAn.Location = New System.Drawing.Point(12, 40)
        Me.dtgvDSMonAn.Name = "dtgvDSMonAn"
        Me.dtgvDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvDSMonAn.Size = New System.Drawing.Size(248, 348)
        Me.dtgvDSMonAn.TabIndex = 0
        '
        'dtgvChiTietDonHang
        '
        Me.dtgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvChiTietDonHang.Location = New System.Drawing.Point(378, 95)
        Me.dtgvChiTietDonHang.Name = "dtgvChiTietDonHang"
        Me.dtgvChiTietDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvChiTietDonHang.Size = New System.Drawing.Size(410, 269)
        Me.dtgvChiTietDonHang.TabIndex = 1
        '
        'btnThemMonAn
        '
        Me.btnThemMonAn.Location = New System.Drawing.Point(281, 148)
        Me.btnThemMonAn.Name = "btnThemMonAn"
        Me.btnThemMonAn.Size = New System.Drawing.Size(75, 23)
        Me.btnThemMonAn.TabIndex = 4
        Me.btnThemMonAn.Text = ">"
        Me.btnThemMonAn.UseVisualStyleBackColor = True
        '
        'btnXoaMonAn
        '
        Me.btnXoaMonAn.Location = New System.Drawing.Point(281, 177)
        Me.btnXoaMonAn.Name = "btnXoaMonAn"
        Me.btnXoaMonAn.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaMonAn.TabIndex = 5
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
        Me.txbTimKiem.TabIndex = 7
        '
        'Tên
        '
        Me.Tên.AutoSize = True
        Me.Tên.Location = New System.Drawing.Point(373, 11)
        Me.Tên.Name = "Tên"
        Me.Tên.Size = New System.Drawing.Size(26, 13)
        Me.Tên.TabIndex = 8
        Me.Tên.Text = "Tên"
        '
        'txbTen
        '
        Me.txbTen.Location = New System.Drawing.Point(433, 4)
        Me.txbTen.Name = "txbTen"
        Me.txbTen.Size = New System.Drawing.Size(200, 20)
        Me.txbTen.TabIndex = 9
        Me.txbTen.Text = " "
        '
        'dtpNgay
        '
        Me.dtpNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay.Location = New System.Drawing.Point(433, 35)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgay.TabIndex = 10
        Me.dtpNgay.Value = New Date(2020, 10, 6, 15, 22, 36, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ngày"
        '
        'txbDienThoai
        '
        Me.txbDienThoai.Location = New System.Drawing.Point(695, 4)
        Me.txbDienThoai.Name = "txbDienThoai"
        Me.txbDienThoai.Size = New System.Drawing.Size(100, 20)
        Me.txbDienThoai.TabIndex = 13
        Me.txbDienThoai.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(642, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Điện thoại"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(185, 9)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btnTimKiem.TabIndex = 14
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txbPhuPhi
        '
        Me.txbPhuPhi.Location = New System.Drawing.Point(436, 374)
        Me.txbPhuPhi.Name = "txbPhuPhi"
        Me.txbPhuPhi.Size = New System.Drawing.Size(114, 20)
        Me.txbPhuPhi.TabIndex = 15
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
        Me.Label5.Location = New System.Drawing.Point(598, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Giảm giá"
        '
        'txbGiamGia
        '
        Me.txbGiamGia.Location = New System.Drawing.Point(674, 396)
        Me.txbGiamGia.Name = "txbGiamGia"
        Me.txbGiamGia.Size = New System.Drawing.Size(114, 20)
        Me.txbGiamGia.TabIndex = 19
        Me.txbGiamGia.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(613, 425)
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
        Me.btnTaoDonHang.Location = New System.Drawing.Point(378, 415)
        Me.btnTaoDonHang.Name = "btnTaoDonHang"
        Me.btnTaoDonHang.Size = New System.Drawing.Size(75, 23)
        Me.btnTaoDonHang.TabIndex = 23
        Me.btnTaoDonHang.Text = "Tạo Đơn"
        Me.btnTaoDonHang.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(510, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txbTrangThai
        '
        Me.txbTrangThai.Location = New System.Drawing.Point(433, 66)
        Me.txbTrangThai.Name = "txbTrangThai"
        Me.txbTrangThai.Size = New System.Drawing.Size(200, 20)
        Me.txbTrangThai.TabIndex = 26
        Me.txbTrangThai.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Trạng thái"
        '
        'btnXoaTatCa
        '
        Me.btnXoaTatCa.Location = New System.Drawing.Point(281, 206)
        Me.btnXoaTatCa.Name = "btnXoaTatCa"
        Me.btnXoaTatCa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaTatCa.TabIndex = 27
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
        'frmDonHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbChiNhanh)
        Me.Controls.Add(Me.btnXoaTatCa)
        Me.Controls.Add(Me.txbTrangThai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpNgay)
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
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents Label2 As Label
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
    Friend WithEvents Button2 As Button
    Friend WithEvents txbTrangThai As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnXoaTatCa As Button
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents Label8 As Label
End Class
