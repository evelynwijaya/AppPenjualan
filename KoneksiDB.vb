Imports System.Data
Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Module KoneksiDB
    Public strkon As String = "server=localhost;user=root;database=tokobaju"

    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public da2 As OdbcDataAdapter
    Public ds2 As DataSet
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader
    Public konek As MySqlConnection = New MySqlConnection(strkon)
    Public da3 As MySqlDataAdapter
    Public conn2 As OdbcConnection
    Public cmd2 As New MySqlCommand
    Public dr2 As MySqlDataReader
    Public str As String
    Public Sub KonekDB()
        Try
            str = "Driver={MYSQL ODBC 5.3 ANSI Driver};database =tokobaju;server=localhost;user=root;password="
            conn = New OdbcConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function koneksi() As Boolean
        Try
            If konek.State = ConnectionState.Closed Then
                konek.Open()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Koneksi Database Bermasalah, Periksa Koneksi Jaringan..", 48, "Perhatian")
            Return False
        End Try
    End Function

    Sub tampildata(ByVal sqldata As String, ByVal sqltabel As String)
        Try
            da = New Data.Odbc.OdbcDataAdapter(sqldata, conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, sqltabel)
        Catch ex As Exception
            MsgBox(ex.ToString, 16, "ERROR")
        End Try
    End Sub

    Sub simpandata(ByVal sqlisi As String)
        Try
            Call KonekDB()
            Dim sqlquery As New Odbc.OdbcCommand
            sqlquery.Connection = conn
            sqlquery.CommandType = CommandType.Text
            sqlquery.CommandText = sqlisi
            sqlquery.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString, 16, "ERROR")
        End Try
    End Sub

    Sub editdata(ByVal sqlisi As String)
        Try
            Call KonekDB()
            Dim sqlquery As New Odbc.OdbcCommand
            sqlquery.Connection = conn
            sqlquery.CommandType = CommandType.Text
            sqlquery.CommandText = sqlisi
            sqlquery.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString, 16, "ERROR")
        End Try
    End Sub

    Sub hapusdata(ByVal sqlisi As String)
        Try
            Call KonekDB()
            Dim sqlquery As New Odbc.OdbcCommand
            sqlquery.Connection = conn
            sqlquery.CommandType = CommandType.Text
            sqlquery.CommandText = sqlisi
            sqlquery.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString, 16, "ERROR")
        End Try
    End Sub
End Module
