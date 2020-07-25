Public Class ExtendedTextBox
    Inherits TextBox
    Private _nulltext As String
    Private _initialForeColor As Color
    Private _IsPasswordField As Boolean

    Public Sub New()
        'new-up the textbox
        MyBase.New()
        UseSystemPasswordChar = False
        'subscribe for events from base
        AddHandler Leave, AddressOf ManageNullText
        AddHandler Enter, AddressOf ManageGotFocus
        SubscribeToForeColorChanged()
    End Sub

    Private Sub GetInitialForeColor(sender As Object, e As EventArgs)
        'set the initial forecolor
        _initialForeColor = Me.ForeColor
        'manage properties depending on Text property being not / equal to NullText
        ManageNullText(Me, EventArgs.Empty)
    End Sub

    Private Sub ManageGotFocus(sender As Object, e As EventArgs)
        'Set text as empty string if Text = NullText
        If Text = NullText Then
            Text = String.Empty

            If IsPasswordField Then
                ManagePasswordProperty(True)
            End If
        End If
        UnSubscribeToForeColorChanged()
        ForeColor = Color.Black
        SubscribeToForeColorChanged()

    End Sub

    Private Sub ManagePasswordProperty(isMasked As Boolean)
        UseSystemPasswordChar = isMasked
    End Sub

    ''' <summary>
    ''' Sets the nulltext property to text if text is null or empty on
    ''' loosing focus and sets the fore color to gray
    ''' </summary>
    Private Sub ManageNullText(sender As Object, e As EventArgs)
        'check if the Text is null or empty
        If String.IsNullOrEmpty(Text) Or Text = NullText Then
            'Set fore color as gray
            ForeColor = Color.Gray
            'Sets the Text property to NullText value if assigned.
            Text = NullText
            ManagePasswordProperty(False)
        End If
        Me.Refresh()
    End Sub

    Public Property NullText() As String
        Get
            Return _nulltext
        End Get
        Set(ByVal value As String)
            _nulltext = value
            ManageNullText(Me, EventArgs.Empty)
        End Set
    End Property

    Public Property IsPasswordField() As Boolean
        Get
            Return _IsPasswordField
        End Get
        Set(ByVal value As Boolean)
            _IsPasswordField = value
        End Set
    End Property

    Sub UnSubscribeToForeColorChanged()
        RemoveHandler ForeColorChanged, AddressOf GetInitialForeColor
    End Sub
    Sub SubscribeToForeColorChanged()
        AddHandler ForeColorChanged, AddressOf GetInitialForeColor
    End Sub

End Class
