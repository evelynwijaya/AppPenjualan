﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahJenis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahJenis))
        Me.kop = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbsimpan = New System.Windows.Forms.Button()
        Me.tbkodebaju = New System.Windows.Forms.TextBox()
        Me.tbnamabaju = New System.Windows.Forms.TextBox()
        Me.ComboMerek = New System.Windows.Forms.ComboBox()
        Me.ComboKategori = New System.Windows.Forms.ComboBox()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.Harga = New System.Windows.Forms.Label()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'kop
        '
        Me.kop.AutoSize = True
        Me.kop.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kop.Location = New System.Drawing.Point(114, 19)
        Me.kop.Name = "kop"
        Me.kop.Size = New System.Drawing.Size(101, 25)
        Me.kop.TabIndex = 2
        Me.kop.Text = "Jenis Baju"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Kode Baju"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nama Baju"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Merek"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Kategori"
        '
        'tbsimpan
        '
        Me.tbsimpan.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsimpan.Location = New System.Drawing.Point(146, 237)
        Me.tbsimpan.Name = "tbsimpan"
        Me.tbsimpan.Size = New System.Drawing.Size(80, 32)
        Me.tbsimpan.TabIndex = 23
        Me.tbsimpan.Text = "SIMPAN"
        Me.tbsimpan.UseVisualStyleBackColor = True
        '
        'tbkodebaju
        '
        Me.tbkodebaju.Location = New System.Drawing.Point(146, 61)
        Me.tbkodebaju.Name = "tbkodebaju"
        Me.tbkodebaju.Size = New System.Drawing.Size(172, 20)
        Me.tbkodebaju.TabIndex = 24
        '
        'tbnamabaju
        '
        Me.tbnamabaju.Location = New System.Drawing.Point(146, 94)
        Me.tbnamabaju.Name = "tbnamabaju"
        Me.tbnamabaju.Size = New System.Drawing.Size(172, 20)
        Me.tbnamabaju.TabIndex = 25
        '
        'ComboMerek
        '
        Me.ComboMerek.FormattingEnabled = True
        Me.ComboMerek.Location = New System.Drawing.Point(146, 155)
        Me.ComboMerek.Name = "ComboMerek"
        Me.ComboMerek.Size = New System.Drawing.Size(172, 21)
        Me.ComboMerek.TabIndex = 30
        '
        'ComboKategori
        '
        Me.ComboKategori.FormattingEnabled = True
        Me.ComboKategori.Location = New System.Drawing.Point(146, 193)
        Me.ComboKategori.Name = "ComboKategori"
        Me.ComboKategori.Size = New System.Drawing.Size(172, 21)
        Me.ComboKategori.TabIndex = 31
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.Location = New System.Drawing.Point(232, 237)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(80, 32)
        Me.bttutup.TabIndex = 32
        Me.bttutup.Text = "TUTUP"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'Harga
        '
        Me.Harga.AutoSize = True
        Me.Harga.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga.Location = New System.Drawing.Point(25, 126)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(53, 18)
        Me.Harga.TabIndex = 33
        Me.Harga.Text = "Harga"
        '
        'tbharga
        '
        Me.tbharga.Location = New System.Drawing.Point(146, 124)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(172, 20)
        Me.tbharga.TabIndex = 34
        '
        'FormTambahJenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(330, 307)
        Me.Controls.Add(Me.tbharga)
        Me.Controls.Add(Me.Harga)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.ComboKategori)
        Me.Controls.Add(Me.ComboMerek)
        Me.Controls.Add(Me.tbnamabaju)
        Me.Controls.Add(Me.tbkodebaju)
        Me.Controls.Add(Me.tbsimpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kop)
        Me.Name = "FormTambahJenis"
        Me.Text = "FormTambahStok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kop As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbsimpan As System.Windows.Forms.Button
    Friend WithEvents tbkodebaju As System.Windows.Forms.TextBox
    Friend WithEvents tbnamabaju As System.Windows.Forms.TextBox
    Friend WithEvents ComboMerek As System.Windows.Forms.ComboBox
    Friend WithEvents ComboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents Harga As System.Windows.Forms.Label
    Friend WithEvents tbharga As System.Windows.Forms.TextBox
End Class
