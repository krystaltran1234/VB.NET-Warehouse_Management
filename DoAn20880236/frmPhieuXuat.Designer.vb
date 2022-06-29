<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuXuat
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
        Me.lTheTich = New System.Windows.Forms.Label()
        Me.lTrongLuong = New System.Windows.Forms.Label()
        Me.dgvDSCTPN = New System.Windows.Forms.DataGridView()
        Me.dtp_ngay = New System.Windows.Forms.DateTimePicker()
        Me.lKhachHang = New System.Windows.Forms.Label()
        Me.lKho = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lMaPhieuNhap = New System.Windows.Forms.Label()
        Me.dtp_PhieuXuatNgay = New System.Windows.Forms.DateTimePicker()
        Me.lDonGia = New System.Windows.Forms.Label()
        Me.tbDoanhThu = New System.Windows.Forms.TextBox()
        Me.tbGhiChu = New System.Windows.Forms.TextBox()
        Me.bDong = New System.Windows.Forms.Button()
        Me.bLuu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvDSCTPN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lTheTich
        '
        Me.lTheTich.AutoSize = True
        Me.lTheTich.Location = New System.Drawing.Point(301, 591)
        Me.lTheTich.Name = "lTheTich"
        Me.lTheTich.Size = New System.Drawing.Size(61, 20)
        Me.lTheTich.TabIndex = 26
        Me.lTheTich.Text = "The tich"
        '
        'lTrongLuong
        '
        Me.lTrongLuong.AutoSize = True
        Me.lTrongLuong.Location = New System.Drawing.Point(72, 591)
        Me.lTrongLuong.Name = "lTrongLuong"
        Me.lTrongLuong.Size = New System.Drawing.Size(89, 20)
        Me.lTrongLuong.TabIndex = 25
        Me.lTrongLuong.Text = "Trong luong"
        '
        'dgvDSCTPN
        '
        Me.dgvDSCTPN.AllowUserToAddRows = False
        Me.dgvDSCTPN.AllowUserToDeleteRows = False
        Me.dgvDSCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSCTPN.Location = New System.Drawing.Point(51, 226)
        Me.dgvDSCTPN.Name = "dgvDSCTPN"
        Me.dgvDSCTPN.RowHeadersWidth = 51
        Me.dgvDSCTPN.RowTemplate.Height = 29
        Me.dgvDSCTPN.Size = New System.Drawing.Size(543, 341)
        Me.dgvDSCTPN.TabIndex = 17
        '
        'dtp_ngay
        '
        Me.dtp_ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ngay.Enabled = False
        Me.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ngay.Location = New System.Drawing.Point(51, 52)
        Me.dtp_ngay.Name = "dtp_ngay"
        Me.dtp_ngay.Size = New System.Drawing.Size(250, 27)
        Me.dtp_ngay.TabIndex = 13
        '
        'lKhachHang
        '
        Me.lKhachHang.AutoSize = True
        Me.lKhachHang.Location = New System.Drawing.Point(595, 23)
        Me.lKhachHang.Name = "lKhachHang"
        Me.lKhachHang.Size = New System.Drawing.Size(86, 20)
        Me.lKhachHang.TabIndex = 11
        Me.lKhachHang.Text = "Khach hang"
        '
        'lKho
        '
        Me.lKho.AutoSize = True
        Me.lKho.Location = New System.Drawing.Point(403, 23)
        Me.lKho.Name = "lKho"
        Me.lKho.Size = New System.Drawing.Size(35, 20)
        Me.lKho.TabIndex = 12
        Me.lKho.Text = "Kho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ngay nhap"
        '
        'lMaPhieuNhap
        '
        Me.lMaPhieuNhap.AutoSize = True
        Me.lMaPhieuNhap.Location = New System.Drawing.Point(883, 29)
        Me.lMaPhieuNhap.Name = "lMaPhieuNhap"
        Me.lMaPhieuNhap.Size = New System.Drawing.Size(53, 20)
        Me.lMaPhieuNhap.TabIndex = 27
        Me.lMaPhieuNhap.Text = "Label4"
        '
        'dtp_PhieuXuatNgay
        '
        Me.dtp_PhieuXuatNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtp_PhieuXuatNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_PhieuXuatNgay.Location = New System.Drawing.Point(51, 121)
        Me.dtp_PhieuXuatNgay.Name = "dtp_PhieuXuatNgay"
        Me.dtp_PhieuXuatNgay.Size = New System.Drawing.Size(250, 27)
        Me.dtp_PhieuXuatNgay.TabIndex = 13
        '
        'lDonGia
        '
        Me.lDonGia.AutoSize = True
        Me.lDonGia.Location = New System.Drawing.Point(425, 126)
        Me.lDonGia.Name = "lDonGia"
        Me.lDonGia.Size = New System.Drawing.Size(53, 20)
        Me.lDonGia.TabIndex = 27
        Me.lDonGia.Text = "Label4"
        '
        'tbDoanhThu
        '
        Me.tbDoanhThu.Location = New System.Drawing.Point(741, 230)
        Me.tbDoanhThu.Name = "tbDoanhThu"
        Me.tbDoanhThu.Size = New System.Drawing.Size(125, 27)
        Me.tbDoanhThu.TabIndex = 28
        '
        'tbGhiChu
        '
        Me.tbGhiChu.Location = New System.Drawing.Point(741, 295)
        Me.tbGhiChu.Name = "tbGhiChu"
        Me.tbGhiChu.Size = New System.Drawing.Size(125, 27)
        Me.tbGhiChu.TabIndex = 28
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(894, 460)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 29
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'bLuu
        '
        Me.bLuu.Location = New System.Drawing.Point(726, 460)
        Me.bLuu.Name = "bLuu"
        Me.bLuu.Size = New System.Drawing.Size(94, 29)
        Me.bLuu.TabIndex = 29
        Me.bLuu.Text = "Luu"
        Me.bLuu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ngay xuat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(628, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Doanh Thu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(628, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Ghi Chu"
        '
        'frmPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 709)
        Me.Controls.Add(Me.bLuu)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.tbGhiChu)
        Me.Controls.Add(Me.tbDoanhThu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lDonGia)
        Me.Controls.Add(Me.lMaPhieuNhap)
        Me.Controls.Add(Me.lTheTich)
        Me.Controls.Add(Me.lTrongLuong)
        Me.Controls.Add(Me.dgvDSCTPN)
        Me.Controls.Add(Me.dtp_PhieuXuatNgay)
        Me.Controls.Add(Me.dtp_ngay)
        Me.Controls.Add(Me.lKhachHang)
        Me.Controls.Add(Me.lKho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPhieuXuat"
        Me.Text = "frmPhieuXuat"
        CType(Me.dgvDSCTPN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lTheTich As Label
    Friend WithEvents lTrongLuong As Label
    Friend WithEvents dgvDSCTPN As DataGridView
    Friend WithEvents dtp_ngay As DateTimePicker
    Friend WithEvents lKhachHang As Label
    Friend WithEvents lKho As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lMaPhieuNhap As Label
    Friend WithEvents dtp_PhieuXuatNgay As DateTimePicker
    Friend WithEvents lDonGia As Label
    Friend WithEvents tbDoanhThu As TextBox
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents bDong As Button
    Friend WithEvents bLuu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
