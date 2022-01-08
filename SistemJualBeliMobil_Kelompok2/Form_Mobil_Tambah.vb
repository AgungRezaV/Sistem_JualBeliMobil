Imports System.IO
Public Class Form_Mobil_Tambah

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReloadDataTableDatabase()
        Form_Mobil.DataGridView1.DataSource = Form_Mobil.ClassMobil.GetDataKoleksiDatabaseMobil()
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PBFoto.Load(picKoleksiDir)
        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Form_Mobil.ClassMobil.dirGambarBukuProperty = picKoleksiDir.ToString()
        Form_Mobil.ClassMobil.dirGambarBukuProperty = Form_Mobil.ClassMobil.dirGambarBukuProperty.Replace("\", "/")
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Form_Mobil.ClassMobil.TipeMobilProperty = TBTipeMobil.Text.ToString()
        Form_Mobil.ClassMobil.TahunPembuatanProperty = Integer.Parse(TBTahunPembuatan.Text)
        Form_Mobil.ClassMobil.HargaMobilProperty = Integer.Parse(TBHarga.Text)
        Form_Mobil.ClassMobil.GaransiMobilProperty = CBGaransi.SelectedItem().ToString()
        Form_Mobil.ClassMobil.HargaDefaultMobilProperty = Integer.Parse(TBHargaDefault.Text)
        If RBBaru.Checked Then
            Form_Mobil.ClassMobil.KondisiMobilProperty = "Baru"
        ElseIf RBBekas.Checked Then
            Form_Mobil.ClassMobil.KondisiMobilProperty = "Bekas"
        End If

        Form_Mobil.ClassMobil.AddDataKoleksiDatabaseMobil(Form_Mobil.ClassMobil.JenisMobilProperty,
                                                          Form_Mobil.ClassMobil.dirGambarBukuProperty,
                                                          Form_Mobil.ClassMobil.TipeMobilProperty,
                                                          Form_Mobil.ClassMobil.TahunPembuatanProperty,
                                                          Form_Mobil.ClassMobil.KondisiMobilProperty,
                                                          Form_Mobil.ClassMobil.HargaMobilProperty,
                                                          Form_Mobil.ClassMobil.GaransiMobilProperty,
                                                          Form_Mobil.ClassMobil.HargaDefaultMobilProperty)
        ReloadDataTableDatabase()
        Me.Close()
    End Sub
End Class