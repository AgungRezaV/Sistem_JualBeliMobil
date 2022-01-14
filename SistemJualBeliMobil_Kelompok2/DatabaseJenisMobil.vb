Public Class DatabaseJenisMobil

    Public Shared ClassMobil As ClassMobil
    Public Shared Form_Mobil As Form_Mobil

    Public Shared selectedTable As Integer
    Public Shared SelectedTableJenisMobil As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ClassMobil = New ClassMobil()
        Form_Mobil = New Form_Mobil()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ReloadDataTableDatabaseJenisMobil()
        DataGridView1.DataSource = Sign_In.ClassJenisMobil.GetDataDatabaseJenisMobil()
    End Sub

    Private Sub Testing_JenisMobil_Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabaseJenisMobil()
        Form_Mobil.TBJenisMobil.Text = SelectedTableJenisMobil
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        Sign_In.Form_Mobil.SelectedTableIDJenisMobil = selectedRow.Cells(0).Value
        Sign_In.Form_Mobil.SelectedTableNamaJenisMobil = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If Sign_In.Form_Mobil.SelectedTableIDJenisMobil = 0 Then
            MessageBox.Show("Silahkan Pilih Terlebih dahulu")
        Else
            Sign_In.Form_Mobil.TBJenisMobil.Text = SelectedTableJenisMobil
            'Form_Mobil.TBJenisMobil.Text = SelectedTableJenisMobil
            Form_Mobil.Activate()
        End If

        Me.Close()
    End Sub
End Class