<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhSachPhieuXuat
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
        Me.bXoa = New System.Windows.Forms.Button()
        Me.bHienThi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_KetThuc = New System.Windows.Forms.DateTimePicker()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bTim = New System.Windows.Forms.Button()
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        Me.cbKho = New System.Windows.Forms.ComboBox()
        Me.dtp_BatDau = New System.Windows.Forms.DateTimePicker()
        Me.dgvDSPhieuXuat = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDSPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(1103, 513)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 34
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(1103, 47)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(94, 29)
        Me.bXoa.TabIndex = 31
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'bHienThi
        '
        Me.bHienThi.Location = New System.Drawing.Point(881, 47)
        Me.bHienThi.Name = "bHienThi"
        Me.bHienThi.Size = New System.Drawing.Size(94, 29)
        Me.bHienThi.TabIndex = 33
        Me.bHienThi.Text = "Hien thi"
        Me.bHienThi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Ngay ket thuc"
        '
        'dtp_KetThuc
        '
        Me.dtp_KetThuc.CustomFormat = "dd/MM/yyyy"
        Me.dtp_KetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_KetThuc.Location = New System.Drawing.Point(198, 49)
        Me.dtp_KetThuc.Name = "dtp_KetThuc"
        Me.dtp_KetThuc.Size = New System.Drawing.Size(132, 27)
        Me.dtp_KetThuc.TabIndex = 29
        Me.dtp_KetThuc.Value = New Date(2022, 5, 25, 21, 42, 32, 0)
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(992, 47)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 28
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(585, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Khach hang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Kho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Ngay bat dau"
        '
        'bTim
        '
        Me.bTim.Location = New System.Drawing.Point(768, 47)
        Me.bTim.Name = "bTim"
        Me.bTim.Size = New System.Drawing.Size(94, 29)
        Me.bTim.TabIndex = 24
        Me.bTim.Text = "Tim"
        Me.bTim.UseVisualStyleBackColor = True
        '
        'cbKhachHang
        '
        Me.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(585, 48)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(151, 28)
        Me.cbKhachHang.TabIndex = 22
        '
        'cbKho
        '
        Me.cbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKho.FormattingEnabled = True
        Me.cbKho.Location = New System.Drawing.Point(381, 48)
        Me.cbKho.Name = "cbKho"
        Me.cbKho.Size = New System.Drawing.Size(151, 28)
        Me.cbKho.TabIndex = 23
        '
        'dtp_BatDau
        '
        Me.dtp_BatDau.CustomFormat = "dd/MM/yyyy"
        Me.dtp_BatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_BatDau.Location = New System.Drawing.Point(35, 50)
        Me.dtp_BatDau.Name = "dtp_BatDau"
        Me.dtp_BatDau.Size = New System.Drawing.Size(132, 27)
        Me.dtp_BatDau.TabIndex = 21
        Me.dtp_BatDau.Value = New Date(2022, 5, 25, 21, 42, 32, 0)
        '
        'dgvDSPhieuXuat
        '
        Me.dgvDSPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhieuXuat.Location = New System.Drawing.Point(12, 110)
        Me.dgvDSPhieuXuat.Name = "dgvDSPhieuXuat"
        Me.dgvDSPhieuXuat.RowHeadersWidth = 51
        Me.dgvDSPhieuXuat.RowTemplate.Height = 29
        Me.dgvDSPhieuXuat.Size = New System.Drawing.Size(1185, 371)
        Me.dgvDSPhieuXuat.TabIndex = 20
        '
        'frmDanhSachPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 585)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.bXoa)
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
        Me.Controls.Add(Me.dgvDSPhieuXuat)
        Me.Name = "frmDanhSachPhieuXuat"
        Me.Text = "frmDanhSachPhieuXuat"
        CType(Me.dgvDSPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bDong As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents bHienThi As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_KetThuc As DateTimePicker
    Friend WithEvents bCapNhat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bTim As Button
    Friend WithEvents cbKhachHang As ComboBox
    Friend WithEvents cbKho As ComboBox
    Friend WithEvents dtp_BatDau As DateTimePicker
    Friend WithEvents dgvDSPhieuXuat As DataGridView
End Class
