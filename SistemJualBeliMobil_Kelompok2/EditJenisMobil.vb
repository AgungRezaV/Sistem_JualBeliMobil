Public Class EditJenisMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TxtboxJenis.Text = JenisMobil.selectedTableJenisMobilNama

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnEditJenis_Click(sender As Object, e As EventArgs) Handles BtnEditJenis.Click
        Sign_In.ClassJenisMobil.Jenis_MobilProperty = TxtboxJenis.Text.ToString()

        Sign_In.ClassJenisMobil.UpdateDataJenisMobilByIDDatabase(JenisMobil.selectedTableIDJenisMobil,
                                                                 Sign_In.ClassJenisMobil.Jenis_MobilProperty)
        Me.Close()
    End Sub

End Class