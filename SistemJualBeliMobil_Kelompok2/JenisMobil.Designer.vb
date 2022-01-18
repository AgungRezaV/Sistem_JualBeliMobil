<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisMobil
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembeliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(36, 295)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 12
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(117, 295)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(198, 295)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 10
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(36, 74)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(237, 204)
        Me.DG.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MobilToolStripMenuItem, Me.JenisMobilToolStripMenuItem, Me.PembeliToolStripMenuItem, Me.BukuPenjualanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(300, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MobilToolStripMenuItem
        '
        Me.MobilToolStripMenuItem.Name = "MobilToolStripMenuItem"
        Me.MobilToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MobilToolStripMenuItem.Text = "Mobil"
        '
        'JenisMobilToolStripMenuItem
        '
        Me.JenisMobilToolStripMenuItem.Name = "JenisMobilToolStripMenuItem"
        Me.JenisMobilToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.JenisMobilToolStripMenuItem.Text = "Jenis Mobil"
        '
        'PembeliToolStripMenuItem
        '
        Me.PembeliToolStripMenuItem.Name = "PembeliToolStripMenuItem"
        Me.PembeliToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PembeliToolStripMenuItem.Text = "Pembeli"
        '
        'BukuPenjualanToolStripMenuItem
        '
        Me.BukuPenjualanToolStripMenuItem.Name = "BukuPenjualanToolStripMenuItem"
        Me.BukuPenjualanToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.BukuPenjualanToolStripMenuItem.Text = "Buku Penjualan"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.SistemJualBeliMobil_Kelompok2.My.Resources.Resources.Logo_SistemJualBeliMobil_VB
        Me.PictureBox1.Location = New System.Drawing.Point(229, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'JenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(300, 346)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.DG)
        Me.Name = "JenisMobil"
        Me.Text = "JenisMobil"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents DG As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembeliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
