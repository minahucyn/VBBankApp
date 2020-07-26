Imports Newtonsoft.Json
Imports VBBankApp

Public Class MainView
    Private ReadOnly _viewModel As MainViewModel
    Dim WithEvents _authView As AuthenticationView
    Public Shared AuthenticatedUserDetails As AuthDetailsModel = New AuthDetailsModel()
    Public Shared MyLocation As Point = New Point

#Region "Events"
    Public Event InitializeApplicationMenu(appMenu As List(Of MenuModel))
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MyLocation = GetMainViewCenter()

        ' Initialize Authorization.
        InitializeAuthorization()
        _viewModel = New MainViewModel()
        InitializeBinding()

        'Subscribe for events
        AddHandler Me.InitializeApplicationMenu, AddressOf OnInitialzeApplicationMenu
    End Sub

    ''' <summary>
    ''' This event handler will initialize role specific application menu
    ''' </summary>
    ''' <param name="appMenu">a list of MenuModel used to initialize app menu</param>
    Private Sub OnInitialzeApplicationMenu(appMenu As List(Of MenuModel))
        'clear the menu
        MainMenuStrip.Items.Clear()
        If appMenu Is Nothing Then
            Return
        End If

        'determine number of menu levels
        Dim menuLevels As Integer = 0
        While True
            'searching the menu model list for level existance
            Dim levelExists As Boolean = appMenu.Exists(Function(x)
                                                            Return x.ParentId = menuLevels Or x.Id = menuLevels
                                                        End Function)
            'if the menu/submenu item level exists....
            If levelExists Then
                'increament the menu level to search for... in the next iteration
                menuLevels += 1
            Else 'if the current menu level does not exist...
                'forcefully exit while.
                Exit While
            End If

        End While

        Dim iterationVariable As Integer = 0
        For index = 0 To menuLevels
            Dim currentLevelMenu = appMenu.Where(Function(x)
                                                     Return x.ParentId = index
                                                 End Function)

            'add level menu
            For Each item In currentLevelMenu
                'add root level
                If item.ParentId = 0 Then
                    'replace "username" string with the actual username
                    If item.Name.ToLower() = "username" Then
                        item.Name = _viewModel.Username
                    End If
                    MainMenuStrip.Items.Add(item.Name, Nothing, AddressOf TadaCicked).Tag = item.Id
                    Continue For
                End If

                'add other levsls
                For Each menuItem As ToolStripMenuItem In MainMenuStrip.Items
                    If item.ParentId = menuItem.Tag Then
                        menuItem.DropDownItems.Add(item.Name, Nothing, AddressOf TadaCicked).Tag = item.Id
                    End If
                Next

            Next
            iterationVariable += 1
        Next

    End Sub

    Private Sub InitializeBinding()
        'logged in fullname [ username ]
        ToolStripLabelUserNameAndRole.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.DisplayUsernameFullname)))
        'logged in user role
        ToolStripLabelUserRoleDisplay.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.UserRole)))
    End Sub

    Private Sub TadaCicked(sender As Object, e As EventArgs)
        Dim og_boom As ToolStripMenuItem = sender

        Select Case og_boom.Text.ToLower()
            Case ("Exit").ToLower()
                Environment.Exit(0)
            Case ("Log out").ToLower()
                LogoutUser()
            Case ("Credit Management").ToLower()
                ShowCreditManagementView()
                Debug.WriteLine("crm HIT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
            Case ("Change Password").ToLower()
                OpenChangePasswordView()
            Case ("User Management").ToLower()
                OpenUserManagementView()
            Case Else

        End Select

    End Sub

    Public Function GetMainViewCenter() As Point

        Dim x = Location.X + (Width - Me.Width) / 2
        Dim y = Location.Y + (Height - Me.Height) / 2

        Return New Point(Math.Max(x, 0), Math.Max(y, 0))
    End Function

    Private Sub OpenUserManagementView()
        'Initialize user management view
        Dim userManagementView As UserManagementView = New UserManagementView() With {
            .MdiParent = Me,
            .StartPosition = FormStartPosition.CenterScreen}
        If IsViewAuthorized(userManagementView) Then
            userManagementView.StartPosition = FormStartPosition.CenterScreen
            userManagementView.Show()
        End If
    End Sub

    Private Sub OpenChangePasswordView()
        'Initialize change password view
        Dim changePasswordView As ChangePasswordView = New ChangePasswordView With {
            .MdiParent = Me,
            .StartPosition = FormStartPosition.CenterParent}
        'Check if user is authorized to change password.. hehe
        If IsViewAuthorized(changePasswordView) Then
            changePasswordView.StartPosition = FormStartPosition.CenterScreen
            changePasswordView.Show()
        End If
    End Sub

    ''' <summary>
    ''' Closes all open MDI children and opens AuthView
    ''' </summary>
    Private Sub LogoutUser()
        'close all open the mdi child views
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        'clear cached auth data
        AuthenticatedUserDetails = New AuthDetailsModel()
        'start the AuthView
        ShowAuthenticationView()

        'logout the user
        Dim authView As New AuthDetailsModel()
        authView.MenuJson = ""
        OnAuthenticationSuccessful(authView)
    End Sub

    Private Sub InitializeAuthorization()
        'TO DO: Check if any user is Authenticated
        'Open AuthView
        ShowAuthenticationView()
    End Sub

    Private Sub OpenCreditManagement()
        'Initialize authView
        Dim crmView As New CreditManagementView()
        'set authView as a child of MainView.
        crmView.MdiParent = Me
        'check if user is authorized for this view
        If IsViewAuthorized(crmView) Then
            crmView.StartPosition = FormStartPosition.CenterScreen
            'open authView
            crmView.Show()
        End If
    End Sub

    ''' <summary>
    ''' Opens the Authentication View
    ''' </summary>
    Private Sub ShowAuthenticationView()
        'Initialize authView
        _authView = New AuthenticationView(New AuthenticationViewModel())
        'set authView as a child of MainView.
        _authView.MdiParent = Me
        'Listen for successful authentication
        AddHandler _authView.AuthenticationSuccessful, AddressOf OnAuthenticationSuccessful
        'check if user is authorized for this view
        If IsViewAuthorized(_authView) Then '
            _authView.StartPosition = FormStartPosition.CenterScreen
            'open authView
            _authView.Show()

        End If

    End Sub

    Private Sub ShowCreditManagementView()
        Dim creditManagementView As CreditManagementView = New CreditManagementView()
        creditManagementView.MdiParent = Me
        'add any event handlers if necessarily
        'check if user is authorized for this view
        If IsViewAuthorized(creditManagementView) Then
            'open authView
            creditManagementView.Show()
        End If
    End Sub

    Private Sub OnAuthenticationSuccessful(authDetails As AuthDetailsModel)
        'assign the authenticated user details to global variable
        MainView.AuthenticatedUserDetails = authDetails
        _viewModel.Fullname = authDetails.Fullname
        _viewModel.UserRole = authDetails.UserRole
        _viewModel.Username = authDetails.Username

        Dim processedMenuString As String = authDetails.MenuJson.Replace(Chr(39), Chr(34))
        'parse menu json string to the a list of menu class
        Dim menu = JsonConvert.DeserializeObject(Of List(Of MenuModel))(processedMenuString)

        'raise the event to generate the app menu
        RaiseEvent InitializeApplicationMenu(menu)

    End Sub

    ''' <summary>
    ''' Checks whether the current user is authorized to view the view.
    ''' </summary>
    ''' <param name="view">The view that is about to be opened</param>
    ''' <returns>true if authorized, else returns false</returns>
    Private Function IsViewAuthorized(view As Form) As Boolean
        'Look for the claim of view from the list of claims for user
        Dim claim = AuthenticatedUserDetails.UserClaims.Claims.Find(Function(x) x = view.Tag)
        'if no claim is found....
        If String.IsNullOrEmpty(claim) Then
            MsgBox($"You are not authorized for {view.Tag}!", MsgBoxStyle.Exclamation, "Not Authorized")
            Return False 'return false
        End If
        'If claim is found... return true
        Return True
    End Function

End Class

Public Class TadaMenuItem
    Inherits ToolStripItem

End Class
