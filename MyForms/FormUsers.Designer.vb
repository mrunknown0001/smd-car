<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelUsersHeader = New System.Windows.Forms.Panel()
        Me.LabelUsers = New System.Windows.Forms.Label()
        Me.ButtonUsersClose = New System.Windows.Forms.Button()
        Me.GroupBoxUsers = New System.Windows.Forms.GroupBox()
        Me.IconButtonUsersFormDelete = New FontAwesome.Sharp.IconButton()
        Me.IconButtonUsersFormEdit = New FontAwesome.Sharp.IconButton()
        Me.IconButtonUsersFormClear = New FontAwesome.Sharp.IconButton()
        Me.IconButtonUsersFormSave = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxActive = New System.Windows.Forms.ComboBox()
        Me.LabelActive = New System.Windows.Forms.Label()
        Me.ComboBoxRole = New System.Windows.Forms.ComboBox()
        Me.LabelRole = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxSuffixName = New System.Windows.Forms.TextBox()
        Me.LabelSuffixName = New System.Windows.Forms.Label()
        Me.TextBoxMiddleName = New System.Windows.Forms.TextBox()
        Me.LabelMiddleName = New System.Windows.Forms.Label()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.DataGridViewUsers = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suffix_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxSearchUser = New System.Windows.Forms.TextBox()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.PanelUsersHeader.SuspendLayout()
        Me.GroupBoxUsers.SuspendLayout()
        CType(Me.DataGridViewUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelUsersHeader
        '
        Me.PanelUsersHeader.Controls.Add(Me.LabelUsers)
        Me.PanelUsersHeader.Controls.Add(Me.ButtonUsersClose)
        Me.PanelUsersHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsersHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsersHeader.Name = "PanelUsersHeader"
        Me.PanelUsersHeader.Size = New System.Drawing.Size(1498, 74)
        Me.PanelUsersHeader.TabIndex = 0
        '
        'LabelUsers
        '
        Me.LabelUsers.AutoSize = True
        Me.LabelUsers.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsers.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelUsers.Location = New System.Drawing.Point(12, 9)
        Me.LabelUsers.Name = "LabelUsers"
        Me.LabelUsers.Size = New System.Drawing.Size(101, 45)
        Me.LabelUsers.TabIndex = 1
        Me.LabelUsers.Text = "Users"
        '
        'ButtonUsersClose
        '
        Me.ButtonUsersClose.BackColor = System.Drawing.Color.Red
        Me.ButtonUsersClose.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonUsersClose.ForeColor = System.Drawing.Color.White
        Me.ButtonUsersClose.Location = New System.Drawing.Point(1449, 3)
        Me.ButtonUsersClose.Name = "ButtonUsersClose"
        Me.ButtonUsersClose.Size = New System.Drawing.Size(46, 40)
        Me.ButtonUsersClose.TabIndex = 0
        Me.ButtonUsersClose.TabStop = False
        Me.ButtonUsersClose.Text = "X"
        Me.ButtonUsersClose.UseVisualStyleBackColor = False
        '
        'GroupBoxUsers
        '
        Me.GroupBoxUsers.Controls.Add(Me.IconButtonUsersFormDelete)
        Me.GroupBoxUsers.Controls.Add(Me.IconButtonUsersFormEdit)
        Me.GroupBoxUsers.Controls.Add(Me.IconButtonUsersFormClear)
        Me.GroupBoxUsers.Controls.Add(Me.IconButtonUsersFormSave)
        Me.GroupBoxUsers.Controls.Add(Me.ComboBoxActive)
        Me.GroupBoxUsers.Controls.Add(Me.LabelActive)
        Me.GroupBoxUsers.Controls.Add(Me.ComboBoxRole)
        Me.GroupBoxUsers.Controls.Add(Me.LabelRole)
        Me.GroupBoxUsers.Controls.Add(Me.TextBoxPassword)
        Me.GroupBoxUsers.Controls.Add(Me.LabelPassword)
        Me.GroupBoxUsers.Controls.Add(Me.TextBoxEmail)
        Me.GroupBoxUsers.Controls.Add(Me.LabelEmail)
        Me.GroupBoxUsers.Controls.Add(Me.TextBoxSuffixName)
        Me.GroupBoxUsers.Controls.Add(Me.LabelSuffixName)
        Me.GroupBoxUsers.Controls.Add(Me.TextBoxMiddleName)
        Me.GroupBoxUsers.Controls.Add(Me.LabelMiddleName)
        Me.GroupBoxUsers.Controls.Add(Me.TextBoxLastName)
        Me.GroupBoxUsers.Controls.Add(Me.LabelLastName)
        Me.GroupBoxUsers.Controls.Add(Me.TextBoxFirstName)
        Me.GroupBoxUsers.Controls.Add(Me.LabelFirstName)
        Me.GroupBoxUsers.Location = New System.Drawing.Point(227, 69)
        Me.GroupBoxUsers.Name = "GroupBoxUsers"
        Me.GroupBoxUsers.Size = New System.Drawing.Size(1100, 314)
        Me.GroupBoxUsers.TabIndex = 1
        Me.GroupBoxUsers.TabStop = False
        '
        'IconButtonUsersFormDelete
        '
        Me.IconButtonUsersFormDelete.BackColor = System.Drawing.Color.Red
        Me.IconButtonUsersFormDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonUsersFormDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonUsersFormDelete.ForeColor = System.Drawing.Color.White
        Me.IconButtonUsersFormDelete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButtonUsersFormDelete.IconColor = System.Drawing.Color.White
        Me.IconButtonUsersFormDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonUsersFormDelete.IconSize = 25
        Me.IconButtonUsersFormDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonUsersFormDelete.Location = New System.Drawing.Point(878, 234)
        Me.IconButtonUsersFormDelete.Name = "IconButtonUsersFormDelete"
        Me.IconButtonUsersFormDelete.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonUsersFormDelete.TabIndex = 21
        Me.IconButtonUsersFormDelete.Text = "Delete"
        Me.IconButtonUsersFormDelete.UseVisualStyleBackColor = False
        '
        'IconButtonUsersFormEdit
        '
        Me.IconButtonUsersFormEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButtonUsersFormEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonUsersFormEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonUsersFormEdit.ForeColor = System.Drawing.Color.White
        Me.IconButtonUsersFormEdit.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.IconButtonUsersFormEdit.IconColor = System.Drawing.Color.White
        Me.IconButtonUsersFormEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonUsersFormEdit.IconSize = 25
        Me.IconButtonUsersFormEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonUsersFormEdit.Location = New System.Drawing.Point(651, 234)
        Me.IconButtonUsersFormEdit.Name = "IconButtonUsersFormEdit"
        Me.IconButtonUsersFormEdit.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonUsersFormEdit.TabIndex = 20
        Me.IconButtonUsersFormEdit.Text = "Edit"
        Me.IconButtonUsersFormEdit.UseVisualStyleBackColor = False
        '
        'IconButtonUsersFormClear
        '
        Me.IconButtonUsersFormClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconButtonUsersFormClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonUsersFormClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonUsersFormClear.ForeColor = System.Drawing.Color.White
        Me.IconButtonUsersFormClear.IconChar = FontAwesome.Sharp.IconChar.Brush
        Me.IconButtonUsersFormClear.IconColor = System.Drawing.Color.White
        Me.IconButtonUsersFormClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonUsersFormClear.IconSize = 25
        Me.IconButtonUsersFormClear.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonUsersFormClear.Location = New System.Drawing.Point(416, 234)
        Me.IconButtonUsersFormClear.Name = "IconButtonUsersFormClear"
        Me.IconButtonUsersFormClear.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonUsersFormClear.TabIndex = 19
        Me.IconButtonUsersFormClear.Text = "Clear"
        Me.IconButtonUsersFormClear.UseVisualStyleBackColor = False
        '
        'IconButtonUsersFormSave
        '
        Me.IconButtonUsersFormSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonUsersFormSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonUsersFormSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonUsersFormSave.ForeColor = System.Drawing.Color.White
        Me.IconButtonUsersFormSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.IconButtonUsersFormSave.IconColor = System.Drawing.Color.White
        Me.IconButtonUsersFormSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonUsersFormSave.IconSize = 25
        Me.IconButtonUsersFormSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonUsersFormSave.Location = New System.Drawing.Point(192, 234)
        Me.IconButtonUsersFormSave.Name = "IconButtonUsersFormSave"
        Me.IconButtonUsersFormSave.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonUsersFormSave.TabIndex = 4
        Me.IconButtonUsersFormSave.Text = "Save"
        Me.IconButtonUsersFormSave.UseVisualStyleBackColor = False
        '
        'ComboBoxActive
        '
        Me.ComboBoxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxActive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxActive.FormattingEnabled = True
        Me.ComboBoxActive.Items.AddRange(New Object() {"", "Active", "Inactive"})
        Me.ComboBoxActive.Location = New System.Drawing.Point(765, 163)
        Me.ComboBoxActive.Name = "ComboBoxActive"
        Me.ComboBoxActive.Size = New System.Drawing.Size(289, 40)
        Me.ComboBoxActive.TabIndex = 15
        '
        'LabelActive
        '
        Me.LabelActive.AutoSize = True
        Me.LabelActive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelActive.Location = New System.Drawing.Point(579, 169)
        Me.LabelActive.Name = "LabelActive"
        Me.LabelActive.Size = New System.Drawing.Size(85, 32)
        Me.LabelActive.TabIndex = 14
        Me.LabelActive.Text = "Active"
        '
        'ComboBoxRole
        '
        Me.ComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxRole.FormatString = "ABC"
        Me.ComboBoxRole.FormattingEnabled = True
        Me.ComboBoxRole.Items.AddRange(New Object() {""})
        Me.ComboBoxRole.Location = New System.Drawing.Point(765, 117)
        Me.ComboBoxRole.Name = "ComboBoxRole"
        Me.ComboBoxRole.Size = New System.Drawing.Size(289, 40)
        Me.ComboBoxRole.Sorted = True
        Me.ComboBoxRole.TabIndex = 13
        '
        'LabelRole
        '
        Me.LabelRole.AutoSize = True
        Me.LabelRole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelRole.Location = New System.Drawing.Point(579, 123)
        Me.LabelRole.Name = "LabelRole"
        Me.LabelRole.Size = New System.Drawing.Size(64, 32)
        Me.LabelRole.TabIndex = 12
        Me.LabelRole.Text = "Role"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxPassword.Location = New System.Drawing.Point(765, 75)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PlaceholderText = "Password"
        Me.TextBoxPassword.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxPassword.TabIndex = 11
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPassword.Location = New System.Drawing.Point(579, 78)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(122, 32)
        Me.LabelPassword.TabIndex = 10
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxEmail.Location = New System.Drawing.Point(765, 30)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.PlaceholderText = "Email"
        Me.TextBoxEmail.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxEmail.TabIndex = 9
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelEmail.Location = New System.Drawing.Point(579, 33)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(76, 32)
        Me.LabelEmail.TabIndex = 8
        Me.LabelEmail.Text = "Email"
        '
        'TextBoxSuffixName
        '
        Me.TextBoxSuffixName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxSuffixName.Location = New System.Drawing.Point(192, 159)
        Me.TextBoxSuffixName.Name = "TextBoxSuffixName"
        Me.TextBoxSuffixName.PlaceholderText = "Suffix Name"
        Me.TextBoxSuffixName.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxSuffixName.TabIndex = 7
        '
        'LabelSuffixName
        '
        Me.LabelSuffixName.AutoSize = True
        Me.LabelSuffixName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSuffixName.Location = New System.Drawing.Point(6, 162)
        Me.LabelSuffixName.Name = "LabelSuffixName"
        Me.LabelSuffixName.Size = New System.Drawing.Size(154, 32)
        Me.LabelSuffixName.TabIndex = 6
        Me.LabelSuffixName.Text = "Suffix Name"
        '
        'TextBoxMiddleName
        '
        Me.TextBoxMiddleName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxMiddleName.Location = New System.Drawing.Point(192, 114)
        Me.TextBoxMiddleName.Name = "TextBoxMiddleName"
        Me.TextBoxMiddleName.PlaceholderText = "Middle Name"
        Me.TextBoxMiddleName.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxMiddleName.TabIndex = 5
        '
        'LabelMiddleName
        '
        Me.LabelMiddleName.AutoSize = True
        Me.LabelMiddleName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelMiddleName.Location = New System.Drawing.Point(6, 117)
        Me.LabelMiddleName.Name = "LabelMiddleName"
        Me.LabelMiddleName.Size = New System.Drawing.Size(168, 32)
        Me.LabelMiddleName.TabIndex = 4
        Me.LabelMiddleName.Text = "Middle Name"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxLastName.Location = New System.Drawing.Point(192, 69)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.PlaceholderText = "Last Name"
        Me.TextBoxLastName.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxLastName.TabIndex = 3
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelLastName.Location = New System.Drawing.Point(6, 72)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(133, 32)
        Me.LabelLastName.TabIndex = 2
        Me.LabelLastName.Text = "Last Name"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxFirstName.Location = New System.Drawing.Point(192, 24)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.PlaceholderText = "First Name"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxFirstName.TabIndex = 1
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFirstName.Location = New System.Drawing.Point(6, 27)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(137, 32)
        Me.LabelFirstName.TabIndex = 0
        Me.LabelFirstName.Text = "First Name"
        '
        'DataGridViewUsers
        '
        Me.DataGridViewUsers.AllowUserToAddRows = False
        Me.DataGridViewUsers.AllowUserToDeleteRows = False
        Me.DataGridViewUsers.AllowUserToResizeRows = False
        Me.DataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.first_name, Me.last_name, Me.middle_name, Me.suffix_name, Me.email, Me.active})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsers.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewUsers.Location = New System.Drawing.Point(43, 453)
        Me.DataGridViewUsers.MultiSelect = False
        Me.DataGridViewUsers.Name = "DataGridViewUsers"
        Me.DataGridViewUsers.ReadOnly = True
        Me.DataGridViewUsers.RowHeadersWidth = 70
        Me.DataGridViewUsers.RowTemplate.Height = 33
        Me.DataGridViewUsers.Size = New System.Drawing.Size(1414, 315)
        Me.DataGridViewUsers.TabIndex = 2
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'first_name
        '
        Me.first_name.DataPropertyName = "first_name"
        Me.first_name.HeaderText = "First Name"
        Me.first_name.MinimumWidth = 8
        Me.first_name.Name = "first_name"
        Me.first_name.ReadOnly = True
        '
        'last_name
        '
        Me.last_name.DataPropertyName = "last_name"
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.MinimumWidth = 8
        Me.last_name.Name = "last_name"
        Me.last_name.ReadOnly = True
        '
        'middle_name
        '
        Me.middle_name.DataPropertyName = "middle_name"
        Me.middle_name.HeaderText = "Middle Name"
        Me.middle_name.MinimumWidth = 8
        Me.middle_name.Name = "middle_name"
        Me.middle_name.ReadOnly = True
        '
        'suffix_name
        '
        Me.suffix_name.DataPropertyName = "suffix_name"
        Me.suffix_name.HeaderText = "Suffix Name"
        Me.suffix_name.MinimumWidth = 8
        Me.suffix_name.Name = "suffix_name"
        Me.suffix_name.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.MinimumWidth = 8
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'active
        '
        Me.active.DataPropertyName = "active"
        Me.active.HeaderText = "Active"
        Me.active.MinimumWidth = 8
        Me.active.Name = "active"
        Me.active.ReadOnly = True
        '
        'TextBoxSearchUser
        '
        Me.TextBoxSearchUser.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TextBoxSearchUser.Location = New System.Drawing.Point(43, 393)
        Me.TextBoxSearchUser.Name = "TextBoxSearchUser"
        Me.TextBoxSearchUser.PlaceholderText = "Search..."
        Me.TextBoxSearchUser.Size = New System.Drawing.Size(358, 40)
        Me.TextBoxSearchUser.TabIndex = 3
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.Location = New System.Drawing.Point(54, 93)
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.PlaceholderText = "HiddenTB - ID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(150, 31)
        Me.TextBoxUserID.TabIndex = 4
        Me.TextBoxUserID.Visible = False
        '
        'FormUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Controls.Add(Me.TextBoxSearchUser)
        Me.Controls.Add(Me.DataGridViewUsers)
        Me.Controls.Add(Me.GroupBoxUsers)
        Me.Controls.Add(Me.PanelUsersHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelUsersHeader.ResumeLayout(False)
        Me.PanelUsersHeader.PerformLayout()
        Me.GroupBoxUsers.ResumeLayout(False)
        Me.GroupBoxUsers.PerformLayout()
        CType(Me.DataGridViewUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelUsersHeader As Panel
    Friend WithEvents ButtonUsersClose As Button
    Friend WithEvents LabelUsers As Label
    Friend WithEvents GroupBoxUsers As GroupBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents TextBoxSuffixName As TextBox
    Friend WithEvents LabelSuffixName As Label
    Friend WithEvents TextBoxMiddleName As TextBox
    Friend WithEvents LabelMiddleName As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents ComboBoxRole As ComboBox
    Friend WithEvents LabelRole As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents ComboBoxActive As ComboBox
    Friend WithEvents LabelActive As Label
    Friend WithEvents DataGridViewUsers As DataGridView
    Friend WithEvents TextBoxSearchUser As TextBox
    Friend WithEvents IconButtonUsersFormSave As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonUsersFormClear As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonUsersFormDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonUsersFormEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents suffix_name As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents active As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxUserID As TextBox
End Class
