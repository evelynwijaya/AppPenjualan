Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormPEnjualan
    Private Sub FormPEnjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigridjenis()
        isigridsementara()
        autokode()
        Combodiskon.Items.Clear()
        Combodiskon.Items.Add("5")
        Combodiskon.Items.Add("10")
        Combodiskon.Items.Add("15")
        Combodiskon.Items.Add("20")
    End Sub

    Sub isigridjenis()
        Dim strtampil As String = "SELECT kode_baju , nama_baju , harga , stok FROM tb_stok Where stok > 0"
        Dim strtabel As String = "tb_stok"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_stok"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub isigridsementara()
        Dim strtampil As String = "SELECT * FROM tb_sementara"
        Dim strtabel As String = "tb_sementara"
        Call tampildata(strtampil, strtabel)
        DataGridView2.DataSource = (ds.Tables("tb_sementara"))
        DataGridView2.ReadOnly = True
    End Sub

    Sub seleksi()
        Dim strtext As String = "Select * from tb_stok where nama_baju like '%" & tbsearch.Text & "%' or harga like '%" & tbsearch.Text & "%' or kode_baju like '%" & tbsearch.Text & "%'"
        Using cmd2 As New MySqlCommand(strtext, konek)
            Using adapter As New MySqlDataAdapter(cmd2)
                Using DataSet As New DataSet()
                    adapter.Fill(DataSet)
                    DataGridView1.DataSource = DataSet.Tables(0)
                    DataGridView1.ReadOnly = True
                End Using
            End Using
        End Using
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
        lbidtransaksi.Text = "T" & Microsoft.VisualBasic.Right("0000" & no, 4)
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click

        If DataGridView2.CurrentCell.Value Is Nothing Then
            Me.Close()
            Form1.Show()
        Else
            MsgBox("Transaksi Belum Selesai!!", vbCritical, "Warning!")
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        lbkodebaju.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value()
        lbnamabaju.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value()
        lbharga.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value()
    End Sub

    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
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
                Dim SAwal As Integer = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value()
                Dim JAwal As Integer = tbjumlah.Text
                Dim Stok As Integer
                Stok = SAwal - JAwal
                Dim tambah As Integer = tbjumlah.Text + Bawal
                Dim total As Integer = tambah * lbharga.Text

                If JAwal > SAwal Then
                    MsgBox("Stok tidak mencukupi!", vbInformation, "Information")
                Else
                    Dim strupdate1 As String = "Update tb_sementara set jumlah = '" & tambah & "', total = '" & total & "' where id_transaksi = '" & lbidtransaksi.Text & "' and kode_baju = '" & lbkodebaju.Text & "'"
                    Call editdata(strupdate1)

                    Dim strupdate2 As String = "Update tb_stok set stok = '" & Stok & "' where kode_baju = '" & lbkodebaju.Text & "'"
                    Call editdata(strupdate2)

                    isigridjenis()
                    isigridsementara()
                    lbkodebaju.Text = ""
                    lbnamabaju.Text = ""
                    lbharga.Text = ""
                    tbjumlah.Text = ""

                End If

                Dim totalbayar As String = 0
                Dim diskon As Double
                Dim totaldiskon As Double
                For i As Integer = 0 To DataGridView2.RowCount - 1
                    totalbayar += DataGridView2.Rows(i).Cells(5).Value
                Next
                diskon = Combodiskon.Text
                If CheckBox1.Checked = True Then
                    totaldiskon = totalbayar - (totalbayar * (diskon / 100))
                    tbtotal.Text = totaldiskon
                    lbdiscount.Text = totalbayar * (diskon / 100)
                Else
                    tbtotal.Text = totalbayar
                End If
            Else
                Dim SAwal As Integer = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value()
                Dim JAwal As Integer = tbjumlah.Text
                Dim Stok As Integer


                If JAwal > SAwal Then
                    MsgBox("Stok tidak mencukupi!", vbInformation, "Information")
                Else
                    Stok = SAwal - JAwal
                    Dim total As Integer = tbjumlah.Text * lbharga.Text
                    Dim strsimpan As String = "Insert into tb_sementara ( id_transaksi , kode_baju , nama_baju , jumlah , harga , total ) " _
                                              & "Value ('" & lbidtransaksi.Text & "', '" & lbkodebaju.Text & "', '" & lbnamabaju.Text & "', '" & tbjumlah.Text & "', '" & lbharga.Text & "', '" & total & "')"
                    Call simpandata(strsimpan)

                    Dim strupdate2 As String = "Update tb_stok set stok = '" & Stok & "' where kode_baju = '" & lbkodebaju.Text & "'"
                    Call editdata(strupdate2)

                    isigridjenis()
                    isigridsementara()
                    lbkodebaju.Text = ""
                    lbnamabaju.Text = ""
                    lbharga.Text = ""
                    tbjumlah.Text = ""

                    Dim totalbayar As String = 0
                    Dim diskon As Double
                    Dim totaldiskon As Double
                    For i As Integer = 0 To DataGridView2.RowCount - 1
                        totalbayar += DataGridView2.Rows(i).Cells(5).Value
                    Next
                    diskon = Val(Combodiskon.Text)
                    If CheckBox1.Checked = True Then
                        totaldiskon = totalbayar - (totalbayar * (diskon / 100))
                        tbtotal.Text = totaldiskon
                        lbdiscount.Text = totalbayar * (diskon / 100)
                    Else
                        tbtotal.Text = totalbayar
                    End If
                End If
            End If
            End If
    End Sub

    Private Sub Combodiskon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combodiskon.SelectedIndexChanged
        Dim totalbayar As String = 0
        Dim diskon As Double
        For i As Integer = 0 To DataGridView2.RowCount - 1
            totalbayar += DataGridView2.Rows(i).Cells(5).Value
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
        Dim Jumlah1 As Integer = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value()
        Dim kembali As Integer = Jumlah1 + Jumlah2

        Dim strupdate As String = "Update tb_stok set stok = '" & kembali & "' where kode_baju = '" & kodebaju & "'"
        Call editdata(strupdate)

        Dim strdelete As String = "Delete from tb_sementara where kode_baju = '" & kodebaju & "' and id_transaksi = '" & idtransaksi & "'"
        Call hapusdata(strdelete)

        isigridsementara()
        isigridjenis()

        Dim totalbayar As String = 0
        Dim diskon As Double
        For i As Integer = 0 To DataGridView2.RowCount - 1
            totalbayar += DataGridView2.Rows(i).Cells(5).Value
        Next
        diskon = Val(Combodiskon.Text)

        lbdiscount.Text = totalbayar * (diskon / 100)
        totalbayar = totalbayar - (totalbayar * (diskon / 100))
        tbtotal.Text = totalbayar

    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        lbtemp.Text = lbidtransaksi.Text
        If tbbayar.Text = "" Then
            MsgBox("Harap selesaikan Pembayaran!", vbCritical, "Warning")
        Else

            Dim strsimpan1 As String = "Insert into tb_transaksi ( id_transaksi , tgl_transaksi ) " _
                                       & "Value ('" & lbidtransaksi.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
            Call simpandata(strsimpan1)


            Dim i As Integer
            For i = 0 To DataGridView2.RowCount - 2
                lbidtransaksi.Text = DataGridView2.Item(0, i).Value
                lbkodebaju.Text = DataGridView2.Item(1, i).Value
                lbnamabaju.Text = DataGridView2.Item(2, i).Value
                tbjumlah.Text = DataGridView2.Item(3, i).Value
                lbharga.Text = DataGridView2.Item(4, i).Value

                Dim strsimpan2 As String = "Insert into tb_detail ( id_transaksi , kode_baju , nama_baju , jumlah , harga , diskon) " _
                                           & "Value ('" & lbidtransaksi.Text & "','" & lbkodebaju.Text & "','" & lbnamabaju.Text & "','" & tbjumlah.Text & "','" & lbharga.Text & "','" & Combodiskon.Text & "')"
                Call simpandata(strsimpan2)

            Next

            MsgBox("Transaksi Selesai!", vbInformation, "Information")

            Call KonekDB()
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * FROM tb_detail INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE tb_detail.id_transaksi = '" & lbtemp.Text & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                LaporanCrystalReport.Show()
                Dim report As New ReportDocument
                report.Load("..\..\Nota.rpt")
                report.SetParameterValue("kode_trans", lbtemp.Text)
                report.SetParameterValue("totalbayar", tbtotal.Text)
                report.SetParameterValue("bayar", tbbayar.Text)
                report.SetParameterValue("kembalian", tbkembalian.Text)
                report.SetParameterValue("diskon", lbdiscount.Text)
                LaporanCrystalReport.CrystalReportViewer1.ReportSource = report
                LaporanCrystalReport.CrystalReportViewer1.Refresh()
            End If
            Dim delete As String = "Delete from tb_sementara"
            Call hapusdata(delete)
            isigridjenis()
            isigridsementara()
            autokode()
            lbidbaju.Text = ""
            lbkodebaju.Text = ""
            lbnamabaju.Text = ""
            lbharga.Text = ""
            tbjumlah.Text = ""
            tbkembalian.Text = ""
            tbbayar.Text = ""
            tbtotal.Text = ""

        End If
    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        lbkodebaju.Text = ""
        lbnamabaju.Text = ""
        lbharga.Text = ""
        tbjumlah.Text = ""
        tbkembalian.Text = ""
        tbbayar.Text = ""
        isigridjenis()
        isigridsementara()
    End Sub

    Private Sub tbbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbbayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbbayar_TextChanged(sender As Object, e As EventArgs) Handles tbbayar.TextChanged
        If tbbayar.Text = "" Or Not IsNumeric(tbbayar.Text) Then
            Exit Sub
        End If
        Dim bayar As Double = tbbayar.Text - tbtotal.Text
        If bayar = 0 Then
            tbkembalian.Text = 0
        Else
            tbkembalian.Text = Format(bayar, "#,###")
            tbbayar.SelectionStart = Len(tbbayar.Text)
        End If
        
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbsearch.TextChanged
        seleksi()
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
                totalbayar += DataGridView2.Rows(i).Cells(5).Value
            Next
            diskon = Val(Combodiskon.Text)
            If CheckBox1.Checked = True Then
                totaldiskon = totalbayar - (totalbayar * (diskon / 100))
                tbtotal.Text = totaldiskon
                lbdiscount.Text = totaldiskon
            Else
                tbtotal.Text = totalbayar
            End If
        End If
    End Sub


End Class