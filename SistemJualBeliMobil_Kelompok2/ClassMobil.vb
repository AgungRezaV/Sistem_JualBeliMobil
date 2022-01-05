Imports System.Text
Imports MySql.Data.MySqlClient
Public Class ClassMobil
    Private ClassGambar
    'Private ClassJenisMobil As String
    Private ClassTipeMobil As String
    Private ClassTahunPembuatan As String
    Private ClassKondisi As String
    Private ClassHarga As Integer
    Private ClassGaransi As String
    Private ClassHargaDefault As Integer

    'Getter and Setter untuk Form Mobil
    Public Property dirGambarBukuProperty() As String
        Get
            Return ClassGambar
        End Get
        Set(ByVal value As String)
            ClassGambar = value
        End Set
    End Property

    'Public Property JenisMobilProperty() As String
    '    Get
    '        Return ClassJenisMobil
    '    End Get
    '    Set(ByVal value As String)
    '        ClassJenisMobil = value
    '    End Set
    'End Property

    Public Property TipeMobilProperty() As String
        Get
            Return ClassTipeMobil
        End Get
        Set(ByVal value As String)
            ClassTipeMobil = value
        End Set
    End Property

    Public Property TahunPembuatanProperty() As String
        Get
            Return ClassTahunPembuatan
        End Get
        Set(ByVal value As String)
            ClassTahunPembuatan = value
        End Set
    End Property

    Public Property KondisiMobilProperty() As String
        Get
            Return ClassKondisi
        End Get
        Set(ByVal value As String)
            ClassKondisi = value
        End Set
    End Property

    Public Property HargaMobilProperty() As Integer
        Get
            Return ClassHarga
        End Get
        Set(ByVal value As Integer)
            ClassHarga = value
        End Set
    End Property

    Public Property GaransiMobilProperty() As String
        Get
            Return ClassGaransi
        End Get
        Set(ByVal value As String)
            ClassGaransi = value
        End Set
    End Property

    Public Property HargaDefaultMobilProperty() As Integer
        Get
            Return ClassHargaDefault
        End Get
        Set(ByVal value As Integer)
            ClassHargaDefault = value
        End Set
    End Property
    '---------CLOSE-----------

    'Database Section
    'Variabel Declaration
    Public Shared ID
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader

    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = " "
    Private database As String = "dbmobil"

    'Get data FOR Perpus from Database
    Public Function GetDataKoleksiDatabaseMobil() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT tm.id_mobil AS 'ID',
                                    tm.id_jenis_mobil AS 'ID Jenis Mobil',
                                    jm.jenis_mobil As 'Jenis Mobil',
                                    tm.tipe_mobil AS 'Tipe Mobil',
                                    tm.tahun_pembuatan AS 'Tahun Pembuatan',
                                    tm.kondisi AS 'Kondisi',
                                    tm.harga AS 'Harga',
                                    tm.garansi AS 'Garansi',
                                    tm.harga_default AS 'Harga Default'
                                    FROM tbmobil AS tm
                                    JOIN jenismobil AS jm ON tm.id_jenis_mobil=jm.id_jenis_mobil"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    '-----------CLOSE-----------

    Public Function AddDataKoleksiDatabaseMobil(dir_gambar As String,
                                                tipe_mobil As String,
                                                tahun_pembuatan As String,
                                                kondisi As String,
                                                harga As Integer,
                                                garansi As String,
                                                harga_default As Integer)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO tbmobil(dir_gambar, tipe_mobil, tahun_pembuatan, kondisi, harga, garansi, harga_default) VALUE('" _
            & dir_gambar & "', '" _
            & tipe_mobil & "', '" _
            & tahun_pembuatan & "', '" _
            & kondisi & "', '" _
            & harga & "', '" _
            & garansi & "', '" _
            & harga_default & "')"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    'Delete Button di Database
    Public Function DeleteDataKoleksiByIDDatabaseMobil(ID As Integer)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM tbmobil " &
                        "WHERE id_mobil = '" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlQuery)

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
    '-------CLOSE--------

    'DATABSE UNTUK FORM JENIS MOBIL

    '--------CLOSE----------

    'EDIT BUTTON DATABASE MOBIL
    Public Function GetDataKoleksiByIDDatabaseMobil(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_mobil,
                                    dir_gambar,
                                    tipe_mobil,
                                    tahun_pembuatan,
                                    kondisi,
                                    harga,
                                    garansi,
                                    harga_default
                                    FROM tbmobil
                                    WHERE id_mobil='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabaseMobil(ID As Integer,
                                                  dir_gambar As String,
                                                  tipe_mobil As String,
                                                  tahun_pembuatan As String,
                                                  kondisi As String,
                                                  harga As Integer,
                                                  garansi As String,
                                                  harga_default As Integer)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE tbmobil SET " &
            "dir_gambar='" & dir_gambar & "', " &
            "tipe_mobil='" & tipe_mobil & "', " &
            "tahun_pembuatan='" & tahun_pembuatan & "', " &
            "kondisi='" & kondisi & "', " &
            "harga='" & harga & "', " &
            "garansi='" & garansi & "', " &
            "harga_default='" & harga_default & "' " &
            "WHERE id_mobil='" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
    '------------close--------------
End Class
