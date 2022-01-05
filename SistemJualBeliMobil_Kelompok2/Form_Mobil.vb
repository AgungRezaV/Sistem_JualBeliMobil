Public Class Form_Mobil
    Public Shared ClassMobil As ClassMobil
    Public Shared ClassJenisMobil As ClassJenisMobil
    Public Shared Testing_JenisMobil As Testing_JenisMobil_Form
    Public Shared SelectedTableKoleksi
    Public Shared SelectedTableKoleksiNama
    Public Shared SelectedTableKoleksiTipeMobil

    Public Sub New()
        ClassMobil = New ClassMobil()
        ClassJenisMobil = New ClassJenisMobil()
        Testing_JenisMobil = New Testing_JenisMobil_Form()
        ' This call is required by the designer.
        InitializeComponent()
        'ReloadDataTableDatabase()
        BtnUpdate.Visible = False
        ' Add any initialization after the InitializeComponent() call.  
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = ClassMobil.GetDataKoleksiDatabaseMobil()
    End Sub

    Private Sub Form_Mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    'Button Tambah/Update Gambar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PBFoto.Load(picKoleksiDir)
        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage
        ClassMobil.dirGambarBukuProperty = picKoleksiDir.ToString()
        ClassMobil.dirGambarBukuProperty = ClassMobil.dirGambarBukuProperty.Replace("\", "/")
    End Sub
    '-------CLOSE--------

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        ClassMobil.TipeMobilProperty = TBTipeMobil.Text.ToString()
        ClassMobil.TahunPembuatanProperty = Integer.Parse(TBTahunPembuatan.Text)
        ClassMobil.HargaMobilProperty = Integer.Parse(TBHarga.Text)
        ClassMobil.GaransiMobilProperty = CBGaransi.SelectedItem().ToString()
        ClassMobil.HargaDefaultMobilProperty = Integer.Parse(TBHargaDefault.Text)
        If RBBaru.Checked Then
            ClassMobil.KondisiMobilProperty = "Baru"
        ElseIf RBBekas.Checked Then
            ClassMobil.KondisiMobilProperty = "Bekas"
        End If

        ClassMobil.AddDataKoleksiDatabaseMobil(ClassMobil.dirGambarBukuProperty,
                                               ClassMobil.TipeMobilProperty,
                                               ClassMobil.TahunPembuatanProperty,
                                               ClassMobil.KondisiMobilProperty,
                                               ClassMobil.HargaMobilProperty,
                                               ClassMobil.GaransiMobilProperty,
                                               ClassMobil.HargaDefaultMobilProperty)
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        If String.Compare(ClassMobil.KondisiMobilProperty, "Baru") = 0 Then
            RBBaru.Checked = False
        ElseIf String.Compare(ClassMobil.KondisiMobilProperty, "Bekas") = 0 Then
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

        selectedTableKoleksi = selectedRow.Cells(0).Value
        SelectedTableKoleksiNama = selectedRow.Cells(1).Value
        SelectedTableKoleksiTipeMobil = selectedRow.Cells(3).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim SelectedKoleksi As List(Of String) = ClassMobil.GetDataKoleksiByIDDatabaseMobil(SelectedTableKoleksi)
        ClassMobil.dirGambarBukuProperty = SelectedKoleksi(2)
        ClassMobil.TipeMobilProperty = SelectedKoleksi(3)
        ClassMobil.TahunPembuatanProperty = SelectedKoleksi(4)
        ClassMobil.KondisiMobilProperty = SelectedKoleksi(5)
        ClassMobil.HargaMobilProperty = SelectedKoleksi(6)
        ClassMobil.GaransiMobilProperty = SelectedKoleksi(7)
        ClassMobil.HargaDefaultMobilProperty = SelectedKoleksi(8)

        PBFoto.Load(ClassMobil.dirGambarBukuProperty)
        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage
        TBTipeMobil.Text = ClassMobil.TipeMobilProperty
        TBTahunPembuatan.Text = ClassMobil.TahunPembuatanProperty
        TBHarga.Text = ClassMobil.HargaMobilProperty
        CBGaransi.SelectedItem() = ClassMobil.GaransiMobilProperty
        TBHargaDefault.Text = ClassMobil.HargaDefaultMobilProperty
        If String.Compare(ClassMobil.KondisiMobilProperty, "Baru") = 0 Then
            RBBaru.Checked = True
        ElseIf String.Compare(ClassMobil.KondisiMobilProperty, "Bekas") = 0 Then
            RBBekas.Checked = True
        End If

        BtnUpdate.Visible = True

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ClassMobil.TipeMobilProperty = TBTipeMobil.Text.ToString()
        ClassMobil.TahunPembuatanProperty = Integer.Parse(TBTahunPembuatan.Text)
        ClassMobil.HargaMobilProperty = Integer.Parse(TBHarga.Text)
        ClassMobil.GaransiMobilProperty = CBGaransi.SelectedItem().ToString()
        ClassMobil.HargaDefaultMobilProperty = Integer.Parse(TBHargaDefault.Text)
        If RBBaru.Checked Then
            ClassMobil.KondisiMobilProperty = "Baru"
        ElseIf RBBekas.Checked Then
            ClassMobil.KondisiMobilProperty = "Bekas"
        End If

        ClassMobil.UpdateDataKoleksiByIDDatabaseMobil(SelectedTableKoleksi,
                                              ClassMobil.dirGambarBukuProperty,
                                              ClassMobil.TipeMobilProperty,
                                              ClassMobil.TahunPembuatanProperty,
                                              ClassMobil.KondisiMobilProperty,
                                              ClassMobil.HargaMobilProperty,
                                              ClassMobil.GaransiMobilProperty,
                                              ClassMobil.HargaDefaultMobilProperty)

        BtnUpdate.Visible = False
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next

        If String.Compare(ClassMobil.KondisiMobilProperty, "Baru") = 0 Then
            RBBaru.Checked = False
        ElseIf String.Compare(ClassMobil.KondisiMobilProperty, "Bekas") = 0 Then
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

    Private Sub BtnFormJenisMobil_Click(sender As Object, e As EventArgs) Handles BtnFormJenisMobil.Click
        Dim open_form2 = New Testing_JenisMobil_Form()
        open_form2.Show()
    End Sub
End Class