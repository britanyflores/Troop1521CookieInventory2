Imports MySql.Data.MySqlClient
Public Class addCookie
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim cookieName As String = cookieNameTB.Text
        Dim conn As New myConnection()
        Dim command As New MySqlCommand("INSERT INTO `cookie`(`name`) VALUES (@cookieName)", conn.getConnection())
        command.Parameters.Add("@cookieName", MySqlDbType.VarChar).Value = cookieName
        conn.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("COOKIE INSERTED")
            conn.closeConnection()
        Else
            MsgBox("COOKIE NOT INSERTED")
            conn.closeConnection()
        End If
    End Sub
End Class