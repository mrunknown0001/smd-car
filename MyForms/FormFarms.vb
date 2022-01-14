Imports MySql.Data.MySqlClient
Public Class FormFarms
    Private Sub ButtonUsersClose_Click(sender As Object, e As EventArgs) Handles ButtonFarmsClose.Click
        Me.Close()
        FormMain.Show()
    End Sub

    Private Sub IconButtonUsersFormSave_Click(sender As Object, e As EventArgs) Handles IconButtonUsersFormSave.Click

    End Sub

    Private Function LoadUsersDataGridView()
        Try
            OpenCon()

            'For Users DataGridView
            Dim myAdapter As New MySqlDataAdapter
            Dim dtfarms As New DataTable
            Dim sql As String = "SELECT id, name, code, description, active FROM farms WHERE is_deleted=0"

            Dim myCommand As New MySqlCommand

            myCommand.CommandText = sql
            myCommand.Connection = con
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(dtfarms)
            'ID_
            If dtfarms.Columns.Contains("ID_") Then
                dtfarms.Columns.Remove("ID_")
            End If
            dtfarms.Columns.Add("ID_", Type.GetType("System.String"))
            For Each dr As DataRow In dtfarms.Rows
                dr.Item("ID_") = dr.Item("id")
            Next
            'Farm Name
            If dtfarms.Columns.Contains("Farm Name") Then
                dtfarms.Columns.Remove("Farm Name")
            End If
            dtfarms.Columns.Add("Farm Name", Type.GetType("System.String"))
            For Each dr As DataRow In dtfarms.Rows
                dr.Item("Farm Name") = dr.Item("name")
            Next
            'Farm Code
            If dtfarms.Columns.Contains("Farm Code") Then
                dtfarms.Columns.Remove("Farm Code")
            End If
            dtfarms.Columns.Add("Farm Code", Type.GetType("System.String"))
            For Each dr As DataRow In dtfarms.Rows
                dr.Item("Farm Code") = dr.Item("code")
            Next
            'Active
            If dtfarms.Columns.Contains("Active User") Then
                dtfarms.Columns.Remove("Active User")
            End If
            dtfarms.Columns.Add("Active User", Type.GetType("System.String"))
            For Each dr As DataRow In dtfarms.Rows
                Select Case dr.Item("active")
                    Case True
                        dr.Item("Active User") = "Yes"
                    Case False
                        dr.Item("Active User") = "No"
                End Select
            Next

            dtfarms.Columns.Remove("id")
            dtfarms.Columns.Remove("name")
            dtfarms.Columns.Remove("code")
            dtfarms.Columns.Remove("description")
            dtfarms.Columns.Remove("active")

            DataGridViewFarms.DataSource = dtfarms

            con.Close()
        Catch ex As Exception
            MessageBox.Show(MsgDatabaceConnectionError & ex.Message, TitleDatabaseConnectionError, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

        Return String.Empty
    End Function

    Private Sub FormFarms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersDataGridView()
    End Sub
End Class