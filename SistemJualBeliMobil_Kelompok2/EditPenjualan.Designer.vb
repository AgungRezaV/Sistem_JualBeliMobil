<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPenjualan
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
        Me.Lblhargaterjual = New System.Windows.Forms.Label()
        Me.LblTanggalPenjualan = New System.Windows.Forms.Label()
        Me.Txtboxhargaterjual = New System.Windows.Forms.TextBox()
        Me.BtnEditPenjualan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Lblhargaterjual
        '
        Me.Lblhargaterjual.AutoSize = True
        Me.Lblhargaterjual.Location = New System.Drawing.Point(32, 57)
        Me.Lblhargaterjual.Name = "Lblhargaterjual"
        Me.Lblhargaterjual.Size = New System.Drawing.Size(71, 13)
        Me.Lblhargaterjual.TabIndex = 0
        Me.Lblhargaterjual.Text = "Harga Terjual"
        '
        'LblTanggalPenjualan
        '
        Me.LblTanggalPenjualan.AutoSize = True
        Me.LblTanggalPenjualan.Location = New System.Drawing.Point(32, 104)
        Me.LblTanggalPenjualan.Name = "LblTanggalPenjualan"
        Me.LblTanggalPenjualan.Size = New System.Drawing.Size(96, 13)
        Me.LblTanggalPenjualan.TabIndex = 1
        Me.LblTanggalPenjualan.Text = "Tanggal Penjualan"
        '
        'Txtboxhargaterjual
        '
        Me.Txtboxhargaterjual.Location = New System.Drawing.Point(131, 57)
        Me.Txtboxhargaterjual.Name = "Txtboxhargaterjual"
        Me.Txtboxhargaterjual.Size = New System.Drawing.Size(267, 20)
        Me.Txtboxhargaterjual.TabIndex = 2
        '
        'BtnEditPenjualan
        '
        Me.BtnEditPenjualan.Location = New System.Drawing.Point(217, 167)
        Me.BtnEditPenjualan.Name = "BtnEditPenjualan"
        Me.BtnEditPenjualan.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditPenjualan.TabIndex = 4
        Me.BtnEditPenjualan.Text = "Edit"
        Me.BtnEditPenjualan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'EditPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 264)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnEditPenjualan)
        Me.Controls.Add(Me.Txtboxhargaterjual)
        Me.Controls.Add(Me.LblTanggalPenjualan)
        Me.Controls.Add(Me.Lblhargaterjual)
        Me.Name = "EditPenjualan"
        Me.Text = "EditPenjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblhargaterjual As Label
    Friend WithEvents LblTanggalPenjualan As Label
    Friend WithEvents Txtboxhargaterjual As TextBox
    Friend WithEvents BtnEditPenjualan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
