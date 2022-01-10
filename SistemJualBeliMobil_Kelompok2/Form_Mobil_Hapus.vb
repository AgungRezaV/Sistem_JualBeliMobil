Public Class Form_Mobil_Hapus
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LblText.Text = Form_Mobil.SelectedTableKoleksiTipeMobil
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Perpus.Koleksi.RemoveKoleksi(Perpus.ListBoxKoleksi.SelectedItem)
        Form_Mobil.ClassMobil.DeleteDataKoleksiByIDDatabaseMobil(Form_Mobil.SelectedTableKoleksi)
        For Each Control As Control In Form_Mobil.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        If String.Compare(Form_Mobil.ClassMobil.KondisiMobilProperty, "Baru") = 0 Then
            Form_Mobil.RBBaru.Checked = False
        ElseIf String.Compare(Form_Mobil.ClassMobil.KondisiMobilProperty, "Bekas") = 0 Then
            Form_Mobil.RBBekas.Checked = False
        End If
        Form_Mobil.CBGaransi.Text = Nothing
        Form_Mobil.PBFoto.Image = Nothing
        Me.Close()
    End Sub
End Class