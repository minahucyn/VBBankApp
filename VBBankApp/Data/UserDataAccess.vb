﻿Imports System.Data.SqlClient

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

    Public Function UpdateUser(updateDbModel As UserUpdateDatebaseModel) As Integer
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_UpdateChangesToUser]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("UserId", updateDbModel.UserId),
            New SqlParameter("NidPp", updateDbModel.NidPp),
            New SqlParameter("Fullname", updateDbModel.Fullname),
            New SqlParameter("Username", updateDbModel.Username),
            New SqlParameter("PhoneNumber", updateDbModel.PhoneNumber),
            New SqlParameter("RoleId", updateDbModel.RolesIdForInsert),
            New SqlParameter("Birthdate", updateDbModel.Birthdate),
            New SqlParameter("Gender", updateDbModel.GenderForInsert),
            New SqlParameter("IsActive", updateDbModel.IsActive)
        }

        Try
            'call method to execute update
            Return Update(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Searches user
    ''' </summary>
    ''' <param name="nidPp"></param>
    ''' <returns></returns>
    Public Function SearchUserByNidPp(nidPp As String) As CustomerSearchDatabaseModel
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_ReadCustomerByNidPp]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("NidPp", nidPp)
        }

        Try
            'call method to execute insert
            Return Read(Of CustomerSearchDatabaseModel)(storedProcedure, parameters).FirstOrDefault
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function

    ''' <summary>
    ''' This function fetches all details for customer search combobox datasource
    ''' </summary>
    ''' <returns>List(Of CustomerSearchDetail)</returns>
    Public Function ReadAllCustomerSearchDatasourceData() As List(Of CustomerSearchDetail)
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_ReadAllCustomerSearchDatasourceFields]"

        Try
            'call method to execute insert
            Return Read(Of CustomerSearchDetail)(storedProcedure)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function


End Class
