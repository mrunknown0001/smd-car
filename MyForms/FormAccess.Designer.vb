<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonAccessClose = New System.Windows.Forms.Button()
        Me.PanelAccessHeader = New System.Windows.Forms.Panel()
        Me.LabelAccess = New System.Windows.Forms.Label()
        Me.GroupBoxAccess = New System.Windows.Forms.GroupBox()
        Me.TextBoxAdUser = New System.Windows.Forms.TextBox()
        Me.LabelAdUserSearched = New System.Windows.Forms.Label()
        Me.IconButtonAdUserSearch = New FontAwesome.Sharp.IconButton()
        Me.TextBoxAdUserSearch = New System.Windows.Forms.TextBox()
        Me.DataGridViewAccess = New System.Windows.Forms.DataGridView()
        Me.TextBoxSearchUserAccess = New System.Windows.Forms.TextBox()
        Me.PanelAccessHeader.SuspendLayout()
        Me.GroupBoxAccess.SuspendLayout()
        CType(Me.DataGridViewAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAccessClose
        '
        Me.ButtonAccessClose.BackColor = System.Drawing.Color.Red
        Me.ButtonAccessClose.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonAccessClose.ForeColor = System.Drawing.Color.White
        Me.ButtonAccessClose.Location = New System.Drawing.Point(1449, 3)
        Me.ButtonAccessClose.Name = "ButtonAccessClose"
        Me.ButtonAccessClose.Size = New System.Drawing.Size(46, 40)
        Me.ButtonAccessClose.TabIndex = 0
        Me.ButtonAccessClose.TabStop = False
        Me.ButtonAccessClose.Text = "X"
        Me.ButtonAccessClose.UseVisualStyleBackColor = False
        '
        'PanelAccessHeader
        '
        Me.PanelAccessHeader.Controls.Add(Me.LabelAccess)
        Me.PanelAccessHeader.Controls.Add(Me.ButtonAccessClose)
        Me.PanelAccessHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAccessHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelAccessHeader.Name = "PanelAccessHeader"
        Me.PanelAccessHeader.Size = New System.Drawing.Size(1498, 74)
        Me.PanelAccessHeader.TabIndex = 1
        '
        'LabelAccess
        '
        Me.LabelAccess.AutoSize = True
        Me.LabelAccess.BackColor = System.Drawing.Color.Transparent
        Me.LabelAccess.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelAccess.Location = New System.Drawing.Point(12, 9)
        Me.LabelAccess.Name = "LabelAccess"
        Me.LabelAccess.Size = New System.Drawing.Size(118, 45)
        Me.LabelAccess.TabIndex = 1
        Me.LabelAccess.Text = "Access"
        '
        'GroupBoxAccess
        '
        Me.GroupBoxAccess.Controls.Add(Me.TextBoxAdUser)
        Me.GroupBoxAccess.Controls.Add(Me.LabelAdUserSearched)
        Me.GroupBoxAccess.Controls.Add(Me.IconButtonAdUserSearch)
        Me.GroupBoxAccess.Controls.Add(Me.TextBoxAdUserSearch)
        Me.GroupBoxAccess.Location = New System.Drawing.Point(67, 103)
        Me.GroupBoxAccess.Name = "GroupBoxAccess"
        Me.GroupBoxAccess.Size = New System.Drawing.Size(1351, 369)
        Me.GroupBoxAccess.TabIndex = 2
        Me.GroupBoxAccess.TabStop = False
        '
        'TextBoxAdUser
        '
        Me.TextBoxAdUser.Location = New System.Drawing.Point(30, 178)
        Me.TextBoxAdUser.Name = "TextBoxAdUser"
        Me.TextBoxAdUser.PlaceholderText = "AD User - Hidden"
        Me.TextBoxAdUser.Size = New System.Drawing.Size(262, 31)
        Me.TextBoxAdUser.TabIndex = 3
        Me.TextBoxAdUser.Visible = False
        '
        'LabelAdUserSearched
        '
        Me.LabelAdUserSearched.AutoSize = True
        Me.LabelAdUserSearched.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LabelAdUserSearched.Location = New System.Drawing.Point(30, 114)
        Me.LabelAdUserSearched.Name = "LabelAdUserSearched"
        Me.LabelAdUserSearched.Size = New System.Drawing.Size(35, 32)
        Me.LabelAdUserSearched.TabIndex = 2
        Me.LabelAdUserSearched.Text = "..."
        '
        'IconButtonAdUserSearch
        '
        Me.IconButtonAdUserSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonAdUserSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonAdUserSearch.ForeColor = System.Drawing.Color.White
        Me.IconButtonAdUserSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButtonAdUserSearch.IconColor = System.Drawing.Color.White
        Me.IconButtonAdUserSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonAdUserSearch.IconSize = 30
        Me.IconButtonAdUserSearch.Location = New System.Drawing.Point(338, 41)
        Me.IconButtonAdUserSearch.Name = "IconButtonAdUserSearch"
        Me.IconButtonAdUserSearch.Size = New System.Drawing.Size(146, 40)
        Me.IconButtonAdUserSearch.TabIndex = 1
        Me.IconButtonAdUserSearch.Text = "Search"
        Me.IconButtonAdUserSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonAdUserSearch.UseVisualStyleBackColor = False
        '
        'TextBoxAdUserSearch
        '
        Me.TextBoxAdUserSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TextBoxAdUserSearch.Location = New System.Drawing.Point(30, 41)
        Me.TextBoxAdUserSearch.Name = "TextBoxAdUserSearch"
        Me.TextBoxAdUserSearch.PlaceholderText = "Search User in AD"
        Me.TextBoxAdUserSearch.Size = New System.Drawing.Size(262, 40)
        Me.TextBoxAdUserSearch.TabIndex = 0
        '
        'DataGridViewAccess
        '
        Me.DataGridViewAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccess.Location = New System.Drawing.Point(67, 570)
        Me.DataGridViewAccess.Name = "DataGridViewAccess"
        Me.DataGridViewAccess.RowHeadersWidth = 62
        Me.DataGridViewAccess.RowTemplate.Height = 33
        Me.DataGridViewAccess.Size = New System.Drawing.Size(1351, 207)
        Me.DataGridViewAccess.TabIndex = 3
        '
        'TextBoxSearchUserAccess
        '
        Me.TextBoxSearchUserAccess.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TextBoxSearchUserAccess.Location = New System.Drawing.Point(97, 498)
        Me.TextBoxSearchUserAccess.Name = "TextBoxSearchUserAccess"
        Me.TextBoxSearchUserAccess.PlaceholderText = "Search User Access.."
        Me.TextBoxSearchUserAccess.Size = New System.Drawing.Size(262, 39)
        Me.TextBoxSearchUserAccess.TabIndex = 4
        '
        'FormAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxSearchUserAccess)
        Me.Controls.Add(Me.DataGridViewAccess)
        Me.Controls.Add(Me.GroupBoxAccess)
        Me.Controls.Add(Me.PanelAccessHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelAccessHeader.ResumeLayout(False)
        Me.PanelAccessHeader.PerformLayout()
        Me.GroupBoxAccess.ResumeLayout(False)
        Me.GroupBoxAccess.PerformLayout()
        CType(Me.DataGridViewAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAccessClose As Button
    Friend WithEvents PanelAccessHeader As Panel
    Friend WithEvents LabelAccess As Label
    Friend WithEvents GroupBoxAccess As GroupBox
    Friend WithEvents DataGridViewAccess As DataGridView
    Friend WithEvents TextBoxSearchUserAccess As TextBox
    Friend WithEvents TextBoxAdUserSearch As TextBox
    Friend WithEvents IconButtonAdUserSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelAdUserSearched As Label
    Friend WithEvents TextBoxAdUser As TextBox
End Class
