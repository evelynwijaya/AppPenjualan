<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMerek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMerek))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.tbnamamerek = New System.Windows.Forms.TextBox()
        Me.tbkodemerek = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.bthapus)
        Me.GroupBox1.Controls.Add(Me.btupdate)
        Me.GroupBox1.Controls.Add(Me.tbnamamerek)
        Me.GroupBox1.Controls.Add(Me.tbkodemerek)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbusername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(335, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.Red
        Me.bthapus.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.SeaShell
        Me.bthapus.Location = New System.Drawing.Point(226, 143)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(87, 28)
        Me.bthapus.TabIndex = 9
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.Chocolate
        Me.btupdate.Location = New System.Drawing.Point(133, 143)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(87, 28)
        Me.btupdate.TabIndex = 8
        Me.btupdate.Text = "UPDATE"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'tbnamamerek
        '
        Me.tbnamamerek.Location = New System.Drawing.Point(133, 104)
        Me.tbnamamerek.Name = "tbnamamerek"
        Me.tbnamamerek.Size = New System.Drawing.Size(180, 20)
        Me.tbnamamerek.TabIndex = 6
        '
        'tbkodemerek
        '
        Me.tbkodemerek.Location = New System.Drawing.Point(133, 67)
        Me.tbkodemerek.Name = "tbkodemerek"
        Me.tbkodemerek.ReadOnly = True
        Me.tbkodemerek.Size = New System.Drawing.Size(180, 20)
        Me.tbkodemerek.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(23, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Merek"
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.Sienna
        Me.lbusername.Location = New System.Drawing.Point(23, 67)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(91, 20)
        Me.lbusername.TabIndex = 3
        Me.lbusername.Text = "Kode Merek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft NeoGothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(115, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DATA MEREK"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(317, 168)
        Me.DataGridView1.TabIndex = 1
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(68, 41)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(261, 20)
        Me.tbcari.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search"
        '
        'btRefresh
        '
        Me.btRefresh.ForeColor = System.Drawing.Color.Chocolate
        Me.btRefresh.Location = New System.Drawing.Point(265, 12)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(64, 23)
        Me.btRefresh.TabIndex = 4
        Me.btRefresh.TabStop = False
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.ForeColor = System.Drawing.Color.Chocolate
        Me.bttutup.Location = New System.Drawing.Point(561, 260)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(87, 28)
        Me.bttutup.TabIndex = 10
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Chocolate
        Me.btnTambah.Location = New System.Drawing.Point(12, 260)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(87, 28)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(15, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hint : Untuk Memilih Data, Double Click pada data yang akan di pilih"
        '
        'FormMerek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(673, 300)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.btRefresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbcari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormMerek"
        Me.Text = "FormMerek"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbnamamerek As System.Windows.Forms.TextBox
    Friend WithEvents tbkodemerek As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbusername As System.Windows.Forms.Label
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
