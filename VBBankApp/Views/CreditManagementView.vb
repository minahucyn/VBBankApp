Public Class CreditManagementView
    Private ReadOnly _viewModel As CreditManagementViewModel

    Public Sub New(viewModel As CreditManagementViewModel)

        ' This call is required by the designer.
        InitializeComponent()
        'assign the viewModel
        Me._viewModel = viewModel
        IntializeBinding()
    End Sub

    Private Sub IntializeBinding()
        'Bind customer credits
        DataGridViewCustomerCredits.DataSource = _viewModel.CustomerCredits
    End Sub

End Class