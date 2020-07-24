Imports VBBankApp

Public Class ExtendedGroupBox
    Public Sub New()
        InitializeComponent()

        'listen for events
        AddHandler GroupBox.TextChanged, AddressOf DisplayCaption
    End Sub

    Private Sub DisplayCaption(sender As Object, e As EventArgs)
        Label.Text = GroupBox.Text
    End Sub

    Private _caption As String
    Public Property Caption() As String
        Get
            Return _caption
        End Get
        Set(ByVal value As String)
            _caption = value
            Label.Text = value
        End Set
    End Property

    Private _captionAlignment As Alignment
    Public Property CaptionAlignment() As Alignment
        Get
            Return _captionAlignment
        End Get
        Set(ByVal value As Alignment)
            _captionAlignment = value
            AlignCaption(value)
        End Set
    End Property

    Private Sub AlignCaption(value As Alignment)
        Select Case value
            Case Alignment.Left
                Label.TextAlign = ContentAlignment.MiddleLeft
            Case Alignment.Center
                Label.TextAlign = ContentAlignment.MiddleCenter
            Case Alignment.Right
                Label.TextAlign = ContentAlignment.MiddleRight
            Case Else

        End Select
    End Sub

    Public Enum Alignment
        Left
        Center
        Right
    End Enum
End Class
