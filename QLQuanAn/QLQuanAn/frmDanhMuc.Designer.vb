<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDanhMuc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhMuc))
        Me.dtgvDanhMuc = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.dtgvKhoiphuc = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txbNgayCapNhatDanhMuc = New System.Windows.Forms.TextBox()
        Me.txbNgayTaoDanhMuc = New System.Windows.Forms.TextBox()
        Me.txbTenDanhMuc = New System.Windows.Forms.TextBox()
        Me.txbIdDanhMuc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKhoiPhucChiNhanh = New System.Windows.Forms.Button()
        CType(Me.dtgvDanhMuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvKhoiphuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvDanhMuc
        '
        Me.dtgvDanhMuc.AllowDrop = True
        Me.dtgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvDanhMuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvDanhMuc.Location = New System.Drawing.Point(0, 0)
        Me.dtgvDanhMuc.Name = "dtgvDanhMuc"
        Me.dtgvDanhMuc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtgvDanhMuc.Size = New System.Drawing.Size(486, 450)
        Me.dtgvDanhMuc.TabIndex = 0
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(3, 236)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnKhoiPhucChiNhanh)
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.btnTimKiem)
        Me.Panel1.Controls.Add(Me.dtgvKhoiphuc)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Controls.Add(Me.txbNgayCapNhatDanhMuc)
        Me.Panel1.Controls.Add(Me.txbNgayTaoDanhMuc)
        Me.Panel1.Controls.Add(Me.txbTenDanhMuc)
        Me.Panel1.Controls.Add(Me.txbIdDanhMuc)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(486, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 450)
        Me.Panel1.TabIndex = 18
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(234, 236)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btnTimKiem.TabIndex = 24
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'dtgvKhoiphuc
        '
        Me.dtgvKhoiphuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvKhoiphuc.Location = New System.Drawing.Point(5, 265)
        Me.dtgvKhoiphuc.Name = "dtgvKhoiphuc"
        Me.dtgvKhoiphuc.Size = New System.Drawing.Size(305, 149)
        Me.dtgvKhoiphuc.TabIndex = 30
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(157, 236)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 23
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(80, 236)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 21
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'txbNgayCapNhatDanhMuc
        '
        Me.txbNgayCapNhatDanhMuc.Location = New System.Drawing.Point(129, 182)
        Me.txbNgayCapNhatDanhMuc.Name = "txbNgayCapNhatDanhMuc"
        Me.txbNgayCapNhatDanhMuc.ReadOnly = True
        Me.txbNgayCapNhatDanhMuc.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayCapNhatDanhMuc.TabIndex = 29
        '
        'txbNgayTaoDanhMuc
        '
        Me.txbNgayTaoDanhMuc.Location = New System.Drawing.Point(129, 145)
        Me.txbNgayTaoDanhMuc.Name = "txbNgayTaoDanhMuc"
        Me.txbNgayTaoDanhMuc.ReadOnly = True
        Me.txbNgayTaoDanhMuc.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayTaoDanhMuc.TabIndex = 28
        '
        'txbTenDanhMuc
        '
        Me.txbTenDanhMuc.Location = New System.Drawing.Point(129, 108)
        Me.txbTenDanhMuc.Name = "txbTenDanhMuc"
        Me.txbTenDanhMuc.Size = New System.Drawing.Size(172, 20)
        Me.txbTenDanhMuc.TabIndex = 18
        '
        'txbIdDanhMuc
        '
        Me.txbIdDanhMuc.Location = New System.Drawing.Point(129, 71)
        Me.txbIdDanhMuc.Name = "txbIdDanhMuc"
        Me.txbIdDanhMuc.ReadOnly = True
        Me.txbIdDanhMuc.Size = New System.Drawing.Size(172, 20)
        Me.txbIdDanhMuc.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Ngày tạo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Ngày cập nhật"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tên danh mục"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Thông tin danh mục"
        '
        'btnKhoiPhucChiNhanh
        '
        Me.btnKhoiPhucChiNhanh.Location = New System.Drawing.Point(129, 420)
        Me.btnKhoiPhucChiNhanh.Name = "btnKhoiPhucChiNhanh"
        Me.btnKhoiPhucChiNhanh.Size = New System.Drawing.Size(75, 23)
        Me.btnKhoiPhucChiNhanh.TabIndex = 31
        Me.btnKhoiPhucChiNhanh.Text = "Khôi phục"
        Me.btnKhoiPhucChiNhanh.UseVisualStyleBackColor = True
        '
        'frmDanhMuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtgvDanhMuc)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDanhMuc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý danh mục"
        CType(Me.dtgvDanhMuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgvKhoiphuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgvDanhMuc As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKhoiPhucChiNhanh As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents dtgvKhoiphuc As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txbNgayCapNhatDanhMuc As TextBox
    Friend WithEvents txbNgayTaoDanhMuc As TextBox
    Friend WithEvents txbTenDanhMuc As TextBox
    Friend WithEvents txbIdDanhMuc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
