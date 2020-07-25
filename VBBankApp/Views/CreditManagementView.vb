﻿Public Class CreditManagementView
    Private ReadOnly _viewModel As CreditManagementViewModel

    Public Sub New(viewModel As CreditManagementViewModel)

        ' This call is required by the designer.
        InitializeComponent()
        'assign the viewModel
        Me._viewModel = viewModel
        IntializeBinding()

        'Subscribe for events
        AddHandler DataGridViewCustomerCredits.CellEnter, AddressOf OnCellFocused
        AddHandler DataGridViewCustomerCredits.RowEnter, AddressOf OnRowFocused
    End Sub

    ''' <summary>
    ''' Identifies the data rpw corresponding to the selected row.
    ''' Call viewModel to display the security management data on the relavent grid and/or list view
    ''' </summary>
    Private Sub OnRowFocused(sender As Object, e As DataGridViewCellEventArgs)
        'get the underlying datarow for the selected row
        'Call view model to filter security data and diaplay selected data in credit listView
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
    End Sub

End Class