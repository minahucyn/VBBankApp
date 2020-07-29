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

End Class
