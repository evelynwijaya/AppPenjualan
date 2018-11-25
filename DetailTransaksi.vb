Imports CrystalDecisions.CrystalReports.Engine

Public Class DetailTransaksi
    Public Sub DetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isitahun()
        ComboBulan.Items.Clear()
        ComboBulan.Items.Add("Januari")
        ComboBulan.Items.Add("Februari")
        ComboBulan.Items.Add("Maret")
        ComboBulan.Items.Add("April")
        ComboBulan.Items.Add("Mei")
        ComboBulan.Items.Add("Juni")
        ComboBulan.Items.Add("July")
        ComboBulan.Items.Add("Agustus")
        ComboBulan.Items.Add("September")
        ComboBulan.Items.Add("Oktober")
        ComboBulan.Items.Add("November")
        ComboBulan.Items.Add("Desenmber")
        DataGridView1.DataSource = ""
        DataGridView2.DataSource = ""
        lbidtransaksi.Text = ""
        ComboBulan.Text = ""
        ComboTahun.Text = ""
    End Sub
   
    Sub isitahun()
        Dim sql As String = "SELECT DISTINCT YEAR(tgl_transaksi) from tb_transaksi "
        Call KonekDB()
        da = New Data.Odbc.OdbcDataAdapter(sql, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            ComboTahun.DataSource = dt
            ComboTahun.ValueMember = "YEAR(tgl_transaksi)"
            ComboTahun.DisplayMember = "YEAR(tgl_transaksi)"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub judulgrid1()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView1.Columns(0).HeaderText = "ID TRANSAKSI"
        DataGridView1.Columns(1).HeaderText = "Tgl Transaksi"
        DataGridView1.Columns(2).HeaderText = "Total"
        DataGridView1.Columns(3).HeaderText = "Diskon"


        DataGridView1.Columns(0).Width = "300"
        DataGridView1.Columns(1).Width = "300"
        DataGridView1.Columns(2).Width = "300"
        DataGridView1.Columns(3).Width = "300"

    End Sub
    Sub judulgrid2()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView2.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView2.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView2.Columns(0).HeaderText = "Kode Baju"
        DataGridView2.Columns(1).HeaderText = "Nama Baju"
        DataGridView2.Columns(2).HeaderText = "Jumlah"
        DataGridView2.Columns(3).HeaderText = "Harga"
        DataGridView2.Columns(4).HeaderText = "Subtotal"

        DataGridView2.Columns(0).Width = "250"
        DataGridView2.Columns(1).Width = "250"
        DataGridView2.Columns(2).Width = "250"
        DataGridView2.Columns(3).Width = "250"
        DataGridView2.Columns(4).Width = "250"

    End Sub

    Public Sub btnprintnota_Click(sender As Object, e As EventArgs) Handles btnprintnota.Click

        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "SELECT * FROM tb_detail INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE tb_detail.id_transaksi = '" & lbidtransaksi.Text & "'"
        cmd.CommandText = str
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            LaporanCrystalReport.Show()
            Dim report As New ReportDocument
            report.Load("..\..\Nota.rpt")
            report.SetParameterValue("id_transaksi", lbidtransaksi.Text)
            LaporanCrystalReport.CrystalReportViewer1.ReportSource = report
            LaporanCrystalReport.CrystalReportViewer1.Refresh()
        Else
            MsgBox("Data pada tanggal tersebut tidak ditemukan!", vbCritical, "Error")


        End If
    End Sub

    Sub Cari(ByVal str As String)
        Dim strtampil As String = str
        Dim strtabel As String = "tb_detail"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_detail"))
        DataGridView1.ReadOnly = True
    End Sub
    Sub Detailcari(ByVal str As String)
        Dim strtampil As String = str
        Dim strtabel As String = "tb_detail"
        Call tampildata(strtampil, strtabel)
        DataGridView2.DataSource = (ds.Tables("tb_detail"))
        DataGridView2.ReadOnly = True
    End Sub

    Public Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim bulan As Integer

        Select Case ComboBulan.Text
            Case "Januari"
                bulan = 1
            Case "Februari"
                bulan = 2
            Case "Maret"
                bulan = 3
            Case "April"
                bulan = 4
            Case "Mei"
                bulan = 5
            Case "Juni"
                bulan = 6
            Case "July"
                bulan = 7
            Case "Agustus"
                bulan = 8
            Case "September"
                bulan = 9
            Case "Oktober"
                bulan = 10
            Case "November"
                bulan = 11
            Case "Desember"
                bulan = 12

        End Select

        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "SELECT DISTINCT tb_transaksi.id_transaksi, tb_transaksi.tgl_transaksi,tb_detail.total, tb_detail.diskon FROM tb_detail INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE MONTH(tgl_transaksi) = '" & bulan & "' and YEAR(tgl_transaksi) = '" & ComboTahun.Text & "'"
        cmd.CommandText = str
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Cari(str)
            judulgrid1()
        Else
            MsgBox("Tidak Ada Transaksi!", vbInformation, "Information")
        End If
    End Sub

    Public Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Public Sub DetailTransaksi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub

    Public Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        lbidtransaksi.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value

        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "SELECT tb_detail.kode_baju, tb_detail.nama_baju, tb_detail.jumlah, tb_detail.harga, tb_detail.subtotal FROM tb_detail INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE tb_detail.id_transaksi = '" & lbidtransaksi.Text & "'"
        cmd.CommandText = str
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Detailcari(str)
            judulgrid2()
        Else
            MsgBox("Tidak Ada Transaksi!", vbInformation, "Information")
        End If
    End Sub
End Class