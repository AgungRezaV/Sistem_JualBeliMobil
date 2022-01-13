Public Class DatabaseMobil
    Public Shared selectedDatabaseMobil
    Public Shared selectedDatabaseMobilTipeMobil
    Public Shared EditPenjualan As EditPenjualan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        EditPenjualan = New EditPenjualan()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = Sign_In.ClassMobil.GetDataKoleksiDatabaseMobil()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedDatabaseMobil = selectedRow.Cells(0).Value
        selectedDatabaseMobilTipeMobil = selectedRow.Cells(3).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selectedDatabaseMobil = 0 Then
            MessageBox.Show("Silahkan Pilih Terlebih Dahulu Nilai yang ingin di pilih")
        Else
            Sign_In.Penjualan.CTipeMobilproperty = selectedDatabaseMobilTipeMobil
            MessageBox.Show(selectedDatabaseMobilTipeMobil)
            EditPenjualan.Activate()
        End If

        Me.Close()
    End Sub

    Private Sub DatabaseMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class