Public Class CreditManagementView
    Private WithEvents _viewModel As CreditManagementViewModel

#Region "Events"
    Public Event CreditRowSelected As EventHandler(Of Integer)
#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'assign the viewModel
        Me._viewModel = New CreditManagementViewModel()
        IntializeBinding()

        'Subscribe for events
        AddHandler DataGridViewCustomerCredits.CellEnter, AddressOf OnCellFocused
        AddHandler DataGridViewSecurity.CellEnter, AddressOf OnCellFocused
        AddHandler DataGridViewCustomerCredits.RowEnter, AddressOf OnRowFocused
        AddHandler CreditRowSelected, AddressOf _viewModel.OnCreditRowSelected
    End Sub

    ''' <summary>
    ''' Identifies the data rpw corresponding to the selected row.
    ''' Call viewModel to display the security management data on the relavent grid and/or list view
    ''' </summary>
    Private Sub OnRowFocused(sender As Object, e As DataGridViewCellEventArgs)
        'get the underlying datarow's credit management ID
        'get the sender grid...
        Dim grid As DataGridView = sender
        Dim creditId = grid(0, e.RowIndex).Value
        'Raise event to notify viewmodel to display security data on relaventGrid and selected data in credit listView
        RaiseEvent CreditRowSelected(Me, creditId)
    End Sub

    ''' <summary>
    ''' When datagridviews' cell is clicked, clears selection and selects the corresponding row
    ''' </summary>
    Private Sub OnCellFocused(sender As Object, e As DataGridViewCellEventArgs)
        'get the sender grid...
        Dim grid As DataGridView = sender
        'Clear selection grid wide...
        grid.ClearSelection()
        'select the row corresponding to the cell selected.
        grid.Rows(e.RowIndex).Selected = True

    End Sub

    Private Sub IntializeBinding()
        'Bind customer credits
        DataGridViewCustomerCredits.DataSource = _viewModel.CustomerCredits
        'Bind selected credits display
        LabledListBoxCreditDetails.DataSource = _viewModel.SelectedCreditsDisplayList
        'Bind security details for selected credit
        DataGridViewSecurity.DataSource = _viewModel.SecuritiesForSelectedCredit
    End Sub

End Class