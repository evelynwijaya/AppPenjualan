Imports System.Data.Odbc

Public Class FormPEnjualan
    Private Sub FormPEnjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigridsementara()
        autokode()
        judulgrid()
        Combodiskon.Items.Clear()
        Combodiskon.Items.Add("5")
        Combodiskon.Items.Add("10")
        Combodiskon.Items.Add("15")
        Combodiskon.Items.Add("20")
    End Sub


    Sub isigridsementara()
        Dim strtampil As String = "SELECT * FROM tb_sementara"
        Dim strtabel As String = "tb_sementara"
        Call tampildata(strtampil, strtabel)
        DataGridView2.DataSource = (ds.Tables("tb_sementara"))
        DataGridView2.ReadOnly = True
    End Sub

    Sub judulgrid()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView2.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView2.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView2.Columns(0).HeaderText = "ID Transaksi"
        DataGridView2.Columns(1).HeaderText = "Kode Baju"
        DataGridView2.Columns(2).HeaderText = "Nama Baju"
        DataGridView2.Columns(3).HeaderText = "Jumlah"
        DataGridView2.Columns(4).Visible = False
        DataGridView2.Columns(5).HeaderText = "Harga"
        DataGridView2.Columns(6).HeaderText = "SUbtotal"

        DataGridView2.Columns(0).Width = "200"
        DataGridView2.Columns(1).Width = "200"
        DataGridView2.Columns(2).Width = "200"
        DataGridView2.Columns(3).Width = "200"
        DataGridView2.Columns(5).Width = "200"
        DataGridView2.Columns(6).Width = "200"
    End Sub


    Sub autokode()
        Dim SQL As String
        Dim no As Long
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQL = "SELECT * FROM tb_transaksi WHERE id_transaksi in (SELECT MAX(id_transaksi) FROM tb_transaksi)"
        cmd.CommandText = SQL
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(0), 4)) + 1
        End If
        lbidtransaksi.Text = "T" & Format(DateTimePicker1.Value, "yyyyMMdd") & Microsoft.VisualBasic.Right("0000" & no, 4)
    End Sub


    Private Sub Combodiskon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combodiskon.SelectedIndexChanged
        Dim totalbayar As String = 0
        Dim diskon As Double
        For i As Integer = 0 To DataGridView2.RowCount - 1
            totalbayar += DataGridView2.Rows(i).Cells(6).Value
        Next
        diskon = Val(Combodiskon.Text)

        lbdiscount.Text = totalbayar * (diskon / 100)
        totalbayar = totalbayar - (totalbayar * (diskon / 100))
        tbtotal.Text = totalbayar
    End Sub
    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim kodebaju As String = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(1).Value()
        Dim idtransaksi As String = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(0).Value()
        Dim Jumlah2 As Integer = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(3).Value()
        Dim stokawal As Integer = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(4).Value()
        Dim kembali As Integer = stokawal + Jumlah2

        Dim strupdate As String = "Update tb_stok set stok = '" & kembali & "' where kode_baju = '" & kodebaju & "'"
        Call editdata(strupdate)

        Dim strdelete As String = "Delete from tb_sementara where kode_baju = '" & kodebaju & "' and id_transaksi = '" & idtransaksi & "'"
        Call hapusdata(strdelete)

        isigridsementara()


        Dim totalbayar As String = 0
        Dim diskon As Double
        For i As Integer = 0 To DataGridView2.RowCount - 1
            totalbayar += DataGridView2.Rows(i).Cells(6).Value
        Next
        diskon = Val(Combodiskon.Text)

        lbdiscount.Text = totalbayar * (diskon / 100)
        totalbayar = totalbayar - (totalbayar * (diskon / 100))
        tbtotal.Text = totalbayar

    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        lbtemp.Text = lbidtransaksi.Text
        Dim strsimpan1 As String = "Insert into tb_transaksi ( id_transaksi , tgl_transaksi ) " _
                                   & "Value ('" & lbidtransaksi.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        Call simpandata(strsimpan1)


        Dim i As Integer
        For i = 0 To DataGridView2.RowCount - 2
            lbidtransaksi.Text = DataGridView2.Item(0, i).Value
            lbkodebaju.Text = DataGridView2.Item(1, i).Value
            lbnamabaju.Text = DataGridView2.Item(2, i).Value
            tbjumlah.Text = DataGridView2.Item(3, i).Value
            lbharga.Text = DataGridView2.Item(5, i).Value
            Dim subtotal As Integer = DataGridView2.Item(6, i).Value
            Dim strsimpan2 As String = "Insert into tb_detail ( id_transaksi , kode_baju , nama_baju , jumlah , harga , diskon, subtotal, total) " _
                                       & "Value ('" & lbidtransaksi.Text & "','" & lbkodebaju.Text & "','" & lbnamabaju.Text & "','" & tbjumlah.Text & "','" & lbharga.Text & "','" & lbdiscount.Text & "','" & subtotal & "','" & tbtotal.Text & "')"
            Call simpandata(strsimpan2)

        Next

        MsgBox("Transaksi Selesai!", vbInformation, "Information")

        Dim delete As String = "Delete from tb_sementara"
        Call hapusdata(delete)
        isigridsementara()
        autokode()
        lbidbaju.Text = ""
        lbkodebaju.Text = ""
        lbstokawal.Text = ""
        lbnamabaju.Text = ""
        lbharga.Text = ""
        tbjumlah.Text = ""
        lbdiscount.Text = ""

        tbtotal.Text = ""
        CheckBox1.Checked = False

    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        lbkodebaju.Text = ""
        lbnamabaju.Text = ""
        lbstokawal.Text = ""
        lbharga.Text = ""
        tbjumlah.Text = ""
        isigridsementara()
    End Sub

    Private Sub tbbayar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Combodiskon.Enabled = True
        Else
            Combodiskon.Enabled = False
            Dim totalbayar As String = 0
            Dim diskon As Double
            Dim totaldiskon As Double
            For i As Integer = 0 To DataGridView2.RowCount - 1
                totalbayar += DataGridView2.Rows(i).Cells(6).Value
            Next
            diskon = Val(Combodiskon.Text)
            If CheckBox1.Checked = True Then
                totaldiskon = totalbayar - (totalbayar * (diskon / 100))
                tbtotal.Text = totaldiskon
                lbdiscount.Text = totaldiskon
            Else
                tbtotal.Text = totalbayar
                lbdiscount.Text = 0
            End If
        End If
    End Sub
    
    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        If DataGridView2.RowCount <= 1 Then
            btrefresh_Click(sender, e)
            Me.Hide()
            Form1.Show()

        ElseIf MsgBox("Transaksi belum selesai! Apakah anda yakin ingin keluar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Question") = MsgBoxResult.Yes Then
            Dim kodebaju As String = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(1).Value()
            Dim idtransaksi As String = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(0).Value()

            Dim i As Integer
            For i = 0 To DataGridView2.RowCount - 2
                lbkodebaju.Text = DataGridView2.Item(1, i).Value
                Dim Jumlah2 As Integer = DataGridView2.Item(3, i).Value
                Dim Jumlah1 As Integer = DataGridView2.Item(4, i).Value
                Dim kembali As Integer = Jumlah1 + Jumlah2
                Dim strupdate As String = "Update tb_stok set stok = '" & kembali & "' where kode_baju = '" & lbkodebaju.Text & "'"
                Call editdata(strupdate)
            Next
            Dim strhapus As String = "Delete from tb_sementara"
            Call hapusdata(strhapus)
            isigridsementara()
            tbtotal.Text = ""
            Me.Hide()
            Form1.Show()
        End If
    End Sub


    Sub ambildata()
        DataGridView2.Refresh()
        If DataGridView2.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView2
                baris = .CurrentRow.Index
                Me.lbkodebaju.Text = .CurrentRow.Index
                Me.lbkodebaju.Text = .Item(0, baris).Value
                Me.lbnamabaju.Text = .Item(1, baris).Value
                Me.lbharga.Text = .Item(3, baris).Value
                Me.lbstokawal.Text = .Item(6, baris).Value
            End With
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btpilih.Click
        DataBaju.Show()
    End Sub

    Private Sub tbjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormPEnjualan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Dim kodebaju As String = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(1).Value()
            Dim idtransaksi As String = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(0).Value()

            Dim i As Integer
            For i = 0 To DataGridView2.RowCount - 2
                lbkodebaju.Text = DataGridView2.Item(1, i).Value
                Dim Jumlah2 As Integer = DataGridView2.Item(3, i).Value
                Dim Jumlah1 As Integer = DataGridView2.Item(4, i).Value
                Dim kembali As Integer = Jumlah1 + Jumlah2
                Dim strupdate As String = "Update tb_stok set stok = '" & kembali & "' where kode_baju = '" & lbkodebaju.Text & "'"
                Call editdata(strupdate)
            Next
            Dim strhapus As String = "Delete from tb_sementara"
            Call hapusdata(strhapus)
            isigridsementara()
            tbtotal.Text = ""
            Application.ExitThread()

        End If
    End Sub

    Private Sub btnext_Click_1(sender As Object, e As EventArgs) Handles btnext.Click
        If lbkodebaju.Text = "" Or tbjumlah.Text = "" Then
            MsgBox("Input Jumlah terlebih dahulu!", vbInformation, "Information")
            tbjumlah.Focus()
        Else
            Call KonekDB()
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            str = "Select * from tb_sementara where kode_baju = '" & lbkodebaju.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim Bawal As Integer = DataGridView2.Rows.Item(DataGridView2.CurrentRow.Index).Cells(3).Value()
                Dim SAwal As Integer = lbstokawal.Text
                Dim JAwal As Integer = tbjumlah.Text
                Dim Stok As Integer
                Stok = SAwal - JAwal
                Dim tambah As Integer = tbjumlah.Text + Bawal
                Dim subtotal As Integer = tambah * lbharga.Text

                If JAwal > SAwal Then
                    MsgBox("Stok tidak mencukupi!", vbInformation, "Information")
                Else
                    Dim strupdate1 As String = "Update tb_sementara set jumlah = '" & tambah & "', subtotal = '" & subtotal & "'where id_transaksi = '" & lbidtransaksi.Text & "' and kode_baju = '" & lbkodebaju.Text & "'"
                    Call editdata(strupdate1)

                    Dim strupdate2 As String = "Update tb_stok set stok = '" & Stok & "' where kode_baju = '" & lbkodebaju.Text & "'"
                    Call editdata(strupdate2)

                    isigridsementara()
                    lbkodebaju.Text = ""
                    lbnamabaju.Text = ""
                    lbharga.Text = ""
                    lbstokawal.Text = ""
                    tbjumlah.Text = ""

                End If

                Dim totalbayar As String = 0

                For i As Integer = 0 To DataGridView2.RowCount - 1
                    totalbayar += DataGridView2.Rows(i).Cells(6).Value
                Next

                tbtotal.Text = totalbayar

            Else
                Dim SAwal As Integer = lbstokawal.Text
                Dim JAwal As Integer = tbjumlah.Text
                Dim Stok As Integer


                If JAwal > SAwal Then
                    MsgBox("Stok tidak mencukupi!", vbInformation, "Information")
                Else
                    Stok = SAwal - JAwal
                    Dim subtotal As Integer = tbjumlah.Text * lbharga.Text
                    Dim strsimpan As String = "Insert into tb_sementara ( id_transaksi , kode_baju , nama_baju , jumlah , harga , subtotal , stokawal ) " _
                                              & "Value ('" & lbidtransaksi.Text & "', '" & lbkodebaju.Text & "', '" & lbnamabaju.Text & "', '" & tbjumlah.Text & "', '" & lbharga.Text & "', '" & subtotal & "', '" & Stok & "')"
                    Call simpandata(strsimpan)

                    Dim strupdate2 As String = "Update tb_stok set stok = '" & Stok & "' where kode_baju = '" & lbkodebaju.Text & "'"
                    Call editdata(strupdate2)

                    isigridsementara()
                    lbkodebaju.Text = ""
                    lbnamabaju.Text = ""
                    lbstokawal.Text = ""
                    lbharga.Text = ""
                    tbjumlah.Text = ""

                    Dim totalbayar As String = 0

                    For i As Integer = 0 To DataGridView2.RowCount - 1
                        totalbayar += DataGridView2.Rows(i).Cells(6).Value
                    Next

                    tbtotal.Text = totalbayar

                End If
            End If
        End If
    End Sub

    Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles btpilih.Leave
        tbjumlah.Focus()
    End Sub

    Private Sub tbjumlah_Leave(sender As Object, e As EventArgs) Handles tbjumlah.Leave
        btnext.Focus()
    End Sub



    Private Sub tbjumlah_TextChanged(sender As Object, e As EventArgs) Handles tbjumlah.TextChanged
        If tbjumlah.Text = "" Or Not IsNumeric(tbjumlah.Text) Then
            Exit Sub
        End If
        Dim hrga As Integer = tbjumlah.Text
        tbjumlah.Text = Format(hrga, "#,###")
        tbjumlah.SelectionStart = Len(tbjumlah.Text) 'supaya angkanya berurut dari kiri ke kanan
    End Sub

    
End Class