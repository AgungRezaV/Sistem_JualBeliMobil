Public Class HapusDataPembeli

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Labelnama.Text = DataPembeli.SelectedTableNama
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Sign_In.Pembeli.DeleteDataPembeliByIDDatabase(DataPembeli.SelectedId)
        Me.Close()
    End Sub
End Class


