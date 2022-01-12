Public Class BukuPenjualan

    Public Shared Penjualan As Penjualan


    Public Shared selected_penjualan As String
    Public Shared selectedtablepenjualan
    Public Shared selectedtablepenjualannama As String
    Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()
        Penjualan = New Penjualan
        ReloadDataTableDatabase()
        'Users = New users
        'UpdateDataTableArrayList()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnTambahPenjualan_Click(sender As Object, e As EventArgs)
        Dim tambah_penjualan = New TambahBukuPenjualan()
        tambah_penjualan.Show()
    End Sub

    Private Sub BtnKurangPenjualan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Penjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = Penjualan.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedtablepenjualan = selectedRow.Cells(0).Value
        selectedtablepenjualannama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedKoleksi As List(Of String) = Penjualan.GetDataKoleksiByIDDatabase(selectedtablepenjualan)

        Penjualan.harga_terjualproperty = selectedKoleksi(1)

        Penjualan.tanggal_penjualan = selectedKoleksi(2)

        Dim formEdit = New EditPenjualan()
        formEdit.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim formHapus = New HapusPenjualan()
        formHapus.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If DataPembeli.DataGridView1.RowCount < 2 Then
            MessageBox.Show("Tolong Input Data Pembeli Terlebih Dahulu")
        Else
            Dim formTambah = New TambahBukuPenjualan()
            formTambah.Show()
        End If

    End Sub

    Private Sub MobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobilToolStripMenuItem.Click
        Dim FormMobil = New Form_Mobil()
        FormMobil.Show()
    End Sub

    Private Sub JenisMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisMobilToolStripMenuItem.Click
        Dim FormJenisMobil = New JenisMobil()
        FormJenisMobil.Show()
    End Sub

    Private Sub PembeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembeliToolStripMenuItem.Click
        Dim FormPembeli = New DataPembeli()
        FormPembeli.Show()
    End Sub
End Class
