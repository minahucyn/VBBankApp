Imports System.Data.SqlClient

Public Class SecuritiesDataAccess
    Inherits DataAccessBase

    Public Function ReadAllCustomerSecurities(userId As Integer) As List(Of SecurityModel)
        'configure stored procedure and parameters
        Dim storedProcedure = "[dbo].[usp_ReadCustomerSecurities]"
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("UserDetailsId", userId)
        }

        Try
            'call method to read data from database
            Return Read(Of SecurityModel)(storedProcedure, parameters)
        Catch ex As Exception
            'throw any exceptions. Will be handled down the line.
            Throw
        End Try
    End Function
End Class
