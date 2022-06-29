<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheoDoiPhieuNhap
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
        Me.dgvDSPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.dtp_Ngay = New System.Windows.Forms.DateTimePicker()
        Me.cbKho = New System.Windows.Forms.ComboBox()
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        Me.bTim = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bTao = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bDong = New System.Windows.Forms.Button()
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDSPhieuNhap
        '
        Me.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhieuNhap.Location = New System.Drawing.Point(25, 105)
        Me.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap"
        Me.dgvDSPhieuNhap.RowHeadersWidth = 51
        Me.dgvDSPhieuNhap.RowTemplate.Height = 29
        Me.dgvDSPhieuNhap.Size = New System.Drawing.Size(1077, 371)
        Me.dgvDSPhieuNhap.TabIndex = 0
        '
        'dtp_Ngay
        '
        Me.dtp_Ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Ngay.Location = New System.Drawing.Point(48, 45)
        Me.dtp_Ngay.Name = "dtp_Ngay"
        Me.dtp_Ngay.Size = New System.Drawing.Size(255, 27)
        Me.dtp_Ngay.TabIndex = 1
        Me.dtp_Ngay.Value = New Date(2022, 5, 25, 21, 42, 32, 0)
        '
        'cbKho
        '
        Me.cbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKho.FormattingEnabled = True
        Me.cbKho.Location = New System.Drawing.Point(345, 43)
        Me.cbKho.Name = "cbKho"
        Me.cbKho.Size = New System.Drawing.Size(151, 28)
        Me.cbKho.TabIndex = 2
        '
        'cbKhachHang
        '
        Me.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(549, 43)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(151, 28)
        Me.cbKhachHang.TabIndex = 2
        '
        'bTim
        '
        Me.bTim.Location = New System.Drawing.Point(771, 43)
        Me.bTim.Name = "bTim"
        Me.bTim.Size = New System.Drawing.Size(94, 29)
        Me.bTim.TabIndex = 3
        Me.bTim.Text = "Tim"
        Me.bTim.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ngay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kho"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Khach hang"
        '
        'bTao
        '
        Me.bTao.Location = New System.Drawing.Point(890, 43)
        Me.bTao.Name = "bTao"
        Me.bTao.Size = New System.Drawing.Size(94, 29)
        Me.bTao.TabIndex = 3
        Me.bTao.Text = "Tao"
        Me.bTao.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(1008, 42)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 5
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(1008, 497)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 6
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'frmTheoDoiPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 547)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bTao)
        Me.Controls.Add(Me.bTim)
        Me.Controls.Add(Me.cbKhachHang)
        Me.Controls.Add(Me.cbKho)
        Me.Controls.Add(Me.dtp_Ngay)
        Me.Controls.Add(Me.dgvDSPhieuNhap)
        Me.Name = "frmTheoDoiPhieuNhap"
        Me.Text = "frmTheoDoiPhieuNhap"
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDSPhieuNhap As DataGridView
    Friend WithEvents dtp_Ngay As DateTimePicker
    Friend WithEvents cbKho As ComboBox
    Friend WithEvents cbKhachHang As ComboBox
    Friend WithEvents bTim As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bTao As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bDong As Button
End Class
