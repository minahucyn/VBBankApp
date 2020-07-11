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
        'Bind Title
        ComboBoxTitle.DataSource = _viewModel.TitleList
    End Sub
End Class