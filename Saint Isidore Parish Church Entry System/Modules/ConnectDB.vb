Imports MySql.Data.MySqlClient

Module ConnectDB
    '//Establish Mysql Connection
    Public con As New MySqlConnection("Server=localhost;user=root;password=;database=church_db;")

    '//basic query
    Public Sub bQuery(ByVal query As String)
        Try
            With con
                If .State = ConnectionState.Open Then .Close()
            End With

            Dim cmd As New MySqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Module
