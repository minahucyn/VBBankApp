﻿Imports VBBankApp

Public Class ChangePasswordView
    Private _viewModel As ChangePasswordViewModel

    Public Sub New()
        InitializeComponent()
        Me._viewModel = New ChangePasswordViewModel()
        InitializeDatabinding()

        'Handle events
        AddHandler ExtendedTextBoxNewPassword.BackColorChanged, AddressOf OnManageValidationStatus
        AddHandler ExtendedTextBoxNewPassword.RegexEvaluated, AddressOf OnUpdateUIOnValidation
        AddHandler ExtendedTextBoxNewPassword.ValidationAgainstLengthRequirementChanged, AddressOf OnValidatedAgainstLength
        AddHandler ButtonChangePassword.Click, AddressOf EmulateSuccessFullPasswordChange
    End Sub

    Private Sub EmulateSuccessFullPasswordChange(sender As Object, e As EventArgs)
        PanelSuccessful.Location = PanelChangePassword.Location
        PanelChangePassword.Hide()
    End Sub

    Private Sub OnValidatedAgainstLength(sender As Object, e As Boolean)
        Select Case e
            Case True
                LabelConditionNumberOfletters.ForeColor = Color.Green
            Case False
                LabelConditionNumberOfletters.ForeColor = Color.Red
            Case Else

        End Select
    End Sub

    Private Sub OnUpdateUIOnValidation(sender As Object, e As RegexValidEventArgs)
        Select Case e.RegexIndex
            Case RegexValidation.Alphabet
                If e.Isvalid Then
                    LabelConditionUpper.ForeColor = Color.Green
                Else
                    LabelConditionUpper.ForeColor = Color.Red
                End If
            Case RegexValidation.Numeric
                If e.Isvalid Then
                    LabelConditionNumeric.ForeColor = Color.Green
                Else
                    LabelConditionNumeric.ForeColor = Color.Red
                End If
            Case RegexValidation.SpecialCharacters
                If e.Isvalid Then
                    LabelConditionSpecialCharacter.ForeColor = Color.Green
                Else
                    LabelConditionSpecialCharacter.ForeColor = Color.Red
                End If
        End Select

    End Sub

    ''' <summary>
    ''' Notifies view model of any changes in evaluation of validation criteria of the new password
    ''' </summary>
    Private Sub OnManageValidationStatus(sender As Object, e As EventArgs)
        If ExtendedTextBoxNewPassword.BackColor = ExtendedTextBoxNewPassword.TextValidColor Then
            _viewModel.SetPasswordValidatedStatus(True)
        Else
            _viewModel.SetPasswordValidatedStatus(False)

        End If
    End Sub

    ''' <summary>
    ''' Bind relavent properties of relavent controls
    ''' </summary>
    Private Sub InitializeDatabinding()
        'bind heading
        LabelChangePasswordHeading.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.Heading)))
        'bind current password text box
        ExtendedTextBoxPassword.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.Password)))
        'bind current password text box
        ExtendedTextBoxNewPassword.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.NewPassword), False,
                                              DataSourceUpdateMode.OnPropertyChanged))
        'bind confirm new password text box
        ExtendedTextBoxConfirmNewPassword.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.ConfirmNewPassword), False,
                                              DataSourceUpdateMode.OnPropertyChanged))
        'bind label passwords mismatch
        LabelPasswordMismatch.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.IsLabelPasswordMisMatchVisible)))
        'bind button change password
        ButtonChangePassword.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsButtonChangePasswordEnabled)))
    End Sub

    Public Enum RegexValidation
        Alphabet
        Numeric
        SpecialCharacters
    End Enum
End Class