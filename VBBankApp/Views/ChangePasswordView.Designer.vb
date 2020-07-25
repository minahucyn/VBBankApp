<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordView
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
        Me.ButtonChangePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelConditionUpper = New System.Windows.Forms.Label()
        Me.LabelConditionNumberOfletters = New System.Windows.Forms.Label()
        Me.LabelConditionSpecialCharacter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelConditions = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExtendedTextBox1 = New VBBankApp.ExtendedTextBox()
        Me.ExtendedTextBox2 = New VBBankApp.ExtendedTextBox()
        Me.ExtendedTextBox3 = New VBBankApp.ExtendedTextBox()
        Me.PanelConditions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonChangePassword
        '
        Me.ButtonChangePassword.Location = New System.Drawing.Point(22, 131)
        Me.ButtonChangePassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonChangePassword.Name = "ButtonChangePassword"
        Me.ButtonChangePassword.Size = New System.Drawing.Size(194, 30)
        Me.ButtonChangePassword.TabIndex = 3
        Me.ButtonChangePassword.Text = "Change my password"
        Me.ButtonChangePassword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password must contain:"
        '
        'LabelConditionUpper
        '
        Me.LabelConditionUpper.AutoSize = True
        Me.LabelConditionUpper.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConditionUpper.Location = New System.Drawing.Point(4, 30)
        Me.LabelConditionUpper.Name = "LabelConditionUpper"
        Me.LabelConditionUpper.Size = New System.Drawing.Size(190, 17)
        Me.LabelConditionUpper.TabIndex = 5
        Me.LabelConditionUpper.Text = "At least one letter (A-Z or a - z)"
        '
        'LabelConditionNumberOfletters
        '
        Me.LabelConditionNumberOfletters.AutoSize = True
        Me.LabelConditionNumberOfletters.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConditionNumberOfletters.Location = New System.Drawing.Point(4, 81)
        Me.LabelConditionNumberOfletters.Name = "LabelConditionNumberOfletters"
        Me.LabelConditionNumberOfletters.Size = New System.Drawing.Size(126, 17)
        Me.LabelConditionNumberOfletters.TabIndex = 6
        Me.LabelConditionNumberOfletters.Text = "At least 8 characters"
        '
        'LabelConditionSpecialCharacter
        '
        Me.LabelConditionSpecialCharacter.AutoSize = True
        Me.LabelConditionSpecialCharacter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConditionSpecialCharacter.Location = New System.Drawing.Point(4, 47)
        Me.LabelConditionSpecialCharacter.Name = "LabelConditionSpecialCharacter"
        Me.LabelConditionSpecialCharacter.Size = New System.Drawing.Size(173, 17)
        Me.LabelConditionSpecialCharacter.TabIndex = 7
        Me.LabelConditionSpecialCharacter.Text = "At least one special charater"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "At least one number (0 - 9)"
        '
        'PanelConditions
        '
        Me.PanelConditions.Controls.Add(Me.Label1)
        Me.PanelConditions.Controls.Add(Me.Label2)
        Me.PanelConditions.Controls.Add(Me.LabelConditionUpper)
        Me.PanelConditions.Controls.Add(Me.LabelConditionSpecialCharacter)
        Me.PanelConditions.Controls.Add(Me.LabelConditionNumberOfletters)
        Me.PanelConditions.Location = New System.Drawing.Point(269, 18)
        Me.PanelConditions.Name = "PanelConditions"
        Me.PanelConditions.Size = New System.Drawing.Size(211, 102)
        Me.PanelConditions.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ExtendedTextBox1)
        Me.Panel1.Controls.Add(Me.PanelConditions)
        Me.Panel1.Controls.Add(Me.ExtendedTextBox2)
        Me.Panel1.Controls.Add(Me.ButtonChangePassword)
        Me.Panel1.Controls.Add(Me.ExtendedTextBox3)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 188)
        Me.Panel1.TabIndex = 10
        '
        'ExtendedTextBox1
        '
        Me.ExtendedTextBox1.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBox1.IsPasswordField = True
        Me.ExtendedTextBox1.Location = New System.Drawing.Point(22, 21)
        Me.ExtendedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExtendedTextBox1.Name = "ExtendedTextBox1"
        Me.ExtendedTextBox1.NullText = "Current Password"
        Me.ExtendedTextBox1.Size = New System.Drawing.Size(194, 25)
        Me.ExtendedTextBox1.TabIndex = 0
        Me.ExtendedTextBox1.Text = "Current Password"
        '
        'ExtendedTextBox2
        '
        Me.ExtendedTextBox2.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBox2.IsPasswordField = True
        Me.ExtendedTextBox2.Location = New System.Drawing.Point(22, 55)
        Me.ExtendedTextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExtendedTextBox2.Name = "ExtendedTextBox2"
        Me.ExtendedTextBox2.NullText = "New Password"
        Me.ExtendedTextBox2.Size = New System.Drawing.Size(194, 25)
        Me.ExtendedTextBox2.TabIndex = 1
        Me.ExtendedTextBox2.Text = "New Password"
        '
        'ExtendedTextBox3
        '
        Me.ExtendedTextBox3.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBox3.IsPasswordField = True
        Me.ExtendedTextBox3.Location = New System.Drawing.Point(22, 89)
        Me.ExtendedTextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExtendedTextBox3.Name = "ExtendedTextBox3"
        Me.ExtendedTextBox3.NullText = "New Password"
        Me.ExtendedTextBox3.Size = New System.Drawing.Size(194, 25)
        Me.ExtendedTextBox3.TabIndex = 2
        Me.ExtendedTextBox3.Text = "New Password"
        '
        'ChangePasswordView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 189)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChangePasswordView"
        Me.Text = "Change your password"
        Me.PanelConditions.ResumeLayout(False)
        Me.PanelConditions.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExtendedTextBox1 As ExtendedTextBox
    Friend WithEvents ExtendedTextBox2 As ExtendedTextBox
    Friend WithEvents ExtendedTextBox3 As ExtendedTextBox
    Friend WithEvents ButtonChangePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelConditionUpper As Label
    Friend WithEvents LabelConditionNumberOfletters As Label
    Friend WithEvents LabelConditionSpecialCharacter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelConditions As Panel
    Friend WithEvents Panel1 As Panel
End Class
