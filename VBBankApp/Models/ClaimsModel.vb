Public Class ClaimsModel
    Public Sub New()
        Claims = New List(Of String)
        Claims.Add("AuthViewAccess")
        'Claims.Add("CreditManagementViewAccess")
        'Claims.Add("ChangePasswordAccess")
        'Claims.Add("UserManagementViewAccess")
    End Sub
    Public Property Claims As List(Of String)
    Public Shared Function GetClaimsModel(claimsCSV As String)
        Return New ClaimsModel() With {
            .Claims = claimsCSV.Split(ChrW(44)).ToList()}
    End Function
End Class
