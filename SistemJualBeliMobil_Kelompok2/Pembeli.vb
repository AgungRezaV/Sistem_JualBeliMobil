Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Pembeli
    Private Nik As String
    Private Nama As String
    Private Alamat As String

    Private PembeliDataTamble As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = " "
    Private database As String = "dbmobil"

    Public Property Nikproperty() As String
        Get
            Return Nik
        End Get
        Set(ByVal value As String)
            Nik = value
        End Set
    End Property

    Public Property NamaProperty() As String
        Get
            Return Nama
        End Get
        Set(ByVal value As String)
            Nama = value
        End Set
    End Property

    Public Property AlamatProperty() As String
        Get
            Return Alamat
        End Get
        Set(ByVal value As String)
            Alamat = value
        End Set
    End Property

    Public Shared selectedtablekoleksi
    Public Sub updatedatatablearraylist()
        'Rows.Clear()

    End Sub

    Public ReadOnly Property getpembelidatatable() As ArrayList
        Get
            Return PembeliDataTamble
        End Get
    End Property

    Public Function GetDataPembeliDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database

        '   dbConn.ConnectionString = "server = " + server + ";" + "Nik=" + Nik + ";" + "user id=" + Nama + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_pembeli AS 'ID',
                                 Nik AS 'Nik',
                                 Nama AS 'Nama Pembeli',
                                 Alamat AS 'Alamat'
                                 FROM pembeli"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function AddDataPembeliDatabase(Nik As String,
                                            Nama As String,
                                            Alamat As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO pembeli(Nik, Nama, Alamat) VALUE('" _
                                & Nik & "', '" _
                                & Nama & "', '" _
                                & Alamat & "')"



            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()


            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataPembeliByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_pembeli,
                                 Nik,
                                 Nama,
                                 Alamat
                                 FROM Pembeli
                                 WHERE id_pembeli='" & ID & "'"


        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataPembeliByIDDatabase(ID As Integer,
                                                  Nik As String,
                                                  Nama As String,
                                                  Alamat As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE Pembeli SET " &
                        " Nik ='" & Nik & "'," &
                        " Nama ='" & Nama & "'," &
                        " Alamat='" & Alamat & "' " &
                        " WHERE id_pembeli='" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function DeleteDataPembeliByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM Pembeli " &
                        "WHERE id_pembeli='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
