Public Class CreditConfigModel
    Public Property Id As Integer
    Public Property Description As String
    Public Property PrincipleAmount As Decimal
    Public Property InterestAmount As Decimal

    Public Overrides Function ToString() As String
        Return $"{Id} | {Description}"
    End Function
End Class
