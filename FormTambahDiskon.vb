Public Class FormTambahDiskon

    Private Sub tbsimpan_Click(sender As Object, e As EventArgs) Handles tbsimpan.Click
        Dim strsimpan As String = "Insert Into tb_diskon ( kode_diskon , diskon ) " _
                                 & "value ('" & tbkodediskon.Text & "','" & tbdiskon.Text & "')"
        Call simpandata(strsimpan)
        If tbdiskon.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbInformation, "Information")
        Else
            MsgBox("Data Tersimpan!", vbInformation, "Information")
        End If
        autokode()
        tbdiskon.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub autokode()
        Dim SQL As String
        Dim no As Long
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQL = "SELECT * FROM tb_diskon WHERE kode_diskon in (SELECT MAX(kode_diskon) FROM tb_diskon)"
        cmd.CommandText = SQL
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(0), 4)) + 1
        End If
        tbkodediskon.Text = "D" & Microsoft.VisualBasic.Right("0000" & no, 4)
    End Sub

    Private Sub FormTambahDiskon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autokode()
    End Sub
End Class