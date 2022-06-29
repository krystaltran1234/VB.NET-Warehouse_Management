Imports System.Text

Public Class frmDanhSachPhieuXuat
    Dim dsPhieuXuat As DataTable
    Dim dsKhachHang As DataTable
    Dim dsKho As DataTable
    Dim dsCTPN As DataTable
    Public pn As DataRow

    Private Sub frmDanhSachPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DocDSPhieuXuat()


    End Sub
    Sub DocDSPhieuXuat()
        Dim sb As StringBuilder = New StringBuilder
        sb.Append("select distinct px_ma, px_ngay, px_ma_phieu_nhap, px_ma_don_gia, px_xoa, k_ten, kh_ten, px_doanh_thu, px_doanh_thu_theo_don_gia, px_ghi_chu from PhieuXuat, PhieuNhap, Kho, KhachHang")
        sb.Append(" where px_ma_phieu_nhap = pn_ma and px_xoa = false and pn_ma_khach_hang = kh_ma and pn_ma_kho = k_ma")
        sb.Append(" and DateValue(px_ngay) >= #" + dtp_BatDau.Value.ToString("yyyy/MM/dd") + "# ")
        sb.Append(" and DateValue(px_ngay) <= #" + dtp_KetThuc.Value.ToString("yyyy/MM/dd") + "# ")

        If cbKho.SelectedIndex >= 0 Then
            sb.Append("and pn_ma_kho = " + cbKho.SelectedValue.ToString() + " ")
        End If

        If cbKhachHang.SelectedIndex >= 0 Then
            sb.Append("and pn_ma_khach_hang = " + cbKhachHang.SelectedValue.ToString() + " ")
        End If

        dsPhieuXuat = DuLieu.DocDuLieu(sb.ToString())
        dgvDSPhieuXuat.DataSource = dsPhieuXuat

    End Sub

    Private Sub bTim_Click(sender As Object, e As EventArgs) Handles bTim.Click
        DocDSPhieuXuat()
    End Sub

    Private Sub bHienThi_Click(sender As Object, e As EventArgs) Handles bHienThi.Click
        If dgvDSPhieuXuat.SelectedCells.Count > 0 Then
            Dim pxv As DataRowView = dgvDSPhieuXuat.Rows(dgvDSPhieuXuat.SelectedCells(0).RowIndex).DataBoundItem
            Dim px As DataRow = pxv.Row
            Dim str As String = "select pn_ma, pn_ngay, k_ten, kh_ten, pn_ma_kho, pn_ma_khach_hang, pn_xoa from PhieuNhap, Kho, KhachHang "
            str = str + "where pn_xoa = false and pn_ma_kho = k_ma and pn_ma_khach_hang = kh_ma "
            str = str + "and pn_ma = " + px("px_ma_phieu_nhap").ToString()


            Dim dspn As DataTable = DuLieu.DocDuLieu(str)

            Dim frmPhieuXuat = New frmPhieuXuat()
            frmPhieuXuat.Tag = Me
            frmPhieuXuat.Loai = Constants.MHPhieuNhapLoai.Hienthi
            frmPhieuXuat.PhieuNhap = dspn.Rows(0)
            frmPhieuXuat.WindowState = FormWindowState.Maximized
            frmPhieuXuat.Show()

        End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDSPhieuXuat.SelectedCells.Count > 0 Then
            Dim pxv As DataRowView = dgvDSPhieuXuat.Rows(dgvDSPhieuXuat.SelectedCells(0).RowIndex).DataBoundItem
            Dim px As DataRow = pxv.Row
            Dim str As String = "select pn_ma, pn_ngay, k_ten, kh_ten, pn_ma_kho, pn_ma_khach_hang, pn_xoa from PhieuNhap, Kho, KhachHang "
            str = str + "where pn_xoa = false and pn_ma_kho = k_ma and pn_ma_khach_hang = kh_ma "
            str = str + "and pn_ma = " + px("px_ma_phieu_nhap").ToString()

            Dim dspn As DataTable = DuLieu.DocDuLieu(str)


            Dim frmPhieuXuat = New frmPhieuXuat()
            frmPhieuXuat.Tag = Me
            frmPhieuXuat.Loai = Constants.MHPhieuNhapLoai.CapNhat
            frmPhieuXuat.PhieuNhap = dspn.Rows(0)
            frmPhieuXuat.WindowState = FormWindowState.Maximized
            frmPhieuXuat.Show()

        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSPhieuXuat.SelectedCells.Count > 0 Then
            Dim pxv As DataRowView = dgvDSPhieuXuat.Rows(dgvDSPhieuXuat.SelectedCells(0).RowIndex).DataBoundItem
            Dim px As DataRow = pxv.Row

            Dim dr As DialogResult = MessageBox.Show("Ban co muon xoa don hang: " + px("px_ma").ToString() + "," + px("px_ngay").ToString(), "Thong bao", MessageBoxButtons.YesNo)
            If dr = DialogResult.Yes Then
                px("px_xoa") = True
                DuLieu.GhiDuLieu("PhieuXuat", dsPhieuXuat)
                dsPhieuXuat.Rows.Remove(px)
            End If


        End If
    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub
End Class