<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Mobil
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBJenisMobil = New System.Windows.Forms.TextBox()
        Me.TBTipeMobil = New System.Windows.Forms.TextBox()
        Me.RBBaru = New System.Windows.Forms.RadioButton()
        Me.RBBekas = New System.Windows.Forms.RadioButton()
        Me.GBKondisiMobil = New System.Windows.Forms.GroupBox()
        Me.TBHarga = New System.Windows.Forms.TextBox()
        Me.TBHargaDefault = New System.Windows.Forms.TextBox()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TBTahunPembuatan = New System.Windows.Forms.TextBox()
        Me.CBGaransi = New System.Windows.Forms.ComboBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnFormJenisMobil = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBKondisiMobil.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(237, 462)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipe Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tahun Pembuatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kondisi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Garansi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(266, 454)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Harga Default"
        '
        'TBJenisMobil
        '
        Me.TBJenisMobil.Enabled = False
        Me.TBJenisMobil.Location = New System.Drawing.Point(387, 190)
        Me.TBJenisMobil.Name = "TBJenisMobil"
        Me.TBJenisMobil.Size = New System.Drawing.Size(104, 20)
        Me.TBJenisMobil.TabIndex = 8
        '
        'TBTipeMobil
        '
        Me.TBTipeMobil.Location = New System.Drawing.Point(387, 230)
        Me.TBTipeMobil.Name = "TBTipeMobil"
        Me.TBTipeMobil.Size = New System.Drawing.Size(187, 20)
        Me.TBTipeMobil.TabIndex = 9
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
        'GBKondisiMobil
        '
        Me.GBKondisiMobil.Controls.Add(Me.RBBekas)
        Me.GBKondisiMobil.Controls.Add(Me.RBBaru)
        Me.GBKondisiMobil.Location = New System.Drawing.Point(387, 307)
        Me.GBKondisiMobil.Name = "GBKondisiMobil"
        Me.GBKondisiMobil.Size = New System.Drawing.Size(187, 45)
        Me.GBKondisiMobil.TabIndex = 13
        Me.GBKondisiMobil.TabStop = False
        Me.GBKondisiMobil.Text = "Kondisi"
        '
        'TBHarga
        '
        Me.TBHarga.Location = New System.Drawing.Point(387, 372)
        Me.TBHarga.Name = "TBHarga"
        Me.TBHarga.Size = New System.Drawing.Size(187, 20)
        Me.TBHarga.TabIndex = 14
        '
        'TBHargaDefault
        '
        Me.TBHargaDefault.Location = New System.Drawing.Point(387, 454)
        Me.TBHargaDefault.Name = "TBHargaDefault"
        Me.TBHargaDefault.Size = New System.Drawing.Size(187, 20)
        Me.TBHargaDefault.TabIndex = 16
        '
        'PBFoto
        '
        Me.PBFoto.Location = New System.Drawing.Point(369, 12)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(122, 137)
        Me.PBFoto.TabIndex = 18
        Me.PBFoto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(369, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Tambah Gambar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(12, 487)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 20
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(93, 487)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 21
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(174, 487)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 22
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TBTahunPembuatan
        '
        Me.TBTahunPembuatan.Location = New System.Drawing.Point(387, 267)
        Me.TBTahunPembuatan.Name = "TBTahunPembuatan"
        Me.TBTahunPembuatan.Size = New System.Drawing.Size(187, 20)
        Me.TBTahunPembuatan.TabIndex = 23
        '
        'CBGaransi
        '
        Me.CBGaransi.FormattingEnabled = True
        Me.CBGaransi.Items.AddRange(New Object() {"1 Tahun", "2 Tahun", "5 Tahun", "Life-Time Warranty"})
        Me.CBGaransi.Location = New System.Drawing.Point(387, 414)
        Me.CBGaransi.Name = "CBGaransi"
        Me.CBGaransi.Size = New System.Drawing.Size(187, 21)
        Me.CBGaransi.TabIndex = 24
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(499, 487)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 25
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnFormJenisMobil
        '
        Me.BtnFormJenisMobil.Location = New System.Drawing.Point(499, 190)
        Me.BtnFormJenisMobil.Name = "BtnFormJenisMobil"
        Me.BtnFormJenisMobil.Size = New System.Drawing.Size(75, 23)
        Me.BtnFormJenisMobil.TabIndex = 26
        Me.BtnFormJenisMobil.Text = "Edit"
        Me.BtnFormJenisMobil.UseVisualStyleBackColor = True
        '
        'Form_Mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 522)
        Me.Controls.Add(Me.BtnFormJenisMobil)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.CBGaransi)
        Me.Controls.Add(Me.TBTahunPembuatan)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form_Mobil"
        Me.Text = "Form_Mobil"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBKondisiMobil.ResumeLayout(False)
        Me.GBKondisiMobil.PerformLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBJenisMobil As TextBox
    Friend WithEvents TBTipeMobil As TextBox
    Friend WithEvents RBBaru As RadioButton
    Friend WithEvents RBBekas As RadioButton
    Friend WithEvents GBKondisiMobil As GroupBox
    Friend WithEvents TBHarga As TextBox
    Friend WithEvents TBHargaDefault As TextBox
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents TBTahunPembuatan As TextBox
    Friend WithEvents CBGaransi As ComboBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnFormJenisMobil As Button
End Class
