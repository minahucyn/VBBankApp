Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text

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
    Private _selectedCreditId As Integer
    Private _selectedCreditIdForSecuritiesSearch As Integer

#End Region

#Region "Events"

#End Region

#Region "Default Constructor"
    Public Sub New()
        'Initialize lists
        CustomerCredits = New BindingList(Of CreditModel)
        AllRepaymentsForCustomer = New BindingList(Of RepaymentModel)
        AllCreditSecuritiesForCustomer = New List(Of SecurityModel)
        SecuritiesForSelectedCredit = New BindingList(Of SecurityModel)
        RepaymentsForSelectedCredit = New BindingList(Of RepaymentModel)
        InitializeDemoData()

        'Initialize internal variables
        _selectedCreditId = -1
        _selectedCreditIdForSecuritiesSearch = -1

    End Sub

#End Region

#Region "Public Properties"
    Public Property CustomerCredits() As BindingList(Of CreditModel)
    Private Property AllCreditSecuritiesForCustomer As List(Of SecurityModel)
    Public Property SecuritiesForSelectedCredit As BindingList(Of SecurityModel)
    Public Property AllRepaymentsForCustomer As BindingList(Of RepaymentModel)
    Public Property RepaymentsForSelectedCredit As BindingList(Of RepaymentModel)

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

#Region "Private Methods"
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

        'create securities for credits
        Dim credit1Security1 As SecurityModel = New SecurityModel() With {
            .Id = 1,
            .CreditId = 1,
            .Description = "House",
            .Worth = 100000}
        Dim credit1Security2 As SecurityModel = New SecurityModel() With {
            .Id = 2,
            .CreditId = 1,
            .Description = "Fishing boat, 50 feet",
            .Worth = 200000}
        Dim credit2Security1 As SecurityModel = New SecurityModel() With {
            .Id = 3,
            .CreditId = 2,
            .Description = "House, 3 Storey",
            .Worth = 250000}

        'add to all securities for customer
        AllCreditSecuritiesForCustomer.Add(credit1Security1)
        AllCreditSecuritiesForCustomer.Add(credit1Security2)
        AllCreditSecuritiesForCustomer.Add(credit2Security1)

        'create repayments
        Dim repayments1 As RepaymentModel = New RepaymentModel() With {
            .Id = 1,
            .CreditsId = 1,
            .Principle = 1000.0,
            .Interest = 500.0,
            .TimeStamp = New DateTime(2019, 4, 1)}
        Dim repayments2 As RepaymentModel = New RepaymentModel() With {
            .Id = 2,
            .CreditsId = 1,
            .Principle = 1000.0,
            .Interest = 500.0,
            .TimeStamp = New DateTime(2019, 5, 11)}
        Dim repayments3 As RepaymentModel = New RepaymentModel() With {
            .Id = 3,
            .CreditsId = 1,
            .Principle = 1000.0,
            .Interest = 500.0,
            .TimeStamp = New DateTime(2019, 6, 10)}
        Dim repayments4 As RepaymentModel = New RepaymentModel() With {
            .Id = 4,
            .CreditsId = 1,
            .Principle = 1000.0,
            .Interest = 500.0,
            .TimeStamp = New DateTime(2019, 7, 10)}

        'Add the repayment instances to the binding list
        AllRepaymentsForCustomer.Add(repayments1)
        AllRepaymentsForCustomer.Add(repayments2)
        AllRepaymentsForCustomer.Add(repayments3)
        AllRepaymentsForCustomer.Add(repayments4)
    End Sub

    Private Sub PopulateCreditSpecificSecurities(creditId As Integer)
        'if the current credit is already the Id for which secutities are displayed...
        If creditId = _selectedCreditIdForSecuritiesSearch Then
            'ignore
            Return
        End If
        _selectedCreditIdForSecuritiesSearch = creditId

        'Clear the current displayed list.
        SecuritiesForSelectedCredit.Clear()

        'Search for customer credit securities for specified creditid
        Dim selectedSecurities = AllCreditSecuritiesForCustomer.Where(Function(x)
                                                                          Return x.CreditId = creditId
                                                                      End Function).ToList()
        'Display securities for current selected credit
        For Each securityModel In selectedSecurities
            SecuritiesForSelectedCredit.Add(securityModel)
        Next
    End Sub

    ''' <summary>
    ''' populates repayments data corresponding to the creditId to binding list 
    ''' </summary>
    Private Sub PopulateCreditRepayments(creditId As Integer)
        'clear the binding list RepaymentsForSelectedCredit
        RepaymentsForSelectedCredit.Clear()

        'Search all repayments for customer by credits Id
        Dim creditSpecificRepayments = AllRepaymentsForCustomer.Where(Function(x)
                                                                          Return x.CreditsId = creditId
                                                                      End Function).ToList()
        'if no repayments for the selected credit...
        If creditSpecificRepayments Is Nothing Then
            Return
        End If

        'add credit specific repayments to binding list
        For Each repayment In creditSpecificRepayments
            RepaymentsForSelectedCredit.Add(repayment)
        Next
    End Sub

    '''' <summary>
    '''' Adds spaces to pascal case.
    '''' Source: 
    '''' </summary>
    '''' <param name="text">The text to insert spaces</param>
    '''' <param name="preserveAcronyms">true if no spaces are to be inserted into Acronyms</param>
    '''' <returns>The text passed in with spaces inserted</returns>
    'Private Function AddSpacesToSentence(ByVal text As String, ByVal preserveAcronyms As Boolean) As String
    '    'null check, if so... return null string 
    '    If String.IsNullOrWhiteSpace(text) Then Return String.Empty
    '    'instantiate string builder
    '    Dim newText As StringBuilder = New StringBuilder(text.Length * 2)
    '    newText.Append(text(0))

    '    For i As Integer = 1 To text.Length - 1

    '        If Char.IsUpper(text(i)) Then
    '            If (text(i - 1) <> " "c AndAlso Not Char.IsUpper(text(i - 1))) OrElse
    '                (preserveAcronyms AndAlso Char.IsUpper(text(i - 1)) AndAlso
    '                i < text.Length - 1 AndAlso Not Char.IsUpper(text(i + 1))) Then
    '                newText.Append(" "c)
    '            End If
    '        End If

    '        newText.Append(text(i))
    '    Next

    '    Return newText.ToString()
    'End Function
#End Region

#Region "Public Methods"
    Public Sub OnCreditRowSelected(sender As Object, e As Integer)
        'If the selected credit id is already selected...
        If _selectedCreditId = e Then
            'Ignore
            Return
        End If
        _selectedCreditId = e
        'load security details for selected credit item
        PopulateCreditSpecificSecurities(e)
        'load repayment details for selected credit
        PopulateCreditRepayments(e)
    End Sub

    Public Sub OnCreditSecurityRowSelected(sender As Object, creditSecurityId As Integer)
        Debug.WriteLine(creditSecurityId)
    End Sub
#End Region

End Class
