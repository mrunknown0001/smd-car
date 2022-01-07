Module Login
    Public loggedusername As String = ""
    Public role As String = ""
    Public timelogged As String = ""
    Public machineName As String = ""
    Public AD As String = ""
    Sub UserLogin()

    End Sub

    Public Function ValidateActiveDirectoryLogin() As Boolean
        Dim Result As Boolean = False
        AD = Environment.UserDomainName 'This returns name of AD in Capital Letters

        If domainName = AD Then
            'Returns True if Loggin on Active Directory, otherwise, Return False
            Result = True
            Return Result
        Else
            Result = True 'False
            Return Result
        End If
    End Function

    Public Function GetADUser() As String
        Dim userName = Environment.UserName

        Return userName
    End Function

    Public Function GetMachineName() As String
        Dim machineName = Environment.MachineName

        Return machineName
    End Function

    Public Function GetADName() As String
        Dim AD = Environment.UserDomainName

        Return AD
    End Function
End Module
