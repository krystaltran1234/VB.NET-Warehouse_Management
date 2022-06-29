<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNguoiDung
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
        Me.dgvDSNguoiDung = New System.Windows.Forms.DataGridView()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbNamSinh = New System.Windows.Forms.TextBox()
        Me.tbTenDangNhap = New System.Windows.Forms.TextBox()
        Me.tbMatKhau = New System.Windows.Forms.TextBox()
        Me.cbLoaiTaiKhoan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.bKhoiPhuc = New System.Windows.Forms.Button()
        Me.bDong = New System.Windows.Forms.Button()
        CType(Me.dgvDSNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDSNguoiDung
        '
        Me.dgvDSNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSNguoiDung.Location = New System.Drawing.Point(27, 26)
        Me.dgvDSNguoiDung.Name = "dgvDSNguoiDung"
        Me.dgvDSNguoiDung.RowHeadersWidth = 51
        Me.dgvDSNguoiDung.RowTemplate.Height = 29
        Me.dgvDSNguoiDung.Size = New System.Drawing.Size(508, 421)
        Me.dgvDSNguoiDung.TabIndex = 0
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(731, 77)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(212, 27)
        Me.tbTen.TabIndex = 1
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(731, 119)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(212, 27)
        Me.tbDiaChi.TabIndex = 1
        '
        'tbNamSinh
        '
        Me.tbNamSinh.Location = New System.Drawing.Point(731, 170)
        Me.tbNamSinh.Name = "tbNamSinh"
        Me.tbNamSinh.Size = New System.Drawing.Size(212, 27)
        Me.tbNamSinh.TabIndex = 1
        '
        'tbTenDangNhap
        '
        Me.tbTenDangNhap.Location = New System.Drawing.Point(731, 222)
        Me.tbTenDangNhap.Name = "tbTenDangNhap"
        Me.tbTenDangNhap.Size = New System.Drawing.Size(212, 27)
        Me.tbTenDangNhap.TabIndex = 1
        '
        'tbMatKhau
        '
        Me.tbMatKhau.Location = New System.Drawing.Point(731, 271)
        Me.tbMatKhau.Name = "tbMatKhau"
        Me.tbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMatKhau.Size = New System.Drawing.Size(212, 27)
        Me.tbMatKhau.TabIndex = 1
        '
        'cbLoaiTaiKhoan
        '
        Me.cbLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiTaiKhoan.FormattingEnabled = True
        Me.cbLoaiTaiKhoan.Location = New System.Drawing.Point(731, 323)
        Me.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan"
        Me.cbLoaiTaiKhoan.Size = New System.Drawing.Size(212, 28)
        Me.cbLoaiTaiKhoan.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(600, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ten"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dia chi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nam sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ten dang nhap"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(600, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mat khau"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(600, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Loai tai khoan"
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(593, 394)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(94, 29)
        Me.bThem.TabIndex = 4
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(717, 394)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 4
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(839, 394)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(94, 29)
        Me.bXoa.TabIndex = 4
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(832, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 24)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Hien thi xoa"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'bKhoiPhuc
        '
        Me.bKhoiPhuc.Location = New System.Drawing.Point(951, 394)
        Me.bKhoiPhuc.Name = "bKhoiPhuc"
        Me.bKhoiPhuc.Size = New System.Drawing.Size(94, 29)
        Me.bKhoiPhuc.TabIndex = 4
        Me.bKhoiPhuc.Text = "Khoi phuc"
        Me.bKhoiPhuc.UseVisualStyleBackColor = True
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(951, 452)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 4
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'frmNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 511)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.bKhoiPhuc)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbLoaiTaiKhoan)
        Me.Controls.Add(Me.tbMatKhau)
        Me.Controls.Add(Me.tbTenDangNhap)
        Me.Controls.Add(Me.tbNamSinh)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.dgvDSNguoiDung)
        Me.Name = "frmNguoiDung"
        Me.Text = "frmNguoiDung"
        CType(Me.dgvDSNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDSNguoiDung As DataGridView
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbNamSinh As TextBox
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents cbLoaiTaiKhoan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents bKhoiPhuc As Button
    Friend WithEvents bDong As Button
End Class
