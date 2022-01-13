Imports MySql.Data.MySqlClient

Public Class Penjualan
    Private CTipeMobil As String
    Private CNamaPembeli As String
    Private CHarga_Terjual As Integer
    Private CTanggal_Penjualan As String

    Public Property CTipeMobilproperty() As String
        Get
            Return CTipeMobil
        End Get
        Set(ByVal value As String)
            CTipeMobil = value
        End Set
    End Property

    Public Property CNamaPembeliproperty() As String
        Get
            Return CNamaPembeli
        End Get
        Set(ByVal value As String)
            CNamaPembeli = value
        End Set
    End Property

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

    Public Function GetDataPenjualanDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT tp.id_penjualan AS 'ID',
                                    tp.id_mobil AS 'ID Mobil',
                                    tm.tipe_mobil AS 'Tipe Mobil',
                                    tp.id_pembeli AS 'ID Pembeli',
                                    pb.Nama AS 'Nama Pembeli',
                                    tp.harga_terjual AS 'Harga Terjual',
                                    tp.tanggal_terjual AS 'Tanggal Penjualan'
                                    FROM tbpenjualan AS tp
                                    JOIN tbmobil AS tm ON tp.id_mobil=tm.id_mobil
                                    JOIN pembeli AS pb ON tp.id_pembeli=pb.id_pembeli"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataPenjualanDatabase(id_mobil As Integer,
                                           id_pembeli As Integer,
                                           harga_terjual As Integer,
                                           tanggal_terjual As Date)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO tbpenjualan(id_mobil, id_pembeli, harga_terjual, tanggal_terjual) VALUE('" _
            & id_mobil & "', '" _
            & id_pembeli & "', '" _
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

    Public Function GetDataPenjualanByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT tp.id_penjualan,
                                    tp.id_mobil,
                                    tm.tipe_mobil,
                                    tp.id_pembeli,
                                    pb.Nama,
                                    tp.harga_terjual,
                                    tp.tanggal_terjual
                                    FROM tbpenjualan AS tp
                                    JOIN tbmobil AS tm ON tp.id_mobil=tm.id_mobil
                                    JOIN pembeli AS pb ON tp.id_pembeli=pb.id_pembeli
                                    WHERE id_penjualan='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataPenjualanByIDDatabase(ID As Integer,
                                                  id_mobil As Integer,
                                                  id_pembeli As Integer,
                                                  harga_terjual As Integer,
                                                  tanggal_terjual As Date)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                    + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE tbpenjualan SET " &
                "id_mobil='" & id_mobil & "', " &
                "id_pembeli='" & id_pembeli & "', " &
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

    Public Function DeleteDataPenjualanByIDDatabase(ID As Integer)
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
