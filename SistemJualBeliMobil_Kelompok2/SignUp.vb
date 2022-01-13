Public Class SignUp

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        If TextBoxUsername.Text.Length > 0 And TextBoxpassword.Text.Length > 0 Then
            Sign_In.USERS.AddUsersDatabase(TextBoxUsername.Text, TextBoxpassword.Text, TextBoxEmail.Text)

            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data Terlebih Dahulu")
        End If

    End Sub

End Class