Imports System.Data.Odbc
Public Class FormTambahDataMerek

    Public Sub FormTambahDataMerek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autokode()
        tbnamamerek.Focus()
        tbnamamerek.Text = ""
    End Sub

    Sub autokode()
        Dim SQL As String
        Dim no As Long
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQL = "SELECT * FROM tb_merek WHERE kode_merek in (SELECT MAX(kode_merek) FROM tb_merek)"
        cmd.CommandText = SQL
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(0), 4)) + 1
        End If
        tbkodemerek.Text = "M" & Microsoft.VisualBasic.Right("0000" & no, 4)
    End Sub

    Private Sub tbsimpan_Click(sender As Object, e As EventArgs) Handles tbsimpan.Click
        If tbnamamerek.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * from tb_merek WHERE nama_merek = '" & tbnamamerek.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Nama Merek sudah ada, silahkan menginput data baru!", vbInformation, "Information")
                tbnamamerek.Text = ""
            Else
                Dim strsimpan As String = "Insert Into tb_merek ( kode_merek , nama_merek ) " _
                                 & "value ('" & tbkodemerek.Text & "','" & tbnamamerek.Text & "')"
                Call simpandata(strsimpan)
                MsgBox("Merek Tersimpan!", MsgBoxStyle.Information, "Information")
                autokode()
                tbnamamerek.Text = ""
                tbnamamerek.Focus()
                FormMerek.isigridmerek()
            End If
        End If
       
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        FormTambahDataMerek_Load(sender, e)
        Me.Hide()
        FormMerek.Show()
    End Sub

    Private Sub tbnamamerek_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamamerek.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormTambahDataMerek_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub
End Class