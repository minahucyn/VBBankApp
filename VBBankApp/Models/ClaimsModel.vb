Public Class ClaimsModel
    Public Sub New()
        Claims = New List(Of String)
        Claims.Add("AuthViewAccess")
    End Sub
    Public Property Claims As List(Of String)
End Class
