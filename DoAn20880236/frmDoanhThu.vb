Imports System.Text
Public Class frmDoanhThu
    Dim dsDoanhThu As DataTable
    Dim TongDoanhThu As Integer
    Dim dsPhieuXuat As DataTable
    Dim dsKhachHang As DataTable
    Dim dsKho As DataTable

    Private Sub frmDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DocDoanhThuTuDSPhieuXuat()
        lDoanhThu.Text = "Tong doanh thu: " + TongDoanhThu.ToString()

    End Sub

    Sub DocDoanhThuTuDSPhieuXuat()
        Dim sb As StringBuilder = New StringBuilder
        sb.Append("select distinct px_ma, px_ngay, px_ma_don_gia, k_ten, kh_ten, px_doanh_thu, px_doanh_thu_theo_don_gia, px_ghi_chu from PhieuXuat, PhieuNhap, Kho, KhachHang")
        sb.Append(" where px_ma_phieu_nhap = pn_ma and px_xoa = false and pn_ma_khach_hang = kh_ma and pn_ma_kho = k_ma")
        sb.Append(" and Month(px_ngay) = " + dtp_thang.Value.ToString("MM") + " ")
        sb.Append(" and Year(px_ngay) = " + dtp_thang.Value.ToString("yyyy") + " ")


        If cbKho.SelectedIndex >= 0 Then
            sb.Append("and pn_ma_kho = " + cbKho.SelectedValue.ToString() + " ")
        End If

        If cbKhachHang.SelectedIndex >= 0 Then
            sb.Append("and pn_ma_khach_hang = " + cbKhachHang.SelectedValue.ToString() + " ")
        End If

        dsPhieuXuat = DuLieu.DocDuLieu(sb.ToString())
        dsDoanhThu = dsPhieuXuat
        dgvDoanhThu.DataSource = dsDoanhThu
        TinhDoanhThu()

    End Sub

    Private Sub bTim_Click(sender As Object, e As EventArgs) Handles bTim.Click
        DocDoanhThuTuDSPhieuXuat()
        lDoanhThu.Text = "Tong doanh thu: " + TongDoanhThu.ToString()


    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub

    Sub TinhDoanhThu()
        If dsDoanhThu.Rows.Count = 0 Then
            TongDoanhThu = 0
            Return
        End If
        TongDoanhThu = dsDoanhThu.Compute("Sum(px_doanh_thu)", String.Empty)

    End Sub
End Class