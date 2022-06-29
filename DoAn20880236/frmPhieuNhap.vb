Public Class frmPhieuNhap
    Dim dsKho As DataTable
    Dim dsKhachHang As DataTable
    Dim dsSanPham As DataTable
    Dim dsCTPN As DataTable
    Dim dsPhieuNhap As DataTable


    Public Loai As Integer '1: moi, 2: hien thi, 3: cap nhat
    Public maPhieuNhap As Integer
    Public PhieuNhap As DataRow
    Private Sub frmPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        dsSanPham = DuLieu.DocDuLieu("select * from SanPham")
        dgvDSSanPham.DataSource = dsSanPham

        If Loai = Constants.MHPhieuNhapLoai.Moi Then
            dsCTPN = DuLieu.DocCauTruc("select * from SanPham, ChiTietPhieuNhap where ctpn_ma_san_pham = sp_ma")
            cbKhachHang.SelectedIndex = -1
            cbKho.SelectedIndex = -1
            dsPhieuNhap = DuLieu.DocCauTruc("select * from PhieuNhap")
            bCapNhat.Visible = False

        ElseIf Loai = Constants.MHPhieuNhapLoai.CapNhat Then
            dsCTPN = DuLieu.DocDuLieu("select * from SanPham, ChiTietPhieuNhap where ctpn_ma_san_pham = sp_ma and ctpn_ma_phieu_nhap =" + PhieuNhap("pn_ma").ToString())
            cbKhachHang.SelectedValue = PhieuNhap("pn_ma_khach_hang")
            cbKho.SelectedValue = PhieuNhap("pn_ma_kho")
            dsPhieuNhap = DuLieu.DocDuLieu("select * from PhieuNhap where pn_ma = " + PhieuNhap("pn_ma").ToString())
            TinhTong()
            bTao.Visible = False
        ElseIf Loai = Constants.MHPhieuNhapLoai.Hienthi Then
            dsCTPN = DuLieu.DocDuLieu("select * from SanPham, ChiTietPhieuNhap where ctpn_ma_san_pham = sp_ma and ctpn_ma_phieu_nhap =" + PhieuNhap("pn_ma").ToString())
            cbKhachHang.SelectedValue = PhieuNhap("pn_ma_khach_hang")
            cbKho.SelectedValue = PhieuNhap("pn_ma_kho")
            dsPhieuNhap = DuLieu.DocDuLieu("select * from PhieuNhap where pn_ma = " + PhieuNhap("pn_ma").ToString())
            TinhTong()
            bCapNhat.Visible = False
            bTao.Visible = False
            bXoa.Visible = False
            bThem.Visible = False
            tbTheTich.Visible = False
            tbTrongLuong.Visible = False


        End If


        dgvDSCTPN.DataSource = dsCTPN
        dgvDSCTPN.Columns(0).Visible = False
        dgvDSCTPN.Columns(2).Visible = False
        dgvDSCTPN.Columns(3).Visible = False
        dgvDSCTPN.Columns(4).Visible = False
        dgvDSCTPN.Columns(8).Visible = False


    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If dgvDSSanPham.SelectedCells.Count > 0 Then
            If nudSoLuong.Value > 0 Then
                Dim spv As DataRowView = dgvDSSanPham.Rows(dgvDSSanPham.SelectedCells(0).RowIndex).DataBoundItem
                Dim sp As DataRow = spv.Row

                Dim ctpns() As DataRow = dsCTPN.Select("sp_ma = " + sp("sp_ma").ToString())
                If ctpns.Length > 0 Then
                    Dim ctpn As DataRow = ctpns(0)

                    ctpn("ctpn_so_luong") += nudSoLuong.Value
                    Dim t As Double = 0
                    Double.TryParse(tbTrongLuong.Text, t)
                    ctpn("ctpn_trong_luong") += t
                    t = 0
                    Double.TryParse(tbTheTich.Text, t)
                    ctpn("ctpn_the_tich") += t

                Else
                    Dim ctpn As DataRow = dsCTPN.NewRow()
                    ctpn("sp_ma") = sp("sp_ma")
                    ctpn("sp_ten") = sp("sp_ten")
                    ctpn("ctpn_ma_san_pham") = sp("sp_ma")
                    ctpn("ctpn_so_luong") = nudSoLuong.Value
                    Dim t As Double = 0
                    Double.TryParse(tbTrongLuong.Text, t)
                    ctpn("ctpn_trong_luong") = t
                    t = 0
                    Double.TryParse(tbTheTich.Text, t)
                    ctpn("ctpn_the_tich") = t


                    dsCTPN.Rows.Add(ctpn)
                End If
            Else
            End If


        Else

        End If
        TinhTong()
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSCTPN.SelectedCells.Count > 0 Then
            If nudSoLuong.Value > 0 Then
                Dim ctpnv As DataRowView = dgvDSCTPN.Rows(dgvDSCTPN.SelectedCells(0).RowIndex).DataBoundItem
                Dim ctpn As DataRow = ctpnv.Row

                Dim t = ctpn("ctpn_so_luong") - nudSoLuong.Value
                If t > 0 Then
                    ctpn("ctpn_so_luong") = t
                Else
                    If Loai = Constants.MHPhieuNhapLoai.Moi Then
                        dsCTPN.Rows.Remove(ctpn)
                    ElseIf Loai = Constants.MHPhieuNhapLoai.CapNhat Then
                        ctpn.Delete()
                    End If
                End If
                    Else
            End If
        Else
        End If
        TinhTong()
    End Sub

    Sub TinhTong()
        Dim TongTrongLuong = dsCTPN.Compute("Sum(ctpn_trong_luong)", String.Empty)
        Dim TongTheTich = dsCTPN.Compute("Sum(ctpn_the_tich)", String.Empty)

        lTheTich.Text = "The tich: " + TongTheTich.ToString()
        lTrongLuong.Text = "Trong luong: " + TongTrongLuong.ToString()
    End Sub

    Private Sub bTao_Click(sender As Object, e As EventArgs) Handles bTao.Click
        If cbKhachHang.SelectedIndex < 0 Then
            MessageBox.Show("Vui long chon khach hang")
            Return
        End If
        If cbKho.SelectedIndex < 0 Then
            MessageBox.Show("Vui long chon kho")
            Return
        End If
        If dsCTPN.Rows.Count <= 0 Then
            MessageBox.Show("Vui long chon san pham")
            Return
        End If

        Dim pn = dsPhieuNhap.NewRow()
        pn("pn_ngay") = dtp_ngay.Value
        pn("pn_ma_khach_hang") = cbKhachHang.SelectedValue
        pn("pn_ma_kho") = cbKho.SelectedValue
        dsPhieuNhap.Rows.Add(pn)
        DuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)

        For Each ctpn In dsCTPN.Rows
            ctpn("ctpn_ma_phieu_nhap") = pn("pn_ma")

        Next
        DuLieu.GhiDuLieu("ChiTietPhieuNhap", dsCTPN)
        TatManHinh()

    End Sub

    Sub TatManHinh()
        If TypeOf Tag Is frmTheoDoiPhieuNhap Then
            CType(Tag, frmTheoDoiPhieuNhap).DocDSPhieuNhap()
        End If

        Me.Close()
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If cbKhachHang.SelectedIndex < 0 Then
            MessageBox.Show("Vui long chon khach hang")
            Return
        End If
        If cbKho.SelectedIndex < 0 Then
            MessageBox.Show("Vui long chon kho")
            Return
        End If
        If dsCTPN.Rows.Count <= 0 Then
            MessageBox.Show("Vui long chon san pham")
            Return
        End If

        Dim pn = dsPhieuNhap.Rows(0)
        pn("pn_ngay") = dtp_ngay.Value
        pn("pn_ma_khach_hang") = cbKhachHang.SelectedValue
        pn("pn_ma_kho") = cbKho.SelectedValue
        DuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)

        For Each ctpn In dsCTPN.Rows
            ctpn("ctpn_ma_phieu_nhap") = pn("pn_ma")

        Next
        DuLieu.GhiDuLieu("ChiTietPhieuNhap", dsCTPN)
        TatManHinh()
    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        TatManHinh()
    End Sub
End Class