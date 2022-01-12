Public Class DatabaseMobil
    Public Shared selectedDatabaseMobil
    Public Shared selectedDatabaseMobilTipeMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

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
        Sign_In.Penjualan.CTipeMobilproperty = selectedDatabaseMobilTipeMobil
        TambahBukuPenjualan.TextBoxMobilTerjual.Text = selectedDatabaseMobilTipeMobil
        Me.Close()
    End Sub

    Private Sub DatabaseMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class