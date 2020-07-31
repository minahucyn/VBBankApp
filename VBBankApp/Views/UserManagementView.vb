Imports VBBankApp

Public Class UserManagementView
    Private _viewModel As UserManagementViewModel

    Public Sub New()

        InitializeComponent()
        'initialize view model
        Me._viewModel = New UserManagementViewModel()
        'Bind to view model properties
        InitializeBinding()
        AddHandler DataGridViewAllUsers.RowEnter, AddressOf OnRowFocused
        AddHandler ButtonEdit.Click, AddressOf EnabledEditMode
        AddHandler ButtonCancelAddEdit.Click, AddressOf OnCancelAddEditButtonClick
        AddHandler ButtonSave.Click, AddressOf OnSaveClicked
        AddHandler ButtonAdd.Click, AddressOf EnabledAddMode
        AddHandler ButtonResetPassword.Click, AddressOf OnResetPasswordClick
        AddHandler ButtonUnlockUser.Click, AddressOf OnUnlockUserClick


    End Sub

    Private Sub OnUnlockUserClick(sender As Object, e As EventArgs)
        'check the username for null
        If String.IsNullOrEmpty(_viewModel.SelectedUsername) Then
            MsgBox("A user needs to be selected to unlock the user. Please select the user and try again.")
            Return
        End If

        'check if user is locked
        If _viewModel.SelectedIsUnlocked Then
            MsgBox("Only locked users can be unlocked.")
            Return
        End If

        'call view model to unlock the user
        _viewModel.UnlockUser(_viewModel.SelectedUsername)
    End Sub

    Private Sub OnResetPasswordClick(sender As Object, e As EventArgs)
        'check the username for null
        If String.IsNullOrEmpty(_viewModel.SelectedUsername) Then
            MsgBox("A user needs to be selected to change the password. Please select the user and try again.")
            Return
        End If
        'confirm that the logged in user wants to reset the password
        If MessageBox.Show($"Are you sure that you want to reset the password for user: {_viewModel.SelectedUsername}?",
                           "Reset Password Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'call view model to reset the password
            _viewModel.ResetSelectedUserPassword(_viewModel.SelectedUsername)
        End If
    End Sub

    Private Sub EnabledAddMode(sender As Object, e As EventArgs)
        _viewModel.EnableAddMode()
    End Sub

    Private Sub OnSaveClicked(sender As Object, e As EventArgs)
        'the date picker is not binding properly and giving me trouble
        Select Case True
            Case _viewModel.SelectedBirthdate Is Nothing And DateTimePickerBirthdate.Value.ToString Is Nothing
                MsgBox("Please select a birthdate for the new user and then save.")
                Return
            Case _viewModel.SelectedBirthdate Is Nothing And DateTimePickerBirthdate.Value.ToString IsNot Nothing
                'manually assign the value
                _viewModel.SelectedBirthdate = DateTimePickerBirthdate.Value
            Case Else
                Debug.WriteLine("This should not have been hit!")
        End Select

        'call view model to save the user                 c
        _viewModel.Save()
    End Sub

    Private Sub OnCancelAddEditButtonClick(sender As Object, e As EventArgs)
        'disable add mode
        If _viewModel.IsAddMode Then
            _viewModel.IsAddMode = False
            Return
        ElseIf _viewModel.IsEditMode Then
            'disable edit mode
            _viewModel.EnableEditMode(False)
            Return
        End If
    End Sub

    Private Sub EnabledEditMode(sender As Object, e As EventArgs)
        'enable edit mode
        _viewModel.EnableEditMode(True)
    End Sub

    Private Sub OnRowFocused(sender As Object, e As DataGridViewCellEventArgs)
        'get grid
        Dim grid As DataGridView = sender
        'Get selected user Id
        Dim userId = grid(0, e.RowIndex).Value
        _viewModel.DisplaySelectedUser(userId)
    End Sub

    Private Sub InitializeBinding()
        'bind all users gridview
        DataGridViewAllUsers.DataSource = _viewModel.AllUsers
        'bind nid / pp
        Me.ExtendedTextBoxNidPp.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.SelectedNidPp)))
        Me.ExtendedTextBoxNidPp.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        'bind username
        Me.ExtendedTextBoxUsername.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.SelectedUsername)))
        Me.ExtendedTextBoxUsername.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        'bind Fullname
        Me.ExtendedTextBoxFullname.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.SelectedFullname)))
        Me.ExtendedTextBoxFullname.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        'bind phone number
        Me.ExtendedTextBoxPhoneNumber.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.SelectedPhoneNumber)))
        Me.ExtendedTextBoxPhoneNumber.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        'bind All roles and selected role
        Me.ComboBoxUserRole.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.SelectedRole)))
        Me.ComboBoxUserRole.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        Me.ComboBoxUserRole.DataSource = _viewModel.AllRoles
        'bind selected birthdate
        Me.DateTimePickerBirthdate.DataBindings.Add(New Binding("Value", _viewModel, NameOf(_viewModel.SelectedBirthdate),
                                                                True, DataSourceUpdateMode.OnValidation))
        Me.DateTimePickerBirthdate.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        'bind All gender and selected gender
        Me.ComboBoxGender.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.SelectedGender)))
        Me.ComboBoxGender.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        Me.ComboBoxGender.DataSource = _viewModel.AllGenders
        'bind Is Active
        Me.CheckBoxIsActive.DataBindings.Add(New Binding("Checked", _viewModel, NameOf(_viewModel.SelectedIsActive)))
        Me.CheckBoxIsActive.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        Me.CheckBoxIsActive.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.CheckBoxIsActiveIsVisible)))

        'bind unlocked
        Me.CheckBoxIsUnocked.DataBindings.Add(New Binding("Checked", _viewModel, NameOf(_viewModel.SelectedIsUnlocked)))
        Me.CheckBoxIsUnocked.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        Me.CheckBoxIsUnocked.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.CheckBoxIsUnlockedIsVisible)))

        'button save
        ButtonSave.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsEditMode)))
        'cancel edit button
        ButtonCancelAddEdit.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsCancelEditEnabledVisible)))
        ButtonCancelAddEdit.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.IsCancelEditEnabledVisible)))

        'cancel edit button
        ButtonEdit.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.FalseOnEditMode)))
        ButtonEdit.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.FalseOnEditMode)))
        'button add
        ButtonAdd.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.FalseOnEditMode)))
        'reset Password
        ButtonResetPassword.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.FalseOnEditMode)))
        'button unlock user
        Me.ButtonUnlockUser.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.IsButtonUnlockUserVisible)))

        'bind selected new credit

    End Sub
End Class