<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmThongKeNgay
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbChiNhanh = New System.Windows.Forms.ComboBox()
        Me.lbNgayTODAY = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgvThongKeNgay = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvThongKeNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbChiNhanh)
        Me.Panel1.Controls.Add(Me.lbNgayTODAY)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 44)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Chi Nhánh"
        '
        'cbChiNhanh
        '
        Me.cbChiNhanh.FormattingEnabled = True
        Me.cbChiNhanh.Location = New System.Drawing.Point(74, 9)
        Me.cbChiNhanh.Name = "cbChiNhanh"
        Me.cbChiNhanh.Size = New System.Drawing.Size(121, 21)
        Me.cbChiNhanh.TabIndex = 1
        '
        'lbNgayTODAY
        '
        Me.lbNgayTODAY.AutoSize = True
        Me.lbNgayTODAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgayTODAY.Location = New System.Drawing.Point(420, 9)
        Me.lbNgayTODAY.Name = "lbNgayTODAY"
        Me.lbNgayTODAY.Size = New System.Drawing.Size(56, 22)
        Me.lbNgayTODAY.TabIndex = 1
        Me.lbNgayTODAY.Text = "Ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thống kế ngày "
        '
        'dtgvThongKeNgay
        '
        Me.dtgvThongKeNgay.AllowUserToAddRows = False
        Me.dtgvThongKeNgay.AllowUserToDeleteRows = False
        Me.dtgvThongKeNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvThongKeNgay.Location = New System.Drawing.Point(1, 46)
        Me.dtgvThongKeNgay.Name = "dtgvThongKeNgay"
        Me.dtgvThongKeNgay.Size = New System.Drawing.Size(796, 402)
        Me.dtgvThongKeNgay.TabIndex = 1
        '
        'FrmThongKeNgay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtgvThongKeNgay)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmThongKeNgay"
        Me.Text = "FrmThongKeNgay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgvThongKeNgay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtgvThongKeNgay As DataGridView
    Friend WithEvents lbNgayTODAY As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbChiNhanh As ComboBox
End Class
