Imports System.ComponentModel

Public Class AuthenticationViewModel
    Inherits ViewModelBase

#Region "Private Properties"
    Private _password As String
    Private _username As String
    Private _passwordHash As String
    Private _isLockedAlertVisible As Boolean
    Private _isOKButtonEnabled As Boolean
    Private _authDataAccess As AuthDataAccess = New AuthDataAccess
    Private _AlertText As String
#End Region

#Region "Events"
    Public Event PasswordVerified(authDetails As AuthDetailsModel)
#End Region

#Region "Default Constructor"

    Public Sub New()
        IsLockedInactiveAlertVisible = False
        IsOKButtonEnabled = False
        'Listen for property changed events
        AddHandler Me.PropertyChanged, AddressOf LogicOnPropertyChange
        'AddHandler Me.PasswordVerified, AddressOf OnPasswordVerified

#If DEBUG Then
        Username = "minahucyn"
        Password = "Bismillah.123!"
#End If
    End Sub

#End Region

#Region "Public Properties"

    Public Property AlertText As String 'The alert text for user locked and/or inactive
        Get
            Return _AlertText
        End Get
        Set
            _AlertText = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            'if the existing username is same as new username...
            If _username = value Then
                'no need to set it again
                Return
            End If
            'store new username
            _username = value
            'notify that username has changed
            OnPropertyChanged()
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            'if the existing password is same as new password...
            If _password = value Then
                Return
            End If
            'store the password
            _password = value
            'notify password changed.
            OnPropertyChanged()
        End Set
    End Property
    Public Property IsLockedInactiveAlertVisible() As Boolean
        Get
            Return _isLockedAlertVisible
        End Get
        Set(ByVal value As Boolean)
            If _isLockedAlertVisible = value Then
                Return
            End If
            _isLockedAlertVisible = value
            'Notify the UI of the change
            OnPropertyChanged()
        End Set
    End Property

    Public Property IsOKButtonEnabled() As Boolean
        Get
            Return _isOKButtonEnabled
        End Get
        Set(ByVal value As Boolean)
            _isOKButtonEnabled = value
            OnPropertyChanged()
        End Set
    End Property

#End Region

#Region "Public Methods"
    Public Sub VerifyPassword()
        Try
            'fetch the password hash from database for the username
            Dim authDetails = GetAuthDetails()
            'handle null auth details
            If authDetails Is Nothing Then
                MsgBox("Could not find a match for the username and/or password. Please try again!")
                Return
            End If
            'check whether the user is active
            If Not authDetails.IsActive Then
                DisplayDeactivatedAlert()
                Return
            End If
            'Check whether the user is locked....
            If authDetails.IsLocked Then
                DisplayAccountlockedAlert()
                'abort authentication
                Return
            End If
            'compare with hash of user provided password
            Dim IsVerified As Boolean = Hashing.VerifyPassword(_password, authDetails.GoodHash)

            'Checking if the password matched
            If IsVerified And authDetails.Username = Username Then
                'resetRetryCount
                ResetRetryCount(authDetails.Username)

                ' Completed password verification..., 
                RaiseEvent PasswordVerified(authDetails)
                Debug.WriteLine("User authenticated")
            Else
                'Notify user that the credetials did not match.
                MsgBox("Authentication failed! Username and Password did not match!")
                'Increment Retry count
                IncrementRetryCount(authDetails.Username)
                CheckUserStatus(authDetails.Username)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


#End Region

#Region "Private Methods"
    Public Sub CheckUserStatus(username As String)
        Try
            Dim userStatus = _authDataAccess.ReadUserStatus(username)
            'handle locked status
            If userStatus.IsLockedOut Then
                DisplayAccountlockedAlert()
            End If
            'handle active status
            If Not userStatus.IsActive Then
                DisplayAccountlockedAlert()
            End If
            '
        Catch ex As Exception
            MsgBox("Cannot check user IsActive and / or locked status" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub DisplayAccountlockedAlert()
        'Show the notification....
        IsLockedInactiveAlertVisible = True
        AlertText = "THE USER IS LOCKED!" & vbCrLf & " PLEASE CONTACT YOUR ADMIN."
    End Sub
    Private Sub DisplayDeactivatedAlert()
        IsLockedInactiveAlertVisible = True
        AlertText = "THE USER DEACTIVATED!" & vbCrLf & " PLEASE CONTACT YOUR ADMIN."
    End Sub
    Public Sub IncrementRetryCount(username As String)
        Try
            _authDataAccess.IncrementRetryCount(username)
        Catch ex As Exception
            'ignore. No point in showing this error
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' resets retry count for the specified username to zero
    ''' </summary>
    ''' <param name="username">The username for which to reset the retry count</param>
    Public Sub ResetRetryCount(username As String)
        Try
            _authDataAccess.ResetRetryCount(username)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Gets the good Hash from the database for the specified username.
    ''' </summary>
    ''' <returns> returns good hash model with hash and islocked property </returns>
    Private Function GetAuthDetails() As AuthDetailsModel
        'read auth details from database
        Try
            Dim authDetails = _authDataAccess.ReadAuthData(Me.Username)
            If authDetails Is Nothing Then Throw New Exception($"Cannot find the specified username: {Me.Username} on the database. Please make sure that the username is correct.")
            Return New AuthDetailsModel() With {
                .Fullname = authDetails.Fullname,
                .UserClaims = ClaimsModel.GetClaimsModel(authDetails.RoleClaimsCSV),
                .Username = authDetails.Username,
                .UserRole = authDetails.UserRole,
                .GoodHash = authDetails.GoodHash,
                .IsLocked = authDetails.IsLocked,
                .IsActive = authDetails.IsActive,
                .MenuJson = authDetails.MenuJson}
        Catch ex As Exception
            Throw
        End Try


    End Function

    Private Sub IncrementRetryCount()

    End Sub

    Private Sub LogicOnPropertyChange(sender As Object, e As PropertyChangedEventArgs)
        'Look for username changes
        If e.PropertyName = NameOf(Username) Then
            'if the IsLockedAlert is visible...
            If IsLockedInactiveAlertVisible Then
                'hide it
                IsLockedInactiveAlertVisible = False
            End If
        End If

        'If username or password changes...
        If e.PropertyName = NameOf(Username) Or e.PropertyName = NameOf(Password) Then
            'Check if OKButton Can be enabled.
            If Not (String.IsNullOrEmpty(Username) Or String.IsNullOrEmpty(Password)) Then
                'enable the OK button
                IsOKButtonEnabled = True
            Else
                'disable the OK button
                IsOKButtonEnabled = False
            End If
        End If

    End Sub
#End Region

End Class
