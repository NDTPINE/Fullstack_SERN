<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKhuyenMai
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
        Me.nmSoTienToiThieu = New System.Windows.Forms.NumericUpDown()
        Me.nmSoTienToiDa = New System.Windows.Forms.NumericUpDown()
        Me.nmPhanTram = New System.Windows.Forms.NumericUpDown()
        Me.dtpNgayKetThuc = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayBatDau = New System.Windows.Forms.DateTimePicker()
        Me.nmGioKetThuc = New System.Windows.Forms.NumericUpDown()
        Me.nmGioBatDau = New System.Windows.Forms.NumericUpDown()
        Me.cbChiNhanh = New System.Windows.Forms.ComboBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txbMaKhuyenMai = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgvKhuyenMai = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.nmSoTienToiThieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmSoTienToiDa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmPhanTram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmGioKetThuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmGioBatDau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvKhuyenMai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbresult)
        Me.Panel1.Controls.Add(Me.nmSoTienToiThieu)
        Me.Panel1.Controls.Add(Me.nmSoTienToiDa)
        Me.Panel1.Controls.Add(Me.nmPhanTram)
        Me.Panel1.Controls.Add(Me.dtpNgayKetThuc)
        Me.Panel1.Controls.Add(Me.dtpNgayBatDau)
        Me.Panel1.Controls.Add(Me.nmGioKetThuc)
        Me.Panel1.Controls.Add(Me.nmGioBatDau)
        Me.Panel1.Controls.Add(Me.cbChiNhanh)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txbMaKhuyenMai)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(556, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 450)
        Me.Panel1.TabIndex = 0
        '
        'lbresult
        '
        Me.lbresult.AutoSize = True
        Me.lbresult.Location = New System.Drawing.Point(49, 399)
        Me.lbresult.Name = "lbresult"
        Me.lbresult.Size = New System.Drawing.Size(0, 13)
        Me.lbresult.TabIndex = 33
        '
        'nmSoTienToiThieu
        '
        Me.nmSoTienToiThieu.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nmSoTienToiThieu.Location = New System.Drawing.Point(111, 303)
        Me.nmSoTienToiThieu.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmSoTienToiThieu.Name = "nmSoTienToiThieu"
        Me.nmSoTienToiThieu.Size = New System.Drawing.Size(127, 20)
        Me.nmSoTienToiThieu.TabIndex = 9
        Me.nmSoTienToiThieu.ThousandsSeparator = True
        '
        'nmSoTienToiDa
        '
        Me.nmSoTienToiDa.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nmSoTienToiDa.Location = New System.Drawing.Point(111, 277)
        Me.nmSoTienToiDa.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmSoTienToiDa.Name = "nmSoTienToiDa"
        Me.nmSoTienToiDa.Size = New System.Drawing.Size(127, 20)
        Me.nmSoTienToiDa.TabIndex = 8
        Me.nmSoTienToiDa.ThousandsSeparator = True
        '
        'nmPhanTram
        '
        Me.nmPhanTram.Location = New System.Drawing.Point(111, 242)
        Me.nmPhanTram.Name = "nmPhanTram"
        Me.nmPhanTram.Size = New System.Drawing.Size(127, 20)
        Me.nmPhanTram.TabIndex = 7
        Me.nmPhanTram.ThousandsSeparator = True
        '
        'dtpNgayKetThuc
        '
        Me.dtpNgayKetThuc.CustomFormat = "yyyy/mm/dd"
        Me.dtpNgayKetThuc.Location = New System.Drawing.Point(111, 155)
        Me.dtpNgayKetThuc.Name = "dtpNgayKetThuc"
        Me.dtpNgayKetThuc.Size = New System.Drawing.Size(130, 20)
        Me.dtpNgayKetThuc.TabIndex = 4
        '
        'dtpNgayBatDau
        '
        Me.dtpNgayBatDau.CustomFormat = "yyyy/mm/dd"
        Me.dtpNgayBatDau.Location = New System.Drawing.Point(111, 124)
        Me.dtpNgayBatDau.Name = "dtpNgayBatDau"
        Me.dtpNgayBatDau.Size = New System.Drawing.Size(130, 20)
        Me.dtpNgayBatDau.TabIndex = 3
        '
        'nmGioKetThuc
        '
        Me.nmGioKetThuc.Location = New System.Drawing.Point(111, 212)
        Me.nmGioKetThuc.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nmGioKetThuc.Name = "nmGioKetThuc"
        Me.nmGioKetThuc.Size = New System.Drawing.Size(127, 20)
        Me.nmGioKetThuc.TabIndex = 6
        '
        'nmGioBatDau
        '
        Me.nmGioBatDau.Location = New System.Drawing.Point(112, 186)
        Me.nmGioBatDau.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nmGioBatDau.Name = "nmGioBatDau"
        Me.nmGioBatDau.Size = New System.Drawing.Size(127, 20)
        Me.nmGioBatDau.TabIndex = 5
        '
        'cbChiNhanh
        '
        Me.cbChiNhanh.FormattingEnabled = True
        Me.cbChiNhanh.Location = New System.Drawing.Point(112, 93)
        Me.cbChiNhanh.Name = "cbChiNhanh"
        Me.cbChiNhanh.Size = New System.Drawing.Size(127, 21)
        Me.cbChiNhanh.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(85, 343)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Sửa"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(166, 343)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(4, 343)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txbMaKhuyenMai
        '
        Me.txbMaKhuyenMai.Location = New System.Drawing.Point(112, 61)
        Me.txbMaKhuyenMai.Name = "txbMaKhuyenMai"
        Me.txbMaKhuyenMai.Size = New System.Drawing.Size(127, 20)
        Me.txbMaKhuyenMai.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Chi Nhánh áp dụng"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Số tiền tối thiểu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Số tiền tối đa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Phần trăm"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Giờ kết thúc"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ngày kết thúc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ngày bắt đầu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Giờ bắt đầu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(49, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quản lý khuyến mãi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã khuyến mãi"
        '
        'dtgvKhuyenMai
        '
        Me.dtgvKhuyenMai.AllowUserToAddRows = False
        Me.dtgvKhuyenMai.AllowUserToDeleteRows = False
        Me.dtgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvKhuyenMai.Location = New System.Drawing.Point(0, 52)
        Me.dtgvKhuyenMai.Name = "dtgvKhuyenMai"
        Me.dtgvKhuyenMai.Size = New System.Drawing.Size(556, 398)
        Me.dtgvKhuyenMai.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txbSearch)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 52)
        Me.Panel2.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(304, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txbSearch
        '
        Me.txbSearch.Location = New System.Drawing.Point(108, 13)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(167, 20)
        Me.txbSearch.TabIndex = 13
        Me.txbSearch.Text = "Mã khuyến mãi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search: "
        '
        'FrmKhuyenMai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtgvKhuyenMai)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmKhuyenMai"
        Me.Text = "FrmKhuyenMai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nmSoTienToiThieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmSoTienToiDa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmPhanTram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmGioKetThuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmGioBatDau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvKhuyenMai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtgvKhuyenMai As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txbMaKhuyenMai As TextBox
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNgayKetThuc As DateTimePicker
    Friend WithEvents dtpNgayBatDau As DateTimePicker
    Friend WithEvents nmGioKetThuc As NumericUpDown
    Friend WithEvents nmGioBatDau As NumericUpDown
    Friend WithEvents nmSoTienToiThieu As NumericUpDown
    Friend WithEvents nmSoTienToiDa As NumericUpDown
    Friend WithEvents nmPhanTram As NumericUpDown
    Friend WithEvents lbresult As Label
End Class
