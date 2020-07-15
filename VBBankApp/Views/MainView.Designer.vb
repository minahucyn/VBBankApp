<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
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
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelUserNameAndRole = New BindableToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelUserRoleDisplay = New BindableToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(954, 24)
        Me.MenuStripMain.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelUserNameAndRole, Me.ToolStripSeparator1, Me.ToolStripLabelUserRoleDisplay})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 465)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(954, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabelUserNameAndRole
        '
        Me.ToolStripLabelUserNameAndRole.Name = "ToolStripLabelUserNameAndRole"
        Me.ToolStripLabelUserNameAndRole.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripLabelUserNameAndRole.Text = "Fullname [Username]"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabelUserRoleDisplay
        '
        Me.ToolStripLabelUserRoleDisplay.Name = "ToolStripLabelUserRoleDisplay"
        Me.ToolStripLabelUserRoleDisplay.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabelUserRoleDisplay.Text = "User Role"
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 490)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStripMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Name = "MainView"
        Me.RightToLeftLayout = True
        Me.Text = "Bank"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabelUserNameAndRole As BindableToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabelUserRoleDisplay As BindableToolStripStatusLabel
End Class
