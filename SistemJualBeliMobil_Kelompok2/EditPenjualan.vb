Public Class EditPenjualan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Txtboxhargaterjual.Text = BukuPenjualan.Penjualan.harga_terjualproperty
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnEditPenjualan_Click(sender As Object, e As EventArgs) Handles BtnEditPenjualan.Click
        BukuPenjualan.Penjualan.harga_terjualproperty = Txtboxhargaterjual.Text.ToString()
        BukuPenjualan.Penjualan.tanggal_penjualan = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        BukuPenjualan.Penjualan.UpdateDataKoleksiByIDDatabase(BukuPenjualan.selectedtablepenjualan,
                                                              BukuPenjualan.Penjualan.harga_terjualproperty,
                                                              BukuPenjualan.Penjualan.tanggal_penjualan)

        Me.Close()
    End Sub
End Class

