<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvDSKhachHang = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTimKiem = New System.Windows.Forms.TextBox()
        Me.ckbXoa = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bKhoiPhuc = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bDong = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvDSKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvDSKhachHang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ckbXoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1115, 527)
        Me.SplitContainer1.SplitterDistance = 602
        Me.SplitContainer1.TabIndex = 2
        '
        'dgvDSKhachHang
        '
        Me.dgvDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDSKhachHang.Location = New System.Drawing.Point(0, 27)
        Me.dgvDSKhachHang.Name = "dgvDSKhachHang"
        Me.dgvDSKhachHang.RowHeadersWidth = 51
        Me.dgvDSKhachHang.RowTemplate.Height = 29
        Me.dgvDSKhachHang.Size = New System.Drawing.Size(602, 500)
        Me.dgvDSKhachHang.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.tbTimKiem)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 27)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tim khach hang"
        '
        'tbTimKiem
        '
        Me.tbTimKiem.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbTimKiem.Location = New System.Drawing.Point(150, 0)
        Me.tbTimKiem.Name = "tbTimKiem"
        Me.tbTimKiem.Size = New System.Drawing.Size(452, 27)
        Me.tbTimKiem.TabIndex = 0
        '
        'ckbXoa
        '
        Me.ckbXoa.AutoSize = True
        Me.ckbXoa.Location = New System.Drawing.Point(335, 33)
        Me.ckbXoa.Name = "ckbXoa"
        Me.ckbXoa.Size = New System.Drawing.Size(111, 24)
        Me.ckbXoa.TabIndex = 6
        Me.ckbXoa.Text = "Hien thi xoa"
        Me.ckbXoa.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bKhoiPhuc)
        Me.Panel2.Controls.Add(Me.bXoa)
        Me.Panel2.Controls.Add(Me.bCapNhat)
        Me.Panel2.Controls.Add(Me.bThem)
        Me.Panel2.Controls.Add(Me.bDong)
        Me.Panel2.Location = New System.Drawing.Point(34, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(423, 108)
        Me.Panel2.TabIndex = 2
        '
        'bKhoiPhuc
        '
        Me.bKhoiPhuc.Location = New System.Drawing.Point(157, 67)
        Me.bKhoiPhuc.Name = "bKhoiPhuc"
        Me.bKhoiPhuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bKhoiPhuc.Size = New System.Drawing.Size(94, 29)
        Me.bKhoiPhuc.TabIndex = 2
        Me.bKhoiPhuc.Text = "Khoi phuc"
        Me.bKhoiPhuc.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(157, 13)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bXoa.Size = New System.Drawing.Size(94, 29)
        Me.bXoa.TabIndex = 2
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(28, 67)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 1
        Me.bCapNhat.Text = "Sua"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(28, 13)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(94, 29)
        Me.bThem.TabIndex = 0
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(301, 39)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 0
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbTen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 27)
        Me.Panel1.TabIndex = 1
        '
        'tbTen
        '
        Me.tbTen.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTen.Location = New System.Drawing.Point(149, 0)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(360, 27)
        Me.tbTen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhap ten khach hang"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 527)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmKhachHang"
        Me.Text = "frmKhachHang"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvDSKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvDSKhachHang As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents ckbXoa As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bKhoiPhuc As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bThem As Button
    Friend WithEvents bDong As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label1 As Label
End Class
