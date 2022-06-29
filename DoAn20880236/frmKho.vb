Public Class frmKho
    Dim dsKho As DataTable
    Dim dsKhoView As DataView

    Private Sub frmKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DocDSKho(ckbXoa.Checked)

    End Sub

    Sub DocDSKho(ByVal hien_thi_xoa As Boolean)
        Dim sql As String

        If hien_thi_xoa Then
            sql = "Select * from Kho"
        Else
            sql = "Select * from Kho where k_xoa = false"

        End If

        dsKho = DuLieu.DocDuLieu(sql)
        dsKhoView = New DataView(dsKho)
        dgvDSKho.DataSource = dsKhoView

        dgvDSKho.Columns(0).HeaderText = "Ma"
        dgvDSKho.Columns(1).HeaderText = "Ten"
        dgvDSKho.Columns(2).HeaderText = "Da xoa"

    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If tbTen.Text <> "" Then
            Dim k As DataRow = dsKho.NewRow()
            k("k_ten") = tbTen.Text
            dsKho.Rows.Add(k)
            DuLieu.GhiDuLieu("Kho", dsKho)
        End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDSKho.SelectedCells.Count > 0 Then
            Dim kv As DataRowView = dgvDSKho.Rows(dgvDSKho.SelectedCells(0).RowIndex).DataBoundItem
            Dim k As DataRow = kv.Row
            k("k_ten") = tbTen.Text

            DuLieu.GhiDuLieu("Kho", dsKho)
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSKho.SelectedCells.Count = 0 Then
            Return
        End If

        Dim kv As DataRowView = dgvDSKho.Rows(dgvDSKho.SelectedCells(0).RowIndex).DataBoundItem
        Dim k As DataRow = kv.Row
        k("k_xoa") = True

        DuLieu.GhiDuLieu("Kho", dsKho)

        If ckbXoa.Checked = False Then
            dsKho.Rows.Remove(k)
        End If

    End Sub

    Private Sub ckbXoa_CheckedChanged(sender As Object, e As EventArgs) Handles ckbXoa.CheckedChanged
        DocDSKho(ckbXoa.Checked)
    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text <> "" Then
            dsKhoView.RowFilter = "k_ten like '%" + tbTimKiem.Text + "%'"
        Else
            dsKhoView.RowFilter = ""
        End If
    End Sub

    Private Sub bKhoiPhuc_Click(sender As Object, e As EventArgs) Handles bKhoiPhuc.Click
        If dgvDSKho.SelectedCells.Count = 0 Then
            Return
        End If

        Dim kv As DataRowView = dgvDSKho.Rows(dgvDSKho.SelectedCells(0).RowIndex).DataBoundItem
        Dim k As DataRow = kv.Row
        k("k_xoa") = False

        DuLieu.GhiDuLieu("Kho", dsKho)

    End Sub
End Class