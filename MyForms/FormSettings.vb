Public Class FormSettings
    Private Sub ButtonSettingsClose_Click(sender As Object, e As EventArgs) Handles ButtonSettingsClose.Click
        Me.Close()
        FormMain.Show()
    End Sub
End Class