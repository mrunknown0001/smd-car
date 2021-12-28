<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PanelLoginHeading = New System.Windows.Forms.Panel()
        Me.LabelLoginHeading = New System.Windows.Forms.Label()
        Me.PictureBoxBGCLogo = New System.Windows.Forms.PictureBox()
        Me.PanelLoginFooter = New System.Windows.Forms.Panel()
        Me.LabelDeveloper = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.CheckBoxShowPassword = New System.Windows.Forms.CheckBox()
        Me.LabelLoginForm = New System.Windows.Forms.Label()
        Me.IconButtonLogin = New FontAwesome.Sharp.IconButton()
        Me.IconButtonCancel = New FontAwesome.Sharp.IconButton()
        Me.PanelLoginHeading.SuspendLayout()
        CType(Me.PictureBoxBGCLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLoginFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLoginHeading
        '
        Me.PanelLoginHeading.Controls.Add(Me.LabelLoginHeading)
        Me.PanelLoginHeading.Controls.Add(Me.PictureBoxBGCLogo)
        Me.PanelLoginHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLoginHeading.Location = New System.Drawing.Point(0, 0)
        Me.PanelLoginHeading.Name = "PanelLoginHeading"
        Me.PanelLoginHeading.Size = New System.Drawing.Size(659, 80)
        Me.PanelLoginHeading.TabIndex = 0
        '
        'LabelLoginHeading
        '
        Me.LabelLoginHeading.AutoSize = True
        Me.LabelLoginHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelLoginHeading.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelLoginHeading.ForeColor = System.Drawing.Color.Black
        Me.LabelLoginHeading.Location = New System.Drawing.Point(215, 9)
        Me.LabelLoginHeading.Name = "LabelLoginHeading"
        Me.LabelLoginHeading.Size = New System.Drawing.Size(436, 48)
        Me.LabelLoginHeading.TabIndex = 1
        Me.LabelLoginHeading.Text = "Corrective Action Report"
        Me.LabelLoginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxBGCLogo
        '
        Me.PictureBoxBGCLogo.BackgroundImage = CType(resources.GetObject("PictureBoxBGCLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxBGCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxBGCLogo.Location = New System.Drawing.Point(12, 3)
        Me.PictureBoxBGCLogo.Name = "PictureBoxBGCLogo"
        Me.PictureBoxBGCLogo.Size = New System.Drawing.Size(176, 74)
        Me.PictureBoxBGCLogo.TabIndex = 0
        Me.PictureBoxBGCLogo.TabStop = False
        '
        'PanelLoginFooter
        '
        Me.PanelLoginFooter.Controls.Add(Me.LabelDeveloper)
        Me.PanelLoginFooter.Controls.Add(Me.LabelVersion)
        Me.PanelLoginFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelLoginFooter.ForeColor = System.Drawing.Color.Transparent
        Me.PanelLoginFooter.Location = New System.Drawing.Point(0, 324)
        Me.PanelLoginFooter.Name = "PanelLoginFooter"
        Me.PanelLoginFooter.Size = New System.Drawing.Size(659, 42)
        Me.PanelLoginFooter.TabIndex = 1
        '
        'LabelDeveloper
        '
        Me.LabelDeveloper.AutoSize = True
        Me.LabelDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelDeveloper.ForeColor = System.Drawing.Color.Black
        Me.LabelDeveloper.Location = New System.Drawing.Point(426, 8)
        Me.LabelDeveloper.Name = "LabelDeveloper"
        Me.LabelDeveloper.Size = New System.Drawing.Size(225, 25)
        Me.LabelDeveloper.TabIndex = 1
        Me.LabelDeveloper.Text = "Developed by BGC IT 2021"
        Me.LabelDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelVersion.ForeColor = System.Drawing.Color.Black
        Me.LabelVersion.Location = New System.Drawing.Point(12, 8)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(99, 25)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Version 1.0"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelEmail.ForeColor = System.Drawing.Color.Black
        Me.LabelEmail.Location = New System.Drawing.Point(45, 130)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(76, 32)
        Me.LabelEmail.TabIndex = 3
        Me.LabelEmail.Text = "Email"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelPassword.Location = New System.Drawing.Point(45, 178)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(122, 32)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxEmail.Location = New System.Drawing.Point(191, 123)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.PlaceholderText = "Email"
        Me.TextBoxEmail.Size = New System.Drawing.Size(404, 39)
        Me.TextBoxEmail.TabIndex = 5
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxPassword.Location = New System.Drawing.Point(191, 171)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.PlaceholderText = "Password"
        Me.TextBoxPassword.Size = New System.Drawing.Size(404, 39)
        Me.TextBoxPassword.TabIndex = 6
        '
        'CheckBoxShowPassword
        '
        Me.CheckBoxShowPassword.AutoSize = True
        Me.CheckBoxShowPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBoxShowPassword.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxShowPassword.Location = New System.Drawing.Point(191, 229)
        Me.CheckBoxShowPassword.Name = "CheckBoxShowPassword"
        Me.CheckBoxShowPassword.Size = New System.Drawing.Size(169, 29)
        Me.CheckBoxShowPassword.TabIndex = 7
        Me.CheckBoxShowPassword.Text = "Show Password"
        Me.CheckBoxShowPassword.UseVisualStyleBackColor = True
        '
        'LabelLoginForm
        '
        Me.LabelLoginForm.AutoSize = True
        Me.LabelLoginForm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelLoginForm.ForeColor = System.Drawing.Color.Black
        Me.LabelLoginForm.Location = New System.Drawing.Point(311, 57)
        Me.LabelLoginForm.Name = "LabelLoginForm"
        Me.LabelLoginForm.Size = New System.Drawing.Size(107, 25)
        Me.LabelLoginForm.TabIndex = 2
        Me.LabelLoginForm.Text = "Login Form"
        '
        'IconButtonLogin
        '
        Me.IconButtonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.IconButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonLogin.ForeColor = System.Drawing.Color.White
        Me.IconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconButtonLogin.IconColor = System.Drawing.Color.White
        Me.IconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonLogin.IconSize = 25
        Me.IconButtonLogin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonLogin.Location = New System.Drawing.Point(191, 269)
        Me.IconButtonLogin.Name = "IconButtonLogin"
        Me.IconButtonLogin.Size = New System.Drawing.Size(175, 43)
        Me.IconButtonLogin.TabIndex = 10
        Me.IconButtonLogin.Text = "Login"
        Me.IconButtonLogin.UseVisualStyleBackColor = False
        '
        'IconButtonCancel
        '
        Me.IconButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.IconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButtonCancel.ForeColor = System.Drawing.Color.White
        Me.IconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.IconButtonCancel.IconColor = System.Drawing.Color.White
        Me.IconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonCancel.IconSize = 25
        Me.IconButtonCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButtonCancel.Location = New System.Drawing.Point(420, 269)
        Me.IconButtonCancel.Name = "IconButtonCancel"
        Me.IconButtonCancel.Size = New System.Drawing.Size(175, 43)
        Me.IconButtonCancel.TabIndex = 11
        Me.IconButtonCancel.Text = "Cancel"
        Me.IconButtonCancel.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(659, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.IconButtonCancel)
        Me.Controls.Add(Me.IconButtonLogin)
        Me.Controls.Add(Me.LabelLoginForm)
        Me.Controls.Add(Me.CheckBoxShowPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.PanelLoginFooter)
        Me.Controls.Add(Me.PanelLoginHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelLoginHeading.ResumeLayout(False)
        Me.PanelLoginHeading.PerformLayout()
        CType(Me.PictureBoxBGCLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLoginFooter.ResumeLayout(False)
        Me.PanelLoginFooter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLoginHeading As Panel
    Friend WithEvents PictureBoxBGCLogo As PictureBox
    Friend WithEvents LabelLoginHeading As Label
    Friend WithEvents PanelLoginFooter As Panel
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelDeveloper As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents CheckBoxShowPassword As CheckBox
    Friend WithEvents LabelLoginForm As Label
    Friend WithEvents IconButtonLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonCancel As FontAwesome.Sharp.IconButton
End Class
