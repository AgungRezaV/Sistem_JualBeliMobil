Public Class EditPenjualan
    Public Shared SelectedTableEditPenjualan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TBMobilTerjual.Text = Sign_In.Penjualan.CTipeMobilproperty
        TBPembeli.Text = Sign_In.Penjualan.CNamaPembeliproperty
        Txtboxhargaterjual.Text = Sign_In.Penjualan.harga_terjualproperty
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnEditPenjualan_Click(sender As Object, e As EventArgs) Handles BtnEditPenjualan.Click
        Sign_In.Penjualan.CTipeMobilproperty = TBMobilTerjual.Text.ToString()
        Sign_In.Penjualan.CNamaPembeliproperty = TBPembeli.Text.ToString()
        Sign_In.Penjualan.harga_terjualproperty = Txtboxhargaterjual.Text.ToString()
        Sign_In.Penjualan.tanggal_penjualan = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Sign_In.Penjualan.UpdateDataPenjualanByIDDatabase(BukuPenjualan.selectedtablepenjualan,
                                                        DatabaseMobil.selectedDatabaseMobil,
                                                        DatabasePembeli.selectedDatabasePembeli,
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

    Private Sub EditPenjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DatabaseMobil.DataGridView1.DataSource = Sign_In.ClassMobil.GetDataKoleksiDatabaseMobil()
        DatabasePembeli.DataGridView1.DataSource = Sign_In.Pembeli.GetDataPembeliDatabase()
        TBMobilTerjual.Text = Sign_In.Penjualan.CTipeMobilproperty
        TBPembeli.Text = Sign_In.Penjualan.CNamaPembeliproperty
        BukuPenjualan.Activate()
    End Sub
End Class

