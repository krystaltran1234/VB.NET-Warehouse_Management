<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuNhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_ngay = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDSSanPham = New System.Windows.Forms.DataGridView()
        Me.dgvDSCTPN = New System.Windows.Forms.DataGridView()
        Me.nudSoLuong = New System.Windows.Forms.NumericUpDown()
        Me.tbTrongLuong = New System.Windows.Forms.TextBox()
        Me.tbTheTich = New System.Windows.Forms.TextBox()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bTao = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.lTrongLuong = New System.Windows.Forms.Label()
        Me.lTheTich = New System.Windows.Forms.Label()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bDong = New System.Windows.Forms.Button()
        Me.cbKho = New System.Windows.Forms.ComboBox()
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDSSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDSCTPN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ngay"
        '
        'dtp_ngay
        '
        Me.dtp_ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ngay.Location = New System.Drawing.Point(50, 44)
        Me.dtp_ngay.Name = "dtp_ngay"
        Me.dtp_ngay.Size = New System.Drawing.Size(250, 27)
        Me.dtp_ngay.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kho"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(594, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Khach hang"
        '
        'dgvDSSanPham
        '
        Me.dgvDSSanPham.AllowUserToAddRows = False
        Me.dgvDSSanPham.AllowUserToDeleteRows = False
        Me.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSSanPham.Location = New System.Drawing.Point(36, 120)
        Me.dgvDSSanPham.Name = "dgvDSSanPham"
        Me.dgvDSSanPham.RowHeadersWidth = 51
        Me.dgvDSSanPham.RowTemplate.Height = 29
        Me.dgvDSSanPham.Size = New System.Drawing.Size(310, 341)
        Me.dgvDSSanPham.TabIndex = 3
        '
        'dgvDSCTPN
        '
        Me.dgvDSCTPN.AllowUserToAddRows = False
        Me.dgvDSCTPN.AllowUserToDeleteRows = False
        Me.dgvDSCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSCTPN.Location = New System.Drawing.Point(623, 120)
        Me.dgvDSCTPN.Name = "dgvDSCTPN"
        Me.dgvDSCTPN.RowHeadersWidth = 51
        Me.dgvDSCTPN.RowTemplate.Height = 29
        Me.dgvDSCTPN.Size = New System.Drawing.Size(543, 341)
        Me.dgvDSCTPN.TabIndex = 4
        '
        'nudSoLuong
        '
        Me.nudSoLuong.Location = New System.Drawing.Point(437, 120)
        Me.nudSoLuong.Name = "nudSoLuong"
        Me.nudSoLuong.Size = New System.Drawing.Size(150, 27)
        Me.nudSoLuong.TabIndex = 5
        Me.nudSoLuong.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tbTrongLuong
        '
        Me.tbTrongLuong.Location = New System.Drawing.Point(437, 163)
        Me.tbTrongLuong.Name = "tbTrongLuong"
        Me.tbTrongLuong.PlaceholderText = "trong luong"
        Me.tbTrongLuong.Size = New System.Drawing.Size(125, 27)
        Me.tbTrongLuong.TabIndex = 6
        '
        'tbTheTich
        '
        Me.tbTheTich.Location = New System.Drawing.Point(437, 221)
        Me.tbTheTich.Name = "tbTheTich"
        Me.tbTheTich.PlaceholderText = "the tich"
        Me.tbTheTich.Size = New System.Drawing.Size(125, 27)
        Me.tbTheTich.TabIndex = 6
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(368, 272)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(94, 29)
        Me.bThem.TabIndex = 7
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'bTao
        '
        Me.bTao.Location = New System.Drawing.Point(437, 348)
        Me.bTao.Name = "bTao"
        Me.bTao.Size = New System.Drawing.Size(94, 29)
        Me.bTao.TabIndex = 7
        Me.bTao.Text = "Tao"
        Me.bTao.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(507, 272)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(94, 29)
        Me.bXoa.TabIndex = 7
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'lTrongLuong
        '
        Me.lTrongLuong.AutoSize = True
        Me.lTrongLuong.Location = New System.Drawing.Point(771, 485)
        Me.lTrongLuong.Name = "lTrongLuong"
        Me.lTrongLuong.Size = New System.Drawing.Size(89, 20)
        Me.lTrongLuong.TabIndex = 8
        Me.lTrongLuong.Text = "Trong luong"
        '
        'lTheTich
        '
        Me.lTheTich.AutoSize = True
        Me.lTheTich.Location = New System.Drawing.Point(1000, 485)
        Me.lTheTich.Name = "lTheTich"
        Me.lTheTich.Size = New System.Drawing.Size(61, 20)
        Me.lTheTich.TabIndex = 8
        Me.lTheTich.Text = "The tich"
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(437, 403)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 7
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(437, 461)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 9
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'cbKho
        '
        Me.cbKho.FormattingEnabled = True
        Me.cbKho.Location = New System.Drawing.Point(408, 43)
        Me.cbKho.Name = "cbKho"
        Me.cbKho.Size = New System.Drawing.Size(151, 28)
        Me.cbKho.TabIndex = 2
        '
        'cbKhachHang
        '
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(594, 43)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(151, 28)
        Me.cbKhachHang.TabIndex = 2
        '
        'frmPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 530)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.lTheTich)
        Me.Controls.Add(Me.lTrongLuong)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.bTao)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.tbTheTich)
        Me.Controls.Add(Me.tbTrongLuong)
        Me.Controls.Add(Me.nudSoLuong)
        Me.Controls.Add(Me.dgvDSCTPN)
        Me.Controls.Add(Me.dgvDSSanPham)
        Me.Controls.Add(Me.cbKhachHang)
        Me.Controls.Add(Me.cbKho)
        Me.Controls.Add(Me.dtp_ngay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPhieuNhap"
        Me.Text = "frmPhieuNhap"
        CType(Me.dgvDSSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDSCTPN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSoLuong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_ngay As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDSSanPham As DataGridView
    Friend WithEvents dgvDSCTPN As DataGridView
    Friend WithEvents nudSoLuong As NumericUpDown
    Friend WithEvents tbTrongLuong As TextBox
    Friend WithEvents tbTheTich As TextBox
    Friend WithEvents bThem As Button
    Friend WithEvents bTao As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents lTrongLuong As Label
    Friend WithEvents lTheTich As Label
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bDong As Button
    Friend WithEvents cbKho As ComboBox
    Friend WithEvents cbKhachHang As ComboBox
End Class
