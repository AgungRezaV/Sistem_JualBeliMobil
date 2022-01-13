Public Class JenisMobil
    Public Shared ClassJenisMobil As ClassJenisMobil
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub New()
        ClassJenisMobil = New ClassJenisMobil()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim buka_form1 = New TambahJenisMobil
        buka_form1.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DG.DataSource = ClassJenisMobil.GetDataKoleksiDatabaseJenisMobil()
    End Sub

    Private Sub JenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DG.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim SelectedKoleksi As List(Of String) = ClassJenisMobil.GetDataJenisMobilByIDDatabase(selectedTableKoleksi)
        ClassJenisMobil.Jenis_MobilProperty = SelectedKoleksi(1)

        Dim form_baru2 = New EditJenisMobil
        form_baru2.Show()
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim form_baru3 = New HapusJenis
        form_baru3.Show()
    End Sub

    Private Sub MobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobilToolStripMenuItem.Click
        Dim FormMobil = New Form_Mobil()
        FormMobil.Show()
        Me.Close()
    End Sub

    Private Sub PembeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembeliToolStripMenuItem.Click
        Dim FormPembeli = New DataPembeli()
        FormPembeli.Show()
        Me.Close()
    End Sub

    Private Sub BukuPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuPenjualanToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub JenisMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisMobilToolStripMenuItem.Click
        MessageBox.Show("Form Sudah Terbuka")
    End Sub
End Class