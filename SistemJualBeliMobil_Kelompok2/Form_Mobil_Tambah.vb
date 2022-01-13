Imports System.IO
Public Class Form_Mobil_Tambah

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "|*.*"
        OpenFileDialog1.ShowDialog()
        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PBFoto.Load(picKoleksiDir)
        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Sign_In.ClassMobil.dirGambarMobilProperty = picKoleksiDir.ToString()
        Sign_In.ClassMobil.dirGambarMobilProperty = Sign_In.ClassMobil.dirGambarMobilProperty.Replace("\", "/")
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
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

        Sign_In.ClassMobil.AddDataDatabaseMobil(Sign_In.ClassMobil.JenisMobilProperty,
                                                          Sign_In.ClassMobil.dirGambarMobilProperty,
                                                          Sign_In.ClassMobil.TipeMobilProperty,
                                                          Sign_In.ClassMobil.TahunPembuatanProperty,
                                                          Sign_In.ClassMobil.KondisiMobilProperty,
                                                          Sign_In.ClassMobil.HargaMobilProperty,
                                                          Sign_In.ClassMobil.GaransiMobilProperty,
                                                          Sign_In.ClassMobil.HargaDefaultMobilProperty)
        Me.Close()
    End Sub
End Class