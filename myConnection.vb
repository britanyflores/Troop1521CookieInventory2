Imports MySql.Data.MySqlClient
Public Class myConnection
    Dim connection As New MySqlConnection("datasource=sql3.freesqldatabase.com;port=3306;username=sql3479308;password=UgXzweU896;database=sql3479308")
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property
    Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub
    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class