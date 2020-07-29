Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports VBBankApp

Public Class CreditManagementViewModel
    Inherits ViewModelBase

#Region "Private Properties"
    Private _userDataAccess As UserDataAccess = New UserDataAccess
    Private _creditDetailsDataAccess As CreditDataAccess = New CreditDataAccess
    Private _selectedTitle As String
    Private _nidPp As String
    Private _fullname As String
    Private _birthdate As Date?
    Private _Username As String
    Private _gender As String
    Private _phoneNumber As String
    Private _selectedCreditId As Integer
    Private _searchTerm As String
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
        'InitializeDemoData()

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

    Public Property SearchTerm() As String
        Get
            Return _searchTerm
        End Get
        Set(ByVal value As String)
            _searchTerm = value
            OnPropertyChanged()
        End Set
    End Property
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
    Public Property Birthdate() As Date?
        Get
            Return _birthdate
        End Get
        Set(ByVal value As Date?)
            'if new value is equal to stored value...
            If value = _birthdate Then
                'ingore
                Return
            End If
            _birthdate = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(ByVal value As String)
            'if new value is equal to stored value...
            If value = _Username Then
                'ingore
                Return
            End If
            _Username = value
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
            .PrincipleAmount = 100000.0,
            .InterestAmount = 500.0,
            .LastUpdated = New DateTime(2020, 5, 25),
            .TimeStamp = New DateTime(2020, 5, 24)
        }
        Dim credit2 = New CreditModel() With {
            .Id = 2,
            .Description = "Not So Lui Loan",
            .PrincipleAmount = 100000000.0,
            .InterestAmount = 50000.0,
            .LastUpdated = New DateTime(2019, 12, 25),
            .TimeStamp = New DateTime(2019, 12, 24)
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

    ''' <summary>
    ''' Calls the datalayer with national Id or passport for searching
    ''' </summary>
    Friend Sub SearchByNidPp()
        Try
            'if there is nothing to search with...
            If String.IsNullOrEmpty(SearchTerm) Then
                'ignore
                Return
            End If
            'search with search term
            Dim results = _userDataAccess.SearchUserByNidPp(SearchTerm)
            'if no results
            If results Is Nothing Then
                MsgBox($"No search result found for: {SearchTerm}")
                Return
            End If
            'otherwise, display on UI
            DisplaSearchResultOnUI(results)
            'Initialize search for credits for loaded customer
            Dim creditDetails = _creditDetailsDataAccess.ReadAllCustomerCredits(results.UsersId)
            'Add credit details to datasource
            AddCustomerCreditDetailsUiDatasource(creditDetails)
            'Initialize search for credit securities for loaded credits
            'Initialize search for credit payments for loaded credits

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SearchTerm = ""
    End Sub

    ''' <summary>
    ''' Add credit details from database to CustomerCredits() binding list
    ''' </summary>
    ''' <param name="creditDetails">customer credits list from database</param>
    Private Sub AddCustomerCreditDetailsUiDatasource(creditDetails As List(Of CreditModel))
        'clear the binding list
        CustomerCredits.Clear()
        'check for parameter nulls
        If creditDetails Is Nothing Then
            MsgBox("Cannot find any credit details for selected customer.")
            Return
        End If
        'add the credit details to binding list
        For Each credit In creditDetails
            CustomerCredits.Add(credit)
        Next
    End Sub

    ''' <summary>
    ''' Displays the search results on the UI by assiging them to the databound properties
    ''' </summary>
    ''' <param name="results">The search result model</param>
    Private Sub DisplaSearchResultOnUI(results As CustomerSearchDatabaseModel)
        Me.NidPp = results.NidPp
        Me.Fullname = results.Fullname
        Me.Gender = results.Gender
        Me.Birthdate = results.Birthdate
        Me.Username = results.Username
        Me.PhoneNumber = results.PhoneNumber
    End Sub

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
