Public Class DataUsers

    Public Sub New()

        ' This call is required by the designer
        InitializeComponent()
        UpdateDataTableArrayList()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub UpdateDataTableArrayList()
        DataGridView1.Rows.Clear()
        For Each rowUser In Sign_In.USERS.getDataUsers()
            Dim dataTable As String() = {rowUser(0),
                                         rowUser(1)}
            DataGridView1.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub Array_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
    End Sub


    Private Sub BtnTambahUser_Click(sender As Object, e As EventArgs) Handles BtnTambahUser.Click
        Dim form_tambah = New SignUp
        SignUp.Show()
    End Sub
End Class