<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.ComboKategori = New System.Windows.Forms.ComboBox()
        Me.ComboMerek = New System.Windows.Forms.ComboBox()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.tbnamabaju = New System.Windows.Forms.TextBox()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbkodestok = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbserach = New System.Windows.Forms.TextBox()
        Me.btrefresh = New System.Windows.Forms.Button()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.bthapus)
        Me.GroupBox1.Controls.Add(Me.ComboKategori)
        Me.GroupBox1.Controls.Add(Me.ComboMerek)
        Me.GroupBox1.Controls.Add(Me.tbharga)
        Me.GroupBox1.Controls.Add(Me.tbnamabaju)
        Me.GroupBox1.Controls.Add(Me.btupdate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbkodestok)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(790, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 413)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Sienna
        Me.Label8.Location = New System.Drawing.Point(21, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Kode Stok"
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.Red
        Me.bthapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.SeaShell
        Me.bthapus.Location = New System.Drawing.Point(303, 307)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(101, 39)
        Me.bthapus.TabIndex = 8
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'ComboKategori
        '
        Me.ComboKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboKategori.FormattingEnabled = True
        Me.ComboKategori.Location = New System.Drawing.Point(167, 246)
        Me.ComboKategori.Name = "ComboKategori"
        Me.ComboKategori.Size = New System.Drawing.Size(370, 32)
        Me.ComboKategori.TabIndex = 16
        '
        'ComboMerek
        '
        Me.ComboMerek.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMerek.FormattingEnabled = True
        Me.ComboMerek.Location = New System.Drawing.Point(167, 143)
        Me.ComboMerek.Name = "ComboMerek"
        Me.ComboMerek.Size = New System.Drawing.Size(370, 32)
        Me.ComboMerek.TabIndex = 15
        '
        'tbharga
        '
        Me.tbharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbharga.Location = New System.Drawing.Point(167, 196)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(370, 29)
        Me.tbharga.TabIndex = 14
        '
        'tbnamabaju
        '
        Me.tbnamabaju.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnamabaju.Location = New System.Drawing.Point(167, 88)
        Me.tbnamabaju.Name = "tbnamabaju"
        Me.tbnamabaju.Size = New System.Drawing.Size(370, 29)
        Me.tbnamabaju.TabIndex = 11
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.Chocolate
        Me.btupdate.Location = New System.Drawing.Point(167, 307)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(130, 39)
        Me.btupdate.TabIndex = 9
        Me.btupdate.Text = "UPDATE"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(21, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Kategori"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Sienna
        Me.Label6.Location = New System.Drawing.Point(21, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(21, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Merek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(21, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Baju"
        '
        'lbkodestok
        '
        Me.lbkodestok.AutoSize = True
        Me.lbkodestok.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkodestok.ForeColor = System.Drawing.Color.Sienna
        Me.lbkodestok.Location = New System.Drawing.Point(163, 37)
        Me.lbkodestok.Name = "lbkodestok"
        Me.lbkodestok.Size = New System.Drawing.Size(98, 26)
        Me.lbkodestok.TabIndex = 3
        Me.lbkodestok.Text = "Kode Stok"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(762, 413)
        Me.DataGridView1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(21, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Search"
        '
        'tbserach
        '
        Me.tbserach.Location = New System.Drawing.Point(115, 68)
        Me.tbserach.Name = "tbserach"
        Me.tbserach.Size = New System.Drawing.Size(1224, 20)
        Me.tbserach.TabIndex = 6
        '
        'btrefresh
        '
        Me.btrefresh.ForeColor = System.Drawing.Color.Chocolate
        Me.btrefresh.Location = New System.Drawing.Point(1231, 20)
        Me.btrefresh.Name = "btrefresh"
        Me.btrefresh.Size = New System.Drawing.Size(106, 42)
        Me.btrefresh.TabIndex = 7
        Me.btrefresh.Text = "REFRESH"
        Me.btrefresh.UseVisualStyleBackColor = True
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.ForeColor = System.Drawing.Color.Chocolate
        Me.bttutup.Location = New System.Drawing.Point(1231, 547)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(118, 39)
        Me.bttutup.TabIndex = 9
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'btnRestock
        '
        Me.btnRestock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestock.ForeColor = System.Drawing.Color.Chocolate
        Me.btnRestock.Location = New System.Drawing.Point(144, 547)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(121, 39)
        Me.btnRestock.TabIndex = 10
        Me.btnRestock.Text = "RESTOCK"
        Me.btnRestock.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Chocolate
        Me.btnTambah.Location = New System.Drawing.Point(15, 547)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(106, 39)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(12, 520)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Hint : Untuk Memilih Data, Double Click pada data yang akan di pilih"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(658, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 45)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Data Stok"
        '
        'FormStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1361, 598)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.btrefresh)
        Me.Controls.Add(Me.tbserach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FormStok"
        Me.Text = "FormStok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbserach As System.Windows.Forms.TextBox
    Friend WithEvents btrefresh As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbkodestok As System.Windows.Forms.Label
    Friend WithEvents ComboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents ComboMerek As System.Windows.Forms.ComboBox
    Friend WithEvents tbnamabaju As System.Windows.Forms.TextBox
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents tbharga As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents btnRestock As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
