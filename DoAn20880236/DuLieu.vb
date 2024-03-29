﻿Imports System.Data.OleDb

Module DuLieu

    Dim ChuoiKetNoi As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\source\repos\DoAn20880236\DoAn20880236\qlkho.accdb;Persist Security Info=True"
    Public Function DocDuLieu(sql As String) As DataTable
        Dim connection As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim command As OleDbCommand = New OleDbCommand(sql, connection)
        Dim dt As DataTable = New DataTable()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command) 'command: tuong ung voi cau select
        adapter.Fill(dt)
        Return dt
    End Function

    Public Function DocCauTruc(sql As String) As DataTable
        Dim connection As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim command As OleDbCommand = New OleDbCommand(sql, connection)
        Dim dt As DataTable = New DataTable()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        adapter.FillSchema(dt, SchemaType.Source)
        Return dt
    End Function

    Public Sub GhiDuLieu(TenBang As String, DuLieu As DataTable)

        Dim connection As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim command As OleDbCommand = New OleDbCommand("select * from " + TenBang, connection)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter) 'Tao cac insert, delete, update tu cau select
        AddHandler adapter.RowUpdated, AddressOf CapNhatMaSo
        adapter.Update(DuLieu)
    End Sub

    Private Sub CapNhatMaSo(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        Dim Ket_noi As OleDbConnection = e.Command.Connection
        If e.StatementType = StatementType.Insert Then
            Dim Lenh As OleDbCommand = New OleDbCommand("Select @@IDENTITY", Ket_noi)
            Dim ma_so As Integer = Integer.Parse(Lenh.ExecuteScalar())
            e.Row(0) = ma_so
        End If
    End Sub
End Module
