Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FormUsers
    Dim dtRole As New DataTable()
    Dim dtusers As New DataTable()
    Private Sub ButtonUsersClose_Click(sender As Object, e As EventArgs) Handles ButtonUsersClose.Click
        Me.Close()
        FormMain.Show()
    End Sub

    Private Function LoadUsersDataGridView()
        Try
            OpenCon()

            'For Users DataGridView
            Dim myAdapter As New MySqlDataAdapter
            Dim sql As String = "SELECT id, first_name, last_name, middle_name, suffix_name, email,
                        role_id, active, is_deleted FROM users WHERE is_deleted=0"

            Dim myCommand As New MySqlCommand

            myCommand.CommandText = sql
            myCommand.Connection = con
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(dtusers)
            'ID_
            If dtusers.Columns.Contains("ID_") Then
                dtusers.Columns.Remove("ID_")
            End If
            dtusers.Columns.Add("ID_", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                dr.Item("ID_") = dr.Item("id")
            Next
            'First Name
            If dtusers.Columns.Contains("First Name") Then
                dtusers.Columns.Remove("First Name")
            End If
            dtusers.Columns.Add("First Name", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                dr.Item("First Name") = dr.Item("first_name")
            Next
            'Last Name
            If dtusers.Columns.Contains("Last Name") Then
                dtusers.Columns.Remove("Last Name")
            End If
            dtusers.Columns.Add("Last Name", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                dr.Item("Last Name") = dr.Item("last_name")
            Next
            'Middle Name
            If dtusers.Columns.Contains("Middle Name") Then
                dtusers.Columns.Remove("Middle Name")
            End If
            dtusers.Columns.Add("Middle Name", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                dr.Item("Middle Name") = dr.Item("middle_name")
            Next
            'Suffix Name
            If dtusers.Columns.Contains("Suffix Name") Then
                dtusers.Columns.Remove("Suffix Name")
            End If
            dtusers.Columns.Add("Suffix Name", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                dr.Item("Suffix Name") = dr.Item("suffix_name")
            Next
            'Email
            If dtusers.Columns.Contains("Email Add.") Then
                dtusers.Columns.Remove("Email Add.")
            End If
            dtusers.Columns.Add("Email Add.", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                dr.Item("Email Add.") = dr.Item("email")
            Next
            'Active
            If dtusers.Columns.Contains("Active User") Then
                dtusers.Columns.Remove("Active User")
            End If
            dtusers.Columns.Add("Active User", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                Select Case dr.Item("active")
                    Case True
                        dr.Item("Active User") = "Yes"
                    Case False
                        dr.Item("Active User") = "No"
                End Select
            Next
            'Roles
            If dtusers.Columns.Contains("Roles") Then
                dtusers.Columns.Remove("Roles")
            End If
            dtusers.Columns.Add("Roles", Type.GetType("System.String"))
            For Each dr As DataRow In dtusers.Rows
                Select Case dr.Item("role_id")
                    Case 1
                        dr.Item("Roles") = "Super"
                    Case 2
                        dr.Item("Roles") = "Admin"
                    Case Else
                        dr.Item("Roles") = "User"
                End Select
            Next

            dtusers.Columns.Remove("id")
            dtusers.Columns.Remove("first_name")
            dtusers.Columns.Remove("last_name")
            dtusers.Columns.Remove("middle_name")
            dtusers.Columns.Remove("suffix_name")
            dtusers.Columns.Remove("email")
            dtusers.Columns.Remove("active")
            dtusers.Columns.Remove("role_id")
            dtusers.Columns.Remove("is_deleted")

            DataGridViewUsers.DataSource = dtusers

            con.Close()
        Catch ex As Exception
            MessageBox.Show(MsgDatabaceConnectionError & ex.Message, TitleDatabaseConnectionError, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

        Return String.Empty
    End Function

    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenCon()
        cmd.Connection = con
        'For Role Pull
        cmd.CommandText = "SELECT id, name FROM roles"

        dtRole.Columns.Add("Id")
        dtRole.Columns.Add("Name")

        'Add Blank Selection in ComboBox as a default Selected
        Dim R As DataRow = dtRole.NewRow
        R("Id") = ""
        R("Name") = ""
        dtRole.Rows.Add(R)

        dtRole.Load(cmd.ExecuteReader())

        'Convert Small Letter in First Letter Capital
        For Each drr As DataRow In dtRole.Rows
            Select Case drr.Item("name")
                Case "super"
                    drr.Item("Name") = "Super"
                Case "admin"
                    drr.Item("Name") = "Admin"
                Case "user"
                    drr.Item("Name") = "User"
                Case Else
                    drr.Item("Name") = ""
            End Select
        Next

        ComboBoxRole.DataSource = dtRole
        ComboBoxRole.DisplayMember = "Name"
        ComboBoxRole.ValueMember = "Id"
        LoadUsersDataGridView()
    End Sub

    Private Sub DataGridViewUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUsers.CellContentClick, DataGridViewUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridViewUsers.Rows(e.RowIndex)
            'Loads Information to Designated Input Fields
            'ID must load on hidden TextBox
            TextBoxUserID.Text = row.Cells(0).Value.ToString
            TextBoxFirstName.Text = row.Cells(1).Value.ToString
            TextBoxLastName.Text = row.Cells(2).Value.ToString
            TextBoxMiddleName.Text = row.Cells(3).Value.ToString
            TextBoxSuffixName.Text = row.Cells(4).Value.ToString
            TextBoxEmail.Text = row.Cells(5).Value.ToString
            ComboBoxRole.Text = row.Cells(7).Value.ToString
            Dim active As String = "Inactive"
            If row.Cells(6).Value = "Yes" Then
                active = "Active"
            End If
            ComboBoxActive.Text = active

        End If
    End Sub

    Private Sub IconButtonUsersFormSave_Click(sender As Object, e As EventArgs) Handles IconButtonUsersFormSave.Click

        Dim result As DialogResult = MessageBox.Show("Continue User Creation/Update?", "Confirm User Creation/Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If (result = DialogResult.Yes) Then
            'Call Validation Function
            ValidateRequiredTextBox(TextBoxFirstName, "First Name is Required!")
            ValidateRequiredTextBox(TextBoxLastName, "Last Name is Required!")
            ValidateRequiredTextBox(TextBoxEmail, "Email is Required!")
            ValidateRequiredComboBox(ComboBoxRole, "Role is Required")
            ValidateRequiredComboBox(ComboBoxActive, "Active Status is Required")

            OpenCon()
            cmd.Connection = con
            Dim role As Integer = 3
            Dim active As Integer = 0
            'Select Case for Active
            Select Case ComboBoxActive.Text
                Case "Active"
                    active = 1 'Boolean
                Case "Inactive"
                    active = 0 'Boolean
            End Select

            Select Case ComboBoxRole.Text
                Case "Admin"
                    role = 2
                Case "Super"
                    role = 1
                Case "User"
                    role = 3
            End Select

            If String.IsNullOrEmpty(TextBoxUserID.Text) Then
                'New User
                ValidateRequiredTextBox(TextBoxPassword, "Passowrd is Required!")

                Try

                    'Start Validation
                    If (TextBoxFirstName.Text Is "" Or TextBoxLastName.Text Is "" Or TextBoxEmail.Text Is "" Or ComboBoxRole.SelectedValue Is "" Or ComboBoxActive.SelectedValue Is "") Then
                        Return
                    Else
                        cmd.CommandText = "INSERT INTO users (`first_name`, `last_name`, `middle_name`, `suffix_name`, `email`, `password`, `role_id`, `active`) 
                VALUES ('" & TextBoxFirstName.Text & "', '" & TextBoxLastName.Text & "', '" & TextBoxMiddleName.Text & "', '" & TextBoxSuffixName.Text & "', '" & TextBoxEmail.Text & "', '" & TextBoxPassword.Text & "', '" & role & "', '" & active & "')"
                        cmd.ExecuteNonQuery()
                        MessageBox.Show(MsgUserAdded, TitleUserAdded, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        con.Close()
                        ClearFields()

                        'Reload Data Grid View
                        dtusers.Clear()
                        DataGridViewUsers.DataSource = dtusers
                        DataGridViewUsers.DataSource = Nothing
                        LoadUsersDataGridView()
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                'Update User
                Try
                    'Start Validation
                    If (TextBoxFirstName.Text Is "" Or TextBoxLastName.Text Is "" Or TextBoxEmail.Text Is "" Or ComboBoxRole.SelectedValue Is "" Or ComboBoxActive.SelectedValue Is "") Then
                        Return
                    Else
                        Dim pass As String = TextBoxPassword.Text
                        'Update without updating password
                        If String.IsNullOrEmpty(pass) Then
                            cmd.CommandText = "UPDATE users SET first_name='" & TextBoxFirstName.Text & "', 
                                            last_name='" & TextBoxLastName.Text & "',
                                            middle_name='" & TextBoxMiddleName.Text & "',
                                            suffix_name='" & TextBoxSuffixName.Text & "',
                                            email='" & TextBoxEmail.Text & "',
                                            active='" & active & "',
                                            role_id='" & role & "'
                                            WHERE id='" & TextBoxUserID.Text & "'
                                        "
                        Else
                            'Update with updating password
                            cmd.CommandText = "UPDATE users SET first_name='" & TextBoxFirstName.Text & "', 
                                            last_name='" & TextBoxLastName.Text & "',
                                            middle_name='" & TextBoxMiddleName.Text & "',
                                            suffix_name='" & TextBoxSuffixName.Text & "',
                                            email='" & TextBoxEmail.Text & "',
                                            active='" & active & "',
                                            role_id='" & role & "',
                                            password='" & pass & "'
                                            WHERE id='" & TextBoxUserID.Text & "'
                                        "
                        End If

                        cmd.ExecuteNonQuery()
                            MessageBox.Show(MsgUserUpdated, TitleUserUpdated, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            con.Close()
                            ClearFields()

                            'Reload Data Grid View
                            dtusers.Clear()
                            DataGridViewUsers.DataSource = dtusers
                            DataGridViewUsers.DataSource = Nothing
                            LoadUsersDataGridView()
                        End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If


    End Sub

    Private Sub IconButtonUsersFormClear_Click(sender As Object, e As EventArgs) Handles IconButtonUsersFormClear.Click
        Dim result As DialogResult = MessageBox.Show(MsgClearContent, TitleClearContent, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If (result = DialogResult.Yes) Then
            ClearFields()
        End If
    End Sub

    Private Sub ClearFields()
        'Clears all text and selected items on the form
        TextBoxUserID.Clear()
        TextBoxFirstName.Clear()
        TextBoxLastName.Clear()
        TextBoxMiddleName.Clear()
        TextBoxSuffixName.Clear()
        TextBoxEmail.Clear()
        TextBoxPassword.Clear()
        ComboBoxRole.SelectedValue = ""
        ComboBoxActive.SelectedItem = ""
    End Sub

    Private Sub TextBoxSearchUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchUser.TextChanged
        Dim cleanString As String = Regex.Replace(TextBoxSearchUser.Text, "[^A-Za-z0-9\-/]", "") 'Removes Special Characters
        'Search Query for DatagridView for Users
        Dim strquery As String = "`First Name` LIKE '%" & cleanString &
            "%' OR `Last Name` LIKE '%" & cleanString &
            "%' OR `Middle Name` LIKE '%" & cleanString &
            "%' OR `Suffix Name` LIKE '%" & cleanString &
            "%' OR `Email Add.` LIKE '%" & cleanString & "%'"

        TryCast(DataGridViewUsers.DataSource, DataTable).DefaultView.RowFilter =
            String.Format(strquery)

    End Sub

    Private Sub IconButtonUsersFormDelete_Click(sender As Object, e As EventArgs) Handles IconButtonUsersFormDelete.Click
        Dim result As DialogResult = MessageBox.Show(MsgUserDelete, TitleUserDelete, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If (result = DialogResult.Yes) Then
            If String.IsNullOrEmpty(TextBoxUserID.Text) Then
                MessageBox.Show(MsgNoUserToDelete, TitleDeleteError, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Return
            End If
            Try
                OpenCon()
                cmd.Connection = con
                cmd.CommandText = "UPDATE users SET is_deleted=1 WHERE id='" & TextBoxUserID.Text & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show(MsgUserDeleted, TitleUserDeleted, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                con.Close()
                ClearFields()

                'Reload Data Grid View
                dtusers.Clear()
                DataGridViewUsers.DataSource = dtusers
                DataGridViewUsers.DataSource = Nothing
                LoadUsersDataGridView()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class