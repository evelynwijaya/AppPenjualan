Public Class Form1

    Private Sub DataStokToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormStok.Show()
        Me.Close()

    End Sub

    Private Sub TambahDataStokToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormTambahJenis.Show()
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = FormatDateTime(Now(), DateFormat.LongDate)
        ToolStripStatusLabel3.Text = FormatDateTime(Now(), DateFormat.LongTime)
        Timer1.Start()
        KonekDB()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = FormatDateTime(Now(), DateFormat.LongDate)
        ToolStripStatusLabel3.Text = FormatDateTime(Now(), DateFormat.LongTime)
    End Sub

    Private Sub TambahStokToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormTambahStok.Show()
        Me.Close()

    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPEnjualan.Show()
        Me.Close()
    End Sub

    Private Sub DetailTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailTransaksiToolStripMenuItem.Click
        FormDetailTransaksi.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
        Me.Close()
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click
        FormKategori.Show()
        Me.Close()
    End Sub

    Private Sub MerekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerekToolStripMenuItem.Click
        FormMerek.Show()
        Me.Close()
    End Sub

    Private Sub StokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokToolStripMenuItem.Click
        FormStok.Show()
        Me.Close()
    End Sub

    Private Sub DiskonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiskonToolStripMenuItem.Click
        FormDiskon.Show()
        Me.Close()
    End Sub
End Class