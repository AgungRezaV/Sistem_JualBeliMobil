Public Class EditDataPembeli

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBoxNik.Text = Sign_In.Pembeli.Nikproperty
        TextBoxNama.Text = Sign_In.Pembeli.NamaProperty
        RichTextBoxAlmt.Text = Sign_In.Pembeli.AlamatProperty
    End Sub
    Private Sub ButtonEditData_Click(sender As Object, e As EventArgs) Handles ButtonEditData.Click
        Sign_In.Pembeli.Nikproperty = TextBoxNik.Text.ToString
        Sign_In.Pembeli.NamaProperty = TextBoxNama.Text.ToString()
        Sign_In.Pembeli.AlamatProperty = RichTextBoxAlmt.Text.ToString()

        Sign_In.Pembeli.UpdateDataKoleksiByIDDatabase(DataPembeli.SelectedId,
                                                            Sign_In.Pembeli.Nikproperty,
                                                            Sign_In.Pembeli.NamaProperty,
                                                            Sign_In.Pembeli.AlamatProperty)
        Me.Close()
    End Sub
End Class