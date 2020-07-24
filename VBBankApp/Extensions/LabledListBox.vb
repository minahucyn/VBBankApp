Public Class LabledListBox
    Public Sub New()
        InitializeComponent()
    End Sub
    Private _caption As String
    Public Property Caption() As String
        Get
            Return _caption
        End Get
        Set(ByVal value As String)
            _caption = value
            ListBoxLabel.Text = value
        End Set
    End Property
End Class
