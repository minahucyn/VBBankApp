Imports System.Data.SqlClient

Public Class RepaymentsDataAccess
    Inherits DataAccessBase

    Public Function ReadAllCustomerRepayments(userId As Integer) As List(Of RepaymentModel)
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_ReadCustomerRepayments]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("UserDetailsId", userId)
        }

        Try
            'call method to read data from database
            Return Read(Of RepaymentModel)(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function
End Class
