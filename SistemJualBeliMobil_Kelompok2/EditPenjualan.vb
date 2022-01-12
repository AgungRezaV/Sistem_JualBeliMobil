Public Class EditPenjualan
    Public Shared SelectedTableEditPenjualan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Txtboxhargaterjual.Text = Sign_In.Penjualan.harga_terjualproperty
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        TBMobilTerjual.Text = Sign_In.Penjualan.CTipeMobilproperty
        TBPembeli.Text = Sign_In.Penjualan.CNamaPembeliproperty
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnEditPenjualan_Click(sender As Object, e As EventArgs) Handles BtnEditPenjualan.Click
        Sign_In.Penjualan.harga_terjualproperty = Txtboxhargaterjual.Text.ToString()
        Sign_In.Penjualan.tanggal_penjualan = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Sign_In.Penjualan.UpdateDataKoleksiByIDDatabase(DatabaseMobil.selectedDatabaseMobil,
                                                              DatabasePembeli.selectedDatabasePembeli,
                                                              BukuPenjualan.selectedtablepenjualan,
                                                              Sign_In.Penjualan.harga_terjualproperty,
                                                              Sign_In.Penjualan.tanggal_penjualan)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenDatabaseMobil = New DatabaseMobil()
        OpenDatabaseMobil.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenDatabasePembeli = New DatabasePembeli()
        OpenDatabasePembeli.Show()
    End Sub
End Class

