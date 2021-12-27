Public Class Sign_In
    Public Shared USERS As users


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        USERS = New users
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxpassword.Text

        Dim data_user As List(Of String) = USERS.CheckAuthDatabase(plainUsername, plainPassword)
        'messagebox.show(authstatus)

        If data_user.Count > 0 Then
            USERS.realUsernameProperty = data_user(1)
            testlogin.Show()
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