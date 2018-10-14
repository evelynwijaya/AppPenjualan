<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPEnjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPEnjualan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnext = New System.Windows.Forms.Button()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbharga = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbnamabaju = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbkodebaju = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btrefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbdiscount = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lbidbaju = New System.Windows.Forms.Label()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbkembalian = New System.Windows.Forms.TextBox()
        Me.tbbayar = New System.Windows.Forms.TextBox()
        Me.Combodiskon = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbidtransaksi = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lbtemp = New System.Windows.Forms.Label()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnext)
        Me.GroupBox1.Controls.Add(Me.tbjumlah)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbharga)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbnamabaju)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbkodebaju)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btrefresh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbsearch)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnext
        '
        Me.btnext.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnext.ForeColor = System.Drawing.Color.Chocolate
        Me.btnext.Location = New System.Drawing.Point(274, 395)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(75, 23)
        Me.btnext.TabIndex = 12
        Me.btnext.Text = "Next"
        Me.btnext.UseVisualStyleBackColor = True
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(95, 359)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(100, 20)
        Me.tbjumlah.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Chocolate
        Me.Label8.Location = New System.Drawing.Point(15, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Jumlah :"
        '
        'lbharga
        '
        Me.lbharga.AutoSize = True
        Me.lbharga.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbharga.ForeColor = System.Drawing.Color.Chocolate
        Me.lbharga.Location = New System.Drawing.Point(100, 329)
        Me.lbharga.Name = "lbharga"
        Me.lbharga.Size = New System.Drawing.Size(0, 15)
        Me.lbharga.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Chocolate
        Me.Label6.Location = New System.Drawing.Point(15, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Harga : "
        '
        'lbnamabaju
        '
        Me.lbnamabaju.AutoSize = True
        Me.lbnamabaju.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnamabaju.ForeColor = System.Drawing.Color.Chocolate
        Me.lbnamabaju.Location = New System.Drawing.Point(102, 299)
        Me.lbnamabaju.Name = "lbnamabaju"
        Me.lbnamabaju.Size = New System.Drawing.Size(0, 15)
        Me.lbnamabaju.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chocolate
        Me.Label4.Location = New System.Drawing.Point(15, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama Baju : "
        '
        'lbkodebaju
        '
        Me.lbkodebaju.AutoSize = True
        Me.lbkodebaju.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkodebaju.ForeColor = System.Drawing.Color.Chocolate
        Me.lbkodebaju.Location = New System.Drawing.Point(96, 271)
        Me.lbkodebaju.Name = "lbkodebaju"
        Me.lbkodebaju.Size = New System.Drawing.Size(0, 15)
        Me.lbkodebaju.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(15, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kode Baju :"
        '
        'btrefresh
        '
        Me.btrefresh.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btrefresh.ForeColor = System.Drawing.Color.Chocolate
        Me.btrefresh.Location = New System.Drawing.Point(283, 11)
        Me.btrefresh.Name = "btrefresh"
        Me.btrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btrefresh.TabIndex = 3
        Me.btrefresh.Text = "Refresh"
        Me.btrefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'tbsearch
        '
        Me.tbsearch.Location = New System.Drawing.Point(60, 40)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(298, 20)
        Me.tbsearch.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(352, 190)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lbdiscount)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.lbidbaju)
        Me.GroupBox2.Controls.Add(Me.btsimpan)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbkembalian)
        Me.GroupBox2.Controls.Add(Me.tbbayar)
        Me.GroupBox2.Controls.Add(Me.Combodiskon)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.lbidtransaksi)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbtotal)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 434)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(190, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Rp."
        '
        'lbdiscount
        '
        Me.lbdiscount.AutoSize = True
        Me.lbdiscount.Location = New System.Drawing.Point(214, 333)
        Me.lbdiscount.Name = "lbdiscount"
        Me.lbdiscount.Size = New System.Drawing.Size(49, 13)
        Me.lbdiscount.TabIndex = 21
        Me.lbdiscount.Text = "Discount"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(164, 332)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lbidbaju
        '
        Me.lbidbaju.AutoSize = True
        Me.lbidbaju.Location = New System.Drawing.Point(302, 3)
        Me.lbidbaju.Name = "lbidbaju"
        Me.lbidbaju.Size = New System.Drawing.Size(45, 13)
        Me.lbidbaju.TabIndex = 19
        Me.lbidbaju.Text = "Label13"
        Me.lbidbaju.Visible = False
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.ForeColor = System.Drawing.Color.Chocolate
        Me.btsimpan.Location = New System.Drawing.Point(289, 407)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 18
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Chocolate
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 24)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "TOTAL"
        '
        'tbkembalian
        '
        Me.tbkembalian.Location = New System.Drawing.Point(121, 385)
        Me.tbkembalian.Name = "tbkembalian"
        Me.tbkembalian.ReadOnly = True
        Me.tbkembalian.Size = New System.Drawing.Size(155, 20)
        Me.tbkembalian.TabIndex = 16
        '
        'tbbayar
        '
        Me.tbbayar.Location = New System.Drawing.Point(121, 359)
        Me.tbbayar.Name = "tbbayar"
        Me.tbbayar.Size = New System.Drawing.Size(155, 20)
        Me.tbbayar.TabIndex = 15
        '
        'Combodiskon
        '
        Me.Combodiskon.Enabled = False
        Me.Combodiskon.FormattingEnabled = True
        Me.Combodiskon.Items.AddRange(New Object() {"0", "5", "10"})
        Me.Combodiskon.Location = New System.Drawing.Point(121, 329)
        Me.Combodiskon.Name = "Combodiskon"
        Me.Combodiskon.Size = New System.Drawing.Size(36, 21)
        Me.Combodiskon.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 301)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(155, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'lbidtransaksi
        '
        Me.lbidtransaksi.AutoSize = True
        Me.lbidtransaksi.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbidtransaksi.ForeColor = System.Drawing.Color.Chocolate
        Me.lbidtransaksi.Location = New System.Drawing.Point(118, 282)
        Me.lbidtransaksi.Name = "lbidtransaksi"
        Me.lbidtransaksi.Size = New System.Drawing.Size(94, 15)
        Me.lbidtransaksi.TabIndex = 12
        Me.lbidtransaksi.Text = "lblidtransaksi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Chocolate
        Me.Label11.Location = New System.Drawing.Point(17, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Kembalian"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Chocolate
        Me.Label10.Location = New System.Drawing.Point(17, 360)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Chocolate
        Me.Label9.Location = New System.Drawing.Point(17, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chocolate
        Me.Label7.Location = New System.Drawing.Point(17, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tanggal "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Chocolate
        Me.Label5.Location = New System.Drawing.Point(17, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ID Transaksi "
        '
        'tbtotal
        '
        Me.tbtotal.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotal.ForeColor = System.Drawing.Color.Red
        Me.tbtotal.Location = New System.Drawing.Point(94, 19)
        Me.tbtotal.Multiline = True
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.Size = New System.Drawing.Size(264, 36)
        Me.tbtotal.TabIndex = 6
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 66)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(352, 190)
        Me.DataGridView2.TabIndex = 1
        '
        'lbtemp
        '
        Me.lbtemp.AutoSize = True
        Me.lbtemp.Location = New System.Drawing.Point(584, 452)
        Me.lbtemp.Name = "lbtemp"
        Me.lbtemp.Size = New System.Drawing.Size(38, 13)
        Me.lbtemp.TabIndex = 21
        Me.lbtemp.Text = "lbtemp"
        Me.lbtemp.Visible = False
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.ForeColor = System.Drawing.Color.Chocolate
        Me.bttutup.Location = New System.Drawing.Point(671, 452)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(75, 23)
        Me.bttutup.TabIndex = 4
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(336, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "TRANSAKSI"
        '
        'FormPEnjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(758, 478)
        Me.Controls.Add(Me.lbtemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bttutup)
        Me.Name = "FormPEnjualan"
        Me.Text = "FormPEnjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnext As System.Windows.Forms.Button
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbharga As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbnamabaju As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbkodebaju As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btrefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbkembalian As System.Windows.Forms.TextBox
    Friend WithEvents tbbayar As System.Windows.Forms.TextBox
    Friend WithEvents Combodiskon As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbidtransaksi As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lbidbaju As System.Windows.Forms.Label
    Friend WithEvents lbtemp As System.Windows.Forms.Label
    Friend WithEvents lbdiscount As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
