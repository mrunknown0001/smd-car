Imports System.Net.NetworkInformation
Imports MySql.Data.MySqlClient

Module Log
    Public Sub AddLog(userID As Integer, action As String, record_id As Integer, table As String, value1 As String, value2 As String, value3 As String)
        'userID = user_id (integer)
        'action = action (string)
        'record_id = record_id (integer)
        'table = table (string)
        'value1, value2, value3 (string)
        'device (string) computer name/device name
        'mac = mac_address (string) pc mac address
        'ip = ip_address_1 (string)
        Try
            Dim device As String = Environment.MachineName 'Get Machine Name
            Dim mac As String = GetMacAddress()
            Dim ip As String = GetIP()
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO logs (`user_id`, `action`, `table_name`, `value_1`, `value_2`, `value_3`, `record_id`, `device`, `mac_address`, `ip_address_1`) 
                VALUES ('" & userID & "', '" & action & "', '" & table & "', '" & value1 & "', '" & value2 & "', '" & value3 & "', '" & record_id & "', '" & device & "', '" & mac & "', '" & ip & "')"
            cmd.ExecuteNonQuery()
            'Message Box
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetUserID(email As String)
        Dim id As String = String.Empty

        Dim myAdapter As New MySqlDataAdapter
        Dim sql As String = "SELECT * FROM users WHERE email='" & email & "'"
        Dim user As New DataTable
        Dim reader As MySqlDataReader
        Try
            OpenCon()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader
            If reader.Read() Then
                id = reader.GetValue(0)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        con.Close()
        Return id
    End Function


    Private Function GetMacAddress()
        Dim mac As String = String.Empty
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        For a = 1 To NetworkInterface.GetAllNetworkInterfaces.Count - 1
            mac += nics(a).GetPhysicalAddress.ToString + ", "
        Next
        Return mac
    End Function

    Private Function GetIP()
        Dim ip As String = String.Empty
        Dim hostName = System.Net.Dns.GetHostName()
        For Each hostAdr In System.Net.Dns.GetHostEntry(hostName).AddressList()
            ip += hostAdr.ToString() + ", "
        Next
        Return ip
    End Function
End Module
