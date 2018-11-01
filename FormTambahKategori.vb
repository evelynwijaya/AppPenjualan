Public Class FormTambahKategori

    Private Sub tbsimpan_Click(sender As Object, e As EventArgs) Handles tbsimpan.Click
        Dim strsimpan As String = "Insert Into tb_kategori ( kode_kategori , kategori )" _
                                  & "value ('" & tbkodekategori.Text & "','" & tbnamakategori.Text & "')"
        Call simpandata(strsimpan)
        If tbnamakategori.Text = " " Then
            MsgBox("Data Belum Lengkap !", vbCritical, "Error")
        Else
            MsgBox("Data Tersimpan!", vbInformation, "Information")
        End If

        autokode()
        tbnamakategori.Text = ""

    End Sub
    Sub autokode()
        Dim SQL As String
        Dim no As Long
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQL = "SELECT * FROM tb_kategori WHERE kode_kategori in (SELECT MAX(kode_kategori) FROM tb_kategori)"
        cmd.CommandText = SQL
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(0), 4)) + 1
        End If
        tbkodekategori.Text = "K" & Microsoft.VisualBasic.Right("0000" & no, 4)
    End Sub


    Private Sub FormTambahKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autokode()

    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Me.Close()
        FormKategori.Show()

    End Sub
End Class