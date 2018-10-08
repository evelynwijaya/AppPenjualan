Public Class FormDetailTransaksi

    Private Sub FormDetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
    End Sub

    Sub isigrid()
        Dim strtampil As String = "SELECT tb_transaksi.tgl_transaksi , tb_detail.id_transaksi , tb_detail.kode_baju , tb_detail.nama_baju , tb_detail.jumlah " _
                                     & " FROM tb_transaksi INNER JOIN tb_detail ON tb_detail.id_transaksi = tb_transaksi.id_transaksi "
        Dim strtabel As String = "tb_detail"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_detail"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub Cari(ByVal str As String)
        Dim strtampil As String = str
        Dim strtabel As String = "tb_transaksi"
        Call tampildata(strtampil, strtabel)
        DataGridView1.DataSource = (ds.Tables("tb_transaksi"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub seleksi()
        Call KonekDB()
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        str = "SELECT tb_transaksi.tgl_transaksi , tb_detail.id_transaksi , tb_detail.kode_baju , tb_detail.nama_baju , tb_detail.jumlah " _
                & " FROM tb_transaksi INNER JOIN tb_detail ON tb_detail.id_transaksi = tb_transaksi.id_transaksi " _
                & " Where tb_transaksi.tgl_transaksi = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
        cmd.CommandText = str
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Cari(str)
        Else
            Cari(str)
            MsgBox("Tidak ada Transaksi!", vbInformation, "Information")
           
        End If
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        seleksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class