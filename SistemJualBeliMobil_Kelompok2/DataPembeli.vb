
Public Class DataPembeli

    Public Shared SelectedId
    Public Shared SelectedTableNik
    Public Shared SelectedTableNama
    Public Shared SelectedTableAlamat

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        reloaddatatabledatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ButtonTambahData_Click(sender As Object, e As EventArgs) Handles ButtonTambahData.Click
        Dim formTambah1 = New TambahDataPembeli()
        formTambah1.Show()

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        SelectedId = selectedRow.Cells(0).Value
        SelectedTableNik = selectedRow.Cells(1).Value
        SelectedTableNama = selectedRow.Cells(2).Value
        SelectedTableAlamat = selectedRow.Cells(3).Value
    End Sub
    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim SelectedDataPembeli As List(Of String) = Sign_In.Pembeli.GetDataPembeliByIDDatabase(SelectedId)
        Sign_In.Pembeli.Nikproperty = SelectedDataPembeli(1)
        Sign_In.Pembeli.NamaProperty = SelectedDataPembeli(2)
        Sign_In.Pembeli.AlamatProperty = SelectedDataPembeli(3)

        Dim FormEdit1 = New EditDataPembeli()
        FormEdit1.Show()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Dim formhapus1 = New HapusDataPembeli()
        formhapus1.Show()
    End Sub

    Private Sub reloaddatatabledatabase()
        DataGridView1.DataSource = Sign_In.Pembeli.GetDataPembeliDatabase()

    End Sub

    'event kalo form nya di aktifkan jadi databasenya ke reload
    Private Sub DataPembeli_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloaddatatabledatabase()
    End Sub

    Private Sub MobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobilToolStripMenuItem.Click
        Dim FormMobil = New Form_Mobil()
        FormMobil.Show()
        Me.Close()
    End Sub

    Private Sub BukuPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuPenjualanToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub JenisMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisMobilToolStripMenuItem.Click
        Dim FormJenisMobil = New JenisMobil()
        FormJenisMobil.Show()
        Me.Close()
    End Sub

    Private Sub PembeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembeliToolStripMenuItem.Click
        MessageBox.Show("Form Sudah Terbuka")
    End Sub
End Class