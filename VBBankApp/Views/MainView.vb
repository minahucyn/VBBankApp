Public Class MainView
    Private _claims As New ClaimsModel
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Initialize Authorization.
        InitializeAuthorization()

    End Sub

    Private Sub InitializeAuthorization()
        'TO DO: Check if any user is Authenticated

        'Open AuthView
        ShowAuthenticationView()

    End Sub

    ''' <summary>
    ''' Opens the Authentication View
    ''' </summary>
    Private Sub ShowAuthenticationView()
        'Initialize authView
        Dim authView As New AuthenticationView()
        'set authView as a child of MainView.
        authView.MdiParent = Me
        'check if user is authorized for this view
        If IsViewAuthorized(authView) Then
            'open authView
            authView.Show()
        End If

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
            MsgBox("You are not authorized for this view!", MsgBoxStyle.Exclamation, "Not Authorized")
            Return False 'return false
        End If
        'If claim is found... return true
        Return True
    End Function

End Class
