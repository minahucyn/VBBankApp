Public Class CustomerSearchDetail
    Public Property NidPp As String
    Public Property Fullname As String

    Public Overrides Function ToString() As String
        Return $"{NidPp} | {Fullname}"
    End Function
End Class
