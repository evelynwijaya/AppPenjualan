Imports System.Data.Odbc
Public Class FormTambahStok

    Private Sub FormTambahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
    End Sub

    Sub isigrid()
        Dim strtampil As String = "SELECT kode_baju , nama_baju , harga , stok FROM tb_stok "
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        lbkodestok.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        Dim sisa_stok As Integer = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value()
        Dim stok_masuk As Integer = tbjumlah.Text
        Dim stok As Integer = sisa_stok + stok_masuk

        Dim strsimpan As String = "UPDATE tb_stok set stok ='" & stok & "', tgl_masuk = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' WHERE kode_baju = '" & lbkodestok.Text & "'"
        Call editdata(strsimpan)

        If tbjumlah.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information!")
        Else
            MsgBox("Data Tersimpan !", vbInformation, "Information")
        End If

        isigrid()
        tbjumlah.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Sub cari(ByVal str As String)
        Dim strtampil As String = "select kode_baju , nama_baju , harga , stok from tb_stok"
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
    End Sub


    Sub seleksi()
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "Select kode_baju , nama_baju , harga , stok from tb_stok where nama_baju like '%" & tbserach.Text & "%'"
        cmd.CommandText = str
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Cari(str)
        Else
            Cari(str)
            MsgBox("Stok Tidak Ditemukan!", vbInformation, "Information")
            tbserach.Text = ""
            isigrid()
            tbserach.Focus()
        End If
    End Sub

    Private Sub tbserach_TextChanged(sender As Object, e As EventArgs) Handles tbserach.TextChanged
        seleksi()
    End Sub

    Private Sub tbjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbserach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbserach.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled = True
        End If
    End Sub
End Class