﻿Public Class AuthDetailsModel
    Public Sub New()
        UserClaims = New ClaimsModel
    End Sub
    Public Property Fullname As String
    Public Property Username As String
    Public Property UserRole As String
    Public Property UserClaims As ClaimsModel
    Public Property GoodHash As String
    Public Property IsLocked As Boolean
    Public Property IsActive As Boolean
    Public Property MenuJson As String
End Class
