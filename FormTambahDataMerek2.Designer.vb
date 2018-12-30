<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahDataMerek2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahDataMerek2))
        Me.bttutup = New System.Windows.Forms.Button()
        Me.tbsimpan = New System.Windows.Forms.Button()
        Me.tbnamamerek = New System.Windows.Forms.TextBox()
        Me.tbkodemerek = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.kop = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.Location = New System.Drawing.Point(780, 351)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(149, 50)
        Me.bttutup.TabIndex = 40
        Me.bttutup.Text = "TUTUP"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'tbsimpan
        '
        Me.tbsimpan.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsimpan.Location = New System.Drawing.Point(597, 351)
        Me.tbsimpan.Name = "tbsimpan"
        Me.tbsimpan.Size = New System.Drawing.Size(141, 50)
        Me.tbsimpan.TabIndex = 39
        Me.tbsimpan.Text = "SIMPAN"
        Me.tbsimpan.UseVisualStyleBackColor = True
        '
        'tbnamamerek
        '
        Me.tbnamamerek.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnamamerek.Location = New System.Drawing.Point(597, 280)
        Me.tbnamamerek.Name = "tbnamamerek"
        Me.tbnamamerek.Size = New System.Drawing.Size(332, 29)
        Me.tbnamamerek.TabIndex = 38
        '
        'tbkodemerek
        '
        Me.tbkodemerek.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkodemerek.Location = New System.Drawing.Point(597, 195)
        Me.tbkodemerek.Name = "tbkodemerek"
        Me.tbkodemerek.ReadOnly = True
        Me.tbkodemerek.Size = New System.Drawing.Size(332, 29)
        Me.tbkodemerek.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(442, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nama Merek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(442, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Kode Merek"
        '
        'kop
        '
        Me.kop.AutoSize = True
        Me.kop.BackColor = System.Drawing.Color.Transparent
        Me.kop.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kop.Location = New System.Drawing.Point(589, 49)
        Me.kop.Name = "kop"
        Me.kop.Size = New System.Drawing.Size(313, 45)
        Me.kop.TabIndex = 34
        Me.kop.Text = "Tambah Data Merek"
        '
        'FormTambahDataMerek2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.tbsimpan)
        Me.Controls.Add(Me.tbnamamerek)
        Me.Controls.Add(Me.tbkodemerek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kop)
        Me.Name = "FormTambahDataMerek2"
        Me.Text = "FormTambahDataMerek2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents tbsimpan As System.Windows.Forms.Button
    Friend WithEvents tbnamamerek As System.Windows.Forms.TextBox
    Friend WithEvents tbkodemerek As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents kop As System.Windows.Forms.Label
End Class
