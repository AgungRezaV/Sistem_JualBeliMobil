Public Class DataUsers

    Public Shared users As users
    Public Sub New()

        ' This call is required by the designer
        InitializeComponent()
        users = New users()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnTambahUser_Click(sender As Object, e As EventArgs) Handles BtnTambahUser.Click
        Dim form_tambah = New SignUp
        SignUp.Show()
    End Sub

    Private Sub DataUsers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloaddatatabledatabase()
    End Sub

    Private Sub reloaddatatabledatabase()
        DataGridView1.DataSource = users.GetDataUsersFromDatabase()
    End Sub
End Class