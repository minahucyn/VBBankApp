Imports Newtonsoft.Json

Public Class UserManagementModel
    Public Property Id As Integer
    Public Property NidPp As String
    Public Property Username As String
    Public Property Fullname As String
    Public Property PhoneNumber As String
    Public Property Role As String
    Public Property Birthdate As Date?
    Public Property Gender As String
    Public Property IsActive As Boolean
    Public Property IsUnlocked As Boolean

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim user As UserManagementModel = obj

        Dim user1 As String = JsonConvert.SerializeObject(user)
        Dim user2 As String = JsonConvert.SerializeObject(Me)
        Debug.WriteLine(user1)
        Debug.WriteLine(user2)
        If user1 = user2 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
