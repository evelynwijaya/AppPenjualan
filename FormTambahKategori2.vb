Public Class FormTambahKategori2

   
    Private Sub FormTambahKategori2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub tbsimpan_Click(sender As Object, e As EventArgs) Handles tbsimpan.Click
        If tbnamakategori.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * from tb_kategori WHERE kategori = '" & tbnamakategori.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Nama Kategori sudah ada, silahkan menginput data baru!", vbInformation, "Information")
                tbnamakategori.Text = ""
            Else

                Dim strsimpan As String = "Insert Into tb_kategori ( kode_kategori , kategori )" _
                                          & "value ('" & tbkodekategori.Text & "','" & tbnamakategori.Text & "')"
                Call simpandata(strsimpan)
                MsgBox("Data Tersimpan!", vbInformation, "Information")

                autokode()
                tbnamakategori.Text = ""
                FormTambahJenis.isikategosi()
                FormStok.isikategosi()
                Me.Hide()
            End If
        End If
    End Sub

   

    Private Sub FormTambahKategori2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub

    Private Sub tbnamakategori_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamakategori.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        Me.Hide()
        FormTambahJenis.Show()
    End Sub
End Class