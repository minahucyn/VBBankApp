Public Class MainViewModel
    Inherits ViewModelBase
    Private _fullname As String
    Private _username As String
    Private _userRole As String

    Public Property Fullname() As String
        Get
            Return _fullname
        End Get
        Set(ByVal value As String)
            If _fullname = value Then
                Return
            End If
            _fullname = value
            SetDisplayUsernameFullname()
        End Set
    End Property

    ''' <summary>
    ''' Sets the display username and fullname by using username and fullname
    ''' </summary>
    Private Sub SetDisplayUsernameFullname()
        DisplayUsernameFullname = $"{Fullname} [ {Username} ]"
    End Sub

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            If _username = value Then
                Return
            End If
            _username = value
            SetDisplayUsernameFullname()
        End Set
    End Property
    Public Property UserRole() As String
        Get
            If String.IsNullOrEmpty(_userRole) Then
                Return String.Empty
            End If
            Return $"User Role: {_userRole}"
        End Get
        Set(ByVal value As String)
            If _userRole = value Then
                Return
            End If
            _userRole = value
            OnPropertyChanged()
        End Set
    End Property

    Private _displayUsernameFullname As String
    Public Property DisplayUsernameFullname() As String
        Get
            Return _displayUsernameFullname
        End Get
        Set(ByVal value As String)
            _displayUsernameFullname = value
            OnPropertyChanged()
        End Set
    End Property


End Class
