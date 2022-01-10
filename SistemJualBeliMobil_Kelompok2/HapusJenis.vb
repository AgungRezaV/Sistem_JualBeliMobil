Public Class HapusJenis
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LbNama.Text = JenisMobil.selectedTableKoleksiNama
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        JenisMobil.ClassJenisMobil.DeleteDataKoleksiByIDDatabaseMobil(JenisMobil.selectedTableKoleksi)
        Me.Close()
    End Sub

End Class