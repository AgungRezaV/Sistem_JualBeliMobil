Public Class HapusPenjualan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Lblisi.Text = BukuPenjualan.selectedtablepenjualannama
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapusPenjualan_Click(sender As Object, e As EventArgs) Handles BtnHapusPenjualan.Click
        BukuPenjualan.Penjualan.DeleteDataKoleksiByIDDatabase(BukuPenjualan.selectedtablepenjualan)
        Me.Close()
    End Sub

End Class