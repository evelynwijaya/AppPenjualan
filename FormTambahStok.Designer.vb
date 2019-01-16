<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahStok
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
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbkodestok = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbserach = New System.Windows.Forms.TextBox()
        Me.btrefresh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.tbharga)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.tbjumlah)
        Me.GroupBox1.Controls.Add(Me.btupdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbkodestok)
        Me.GroupBox1.ForeColor = System.Drawing.Color.BurlyWood
        Me.GroupBox1.Location = New System.Drawing.Point(760, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 441)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tbharga
        '
        Me.tbharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbharga.Location = New System.Drawing.Point(171, 269)
        Me.tbharga.MaxLength = 8
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(400, 29)
        Me.tbharga.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Sienna
        Me.Label7.Location = New System.Drawing.Point(25, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 26)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Sienna
        Me.Label6.Location = New System.Drawing.Point(25, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 26)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Kode Baju"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(171, 213)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(400, 29)
        Me.DateTimePicker1.TabIndex = 13
        '
        'tbjumlah
        '
        Me.tbjumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbjumlah.Location = New System.Drawing.Point(171, 142)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(400, 29)
        Me.tbjumlah.TabIndex = 12
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.Chocolate
        Me.btupdate.Location = New System.Drawing.Point(172, 327)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(148, 41)
        Me.btupdate.TabIndex = 10
        Me.btupdate.Text = "SIMPAN"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(25, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tgl Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Sienna
        Me.Label2.Location = New System.Drawing.Point(25, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jumlah Masuk"
        '
        'lbkodestok
        '
        Me.lbkodestok.AutoSize = True
        Me.lbkodestok.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkodestok.ForeColor = System.Drawing.Color.Sienna
        Me.lbkodestok.Location = New System.Drawing.Point(167, 86)
        Me.lbkodestok.Name = "lbkodestok"
        Me.lbkodestok.Size = New System.Drawing.Size(97, 26)
        Me.lbkodestok.TabIndex = 4
        Me.lbkodestok.Text = "Kode Baju"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Chocolate
        Me.Button1.Location = New System.Drawing.Point(1207, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 41)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "TUTUP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search"
        '
        'tbserach
        '
        Me.tbserach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbserach.Location = New System.Drawing.Point(106, 76)
        Me.tbserach.Name = "tbserach"
        Me.tbserach.Size = New System.Drawing.Size(1107, 29)
        Me.tbserach.TabIndex = 7
        '
        'btrefresh
        '
        Me.btrefresh.ForeColor = System.Drawing.Color.Chocolate
        Me.btrefresh.Location = New System.Drawing.Point(1219, 16)
        Me.btrefresh.Name = "btrefresh"
        Me.btrefresh.Size = New System.Drawing.Size(131, 45)
        Me.btrefresh.TabIndex = 8
        Me.btrefresh.Text = "REFRESH"
        Me.btrefresh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 441)
        Me.DataGridView1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(15, 557)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Hint : Untuk Memilih Data, Double Click pada data yang akan di pilih"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(610, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Data Masuk"
        '
        'btncari
        '
        Me.btncari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.Location = New System.Drawing.Point(1219, 72)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(131, 35)
        Me.btncari.TabIndex = 17
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'FormTambahStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 623)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btrefresh)
        Me.Controls.Add(Me.tbserach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormTambahStok"
        Me.Text = "FormStokMasuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbserach As System.Windows.Forms.TextBox
    Friend WithEvents btrefresh As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbkodestok As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbharga As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
End Class
