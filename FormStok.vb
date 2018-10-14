Imports MySql.Data.MySqlClient
Public Class FormStok
    Private Sub FormStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()

    End Sub

    Sub isigrid()
        Dim strtampil As String = "select * from tb_stok"
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        lbkodestok.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value()
        tbnamabaju.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value()
        ComboMerek.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value()
        tbharga.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(4).Value()
        ComboKategori.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(6).Value()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        Dim strupdate As String = "Update tb_stok set nama_baju = '" & tbnamabaju.Text & "', nama_merek = '" & ComboMerek.Text & "', harga = '" & tbharga.Text & "', kategori = '" & ComboKategori.Text & "' Where kode_baju = '" & lbkodestok.Text & "'"
        Call editdata(strupdate)
        MsgBox("Data Terupdate!", vbInformation, "Information")
        isigrid()

        lbkodestok.Text = ""
        tbnamabaju.Text = ""
        ComboMerek.Text = ""
        tbharga.Text = ""
        ComboKategori.Text = ""
        tbnamabaju.Focus()
    End Sub
    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        lbkodestok.Text = ""
        tbnamabaju.Text = ""
        ComboMerek.Text = ""
        tbharga.Text = ""
        ComboKategori.Text = ""
        tbserach.Text = ""
    End Sub

    Sub seleksi()
        Dim strtext As String = "Select * from tb_stok where nama_baju like '%" & tbserach.Text & "%' or nama_merek like '%" & tbserach.Text & "%' or kode_baju like '%" & tbserach.Text & "%' or kategori like '%" & tbserach.Text & "%'"
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

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If tbnamabaju.Text <> "" Or tbharga.Text <> "" Or ComboKategori.Text <> "" Or ComboMerek.Text <> "" Then
            Dim strhapus As String = "DELETE FROM tb_stok WHERE kode_stok = '" & lbkodestok.Text & "'"
            If MsgBox("Apakah Anda yakin ingin menghapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
                Call hapusdata(strhapus)
                MsgBox("Data Berhasil Dihapus!", vbInformation, "Information")
            End If
        Else
            MsgBox("Input data terlebih dahulu!", vbCritical, "Error")
        End If
        isigrid()

    End Sub

    Private Sub tbserach_TextChanged(sender As Object, e As EventArgs) Handles tbserach.TextChanged
        seleksi()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormTambahJenis.Show()
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        FormTambahStok.Show()
    End Sub

    Private Sub tbharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class