Imports System.ComponentModel

Public Class AuthenticationViewModel
    Inherits ViewModelBase

#Region "Private Properties"
    Private _password As String
    Private _username As String
    Private _passwordHash As String
    Private _isLockedAlertVisible As Boolean
    Private _isOKButtonEnabled As Boolean
#End Region

#Region "Events"
    Public Event PasswordVerified(authDetails As AuthDetailsModel)
#End Region

#Region "Default Constructor"

    Public Sub New()
        IsLockedAlertVisible = False
        IsOKButtonEnabled = False
        'Listen for property changed events
        AddHandler Me.PropertyChanged, AddressOf ActingOnPropertyChanges
        'AddHandler Me.PasswordVerified, AddressOf OnPasswordVerified
    End Sub

#End Region

#Region "Public Properties"
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
    Public Property IsLockedAlertVisible() As Boolean
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
        'fetch the password hash from database for the username
        Dim authDetails = GetAuthDetails()
        'Check whether the user is locked....
        If authDetails.IsLocked Then
            'Show the notification....
            IsLockedAlertVisible = True
            'abort authentication
            Return
        End If
        'compare with hash of user provided password
        Dim IsVerified As Boolean = Hashing.VerifyPassword(_password, authDetails.GoodHash)

        'Checking if the password matched
        If IsVerified Then
            ' Completed password verification..., 
            RaiseEvent PasswordVerified(authDetails)
            Debug.WriteLine("User authenticated")
        Else
            'Notify user that the credetials did not match.
            MsgBox("Authentication failed! Username and Password did not match!")
            'Increment Retry count

        End If

    End Sub
#End Region

#Region "Private Methods"

    'Private Sub OnPasswordVerified(authDetails As AuthDetailsModel)
    '    MsgBox("Password verified!" & vbCrLf & $"Username: {authDetails.Username}, Role: {authDetails.UserRole}, name: {authDetails.Fullname}")
    'End Sub

    ''' <summary>
    ''' Gets the good Hash from the database for the specified username.
    ''' </summary>
    ''' <returns> returns good hash model with hash and islocked property </returns>
    Private Function GetAuthDetails() As AuthDetailsModel
        'Simulate calling database
        Return New AuthDetailsModel() With {
            .Fullname = "Mina Hucyn",
            .UserClaims = New ClaimsModel(),
            .Username = "minahucyn",
            .UserRole = "Normal",
            .GoodHash = "SHA512:88:rvb0bbHRIxdO9DoZvhrv2NWC/tssaikt0Q==:4cq/04d1pjFir7COwEBrfe02z3u6xrYkyhI/a80X/5QEBZRo9ooEUONk0FhAIWTvSDjVrIZOxF3Oz9tgkn2p8w==",
            .IsLocked = False,
            .MenuJson = "[{'Id':1,'Name':'Username','ParentId':0},{'Id':5,'Name':'Settings','ParentId':0},{'Id':2,'Name':'Log Out','ParentId':1},{'Id':3,'Name':'Change Password','ParentId':1},{'Id':4,'Name':'Exit','ParentId':1}]"}
    End Function

    Private Sub IncrementRetryCount()

    End Sub

    Private Sub ActingOnPropertyChanges(sender As Object, e As PropertyChangedEventArgs)
        'Look for username changes
        If e.PropertyName = NameOf(Username) Then
            'if the IsLockedAlert is visible...
            If IsLockedAlertVisible Then
                'hide it
                IsLockedAlertVisible = False
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
