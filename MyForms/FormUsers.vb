Imports MySql.Data.MySqlClient

Public Class FormUsers
    Dim dtRole As New DataTable()
    Dim dtusers As New DataTable()
    Private Sub ButtonUsersClose_Click(sender As Object, e As EventArgs) Handles ButtonUsersClose.Click
        Me.Close()
        FormMain.Show()
    End Sub

    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenCon()
        cmd.Connection = con

        Try
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


            'For Users DataGridView
            Dim myAdapter As New MySqlDataAdapter
            Dim sql As String = "SELECT id, first_name, last_name, middle_name, suffix_name, 
                        email, role_id, active FROM users"
            Dim myCommand As New MySqlCommand

            myCommand.CommandText = sql
            myCommand.Connection = con
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(dtusers)

            'Convert Role ID to String Equivalent
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
            dtusers.Columns.Remove("role_id")

            DataGridViewUsers.DataSource = dtusers

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Database Connection Error", "MySQL Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

        con.Close()
    End Sub


    Private Sub DataGridViewUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUsers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridViewUsers.Rows(e.RowIndex)

            TextBoxFirstName.Text = row.Cells("first_name").Value.ToString

        End If
    End Sub

    Private Sub DataGridViewUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUsers.CellContentClick, DataGridViewUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridViewUsers.Rows(e.RowIndex)
            'Loads Information to Designated Input Fields
            'ID must load on hidden TextBox
            TextBoxUserID.Text = row.Cells(0).Value.ToString
            TextBoxFirstName.Text = row.Cells("first_name").Value.ToString
            TextBoxLastName.Text = row.Cells("last_name").Value.ToString
            TextBoxMiddleName.Text = row.Cells("middle_name").Value.ToString
            TextBoxSuffixName.Text = row.Cells("suffix_name").Value.ToString
            TextBoxEmail.Text = row.Cells("email").Value.ToString
            ComboBoxRole.Text = row.Cells(7).Value.ToString
            Dim active As String = "Inactive"
            If row.Cells(6).Value Then
                active = "Active"
            End If
            ComboBoxActive.Text = active

        End If
    End Sub

    Private Sub IconButtonUsersFormSave_Click(sender As Object, e As EventArgs) Handles IconButtonUsersFormSave.Click
        'Call Validation Function
        ValidateRequiredTextBox(TextBoxFirstName, "First Name is Required!")
        ValidateRequiredTextBox(TextBoxLastName, "Last Name is Required!")
        ValidateRequiredTextBox(TextBoxEmail, "Email is Required!")
        ValidateRequiredTextBox(TextBoxPassword, "Passowrd is Required!")
    End Sub

    Private Sub IconButtonUsersFormClear_Click(sender As Object, e As EventArgs) Handles IconButtonUsersFormClear.Click
        'Clears all text and selected items on the form
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
        'Search Query for DatagridView for Users
        Dim strquery As String = "first_name LIKE '%" & TextBoxSearchUser.Text &
            "%' OR last_name LIKE '%" & TextBoxSearchUser.Text &
            "%' OR middle_name LIKE '%" & TextBoxSearchUser.Text &
            "%' OR suffix_name LIKE '%" & TextBoxSearchUser.Text &
            "%' OR email LIKE '%" & TextBoxSearchUser.Text & "%'"

        TryCast(DataGridViewUsers.DataSource, DataTable).DefaultView.RowFilter =
            String.Format(strquery)

    End Sub
End Class