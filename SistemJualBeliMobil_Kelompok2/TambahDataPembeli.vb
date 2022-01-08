Public Class TambahDataPembeli


    Private Sub ButtonTambahData_Click(sender As Object, e As EventArgs) Handles ButtonTambahData.Click
        DataPembeli.Pembeli.Nikproperty = TextBoxNik.Text.ToString()
        DataPembeli.Pembeli.NamaProperty = TextBoxNama.Text.ToString()
        DataPembeli.Pembeli.AlamatProperty = RichTextBoxTambh.Text.ToString()
        DataPembeli.Pembeli.AddDataPembeliDatabase(
            DataPembeli.Pembeli.Nikproperty,
            DataPembeli.Pembeli.NamaProperty,
            DataPembeli.Pembeli.AlamatProperty)
        Me.Close()
    End Sub


End Class
