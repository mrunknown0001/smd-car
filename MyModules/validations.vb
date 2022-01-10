Imports System.Security.Principal
Module validations

    Sub ValidateRequiredTextBox(field As TextBox, errMgs As String)
        If (field.Text = "") Then
            MessageBox.Show(errMgs, TitleTextFieldValidation, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            field.Focus()
            Return
        End If
    End Sub

    Sub ValidateRequiredComboBox(field As ComboBox, errMgs As String)
        If (field.Text = "") Then
            MessageBox.Show(errMgs, TitleComboBoxValidation, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            field.Focus()
            Return
        End If
    End Sub

    Sub ValidateNumber(field As TextBox, errMgs As String)

        Return
    End Sub


    Public Function isAdmin()
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        'Administrator User Only
        If isElevated Then
            Return True
        Else
            'Original Return Value False
            'Bypass Process on Domain Administrator Access
            Return True 'False
        End If
    End Function
End Module
