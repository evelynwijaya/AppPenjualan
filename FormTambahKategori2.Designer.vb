<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahKategori2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahKategori2))
        Me.bttutup = New System.Windows.Forms.Button()
        Me.tbsimpan = New System.Windows.Forms.Button()
        Me.tbnamakategori = New System.Windows.Forms.TextBox()
        Me.tbkodekategori = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.kop = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.Location = New System.Drawing.Point(810, 385)
        Me.bttutup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(161, 54)
        Me.bttutup.TabIndex = 32
        Me.bttutup.Text = "TUTUP"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'tbsimpan
        '
        Me.tbsimpan.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsimpan.Location = New System.Drawing.Point(586, 385)
        Me.tbsimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbsimpan.Name = "tbsimpan"
        Me.tbsimpan.Size = New System.Drawing.Size(169, 54)
        Me.tbsimpan.TabIndex = 31
        Me.tbsimpan.Text = "SIMPAN"
        Me.tbsimpan.UseVisualStyleBackColor = True
        '
        'tbnamakategori
        '
        Me.tbnamakategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnamakategori.Location = New System.Drawing.Point(586, 292)
        Me.tbnamakategori.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbnamakategori.Name = "tbnamakategori"
        Me.tbnamakategori.Size = New System.Drawing.Size(574, 26)
        Me.tbnamakategori.TabIndex = 30
        '
        'tbkodekategori
        '
        Me.tbkodekategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkodekategori.Location = New System.Drawing.Point(586, 189)
        Me.tbkodekategori.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbkodekategori.Name = "tbkodekategori"
        Me.tbkodekategori.ReadOnly = True
        Me.tbkodekategori.Size = New System.Drawing.Size(574, 26)
        Me.tbkodekategori.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 292)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nama Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 189)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 29)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Kode Kategori"
        '
        'kop
        '
        Me.kop.AutoSize = True
        Me.kop.BackColor = System.Drawing.Color.Transparent
        Me.kop.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kop.Location = New System.Drawing.Point(578, 56)
        Me.kop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.kop.Name = "kop"
        Me.kop.Size = New System.Drawing.Size(264, 45)
        Me.kop.TabIndex = 26
        Me.kop.Text = "Tambah Kategori"
        '
        'FormTambahKategori2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.tbsimpan)
        Me.Controls.Add(Me.tbnamakategori)
        Me.Controls.Add(Me.tbkodekategori)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kop)
        Me.Name = "FormTambahKategori2"
        Me.Text = "FormTambahKategori2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents tbsimpan As System.Windows.Forms.Button
    Friend WithEvents tbnamakategori As System.Windows.Forms.TextBox
    Friend WithEvents tbkodekategori As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents kop As System.Windows.Forms.Label
End Class
