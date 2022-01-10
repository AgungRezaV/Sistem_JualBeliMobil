Public Class EditDataPembeli

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBoxNik.Text = DataPembeli.Pembeli.Nikproperty
        TextBoxNama.Text = DataPembeli.Pembeli.NamaProperty
        RichTextBoxAlmt.Text = DataPembeli.Pembeli.AlamatProperty
    End Sub
    Private Sub ButtonEditData_Click(sender As Object, e As EventArgs) Handles ButtonEditData.Click
        DataPembeli.Pembeli.Nikproperty = TextBoxNik.Text.ToString
        DataPembeli.Pembeli.NamaProperty = TextBoxNama.Text.ToString()
        DataPembeli.Pembeli.AlamatProperty = RichTextBoxAlmt.Text.ToString()

        DataPembeli.Pembeli.UpdateDataKoleksiByIDDatabase(DataPembeli.SelectedId, DataPembeli.Pembeli.Nikproperty, DataPembeli.Pembeli.NamaProperty, DataPembeli.Pembeli.AlamatProperty)
        Me.Close()
    End Sub
End Class