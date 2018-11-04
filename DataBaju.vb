Imports MySql.Data.MySqlClient
Public Class DataBaju

    Private Sub DataBaju_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigridjenis()
        judulgrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ambildata()
        Me.Close()
    End Sub

   

    Sub isigridjenis()
        Dim strtampil As String = "SELECT kode_baju , nama_baju , harga , stok FROM tb_stok Where stok > 0"
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

        DataGridView1.Columns(0).Width = "310"
        DataGridView1.Columns(1).Width = "310"
        DataGridView1.Columns(2).Width = "310"
        DataGridView1.Columns(3).Width = "310"
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

    Sub ambildata()
        DataGridView1.Refresh()
        If DataGridView1.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView1
                baris = .CurrentRow.Index
                FormPEnjualan.lbkodebaju.Text = .CurrentRow.Index
                FormPEnjualan.lbkodebaju.Text = .Item(0, baris).Value
                FormPEnjualan.lbnamabaju.Text = .Item(1, baris).Value
                FormPEnjualan.lbharga.Text = .Item(2, baris).Value
                FormPEnjualan.lbstokawal.Text = .Item(3, baris).Value
            End With
        End If
    End Sub

    Private Sub tbsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbsearch.KeyPress
        If Not ((e.KeyChar Like "[A-Z,a-z]") Or e.KeyChar = vbBack Or (e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FormPEnjualan.Show()
    End Sub
End Class