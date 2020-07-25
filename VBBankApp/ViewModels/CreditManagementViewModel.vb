Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class CreditManagementViewModel
    Inherits ViewModelBase
#Region "Private Properties"
    Private _selectedTitle As String
    Private _nidPp As String
    Private _fullname As String
    Private _birthdate As Date
    Private _age As Integer
    Private _gender As String
    Private _phoneNumber As String

#End Region

#Region "Default Constructor"
    Public Sub New()
        'Initialize lists
        CustomerCredits = New BindingList(Of CreditModel)
        InitializeDemoData()
    End Sub

    Private Sub InitializeDemoData()
        'create demo credits
        Dim credit1 = New CreditModel() With {
            .Id = 1,
            .Description = "Lui Loan",
            .CreditAmount = 100000.0,
            .Outstanding = 100000.0,
            .InterestOutstanding = 187878.0,
            .PrincipleOutstanding = 100000.0,
            .PrincipleDue = 1000.0,
            .InterestDue = 500.0,
            .TotalDue = 1500.0
        }
        Dim credit2 = New CreditModel() With {
            .Id = 2,
            .Description = "Not So Lui Loan",
            .CreditAmount = 100000000.0,
            .Outstanding = 100000000.0,
            .InterestOutstanding = 18787834656.0,
            .PrincipleOutstanding = 100000000.0,
            .PrincipleDue = 1000.0,
            .InterestDue = 500.0,
            .TotalDue = 1500.0
        }
        'add the demo credits to the datasource for UI, Binding List
        CustomerCredits.Add(credit1)
        CustomerCredits.Add(credit2)
    End Sub
#End Region

#Region "Public Properties"
    Public Property CustomerCredits() As BindingList(Of CreditModel)
    Public Property NidPp() As String
        Get
            Return _nidPp
        End Get
        Set(ByVal value As String)
            'if new value is equal to stored value...
            If value = _nidPp Then
                'ingore
                Return
            End If
            _nidPp = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property Fullname() As String
        Get
            Return _fullname
        End Get
        Set(ByVal value As String)
            'if new value is equal to stored value...
            If value = _fullname Then
                'ingore
                Return
            End If
            _fullname = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property Birthdate() As Date
        Get
            Return _birthdate
        End Get
        Set(ByVal value As Date)
            'if new value is equal to stored value...
            If value = _birthdate Then
                'ingore
                Return
            End If
            _birthdate = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            'if new value is equal to stored value...
            If value = _age Then
                'ingore
                Return
            End If
            _age = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return _gender
        End Get
        Set(ByVal value As String)
            'if new value is equal to stored value...
            If value = _gender Then
                'ingore
                Return
            End If
            _gender = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property PhoneNumber() As String
        Get
            Return _phoneNumber
        End Get
        Set(ByVal value As String)
            'if new value is equal to stored value...
            If value = _phoneNumber Then
                'ingore
                Return
            End If
            _phoneNumber = value
            OnPropertyChanged()
        End Set
    End Property

#End Region


End Class
