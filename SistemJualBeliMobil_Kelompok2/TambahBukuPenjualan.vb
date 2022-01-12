Public Class TambahBukuPenjualan
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        BukuPenjualan.Penjualan.harga_terjualproperty = TxtBoxHargaTerjual.Text.ToString()
        BukuPenjualan.Penjualan.tanggal_penjualan = DateTimePickerJual.Value.ToString("yyyy/MM/dd")

        BukuPenjualan.Penjualan.AddDataKoleksiDatabase(BukuPenjualan.Penjualan.harga_terjualproperty, BukuPenjualan.Penjualan.tanggal_penjualan)

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormDatabaseMobil = New DatabaseMobil()
        FormDatabaseMobil.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FormDatabasePembeli = New DatabasePembeli()
        FormDatabasePembeli.Show()
    End Sub
End Class