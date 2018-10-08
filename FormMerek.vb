Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class FormMerek
    Private Sub FormMerek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigridmerek()
        judulgrid()
        tbcari.Focus()
    End Sub

    Sub isigridmerek()
        Dim strtampil As String = "Select * From tb_merek"
        Dim strtabel As String = "tb_merek"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_merek"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub judulgrid()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView1.Columns(0).HeaderText = "KODE MEREK"
        DataGridView1.Columns(1).HeaderText = "NAMA MEREK"
        DataGridView1.Columns(0).Width = "150"
        DataGridView1.Columns(1).Width = "150"
    End Sub
 Sub seleksi()
        Dim strtext As String = "Select * from tb_merek where kode_merek like '%" & tbcari.Text & "%' or nama_merek like '%" & tbcari.Text & "%'"
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
        tbcari.Text = ""
        isigridmerek()
        judulgrid()
        tbkodemerek.Text = ""
        tbnamamerek.Text = ""
    End Sub


    Private Sub tbcari_TextChanged(sender As Object, e As EventArgs) Handles tbcari.TextChanged
        seleksi()

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        tbkodemerek.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value()
        tbnamamerek.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        Dim stredit As String = "Update tb_merek set nama_merek = '" & tbnamamerek.Text & "' where kode_merek = '" & tbkodemerek.Text & "'"
        Call editdata(stredit)

        If tbnamamerek.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            MsgBox("Data Terupdate!", vbInformation, "Information")
        End If

        tbcari.Text = ""
        isigridmerek()
        judulgrid()
        tbkodemerek.Text = ""
        tbnamamerek.Text = ""
        tbnamamerek.Focus()
    End Sub

    
    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If tbnamamerek.Text <> "" Then
            Dim strhapus As String = "DELETE FROM tb_merek WHERE kode_merek = '" & tbkodemerek.Text & "'"
            If MsgBox("Apakah Anda yakin ingin menghapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
                Call hapusdata(strhapus)
                MsgBox("Data Berhasil Dihapus!", vbInformation, "Information")
            End If
        Else
            MsgBox("Input data terlebih dahulu!", vbCritical, "Error")
        End If
        isigridmerek()
        judulgrid()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormTambahDataMerek.Show()
    End Sub
End Class