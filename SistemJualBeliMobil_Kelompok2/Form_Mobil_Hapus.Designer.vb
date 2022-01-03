<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Mobil_Hapus
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
        Me.LblText = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblText
        '
        Me.LblText.AutoSize = True
        Me.LblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblText.Location = New System.Drawing.Point(200, 34)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(77, 26)
        Me.LblText.TabIndex = 0
        Me.LblText.Text = "Label1"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(149, 107)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(163, 23)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Hapus"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Form_Mobil_Hapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 325)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LblText)
        Me.Name = "Form_Mobil_Hapus"
        Me.Text = "Form_Mobil_Hapus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblText As Label
    Friend WithEvents BtnDelete As Button
End Class
