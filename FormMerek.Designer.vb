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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.tbnamamerek = New System.Windows.Forms.TextBox()
        Me.tbkodemerek = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.bthapus)
        Me.GroupBox1.Controls.Add(Me.btupdate)
        Me.GroupBox1.Controls.Add(Me.tbnamamerek)
        Me.GroupBox1.Controls.Add(Me.tbkodemerek)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbusername)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(696, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 436)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.Red
        Me.bthapus.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.SeaShell
        Me.bthapus.Location = New System.Drawing.Point(345, 205)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(146, 39)
        Me.bthapus.TabIndex = 9
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.Chocolate
        Me.btupdate.Location = New System.Drawing.Point(181, 205)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(136, 39)
        Me.btupdate.TabIndex = 8
        Me.btupdate.Text = "UPDATE"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'tbnamamerek
        '
        Me.tbnamamerek.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnamamerek.Location = New System.Drawing.Point(181, 127)
        Me.tbnamamerek.Name = "tbnamamerek"
        Me.tbnamamerek.Size = New System.Drawing.Size(437, 29)
        Me.tbnamamerek.TabIndex = 6
        '
        'tbkodemerek
        '
        Me.tbkodemerek.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkodemerek.Location = New System.Drawing.Point(181, 61)
        Me.tbkodemerek.Name = "tbkodemerek"
        Me.tbkodemerek.ReadOnly = True
        Me.tbkodemerek.Size = New System.Drawing.Size(437, 29)
        Me.tbkodemerek.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Sienna
        Me.Label3.Location = New System.Drawing.Point(19, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Merek"
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.Sienna
        Me.lbusername.Location = New System.Drawing.Point(19, 59)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(150, 31)
        Me.lbusername.TabIndex = 3
        Me.lbusername.Text = "Kode Merek"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(664, 436)
        Me.DataGridView1.TabIndex = 1
        '
        'tbcari
        '
        Me.tbcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcari.Location = New System.Drawing.Point(136, 60)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(1064, 29)
        Me.tbcari.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(29, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search"
        '
        'btRefresh
        '
        Me.btRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.ForeColor = System.Drawing.Color.Chocolate
        Me.btRefresh.Location = New System.Drawing.Point(1207, 20)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(120, 32)
        Me.btRefresh.TabIndex = 4
        Me.btRefresh.TabStop = False
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.ForeColor = System.Drawing.Color.Chocolate
        Me.bttutup.Location = New System.Drawing.Point(1207, 553)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(125, 37)
        Me.bttutup.TabIndex = 10
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Chocolate
        Me.btnTambah.Location = New System.Drawing.Point(26, 553)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(120, 37)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(23, 535)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hint : Untuk Memilih Data, Double Click pada data yang akan di pilih"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(593, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 45)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Data Merek"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(1207, 60)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(120, 29)
        Me.btncari.TabIndex = 14
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'FormMerek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 602)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.Label2)
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
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents tbnamamerek As System.Windows.Forms.TextBox
    Friend WithEvents tbkodemerek As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbusername As System.Windows.Forms.Label
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
End Class
