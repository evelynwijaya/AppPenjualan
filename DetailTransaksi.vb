Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Public Class DetailTransaksi

    Sub isimerek()
        Dim sql As String = "Select id_transaksi from tb_transaksi Order by id_transaksi"
        Call KonekDB()
        da = New Data.Odbc.OdbcDataAdapter(sql, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.ValueMember = "id_transaksi"
            ComboBox1.DisplayMember = "id_transaksi"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub judulgrid()
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
        Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
        objAlternatingCellStyle.BackColor = Color.Pink

        DataGridView1.Columns(0).HeaderText = "ID TRANSAKSI"
        DataGridView1.Columns(1).HeaderText = "Tgl Transaksi"

        DataGridView1.Columns(3).HeaderText = "Kode Baju"
        DataGridView1.Columns(4).HeaderText = "Nama Baju"
        DataGridView1.Columns(5).HeaderText = "Jumlah"
        DataGridView1.Columns(6).HeaderText = "Harga"
        DataGridView1.Columns(7).HeaderText = "Diskon"

        DataGridView1.Columns(0).Width = "150"
        DataGridView1.Columns(1).Width = "120"
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Width = "120"
        DataGridView1.Columns(4).Width = "120"
        DataGridView1.Columns(5).Width = "120"
        DataGridView1.Columns(6).Width = "120"
        DataGridView1.Columns(7).Width = "120"
    End Sub

    Private Sub btnprintnota_Click(sender As Object, e As EventArgs) Handles btnprintnota.Click

        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "SELECT * FROM tb_detail INNER JOIN tb_transaksi ON tb_detail.id_transaksi = tb_transaksi.id_transaksi WHERE tb_detail.id_transaksi = '" & ComboBox1.Text & "' AND tb_transaksi.tgl_transaksi = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
        cmd.CommandText = str
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            LaporanCrystalReport.Show()
            Dim report As New ReportDocument
            report.Load("..\..\Nota.rpt")
            report.SetParameterValue("id_transaksi", ComboBox1.Text)
            LaporanCrystalReport.CrystalReportViewer1.ReportSource = report
            LaporanCrystalReport.CrystalReportViewer1.Refresh()
        End If
    End Sub
    'Sub seleksi()
    '    Dim strtext As String = "SELECT * FROM tb_transaksi INNER JOIN tb_detail ON tb_transaksi.id_transaksi = tb_detail.id_transaksi WHERE tb_transaksi.tgl_transaksi = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tb_transaksi.id_transaksi = '" & ComboBox1.Text & "'"
    '    Using cmd2 As New MySqlCommand(strtext, konek)
    '        Using adapter As New MySqlDataAdapter(cmd2)
    '            Using DataSet As New DataSet()
    '                adapter.Fill(DataSet)
    '                DataGridView1.DataSource = DataSet.Tables(0)
    '                DataGridView1.ReadOnly = True
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    Sub Cari(ByVal str As String)
        Dim strtampil As String = str
        Dim strtabel As String = "tb_detail"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_detail"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "SELECT * FROM tb_transaksi INNER JOIN tb_detail ON tb_transaksi.id_transaksi = tb_detail.id_transaksi WHERE tb_transaksi.tgl_transaksi = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tb_transaksi.id_transaksi = '" & ComboBox1.Text & "'"
        cmd.CommandText = str
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Cari(str)
            judulgrid()
        Else
            MsgBox("Tidak Ada Transaksi!", vbInformation, "Information")
        End If
    End Sub

    Private Sub DetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isimerek()

    End Sub

   
    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub DetailTransaksi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub
End Class