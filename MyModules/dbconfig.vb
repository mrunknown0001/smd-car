Imports MySql.Data.MySqlClient

Module dbconfig
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Sub OpenCon()
        'Connection String Based on .env File
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            Else
                con.ConnectionString = "server=" & dbServer & ";port=" & dbPort & ";username=" & dbUser & ";password=" & dbPassword & ";database=" & dbName
            End If
            con.Open()
            'MessageBox.Show("Connected!", "Database Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show("Database Connection Error. Program will close now.", "MySQL Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End
        End Try
    End Sub
End Module
