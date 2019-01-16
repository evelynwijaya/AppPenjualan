Imports System.Data.Odbc
Public Class FormTambahJenis
    Public Sub FormTambahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isimerek()
        isikategosi()
        autokode()
        ComboKategori.Text = ""
        tbharga.Text = ""

        tbnamabaju.Text = ""
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
       
        If tbnamabaju.Text = "" Or ComboMerek.Text = "" Or ComboKategori.Text = "" Or tbharga.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * from tb_stok WHERE nama_baju = '" & tbnamabaju.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Nama Baju sudah ada, silahkan menginput data baru!", vbInformation, "Information")
                tbnamabaju.Text = ""
                tbharga.Text = ""
                ComboKategori.Text = ""
                ComboMerek.Text = ""
            Else
                Dim strsimpan As String = "Insert Into tb_stok ( kode_baju , nama_baju , nama_merek , kategori , harga )" _
                                     & "Value ('" & tbkodebaju.Text & "','" & tbnamabaju.Text & "','" & ComboMerek.Text & "','" & ComboKategori.Text & "','" & tbharga.Text & "')"
                Call simpandata(strsimpan)
                MsgBox("Data Tersimpan !", vbInformation, "Information")

                autokode()
                tbnamabaju.Text = ""
                tbharga.Text = ""
                ComboKategori.Text = ""
                ComboMerek.Text = ""
                FormStok.isigrid()
            End If
        End If

    End Sub


    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        autokode()
        tbharga.Text = ""
        tbnamabaju.Text = ""
        ComboMerek.Text = ""
        ComboKategori.Text = ""

        Me.Hide()
        FormStok.Show()
    End Sub

    Private Sub tbharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbnamabaju_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamabaju.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
   

    Private Sub FormTambahJenis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub

   

    'Private Sub tbharga_Leave(sender As Object, e As EventArgs) Handles tbharga.Leave
    '    ComboMerek.Focus()
    'End Sub

    'Private Sub ComboMerek_Leave(sender As Object, e As EventArgs) Handles ComboMerek.Leave
    '    ComboKategori.Focus()
    'End Sub

    'Private Sub ComboKategori_Leave(sender As Object, e As EventArgs) Handles ComboKategori.Leave
    '    tbsimpan.Focus()
    'End Sub

    'Private Sub tbsimpan_Leave(sender As Object, e As EventArgs) Handles tbsimpan.Leave
    '    bttutup.Focus()
    'End Sub

    'Private Sub bttutup_Leave(sender As Object, e As EventArgs) Handles bttutup.Leave
    '    tbnamabaju.Focus()
    'End Sub

    Private Sub btntambahmerek_Click(sender As Object, e As EventArgs) Handles btntambahmerek.Click
        FormTambahDataMerek2.Show()
        Me.Hide()
    End Sub

    Private Sub btntambahkategori_Click(sender As Object, e As EventArgs) Handles btntambahkategori.Click
        FormTambahKategori2.Show()
        Me.Hide()
    End Sub

    
    Private Sub tbharga_TextChanged(sender As Object, e As EventArgs) Handles tbharga.TextChanged
        If tbharga.Text = "" Or Not IsNumeric(tbharga.Text) Then
            Exit Sub
        End If
        Dim hrga As Integer = tbharga.Text
        tbharga.Text = Format(hrga, "#,###")
        tbharga.SelectionStart = Len(tbharga.Text) 'supaya angkanya berurut dari kiri ke kanan
    End Sub

   
End Class