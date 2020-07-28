Imports System.Data.SqlClient

Public Class UserDataAccess
    Inherits DataAccessBase

    Public Function ReadAllUsers() As List(Of UserManagementDatabaseModel)
        'configure stored procedure
        Dim storedProcedure = "[dbo].[usp_ReadAllUsers]"
        Try
            'read and return
            Return Read(Of UserManagementDatabaseModel)(storedProcedure)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub CreateUser(userInsertModel As UserInsertDatabaseModel)
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_CreateUser]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Fullname", userInsertModel.Fullname),
            New SqlParameter("NidPp", userInsertModel.NidPp),
            New SqlParameter("Birthdate", userInsertModel.Birthdate),
            New SqlParameter("Gender", userInsertModel.GenderForInsert),
            New SqlParameter("PhoneNumber", userInsertModel.PhoneNumber),
            New SqlParameter("RolesId", userInsertModel.RolesIdForInsert),
            New SqlParameter("Username", userInsertModel.Username)
        }

        Try
            'call method to execute insert
            Create(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Sub

    Public Function ResetPassword(username As String) As Integer
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_ResetUserPassword]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Username", username)
        }

        Try
            'call method to execute insert
            Return Update(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function

    Public Function UnlockUser(username As String) As Integer
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_UpdateUnlockUser]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("Username", username)
        }

        Try
            'call method to execute insert
            Return Update(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function
End Class
