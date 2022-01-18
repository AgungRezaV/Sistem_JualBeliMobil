<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJenisMobil
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
        Me.BtnEditJenis = New System.Windows.Forms.Button()
        Me.TxtboxJenis = New System.Windows.Forms.TextBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEditJenis
        '
        Me.BtnEditJenis.Location = New System.Drawing.Point(382, 107)
        Me.BtnEditJenis.Name = "BtnEditJenis"
        Me.BtnEditJenis.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditJenis.TabIndex = 11
        Me.BtnEditJenis.Text = "Edit"
        Me.BtnEditJenis.UseVisualStyleBackColor = True
        '
        'TxtboxJenis
        '
        Me.TxtboxJenis.Location = New System.Drawing.Point(214, 69)
        Me.TxtboxJenis.Name = "TxtboxJenis"
        Me.TxtboxJenis.Size = New System.Drawing.Size(243, 20)
        Me.TxtboxJenis.TabIndex = 10
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(12, 70)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(111, 19)
        Me.lblJenis.TabIndex = 9
        Me.lblJenis.Text = "Jenis Mobil :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.SistemJualBeliMobil_Kelompok2.My.Resources.Resources.Logo_SistemJualBeliMobil_VB
        Me.PictureBox1.Location = New System.Drawing.Point(413, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'EditJenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(484, 132)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEditJenis)
        Me.Controls.Add(Me.TxtboxJenis)
        Me.Controls.Add(Me.lblJenis)
        Me.Name = "EditJenisMobil"
        Me.Text = "EditJenisMobil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEditJenis As Button
    Friend WithEvents TxtboxJenis As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
