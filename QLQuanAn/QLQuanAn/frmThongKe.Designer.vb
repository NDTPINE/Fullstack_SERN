<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKe))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgvThongKe = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.chbThanhCong = New System.Windows.Forms.CheckBox()
        Me.cbHuy = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbTongTien = New System.Windows.Forms.TextBox()
        Me.txbSoLuongDH = New System.Windows.Forms.TextBox()
        Me.txbTongKhuyenMai = New System.Windows.Forms.TextBox()
        Me.cbChiNhanh = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnThongKe = New System.Windows.Forms.Button()
        CType(Me.dtgvThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THỐNG KÊ"
        '
        'dtgvThongKe
        '
        Me.dtgvThongKe.AllowUserToAddRows = False
        Me.dtgvThongKe.AllowUserToDeleteRows = False
        Me.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvThongKe.Location = New System.Drawing.Point(12, 115)
        Me.dtgvThongKe.Name = "dtgvThongKe"
        Me.dtgvThongKe.ReadOnly = True
        Me.dtgvThongKe.Size = New System.Drawing.Size(776, 323)
        Me.dtgvThongKe.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Từ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Đến"
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = ""
        Me.dtpFrom.Location = New System.Drawing.Point(66, 39)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpFrom.TabIndex = 1
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = ""
        Me.dtpTo.Location = New System.Drawing.Point(66, 72)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpTo.TabIndex = 2
        '
        'chbThanhCong
        '
        Me.chbThanhCong.AutoSize = True
        Me.chbThanhCong.Location = New System.Drawing.Point(290, 39)
        Me.chbThanhCong.Name = "chbThanhCong"
        Me.chbThanhCong.Size = New System.Drawing.Size(85, 17)
        Me.chbThanhCong.TabIndex = 6
        Me.chbThanhCong.Text = "Thành Công"
        Me.chbThanhCong.UseVisualStyleBackColor = True
        '
        'cbHuy
        '
        Me.cbHuy.AutoSize = True
        Me.cbHuy.Location = New System.Drawing.Point(290, 72)
        Me.cbHuy.Name = "cbHuy"
        Me.cbHuy.Size = New System.Drawing.Size(45, 17)
        Me.cbHuy.TabIndex = 7
        Me.cbHuy.Text = "Hủy"
        Me.cbHuy.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(536, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tổng tiền"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(536, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Số lượng DH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(536, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tổng khuyến mãi"
        '
        'txbTongTien
        '
        Me.txbTongTien.Location = New System.Drawing.Point(631, 21)
        Me.txbTongTien.Name = "txbTongTien"
        Me.txbTongTien.ReadOnly = True
        Me.txbTongTien.Size = New System.Drawing.Size(115, 20)
        Me.txbTongTien.TabIndex = 11
        '
        'txbSoLuongDH
        '
        Me.txbSoLuongDH.Location = New System.Drawing.Point(631, 48)
        Me.txbSoLuongDH.Name = "txbSoLuongDH"
        Me.txbSoLuongDH.ReadOnly = True
        Me.txbSoLuongDH.Size = New System.Drawing.Size(115, 20)
        Me.txbSoLuongDH.TabIndex = 12
        '
        'txbTongKhuyenMai
        '
        Me.txbTongKhuyenMai.Location = New System.Drawing.Point(631, 74)
        Me.txbTongKhuyenMai.Name = "txbTongKhuyenMai"
        Me.txbTongKhuyenMai.ReadOnly = True
        Me.txbTongKhuyenMai.Size = New System.Drawing.Size(115, 20)
        Me.txbTongKhuyenMai.TabIndex = 13
        '
        'cbChiNhanh
        '
        Me.cbChiNhanh.FormattingEnabled = True
        Me.cbChiNhanh.Location = New System.Drawing.Point(395, 53)
        Me.cbChiNhanh.Name = "cbChiNhanh"
        Me.cbChiNhanh.Size = New System.Drawing.Size(121, 21)
        Me.cbChiNhanh.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Chi Nhánh"
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(394, 80)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(121, 25)
        Me.btnThongKe.TabIndex = 4
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'frmThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbChiNhanh)
        Me.Controls.Add(Me.txbTongKhuyenMai)
        Me.Controls.Add(Me.txbSoLuongDH)
        Me.Controls.Add(Me.txbTongTien)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbHuy)
        Me.Controls.Add(Me.chbThanhCong)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgvThongKe)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThongKe"
        Me.Text = "Thống kê"
        CType(Me.dtgvThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtgvThongKe As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents chbThanhCong As CheckBox
    Friend WithEvents cbHuy As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbTongTien As TextBox
    Friend WithEvents txbSoLuongDH As TextBox
    Friend WithEvents txbTongKhuyenMai As TextBox
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnThongKe As Button
End Class
