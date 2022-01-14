Imports System.Data
Imports MySql.Data.MySqlClient

Public Class FormLogin

    Dim counter As Integer = 0 'Login Throttling Control Counter

    Private Sub FormLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            End

        ElseIf e.KeyCode = Keys.Enter Then
            IconButtonLogin.PerformClick()
        End If
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        Dim PasswordCharacter As String = "*"
        If TextBoxPassword.PasswordChar = PasswordCharacter Then
            TextBoxPassword.PasswordChar = ""
        Else
            TextBoxPassword.PasswordChar = "*"
        End If
    End Sub


    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check Application Lock (by default 15 minutes) after Login Throttle Lock
        'If CheckEnvExist function has Error the program will close
        CheckEnvExist()
        'Tries to Open the Connection to the Database
        OpenCon()

        'If ValidateActiveDirectoryLogin() = False Then
        '    MessageBox.Show("Error on User. User is not under " & domainName & " domain. Program will close now.", "AD User Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    End
        'Else
        '    loggedUser = GetADUser()
        '    timelogged = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        '    'Show Splash Window
        '    WelcomeSplash.Show()
        '    Me.Visible = False
        '    Me.ShowInTaskbar = False
        'End If

    End Sub


    Private Sub IconButtonLogin_Click(sender As Object, e As EventArgs) Handles IconButtonLogin.Click
        Dim email As String = TextBoxEmail.Text
        Dim password As String = Encrypt(TextBoxPassword.Text)
        Dim is_deleted As String = "0"

        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        ValidateRequiredTextBox(Me.TextBoxEmail, MsgEmailRequired)
        ValidateRequiredTextBox(Me.TextBoxPassword, MsgPasswordRequired)
        'Call Login Method Here

        While counter <= 2
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM users WHERE email='" & email & "' AND password='" & password & "' AND is_deleted='" & is_deleted & "'" 'SQL Query

                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)

                If myData IsNot Nothing AndAlso myData.Rows.Count > 0 Then
                    'User Found
                    loggedUser = email
                    timelogged = timenow

                    'if user is_locked is 1
                    'check unlock_time, if curent time, user continue to login else, wait for 15 mins and tell the user that account is locked
                    Dim myAd2 As New MySqlDataAdapter
                    Dim sql As String = "SELECT * FROM users WHERE email='" & email & "'"
                    Dim user As New DataTable
                    Dim reader As MySqlDataReader
                    Try
                        OpenCon()
                        cmd.CommandText = sql
                        reader = cmd.ExecuteReader
                        If reader.Read() Then
                            If reader.GetValue("is_locked").ToString = "1" Then

                                'If reader.GetValue("unlock_time") >= timenow Then
                                If DateTime.Compare(reader.GetValue("unlock_time"), timenow) < 0 Then
                                    con.Close()


                                    MessageBox.Show(MsgWelcomeMessage, TitleLoginSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    FormMain.Show()
                                    Me.Hide()
                                    'Add Log for User Login
                                    AddLog(GetUserID(email), ActionLogin, 0, "Login", "", "", "")
                                    Return
                                Else
                                    MessageBox.Show(MsgAccountLocked, TitleAccountLocked, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                    Me.Close()
                                    End
                                End If

                            End If
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                Else
                    MessageBox.Show(MsgCredentialError, TitleLoginError, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    'Increase Counter for Every Failed Login Attempt
                    counter += 1
                    If counter > 2 Then
                        MessageBox.Show(MsgTooMayAttempt, TitleTooManyAttempt, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        'Connect to Database and Lock for 15 minutes
                        'Search for user if available, if not just ignore
                        'if available, update is_locked to 1 and unlock_time to current time plush 15 minutes
                        'Add to user log, login attempt made, important to note on computer, mac address and ip address
                        Dim cmd2 As New MySqlCommand
                        Dim myad As New MySqlDataAdapter
                        Dim mydat As New DataTable

                        cmd2.Connection = con
                        cmd2.CommandText = "SELECT * FROM users WHERE email='" & email & "'"

                        myad.SelectCommand = cmd2
                        myad.Fill(mydat)

                        If mydat IsNot Nothing AndAlso mydat.Rows.Count > 0 Then
                            Dim unlocked As String = DateTime.Now.AddMinutes(15).ToString("yyyy/MM/dd HH:mm:ss")
                            OpenCon()
                            cmd.Connection = con
                            cmd.CommandText = "UPDATE users SET is_locked=1, unlock_time='" & unlocked & "' WHERE email='" & email & "'"
                            cmd.ExecuteNonQuery()
                            'Add Log
                            AddLog(GetUserID(email), "Login Attempt", 0, "Login Attempt", "", "", "")
                        End If

                        Me.Close()
                        End

                    End If 'End f If Statement with Counter 2
                    Return 'Need Return to stop iteration
                End If

                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End While
    End Sub

    Private Sub IconButtonCancel_Click(sender As Object, e As EventArgs) Handles IconButtonCancel.Click
        Me.Close()
        End
    End Sub

End Class
