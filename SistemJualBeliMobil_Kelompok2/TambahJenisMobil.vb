Public Class TambahJenisMobil
    Private Sub BtnTmbhJenis_Click(sender As Object, e As EventArgs) Handles BtnTmbhJenis.Click
        JenisMobil.ClassJenisMobil.Jenis_MobilProperty = TxtboxJenis.Text.ToString()

        JenisMobil.ClassJenisMobil.AddDataDatabaseJenisMobil(JenisMobil.ClassJenisMobil.Jenis_MobilProperty)

        Me.Close()

    End Sub
End Class