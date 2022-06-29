Public Class frmTheoDoiPhieuNhap
    Dim dsPhieuNhap As DataTable
    Dim dsKhachHang As DataTable
    Dim dsKho As DataTable

    Private Sub frmTheoDoiPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsKho = DuLieu.DocDuLieu("select * from Kho where k_xoa = false")
        cbKho.DataSource = dsKho
        cbKho.DisplayMember = "k_ten"
        cbKho.ValueMember = "k_ma"

        dsKhachHang = DuLieu.DocDuLieu("select * from KhachHang where kh_xoa = false")
        cbKhachHang.DataSource = dsKhachHang
        cbKhachHang.DisplayMember = "kh_ten"
        cbKhachHang.ValueMember = "kh_ma"

        cbKhachHang.SelectedIndex = -1
        cbKho.SelectedIndex = -1

        DocDSPhieuNhap()
    End Sub

    Public Sub DocDSPhieuNhap()
        Dim str As String = "select pn_ma, pn_ngay, k_ten, kh_ten, pn_ma_kho, pn_ma_khach_hang, pn_xoa from PhieuNhap, Kho, KhachHang "
        str = str + "where pn_xoa = false and pn_ma_kho = k_ma and pn_ma_khach_hang = kh_ma "
        str = str + "and DateValue(pn_ngay) = #" + dtp_Ngay.Value.ToString("yyyy/MM/dd") + "# "

        If cbKho.SelectedIndex >= 0 Then
            str = str + "and pn_ma_kho = " + cbKho.SelectedValue.ToString() + " "
        End If

        If cbKhachHang.SelectedIndex >= 0 Then
            str = str + "and pn_ma_khach_hang = " + cbKhachHang.SelectedValue.ToString()
        End If
        dsPhieuNhap = DuLieu.DocDuLieu(str)
        dgvDSPhieuNhap.DataSource = dsPhieuNhap

    End Sub

    Private Sub bTim_Click(sender As Object, e As EventArgs) Handles bTim.Click
        DocDSPhieuNhap()

    End Sub

    Private Sub bTao_Click(sender As Object, e As EventArgs) Handles bTao.Click
        Dim frmPhieuNhap = New frmPhieuNhap()
        frmPhieuNhap.Tag = Me
        frmPhieuNhap.Loai = Constants.MHPhieuNhapLoai.Moi
        frmPhieuNhap.MdiParent = Me.MdiParent
        frmPhieuNhap.WindowState = FormWindowState.Maximized
        frmPhieuNhap.Show()

    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDSPhieuNhap.SelectedCells.Count > 0 Then
            Dim pnv As DataRowView = dgvDSPhieuNhap.Rows(dgvDSPhieuNhap.SelectedCells(0).RowIndex).DataBoundItem
            Dim pn As DataRow = pnv.Row

            Dim frmPhieuNhap = New frmPhieuNhap()
            frmPhieuNhap.Tag = Me
            frmPhieuNhap.Loai = Constants.MHPhieuNhapLoai.CapNhat
            frmPhieuNhap.PhieuNhap = pn
            frmPhieuNhap.MdiParent = Me.MdiParent
            frmPhieuNhap.WindowState = FormWindowState.Maximized
            frmPhieuNhap.Show()
        End If


    End Sub

    Private Sub dgvDSPhieuNhap_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSPhieuNhap.CellContentClick
        If dgvDSPhieuNhap.SelectedCells.Count > 0 Then
            Dim pnv As DataRowView = dgvDSPhieuNhap.Rows(dgvDSPhieuNhap.SelectedCells(0).RowIndex).DataBoundItem
            Dim pn As DataRow = pnv.Row

            Dim frmPhieuNhap = New frmPhieuNhap()
            frmPhieuNhap.Tag = Me
            frmPhieuNhap.Loai = Constants.MHPhieuNhapLoai.Hienthi
            frmPhieuNhap.PhieuNhap = pn
            frmPhieuNhap.MdiParent = Me.MdiParent
            frmPhieuNhap.WindowState = FormWindowState.Maximized
            frmPhieuNhap.Show()
        End If
    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub
End Class