<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BukuPenjualan
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(602, 264)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(305, 323)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(82, 30)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(519, 322)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(95, 31)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(402, 322)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(95, 31)
        Me.BtnEdit.TabIndex = 6
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MobilToolStripMenuItem, Me.JenisMobilToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 24)
        Me.MenuStrip1.TabIndex = 7
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
        'BukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 447)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BukuPenjualan"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisMobilToolStripMenuItem As ToolStripMenuItem
End Class
