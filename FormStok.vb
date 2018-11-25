Imports System.Data.Odbc
Public Class FormStok
    Public Sub FormStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbkodestok.Text = ""
        tbnamabaju.Text = ""
        ComboMerek.Text = ""
        tbharga.Text = ""
        ComboKategori.Text = ""
        tbserach.Text = ""

        isigrid()
        isikategosi()
        isimerek()
    End Sub

    Sub isigrid()
        Dim strtampil As String = "select * from tb_stok"
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
       
        lbkodestok.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value()
        tbnamabaju.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value()
        ComboMerek.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value()
        tbharga.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value()
        ComboKategori.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(5).Value()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        If tbnamabaju.Text = "" Or tbharga.Text = "" Then
            MsgBox("Mohon lengkapi Data!", vbCritical, "Warning!")
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
            Else

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
            End If
        End If
    End Sub
    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        lbkodestok.Text = ""
        tbnamabaju.Text = ""
        ComboMerek.Text = ""
        tbharga.Text = ""
        ComboKategori.Text = ""
        tbserach.Text = ""
        isigrid()
    End Sub

  

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        btrefresh_Click(sender, e)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If tbnamabaju.Text = "" And tbharga.Text = "" And ComboKategori.Text = "" And ComboMerek.Text = "" Then
            MsgBox("Pilih data terlebih dahulu!", vbCritical, "Error")
        Else
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * FROM tb_stok WHERE stok=0 and kode_baju = '" & lbkodestok.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim strhapus As String = "DELETE FROM tb_stok WHERE kode_baju = '" & lbkodestok.Text & "'"
                If MsgBox("Apakah Anda yakin ingin menghapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
                    Call hapusdata(strhapus)
                    MsgBox("Data Berhasil Dihapus!", vbInformation, "Information")
                    isigrid()
                    lbkodestok.Text = ""
                    tbnamabaju.Text = ""
                    tbharga.Text = ""
                    ComboKategori.Text = ""
                    ComboMerek.Text = ""
                End If
            Else
                MsgBox("Maaf Data Tidak bisa di hapus karena stok masih tersedia!", vbInformation, "Information")
            End If
        End If
    End Sub

   

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' FormTambahJenis.FormTambahStok_Load(sender, e)
        FormTambahJenis.Show()
        Me.Hide()
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        'FormTambahStok.FormTambahStok_Load(sender, e)
        FormTambahStok.Show()
        Me.Hide()

    End Sub

    Private Sub tbharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbserach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbserach.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbnamabaju_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamabaju.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormStok_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "Select * from tb_stok where nama_baju like '%" & tbserach.Text & "%' or nama_merek like '%" & tbserach.Text & "%' or kode_baju like '%" & tbserach.Text & "%' or kategori like '%" & tbserach.Text & "%'"

        cmd.CommandText = str
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Cari(str)
        Else
            Cari(str)
            MsgBox("Maaf, data tidak ditemukan!", vbInformation, "Pesan")
            tbserach.Text = ""


        End If
    End Sub
End Class