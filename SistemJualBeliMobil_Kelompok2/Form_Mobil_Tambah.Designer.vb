﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Mobil_Tambah
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
        Me.CBGaransi = New System.Windows.Forms.ComboBox()
        Me.TBTahunPembuatan = New System.Windows.Forms.TextBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.TBHargaDefault = New System.Windows.Forms.TextBox()
        Me.TBHarga = New System.Windows.Forms.TextBox()
        Me.GBKondisiMobil = New System.Windows.Forms.GroupBox()
        Me.RBBekas = New System.Windows.Forms.RadioButton()
        Me.RBBaru = New System.Windows.Forms.RadioButton()
        Me.TBTipeMobil = New System.Windows.Forms.TextBox()
        Me.TBJenisMobil = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBKondisiMobil.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBGaransi
        '
        Me.CBGaransi.FormattingEnabled = True
        Me.CBGaransi.Items.AddRange(New Object() {"1 Tahun", "2 Tahun", "5 Tahun", "Life-Time Warranty"})
        Me.CBGaransi.Location = New System.Drawing.Point(133, 414)
        Me.CBGaransi.Name = "CBGaransi"
        Me.CBGaransi.Size = New System.Drawing.Size(187, 21)
        Me.CBGaransi.TabIndex = 40
        '
        'TBTahunPembuatan
        '
        Me.TBTahunPembuatan.Location = New System.Drawing.Point(133, 267)
        Me.TBTahunPembuatan.Name = "TBTahunPembuatan"
        Me.TBTahunPembuatan.Size = New System.Drawing.Size(187, 20)
        Me.TBTahunPembuatan.TabIndex = 39
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(133, 155)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(122, 23)
        Me.BtnTambahGambar.TabIndex = 38
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'PBFoto
        '
        Me.PBFoto.Location = New System.Drawing.Point(133, 12)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(122, 137)
        Me.PBFoto.TabIndex = 37
        Me.PBFoto.TabStop = False
        '
        'TBHargaDefault
        '
        Me.TBHargaDefault.Location = New System.Drawing.Point(133, 454)
        Me.TBHargaDefault.Name = "TBHargaDefault"
        Me.TBHargaDefault.Size = New System.Drawing.Size(187, 20)
        Me.TBHargaDefault.TabIndex = 36
        '
        'TBHarga
        '
        Me.TBHarga.Location = New System.Drawing.Point(133, 372)
        Me.TBHarga.Name = "TBHarga"
        Me.TBHarga.Size = New System.Drawing.Size(187, 20)
        Me.TBHarga.TabIndex = 35
        '
        'GBKondisiMobil
        '
        Me.GBKondisiMobil.Controls.Add(Me.RBBekas)
        Me.GBKondisiMobil.Controls.Add(Me.RBBaru)
        Me.GBKondisiMobil.Location = New System.Drawing.Point(133, 307)
        Me.GBKondisiMobil.Name = "GBKondisiMobil"
        Me.GBKondisiMobil.Size = New System.Drawing.Size(187, 45)
        Me.GBKondisiMobil.TabIndex = 34
        Me.GBKondisiMobil.TabStop = False
        Me.GBKondisiMobil.Text = "Kondisi"
        '
        'RBBekas
        '
        Me.RBBekas.AutoSize = True
        Me.RBBekas.Location = New System.Drawing.Point(85, 19)
        Me.RBBekas.Name = "RBBekas"
        Me.RBBekas.Size = New System.Drawing.Size(55, 17)
        Me.RBBekas.TabIndex = 12
        Me.RBBekas.TabStop = True
        Me.RBBekas.Text = "Bekas"
        Me.RBBekas.UseVisualStyleBackColor = True
        '
        'RBBaru
        '
        Me.RBBaru.AutoSize = True
        Me.RBBaru.Location = New System.Drawing.Point(6, 19)
        Me.RBBaru.Name = "RBBaru"
        Me.RBBaru.Size = New System.Drawing.Size(47, 17)
        Me.RBBaru.TabIndex = 11
        Me.RBBaru.TabStop = True
        Me.RBBaru.Text = "Baru"
        Me.RBBaru.UseVisualStyleBackColor = True
        '
        'TBTipeMobil
        '
        Me.TBTipeMobil.Location = New System.Drawing.Point(133, 230)
        Me.TBTipeMobil.Name = "TBTipeMobil"
        Me.TBTipeMobil.Size = New System.Drawing.Size(187, 20)
        Me.TBTipeMobil.TabIndex = 33
        '
        'TBJenisMobil
        '
        Me.TBJenisMobil.Location = New System.Drawing.Point(133, 190)
        Me.TBJenisMobil.Name = "TBJenisMobil"
        Me.TBJenisMobil.Size = New System.Drawing.Size(187, 20)
        Me.TBJenisMobil.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 454)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Harga Default"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Garansi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Kondisi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tahun Pembuatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tipe Mobil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Jenis Mobil"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(133, 489)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 41
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form_Mobil_Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 524)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.CBGaransi)
        Me.Controls.Add(Me.TBTahunPembuatan)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.TBHargaDefault)
        Me.Controls.Add(Me.TBHarga)
        Me.Controls.Add(Me.GBKondisiMobil)
        Me.Controls.Add(Me.TBTipeMobil)
        Me.Controls.Add(Me.TBJenisMobil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Mobil_Tambah"
        Me.Text = "Form_Mobil_Tambah"
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBKondisiMobil.ResumeLayout(False)
        Me.GBKondisiMobil.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBGaransi As ComboBox
    Friend WithEvents TBTahunPembuatan As TextBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents TBHargaDefault As TextBox
    Friend WithEvents TBHarga As TextBox
    Friend WithEvents GBKondisiMobil As GroupBox
    Friend WithEvents RBBekas As RadioButton
    Friend WithEvents RBBaru As RadioButton
    Friend WithEvents TBTipeMobil As TextBox
    Friend WithEvents TBJenisMobil As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class