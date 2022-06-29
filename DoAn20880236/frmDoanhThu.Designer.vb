<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoanhThu
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
        Me.bDong = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bTim = New System.Windows.Forms.Button()
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        Me.cbKho = New System.Windows.Forms.ComboBox()
        Me.dtp_thang = New System.Windows.Forms.DateTimePicker()
        Me.dgvDoanhThu = New System.Windows.Forms.DataGridView()
        Me.lDoanhThu = New System.Windows.Forms.Label()
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(943, 43)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 48
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(487, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Khach hang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Kho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Thang"
        '
        'bTim
        '
        Me.bTim.Location = New System.Drawing.Point(762, 43)
        Me.bTim.Name = "bTim"
        Me.bTim.Size = New System.Drawing.Size(94, 29)
        Me.bTim.TabIndex = 39
        Me.bTim.Text = "Tim"
        Me.bTim.UseVisualStyleBackColor = True
        '
        'cbKhachHang
        '
        Me.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(487, 45)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(151, 28)
        Me.cbKhachHang.TabIndex = 37
        '
        'cbKho
        '
        Me.cbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKho.FormattingEnabled = True
        Me.cbKho.Location = New System.Drawing.Point(221, 44)
        Me.cbKho.Name = "cbKho"
        Me.cbKho.Size = New System.Drawing.Size(151, 28)
        Me.cbKho.TabIndex = 38
        '
        'dtp_thang
        '
        Me.dtp_thang.CustomFormat = "MM/yyyy"
        Me.dtp_thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_thang.Location = New System.Drawing.Point(35, 45)
        Me.dtp_thang.Name = "dtp_thang"
        Me.dtp_thang.Size = New System.Drawing.Size(132, 27)
        Me.dtp_thang.TabIndex = 36
        Me.dtp_thang.Value = New Date(2022, 5, 25, 21, 42, 32, 0)
        '
        'dgvDoanhThu
        '
        Me.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhThu.Location = New System.Drawing.Point(12, 105)
        Me.dgvDoanhThu.Name = "dgvDoanhThu"
        Me.dgvDoanhThu.RowHeadersWidth = 51
        Me.dgvDoanhThu.RowTemplate.Height = 29
        Me.dgvDoanhThu.Size = New System.Drawing.Size(1025, 364)
        Me.dgvDoanhThu.TabIndex = 35
        '
        'lDoanhThu
        '
        Me.lDoanhThu.AutoSize = True
        Me.lDoanhThu.Location = New System.Drawing.Point(682, 496)
        Me.lDoanhThu.Name = "lDoanhThu"
        Me.lDoanhThu.Size = New System.Drawing.Size(81, 20)
        Me.lDoanhThu.TabIndex = 40
        Me.lDoanhThu.Text = "Doanh Thu"
        '
        'frmDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 572)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.lDoanhThu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bTim)
        Me.Controls.Add(Me.cbKhachHang)
        Me.Controls.Add(Me.cbKho)
        Me.Controls.Add(Me.dtp_thang)
        Me.Controls.Add(Me.dgvDoanhThu)
        Me.Name = "frmDoanhThu"
        Me.Text = "frmDoanhThu"
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bDong As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bTim As Button
    Friend WithEvents cbKhachHang As ComboBox
    Friend WithEvents cbKho As ComboBox
    Friend WithEvents dtp_thang As DateTimePicker
    Friend WithEvents dgvDoanhThu As DataGridView
    Friend WithEvents lDoanhThu As Label
End Class
