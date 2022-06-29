Public Class frmKhachHang
    Dim dsKhachHang As DataTable
    Dim dsKhachHangView As DataView
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocDSKhachHang(ckbXoa.Checked)


    End Sub

    Sub DocDSKhachHang(ByVal hien_thi_xoa As Boolean)
        Dim sql As String

        If hien_thi_xoa Then
            sql = "select * from KhachHang"
        Else
            sql = "select * from KhachHang where kh_xoa = false"
        End If

        dsKhachHang = DuLieu.DocDuLieu(sql)
        dsKhachHangView = New DataView(dsKhachHang)
        dgvDSKhachHang.DataSource = dsKhachHangView

        dgvDSKhachHang.Columns(0).HeaderText = "Ma"
        dgvDSKhachHang.Columns(1).HeaderText = "Ten khach hang"
        dgvDSKhachHang.Columns(2).HeaderText = "Da xoa"

    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If tbTen.Text <> "" Then
            Dim kh As DataRow = dsKhachHang.NewRow()
            kh("kh_ten") = tbTen.Text
            dsKhachHang.Rows.Add(kh)
            DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
        End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDSKhachHang.SelectedCells.Count > 0 Then
            Dim khv As DataRowView = dgvDSKhachHang.Rows(dgvDSKhachHang.SelectedCells(0).RowIndex).DataBoundItem
            Dim kh As DataRow = khv.Row
            kh("kh_ten") = tbTen.Text

            DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSKhachHang.SelectedCells.Count = 0 Then
            Return
        End If

        Dim khv As DataRowView = dgvDSKhachHang.Rows(dgvDSKhachHang.SelectedCells(0).RowIndex).DataBoundItem
        Dim kh As DataRow = khv.Row
        kh("kh_xoa") = True

        DuLieu.GhiDuLieu("KhachHang", dsKhachHang)

        If ckbXoa.Checked = False Then
            dsKhachHang.Rows.Remove(kh)
        End If

    End Sub

    Private Sub bKhoiPhuc_Click(sender As Object, e As EventArgs) Handles bKhoiPhuc.Click
        If dgvDSKhachHang.SelectedCells.Count = 0 Then
            Return
        End If

        Dim khv As DataRowView = dgvDSKhachHang.Rows(dgvDSKhachHang.SelectedCells(0).RowIndex).DataBoundItem
        Dim kh As DataRow = khv.Row
        kh("kh_xoa") = False

        DuLieu.GhiDuLieu("KhachHang", dsKhachHang)


    End Sub

    Private Sub ckbXoa_CheckedChanged(sender As Object, e As EventArgs) Handles ckbXoa.CheckedChanged
        DocDSKhachHang(ckbXoa.Checked)
    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text <> "" Then
            dsKhachHangView.RowFilter = "kh_ten like '%" + tbTimKiem.Text + "%'"
        Else
            dsKhachHangView.RowFilter = ""
        End If
    End Sub
End Class