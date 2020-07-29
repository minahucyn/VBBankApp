Imports System.ComponentModel

Public Class CreditManagementView
    Private WithEvents _viewModel As CreditManagementViewModel
    Private _selectedIndex As Integer = -1

#Region "Events"
    Public Event CreditRowSelected As EventHandler(Of Integer)
    Public Event CreditSecurityRowSelected As EventHandler(Of Integer)

#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'assign the viewModel
        Me._viewModel = New CreditManagementViewModel()
        IntializeBinding()

        'Subscribe for events

        AddHandler DataGridViewCustomerCredits.RowEnter, AddressOf OnRowFocused
        AddHandler DataGridViewCustomerCredits.RowsAdded, AddressOf OnRowsAdded
        AddHandler CreditRowSelected, AddressOf _viewModel.OnCreditRowSelected
        AddHandler CreditSecurityRowSelected, AddressOf _viewModel.OnCreditSecurityRowSelected
        AddHandler AddCreditsToolStripMenuItem.Click, AddressOf EnableCreditAddMode
        AddHandler ButtonCancelCredit.Click, AddressOf CancelAddingNewCredit
        AddHandler ComboBoxCustomerSearch.KeyUp, AddressOf OnKeyUpForSearch
    End Sub

    Private Sub CancelAddingNewCredit(sender As Object, e As EventArgs)
        'clear all 3 items in the credits entry
        _viewModel.SelectedNewCredit = ""
        _viewModel.NewCreditPrincipleAmount = 0
        _viewModel.NewCreditInterestAmount = 0

        'hide the form and show the grid
        Dim addLocation = GroupBoxCreditDetailsAdd.Location
        Dim displayCreditLocation = GroupBoxCreditDisplay.Location

        GroupBoxCreditDisplay.Location = addLocation
        GroupBoxCreditDetailsAdd.Location = displayCreditLocation
    End Sub

    Private Sub EnableCreditAddMode(sender As Object, e As EventArgs)
        Dim addLocation = GroupBoxCreditDetailsAdd.Location
        Dim displayCreditLocation = GroupBoxCreditDisplay.Location

        GroupBoxCreditDisplay.Location = addLocation
        GroupBoxCreditDetailsAdd.Location = displayCreditLocation
    End Sub

    Private Sub OnRowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        Dim grid As DataGridView = sender
        grid.ClearSelection()
    End Sub

    Private Sub OnKeyUpForSearch(sender As Object, e As KeyEventArgs)
        If ComboBoxCustomerSearch.Text.Contains("|") Then
            _viewModel.SearchTerm = ComboBoxCustomerSearch.Text.Split(ChrW(124))(0)
        Else
            _viewModel.SearchTerm = ComboBoxCustomerSearch.Text.Trim()
        End If
        If e.KeyCode = Keys.Enter Then
            _viewModel.SearchByNidPp()
        End If
    End Sub


    ''' <summary>
    ''' Identifies the data rpw corresponding to the selected row.
    ''' Call viewModel to display the security and payment management data on the relavent grid
    ''' </summary>
    Private Sub OnRowFocused(sender As Object, e As DataGridViewCellEventArgs)
        'bypass multiple invokes with same row index
        ' If _selectedIndex = -1 Then Return
        If _selectedIndex = e.RowIndex Then Return
        _selectedIndex = e.RowIndex

        'get the underlying datarow's credit management ID
        'get the sender grid...
        Dim grid As DataGridView = sender
        Dim creditId = grid(0, e.RowIndex).Value
        'Raise event to notify viewmodel to display security data on relaventGrid
        RaiseEvent CreditRowSelected(Me, creditId)
    End Sub


    Private Sub IntializeBinding()
        'Bind combobox datasource
        ComboBoxCustomerSearch.DataSource = _viewModel.CustomerSearchComboDatasource

#Region "Grids"

        'Bind customer credits
        DataGridViewCustomerCredits.DataSource = _viewModel.CustomerCredits
        'Bind security details for selected credit
        DataGridViewSecurity.DataSource = _viewModel.SecuritiesForSelectedCredit
        'Bind credit specific repayments grid
        DataGridViewRepayments.DataSource = _viewModel.RepaymentsForSelectedCredit

#End Region

#Region "Customer Properties"
        'bind national Id/PP
        Me.TextBoxNidPp.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.NidPp)))
        'Bind customer name
        Me.TextBoxCustomerName.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.Fullname)))
        'Bind gender
        Me.TextBoxGender.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.Gender)))
        'bind birthdate
        Me.DateTimePickerBirthdate.DataBindings.Add(New Binding("Value", _viewModel, NameOf(_viewModel.Birthdate),
                                                                True, DataSourceUpdateMode.OnValidation))
        'username
        Me.ExtendedTextBoxUsername.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.Username)))
        'phone number
        Me.TextBoxPhoneNumber.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.PhoneNumber)))

#End Region

#Region "Add new credit Bindings"
        'comboxBOx
        ComboBoxCredits.DataSource = _viewModel.AllCreditConfig
        ComboBoxCredits.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.SelectedNewCredit)))
        'principle amount
        TextBoxPrincipleAmount.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.NewCreditPrincipleAmount)))
        'interestAmount
        TextBoxInterestAmount.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.NewCreditInterestAmount)))

#End Region
    End Sub

End Class