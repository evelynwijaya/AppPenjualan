<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahDataMerek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahDataMerek))
        Me.kop = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbkodemerek = New System.Windows.Forms.TextBox()
        Me.tbnamamerek = New System.Windows.Forms.TextBox()
        Me.tbsimpan = New System.Windows.Forms.Button()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'kop
        '
        Me.kop.AutoSize = True
        Me.kop.BackColor = System.Drawing.Color.Transparent
        Me.kop.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kop.Location = New System.Drawing.Point(557, 40)
        Me.kop.Name = "kop"
        Me.kop.Size = New System.Drawing.Size(313, 45)
        Me.kop.TabIndex = 1
        Me.kop.Text = "Tambah Data Merek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(410, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kode Merek"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nama Merek"
        '
        'tbkodemerek
        '
        Me.tbkodemerek.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkodemerek.Location = New System.Drawing.Point(565, 186)
        Me.tbkodemerek.Name = "tbkodemerek"
        Me.tbkodemerek.ReadOnly = True
        Me.tbkodemerek.Size = New System.Drawing.Size(332, 29)
        Me.tbkodemerek.TabIndex = 16
        '
        'tbnamamerek
        '
        Me.tbnamamerek.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnamamerek.Location = New System.Drawing.Point(565, 271)
        Me.tbnamamerek.Name = "tbnamamerek"
        Me.tbnamamerek.Size = New System.Drawing.Size(332, 29)
        Me.tbnamamerek.TabIndex = 17
        '
        'tbsimpan
        '
        Me.tbsimpan.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsimpan.Location = New System.Drawing.Point(565, 342)
        Me.tbsimpan.Name = "tbsimpan"
        Me.tbsimpan.Size = New System.Drawing.Size(141, 50)
        Me.tbsimpan.TabIndex = 18
        Me.tbsimpan.Text = "SIMPAN"
        Me.tbsimpan.UseVisualStyleBackColor = True
        '
        'bttutup
        '
        Me.bttutup.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttutup.Location = New System.Drawing.Point(748, 342)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(149, 50)
        Me.bttutup.TabIndex = 33
        Me.bttutup.Text = "TUTUP"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'FormTambahDataMerek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1308, 600)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.tbsimpan)
        Me.Controls.Add(Me.tbnamamerek)
        Me.Controls.Add(Me.tbkodemerek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kop)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FormTambahDataMerek"
        Me.Text = "FormTambahDataMerek"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kop As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbkodemerek As System.Windows.Forms.TextBox
    Friend WithEvents tbnamamerek As System.Windows.Forms.TextBox
    Friend WithEvents tbsimpan As System.Windows.Forms.Button
    Friend WithEvents bttutup As System.Windows.Forms.Button
End Class
