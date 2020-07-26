Public Class ClaimsModel
    Public Sub New()
        Claims = New List(Of String)
        Claims.Add("AuthViewAccess")
        Claims.Add("CreditManagementViewAccess")
        Claims.Add("ChangePasswordAccess")
        Claims.Add("UserManagementViewAccess")
    End Sub
    Public Property Claims As List(Of String)
End Class
