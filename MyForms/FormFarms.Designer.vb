<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFarms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonFarmsClose = New System.Windows.Forms.Button()
        Me.PanelFarmsHeader = New System.Windows.Forms.Panel()
        Me.LabelFarms = New System.Windows.Forms.Label()
        Me.GroupBoxFarms = New System.Windows.Forms.GroupBox()
        Me.ComboBoxFarmsActive = New System.Windows.Forms.ComboBox()
        Me.LabelFarmsActive = New System.Windows.Forms.Label()
        Me.TextBoxFarmsDescription = New System.Windows.Forms.TextBox()
        Me.LabelFarmsDesc = New System.Windows.Forms.Label()
        Me.TextBoxFarmCode = New System.Windows.Forms.TextBox()
        Me.LabelFarmsFarmCode = New System.Windows.Forms.Label()
        Me.IconButtonFarmsFormDelete = New FontAwesome.Sharp.IconButton()
        Me.IconButtonFarmsFormEdit = New FontAwesome.Sharp.IconButton()
        Me.IconButtonFarmsFormClear = New FontAwesome.Sharp.IconButton()
        Me.IconButtonUsersFormSave = New FontAwesome.Sharp.IconButton()
        Me.TextBoxFarmName = New System.Windows.Forms.TextBox()
        Me.LabelFarmName = New System.Windows.Forms.Label()
        Me.DataGridViewFarms = New System.Windows.Forms.DataGridView()
        Me.TextBoxFarmID = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchFarm = New System.Windows.Forms.TextBox()
        Me.PanelFarmsHeader.SuspendLayout()
        Me.GroupBoxFarms.SuspendLayout()
        CType(Me.DataGridViewFarms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonFarmsClose
        '
        Me.ButtonFarmsClose.BackColor = System.Drawing.Color.Red
        Me.ButtonFarmsClose.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonFarmsClose.ForeColor = System.Drawing.Color.White
        Me.ButtonFarmsClose.Location = New System.Drawing.Point(1449, 3)
        Me.ButtonFarmsClose.Name = "ButtonFarmsClose"
        Me.ButtonFarmsClose.Size = New System.Drawing.Size(46, 40)
        Me.ButtonFarmsClose.TabIndex = 0
        Me.ButtonFarmsClose.TabStop = False
        Me.ButtonFarmsClose.Text = "X"
        Me.ButtonFarmsClose.UseVisualStyleBackColor = False
        '
        'PanelFarmsHeader
        '
        Me.PanelFarmsHeader.Controls.Add(Me.LabelFarms)
        Me.PanelFarmsHeader.Controls.Add(Me.ButtonFarmsClose)
        Me.PanelFarmsHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFarmsHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelFarmsHeader.Name = "PanelFarmsHeader"
        Me.PanelFarmsHeader.Size = New System.Drawing.Size(1498, 74)
        Me.PanelFarmsHeader.TabIndex = 1
        '
        'LabelFarms
        '
        Me.LabelFarms.AutoSize = True
        Me.LabelFarms.BackColor = System.Drawing.Color.Transparent
        Me.LabelFarms.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFarms.Location = New System.Drawing.Point(12, 9)
        Me.LabelFarms.Name = "LabelFarms"
        Me.LabelFarms.Size = New System.Drawing.Size(109, 45)
        Me.LabelFarms.TabIndex = 1
        Me.LabelFarms.Text = "Farms"
        '
        'GroupBoxFarms
        '
        Me.GroupBoxFarms.Controls.Add(Me.ComboBoxFarmsActive)
        Me.GroupBoxFarms.Controls.Add(Me.LabelFarmsActive)
        Me.GroupBoxFarms.Controls.Add(Me.TextBoxFarmsDescription)
        Me.GroupBoxFarms.Controls.Add(Me.LabelFarmsDesc)
        Me.GroupBoxFarms.Controls.Add(Me.TextBoxFarmCode)
        Me.GroupBoxFarms.Controls.Add(Me.LabelFarmsFarmCode)
        Me.GroupBoxFarms.Controls.Add(Me.IconButtonFarmsFormDelete)
        Me.GroupBoxFarms.Controls.Add(Me.IconButtonFarmsFormEdit)
        Me.GroupBoxFarms.Controls.Add(Me.IconButtonFarmsFormClear)
        Me.GroupBoxFarms.Controls.Add(Me.IconButtonUsersFormSave)
        Me.GroupBoxFarms.Controls.Add(Me.TextBoxFarmName)
        Me.GroupBoxFarms.Controls.Add(Me.LabelFarmName)
        Me.GroupBoxFarms.Location = New System.Drawing.Point(211, 80)
        Me.GroupBoxFarms.Name = "GroupBoxFarms"
        Me.GroupBoxFarms.Size = New System.Drawing.Size(1100, 321)
        Me.GroupBoxFarms.TabIndex = 2
        Me.GroupBoxFarms.TabStop = False
        '
        'ComboBoxFarmsActive
        '
        Me.ComboBoxFarmsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFarmsActive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxFarmsActive.FormattingEnabled = True
        Me.ComboBoxFarmsActive.Items.AddRange(New Object() {"", "Active", "Inactive"})
        Me.ComboBoxFarmsActive.Location = New System.Drawing.Point(723, 156)
        Me.ComboBoxFarmsActive.Name = "ComboBoxFarmsActive"
        Me.ComboBoxFarmsActive.Size = New System.Drawing.Size(306, 40)
        Me.ComboBoxFarmsActive.TabIndex = 18
        '
        'LabelFarmsActive
        '
        Me.LabelFarmsActive.AutoSize = True
        Me.LabelFarmsActive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFarmsActive.Location = New System.Drawing.Point(560, 164)
        Me.LabelFarmsActive.Name = "LabelFarmsActive"
        Me.LabelFarmsActive.Size = New System.Drawing.Size(85, 32)
        Me.LabelFarmsActive.TabIndex = 17
        Me.LabelFarmsActive.Text = "Active"
        '
        'TextBoxFarmsDescription
        '
        Me.TextBoxFarmsDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxFarmsDescription.Location = New System.Drawing.Point(723, 24)
        Me.TextBoxFarmsDescription.Multiline = True
        Me.TextBoxFarmsDescription.Name = "TextBoxFarmsDescription"
        Me.TextBoxFarmsDescription.PlaceholderText = "Description"
        Me.TextBoxFarmsDescription.Size = New System.Drawing.Size(306, 105)
        Me.TextBoxFarmsDescription.TabIndex = 16
        '
        'LabelFarmsDesc
        '
        Me.LabelFarmsDesc.AutoSize = True
        Me.LabelFarmsDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFarmsDesc.Location = New System.Drawing.Point(560, 31)
        Me.LabelFarmsDesc.Name = "LabelFarmsDesc"
        Me.LabelFarmsDesc.Size = New System.Drawing.Size(146, 32)
        Me.LabelFarmsDesc.TabIndex = 15
        Me.LabelFarmsDesc.Text = "Description"
        '
        'TextBoxFarmCode
        '
        Me.TextBoxFarmCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxFarmCode.Location = New System.Drawing.Point(192, 90)
        Me.TextBoxFarmCode.Name = "TextBoxFarmCode"
        Me.TextBoxFarmCode.PlaceholderText = "Farm Code"
        Me.TextBoxFarmCode.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxFarmCode.TabIndex = 14
        '
        'LabelFarmsFarmCode
        '
        Me.LabelFarmsFarmCode.AutoSize = True
        Me.LabelFarmsFarmCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFarmsFarmCode.Location = New System.Drawing.Point(6, 93)
        Me.LabelFarmsFarmCode.Name = "LabelFarmsFarmCode"
        Me.LabelFarmsFarmCode.Size = New System.Drawing.Size(135, 32)
        Me.LabelFarmsFarmCode.TabIndex = 13
        Me.LabelFarmsFarmCode.Text = "Farm Code"
        '
        'IconButtonFarmsFormDelete
        '
        Me.IconButtonFarmsFormDelete.BackColor = System.Drawing.Color.Red
        Me.IconButtonFarmsFormDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonFarmsFormDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonFarmsFormDelete.ForeColor = System.Drawing.Color.White
        Me.IconButtonFarmsFormDelete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButtonFarmsFormDelete.IconColor = System.Drawing.Color.White
        Me.IconButtonFarmsFormDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonFarmsFormDelete.IconSize = 25
        Me.IconButtonFarmsFormDelete.Location = New System.Drawing.Point(855, 226)
        Me.IconButtonFarmsFormDelete.Name = "IconButtonFarmsFormDelete"
        Me.IconButtonFarmsFormDelete.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonFarmsFormDelete.TabIndex = 12
        Me.IconButtonFarmsFormDelete.Text = "Delete"
        Me.IconButtonFarmsFormDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonFarmsFormDelete.UseVisualStyleBackColor = False
        '
        'IconButtonFarmsFormEdit
        '
        Me.IconButtonFarmsFormEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButtonFarmsFormEdit.Enabled = False
        Me.IconButtonFarmsFormEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonFarmsFormEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonFarmsFormEdit.ForeColor = System.Drawing.Color.White
        Me.IconButtonFarmsFormEdit.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.IconButtonFarmsFormEdit.IconColor = System.Drawing.Color.White
        Me.IconButtonFarmsFormEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonFarmsFormEdit.IconSize = 25
        Me.IconButtonFarmsFormEdit.Location = New System.Drawing.Point(628, 226)
        Me.IconButtonFarmsFormEdit.Name = "IconButtonFarmsFormEdit"
        Me.IconButtonFarmsFormEdit.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonFarmsFormEdit.TabIndex = 11
        Me.IconButtonFarmsFormEdit.Text = "Edit"
        Me.IconButtonFarmsFormEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonFarmsFormEdit.UseVisualStyleBackColor = False
        '
        'IconButtonFarmsFormClear
        '
        Me.IconButtonFarmsFormClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconButtonFarmsFormClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonFarmsFormClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonFarmsFormClear.ForeColor = System.Drawing.Color.White
        Me.IconButtonFarmsFormClear.IconChar = FontAwesome.Sharp.IconChar.Brush
        Me.IconButtonFarmsFormClear.IconColor = System.Drawing.Color.White
        Me.IconButtonFarmsFormClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonFarmsFormClear.IconSize = 25
        Me.IconButtonFarmsFormClear.Location = New System.Drawing.Point(393, 226)
        Me.IconButtonFarmsFormClear.Name = "IconButtonFarmsFormClear"
        Me.IconButtonFarmsFormClear.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonFarmsFormClear.TabIndex = 10
        Me.IconButtonFarmsFormClear.Text = "Clear"
        Me.IconButtonFarmsFormClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonFarmsFormClear.UseVisualStyleBackColor = False
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
        Me.IconButtonUsersFormSave.Location = New System.Drawing.Point(169, 226)
        Me.IconButtonUsersFormSave.Name = "IconButtonUsersFormSave"
        Me.IconButtonUsersFormSave.Size = New System.Drawing.Size(176, 43)
        Me.IconButtonUsersFormSave.TabIndex = 9
        Me.IconButtonUsersFormSave.Text = "Save"
        Me.IconButtonUsersFormSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonUsersFormSave.UseVisualStyleBackColor = False
        '
        'TextBoxFarmName
        '
        Me.TextBoxFarmName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxFarmName.Location = New System.Drawing.Point(192, 24)
        Me.TextBoxFarmName.Name = "TextBoxFarmName"
        Me.TextBoxFarmName.PlaceholderText = "Farm Name"
        Me.TextBoxFarmName.Size = New System.Drawing.Size(289, 39)
        Me.TextBoxFarmName.TabIndex = 1
        '
        'LabelFarmName
        '
        Me.LabelFarmName.AutoSize = True
        Me.LabelFarmName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFarmName.Location = New System.Drawing.Point(6, 27)
        Me.LabelFarmName.Name = "LabelFarmName"
        Me.LabelFarmName.Size = New System.Drawing.Size(144, 32)
        Me.LabelFarmName.TabIndex = 0
        Me.LabelFarmName.Text = "Farm Name"
        '
        'DataGridViewFarms
        '
        Me.DataGridViewFarms.AllowUserToAddRows = False
        Me.DataGridViewFarms.AllowUserToDeleteRows = False
        Me.DataGridViewFarms.AllowUserToResizeRows = False
        Me.DataGridViewFarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewFarms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewFarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewFarms.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewFarms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewFarms.EnableHeadersVisualStyles = False
        Me.DataGridViewFarms.Location = New System.Drawing.Point(52, 491)
        Me.DataGridViewFarms.MultiSelect = False
        Me.DataGridViewFarms.Name = "DataGridViewFarms"
        Me.DataGridViewFarms.ReadOnly = True
        Me.DataGridViewFarms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridViewFarms.RowHeadersWidth = 70
        Me.DataGridViewFarms.RowTemplate.Height = 33
        Me.DataGridViewFarms.Size = New System.Drawing.Size(1414, 274)
        Me.DataGridViewFarms.TabIndex = 15
        '
        'TextBoxFarmID
        '
        Me.TextBoxFarmID.Location = New System.Drawing.Point(33, 104)
        Me.TextBoxFarmID.Name = "TextBoxFarmID"
        Me.TextBoxFarmID.PlaceholderText = "HiddenTB - ID"
        Me.TextBoxFarmID.Size = New System.Drawing.Size(150, 31)
        Me.TextBoxFarmID.TabIndex = 16
        Me.TextBoxFarmID.Visible = False
        '
        'TextBoxSearchFarm
        '
        Me.TextBoxSearchFarm.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TextBoxSearchFarm.Location = New System.Drawing.Point(52, 429)
        Me.TextBoxSearchFarm.Name = "TextBoxSearchFarm"
        Me.TextBoxSearchFarm.PlaceholderText = "Search..."
        Me.TextBoxSearchFarm.Size = New System.Drawing.Size(358, 40)
        Me.TextBoxSearchFarm.TabIndex = 17
        '
        'FormFarms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxSearchFarm)
        Me.Controls.Add(Me.TextBoxFarmID)
        Me.Controls.Add(Me.DataGridViewFarms)
        Me.Controls.Add(Me.GroupBoxFarms)
        Me.Controls.Add(Me.PanelFarmsHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormFarms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelFarmsHeader.ResumeLayout(False)
        Me.PanelFarmsHeader.PerformLayout()
        Me.GroupBoxFarms.ResumeLayout(False)
        Me.GroupBoxFarms.PerformLayout()
        CType(Me.DataGridViewFarms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonFarmsClose As Button
    Friend WithEvents PanelFarmsHeader As Panel
    Friend WithEvents LabelFarms As Label
    Friend WithEvents GroupBoxFarms As GroupBox
    Friend WithEvents IconButtonFarmsFormDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonFarmsFormEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonFarmsFormClear As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonUsersFormSave As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBoxFarmName As TextBox
    Friend WithEvents LabelFarmName As Label
    Friend WithEvents TextBoxFarmCode As TextBox
    Friend WithEvents LabelFarmsFarmCode As Label
    Friend WithEvents LabelFarmsActive As Label
    Friend WithEvents TextBoxFarmsDescription As TextBox
    Friend WithEvents LabelFarmsDesc As Label
    Friend WithEvents ComboBoxFarmsActive As ComboBox
    Friend WithEvents DataGridViewFarms As DataGridView
    Friend WithEvents TextBoxFarmID As TextBox
    Friend WithEvents TextBoxSearchFarm As TextBox
End Class
