<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahBukuPenjualan
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
        Me.LblTmbhBuku = New System.Windows.Forms.Label()
        Me.LblMobilID = New System.Windows.Forms.Label()
        Me.LblHargaTerjual = New System.Windows.Forms.Label()
        Me.LblPembeliID = New System.Windows.Forms.Label()
        Me.LblTanggalJual = New System.Windows.Forms.Label()
        Me.TextBoxMobilTerjual = New System.Windows.Forms.TextBox()
        Me.TextBoxPembeli = New System.Windows.Forms.TextBox()
        Me.TxtBoxHargaTerjual = New System.Windows.Forms.TextBox()
        Me.DateTimePickerJual = New System.Windows.Forms.DateTimePicker()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTmbhBuku
        '
        Me.LblTmbhBuku.AutoSize = True
        Me.LblTmbhBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTmbhBuku.Location = New System.Drawing.Point(66, 23)
        Me.LblTmbhBuku.Name = "LblTmbhBuku"
        Me.LblTmbhBuku.Size = New System.Drawing.Size(268, 25)
        Me.LblTmbhBuku.TabIndex = 1
        Me.LblTmbhBuku.Text = "Tambah Buku Penjualan"
        '
        'LblMobilID
        '
        Me.LblMobilID.AutoSize = True
        Me.LblMobilID.Location = New System.Drawing.Point(11, 80)
        Me.LblMobilID.Name = "LblMobilID"
        Me.LblMobilID.Size = New System.Drawing.Size(56, 13)
        Me.LblMobilID.TabIndex = 2
        Me.LblMobilID.Text = "Tipe Mobil"
        '
        'LblHargaTerjual
        '
        Me.LblHargaTerjual.AutoSize = True
        Me.LblHargaTerjual.Location = New System.Drawing.Point(11, 155)
        Me.LblHargaTerjual.Name = "LblHargaTerjual"
        Me.LblHargaTerjual.Size = New System.Drawing.Size(71, 13)
        Me.LblHargaTerjual.TabIndex = 6
        Me.LblHargaTerjual.Text = "Harga Terjual"
        '
        'LblPembeliID
        '
        Me.LblPembeliID.AutoSize = True
        Me.LblPembeliID.Location = New System.Drawing.Point(10, 117)
        Me.LblPembeliID.Name = "LblPembeliID"
        Me.LblPembeliID.Size = New System.Drawing.Size(75, 13)
        Me.LblPembeliID.TabIndex = 7
        Me.LblPembeliID.Text = "Nama Pembeli"
        '
        'LblTanggalJual
        '
        Me.LblTanggalJual.AutoSize = True
        Me.LblTanggalJual.Location = New System.Drawing.Point(11, 189)
        Me.LblTanggalJual.Name = "LblTanggalJual"
        Me.LblTanggalJual.Size = New System.Drawing.Size(81, 13)
        Me.LblTanggalJual.TabIndex = 8
        Me.LblTanggalJual.Text = "Tanggal Terjual"
        '
        'TextBoxMobilTerjual
        '
        Me.TextBoxMobilTerjual.Enabled = False
        Me.TextBoxMobilTerjual.Location = New System.Drawing.Point(151, 77)
        Me.TextBoxMobilTerjual.Name = "TextBoxMobilTerjual"
        Me.TextBoxMobilTerjual.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxMobilTerjual.TabIndex = 14
        '
        'TextBoxPembeli
        '
        Me.TextBoxPembeli.Enabled = False
        Me.TextBoxPembeli.Location = New System.Drawing.Point(151, 114)
        Me.TextBoxPembeli.Name = "TextBoxPembeli"
        Me.TextBoxPembeli.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxPembeli.TabIndex = 15
        '
        'TxtBoxHargaTerjual
        '
        Me.TxtBoxHargaTerjual.Location = New System.Drawing.Point(151, 152)
        Me.TxtBoxHargaTerjual.Name = "TxtBoxHargaTerjual"
        Me.TxtBoxHargaTerjual.Size = New System.Drawing.Size(248, 20)
        Me.TxtBoxHargaTerjual.TabIndex = 16
        '
        'DateTimePickerJual
        '
        Me.DateTimePickerJual.Location = New System.Drawing.Point(151, 189)
        Me.DateTimePickerJual.Name = "DateTimePickerJual"
        Me.DateTimePickerJual.Size = New System.Drawing.Size(248, 20)
        Me.DateTimePickerJual.TabIndex = 19
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Location = New System.Drawing.Point(12, 227)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(387, 46)
        Me.ButtonTambah.TabIndex = 23
        Me.ButtonTambah.Text = "Tambah "
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(324, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.SistemJualBeliMobil_Kelompok2.My.Resources.Resources.Logo_SistemJualBeliMobil_VB
        Me.PictureBox1.Location = New System.Drawing.Point(355, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'TambahBukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(419, 299)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.DateTimePickerJual)
        Me.Controls.Add(Me.TxtBoxHargaTerjual)
        Me.Controls.Add(Me.TextBoxPembeli)
        Me.Controls.Add(Me.TextBoxMobilTerjual)
        Me.Controls.Add(Me.LblTanggalJual)
        Me.Controls.Add(Me.LblPembeliID)
        Me.Controls.Add(Me.LblHargaTerjual)
        Me.Controls.Add(Me.LblMobilID)
        Me.Controls.Add(Me.LblTmbhBuku)
        Me.Name = "TambahBukuPenjualan"
        Me.Text = "TambahBukuPenjualan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTmbhBuku As Label
    Friend WithEvents LblMobilID As Label
    Friend WithEvents LblHargaTerjual As Label
    Friend WithEvents LblPembeliID As Label
    Friend WithEvents LblTanggalJual As Label
    Friend WithEvents TextBoxMobilTerjual As TextBox
    Friend WithEvents TextBoxPembeli As TextBox
    Friend WithEvents TxtBoxHargaTerjual As TextBox
    Friend WithEvents DateTimePickerJual As DateTimePicker
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
