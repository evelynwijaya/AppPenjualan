Imports MySql.Data.MySqlClient
Public Class FormDiskon

    Private Sub FormDiskon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigriddiskon()
    End Sub

    Sub isigriddiskon()
        Dim strtampil As String = "Select * From tb_diskon"
        Dim strtabel As String = "tb_diskon"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_diskon"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub seleksi()
        Dim strtext As String = "Select * from tb_diskon where kode_diskon like '%" & tbsearch.Text & "%' or diskon like '%" & tbsearch.Text & "%'"
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        tbkodediskon.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value
        tbdiskon.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value
    End Sub

    Private Sub tbsearch_TextChanged(sender As Object, e As EventArgs) Handles tbsearch.TextChanged
        seleksi()
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        tbsearch.Text = ""
        tbkodediskon.Text = ""
        tbdiskon.Text = ""
        isigriddiskon()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormTambahDiskon.Show()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        Dim strupdate As String = "Update tb_diskon set diskon = '" & tbdiskon.Text & "' where kode_diskon = '" & tbkodediskon.Text & "'"
        Call editdata(strupdate)

        If tbdiskon.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            MsgBox("Data Terupdate!", vbInformation, "Information")
        End If

        isigriddiskon()
        tbdiskon.Text = ""
        tbkodediskon.Text = ""
        tbdiskon.Focus()
        tbsearch.Text = ""
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If tbkodediskon.Text <> "" Then
            Dim strdelete As String = "Delete From tb_diskon where kode_diskon = '" & tbkodediskon.Text & "'"
            If MsgBox("Apakah anda yakin ingin menghapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
                Call hapusdata(strdelete)
                MsgBox("Data berhasil dihapus!", vbInformation, "Information")
            Else
                MsgBox("Pilih Data terlebih dahulu!", vbInformation, "Information")
            End If
        End If
        isigriddiskon()
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class