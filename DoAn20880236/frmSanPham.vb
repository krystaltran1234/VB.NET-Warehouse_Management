Public Class frmSanPham
    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsSanPham = DuLieu.DocDuLieu("Select * from SanPham")
        dsSanPhamView = New DataView(dsSanPham)
        dgvDSSanPham.DataSource = dsSanPhamView
        dgvDSSanPham.Columns(0).HeaderText = "Ma"
        dgvDSSanPham.Columns(1).HeaderText = "Ten"

    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If tbTen.Text <> "" Then
            Dim sp As DataRow = dsSanPham.NewRow()
            sp("sp_Ten") = tbTen.Text
            dsSanPham.Rows.Add(sp)
            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        Else

        End If

    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDSSanPham.SelectedCells.Count > 0 Then
            Dim spv As DataRowView = dgvDSSanPham.Rows(dgvDSSanPham.SelectedCells(0).RowIndex).DataBoundItem
            Dim sp As DataRow = spv.Row
            sp("sp_Ten") = tbTen.Text

            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        Else

        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSSanPham.SelectedCells.Count > 0 Then
            Dim spv As DataRowView = dgvDSSanPham.Rows(dgvDSSanPham.SelectedCells(0).RowIndex).DataBoundItem
            Dim sp As DataRow = spv.Row
            sp.Delete()

            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        Else

        End If
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text <> "" Then
            dsSanPhamView.RowFilter = "sp_Ten like '%" + tbTimKiem.Text + "%'"
        Else
            dsSanPhamView.RowFilter = ""
        End If
    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub
End Class