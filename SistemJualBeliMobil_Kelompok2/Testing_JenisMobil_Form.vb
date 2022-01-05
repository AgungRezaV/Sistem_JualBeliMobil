Public Class Testing_JenisMobil_Form
    Public Shared SelectedTableKoleksiJenisMobil
    Public Shared selectedTableKoleksi
    Public Shared ClassJenisMobil As ClassJenisMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ClassJenisMobil = New ClassJenisMobil()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReloadDataTableDatabaseJenisMobil()
        DataGridView1.DataSource = ClassJenisMobil.GetDatabaseJenisMobil
    End Sub

    Private Sub MobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobilToolStripMenuItem.Click
        Dim Form1 = New Form_Mobil()
        Form1.Show()
    End Sub

    Private Sub Testing_JenisMobil_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabaseJenisMobil()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        SelectedTableKoleksiJenisMobil = selectedRow.Cells(1).Value
    End Sub
End Class