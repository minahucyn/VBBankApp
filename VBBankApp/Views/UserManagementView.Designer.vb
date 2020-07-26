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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NidPp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsUnLocked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ExtendedGroupBox1 = New VBBankApp.ExtendedGroupBox()
        Me.ButtonAddSaveUser = New System.Windows.Forms.Button()
        Me.ButtonUnlock = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonActivateDeactivate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ExtendedTextBox1 = New VBBankApp.ExtendedTextBox()
        Me.ExtendedTextBox2 = New VBBankApp.ExtendedTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ExtendedTextBox3 = New VBBankApp.ExtendedTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ExtendedTextBox4 = New VBBankApp.ExtendedTextBox()
        Me.CheckBoxIsActive = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIsUnocked = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExtendedGroupBoxAllUsers
        '
        Me.ExtendedGroupBoxAllUsers.Caption = "All Users"
        Me.ExtendedGroupBoxAllUsers.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Left
        Me.ExtendedGroupBoxAllUsers.Location = New System.Drawing.Point(2, 2)
        Me.ExtendedGroupBoxAllUsers.Name = "ExtendedGroupBoxAllUsers"
        Me.ExtendedGroupBoxAllUsers.Size = New System.Drawing.Size(778, 463)
        Me.ExtendedGroupBoxAllUsers.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.FullnameUsername, Me.Role, Me.NidPp, Me.BirthdateAge, Me.Gender, Me.PhoneNumber, Me.IsActive, Me.IsUnLocked})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(778, 440)
        Me.DataGridView1.TabIndex = 1
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
        'ExtendedGroupBox1
        '
        Me.ExtendedGroupBox1.Caption = "All Users"
        Me.ExtendedGroupBox1.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBox1.Location = New System.Drawing.Point(786, 2)
        Me.ExtendedGroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExtendedGroupBox1.Name = "ExtendedGroupBox1"
        Me.ExtendedGroupBox1.Size = New System.Drawing.Size(325, 463)
        Me.ExtendedGroupBox1.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(804, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fullname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(954, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(954, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Role"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(804, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "National Id / Passport"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(804, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Birthdate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(954, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(804, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Phone Number"
        '
        'ExtendedTextBox1
        '
        Me.ExtendedTextBox1.AutoValidate = False
        Me.ExtendedTextBox1.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBox1.IsPasswordField = False
        Me.ExtendedTextBox1.Location = New System.Drawing.Point(807, 105)
        Me.ExtendedTextBox1.MinimumValidLength = 0
        Me.ExtendedTextBox1.Name = "ExtendedTextBox1"
        Me.ExtendedTextBox1.NullText = Nothing
        Me.ExtendedTextBox1.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBox1.Size = New System.Drawing.Size(294, 22)
        Me.ExtendedTextBox1.TabIndex = 14
        Me.ExtendedTextBox1.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBox1.TextValidColor = System.Drawing.Color.Honeydew
        '
        'ExtendedTextBox2
        '
        Me.ExtendedTextBox2.AutoValidate = False
        Me.ExtendedTextBox2.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBox2.IsPasswordField = False
        Me.ExtendedTextBox2.Location = New System.Drawing.Point(957, 55)
        Me.ExtendedTextBox2.MinimumValidLength = 0
        Me.ExtendedTextBox2.Name = "ExtendedTextBox2"
        Me.ExtendedTextBox2.NullText = Nothing
        Me.ExtendedTextBox2.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBox2.Size = New System.Drawing.Size(144, 22)
        Me.ExtendedTextBox2.TabIndex = 15
        Me.ExtendedTextBox2.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBox2.TextValidColor = System.Drawing.Color.Honeydew
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(957, 155)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'ExtendedTextBox3
        '
        Me.ExtendedTextBox3.AutoValidate = False
        Me.ExtendedTextBox3.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBox3.IsPasswordField = False
        Me.ExtendedTextBox3.Location = New System.Drawing.Point(807, 55)
        Me.ExtendedTextBox3.MinimumValidLength = 0
        Me.ExtendedTextBox3.Name = "ExtendedTextBox3"
        Me.ExtendedTextBox3.NullText = Nothing
        Me.ExtendedTextBox3.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBox3.Size = New System.Drawing.Size(144, 22)
        Me.ExtendedTextBox3.TabIndex = 17
        Me.ExtendedTextBox3.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBox3.TextValidColor = System.Drawing.Color.Honeydew
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(807, 210)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 22)
        Me.DateTimePicker1.TabIndex = 18
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(957, 211)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 19
        '
        'ExtendedTextBox4
        '
        Me.ExtendedTextBox4.AutoValidate = False
        Me.ExtendedTextBox4.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBox4.IsPasswordField = False
        Me.ExtendedTextBox4.Location = New System.Drawing.Point(807, 154)
        Me.ExtendedTextBox4.MinimumValidLength = 0
        Me.ExtendedTextBox4.Name = "ExtendedTextBox4"
        Me.ExtendedTextBox4.NullText = Nothing
        Me.ExtendedTextBox4.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBox4.Size = New System.Drawing.Size(144, 22)
        Me.ExtendedTextBox4.TabIndex = 20
        Me.ExtendedTextBox4.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBox4.TextValidColor = System.Drawing.Color.Honeydew
        '
        'CheckBoxIsActive
        '
        Me.CheckBoxIsActive.AutoSize = True
        Me.CheckBoxIsActive.Location = New System.Drawing.Point(807, 251)
        Me.CheckBoxIsActive.Name = "CheckBoxIsActive"
        Me.CheckBoxIsActive.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxIsActive.TabIndex = 21
        Me.CheckBoxIsActive.Text = "Is Active"
        Me.CheckBoxIsActive.UseVisualStyleBackColor = True
        '
        'CheckBoxIsUnocked
        '
        Me.CheckBoxIsUnocked.AutoSize = True
        Me.CheckBoxIsUnocked.Location = New System.Drawing.Point(807, 274)
        Me.CheckBoxIsUnocked.Name = "CheckBoxIsUnocked"
        Me.CheckBoxIsUnocked.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxIsUnocked.TabIndex = 22
        Me.CheckBoxIsUnocked.Text = "Is Unlocked"
        Me.CheckBoxIsUnocked.UseVisualStyleBackColor = True
        '
        'UserManagementView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 469)
        Me.Controls.Add(Me.CheckBoxIsUnocked)
        Me.Controls.Add(Me.CheckBoxIsActive)
        Me.Controls.Add(Me.ExtendedTextBox4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ExtendedTextBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ExtendedTextBox2)
        Me.Controls.Add(Me.ExtendedTextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonActivateDeactivate)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonUnlock)
        Me.Controls.Add(Me.ButtonAddSaveUser)
        Me.Controls.Add(Me.ExtendedGroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ExtendedGroupBoxAllUsers)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserManagementView"
        Me.Text = "UserManagementView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExtendedGroupBoxAllUsers As ExtendedGroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents FullnameUsername As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents NidPp As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateAge As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents IsActive As DataGridViewCheckBoxColumn
    Friend WithEvents IsUnLocked As DataGridViewCheckBoxColumn
    Friend WithEvents ExtendedGroupBox1 As ExtendedGroupBox
    Friend WithEvents ButtonAddSaveUser As Button
    Friend WithEvents ButtonUnlock As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonActivateDeactivate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ExtendedTextBox1 As ExtendedTextBox
    Friend WithEvents ExtendedTextBox2 As ExtendedTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ExtendedTextBox3 As ExtendedTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ExtendedTextBox4 As ExtendedTextBox
    Friend WithEvents CheckBoxIsActive As CheckBox
    Friend WithEvents CheckBoxIsUnocked As CheckBox
End Class
