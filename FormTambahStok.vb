﻿Imports System.Data.Odbc
Public Class FormTambahStok

    Public Sub FormTambahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
        judulgrid()
        tbserach.Text = ""
        tbjumlah.Text = ""
        DateTimePicker1.Value = Now
        'DateTimePicker1.MinDate = Format(Now)
        'DateTimePicker1.MaxDate = Format(Now.AddDays(3))
    End Sub

    Sub isigrid()
        Dim strtampil As String = "SELECT kode_baju , nama_baju , harga , stok FROM tb_stok "
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub judulgrid()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView1.Columns(0).HeaderText = "Kode Baju"
        DataGridView1.Columns(1).HeaderText = "Nama Baju"
        DataGridView1.Columns(2).HeaderText = "Harga"
        DataGridView1.Columns(3).HeaderText = "Stok"

        DataGridView1.Columns(0).Width = "170"
        DataGridView1.Columns(1).Width = "170"
        DataGridView1.Columns(2).Width = "170"
        DataGridView1.Columns(3).Width = "170"
     
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        lbkodestok.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value()
        tbharga.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value()
        tbjumlah.Focus()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
      
        If tbjumlah.Text = "" Or tbharga.Text = "" Then
            MsgBox("Mohon Lengkapi Data!", vbInformation, "Information!")
        Else
            Dim harga As Double = tbharga.Text
            Dim sisa_stok As Integer = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value()
            Dim stok_masuk As Integer = tbjumlah.Text
            Dim stok As Integer = sisa_stok + stok_masuk

            Dim strsimpan As String = "UPDATE tb_stok set stok ='" & stok & "', harga = '" & harga & "', tgl_masuk = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' WHERE kode_baju = '" & lbkodestok.Text & "'"
            Call editdata(strsimpan)
            MsgBox("Data Tersimpan!", vbInformation, "Information")
        End If
        FormStok.isigrid()
        isigrid()
        tbjumlah.Text = ""
        tbharga.Text = ""
        lbkodestok.Text = ""
        DateTimePicker1.Value = Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        btrefresh_Click(sender, e)
        FormStok.Show()
    End Sub

    Sub Cari(ByVal str As String)
        Dim strtampil As String = str
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
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

    Private Sub FormTambahStok_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        lbkodestok.Text = ""
        tbserach.Text = ""
        tbjumlah.Text = ""
        tbharga.Text = ""
        DateTimePicker1.Value = Now
        isigrid()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbharga.TextChanged
        If tbharga.Text = "" Or Not IsNumeric(tbharga.Text) Then
            Exit Sub
        End If
        Dim hrga As Integer = tbharga.Text
        tbharga.Text = Format(hrga, "#,###")
        tbharga.SelectionStart = Len(tbharga.Text) 'supaya angkanya berurut dari kiri ke kanan
    End Sub

    
    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "Select * from tb_stok where nama_baju like '%" & tbserach.Text & "%' or kode_baju like '%" & tbserach.Text & "%'"

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

    Private Sub tbserach_Leave(sender As Object, e As EventArgs) Handles tbserach.Leave
        btncari.Focus()
    End Sub

    Private Sub btncari_Leave(sender As Object, e As EventArgs) Handles btncari.Leave
        btrefresh.Focus()
    End Sub

    'Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    '    If DateDiff(DateInterval.Day, DateTimePicker1.Value, Today()) > 3 Then
    '        MsgBox("Tidak dapat menginput transaksi lewat dari 3 hari", vbInformation, "Information")
    '    End If
    'End Sub

    Private Sub tbjumlah_TextChanged(sender As Object, e As EventArgs) Handles tbjumlah.TextChanged
        If tbjumlah.Text = "" Or Not IsNumeric(tbjumlah.Text) Then
            Exit Sub
        End If
        Dim jumlah As Integer = tbjumlah.Text
        tbjumlah.Text = Format(jumlah, "#,###")
        tbjumlah.SelectionStart = Len(tbjumlah.Text)
    End Sub
End Class