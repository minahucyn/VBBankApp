Public Class CreditModel
    Private _description As String
    Private _creditAmount As Double
    Private _interestOutstanding As Double
    Private _principleOutstanding As Double
    Private _outstanding As Double
    Private _principleDue As Double
    Private _interestDue As Double
    Private _totalDue As Double

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property
    Public Property CreditAmount() As Double
        Get
            Return _creditAmount
        End Get
        Set(ByVal value As Double)
            _creditAmount = value
        End Set
    End Property
    Public Property PrincipleOutstanding() As Double
        Get
            Return _principleOutstanding
        End Get
        Set(ByVal value As Double)
            _principleOutstanding = value
        End Set
    End Property
    Public Property InterestOutstanding() As Double
        Get
            Return _interestOutstanding
        End Get
        Set(ByVal value As Double)
            _interestOutstanding = value
        End Set
    End Property
    Public Property Outstanding() As Double
        Get
            Return _outstanding
        End Get
        Set(ByVal value As Double)
            _outstanding = value
        End Set
    End Property
    Public Property PrincipleDue() As Double
        Get
            Return _principleDue
        End Get
        Set(ByVal value As Double)
            _principleDue = value
        End Set
    End Property
    Public Property InterestDue() As Double
        Get
            Return _interestDue
        End Get
        Set(ByVal value As Double)
            _interestDue = value
        End Set
    End Property
    Public Property TotalDue() As Double
        Get
            Return _totalDue
        End Get
        Set(ByVal value As Double)
            _totalDue = value
        End Set
    End Property

End Class
