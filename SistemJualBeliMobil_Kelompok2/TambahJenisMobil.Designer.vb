﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJenisMobil
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
        Me.BtnTmbhJenis = New System.Windows.Forms.Button()
        Me.TxtboxJenis = New System.Windows.Forms.TextBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTmbhJenis
        '
        Me.BtnTmbhJenis.Location = New System.Drawing.Point(377, 108)
        Me.BtnTmbhJenis.Name = "BtnTmbhJenis"
        Me.BtnTmbhJenis.Size = New System.Drawing.Size(75, 23)
        Me.BtnTmbhJenis.TabIndex = 8
        Me.BtnTmbhJenis.Text = "Tambah"
        Me.BtnTmbhJenis.UseVisualStyleBackColor = True
        '
        'TxtboxJenis
        '
        Me.TxtboxJenis.Location = New System.Drawing.Point(209, 48)
        Me.TxtboxJenis.Name = "TxtboxJenis"
        Me.TxtboxJenis.Size = New System.Drawing.Size(243, 20)
        Me.TxtboxJenis.TabIndex = 7
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(19, 47)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(111, 19)
        Me.lblJenis.TabIndex = 6
        Me.lblJenis.Text = "Jenis Mobil :"
        '
        'TambahJenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 157)
        Me.Controls.Add(Me.BtnTmbhJenis)
        Me.Controls.Add(Me.TxtboxJenis)
        Me.Controls.Add(Me.lblJenis)
        Me.Name = "TambahJenisMobil"
        Me.Text = "TambahJenisMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTmbhJenis As Button
    Friend WithEvents TxtboxJenis As TextBox
    Friend WithEvents lblJenis As Label
End Class