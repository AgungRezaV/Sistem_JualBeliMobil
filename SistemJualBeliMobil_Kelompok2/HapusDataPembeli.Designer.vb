<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusDataPembeli
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
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Labelnama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnhapus
        '
        Me.btnhapus.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(143, 174)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(88, 32)
        Me.btnhapus.TabIndex = 5
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Labelnama
        '
        Me.Labelnama.AutoSize = True
        Me.Labelnama.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelnama.Font = New System.Drawing.Font("Cooper Black", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnama.ForeColor = System.Drawing.Color.Red
        Me.Labelnama.Location = New System.Drawing.Point(86, 115)
        Me.Labelnama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labelnama.Name = "Labelnama"
        Me.Labelnama.Size = New System.Drawing.Size(208, 31)
        Me.Labelnama.TabIndex = 4
        Me.Labelnama.Text = "Nama Pembeli"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NSimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah Anda Ingin Menghapus Koleksi Berikut ???"
        '
        'HapusDataPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 270)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.Labelnama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusDataPembeli"
        Me.Text = "HapusDataPembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnhapus As Button
    Friend WithEvents Labelnama As Label
    Friend WithEvents Label1 As Label
End Class
