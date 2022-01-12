Public Class TambahDataPembeli


    Private Sub ButtonTambahData_Click(sender As Object, e As EventArgs) Handles ButtonTambahData.Click
        Sign_In.Pembeli.Nikproperty = TextBoxNik.Text.ToString()
        Sign_In.Pembeli.NamaProperty = TextBoxNama.Text.ToString()
        Sign_In.Pembeli.AlamatProperty = RichTextBoxTambh.Text.ToString()
        Sign_In.Pembeli.AddDataPembeliDatabase(
            Sign_In.Pembeli.Nikproperty,
            Sign_In.Pembeli.NamaProperty,
            Sign_In.Pembeli.AlamatProperty)
        Me.Close()
    End Sub


End Class
