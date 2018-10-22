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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKategori))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search"
        '
        'btRefresh
        '
        Me.btRefresh.ForeColor = System.Drawing.Color.Chocolate
        Me.btRefresh.Location = New System.Drawing.Point(285, 12)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(64, 23)
        Me.btRefresh.TabIndex = 5
        Me.btRefresh.TabStop = False
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(88, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATA KATEGORI"
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.Sienna
        Me.lbusername.Location = New System.Drawing.Point(19, 68)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(105, 20)
        Me.lbusername.TabIndex = 4
        Me.lbusername.Text = "Kode Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(19, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Kategori"
        '
        'tbkodekategori
        '
        Me.tbkodekategori.Location = New System.Drawing.Point(143, 68)
        Me.tbkodekategori.Name = "tbkodekategori"
        Me.tbkodekategori.ReadOnly = True
        Me.tbkodekategori.Size = New System.Drawing.Size(167, 20)
        Me.tbkodekategori.TabIndex = 6
        '
        'tbnamakategori
        '
        Me.tbnamakategori.Location = New System.Drawing.Point(143, 108)
        Me.tbnamakategori.Name = "tbnamakategori"
        Me.tbnamakategori.Size = New System.Drawing.Size(167, 20)
        Me.tbnamakategori.TabIndex = 7
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.Chocolate
        Me.btupdate.Location = New System.Drawing.Point(143, 134)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(87, 28)
        Me.btupdate.TabIndex = 9
        Me.btupdate.Text = "UPDATE"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.Red
        Me.bthapus.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.SeaShell
        Me.bthapus.Location = New System.Drawing.Point(240, 134)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(70, 28)
        Me.bthapus.TabIndex = 10
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.bthapus)
        Me.GroupBox1.Controls.Add(Me.btupdate)
        Me.GroupBox1.Controls.Add(Me.tbnamakategori)
        Me.GroupBox1.Controls.Add(Me.tbkodekategori)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbusername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(355, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 248)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(334, 192)
        Me.DataGridView1.TabIndex = 7
        '
        'tbsearch
        '
        Me.tbsearch.Location = New System.Drawing.Point(59, 41)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(290, 20)
        Me.tbsearch.TabIndex = 8
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.ForeColor = System.Drawing.Color.Chocolate
        Me.bttutup.Location = New System.Drawing.Point(595, 288)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(87, 28)
        Me.bttutup.TabIndex = 11
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Chocolate
        Me.btnTambah.Location = New System.Drawing.Point(15, 288)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(87, 28)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(12, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Hint : Untuk Memilih Data, Double Click pada data yang akan di pilih"
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(694, 328)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
End Class
