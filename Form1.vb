
Public Class Form1

    Private Sub DataStokToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormStok.Show()
        Me.Hide()

    End Sub

    Private Sub TambahDataStokToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormTambahJenis.Show()
        Me.Hide()

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
        Me.Hide()

    End Sub

    

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
        Me.Hide()
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click
        '  FormKategori.FormKategori_Load(sender, e)
        FormKategori.Show()
        Me.Hide()
    End Sub

    Private Sub MerekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerekToolStripMenuItem.Click
        ' FormMerek.FormMerek_Load(sender, e)
        FormMerek.Show()
        Me.Hide()
    End Sub

    Private Sub StokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokToolStripMenuItem.Click
        ' FormStok.FormStok_Load(sender, e)
        FormStok.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If
    End Sub

    Private Sub TransaksiPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPenjualanToolStripMenuItem.Click
        FormPEnjualan.Show()
        Me.Hide()
    End Sub

    Public Sub DetailTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailTransaksiToolStripMenuItem.Click
        DetailTransaksi.DetailTransaksi_Load(sender, e)
        DetailTransaksi.Show()
        Me.Hide()
    End Sub
End Class