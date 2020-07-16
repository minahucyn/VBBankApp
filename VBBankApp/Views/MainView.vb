﻿Imports Newtonsoft.Json
Imports VBBankApp

Public Class MainView
    Private ReadOnly _viewModel As MainViewModel
    Private _claims As New ClaimsModel
    Dim WithEvents _authView As AuthenticationView

#Region "Events"
    Public Event InitializeApplicationMenu(appMenu As List(Of MenuModel))
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Initialize Authorization.
        InitializeAuthorization()
        InitializeMenu()
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

        'determine number of menu levels
        Dim menuLevels As Integer = 0
        While True

            Dim levelExists As Boolean = appMenu.Exists(Function(x)
                                                            Return x.ParentId = menuLevels
                                                        End Function)
            If levelExists Then
                menuLevels += 1
            Else
                Exit While
            End If


        End While




        For index = 0 To menuLevels
            Dim currentLevelMenu = appMenu.Where(Function(x)
                                                     Return x.ParentId = index
                                                 End Function)

            'add level menu
            For Each item In currentLevelMenu
                'add root level
                If item.ParentId = 0 Then
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
        Next





    End Sub

    Private Sub InitializeBinding()
        'logged in fullname [ username ]
        ToolStripLabelUserNameAndRole.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.DisplayUsernameFullname)))
        'logged in user role
        ToolStripLabelUserRoleDisplay.DataBindings.Add(New Binding("Text", _viewModel, NameOf(_viewModel.UserRole)))
    End Sub

    Private Sub TadaClicked(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub InitializeMenu()
        'clear the menu
        'add the tada stuff to the menu

        'MainMenuStrip.Items.Clear()
        'MainMenuStrip.Items.Add("Boom", Nothing, AddressOf TadaCicked)
        'MainMenuStrip.Items.Add("B000oom", Nothing, AddressOf TadaCicked)

        'Dim SubMenu As ToolStripMenuItem = New ToolStripMenuItem("Sub Boom", Nothing, AddressOf TadaClicked)

        'For Each item In MainMenuStrip.Items
        '    Dim boomItem As ToolStripMenuItem = item
        '    Debug.WriteLine("Menu item name:" + boomItem.Text)
        '    boomItem.DropDownItems.Add(SubMenu)

        'Next


    End Sub

    Private Sub TadaCicked(sender As Object, e As EventArgs)
        Dim og_boom As ToolStripMenuItem = sender
        Debug.WriteLine(og_boom.Text & " - " & og_boom.DropDownItems.Count)
    End Sub

    Private Sub InitializeAuthorization()
        'TO DO: Check if any user is Authenticated

        Dim menu As List(Of MenuModel) = New List(Of MenuModel)
        menu.Add(New MenuModel() With {.Id = 1, .Name = "Username", .ParentId = 0})
        menu.Add(New MenuModel() With {.Id = 2, .Name = "Log Out", .ParentId = 1})
        menu.Add(New MenuModel() With {.Id = 3, .Name = "Exit", .ParentId = 1})

        'Open AuthView
        ShowAuthenticationView()
    End Sub

    Private Sub OpenCreditManagement()
        'Initialize authView
        Dim crmView As New CreditManagementView(New CreditManagementViewModel())
        'set authView as a child of MainView.
        crmView.MdiParent = Me
        'check if user is authorized for this view
        If IsViewAuthorized(crmView) Then
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
        If IsViewAuthorized(_authView) Then
            'open authView
            _authView.Show()
        End If

    End Sub

    Private Sub OnAuthenticationSuccessful(authDetails As AuthDetailsModel)
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
        Dim claim = _claims.Claims.Find(Function(x) x = view.Tag)
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
