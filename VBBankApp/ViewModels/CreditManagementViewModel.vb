Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class CreditManagementViewModel
    Inherits ViewModelBase
#Region "Private Properties"
    Private _selectedTitle As String

#End Region

#Region "Default Constructor"
    Public Sub New()
        'Initialize lists
        TitleList = New List(Of String)
    End Sub
#End Region

#Region "Public Properties"
    Public Property TitleList() As List(Of String)
    Public Property SelectedTitle() As String
        Get
            Return _selectedTitle
        End Get
        Set(ByVal value As String)
            If _selectedTitle = value Then
                Return
            End If
            _selectedTitle = value
            OnPropertyChanged()
        End Set
    End Property
#End Region


End Class
