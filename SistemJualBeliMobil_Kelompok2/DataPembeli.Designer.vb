<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPembeli
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
        Me.ButtonTambahData = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembeliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonTambahData
        '
        Me.ButtonTambahData.Location = New System.Drawing.Point(68, 260)
        Me.ButtonTambahData.Name = "ButtonTambahData"
        Me.ButtonTambahData.Size = New System.Drawing.Size(112, 23)
        Me.ButtonTambahData.TabIndex = 37
        Me.ButtonTambahData.Text = "Tambah Data"
        Me.ButtonTambahData.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "PEMBELI"
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.Location = New System.Drawing.Point(28, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(425, 180)
        Me.DataGridView1.TabIndex = 38
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(186, 260)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(112, 23)
        Me.ButtonEdit.TabIndex = 40
        Me.ButtonEdit.Text = "Edit Data"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(304, 260)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(112, 23)
        Me.ButtonHapus.TabIndex = 41
        Me.ButtonHapus.Text = "Hapus Data"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MobilToolStripMenuItem, Me.JenisMobilToolStripMenuItem, Me.PembeliToolStripMenuItem, Me.BukuPenjualanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(479, 24)
        Me.MenuStrip1.TabIndex = 42
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
        Me.PictureBox1.Location = New System.Drawing.Point(409, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'DataPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(479, 290)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonTambahData)
        Me.Controls.Add(Me.Label4)
        Me.Name = "DataPembeli"
        Me.Text = "DataPembeli"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonTambahData As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembeliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
