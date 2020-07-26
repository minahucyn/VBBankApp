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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasswordView))
        Me.ButtonChangePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelConditionUpper = New System.Windows.Forms.Label()
        Me.LabelConditionNumberOfletters = New System.Windows.Forms.Label()
        Me.LabelConditionSpecialCharacter = New System.Windows.Forms.Label()
        Me.LabelConditionNumeric = New System.Windows.Forms.Label()
        Me.PanelConditions = New System.Windows.Forms.Panel()
        Me.PanelChangePassword = New System.Windows.Forms.Panel()
        Me.LabelChangePasswordHeading = New System.Windows.Forms.Label()
        Me.ExtendedTextBoxPassword = New VBBankApp.ExtendedTextBox()
        Me.ExtendedTextBoxNewPassword = New VBBankApp.ExtendedTextBox()
        Me.ExtendedTextBoxConfirmNewPassword = New VBBankApp.ExtendedTextBox()
        Me.LabelPasswordMismatch = New System.Windows.Forms.Label()
        Me.PanelSuccessful = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelConditions.SuspendLayout()
        Me.PanelChangePassword.SuspendLayout()
        Me.PanelSuccessful.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonChangePassword
        '
        Me.ButtonChangePassword.Location = New System.Drawing.Point(22, 200)
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
        'LabelConditionNumeric
        '
        Me.LabelConditionNumeric.AutoSize = True
        Me.LabelConditionNumeric.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConditionNumeric.Location = New System.Drawing.Point(4, 64)
        Me.LabelConditionNumeric.Name = "LabelConditionNumeric"
        Me.LabelConditionNumeric.Size = New System.Drawing.Size(165, 17)
        Me.LabelConditionNumeric.TabIndex = 8
        Me.LabelConditionNumeric.Text = "At least one number (0 - 9)"
        '
        'PanelConditions
        '
        Me.PanelConditions.Controls.Add(Me.Label1)
        Me.PanelConditions.Controls.Add(Me.LabelConditionNumeric)
        Me.PanelConditions.Controls.Add(Me.LabelConditionUpper)
        Me.PanelConditions.Controls.Add(Me.LabelConditionSpecialCharacter)
        Me.PanelConditions.Controls.Add(Me.LabelConditionNumberOfletters)
        Me.PanelConditions.Location = New System.Drawing.Point(269, 69)
        Me.PanelConditions.Name = "PanelConditions"
        Me.PanelConditions.Size = New System.Drawing.Size(211, 102)
        Me.PanelConditions.TabIndex = 9
        '
        'PanelChangePassword
        '
        Me.PanelChangePassword.Controls.Add(Me.LabelChangePasswordHeading)
        Me.PanelChangePassword.Controls.Add(Me.ExtendedTextBoxPassword)
        Me.PanelChangePassword.Controls.Add(Me.PanelConditions)
        Me.PanelChangePassword.Controls.Add(Me.ExtendedTextBoxNewPassword)
        Me.PanelChangePassword.Controls.Add(Me.ButtonChangePassword)
        Me.PanelChangePassword.Controls.Add(Me.ExtendedTextBoxConfirmNewPassword)
        Me.PanelChangePassword.Controls.Add(Me.LabelPasswordMismatch)
        Me.PanelChangePassword.Location = New System.Drawing.Point(1, 0)
        Me.PanelChangePassword.Name = "PanelChangePassword"
        Me.PanelChangePassword.Size = New System.Drawing.Size(509, 243)
        Me.PanelChangePassword.TabIndex = 10
        '
        'LabelChangePasswordHeading
        '
        Me.LabelChangePasswordHeading.AutoSize = True
        Me.LabelChangePasswordHeading.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChangePasswordHeading.Location = New System.Drawing.Point(17, 21)
        Me.LabelChangePasswordHeading.Name = "LabelChangePasswordHeading"
        Me.LabelChangePasswordHeading.Size = New System.Drawing.Size(244, 25)
        Me.LabelChangePasswordHeading.TabIndex = 9
        Me.LabelChangePasswordHeading.Text = "Change password for user"
        '
        'ExtendedTextBoxPassword
        '
        Me.ExtendedTextBoxPassword.AutoValidate = False
        Me.ExtendedTextBoxPassword.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxPassword.IsPasswordField = True
        Me.ExtendedTextBoxPassword.Location = New System.Drawing.Point(22, 72)
        Me.ExtendedTextBoxPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExtendedTextBoxPassword.MinimumValidLength = 0
        Me.ExtendedTextBoxPassword.Name = "ExtendedTextBoxPassword"
        Me.ExtendedTextBoxPassword.NullText = "Current Password"
        Me.ExtendedTextBoxPassword.RegexListToValidateCSV = ""
        Me.ExtendedTextBoxPassword.Size = New System.Drawing.Size(194, 25)
        Me.ExtendedTextBoxPassword.TabIndex = 0
        Me.ExtendedTextBoxPassword.Text = "Current Password"
        Me.ExtendedTextBoxPassword.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxPassword.TextValidColor = System.Drawing.Color.Honeydew
        '
        'ExtendedTextBoxNewPassword
        '
        Me.ExtendedTextBoxNewPassword.AutoValidate = True
        Me.ExtendedTextBoxNewPassword.BackColor = System.Drawing.SystemColors.Window
        Me.ExtendedTextBoxNewPassword.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxNewPassword.IsPasswordField = True
        Me.ExtendedTextBoxNewPassword.Location = New System.Drawing.Point(22, 106)
        Me.ExtendedTextBoxNewPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExtendedTextBoxNewPassword.MinimumValidLength = 8
        Me.ExtendedTextBoxNewPassword.Name = "ExtendedTextBoxNewPassword"
        Me.ExtendedTextBoxNewPassword.NullText = "New Password"
        Me.ExtendedTextBoxNewPassword.RegexListToValidateCSV = "[A-Za-z],[0-9],[\x20-\x2F\x3A-\x40\x5B-\x60\x7B-\x7E]"
        Me.ExtendedTextBoxNewPassword.Size = New System.Drawing.Size(194, 25)
        Me.ExtendedTextBoxNewPassword.TabIndex = 1
        Me.ExtendedTextBoxNewPassword.Text = "New Password"
        Me.ExtendedTextBoxNewPassword.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxNewPassword.TextValidColor = System.Drawing.Color.Honeydew
        '
        'ExtendedTextBoxConfirmNewPassword
        '
        Me.ExtendedTextBoxConfirmNewPassword.AutoValidate = True
        Me.ExtendedTextBoxConfirmNewPassword.BackColor = System.Drawing.SystemColors.Window
        Me.ExtendedTextBoxConfirmNewPassword.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxConfirmNewPassword.IsPasswordField = True
        Me.ExtendedTextBoxConfirmNewPassword.Location = New System.Drawing.Point(22, 140)
        Me.ExtendedTextBoxConfirmNewPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExtendedTextBoxConfirmNewPassword.MinimumValidLength = 8
        Me.ExtendedTextBoxConfirmNewPassword.Name = "ExtendedTextBoxConfirmNewPassword"
        Me.ExtendedTextBoxConfirmNewPassword.NullText = "Confirm New Password"
        Me.ExtendedTextBoxConfirmNewPassword.RegexListToValidateCSV = "[A-Za-z],[\x30-\x39],[\x20-\x2F\x3A-\x40\x5B-\x60\x7B-\x7E]"
        Me.ExtendedTextBoxConfirmNewPassword.Size = New System.Drawing.Size(194, 25)
        Me.ExtendedTextBoxConfirmNewPassword.TabIndex = 2
        Me.ExtendedTextBoxConfirmNewPassword.Text = "Confirm New Password"
        Me.ExtendedTextBoxConfirmNewPassword.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxConfirmNewPassword.TextValidColor = System.Drawing.Color.Honeydew
        '
        'LabelPasswordMismatch
        '
        Me.LabelPasswordMismatch.AutoSize = True
        Me.LabelPasswordMismatch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPasswordMismatch.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelPasswordMismatch.Location = New System.Drawing.Point(19, 169)
        Me.LabelPasswordMismatch.Name = "LabelPasswordMismatch"
        Me.LabelPasswordMismatch.Size = New System.Drawing.Size(137, 15)
        Me.LabelPasswordMismatch.TabIndex = 9
        Me.LabelPasswordMismatch.Text = "Passwords do not match"
        '
        'PanelSuccessful
        '
        Me.PanelSuccessful.Controls.Add(Me.Label3)
        Me.PanelSuccessful.Controls.Add(Me.Label2)
        Me.PanelSuccessful.Controls.Add(Me.PictureBox1)
        Me.PanelSuccessful.Location = New System.Drawing.Point(1, 249)
        Me.PanelSuccessful.Name = "PanelSuccessful"
        Me.PanelSuccessful.Size = New System.Drawing.Size(509, 243)
        Me.PanelSuccessful.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Your password has been changed successfully"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password updated!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(203, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ChangePasswordView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 243)
        Me.Controls.Add(Me.PanelSuccessful)
        Me.Controls.Add(Me.PanelChangePassword)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePasswordView"
        Me.Tag = "ChangePasswordAccess"
        Me.PanelConditions.ResumeLayout(False)
        Me.PanelConditions.PerformLayout()
        Me.PanelChangePassword.ResumeLayout(False)
        Me.PanelChangePassword.PerformLayout()
        Me.PanelSuccessful.ResumeLayout(False)
        Me.PanelSuccessful.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExtendedTextBoxPassword As ExtendedTextBox
    Friend WithEvents ExtendedTextBoxNewPassword As ExtendedTextBox
    Friend WithEvents ExtendedTextBoxConfirmNewPassword As ExtendedTextBox
    Friend WithEvents ButtonChangePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelConditionUpper As Label
    Friend WithEvents LabelConditionNumberOfletters As Label
    Friend WithEvents LabelConditionSpecialCharacter As Label
    Friend WithEvents LabelConditionNumeric As Label
    Friend WithEvents PanelConditions As Panel
    Friend WithEvents PanelChangePassword As Panel
    Friend WithEvents LabelChangePasswordHeading As Label
    Friend WithEvents LabelPasswordMismatch As Label
    Friend WithEvents PanelSuccessful As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
