<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusPenjualan
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
        Me.LabelHapus = New System.Windows.Forms.Label()
        Me.Lblisi = New System.Windows.Forms.Label()
        Me.BtnHapusPenjualan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelHapus
        '
        Me.LabelHapus.AutoSize = True
        Me.LabelHapus.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHapus.Location = New System.Drawing.Point(55, 9)
        Me.LabelHapus.Name = "LabelHapus"
        Me.LabelHapus.Size = New System.Drawing.Size(273, 29)
        Me.LabelHapus.TabIndex = 0
        Me.LabelHapus.Text = "Hapus Daftar Penjualan"
        '
        'Lblisi
        '
        Me.Lblisi.AutoSize = True
        Me.Lblisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblisi.Location = New System.Drawing.Point(185, 63)
        Me.Lblisi.Name = "Lblisi"
        Me.Lblisi.Size = New System.Drawing.Size(25, 24)
        Me.Lblisi.TabIndex = 1
        Me.Lblisi.Text = "X"
        '
        'BtnHapusPenjualan
        '
        Me.BtnHapusPenjualan.Location = New System.Drawing.Point(146, 106)
        Me.BtnHapusPenjualan.Name = "BtnHapusPenjualan"
        Me.BtnHapusPenjualan.Size = New System.Drawing.Size(78, 29)
        Me.BtnHapusPenjualan.TabIndex = 2
        Me.BtnHapusPenjualan.Text = "Hapus"
        Me.BtnHapusPenjualan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID :"
        '
        'HapusPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 148)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusPenjualan)
        Me.Controls.Add(Me.Lblisi)
        Me.Controls.Add(Me.LabelHapus)
        Me.Name = "HapusPenjualan"
        Me.Text = "HapusPenjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHapus As Label
    Friend WithEvents Lblisi As Label
    Friend WithEvents BtnHapusPenjualan As Button
    Friend WithEvents Label1 As Label
End Class
