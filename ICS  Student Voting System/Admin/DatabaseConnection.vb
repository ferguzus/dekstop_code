Imports MySql.Data.MySqlClient
Imports System.IO

Module DatabaseConnection
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable

    Public Sub dbconn()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;user=root;password=2474;database=cdm-internship-database"
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Server is not connected !", vbExclamation)
        End Try
    End Sub
End Module
