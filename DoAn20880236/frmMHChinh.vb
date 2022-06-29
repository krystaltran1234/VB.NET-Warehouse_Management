Public Class frmMHChinh
    Public NguoiDung As DataRow
    Private Sub SanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhamToolStripMenuItem.Click
        Dim frm As frmSanPham = New frmSanPham()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub NguoiDungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NguoiDungToolStripMenuItem.Click
        Dim frm As frmNguoiDung = New frmNguoiDung()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub frmMHChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim frm As frmDangNhap = New frmDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.OK Then
            Me.NguoiDung = frm.NguoiDung
            lbThongTinNguoiDung.Text = NguoiDung("nd_ho_ten")
            Me.Show()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub TheoDoiPhieuNhapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheoDoiPhieuNhapToolStripMenuItem.Click
        Dim frm As frmTheoDoiPhieuNhap = New frmTheoDoiPhieuNhap()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub DanhSachPhieuNhapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuNhapToolStripMenuItem.Click
        Dim frm As frmDanhSachPhieuNhap = New frmDanhSachPhieuNhap()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub KhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhoToolStripMenuItem.Click
        Dim frm As frmKho = New frmKho()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        Dim frm As frmKhachHang = New frmKhachHang()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub DanhSachPhieuXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuXuatToolStripMenuItem.Click
        Dim frm As frmDanhSachPhieuXuat = New frmDanhSachPhieuXuat()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub BaoCaoDoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaoCaoDoanhThuToolStripMenuItem.Click
        Dim frm As frmDoanhThu = New frmDoanhThu()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub


End Class
