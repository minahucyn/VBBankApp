Imports System.Data.SqlClient

Public Class ChangePasswordDataAccess
    Inherits DataAccessBase

    Public Function UpdateUserHash(username As String, userHash As String) As Integer
        'configure stored procedure and sql parameters
        Dim storedProcedure = "[dbo].[usp_UpdateUserHash]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Hash", userHash),
            New SqlParameter("Username", username)}
        Try
            'call the update function
            Return Update(storedProcedure, parameters)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadGoodHash(username As String) As GoodHashModel
        'configure stored procedure and sql parameters
        Dim storedProcedure = "[dbo].[usp_ReadGoodHash]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Username", username)}

        Try
            'read and return
            Return Read(Of GoodHashModel)(storedProcedure, parameters).FirstOrDefault
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
