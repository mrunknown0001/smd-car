<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.ButtonSettingsClose = New System.Windows.Forms.Button()
        Me.PanelSettingsHeader = New System.Windows.Forms.Panel()
        Me.LabelSettings = New System.Windows.Forms.Label()
        Me.PanelSettingsHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSettingsClose
        '
        Me.ButtonSettingsClose.BackColor = System.Drawing.Color.Red
        Me.ButtonSettingsClose.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSettingsClose.ForeColor = System.Drawing.Color.White
        Me.ButtonSettingsClose.Location = New System.Drawing.Point(1449, 3)
        Me.ButtonSettingsClose.Name = "ButtonSettingsClose"
        Me.ButtonSettingsClose.Size = New System.Drawing.Size(46, 40)
        Me.ButtonSettingsClose.TabIndex = 0
        Me.ButtonSettingsClose.TabStop = False
        Me.ButtonSettingsClose.Text = "X"
        Me.ButtonSettingsClose.UseVisualStyleBackColor = False
        '
        'PanelSettingsHeader
        '
        Me.PanelSettingsHeader.Controls.Add(Me.LabelSettings)
        Me.PanelSettingsHeader.Controls.Add(Me.ButtonSettingsClose)
        Me.PanelSettingsHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSettingsHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelSettingsHeader.Name = "PanelSettingsHeader"
        Me.PanelSettingsHeader.Size = New System.Drawing.Size(1498, 74)
        Me.PanelSettingsHeader.TabIndex = 1
        '
        'LabelSettings
        '
        Me.LabelSettings.AutoSize = True
        Me.LabelSettings.BackColor = System.Drawing.Color.Transparent
        Me.LabelSettings.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSettings.Location = New System.Drawing.Point(12, 9)
        Me.LabelSettings.Name = "LabelSettings"
        Me.LabelSettings.Size = New System.Drawing.Size(141, 45)
        Me.LabelSettings.TabIndex = 1
        Me.LabelSettings.Text = "Settings"
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelSettingsHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelSettingsHeader.ResumeLayout(False)
        Me.PanelSettingsHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSettingsClose As Button
    Friend WithEvents PanelSettingsHeader As Panel
    Friend WithEvents LabelSettings As Label
End Class
