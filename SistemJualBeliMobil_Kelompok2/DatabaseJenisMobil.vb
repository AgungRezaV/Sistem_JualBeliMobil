Public Class DatabaseJenisMobil

    Public Shared ClassMobil As ClassMobil

    Public Shared selectedTable As Integer
    Public Shared SelectedTableJenisMobil As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ClassMobil = New ClassMobil()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ReloadDataTableDatabaseJenisMobil()
        DataGridView1.DataSource = Sign_In.ClassJenisMobil.GetDataKoleksiDatabaseJenisMobil()
    End Sub

    Private Sub Testing_JenisMobil_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabaseJenisMobil()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedTable = selectedRow.Cells(0).Value
        SelectedTableJenisMobil = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If selectedTable = 0 Then
            MessageBox.Show("Gakada nilai")
        Else
            Form_Mobil.Activate()
        End If

        Me.Close()
    End Sub
End Class