Imports System.ComponentModel
Imports VBBankApp

Public Class AuthenticationView
    Private ReadOnly _viewModel As AuthenticationViewModel
    Public Event AuthenticationSuccessful(authDetails As AuthDetailsModel)

    Private _isAuthSuccessful As Boolean

    Public Sub New(viewModel As AuthenticationViewModel)

        InitializeComponent()
        Me.CenterToParent()
        _isAuthSuccessful = False
        'assign the view model to the field
        Me._viewModel = viewModel

        'Bind The controls to ViewModel.
        InitializeBinding()

        'Subscribe to Events
        AddHandler OK.Click, AddressOf OnOKClicked
        AddHandler Cancel.Click, AddressOf OnCancelClick
        AddHandler _viewModel.PasswordVerified, AddressOf OnUserLoggedIn
        AddHandler Me.FormClosing, AddressOf AuthenticationView_Closing
    End Sub

    Private Sub OnCancelClick(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Async Sub OnUserLoggedIn(authDetails As AuthDetailsModel)
        _isAuthSuccessful = True
        Await InitializeAniamtionAsync()
        RaiseEvent AuthenticationSuccessful(authDetails)
        Me.Close()
    End Sub

    ''' <summary>
    ''' Runs the login successful animation asynchronously
    ''' </summary>
    Private Async Function InitializeAniamtionAsync() As Task
        'move the animation panel to view area
        PanelAnimation.Location = PanelAuth.Location
        PictureBoxAnimation.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxAnimation.Image = My.Resources.loginSuccessful
        Await Task.Delay(2900)
    End Function

    Private Sub OnOKClicked(sender As Object, e As EventArgs)
        'Try to login user
        _viewModel.VerifyPassword()
    End Sub

    Private Sub InitializeBinding()
        'Bind username
        UsernameTextBox.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.Username),
                                                     False, DataSourceUpdateMode.OnPropertyChanged))
        'Bind password
        PasswordTextBox.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.Password),
                                                     False, DataSourceUpdateMode.OnPropertyChanged))
        'Bind islockedalert
        LabelLockedAlert.DataBindings.Add(New Binding("Visible", _viewModel, NameOf(_viewModel.IsLockedAlertVisible)))
        'Bind OKButton
        OK.DataBindings.Add(New Binding("Enabled", _viewModel, NameOf(_viewModel.IsOKButtonEnabled)))

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub AuthenticationView_Closing(sender As Object, e As CancelEventArgs)
        'if form is closing on successful authentiation Don not show msg to confirm app exit.
        If _isAuthSuccessful Then
            Return
        End If
        'ask the user wheather the user wants to close the app.
        Dim userInput = MsgBox("Are you sure you want to exit the application?", MsgBoxStyle.YesNo, "Application Exit!")
        'check user input...
        If userInput = MsgBoxResult.Yes Then
            'if yes exit app.
            Application.Exit()
        Else
            'cancel the closing event.
            e.Cancel = True
        End If
    End Sub

End Class
