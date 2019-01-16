Imports System.Data.Odbc

Public Class FormMerek
    Public Sub FormMerek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigridmerek()
        judulgrid()
        tbkodemerek.Text = ""
        tbnamamerek.Text = ""
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
        DataGridView1.Columns(0).Width = "305"
        DataGridView1.Columns(1).Width = "305"
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        tbcari.Text = ""
        isigridmerek()
        judulgrid()
        tbkodemerek.Text = ""
        tbnamamerek.Text = ""
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        tbkodemerek.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value()
        tbnamamerek.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
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

                Dim stredit As String = "Update tb_merek set nama_merek = '" & tbnamamerek.Text & "' where kode_merek = '" & tbkodemerek.Text & "'"
                Call editdata(stredit)

                MsgBox("Data Terupdate!", vbInformation, "Information")

                tbcari.Text = ""
                isigridmerek()
                judulgrid()
                tbkodemerek.Text = ""
                tbnamamerek.Text = ""
                tbnamamerek.Focus()
            End If
        End If
    End Sub

    
    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        btRefresh_Click(sender, e)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If tbnamamerek.Text = "" Then
            MsgBox("Pilih data terlebih dahulu!", vbCritical, "Error")
        Else
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * FROM tb_stok WHERE nama_merek = '" & tbnamamerek.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Maaf, Data Merek ini tidak dapat dihapus karena Sudah Terdapat dalam Data Baju!", vbInformation, "Information")
                tbkodemerek.Text = ""
                tbnamamerek.Text = ""
            Else

                Dim strhapus As String = "DELETE FROM tb_merek WHERE kode_merek = '" & tbkodemerek.Text & "'"
                If MsgBox("Apakah Anda yakin ingin menghapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
                    Call hapusdata(strhapus)
                    MsgBox("Data Berhasil Dihapus!", vbInformation, "Information")
                    isigridmerek()
                    judulgrid()
                    tbkodemerek.Text = ""
                    tbnamamerek.Text = ""
                End If
            End If
        End If

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' FormTambahDataMerek.FormTambahDataMerek_Load(sender, e)
        FormTambahDataMerek.Show()
        Me.Hide()
    End Sub

    Private Sub tbcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcari.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormMerek_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub
    Sub Cari(ByVal str As String)
        Dim strtampil As String = str
        Dim strtabel As String = "tb_merek"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_merek"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "Select * from tb_merek where kode_merek like '%" & tbcari.Text & "%' or nama_merek like '%" & tbcari.Text & "%'"

        cmd.CommandText = str
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Cari(str)
        Else
            Cari(str)
            MsgBox("Maaf, data tidak ditemukan!", vbInformation, "Pesan")
            tbcari.Text = ""
            judulgrid()

        End If
    End Sub

    Private Sub tbnamamerek_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamamerek.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbcari_Leave(sender As Object, e As EventArgs) Handles tbcari.Leave
        btncari.Focus()
    End Sub

    Private Sub btncari_Leave(sender As Object, e As EventArgs) Handles btncari.Leave
        btRefresh.Focus()
    End Sub
End Class