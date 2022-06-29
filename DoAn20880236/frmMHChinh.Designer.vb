<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMHChinh
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuanLyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NguoiDungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaoCaoDoanhThuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NghiepVuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheoDoiPhieuNhapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSachPhieuNhapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSachPhieuXuatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbThongTinNguoiDung = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuanLyToolStripMenuItem, Me.ThongTinToolStripMenuItem, Me.NghiepVuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuanLyToolStripMenuItem
        '
        Me.QuanLyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SanPhamToolStripMenuItem, Me.NguoiDungToolStripMenuItem, Me.KhoToolStripMenuItem, Me.KhachHangToolStripMenuItem})
        Me.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem"
        Me.QuanLyToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.QuanLyToolStripMenuItem.Text = "Quan ly"
        '
        'SanPhamToolStripMenuItem
        '
        Me.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem"
        Me.SanPhamToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.SanPhamToolStripMenuItem.Text = "San pham"
        '
        'NguoiDungToolStripMenuItem
        '
        Me.NguoiDungToolStripMenuItem.Name = "NguoiDungToolStripMenuItem"
        Me.NguoiDungToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.NguoiDungToolStripMenuItem.Text = "Nguoi dung"
        '
        'KhoToolStripMenuItem
        '
        Me.KhoToolStripMenuItem.Name = "KhoToolStripMenuItem"
        Me.KhoToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.KhoToolStripMenuItem.Text = "Kho"
        '
        'KhachHangToolStripMenuItem
        '
        Me.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem"
        Me.KhachHangToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.KhachHangToolStripMenuItem.Text = "Khach hang"
        '
        'ThongTinToolStripMenuItem
        '
        Me.ThongTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaoCaoDoanhThuToolStripMenuItem})
        Me.ThongTinToolStripMenuItem.Name = "ThongTinToolStripMenuItem"
        Me.ThongTinToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.ThongTinToolStripMenuItem.Text = "Thong tin"
        '
        'BaoCaoDoanhThuToolStripMenuItem
        '
        Me.BaoCaoDoanhThuToolStripMenuItem.Name = "BaoCaoDoanhThuToolStripMenuItem"
        Me.BaoCaoDoanhThuToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.BaoCaoDoanhThuToolStripMenuItem.Text = "Bao cao doanh thu"
        '
        'NghiepVuToolStripMenuItem
        '
        Me.NghiepVuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TheoDoiPhieuNhapToolStripMenuItem, Me.DanhSachPhieuNhapToolStripMenuItem, Me.DanhSachPhieuXuatToolStripMenuItem})
        Me.NghiepVuToolStripMenuItem.Name = "NghiepVuToolStripMenuItem"
        Me.NghiepVuToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.NghiepVuToolStripMenuItem.Text = "Nghiep vu"
        '
        'TheoDoiPhieuNhapToolStripMenuItem
        '
        Me.TheoDoiPhieuNhapToolStripMenuItem.Name = "TheoDoiPhieuNhapToolStripMenuItem"
        Me.TheoDoiPhieuNhapToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.TheoDoiPhieuNhapToolStripMenuItem.Text = "Theo doi phieu nhap"
        '
        'DanhSachPhieuNhapToolStripMenuItem
        '
        Me.DanhSachPhieuNhapToolStripMenuItem.Name = "DanhSachPhieuNhapToolStripMenuItem"
        Me.DanhSachPhieuNhapToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.DanhSachPhieuNhapToolStripMenuItem.Text = "Danh sach phieu nhap"
        '
        'DanhSachPhieuXuatToolStripMenuItem
        '
        Me.DanhSachPhieuXuatToolStripMenuItem.Name = "DanhSachPhieuXuatToolStripMenuItem"
        Me.DanhSachPhieuXuatToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.DanhSachPhieuXuatToolStripMenuItem.Text = "Danh sach phieu xuat"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbThongTinNguoiDung)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 32)
        Me.Panel1.TabIndex = 2
        '
        'lbThongTinNguoiDung
        '
        Me.lbThongTinNguoiDung.AutoSize = True
        Me.lbThongTinNguoiDung.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbThongTinNguoiDung.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbThongTinNguoiDung.Location = New System.Drawing.Point(826, 12)
        Me.lbThongTinNguoiDung.Name = "lbThongTinNguoiDung"
        Me.lbThongTinNguoiDung.Size = New System.Drawing.Size(53, 20)
        Me.lbThongTinNguoiDung.TabIndex = 1
        Me.lbThongTinNguoiDung.Text = "Label1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 28)
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.TextToolStripMenuItem.Text = "text"
        '
        'frmMHChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 480)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMHChinh"
        Me.Text = "Ung dung quan ly kho"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuanLyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SanPhamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThongTinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NguoiDungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbThongTinNguoiDung As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NghiepVuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheoDoiPhieuNhapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSachPhieuNhapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KhachHangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSachPhieuXuatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaoCaoDoanhThuToolStripMenuItem As ToolStripMenuItem
End Class
