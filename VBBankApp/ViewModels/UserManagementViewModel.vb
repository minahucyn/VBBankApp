Imports System.ComponentModel

Public Class UserManagementViewModel
    Inherits ViewModelBase

#Region "Private properties"
    Private _selectedNidPp As String
    Private _selectedUsername As String
    Private _selectedFullname As String
    Private _selectedPhoneNumber As String
    Private _selectedRole As String
    Private _selectedBirthdate As Date?
    Private _selectedGender As String
    Private _selectedIsActive As Boolean
    Private _selectedIsUnlocked As Boolean
#End Region

#Region "Default Constructor"
    Public Sub New()
        AllUsers = New BindingList(Of UserManagementModel)
    End Sub
#End Region

#Region "Public Properties"
    Public Property AllUsers As BindingList(Of UserManagementModel)
    Public Property SelectedNidPp() As String
        Get
            Return _selectedNidPp
        End Get
        Set(ByVal value As String)
            If value = _selectedNidPp Then Return
            _selectedNidPp = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedUsername() As String
        Get
            Return _selectedUsername
        End Get
        Set(ByVal value As String)
            If value = _selectedUsername Then Return
            _selectedUsername = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property SelectedFullname() As String
        Get
            Return _selectedFullname
        End Get
        Set(ByVal value As String)
            If value = _selectedFullname Then Return
            _selectedFullname = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedPhoneNumber() As String
        Get
            Return _selectedPhoneNumber
        End Get
        Set(ByVal value As String)
            If value = _selectedPhoneNumber Then Return
            _selectedPhoneNumber = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedRole() As String
        Get
            Return _selectedRole
        End Get
        Set(ByVal value As String)
            If value = _selectedRole Then Return
            _selectedRole = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedBirthdate() As Date?
        Get
            Return _selectedBirthdate
        End Get
        Set(ByVal value As Date?)
            If value = _selectedBirthdate Then Return
            _selectedBirthdate = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedGender() As String
        Get
            Return _selectedGender
        End Get
        Set(ByVal value As String)
            If value = _selectedGender Then Return
            _selectedGender = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedIsAcive() As Boolean
        Get
            Return _selectedIsActive
        End Get
        Set(ByVal value As Boolean)
            If value = _selectedIsActive Then Return
            _selectedIsActive = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedIsUnlocked() As Boolean
        Get
            Return _selectedIsUnlocked
        End Get
        Set(ByVal value As Boolean)
            If value = _selectedIsUnlocked Then Return
            _selectedIsUnlocked = value
            OnPropertyChanged()
        End Set
    End Property
#End Region

End Class
