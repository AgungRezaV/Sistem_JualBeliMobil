Public Class EditJenisMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TxtboxJenis.Text = JenisMobil.ClassJenisMobil.Jenis_MobilProperty

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTmbhJenis_Click(sender As Object, e As EventArgs) Handles BtnTmbhJenis.Click
        JenisMobil.ClassJenisMobil.Jenis_MobilProperty = TxtboxJenis.Text.ToString()

        JenisMobil.ClassJenisMobil.UpdateDataKoleksiByIDDatabase(JenisMobil.selectedTableKoleksi,
            JenisMobil.ClassJenisMobil.Jenis_MobilProperty)
        Me.Close()
    End Sub

End Class