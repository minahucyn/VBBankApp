Imports System.ComponentModel

Public Class AuthenticationView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.CenterToParent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub AuthenticationView_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
