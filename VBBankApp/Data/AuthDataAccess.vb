Imports System.Data.SqlClient

Public Class AuthDataAccess
    Inherits DataAccessBase

    Public Function ReadAuthData(username As String) As AuthDetailsDatabaseModel
        'configure stored procedure and sql parameters
        Dim storedProcedure = "[dbo].[usp_ReadAuthDetails]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Username", username)}

        Try
            'read and return
            Return Read(Of AuthDetailsDatabaseModel)(storedProcedure, parameters).FirstOrDefault
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function IncrementRetryCount(username As String) As Integer
        'configure stored procedure and sql parameters
        Dim storedProcedure = "[dbo].[usp_IncrementRetryCount]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Username", username)}

        Try
            'read and return
            Return Update(storedProcedure, parameters)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ResetRetryCount(username As String)
        'configure stored procedure and sql parameters
        Dim storedProcedure = "[dbo].[usp_ResetRetryCount]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Username", username)}

        Try
            'read and return
            Return Update(storedProcedure, parameters)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ReadUserStatus(username As String) As UserIsActiveIsLockedStatusModel
        'configure stored procedure and sql parameters
        Dim storedProcedure = "[dbo].[usp_ReadUserStatus]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Username", username)}

        Try
            'read and return
            Return Read(Of UserIsActiveIsLockedStatusModel)(storedProcedure, parameters).FirstOrDefault
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
