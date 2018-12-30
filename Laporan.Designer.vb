<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Me.ComboLaporan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DAwal = New System.Windows.Forms.DateTimePicker()
        Me.DAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboLaporan
        '
        Me.ComboLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboLaporan.FormattingEnabled = True
        Me.ComboLaporan.Location = New System.Drawing.Point(503, 108)
        Me.ComboLaporan.Name = "ComboLaporan"
        Me.ComboLaporan.Size = New System.Drawing.Size(320, 32)
        Me.ComboLaporan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(514, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Jenis Laporan"
        '
        'DAwal
        '
        Me.DAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAwal.Location = New System.Drawing.Point(503, 229)
        Me.DAwal.Name = "DAwal"
        Me.DAwal.Size = New System.Drawing.Size(320, 26)
        Me.DAwal.TabIndex = 3
        Me.DAwal.Value = New Date(2018, 10, 6, 0, 0, 0, 0)
        '
        'DAkhir
        '
        Me.DAkhir.CustomFormat = "yyyy-MM-dd"
        Me.DAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAkhir.Location = New System.Drawing.Point(503, 353)
        Me.DAkhir.Name = "DAkhir"
        Me.DAkhir.Size = New System.Drawing.Size(320, 26)
        Me.DAkhir.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(502, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tanggal Awal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(502, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal Akhir"
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(503, 434)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(147, 37)
        Me.btn_ok.TabIndex = 6
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntutup.Location = New System.Drawing.Point(696, 434)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(127, 37)
        Me.btntutup.TabIndex = 8
        Me.btntutup.Text = "Tutup"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1327, 659)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DAkhir)
        Me.Controls.Add(Me.DAwal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboLaporan)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboLaporan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btntutup As System.Windows.Forms.Button
End Class
