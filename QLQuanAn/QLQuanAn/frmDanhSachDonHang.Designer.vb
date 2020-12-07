<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachDonHang
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
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnDocTatCaDH = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbDSChiNhanh = New System.Windows.Forms.ComboBox()
        Me.dtgvDanhSachDonHang = New System.Windows.Forms.DataGridView()
        Me.btnHoanTat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvDanhSachDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnHuy)
        Me.Panel1.Controls.Add(Me.btnDocTatCaDH)
        Me.Panel1.Controls.Add(Me.btnCapNhat)
        Me.Panel1.Controls.Add(Me.btnXem)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.cbDSChiNhanh)
        Me.Panel1.Controls.Add(Me.dtgvDanhSachDonHang)
        Me.Panel1.Controls.Add(Me.btnHoanTat)
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 443)
        Me.Panel1.TabIndex = 0
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(705, 5)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 13
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnDocTatCaDH
        '
        Me.btnDocTatCaDH.Location = New System.Drawing.Point(279, 5)
        Me.btnDocTatCaDH.Name = "btnDocTatCaDH"
        Me.btnDocTatCaDH.Size = New System.Drawing.Size(75, 23)
        Me.btnDocTatCaDH.TabIndex = 12
        Me.btnDocTatCaDH.Text = "Tất cả DH"
        Me.btnDocTatCaDH.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(545, 5)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 11
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(465, 5)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 10
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 9
        '
        'cbDSChiNhanh
        '
        Me.cbDSChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDSChiNhanh.FormattingEnabled = True
        Me.cbDSChiNhanh.Location = New System.Drawing.Point(9, 7)
        Me.cbDSChiNhanh.Name = "cbDSChiNhanh"
        Me.cbDSChiNhanh.Size = New System.Drawing.Size(121, 21)
        Me.cbDSChiNhanh.TabIndex = 8
        '
        'dtgvDanhSachDonHang
        '
        Me.dtgvDanhSachDonHang.AllowUserToAddRows = False
        Me.dtgvDanhSachDonHang.AllowUserToDeleteRows = False
        Me.dtgvDanhSachDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvDanhSachDonHang.Location = New System.Drawing.Point(3, 35)
        Me.dtgvDanhSachDonHang.MultiSelect = False
        Me.dtgvDanhSachDonHang.Name = "dtgvDanhSachDonHang"
        Me.dtgvDanhSachDonHang.ReadOnly = True
        Me.dtgvDanhSachDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvDanhSachDonHang.Size = New System.Drawing.Size(789, 405)
        Me.dtgvDanhSachDonHang.TabIndex = 7
        '
        'btnHoanTat
        '
        Me.btnHoanTat.Location = New System.Drawing.Point(625, 5)
        Me.btnHoanTat.Name = "btnHoanTat"
        Me.btnHoanTat.Size = New System.Drawing.Size(75, 23)
        Me.btnHoanTat.TabIndex = 6
        Me.btnHoanTat.Text = "Hoàn Tất"
        Me.btnHoanTat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(385, 5)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmDanhSachDonHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDanhSachDonHang"
        Me.Text = "frmDanhSachDonHang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgvDanhSachDonHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtgvDanhSachDonHang As DataGridView
    Friend WithEvents btnHoanTat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents cbDSChiNhanh As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents btnDocTatCaDH As Button
    Friend WithEvents btnHuy As Button
End Class
