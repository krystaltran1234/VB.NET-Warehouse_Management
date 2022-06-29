Public Class frmDangNhap
    Public NguoiDung As DataRow

    Private Sub bDangNhap_Click(sender As Object, e As EventArgs) Handles bDangNhap.Click
        Dim TenDangNhap As String = tbTenDangNhap.Text
        Dim MatKhau As String = tbMatKhau.Text


        Dim dsNguoiDung As DataTable = DuLieu.DocDuLieu("select * from NguoiDung, TaiKhoan where nd_ma_tai_khoan = tk_ma and nd_xoa = false and tk_ten_dang_nhap = '" + TenDangNhap + "'")
        If dsNguoiDung.Rows.Count = 1 Then
            If Util.getHash(MatKhau) = dsNguoiDung.Rows(0)("tk_mat_khau") Then
                Me.DialogResult = DialogResult.OK
                Me.NguoiDung = dsNguoiDung.Rows(0)
                Me.Close()
                Return
            End If
        End If
        lbThongBao.Text = "Tai khoan hoac mat khau khong dung"
        'Me.DialogResult = DialogResult.Cancel
        'Me.Close()


    End Sub


End Class