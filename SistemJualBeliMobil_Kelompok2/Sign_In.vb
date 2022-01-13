Public Class Sign_In
    Public Shared USERS As users
    Public Shared ClassMobil As ClassMobil
    Public Shared Penjualan As Penjualan
    Public Shared ClassJenisMobil As ClassJenisMobil
    Public Shared Pembeli As Pembeli
    Public Shared Testing_JenisMobil As DatabaseJenisMobil

    Public Shared Form_Mobil As Form_Mobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TextBoxpassword.PasswordChar = "*"

        ' Add any initialization after the InitializeComponent() call.
        USERS = New users
        ClassMobil = New ClassMobil()
        Penjualan = New Penjualan()
        ClassJenisMobil = New ClassJenisMobil()
        Pembeli = New Pembeli()
        Form_Mobil = New Form_Mobil()

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxpassword.Text

        Dim data_user As List(Of String) = USERS.CheckAuthDatabase(plainUsername, plainPassword)
        'messagebox.show(authstatus)

        If data_user.Count > 0 Then

            USERS.realUsernameProperty = data_user(1)
            Dim formpenjualan = New BukuPenjualan()
            formpenjualan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password Anda Salah")
        End If
    End Sub

    Private Sub Buttonsignup_Click(sender As Object, e As EventArgs) Handles Buttonsignup.Click
        Dim signup = New SignUp
        signup.Show()
    End Sub
End Class