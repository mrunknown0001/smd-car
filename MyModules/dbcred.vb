Imports System.IO

Module dbcred
    'Declration of Public Variable on Database Cred
    Public dbServer As String = ""
    Public dbUser As String = ""
    Public dbPassword As String = ""
    Public dbName As String = ""
    Public dbPort As String = ""
    Public loggedUser As String = ""
    Public domainName As String = ""
    Sub CheckEnvExist()
        Dim SourcePath As String = "C:\env\.env"
        If System.IO.File.Exists(SourcePath) Then
            'The .env file exists
            'Get all the Credentials Available
            Dim objReader As New System.IO.StreamReader(SourcePath)
            Dim tmpStr As String = ""
            Dim tmpStrArr As Array

            Do While objReader.Peek() <> -1
                tmpStr = objReader.ReadLine()
                tmpStrArr = tmpStr.Split("=")

                If (tmpStrArr.GetValue(0) = "DB_SERVER") Then
                    dbServer = tmpStrArr(1)
                ElseIf (tmpStrArr.GetValue(0) = "DB_USER") Then
                    dbUser = tmpStrArr(1)
                ElseIf (tmpStrArr.GetValue(0) = "DB_PASS") Then
                    dbPassword = tmpStrArr(1)
                ElseIf (tmpStrArr.GetValue(0) = "DB_NAME") Then
                    dbName = tmpStrArr(1)
                ElseIf (tmpStrArr.GetValue(0) = "DB_PORT") Then
                    dbPort = tmpStrArr(1)
                ElseIf (tmpstrarr.GetValue(0) = "DOMAIN") Then
                    domainName = tmpStrArr(1)
                End If
            Loop

        Else
            'The .env file doesn't exist
            MessageBox.Show("Critical Error. Environment file NOT found! Please Check your Credentials. Program is closing now.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'Database Connection Error End Program
            End
        End If
    End Sub
End Module
