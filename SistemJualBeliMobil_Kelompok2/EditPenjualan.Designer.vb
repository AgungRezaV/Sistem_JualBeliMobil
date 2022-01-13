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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBPembeli = New System.Windows.Forms.TextBox()
        Me.TBMobilTerjual = New System.Windows.Forms.TextBox()
        Me.LblPembeliID = New System.Windows.Forms.Label()
        Me.LblMobilID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lblhargaterjual
        '
        Me.Lblhargaterjual.AutoSize = True
        Me.Lblhargaterjual.Location = New System.Drawing.Point(18, 97)
        Me.Lblhargaterjual.Name = "Lblhargaterjual"
        Me.Lblhargaterjual.Size = New System.Drawing.Size(71, 13)
        Me.Lblhargaterjual.TabIndex = 0
        Me.Lblhargaterjual.Text = "Harga Terjual"
        '
        'LblTanggalPenjualan
        '
        Me.LblTanggalPenjualan.AutoSize = True
        Me.LblTanggalPenjualan.Location = New System.Drawing.Point(19, 135)
        Me.LblTanggalPenjualan.Name = "LblTanggalPenjualan"
        Me.LblTanggalPenjualan.Size = New System.Drawing.Size(96, 13)
        Me.LblTanggalPenjualan.TabIndex = 1
        Me.LblTanggalPenjualan.Text = "Tanggal Penjualan"
        '
        'Txtboxhargaterjual
        '
        Me.Txtboxhargaterjual.Location = New System.Drawing.Point(118, 97)
        Me.Txtboxhargaterjual.Name = "Txtboxhargaterjual"
        Me.Txtboxhargaterjual.Size = New System.Drawing.Size(266, 20)
        Me.Txtboxhargaterjual.TabIndex = 2
        '
        'BtnEditPenjualan
        '
        Me.BtnEditPenjualan.Location = New System.Drawing.Point(161, 172)
        Me.BtnEditPenjualan.Name = "BtnEditPenjualan"
        Me.BtnEditPenjualan.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditPenjualan.TabIndex = 4
        Me.BtnEditPenjualan.Text = "Edit"
        Me.BtnEditPenjualan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(118, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(309, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TBPembeli
        '
        Me.TBPembeli.Enabled = False
        Me.TBPembeli.Location = New System.Drawing.Point(118, 59)
        Me.TBPembeli.Name = "TBPembeli"
        Me.TBPembeli.Size = New System.Drawing.Size(185, 20)
        Me.TBPembeli.TabIndex = 29
        '
        'TBMobilTerjual
        '
        Me.TBMobilTerjual.Enabled = False
        Me.TBMobilTerjual.Location = New System.Drawing.Point(118, 21)
        Me.TBMobilTerjual.Name = "TBMobilTerjual"
        Me.TBMobilTerjual.Size = New System.Drawing.Size(185, 20)
        Me.TBMobilTerjual.TabIndex = 28
        '
        'LblPembeliID
        '
        Me.LblPembeliID.AutoSize = True
        Me.LblPembeliID.Location = New System.Drawing.Point(19, 59)
        Me.LblPembeliID.Name = "LblPembeliID"
        Me.LblPembeliID.Size = New System.Drawing.Size(58, 13)
        Me.LblPembeliID.TabIndex = 27
        Me.LblPembeliID.Text = "ID Pembeli"
        '
        'LblMobilID
        '
        Me.LblMobilID.AutoSize = True
        Me.LblMobilID.Location = New System.Drawing.Point(18, 24)
        Me.LblMobilID.Name = "LblMobilID"
        Me.LblMobilID.Size = New System.Drawing.Size(81, 13)
        Me.LblMobilID.TabIndex = 26
        Me.LblMobilID.Text = "ID Mobil Terjual"
        '
        'EditPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 207)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBPembeli)
        Me.Controls.Add(Me.TBMobilTerjual)
        Me.Controls.Add(Me.LblPembeliID)
        Me.Controls.Add(Me.LblMobilID)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TBPembeli As TextBox
    Friend WithEvents TBMobilTerjual As TextBox
    Friend WithEvents LblPembeliID As Label
    Friend WithEvents LblMobilID As Label
End Class
