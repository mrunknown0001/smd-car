Public Class FormMain
    Private Sub FormMain_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabelUser.Text = "User: " & loggedUser
        ToolStripStatusLabelTimeLogged.Text = "Time Logged: " & timelogged
        'Check if Admin or User Access
        If isAdmin() Then
            'Enable Menu & Show all admin menu
            IconButtonMainFormUsers.Enabled = True
            IconButtonMainFormUsers.Visible = True
            IconButtonMainFormFarms.Enabled = True
            IconButtonMainFormFarms.Visible = True
            IconButtonMainFormSettings.Enabled = True
            IconButtonMainFormSettings.Visible = True
            IconButtonMainFormUserAccess.Enabled = True
            IconButtonMainFormUserAccess.Visible = True

        Else
            'Disable all admin menu and hide
            IconButtonMainFormUsers.Enabled = False
            IconButtonMainFormUsers.Visible = False
            IconButtonMainFormFarms.Enabled = False
            IconButtonMainFormFarms.Visible = False
            IconButtonMainFormSettings.Enabled = False
            IconButtonMainFormSettings.Visible = False
            IconButtonMainFormUserAccess.Enabled = False
            IconButtonMainFormUserAccess.Visible = False
        End If

    End Sub


    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ButtonMainFormClose_Click(sender As Object, e As EventArgs) Handles ButtonMainFormClose.Click
        Dim ForceCloseResponce As DialogResult = MessageBox.Show("Are you sure you want to Force Close All Window?", "Force Close App", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If (ForceCloseResponce = DialogResult.Yes) Then
            'Log codes place here
            con.Close()
            End
        End If
    End Sub

    Private Sub IconButtonMainFormUsers_Click(sender As Object, e As EventArgs) Handles IconButtonMainFormUsers.Click
        FormUsers.Show()
        Me.Hide()
    End Sub

    Private Sub IconButtonMainFormFarms_Click(sender As Object, e As EventArgs) Handles IconButtonMainFormFarms.Click
        Me.Hide()
        FormFarms.Show()
    End Sub

    Private Sub IconButtonMainFormLogout_Click(sender As Object, e As EventArgs) Handles IconButtonMainFormLogout.Click
        Dim LogoutResponce As DialogResult = MessageBox.Show("Are you sure you want to Logout?", "Confirm Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If (LogoutResponce = DialogResult.Yes) Then
            'Log codes place here
            End
        End If
    End Sub

End Class