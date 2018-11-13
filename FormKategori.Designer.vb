<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategori
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbkodekategori = New System.Windows.Forms.TextBox()
        Me.tbnamakategori = New System.Windows.Forms.TextBox()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search"
        '
        'btRefresh
        '
        Me.btRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.ForeColor = System.Drawing.Color.Chocolate
        Me.btRefresh.Location = New System.Drawing.Point(1229, 27)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(121, 45)
        Me.btRefresh.TabIndex = 5
        Me.btRefresh.TabStop = False
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.Sienna
        Me.lbusername.Location = New System.Drawing.Point(22, 69)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(144, 24)
        Me.lbusername.TabIndex = 4
        Me.lbusername.Text = "Kode Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(22, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Kategori"
        '
        'tbkodekategori
        '
        Me.tbkodekategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkodekategori.Location = New System.Drawing.Point(219, 66)
        Me.tbkodekategori.Name = "tbkodekategori"
        Me.tbkodekategori.ReadOnly = True
        Me.tbkodekategori.Size = New System.Drawing.Size(355, 29)
        Me.tbkodekategori.TabIndex = 6
        '
        'tbnamakategori
        '
        Me.tbnamakategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnamakategori.Location = New System.Drawing.Point(219, 132)
        Me.tbnamakategori.Name = "tbnamakategori"
        Me.tbnamakategori.Size = New System.Drawing.Size(355, 29)
        Me.tbnamakategori.TabIndex = 7
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.Chocolate
        Me.btupdate.Location = New System.Drawing.Point(221, 190)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(113, 44)
        Me.btupdate.TabIndex = 9
        Me.btupdate.Text = "UPDATE"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.Red
        Me.bthapus.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.SeaShell
        Me.bthapus.Location = New System.Drawing.Point(365, 190)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(113, 44)
        Me.bthapus.TabIndex = 10
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.bthapus)
        Me.GroupBox1.Controls.Add(Me.btupdate)
        Me.GroupBox1.Controls.Add(Me.tbnamakategori)
        Me.GroupBox1.Controls.Add(Me.tbkodekategori)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbusername)
        Me.GroupBox1.Location = New System.Drawing.Point(763, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 375)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 375)
        Me.DataGridView1.TabIndex = 7
        '
        'tbsearch
        '
        Me.tbsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.Location = New System.Drawing.Point(106, 78)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(1119, 29)
        Me.tbsearch.TabIndex = 8
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.ForeColor = System.Drawing.Color.Chocolate
        Me.bttutup.Location = New System.Drawing.Point(1246, 538)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(111, 45)
        Me.bttutup.TabIndex = 11
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Chocolate
        Me.btnTambah.Location = New System.Drawing.Point(15, 538)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(115, 45)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(12, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Hint : Untuk Memilih Data, Double Click pada data yang akan di pilih"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(590, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 45)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Data Kategori"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(1231, 78)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(119, 29)
        Me.btncari.TabIndex = 15
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 595)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btRefresh)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKategori"
        Me.Text = "FormKategori"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents lbusername As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbkodekategori As System.Windows.Forms.TextBox
    Friend WithEvents tbnamakategori As System.Windows.Forms.TextBox
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
End Class
