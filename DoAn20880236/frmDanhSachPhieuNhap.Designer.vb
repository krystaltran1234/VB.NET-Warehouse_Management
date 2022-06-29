<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachPhieuNhap
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
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bTim = New System.Windows.Forms.Button()
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        Me.cbKho = New System.Windows.Forms.ComboBox()
        Me.dtp_BatDau = New System.Windows.Forms.DateTimePicker()
        Me.dgvDSPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_KetThuc = New System.Windows.Forms.DateTimePicker()
        Me.bHienThi = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.bTaoPhieuXuat = New System.Windows.Forms.Button()
        Me.bDong = New System.Windows.Forms.Button()
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(1069, 25)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 15
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(603, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Khach hang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ngay bat dau"
        '
        'bTim
        '
        Me.bTim.Location = New System.Drawing.Point(785, 54)
        Me.bTim.Name = "bTim"
        Me.bTim.Size = New System.Drawing.Size(94, 29)
        Me.bTim.TabIndex = 11
        Me.bTim.Text = "Tim"
        Me.bTim.UseVisualStyleBackColor = True
        '
        'cbKhachHang
        '
        Me.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(603, 55)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(151, 28)
        Me.cbKhachHang.TabIndex = 8
        '
        'cbKho
        '
        Me.cbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKho.FormattingEnabled = True
        Me.cbKho.Location = New System.Drawing.Point(399, 55)
        Me.cbKho.Name = "cbKho"
        Me.cbKho.Size = New System.Drawing.Size(151, 28)
        Me.cbKho.TabIndex = 9
        '
        'dtp_BatDau
        '
        Me.dtp_BatDau.CustomFormat = "dd/MM/yyyy"
        Me.dtp_BatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_BatDau.Location = New System.Drawing.Point(53, 57)
        Me.dtp_BatDau.Name = "dtp_BatDau"
        Me.dtp_BatDau.Size = New System.Drawing.Size(132, 27)
        Me.dtp_BatDau.TabIndex = 7
        Me.dtp_BatDau.Value = New Date(2022, 5, 25, 21, 42, 32, 0)
        '
        'dgvDSPhieuNhap
        '
        Me.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhieuNhap.Location = New System.Drawing.Point(30, 117)
        Me.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap"
        Me.dgvDSPhieuNhap.RowHeadersWidth = 51
        Me.dgvDSPhieuNhap.RowTemplate.Height = 29
        Me.dgvDSPhieuNhap.Size = New System.Drawing.Size(1133, 371)
        Me.dgvDSPhieuNhap.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Ngay ket thuc"
        '
        'dtp_KetThuc
        '
        Me.dtp_KetThuc.CustomFormat = "dd/MM/yyyy"
        Me.dtp_KetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_KetThuc.Location = New System.Drawing.Point(216, 56)
        Me.dtp_KetThuc.Name = "dtp_KetThuc"
        Me.dtp_KetThuc.Size = New System.Drawing.Size(132, 27)
        Me.dtp_KetThuc.TabIndex = 16
        Me.dtp_KetThuc.Value = New Date(2022, 5, 25, 21, 42, 32, 0)
        '
        'bHienThi
        '
        Me.bHienThi.Location = New System.Drawing.Point(940, 25)
        Me.bHienThi.Name = "bHienThi"
        Me.bHienThi.Size = New System.Drawing.Size(94, 29)
        Me.bHienThi.TabIndex = 18
        Me.bHienThi.Text = "Hien thi"
        Me.bHienThi.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(1069, 71)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(94, 29)
        Me.bXoa.TabIndex = 18
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'bTaoPhieuXuat
        '
        Me.bTaoPhieuXuat.Location = New System.Drawing.Point(920, 71)
        Me.bTaoPhieuXuat.Name = "bTaoPhieuXuat"
        Me.bTaoPhieuXuat.Size = New System.Drawing.Size(123, 29)
        Me.bTaoPhieuXuat.TabIndex = 18
        Me.bTaoPhieuXuat.Text = "Tao phieu xuat"
        Me.bTaoPhieuXuat.UseVisualStyleBackColor = True
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(1069, 518)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 19
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'frmDanhSachPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 649)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bTaoPhieuXuat)
        Me.Controls.Add(Me.bHienThi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_KetThuc)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bTim)
        Me.Controls.Add(Me.cbKhachHang)
        Me.Controls.Add(Me.cbKho)
        Me.Controls.Add(Me.dtp_BatDau)
        Me.Controls.Add(Me.dgvDSPhieuNhap)
        Me.Name = "frmDanhSachPhieuNhap"
        Me.Text = "frmDanhSachPhieuNhap"
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCapNhat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bTim As Button
    Friend WithEvents cbKhachHang As ComboBox
    Friend WithEvents cbKho As ComboBox
    Friend WithEvents dtp_BatDau As DateTimePicker
    Friend WithEvents dgvDSPhieuNhap As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_KetThuc As DateTimePicker
    Friend WithEvents bHienThi As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents bTaoPhieuXuat As Button
    Friend WithEvents bDong As Button
End Class
