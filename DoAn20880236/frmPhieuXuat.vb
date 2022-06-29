Imports System.Text
Public Class frmPhieuXuat

    Dim dsCTPN As DataTable
    Public PhieuNhap As DataRow
    Public Loai As Integer
    Dim dsDonGia As DataTable
    Dim DonGia As DataRow
    Dim TongTien As Integer

    Public maPhieuXuat As Integer
    Public px As DataRow
    Private Sub frmPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Loai = Constants.MHPhieuNhapLoai.CapNhat Or Loai = Constants.MHPhieuNhapLoai.Moi Then
            bLuu.Visible = True
        ElseIf Loai = Constants.MHPhieuNhapLoai.Hienthi Then
            bLuu.Visible = False
        End If

        lMaPhieuNhap.Text = "Ma phieu nhap: " + PhieuNhap(0).ToString()
        lKhachHang.Text = PhieuNhap(3)
        lKho.Text = PhieuNhap(2)
        dtp_ngay.Value = PhieuNhap(1)

        dsCTPN = DuLieu.DocDuLieu("select * from SanPham, ChiTietPhieuNhap where ctpn_ma_san_pham = sp_ma and ctpn_ma_phieu_nhap =" + PhieuNhap("pn_ma").ToString())
        dgvDSCTPN.DataSource = dsCTPN

        Dim sb As StringBuilder = New StringBuilder()
        sb.Append("Select * from DonGia where dg_ma_khach_hang =" + PhieuNhap("pn_ma_khach_hang").ToString())
        sb.Append(" and DateValue(dg_ngay_ap_dung) <= #" + Convert.ToDateTime(PhieuNhap("pn_ngay")).ToString("yyyy/MM/dd") + "# ")
        sb.Append("order by dg_ngay_ap_dung desc")

        dsDonGia = DuLieu.DocDuLieu(sb.ToString())
        sb = New StringBuilder
        If dsDonGia.Rows.Count > 0 Then
            DonGia = dsDonGia.Rows(0)
            sb.Append(Convert.ToDateTime(DonGia("dg_ngay_ap_dung")).ToString("yyyy/MM/dd"))
            sb.Append(", ")
            If DonGia("dg_loai") = 1 Then
                sb.Append("Tinh theo trong luong")
                sb.Append(", ")
                sb.Append("So luong " + DonGia("dg_trong_luong").ToString())

            ElseIf DonGia("dg_loai") = 2 Then
                sb.Append("Tinh theo the tich")
                sb.Append(", ")
                sb.Append("So luong " + DonGia("dg_the_tich").ToString())
            End If
            sb.Append(", ")
            sb.Append("Gia: " + DonGia("dg_so_tien").ToString())
            lDonGia.Text = sb.ToString()

            TinhTien()

            Dim dsPhieuXuat As DataTable = DuLieu.DocDuLieu("Select * from PhieuXuat where px_ma_phieu_nhap = " + PhieuNhap("pn_ma").ToString())


            If dsPhieuXuat.Rows.Count > 0 Then
                px = dsPhieuXuat.Rows(0)
                If px("px_ma_don_gia") = DonGia("dg_ma") Then
                    px("px_ngay") = dtp_PhieuXuatNgay.Value
                    tbDoanhThu.Text = px("px_doanh_thu")
                    tbGhiChu.Text = px("px_ghi_chu")

                End If
            End If

        Else
            lDonGia.Text = "Khong tim thay don gia"
            bLuu.Visible = False

        End If



    End Sub


    Sub TinhTien()
        Dim TongTrongLuong = dsCTPN.Compute("Sum(ctpn_trong_luong)", String.Empty)
        Dim TongTheTich = dsCTPN.Compute("Sum(ctpn_the_tich)", String.Empty)
        TongTien = 0

        If DonGia("dg_loai") = 1 Then
            TongTien = (TongTrongLuong * DonGia("dg_so_tien")) / DonGia("dg_trong_luong")

        ElseIf DonGia("dg_loai") = 2 Then
            TongTien = (TongTheTich * DonGia("dg_so_tien")) / DonGia("dg_the_tich")

        End If
        lTheTich.Text = "Tong the tich: " + TongTheTich.ToString()
        lTrongLuong.Text = "Tong trong luong: " + TongTrongLuong.ToString()
        tbDoanhThu.Text = TongTien



    End Sub

    Private Sub bLuu_Click(sender As Object, e As EventArgs) Handles bLuu.Click
        Dim dsPhieuXuat As DataTable = DuLieu.DocDuLieu("Select * from PhieuXuat where px_ma_phieu_nhap = " + PhieuNhap("pn_ma").ToString())

        If dsPhieuXuat.Rows.Count > 0 Then
            px = dsPhieuXuat.Rows(0)
        Else
            px = dsPhieuXuat.NewRow()
            dsPhieuXuat.Rows.Add(px)

        End If
        px("px_ma_phieu_nhap") = PhieuNhap("pn_ma")
        px("px_ngay") = dtp_PhieuXuatNgay.Value
        px("px_ma_don_gia") = DonGia("dg_ma")
        px("px_doanh_thu") = tbDoanhThu.Text
        px("px_ghi_chu") = tbGhiChu.Text
        px("px_doanh_thu_theo_don_gia") = TongTien

        DuLieu.GhiDuLieu("PhieuXuat", dsPhieuXuat)
        Me.Close()


    End Sub


    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub


End Class