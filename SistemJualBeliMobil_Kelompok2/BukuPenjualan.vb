Public Class BukuPenjualan
    Public Shared DatabaseMobil As DatabaseMobil
    Public Shared DatabasePembeli As DatabasePembeli

    Public Shared selectedtablepenjualan
    Public Shared selectedtablepenjualannama As String
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        DatabaseMobil = New DatabaseMobil()
        DatabasePembeli = New DatabasePembeli()

        ReloadDataTableDatabase()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnTambahPenjualan_Click(sender As Object, e As EventArgs)
        Dim tambah_penjualan = New TambahBukuPenjualan()
        tambah_penjualan.Show()
    End Sub

    Private Sub Penjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = Sign_In.Penjualan.GetDataPenjualanDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedtablepenjualan = selectedRow.Cells(0).Value
        selectedtablepenjualannama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedKoleksi As List(Of String) = Sign_In.Penjualan.GetDataPenjualanByIDDatabase(selectedtablepenjualan)
        Sign_In.Penjualan.CTipeMobilproperty = selectedKoleksi(2)
        Sign_In.Penjualan.CNamaPembeliproperty = selectedKoleksi(4)
        Sign_In.Penjualan.harga_terjualproperty = selectedKoleksi(5)
        Sign_In.Penjualan.tanggal_penjualan = selectedKoleksi(6)

        EditPenjualan.TBMobilTerjual.Text = Sign_In.Penjualan.CTipeMobilproperty
        EditPenjualan.TBPembeli.Text = Sign_In.Penjualan.CNamaPembeliproperty

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

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadDataTableDatabase()
    End Sub

    Private Sub BukuPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuPenjualanToolStripMenuItem.Click
        MessageBox.Show("Form Sudah Terbuka")
    End Sub

    Private Sub AdminDataAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminDataAccountToolStripMenuItem.Click
        Dim DataUser = New DataUsers
        DataUser.Show()
    End Sub

End Class
