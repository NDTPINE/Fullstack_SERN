<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiNhanh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiNhanh))
        Me.dtgvChiNhanh = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chbXoa = New System.Windows.Forms.CheckBox()
        Me.lbresult = New System.Windows.Forms.Label()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnXoaChiNhanh = New System.Windows.Forms.Button()
        Me.btnSuaChiNhanh = New System.Windows.Forms.Button()
        Me.btnThemChiNhanh = New System.Windows.Forms.Button()
        Me.txbNgayCapNhatChiNhanh = New System.Windows.Forms.TextBox()
        Me.txbNgayTaoChiNhanh = New System.Windows.Forms.TextBox()
        Me.txbDiaChiChiNhanh = New System.Windows.Forms.TextBox()
        Me.txbTenChiNhanh = New System.Windows.Forms.TextBox()
        Me.txbIdChiNhanh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgvChiNhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgvChiNhanh
        '
        Me.dtgvChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvChiNhanh.Location = New System.Drawing.Point(0, 0)
        Me.dtgvChiNhanh.Name = "dtgvChiNhanh"
        Me.dtgvChiNhanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvChiNhanh.Size = New System.Drawing.Size(800, 450)
        Me.dtgvChiNhanh.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chbXoa)
        Me.Panel1.Controls.Add(Me.lbresult)
        Me.Panel1.Controls.Add(Me.txbSearch)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnXoaChiNhanh)
        Me.Panel1.Controls.Add(Me.btnSuaChiNhanh)
        Me.Panel1.Controls.Add(Me.btnThemChiNhanh)
        Me.Panel1.Controls.Add(Me.txbNgayCapNhatChiNhanh)
        Me.Panel1.Controls.Add(Me.txbNgayTaoChiNhanh)
        Me.Panel1.Controls.Add(Me.txbDiaChiChiNhanh)
        Me.Panel1.Controls.Add(Me.txbTenChiNhanh)
        Me.Panel1.Controls.Add(Me.txbIdChiNhanh)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(495, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 450)
        Me.Panel1.TabIndex = 1
        '
        'chbXoa
        '
        Me.chbXoa.AutoSize = True
        Me.chbXoa.Location = New System.Drawing.Point(233, 308)
        Me.chbXoa.Name = "chbXoa"
        Me.chbXoa.Size = New System.Drawing.Size(62, 17)
        Me.chbXoa.TabIndex = 59
        Me.chbXoa.Text = "Đã Xóa"
        Me.chbXoa.UseVisualStyleBackColor = True
        '
        'lbresult
        '
        Me.lbresult.AutoSize = True
        Me.lbresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbresult.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbresult.Location = New System.Drawing.Point(26, 383)
        Me.lbresult.Name = "lbresult"
        Me.lbresult.Size = New System.Drawing.Size(0, 17)
        Me.lbresult.TabIndex = 58
        Me.lbresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbSearch
        '
        Me.txbSearch.Location = New System.Drawing.Point(58, 308)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(167, 20)
        Me.txbSearch.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(120, 349)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 23)
        Me.btnSearch.TabIndex = 55
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnXoaChiNhanh
        '
        Me.btnXoaChiNhanh.Location = New System.Drawing.Point(229, 265)
        Me.btnXoaChiNhanh.Name = "btnXoaChiNhanh"
        Me.btnXoaChiNhanh.Size = New System.Drawing.Size(69, 23)
        Me.btnXoaChiNhanh.TabIndex = 27
        Me.btnXoaChiNhanh.Text = "Xoá"
        Me.btnXoaChiNhanh.UseVisualStyleBackColor = True
        '
        'btnSuaChiNhanh
        '
        Me.btnSuaChiNhanh.Location = New System.Drawing.Point(118, 265)
        Me.btnSuaChiNhanh.Name = "btnSuaChiNhanh"
        Me.btnSuaChiNhanh.Size = New System.Drawing.Size(69, 23)
        Me.btnSuaChiNhanh.TabIndex = 24
        Me.btnSuaChiNhanh.Text = "Sửa"
        Me.btnSuaChiNhanh.UseVisualStyleBackColor = True
        '
        'btnThemChiNhanh
        '
        Me.btnThemChiNhanh.Location = New System.Drawing.Point(7, 265)
        Me.btnThemChiNhanh.Name = "btnThemChiNhanh"
        Me.btnThemChiNhanh.Size = New System.Drawing.Size(69, 23)
        Me.btnThemChiNhanh.TabIndex = 22
        Me.btnThemChiNhanh.Text = "Thêm"
        Me.btnThemChiNhanh.UseVisualStyleBackColor = True
        '
        'txbNgayCapNhatChiNhanh
        '
        Me.txbNgayCapNhatChiNhanh.Location = New System.Drawing.Point(126, 218)
        Me.txbNgayCapNhatChiNhanh.Name = "txbNgayCapNhatChiNhanh"
        Me.txbNgayCapNhatChiNhanh.ReadOnly = True
        Me.txbNgayCapNhatChiNhanh.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayCapNhatChiNhanh.TabIndex = 33
        '
        'txbNgayTaoChiNhanh
        '
        Me.txbNgayTaoChiNhanh.Location = New System.Drawing.Point(126, 176)
        Me.txbNgayTaoChiNhanh.Name = "txbNgayTaoChiNhanh"
        Me.txbNgayTaoChiNhanh.ReadOnly = True
        Me.txbNgayTaoChiNhanh.Size = New System.Drawing.Size(172, 20)
        Me.txbNgayTaoChiNhanh.TabIndex = 32
        '
        'txbDiaChiChiNhanh
        '
        Me.txbDiaChiChiNhanh.Location = New System.Drawing.Point(126, 134)
        Me.txbDiaChiChiNhanh.Name = "txbDiaChiChiNhanh"
        Me.txbDiaChiChiNhanh.Size = New System.Drawing.Size(172, 20)
        Me.txbDiaChiChiNhanh.TabIndex = 21
        '
        'txbTenChiNhanh
        '
        Me.txbTenChiNhanh.Location = New System.Drawing.Point(126, 92)
        Me.txbTenChiNhanh.Name = "txbTenChiNhanh"
        Me.txbTenChiNhanh.Size = New System.Drawing.Size(172, 20)
        Me.txbTenChiNhanh.TabIndex = 19
        '
        'txbIdChiNhanh
        '
        Me.txbIdChiNhanh.Location = New System.Drawing.Point(126, 50)
        Me.txbIdChiNhanh.Name = "txbIdChiNhanh"
        Me.txbIdChiNhanh.ReadOnly = True
        Me.txbIdChiNhanh.Size = New System.Drawing.Size(172, 20)
        Me.txbIdChiNhanh.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Ngày tạo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Ngày cập nhật"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Thông tin chi nhánh"
        '
        'frmChiNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgvChiNhanh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChiNhanh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý chi nhánh"
        CType(Me.dtgvChiNhanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgvChiNhanh As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnXoaChiNhanh As Button
    Friend WithEvents btnSuaChiNhanh As Button
    Friend WithEvents btnThemChiNhanh As Button
    Friend WithEvents txbNgayCapNhatChiNhanh As TextBox
    Friend WithEvents txbNgayTaoChiNhanh As TextBox
    Friend WithEvents txbDiaChiChiNhanh As TextBox
    Friend WithEvents txbTenChiNhanh As TextBox
    Friend WithEvents txbIdChiNhanh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chbXoa As CheckBox
    Friend WithEvents lbresult As Label
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSearch As Button
End Class
