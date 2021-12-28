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
        Me.ButtonFarmsClose = New System.Windows.Forms.Button()
        Me.PanelFarmsHeader = New System.Windows.Forms.Panel()
        Me.LabelFarms = New System.Windows.Forms.Label()
        Me.PanelFarmsHeader.SuspendLayout()
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
        'FormFarms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1498, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelFarmsHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormFarms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelFarmsHeader.ResumeLayout(False)
        Me.PanelFarmsHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFarmsClose As Button
    Friend WithEvents PanelFarmsHeader As Panel
    Friend WithEvents LabelFarms As Label
End Class
