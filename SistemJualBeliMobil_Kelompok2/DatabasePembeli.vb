Public Class DatabasePembeli
    Public Shared selectedDatabasePembeli
    Public Shared selectedDatabaseNamaPembeli

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = Sign_In.Pembeli.GetDataPembeliDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedDatabasePembeli = selectedRow.Cells(0).Value
        selectedDatabaseNamaPembeli = selectedRow.Cells(2).Value
    End Sub

    Private Sub DatabaseMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selectedDatabasePembeli = 0 Then
            MessageBox.Show("Silahkan Pilih Terlebih Dahulu Nilai yang ingin di pilih")
        Else
            Sign_In.Penjualan.CNamaPembeliproperty = selectedDatabaseNamaPembeli
            EditPenjualan.Activate()
        End If

        Me.Close()
    End Sub
End Class