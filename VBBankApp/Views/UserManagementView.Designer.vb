<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementView
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
        Me.ExtendedGroupBoxAllUsers = New VBBankApp.ExtendedGroupBox()
        Me.DataGridViewAllUsers = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NidPp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsUnLocked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ExtendedGroupBoxUsers = New VBBankApp.ExtendedGroupBox()
        Me.ButtonAddSaveUser = New System.Windows.Forms.Button()
        Me.ButtonUnlock = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonActivateDeactivate = New System.Windows.Forms.Button()
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelRole = New System.Windows.Forms.Label()
        Me.LabelNidPp = New System.Windows.Forms.Label()
        Me.LabelBirthdate = New System.Windows.Forms.Label()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.ExtendedTextBoxFullname = New VBBankApp.ExtendedTextBox()
        Me.ComboBoxUserRole = New System.Windows.Forms.ComboBox()
        Me.ExtendedTextBoxNidPp = New VBBankApp.ExtendedTextBox()
        Me.DateTimePickerBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.ExtendedTextBoxPhoneNumber = New VBBankApp.ExtendedTextBox()
        Me.CheckBoxIsActive = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIsUnocked = New System.Windows.Forms.CheckBox()
        Me.ExtendedTextBoxUsername = New VBBankApp.ExtendedTextBox()
        CType(Me.DataGridViewAllUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExtendedGroupBoxAllUsers
        '
        Me.ExtendedGroupBoxAllUsers.Caption = "All Users"
        Me.ExtendedGroupBoxAllUsers.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBoxAllUsers.Location = New System.Drawing.Point(2, 2)
        Me.ExtendedGroupBoxAllUsers.Name = "ExtendedGroupBoxAllUsers"
        Me.ExtendedGroupBoxAllUsers.Size = New System.Drawing.Size(778, 463)
        Me.ExtendedGroupBoxAllUsers.TabIndex = 0
        '
        'DataGridViewAllUsers
        '
        Me.DataGridViewAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAllUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.FullnameUsername, Me.Role, Me.NidPp, Me.BirthdateAge, Me.Gender, Me.PhoneNumber, Me.IsActive, Me.IsUnLocked})
        Me.DataGridViewAllUsers.Location = New System.Drawing.Point(2, 25)
        Me.DataGridViewAllUsers.Name = "DataGridViewAllUsers"
        Me.DataGridViewAllUsers.Size = New System.Drawing.Size(778, 440)
        Me.DataGridViewAllUsers.TabIndex = 1
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'FullnameUsername
        '
        Me.FullnameUsername.HeaderText = "Fullname (Username)"
        Me.FullnameUsername.Name = "FullnameUsername"
        '
        'Role
        '
        Me.Role.HeaderText = "User Role"
        Me.Role.Name = "Role"
        '
        'NidPp
        '
        Me.NidPp.HeaderText = "Nid / Pp"
        Me.NidPp.Name = "NidPp"
        '
        'BirthdateAge
        '
        Me.BirthdateAge.HeaderText = "Birthdate (Age)"
        Me.BirthdateAge.Name = "BirthdateAge"
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.HeaderText = "Phone Number"
        Me.PhoneNumber.Name = "PhoneNumber"
        '
        'IsActive
        '
        Me.IsActive.HeaderText = "IsActive"
        Me.IsActive.Name = "IsActive"
        '
        'IsUnLocked
        '
        Me.IsUnLocked.HeaderText = "Is Unlocked"
        Me.IsUnLocked.Name = "IsUnLocked"
        '
        'ExtendedGroupBoxUsers
        '
        Me.ExtendedGroupBoxUsers.Caption = "User"
        Me.ExtendedGroupBoxUsers.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBoxUsers.Location = New System.Drawing.Point(786, 2)
        Me.ExtendedGroupBoxUsers.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExtendedGroupBoxUsers.Name = "ExtendedGroupBoxUsers"
        Me.ExtendedGroupBoxUsers.Size = New System.Drawing.Size(325, 463)
        Me.ExtendedGroupBoxUsers.TabIndex = 2
        '
        'ButtonAddSaveUser
        '
        Me.ButtonAddSaveUser.Location = New System.Drawing.Point(849, 385)
        Me.ButtonAddSaveUser.Name = "ButtonAddSaveUser"
        Me.ButtonAddSaveUser.Size = New System.Drawing.Size(102, 23)
        Me.ButtonAddSaveUser.TabIndex = 3
        Me.ButtonAddSaveUser.Text = "Add / Save"
        Me.ButtonAddSaveUser.UseVisualStyleBackColor = True
        '
        'ButtonUnlock
        '
        Me.ButtonUnlock.Location = New System.Drawing.Point(849, 414)
        Me.ButtonUnlock.Name = "ButtonUnlock"
        Me.ButtonUnlock.Size = New System.Drawing.Size(102, 23)
        Me.ButtonUnlock.TabIndex = 4
        Me.ButtonUnlock.Text = "Unlock"
        Me.ButtonUnlock.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(957, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Reset Password"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonActivateDeactivate
        '
        Me.ButtonActivateDeactivate.Location = New System.Drawing.Point(957, 385)
        Me.ButtonActivateDeactivate.Name = "ButtonActivateDeactivate"
        Me.ButtonActivateDeactivate.Size = New System.Drawing.Size(102, 23)
        Me.ButtonActivateDeactivate.TabIndex = 6
        Me.ButtonActivateDeactivate.Text = "De/Activate"
        Me.ButtonActivateDeactivate.UseVisualStyleBackColor = True
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Location = New System.Drawing.Point(804, 89)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(54, 13)
        Me.LabelFullname.TabIndex = 7
        Me.LabelFullname.Text = "Fullname"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(954, 39)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(58, 13)
        Me.LabelUsername.TabIndex = 8
        Me.LabelUsername.Text = "Username"
        '
        'LabelRole
        '
        Me.LabelRole.AutoSize = True
        Me.LabelRole.Location = New System.Drawing.Point(954, 139)
        Me.LabelRole.Name = "LabelRole"
        Me.LabelRole.Size = New System.Drawing.Size(30, 13)
        Me.LabelRole.TabIndex = 9
        Me.LabelRole.Text = "Role"
        '
        'LabelNidPp
        '
        Me.LabelNidPp.AutoSize = True
        Me.LabelNidPp.Location = New System.Drawing.Point(804, 39)
        Me.LabelNidPp.Name = "LabelNidPp"
        Me.LabelNidPp.Size = New System.Drawing.Size(118, 13)
        Me.LabelNidPp.TabIndex = 10
        Me.LabelNidPp.Text = "National Id / Passport"
        '
        'LabelBirthdate
        '
        Me.LabelBirthdate.AutoSize = True
        Me.LabelBirthdate.Location = New System.Drawing.Point(804, 194)
        Me.LabelBirthdate.Name = "LabelBirthdate"
        Me.LabelBirthdate.Size = New System.Drawing.Size(54, 13)
        Me.LabelBirthdate.TabIndex = 11
        Me.LabelBirthdate.Text = "Birthdate"
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Location = New System.Drawing.Point(954, 194)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(45, 13)
        Me.LabelGender.TabIndex = 12
        Me.LabelGender.Text = "Gender"
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(804, 138)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(84, 13)
        Me.LabelPhoneNumber.TabIndex = 13
        Me.LabelPhoneNumber.Text = "Phone Number"
        '
        'ExtendedTextBoxFullname
        '
        Me.ExtendedTextBoxFullname.AutoValidate = False
        Me.ExtendedTextBoxFullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ExtendedTextBoxFullname.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxFullname.IsPasswordField = False
        Me.ExtendedTextBoxFullname.Location = New System.Drawing.Point(807, 105)
        Me.ExtendedTextBoxFullname.MinimumValidLength = 0
        Me.ExtendedTextBoxFullname.Name = "ExtendedTextBoxFullname"
        Me.ExtendedTextBoxFullname.NullText = "Fullname"
        Me.ExtendedTextBoxFullname.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBoxFullname.Size = New System.Drawing.Size(294, 22)
        Me.ExtendedTextBoxFullname.TabIndex = 14
        Me.ExtendedTextBoxFullname.Text = "FULLNAME"
        Me.ExtendedTextBoxFullname.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxFullname.TextValidColor = System.Drawing.Color.Honeydew
        '
        'ComboBoxUserRole
        '
        Me.ComboBoxUserRole.FormattingEnabled = True
        Me.ComboBoxUserRole.Location = New System.Drawing.Point(957, 155)
        Me.ComboBoxUserRole.Name = "ComboBoxUserRole"
        Me.ComboBoxUserRole.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxUserRole.TabIndex = 16
        Me.ComboBoxUserRole.Text = "Select user role..."
        '
        'ExtendedTextBoxNidPp
        '
        Me.ExtendedTextBoxNidPp.AutoValidate = False
        Me.ExtendedTextBoxNidPp.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxNidPp.IsPasswordField = False
        Me.ExtendedTextBoxNidPp.Location = New System.Drawing.Point(807, 55)
        Me.ExtendedTextBoxNidPp.MinimumValidLength = 0
        Me.ExtendedTextBoxNidPp.Name = "ExtendedTextBoxNidPp"
        Me.ExtendedTextBoxNidPp.NullText = "National Id / Passport"
        Me.ExtendedTextBoxNidPp.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBoxNidPp.Size = New System.Drawing.Size(144, 22)
        Me.ExtendedTextBoxNidPp.TabIndex = 17
        Me.ExtendedTextBoxNidPp.Text = "National Id / Passport"
        Me.ExtendedTextBoxNidPp.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxNidPp.TextValidColor = System.Drawing.Color.Honeydew
        '
        'DateTimePickerBirthdate
        '
        Me.DateTimePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerBirthdate.Location = New System.Drawing.Point(807, 210)
        Me.DateTimePickerBirthdate.Name = "DateTimePickerBirthdate"
        Me.DateTimePickerBirthdate.Size = New System.Drawing.Size(144, 22)
        Me.DateTimePickerBirthdate.TabIndex = 18
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Location = New System.Drawing.Point(957, 211)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxGender.TabIndex = 19
        Me.ComboBoxGender.Text = "Select gender..."
        '
        'ExtendedTextBoxPhoneNumber
        '
        Me.ExtendedTextBoxPhoneNumber.AutoValidate = False
        Me.ExtendedTextBoxPhoneNumber.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxPhoneNumber.IsPasswordField = False
        Me.ExtendedTextBoxPhoneNumber.Location = New System.Drawing.Point(807, 154)
        Me.ExtendedTextBoxPhoneNumber.MinimumValidLength = 0
        Me.ExtendedTextBoxPhoneNumber.Name = "ExtendedTextBoxPhoneNumber"
        Me.ExtendedTextBoxPhoneNumber.NullText = "Phone Number"
        Me.ExtendedTextBoxPhoneNumber.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBoxPhoneNumber.Size = New System.Drawing.Size(144, 22)
        Me.ExtendedTextBoxPhoneNumber.TabIndex = 20
        Me.ExtendedTextBoxPhoneNumber.Text = "Phone Number"
        Me.ExtendedTextBoxPhoneNumber.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxPhoneNumber.TextValidColor = System.Drawing.Color.Honeydew
        '
        'CheckBoxIsActive
        '
        Me.CheckBoxIsActive.AutoSize = True
        Me.CheckBoxIsActive.Location = New System.Drawing.Point(807, 271)
        Me.CheckBoxIsActive.Name = "CheckBoxIsActive"
        Me.CheckBoxIsActive.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxIsActive.TabIndex = 21
        Me.CheckBoxIsActive.Text = "Is Active"
        Me.CheckBoxIsActive.UseVisualStyleBackColor = True
        '
        'CheckBoxIsUnocked
        '
        Me.CheckBoxIsUnocked.AutoSize = True
        Me.CheckBoxIsUnocked.Location = New System.Drawing.Point(807, 294)
        Me.CheckBoxIsUnocked.Name = "CheckBoxIsUnocked"
        Me.CheckBoxIsUnocked.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxIsUnocked.TabIndex = 22
        Me.CheckBoxIsUnocked.Text = "Is Unlocked"
        Me.CheckBoxIsUnocked.UseVisualStyleBackColor = True
        '
        'ExtendedTextBoxUsername
        '
        Me.ExtendedTextBoxUsername.AutoValidate = False
        Me.ExtendedTextBoxUsername.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxUsername.IsPasswordField = False
        Me.ExtendedTextBoxUsername.Location = New System.Drawing.Point(957, 55)
        Me.ExtendedTextBoxUsername.MinimumValidLength = 0
        Me.ExtendedTextBoxUsername.Name = "ExtendedTextBoxUsername"
        Me.ExtendedTextBoxUsername.NullText = "Username"
        Me.ExtendedTextBoxUsername.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBoxUsername.Size = New System.Drawing.Size(144, 22)
        Me.ExtendedTextBoxUsername.TabIndex = 15
        Me.ExtendedTextBoxUsername.Text = "Username"
        Me.ExtendedTextBoxUsername.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxUsername.TextValidColor = System.Drawing.Color.Honeydew
        '
        'UserManagementView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 469)
        Me.Controls.Add(Me.CheckBoxIsUnocked)
        Me.Controls.Add(Me.CheckBoxIsActive)
        Me.Controls.Add(Me.ExtendedTextBoxPhoneNumber)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.DateTimePickerBirthdate)
        Me.Controls.Add(Me.ExtendedTextBoxNidPp)
        Me.Controls.Add(Me.ComboBoxUserRole)
        Me.Controls.Add(Me.ExtendedTextBoxUsername)
        Me.Controls.Add(Me.ExtendedTextBoxFullname)
        Me.Controls.Add(Me.LabelPhoneNumber)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.LabelBirthdate)
        Me.Controls.Add(Me.LabelNidPp)
        Me.Controls.Add(Me.LabelRole)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelFullname)
        Me.Controls.Add(Me.ButtonActivateDeactivate)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonUnlock)
        Me.Controls.Add(Me.ButtonAddSaveUser)
        Me.Controls.Add(Me.ExtendedGroupBoxUsers)
        Me.Controls.Add(Me.DataGridViewAllUsers)
        Me.Controls.Add(Me.ExtendedGroupBoxAllUsers)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserManagementView"
        Me.Text = "UserManagementView"
        CType(Me.DataGridViewAllUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExtendedGroupBoxAllUsers As ExtendedGroupBox
    Friend WithEvents DataGridViewAllUsers As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents FullnameUsername As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents NidPp As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateAge As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents IsActive As DataGridViewCheckBoxColumn
    Friend WithEvents IsUnLocked As DataGridViewCheckBoxColumn
    Friend WithEvents ExtendedGroupBoxUsers As ExtendedGroupBox
    Friend WithEvents ButtonAddSaveUser As Button
    Friend WithEvents ButtonUnlock As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonActivateDeactivate As Button
    Friend WithEvents LabelFullname As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelRole As Label
    Friend WithEvents LabelNidPp As Label
    Friend WithEvents LabelBirthdate As Label
    Friend WithEvents LabelGender As Label
    Friend WithEvents LabelPhoneNumber As Label
    Friend WithEvents ExtendedTextBoxFullname As ExtendedTextBox
    Friend WithEvents ComboBoxUserRole As ComboBox
    Friend WithEvents ExtendedTextBoxNidPp As ExtendedTextBox
    Friend WithEvents DateTimePickerBirthdate As DateTimePicker
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ExtendedTextBoxPhoneNumber As ExtendedTextBox
    Friend WithEvents CheckBoxIsActive As CheckBox
    Friend WithEvents CheckBoxIsUnocked As CheckBox
    Friend WithEvents ExtendedTextBoxUsername As ExtendedTextBox
End Class
