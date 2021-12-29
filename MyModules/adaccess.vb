Imports System.DirectoryServices.AccountManagement
Module adaccess
    Public Function CheckUserAd(username As String)
        ' Create a domain context
        Dim DC = New PrincipalContext(ContextType.Domain)

        Try
            ' Find a user in the domain
            Dim user = UserPrincipal.FindByIdentity(DC, username)
            Dim userad As String = Nothing
            Try
                If user IsNot Nothing Then
                    userad = user.ToString
                End If
            Catch ex As Exception

            End Try

            If userad Is Nothing Or String.IsNullOrEmpty(userad) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


    Public Function CheckUserAccess()

        Return False
    End Function
End Module
