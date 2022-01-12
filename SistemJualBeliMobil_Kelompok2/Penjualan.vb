Imports MySql.Data.MySqlClient

Public Class Penjualan
    Private CHarga_Terjual As Integer
    Private CTanggal_Penjualan As String
    Public Property harga_terjualproperty() As String
        Get
            Return CHarga_Terjual
        End Get
        Set(ByVal value As String)
            CHarga_Terjual = value
        End Set
    End Property

    Public Property tanggal_penjualan() As String
        Get
            Return CTanggal_Penjualan
        End Get
        Set(ByVal value As String)
            CTanggal_Penjualan = value
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

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT id_penjualan AS 'ID',
                                    harga_terjual AS 'Harga Terjual',
                                    tanggal_terjual AS 'Tanggal Penjualan'
                                    FROM tbpenjualan"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(harga_terjual As Integer,
                                               tanggal_terjual As Date)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO tbpenjualan(harga_terjual, tanggal_terjual) VALUE('" _
                & harga_terjual & "', '" _
                & tanggal_terjual.ToString("yyyy/MM/dd") & "')"
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

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penjualan,
                                    harga_terjual,
                                    tanggal_terjual
                                    FROM tbpenjualan
                                    WHERE id_penjualan='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                      harga_terjual As Integer,
                                                      tanggal_terjual As Date)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE tbpenjualan SET " &
                "harga_terjual='" & harga_terjual & "', " &
                "tanggal_terjual='" & tanggal_terjual.ToString("yyyy/MM/dd") & "' " &
                "WHERE id_penjualan='" & ID & "'"
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

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
                + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM tbpenjualan " &
                    "WHERE id_penjualan='" & ID & "'"

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
