Public Class Form_Mobil_Hapus
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LblText.Text = Form_Mobil.SelectedTableKoleksiNama
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Perpus.Koleksi.RemoveKoleksi(Perpus.ListBoxKoleksi.SelectedItem)
        Form_Mobil.ClassMobil.DeleteDataKoleksiByIDDatabase(Form_Mobil.SelectedTableKoleksi)
        Me.Close()
    End Sub
End Class