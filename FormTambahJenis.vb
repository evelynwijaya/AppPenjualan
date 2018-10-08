Imports System.Data.Odbc
Public Class FormTambahJenis
    Private Sub FormTambahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isimerek()
        isikategosi()
        autokode()
        ComboKategori.Text = ""
        ComboMerek.Text = ""
        tbnamabaju.Focus()
    End Sub
    Sub isimerek()
        Dim sql As String = "Select * from tb_merek Order by kode_merek"
        Call KonekDB()
        da = New Data.Odbc.OdbcDataAdapter(sql, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            ComboMerek.DataSource = dt
            ComboMerek.ValueMember = "kode_merek"
            ComboMerek.DisplayMember = "nama_merek"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub isikategosi()
        Dim sql As String = "Select * from tb_kategori Order by kode_kategori"
        Call KonekDB()
        da = New Data.Odbc.OdbcDataAdapter(sql, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            ComboKategori.DataSource = dt
            ComboKategori.ValueMember = "kode_kategori"
            ComboKategori.DisplayMember = "kategori"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub autokode()
        Dim SQL As String
        Dim no As Long
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQL = "SELECT * FROM tb_stok WHERE kode_baju in (SELECT MAX(kode_baju) FROM tb_stok)"
        cmd.CommandText = SQL
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(0), 4)) + 1
        End If
        tbkodebaju.Text = "S" & Microsoft.VisualBasic.Right("0000" & no, 4)
    End Sub

    Private Sub tbsimpan_Click(sender As Object, e As EventArgs) Handles tbsimpan.Click
        Dim strsimpan As String = "Insert Into tb_stok ( kode_baju , nama_baju , nama_merek , kategori , harga )" _
                                  & "Value ('" & tbkodebaju.Text & "','" & tbnamabaju.Text & "','" & ComboMerek.Text & "','" & ComboKategori.Text & "','" & tbharga.Text & "')"
        Call simpandata(strsimpan)

        If tbnamabaju.Text = "" Or ComboMerek.Text = "" Or ComboKategori.Text = "" Or tbharga.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            MsgBox("Data Tersimpan !", vbInformation, "Information")
        End If

        autokode()
        tbnamabaju.Text = ""
        tbharga.Text = ""
        ComboKategori.Text = ""
        ComboMerek.Text = ""
    End Sub


    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class