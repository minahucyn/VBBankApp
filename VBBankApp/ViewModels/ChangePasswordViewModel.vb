Imports System.ComponentModel
Imports Newtonsoft.Json

Public Class ChangePasswordViewModel
    Inherits ViewModelBase

#Region "Private Properties"
    Private _password As String
    Private _newPassword As String
    Private _confirmNewPassword As String
    Private _buttonChangePasswordEnabled As Boolean
    Private _isNewPasswordMatchConfirmed As Boolean
    Private _isLabelPasswordMisMatchVisible As Boolean
    Private _isPasswordValidated As Boolean


#End Region

#Region "Default Constructor"
    Public Sub New()

        InitializeControlValues()

        'Subscribe for events
        AddHandler Me.PropertyChanged, AddressOf RunLogicOnPropertyChanged

    End Sub

#End Region

#Region "Public Properties"
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            If value = _password Then
                Return
            End If
            _password = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property NewPassword() As String
        Get
            Return _newPassword
        End Get
        Set(ByVal value As String)
            If value = _newPassword Then
                Return
            End If
            _newPassword = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property ConfirmNewPassword() As String
        Get
            Return _confirmNewPassword
        End Get
        Set(ByVal value As String)
            If value = _confirmNewPassword Then
                Return
            End If
            _confirmNewPassword = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property IsButtonChangePasswordEnabled() As Boolean
        Get
            Return _buttonChangePasswordEnabled
        End Get
        Set(ByVal value As Boolean)
            _buttonChangePasswordEnabled = value
        End Set
    End Property
    Public Property Heading As String

    Public Property IsLabelPasswordMisMatchVisible() As Boolean
        Get
            Return _isLabelPasswordMisMatchVisible
        End Get
        Set(ByVal value As Boolean)
            If value = _isLabelPasswordMisMatchVisible Then Return
            _isLabelPasswordMisMatchVisible = value
            OnPropertyChanged()
        End Set
    End Property
#End Region

#Region "Public Methods"
    Public Sub ChangePassword(sender As Object, e As EventArgs)
        'if the entered current password Hash matches with good hash...
        If VerifyCurrentPassword() Then

        End If
    End Sub

    Public Sub SetPasswordValidatedStatus(isValidated As Boolean)
        _isPasswordValidated = isValidated
    End Sub

#End Region

#Region "Private Methods"
    Private Sub InitializeControlValues()
        'Change password button is disabled initially
        IsLabelPasswordMisMatchVisible = False
        _buttonChangePasswordEnabled = False
        'Assign Heading
        Heading = $"Change Password for user {MainView.AuthenticatedUserDetails.Username}"
        'Set null text
        Password = "Current Password"
        NewPassword = "New Password"
        ConfirmNewPassword = "Confirm New Password"
    End Sub
    ''' <summary>
    ''' Runs specified logics when properties changes.
    ''' </summary>
    Private Sub RunLogicOnPropertyChanged(sender As Object, e As PropertyChangedEventArgs)
        'Check whether the passwords match when changed property is  ConfirmNewPassword...
        If e.PropertyName = NameOf(ConfirmNewPassword) Or e.PropertyName = NameOf(NewPassword) Then
            'compare them to check whether they match
            If NewPasswordMatchConfirmed() Then
                _isNewPasswordMatchConfirmed = True
            Else
                _isNewPasswordMatchConfirmed = False
            End If
        End If

        'verify passwords match
        If e.PropertyName = NameOf(ConfirmNewPassword) Or e.PropertyName = NameOf(NewPassword) Then

            If _isNewPasswordMatchConfirmed Then
                IsLabelPasswordMisMatchVisible = False
            Else
                If ConfirmNewPassword <> "Confirm New Password" Then IsLabelPasswordMisMatchVisible = True
            End If

            End If

        'Enable change password button on entering confirm new password
        If e.PropertyName = NameOf(ConfirmNewPassword) Or e.PropertyName = NameOf(NewPassword) Then
            If _isPasswordValidated And _isNewPasswordMatchConfirmed Then
                IsButtonChangePasswordEnabled = True
            Else
                IsButtonChangePasswordEnabled = False
            End If
        End If

        Debug.WriteLine($"Password Confirmed: {_isNewPasswordMatchConfirmed}")
        Debug.WriteLine($"Is Label Password MisMatch Visible: {IsLabelPasswordMisMatchVisible}")
        Debug.WriteLine($"New Password: {NewPassword}")
        Debug.WriteLine($"Confirm Password: {ConfirmNewPassword}")
        Debug.WriteLine("=============================================================================")
    End Sub

    ''' <summary>
    ''' Checks whether the user entered NewPassword and ConfirmNewPassword matches
    ''' </summary>
    ''' <returns>True if matches</returns>
    Private Function NewPasswordMatchConfirmed() As Boolean
        If NewPassword = ConfirmNewPassword Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Verifies whether the current password hash entered matches with 
    ''' the good hash
    ''' </summary>
    ''' <returns>True if matches</returns>
    Private Function VerifyCurrentPassword() As Boolean
        Return Hashing.VerifyPassword(Password, MainView.AuthenticatedUserDetails.GoodHash)
    End Function
#End Region

End Class
