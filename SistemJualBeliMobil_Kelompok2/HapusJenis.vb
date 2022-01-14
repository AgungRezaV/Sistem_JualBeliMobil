Public Class HapusJenis
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LbNama.Text = JenisMobil.selectedTableJenisMobilNama
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        JenisMobil.ClassJenisMobil.DeleteDataJenisMobilByID(JenisMobil.selectedTableIDJenisMobil)
        Me.Close()
    End Sub

End Class