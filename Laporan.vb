﻿Imports CrystalDecisions.CrystalReports.Engine
Public Class Laporan

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboLaporan.Items.Clear()
        ComboLaporan.Items.Add("Laporan Stok")
        ComboLaporan.Items.Add("Laporan Penjualan Periodik")
        ComboLaporan.Items.Add("Laporan Penjualan Kategori")
    End Sub


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If ComboLaporan.Text = "" Then
            MsgBox("Mohon Pilih Laporan !", vbCritical, "Pesan")
            ComboLaporan.Focus()

        ElseIf ComboLaporan.SelectedIndex = 0 Then
            Dim tglawal As String = DAwal.Value.Year.ToString + "-" + DAwal.Value.Month.ToString + "-" + DAwal.Value.Day.ToString
            Dim tglakhir As String = DAkhir.Value.Year.ToString + "-" + DAkhir.Value.Month.ToString + "-" + DAkhir.Value.Day.ToString
            Call KonekDB()
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * FROM tb_stok INNER JOIN tb_detail ON tb_stok.kode_baju = tb_detail.kode_baju INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE tgl_transaksi >= '" & tglawal & "' AND tgl_transaksi <= '" & tglakhir & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                LaporanCrystalReport.Show()
                Dim report As New ReportDocument
                report.Load("..\..\LaporanStok.rpt")
                report.SetParameterValue("tgl_awal", tglawal)
                report.SetParameterValue("tgl_akhir", tglakhir)
                LaporanCrystalReport.CrystalReportViewer1.ReportSource = report
                LaporanCrystalReport.CrystalReportViewer1.Refresh()
            Else
                MsgBox("Data pada tanggal tersebut tidak ditemukan!", vbCritical, "Error")

            End If

        ElseIf ComboLaporan.SelectedIndex = 1 Then
            Dim tglawal As String = DAwal.Value.Year.ToString + "-" + DAwal.Value.Month.ToString + "-" + DAwal.Value.Day.ToString
            Dim tglakhir As String = DAkhir.Value.Year.ToString + "-" + DAkhir.Value.Month.ToString + "-" + DAkhir.Value.Day.ToString
            Call KonekDB()
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * FROM tb_detail INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE tgl_transaksi >= '" & tglawal & "' AND tgl_transaksi <= '" & tglakhir & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                LaporanCrystalReport.Show()
                Dim report As New ReportDocument
                report.Load("..\..\TransaksiPenjualan.rpt")
                report.SetParameterValue("tgl_awal", tglawal)
                report.SetParameterValue("tgl_akhir", tglakhir)
                LaporanCrystalReport.CrystalReportViewer1.ReportSource = report
                LaporanCrystalReport.CrystalReportViewer1.Refresh()
            Else
                MsgBox("Data pada tanggal tersebut tidak ditemukan!", vbCritical, "Error")

            End If

        ElseIf ComboLaporan.SelectedIndex = 2 Then
            Dim tglawal As String = DAwal.Value.Year.ToString + "-" + DAwal.Value.Month.ToString + "-" + DAwal.Value.Day.ToString
            Dim tglakhir As String = DAkhir.Value.Year.ToString + "-" + DAkhir.Value.Month.ToString + "-" + DAkhir.Value.Day.ToString
            Call KonekDB()
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            str = "SELECT * FROM tb_stok INNER JOIN tb_detail ON tb_stok.kode_baju = tb_detail.kode_baju INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE tgl_transaksi >= '" & tglawal & "' AND tgl_transaksi <= '" & tglakhir & "'"
            cmd.CommandText = str
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                LaporanCrystalReport.Show()
                Dim report As New ReportDocument
                report.Load("..\..\LaporanKategori.rpt")
                report.SetParameterValue("tgl_awal", tglawal)
                report.SetParameterValue("tgl_akhir", tglakhir)
                LaporanCrystalReport.CrystalReportViewer1.ReportSource = report
                LaporanCrystalReport.CrystalReportViewer1.Refresh()
            Else
                MsgBox("Data pada tanggal tersebut tidak ditemukan!", vbCritical, "Error")

            End If
        End If
    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class