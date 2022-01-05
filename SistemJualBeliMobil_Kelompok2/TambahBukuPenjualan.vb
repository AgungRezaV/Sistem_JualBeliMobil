Public Class TambahBukuPenjualan
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        BukuPenjualan.Penjualan.harga_terjualproperty = TxtBoxHargaTerjual.Text.ToString()
        BukuPenjualan.Penjualan.tanggal_penjualan = DateTimePickerJual.Value.ToString("yyyy/MM/dd")

        BukuPenjualan.Penjualan.AddDataKoleksiDatabase(BukuPenjualan.Penjualan.harga_terjualproperty, BukuPenjualan.Penjualan.tanggal_penjualan)

        Me.Close()

    End Sub
End Class