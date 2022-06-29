<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Me.dgvDSSanPham = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTimKiem = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bThem = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bDong = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvDSSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvDSSanPham)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bDong)
        Me.SplitContainer1.Size = New System.Drawing.Size(1036, 676)
        Me.SplitContainer1.SplitterDistance = 560
        Me.SplitContainer1.TabIndex = 0
        '
        'dgvDSSanPham
        '
        Me.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDSSanPham.Location = New System.Drawing.Point(0, 27)
        Me.dgvDSSanPham.Name = "dgvDSSanPham"
        Me.dgvDSSanPham.RowHeadersWidth = 51
        Me.dgvDSSanPham.RowTemplate.Height = 29
        Me.dgvDSSanPham.Size = New System.Drawing.Size(560, 649)
        Me.dgvDSSanPham.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.tbTimKiem)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(560, 27)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tim san pham"
        '
        'tbTimKiem
        '
        Me.tbTimKiem.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbTimKiem.Location = New System.Drawing.Point(108, 0)
        Me.tbTimKiem.Name = "tbTimKiem"
        Me.tbTimKiem.Size = New System.Drawing.Size(452, 27)
        Me.tbTimKiem.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bXoa)
        Me.Panel2.Controls.Add(Me.bCapNhat)
        Me.Panel2.Controls.Add(Me.bThem)
        Me.Panel2.Location = New System.Drawing.Point(23, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(423, 108)
        Me.Panel2.TabIndex = 2
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(311, 36)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bXoa.Size = New System.Drawing.Size(94, 29)
        Me.bXoa.TabIndex = 2
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(151, 36)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(94, 29)
        Me.bCapNhat.TabIndex = 1
        Me.bCapNhat.Text = "Sua"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(3, 36)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(94, 29)
        Me.bThem.TabIndex = 0
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbTen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 27)
        Me.Panel1.TabIndex = 1
        '
        'tbTen
        '
        Me.tbTen.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTen.Location = New System.Drawing.Point(138, 0)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(334, 27)
        Me.tbTen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhap ten san pham"
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(334, 226)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(94, 29)
        Me.bDong.TabIndex = 0
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 676)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmSanPham"
        Me.Text = "frmSanPham"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvDSSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvDSSanPham As DataGridView
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bXoa As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bThem As Button
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bDong As Button
End Class
