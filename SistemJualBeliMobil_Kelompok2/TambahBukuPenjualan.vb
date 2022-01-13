Public Class TambahBukuPenjualan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Sign_In.Penjualan.CTipeMobilproperty = TextBoxMobilTerjual.Text.ToString()
        Sign_In.Penjualan.CNamaPembeliproperty = TextBoxPembeli.Text.ToString()
        Sign_In.Penjualan.harga_terjualproperty = TxtBoxHargaTerjual.Text.ToString()
        Sign_In.Penjualan.tanggal_penjualan = DateTimePickerJual.Value.ToString("yyyy/MM/dd")
        Sign_In.Penjualan.AddDataPenjualanDatabase(DatabaseMobil.selectedDatabaseMobil,
                                                 DatabasePembeli.selectedDatabasePembeli,
                                                 Sign_In.Penjualan.harga_terjualproperty,
                                                 Sign_In.Penjualan.tanggal_penjualan)
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

    Private Sub TambahBukuPenjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBoxMobilTerjual.Text = DatabaseMobil.selectedDatabaseMobilTipeMobil
        TextBoxPembeli.Text = DatabasePembeli.selectedDatabaseNamaPembeli
    End Sub
End Class