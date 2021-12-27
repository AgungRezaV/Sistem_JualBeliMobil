

Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class users
    'Pendeklarasian untuk username dan password
    Private username As String
    Private password As String
    Private email As String

    'Variabel Untuk Database
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "sistemjualbelimobil"

    Private TripleDes As New TripleDESCryptoServiceProvider
    Public Function EncrypData(ByVal plaintext As String) As String

        'convert the plaintext string to a byte array
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'create the stream
        Dim ms As New System.IO.MemoryStream

        'create the encoder to write the stream
        Dim encStream As New CryptoStream(ms,
          TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        'use the crypto stream to write the byte array to the stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'convert the encrypted stream to a printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Private DataUsers As New ArrayList()
    Private realUsername As String
    Private realPassword As String

    Public Property realUsernameProperty() As String
        Get
            Return realUsername
        End Get
        Set(ByVal value As String)
            realUsername = value
        End Set
    End Property

    Public Property realPasswordProperty() As String
        Get
            Return realPassword
        End Get
        Set(ByVal value As String)

            realPassword = value
        End Set
    End Property

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String

        For Each user_data In getDataUsers()
            Dim username_table As String = user_data(0)
            Dim password_table As String = user_data(1)
            Dim email_table As String = user_data(2)
            If String.Compare(username_table, username) = 0 Then
                If String.Compare(username_table, username) = 0 And String.Compare(EncrypData(plainPassword), password_table) = 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Next

        Return False
    End Function

    Public Function addDataUsers(realUsername As String,
                                 realPassword As String)

        DataUsers.Add({realUsername,
          EncrypData(realPassword)})
    End Function

    Public Function removeDataKoleksi(index As Integer)
        DataUsers.RemoveAt(index)
    End Function

    Public ReadOnly Property getDataUsers() As ArrayList
        Get
            Return DataUsers
        End Get
    End Property

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()

        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUsersDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO users(username, password, registered_at)
                        VALUE('" & username_regist & "','" _
                                & EncryptMD5(password_regist) & "', '" _
                                & today.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)

        Try
            Dim result As New List(Of String)
            dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username
                            FROM users
                            WHERE username='" & username_login & "'AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function


End Class
