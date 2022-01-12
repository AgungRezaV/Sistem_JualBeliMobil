Public Class Form_Mobil
    Public Shared SelectedTableKoleksi
    Public Shared SelectedTableKoleksiNama
    Public Shared SelectedTableKoleksiTipeMobil

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'ReloadDataTableDatabase()
        BtnUpdate.Enabled = False
        ' Add any initialization after the InitializeComponent() call
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = Sign_In.ClassMobil.GetDataKoleksiDatabaseMobil()
    End Sub

    Private Sub Form_Mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
        TBJenisMobil.Text = DatabaseJenisMobil.SelectedTableJenisMobil
    End Sub

    'Button Tambah/Update Gambar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PBFoto.Load(picKoleksiDir)
        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Sign_In.ClassMobil.dirGambarBukuProperty = picKoleksiDir.ToString()
        Sign_In.ClassMobil.dirGambarBukuProperty = Sign_In.ClassMobil.dirGambarBukuProperty.Replace("\", "/")
    End Sub
    '-------CLOSE--------

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        Sign_In.ClassMobil.JenisMobilProperty = TBJenisMobil.Text.ToString()
        Sign_In.ClassMobil.TipeMobilProperty = TBTipeMobil.Text.ToString()
        Sign_In.ClassMobil.TahunPembuatanProperty = Integer.Parse(TBTahunPembuatan.Text)
        Sign_In.ClassMobil.HargaMobilProperty = Integer.Parse(TBHarga.Text)
        Sign_In.ClassMobil.GaransiMobilProperty = CBGaransi.SelectedItem().ToString()
        Sign_In.ClassMobil.HargaDefaultMobilProperty = Integer.Parse(TBHargaDefault.Text)
        If RBBaru.Checked Then
            Sign_In.ClassMobil.KondisiMobilProperty = "Baru"
        ElseIf RBBekas.Checked Then
            Sign_In.ClassMobil.KondisiMobilProperty = "Bekas"
        End If

        Sign_In.ClassMobil.AddDataKoleksiDatabaseMobil(
                                               DatabaseJenisMobil.selectedTable,
                                               Sign_In.ClassMobil.dirGambarBukuProperty,
                                               Sign_In.ClassMobil.TipeMobilProperty,
                                               Sign_In.ClassMobil.TahunPembuatanProperty,
                                               Sign_In.ClassMobil.KondisiMobilProperty,
                                               Sign_In.ClassMobil.HargaMobilProperty,
                                               Sign_In.ClassMobil.GaransiMobilProperty,
                                               Sign_In.ClassMobil.HargaDefaultMobilProperty)
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        If String.Compare(Sign_In.ClassMobil.KondisiMobilProperty, "Baru") = 0 Then
            RBBaru.Checked = False
        ElseIf String.Compare(Sign_In.ClassMobil.KondisiMobilProperty, "Bekas") = 0 Then
            RBBekas.Checked = False
        End If
        CBGaransi.Text = Nothing
        PBFoto.Image = Nothing
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        SelectedTableKoleksi = selectedRow.Cells(0).Value
        SelectedTableKoleksiNama = selectedRow.Cells(1).Value
        SelectedTableKoleksiTipeMobil = selectedRow.Cells(3).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim SelectedKoleksi As List(Of String) = Sign_In.ClassMobil.GetDataKoleksiByIDDatabaseMobil(SelectedTableKoleksi)
        Sign_In.ClassMobil.JenisMobilProperty = SelectedKoleksi(2)
        Sign_In.ClassMobil.dirGambarBukuProperty = SelectedKoleksi(3)
        Sign_In.ClassMobil.TipeMobilProperty = SelectedKoleksi(4)
        Sign_In.ClassMobil.TahunPembuatanProperty = SelectedKoleksi(5)
        Sign_In.ClassMobil.KondisiMobilProperty = SelectedKoleksi(6)
        Sign_In.ClassMobil.HargaMobilProperty = SelectedKoleksi(7)
        Sign_In.ClassMobil.GaransiMobilProperty = SelectedKoleksi(8)
        Sign_In.ClassMobil.HargaDefaultMobilProperty = SelectedKoleksi(9)

        TBJenisMobil.Text = Sign_In.ClassMobil.JenisMobilProperty
        PBFoto.Load(Sign_In.ClassMobil.dirGambarBukuProperty)
        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage
        TBTipeMobil.Text = Sign_In.ClassMobil.TipeMobilProperty
        TBTahunPembuatan.Text = Sign_In.ClassMobil.TahunPembuatanProperty
        TBHarga.Text = Sign_In.ClassMobil.HargaMobilProperty
        CBGaransi.SelectedItem() = Sign_In.ClassMobil.GaransiMobilProperty
        TBHargaDefault.Text = Sign_In.ClassMobil.HargaDefaultMobilProperty
        If String.Compare(Sign_In.ClassMobil.KondisiMobilProperty, "Baru") = 0 Then
            RBBaru.Checked = True
        ElseIf String.Compare(Sign_In.ClassMobil.KondisiMobilProperty, "Bekas") = 0 Then
            RBBekas.Checked = True
        End If

        BtnUpdate.Enabled = True
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Sign_In.ClassMobil.JenisMobilProperty = TBJenisMobil.Text
        Sign_In.ClassMobil.TipeMobilProperty = TBTipeMobil.Text.ToString()
        Sign_In.ClassMobil.TahunPembuatanProperty = Integer.Parse(TBTahunPembuatan.Text)
        Sign_In.ClassMobil.HargaMobilProperty = Integer.Parse(TBHarga.Text)
        Sign_In.ClassMobil.GaransiMobilProperty = CBGaransi.SelectedItem().ToString()
        Sign_In.ClassMobil.HargaDefaultMobilProperty = Integer.Parse(TBHargaDefault.Text)
        If RBBaru.Checked Then
            Sign_In.ClassMobil.KondisiMobilProperty = "Baru"
        ElseIf RBBekas.Checked Then
            Sign_In.ClassMobil.KondisiMobilProperty = "Bekas"
        End If

        Sign_In.ClassMobil.UpdateDataKoleksiByIDDatabaseMobil(SelectedTableKoleksi,
                                                  DatabaseJenisMobil.selectedTable,
                                                  Sign_In.ClassMobil.dirGambarBukuProperty,
                                                  Sign_In.ClassMobil.TipeMobilProperty,
                                                  Sign_In.ClassMobil.TahunPembuatanProperty,
                                                  Sign_In.ClassMobil.KondisiMobilProperty,
                                                  Sign_In.ClassMobil.HargaMobilProperty,
                                                  Sign_In.ClassMobil.GaransiMobilProperty,
                                                  Sign_In.ClassMobil.HargaDefaultMobilProperty)

        BtnUpdate.Visible = False
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        If String.Compare(Sign_In.ClassMobil.KondisiMobilProperty, "Baru") = 0 Then
            RBBaru.Checked = False
        ElseIf String.Compare(Sign_In.ClassMobil.KondisiMobilProperty, "Bekas") = 0 Then
            RBBekas.Checked = False
        End If
        CBGaransi.Text = Nothing
        PBFoto.Image = Nothing
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim open_form1 = New Form_Mobil_Hapus()
        open_form1.Show()
    End Sub

    Private Sub BtnEditJenisMobil_Click(sender As Object, e As EventArgs) Handles BtnEditJenisMobil.Click
        Dim open_form2 = New DatabaseJenisMobil()
        open_form2.Show()
    End Sub

    Private Sub BukuPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuPenjualanToolStripMenuItem.Click
        Dim FormBukuPenjualan = New BukuPenjualan()
        FormBukuPenjualan.Show()
        Me.Close()
    End Sub

    Private Sub JenisMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisMobilToolStripMenuItem.Click
        Dim FormJenisMobil = New JenisMobil()
        FormJenisMobil.Show()
        Me.Close()
    End Sub

    Private Sub PembeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembeliToolStripMenuItem.Click
        Dim FormPembeli = New DataPembeli()
        FormPembeli.Show()
        Me.Close()
    End Sub
End Class