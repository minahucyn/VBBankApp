Imports System.Data.SqlClient

Public Class CreditDataAccess
    Inherits DataAccessBase

    Public Function ReadAllCustomerCredits(userId As Integer) As List(Of CreditModel)
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_ReadCustomerCredits]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("UserId", userId)
        }

        Try
            'call method to read data from database
            Return Read(Of CreditModel)(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function

    Public Function ReadAllCreditsConfiguration() As List(Of CreditConfigModel)
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_ReadAllCreditConfig]"

        Try
            'call method to read data from database
            Return Read(Of CreditConfigModel)(storedProcedure)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function

    Public Function CreateNewCreditForCustomer(newCreditData As CreateCustomerCreditDatabaseModel) As Integer
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_CreateNewCustomerCredit]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("CreditConfigId", newCreditData.CreditConfigId),
            New SqlParameter("Username", newCreditData.Username)
        }
        Try
            'call method to insert to database
            Return Create(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function
End Class
