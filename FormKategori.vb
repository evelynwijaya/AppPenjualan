Imports System.Data.Odbc
Public Class FormKategori

    Public Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbsearch.Text = ""
        tbnamakategori.Text = ""
        tbkodekategori.Text = ""
        isigridkategori()
        judulgrid()
    End Sub

    Sub isigridkategori()
        Dim strtampil As String = "Select * From tb_kategori"
        Dim strtabel As String = "tb_kategori"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_kategori"))
        DataGridView1.ReadOnly = True
    End Sub
    Sub judulgrid()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView1.Columns(0).HeaderText = "KODE KATEGORI"
        DataGridView1.Columns(1).HeaderText = "NAMA KATEGORI"
        DataGridView1.Columns(0).Width = "325"
        DataGridView1.Columns(1).Width = "325"
    End Sub
    Sub Cari(ByVal str As String)
        Dim strtampil As String = str
        Dim strtabel As String = "tb_kategori"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_kategori"))
        DataGridView1.ReadOnly = True
    End Sub


    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        tbsearch.Text = ""
        tbkodekategori.Text = ""
        tbnamakategori.Text = ""
        isigridkategori()
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        tbkodekategori.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value
        tbnamakategori.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        If tbnamakategori.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information")
        Else
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * from tb_kategori WHERE nama_kategori = '" & tbnamakategori.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Nama Kategori sudah ada, silahkan menginput data baru!", vbInformation, "Information")
                tbnamakategori.Text = ""
            Else

                Dim stredit As String = "Update tb_kategori set kategori = '" & tbnamakategori.Text & "' where kode_kategori = '" & tbkodekategori.Text & "'"
                Call editdata(stredit)

                MsgBox("Data Terupdate!", vbInformation, "Information")

                tbsearch.Text = ""
                isigridkategori()
                tbkodekategori.Text = ""
                tbnamakategori.Text = ""
                tbnamakategori.Focus()
            End If
        End If
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        btRefresh_Click(sender, e)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If tbnamakategori.Text = "" Then
            MsgBox("Pilih data terlebih dahulu!", vbCritical, "Error")
        Else
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * FROM tb_stok WHERE kategori = '" & tbnamakategori.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Maaf, Data Kategori ini tidak dapat dihapus karena Sudah Terdapat dalam Data Baju!", vbInformation, "Information")
                tbkodekategori.Text = ""
                tbnamakategori.Text = ""
            Else

                Dim strhapus As String = "DELETE FROM tb_kategori WHERE kode_kategori = '" & tbkodekategori.Text & "'"
                If MsgBox("Apakah Anda yakin ingin menghapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
                    Call hapusdata(strhapus)
                    MsgBox("Data Berhasil Dihapus!", vbInformation, "Information")
                    isigridkategori()
                    tbkodekategori.Text = ""
                    tbnamakategori.Text = ""
                End If
            End If
        End If

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' FormTambahKategori.FormTambahKategori_Load(sender, e)
        FormTambahKategori.Show()
        Me.Hide()
    End Sub

    Private Sub tbsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbsearch.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbnamakategori_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamakategori.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormKategori_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "Select * from tb_kategori where kode_kategori like '%" & tbsearch.Text & "%' or nama_kategori like '%" & tbsearch.Text & "%'"

        cmd.CommandText = str
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Cari(str)
        Else
            Cari(str)
            MsgBox("Maaf, data tidak ditemukan!", vbInformation, "Pesan")
            tbsearch.Text = ""
            judulgrid()

        End If
    End Sub
End Class