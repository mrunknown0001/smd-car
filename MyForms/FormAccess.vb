Public Class FormAccess
    Private Sub ButtonAccessClose_Click(sender As Object, e As EventArgs) Handles ButtonAccessClose.Click
        Me.Close()
        FormMain.Show()
    End Sub

    Private Sub FormAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load all data regarding access
    End Sub

    Private Sub IconButtonAdUserSearch_Click(sender As Object, e As EventArgs) Handles IconButtonAdUserSearch.Click
        If CheckUserAd(TextBoxAdUserSearch.Text) Then
            MessageBox.Show(MsgAdUserSearchSuccess, TitleAdUserSearch, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            LabelAdUserSearched.Text = TextBoxAdUserSearch.Text
            TextBoxAdUser.Text = TextBoxAdUserSearch.Text
        Else
            MessageBox.Show(MsgAdUserSearchFail, TitleAdUserSearch, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            LabelAdUserSearched.Text = "User not found!"
        End If
    End Sub
End Class