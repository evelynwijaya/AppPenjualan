﻿Imports MySql.Data.MySqlClient
Public Class FormKategori

    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigridkategori()
        judulgrid()
    End Sub

    Sub isigridkategori()
        Dim strtampil As String = "Select * From tb_kategori"
        Dim strtabel As String = "tb_kategori"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_kategori"))
        DataGridView1.ReadOnly = True
    End Sub
    Sub judulgrid()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView1.Columns(0).HeaderText = "KODE KATEGORI"
        DataGridView1.Columns(1).HeaderText = "NAMA KATEGORI"
        DataGridView1.Columns(0).Width = "325"
        DataGridView1.Columns(1).Width = "325"
    End Sub

    Sub seleksi()
        Dim strtext As String = "Select * from tb_kategori where kode_kategori like '%" & tbsearch.Text & "%' or nama_kategori like '%" & tbsearch.Text & "%'"
        Using cmd2 As New MySqlCommand(strtext, konek)
            Using adapter As New MySqlDataAdapter(cmd2)
                Using DataSet As New DataSet()
                    adapter.Fill(DataSet)
                    DataGridView1.DataSource = DataSet.Tables(0)
                    DataGridView1.ReadOnly = True
                End Using
            End Using
        End Using
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        tbsearch.Text = ""
        tbkodekategori.Text = ""
        tbnamakategori.Text = ""
        isigridkategori()
    End Sub

    Private Sub tbsearch_TextChanged(sender As Object, e As EventArgs) Handles tbsearch.TextChanged
        seleksi()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        tbkodekategori.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value
        tbnamakategori.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        Dim stredit As String = "Update tb_kategori set kategori = '" & tbnamakategori.Text & "' where kode_kategori = '" & tbkodekategori.Text & "'"
        Call editdata(stredit)

        If tbnamakategori.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            MsgBox("Data Terupdate!", vbInformation, "Information")
        End If

        tbsearch.Text = ""
        isigridkategori()
        tbkodekategori.Text = ""
        tbnamakategori.Text = ""
        tbnamakategori.Focus()
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If tbnamakategori.Text <> "" Then
            Dim strhapus As String = "DELETE FROM tb_kategori WHERE kode_kategori = '" & tbkodekategori.Text & "'"
            If MsgBox("Apakah Anda yakin ingin menghapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
                Call hapusdata(strhapus)
                MsgBox("Data Berhasil Dihapus!", vbInformation, "Information")
            End If
        Else
            MsgBox("Pilih data terlebih dahulu!", vbCritical, "Error")
        End If
        isigridkategori()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormTambahKategori.Show()
    End Sub

    Private Sub tbsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbsearch.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbnamakategori_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamakategori.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class