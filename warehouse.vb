Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class warehouse
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim warehouseID As String = warehouseIDTB.Text
        Dim name As String = nameTB.Text
        Dim address As String = addressTB.Text
        Dim phone As String = phoneTB.Text
        Dim note As String = noteTB.Text
        Dim conn As New myConnection()
        Dim command As New MySqlCommand("INSERT INTO `user`(`warehouseID`, `name`, `address`, `phone`, `note`) VALUES (@warehouseID, @name, @address, @phone, @note)", conn.getConnection())

        command.Parameters.Add("@warehouseID", MySqlDbType.VarChar).Value = warehouseID
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

        conn.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("WAREHOUSE INSERTED")
            conn.closeConnection()
        Else
            MsgBox("WAREHOUSE INSERTED")
            conn.closeConnection()
        End If
    End Sub
End Class
