<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.GroupBoxMenu = New System.Windows.Forms.GroupBox()
        Me.IconButtonMainFormUserAccess = New FontAwesome.Sharp.IconButton()
        Me.IconButtonMainFormSettings = New FontAwesome.Sharp.IconButton()
        Me.IconButtonMainFormLogout = New FontAwesome.Sharp.IconButton()
        Me.IconButtonMainFormFarms = New FontAwesome.Sharp.IconButton()
        Me.IconButtonMainFormUsers = New FontAwesome.Sharp.IconButton()
        Me.LabelMainMenuSpacer = New System.Windows.Forms.Label()
        Me.PictureBoxBGCLogo = New System.Windows.Forms.PictureBox()
        Me.PanelMainHeader = New System.Windows.Forms.Panel()
        Me.ButtonMainFormClose = New System.Windows.Forms.Button()
        Me.ButtonUsersClose = New System.Windows.Forms.Button()
        Me.LabelLoginHeading = New System.Windows.Forms.Label()
        Me.PanelMainPane = New System.Windows.Forms.Panel()
        Me.StatusStripMainForm = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelTimeLogged = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IconButtonMainFormDepartment = New FontAwesome.Sharp.IconButton()
        Me.PanelSideMenu.SuspendLayout()
        Me.GroupBoxMenu.SuspendLayout()
        CType(Me.PictureBoxBGCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMainHeader.SuspendLayout()
        Me.PanelMainPane.SuspendLayout()
        Me.StatusStripMainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.Controls.Add(Me.GroupBoxMenu)
        Me.PanelSideMenu.Controls.Add(Me.LabelMainMenuSpacer)
        Me.PanelSideMenu.Controls.Add(Me.PictureBoxBGCLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(218, 798)
        Me.PanelSideMenu.TabIndex = 0
        '
        'GroupBoxMenu
        '
        Me.GroupBoxMenu.Controls.Add(Me.IconButtonMainFormDepartment)
        Me.GroupBoxMenu.Controls.Add(Me.IconButtonMainFormUserAccess)
        Me.GroupBoxMenu.Controls.Add(Me.IconButtonMainFormSettings)
        Me.GroupBoxMenu.Controls.Add(Me.IconButtonMainFormLogout)
        Me.GroupBoxMenu.Controls.Add(Me.IconButtonMainFormFarms)
        Me.GroupBoxMenu.Controls.Add(Me.IconButtonMainFormUsers)
        Me.GroupBoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxMenu.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxMenu.Location = New System.Drawing.Point(0, 106)
        Me.GroupBoxMenu.Name = "GroupBoxMenu"
        Me.GroupBoxMenu.Size = New System.Drawing.Size(218, 692)
        Me.GroupBoxMenu.TabIndex = 5
        Me.GroupBoxMenu.TabStop = False
        Me.GroupBoxMenu.Text = "Main Menu"
        '
        'IconButtonMainFormUserAccess
        '
        Me.IconButtonMainFormUserAccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonMainFormUserAccess.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonMainFormUserAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMainFormUserAccess.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonMainFormUserAccess.ForeColor = System.Drawing.Color.White
        Me.IconButtonMainFormUserAccess.IconChar = FontAwesome.Sharp.IconChar.UserLock
        Me.IconButtonMainFormUserAccess.IconColor = System.Drawing.Color.White
        Me.IconButtonMainFormUserAccess.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMainFormUserAccess.IconSize = 30
        Me.IconButtonMainFormUserAccess.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonMainFormUserAccess.Location = New System.Drawing.Point(3, 117)
        Me.IconButtonMainFormUserAccess.Name = "IconButtonMainFormUserAccess"
        Me.IconButtonMainFormUserAccess.Size = New System.Drawing.Size(212, 41)
        Me.IconButtonMainFormUserAccess.TabIndex = 3
        Me.IconButtonMainFormUserAccess.Text = "Access"
        Me.IconButtonMainFormUserAccess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonMainFormUserAccess.UseVisualStyleBackColor = False
        '
        'IconButtonMainFormSettings
        '
        Me.IconButtonMainFormSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonMainFormSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButtonMainFormSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMainFormSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonMainFormSettings.ForeColor = System.Drawing.Color.White
        Me.IconButtonMainFormSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs
        Me.IconButtonMainFormSettings.IconColor = System.Drawing.Color.White
        Me.IconButtonMainFormSettings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMainFormSettings.IconSize = 30
        Me.IconButtonMainFormSettings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonMainFormSettings.Location = New System.Drawing.Point(3, 607)
        Me.IconButtonMainFormSettings.Name = "IconButtonMainFormSettings"
        Me.IconButtonMainFormSettings.Size = New System.Drawing.Size(212, 41)
        Me.IconButtonMainFormSettings.TabIndex = 8
        Me.IconButtonMainFormSettings.Text = "Settings"
        Me.IconButtonMainFormSettings.UseVisualStyleBackColor = False
        '
        'IconButtonMainFormLogout
        '
        Me.IconButtonMainFormLogout.BackColor = System.Drawing.Color.Red
        Me.IconButtonMainFormLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButtonMainFormLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMainFormLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonMainFormLogout.ForeColor = System.Drawing.Color.White
        Me.IconButtonMainFormLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButtonMainFormLogout.IconColor = System.Drawing.Color.White
        Me.IconButtonMainFormLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMainFormLogout.IconSize = 30
        Me.IconButtonMainFormLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonMainFormLogout.Location = New System.Drawing.Point(3, 648)
        Me.IconButtonMainFormLogout.Name = "IconButtonMainFormLogout"
        Me.IconButtonMainFormLogout.Size = New System.Drawing.Size(212, 41)
        Me.IconButtonMainFormLogout.TabIndex = 7
        Me.IconButtonMainFormLogout.Text = "Logout"
        Me.IconButtonMainFormLogout.UseVisualStyleBackColor = False
        '
        'IconButtonMainFormFarms
        '
        Me.IconButtonMainFormFarms.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonMainFormFarms.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonMainFormFarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMainFormFarms.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonMainFormFarms.ForeColor = System.Drawing.Color.White
        Me.IconButtonMainFormFarms.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.IconButtonMainFormFarms.IconColor = System.Drawing.Color.White
        Me.IconButtonMainFormFarms.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMainFormFarms.IconSize = 30
        Me.IconButtonMainFormFarms.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonMainFormFarms.Location = New System.Drawing.Point(3, 76)
        Me.IconButtonMainFormFarms.Name = "IconButtonMainFormFarms"
        Me.IconButtonMainFormFarms.Size = New System.Drawing.Size(212, 41)
        Me.IconButtonMainFormFarms.TabIndex = 2
        Me.IconButtonMainFormFarms.Text = "Farms"
        Me.IconButtonMainFormFarms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonMainFormFarms.UseVisualStyleBackColor = False
        '
        'IconButtonMainFormUsers
        '
        Me.IconButtonMainFormUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonMainFormUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonMainFormUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMainFormUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonMainFormUsers.ForeColor = System.Drawing.Color.White
        Me.IconButtonMainFormUsers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButtonMainFormUsers.IconColor = System.Drawing.Color.White
        Me.IconButtonMainFormUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMainFormUsers.IconSize = 30
        Me.IconButtonMainFormUsers.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonMainFormUsers.Location = New System.Drawing.Point(3, 35)
        Me.IconButtonMainFormUsers.Name = "IconButtonMainFormUsers"
        Me.IconButtonMainFormUsers.Size = New System.Drawing.Size(212, 41)
        Me.IconButtonMainFormUsers.TabIndex = 1
        Me.IconButtonMainFormUsers.Text = "Users"
        Me.IconButtonMainFormUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonMainFormUsers.UseVisualStyleBackColor = False
        '
        'LabelMainMenuSpacer
        '
        Me.LabelMainMenuSpacer.AutoSize = True
        Me.LabelMainMenuSpacer.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelMainMenuSpacer.Location = New System.Drawing.Point(0, 74)
        Me.LabelMainMenuSpacer.Name = "LabelMainMenuSpacer"
        Me.LabelMainMenuSpacer.Size = New System.Drawing.Size(21, 32)
        Me.LabelMainMenuSpacer.TabIndex = 4
        Me.LabelMainMenuSpacer.Text = " "
        '
        'PictureBoxBGCLogo
        '
        Me.PictureBoxBGCLogo.BackgroundImage = CType(resources.GetObject("PictureBoxBGCLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxBGCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxBGCLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBoxBGCLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxBGCLogo.Name = "PictureBoxBGCLogo"
        Me.PictureBoxBGCLogo.Size = New System.Drawing.Size(218, 74)
        Me.PictureBoxBGCLogo.TabIndex = 1
        Me.PictureBoxBGCLogo.TabStop = False
        '
        'PanelMainHeader
        '
        Me.PanelMainHeader.Controls.Add(Me.ButtonMainFormClose)
        Me.PanelMainHeader.Controls.Add(Me.ButtonUsersClose)
        Me.PanelMainHeader.Controls.Add(Me.LabelLoginHeading)
        Me.PanelMainHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMainHeader.Location = New System.Drawing.Point(218, 0)
        Me.PanelMainHeader.Name = "PanelMainHeader"
        Me.PanelMainHeader.Size = New System.Drawing.Size(1280, 74)
        Me.PanelMainHeader.TabIndex = 1
        '
        'ButtonMainFormClose
        '
        Me.ButtonMainFormClose.BackColor = System.Drawing.Color.Red
        Me.ButtonMainFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMainFormClose.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonMainFormClose.ForeColor = System.Drawing.Color.White
        Me.ButtonMainFormClose.Location = New System.Drawing.Point(1234, 2)
        Me.ButtonMainFormClose.Name = "ButtonMainFormClose"
        Me.ButtonMainFormClose.Size = New System.Drawing.Size(46, 40)
        Me.ButtonMainFormClose.TabIndex = 3
        Me.ButtonMainFormClose.TabStop = False
        Me.ButtonMainFormClose.Text = "X"
        Me.ButtonMainFormClose.UseVisualStyleBackColor = False
        '
        'ButtonUsersClose
        '
        Me.ButtonUsersClose.BackColor = System.Drawing.Color.Red
        Me.ButtonUsersClose.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonUsersClose.ForeColor = System.Drawing.Color.White
        Me.ButtonUsersClose.Location = New System.Drawing.Point(1429, 3)
        Me.ButtonUsersClose.Name = "ButtonUsersClose"
        Me.ButtonUsersClose.Size = New System.Drawing.Size(46, 40)
        Me.ButtonUsersClose.TabIndex = 5
        Me.ButtonUsersClose.TabStop = False
        Me.ButtonUsersClose.Text = "X"
        Me.ButtonUsersClose.UseVisualStyleBackColor = False
        '
        'LabelLoginHeading
        '
        Me.LabelLoginHeading.AutoSize = True
        Me.LabelLoginHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelLoginHeading.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelLoginHeading.ForeColor = System.Drawing.Color.Black
        Me.LabelLoginHeading.Location = New System.Drawing.Point(433, 2)
        Me.LabelLoginHeading.Name = "LabelLoginHeading"
        Me.LabelLoginHeading.Size = New System.Drawing.Size(436, 48)
        Me.LabelLoginHeading.TabIndex = 2
        Me.LabelLoginHeading.Text = "Corrective Action Report"
        Me.LabelLoginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMainPane
        '
        Me.PanelMainPane.AutoScroll = True
        Me.PanelMainPane.Controls.Add(Me.StatusStripMainForm)
        Me.PanelMainPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainPane.ForeColor = System.Drawing.Color.Black
        Me.PanelMainPane.Location = New System.Drawing.Point(218, 74)
        Me.PanelMainPane.Name = "PanelMainPane"
        Me.PanelMainPane.Size = New System.Drawing.Size(1280, 724)
        Me.PanelMainPane.TabIndex = 2
        '
        'StatusStripMainForm
        '
        Me.StatusStripMainForm.BackColor = System.Drawing.Color.Transparent
        Me.StatusStripMainForm.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStripMainForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelUser, Me.ToolStripStatusLabelTimeLogged})
        Me.StatusStripMainForm.Location = New System.Drawing.Point(0, 692)
        Me.StatusStripMainForm.Name = "StatusStripMainForm"
        Me.StatusStripMainForm.Size = New System.Drawing.Size(1280, 32)
        Me.StatusStripMainForm.TabIndex = 0
        Me.StatusStripMainForm.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelUser
        '
        Me.ToolStripStatusLabelUser.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabelUser.Name = "ToolStripStatusLabelUser"
        Me.ToolStripStatusLabelUser.Size = New System.Drawing.Size(205, 25)
        Me.ToolStripStatusLabelUser.Text = "ToolStripStatusLabelUser"
        '
        'ToolStripStatusLabelTimeLogged
        '
        Me.ToolStripStatusLabelTimeLogged.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabelTimeLogged.Name = "ToolStripStatusLabelTimeLogged"
        Me.ToolStripStatusLabelTimeLogged.Size = New System.Drawing.Size(269, 25)
        Me.ToolStripStatusLabelTimeLogged.Text = "ToolStripStatusLabelTimeLogged"
        '
        'IconButtonMainFormDepartment
        '
        Me.IconButtonMainFormDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonMainFormDepartment.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonMainFormDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMainFormDepartment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonMainFormDepartment.ForeColor = System.Drawing.Color.White
        Me.IconButtonMainFormDepartment.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.IconButtonMainFormDepartment.IconColor = System.Drawing.Color.White
        Me.IconButtonMainFormDepartment.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMainFormDepartment.IconSize = 30
        Me.IconButtonMainFormDepartment.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonMainFormDepartment.Location = New System.Drawing.Point(3, 158)
        Me.IconButtonMainFormDepartment.Name = "IconButtonMainFormDepartment"
        Me.IconButtonMainFormDepartment.Size = New System.Drawing.Size(212, 41)
        Me.IconButtonMainFormDepartment.TabIndex = 9
        Me.IconButtonMainFormDepartment.Text = "Departments"
        Me.IconButtonMainFormDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonMainFormDepartment.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelMainPane)
        Me.Controls.Add(Me.PanelMainHeader)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelSideMenu.PerformLayout()
        Me.GroupBoxMenu.ResumeLayout(False)
        CType(Me.PictureBoxBGCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMainHeader.ResumeLayout(False)
        Me.PanelMainHeader.PerformLayout()
        Me.PanelMainPane.ResumeLayout(False)
        Me.PanelMainPane.PerformLayout()
        Me.StatusStripMainForm.ResumeLayout(False)
        Me.StatusStripMainForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents PanelMainHeader As Panel
    Friend WithEvents LabelLoginHeading As Label
    Friend WithEvents PictureBoxBGCLogo As PictureBox
    Friend WithEvents PanelMainPane As Panel
    Friend WithEvents LabelMainMenuSpacer As Label
    Friend WithEvents GroupBoxMenu As GroupBox
    Friend WithEvents ButtonUsersClose As Button
    Friend WithEvents StatusStripMainForm As StatusStrip
    Friend WithEvents ToolStripStatusLabelUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelTimeLogged As ToolStripStatusLabel
    Friend WithEvents ButtonMainFormClose As Button
    Friend WithEvents IconButtonMainFormUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMainFormFarms As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMainFormSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMainFormLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMainFormUserAccess As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMainFormDepartment As FontAwesome.Sharp.IconButton
End Class
