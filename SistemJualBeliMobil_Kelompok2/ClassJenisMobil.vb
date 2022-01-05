Imports MySql.Data.MySqlClient

Public Class ClassJenisMobil
    Private ClassJenisMobil

    Public Property JenisMobilProperty As String
        Get
            Return ClassJenisMobil
        End Get
        Set(ByVal value As String)
            ClassJenisMobil = value
        End Set
    End Property

    Public Shared ID
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader

    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = " "
    Private database As String = "dbmobil"

    Public Function GetDatabaseJenisMobil() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT id_jenis_mobil AS 'ID',
                                    jenis_mobil AS 'Jenis Mobil'
                                    FROM jenismobil"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDatabaseJenisMobilById(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_mobil,
                                    jenis_mobil
                                    FROM jenismobil
                                    WHERE id_jenis_mobil='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
End Class
