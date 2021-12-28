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

        If ValidateActiveDirectoryLogin() = False Then
            MessageBox.Show("Error on User. User is not under " & domainName & " domain. Program will close now.", "AD User Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End
        Else
            loggedUser = GetADUser()
            timelogged = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            'Show Splash Window
            WelcomeSplash.Show()
            Me.Visible = False
            Me.ShowInTaskbar = False
        End If

    End Sub


    Private Sub IconButtonLogin_Click(sender As Object, e As EventArgs) Handles IconButtonLogin.Click
        Dim email As String = TextBoxEmail.Text
        Dim password As String = TextBoxPassword.Text

        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        ValidateRequiredTextBox(Me.TextBoxEmail, "Email field is Required!")
        ValidateRequiredTextBox(Me.TextBoxPassword, "Password field is Required!")
        'Call Login Method Here

        While counter <= 2
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM users WHERE email='" & email & "' AND password='" & password & "';" 'SQL Query

                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)

                If myData IsNot Nothing AndAlso myData.Rows.Count > 0 Then
                    'User Found
                    loggedUser = email
                    timelogged = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    Me.Hide()
                    MessageBox.Show("Welcome Back to the System!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    FormMain.Show()
                    Return
                Else
                    MessageBox.Show("Login Error. Please Check your credentials", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    'Increase Counter for Every Failed Login Attempt
                    counter += 1
                    If counter > 2 Then
                        MessageBox.Show("Too Many Attemps. Program is closing now!", "Too Many Attemps", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        'Connect to Database and Lock for 15 minutes
                        End
                    End If
                    Return
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
