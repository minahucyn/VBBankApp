Imports System.Data.SqlClient
Imports System.Reflection

Public Class DataAccessBase
    Public _dataTable As DataTable
    Dim _connection As SqlConnection
    Dim _dataAdapter As SqlDataAdapter
    Public Sub New()
        _connection = New SqlConnection(My.Settings.ConnectionString)
        _dataAdapter = New SqlDataAdapter()

    End Sub

    ''' <summary>
    ''' Inserts rows to the database with the specified stored procedure and parameters
    ''' </summary>
    ''' <param name="storedProcedure">The stored procedure name as string</param>
    ''' <param name="sqlParameters">A list of SqlParameters</param>
    ''' <returns>Number of rows effected</returns>
    Public Function Create(storedProcedure As String, sqlParameters As List(Of SqlParameter)) As Integer
        'check method parameters
        If String.IsNullOrEmpty(storedProcedure) Then Throw New Exception("Stored procedure not provided for database call.")
        If sqlParameters Is Nothing Then Throw New Exception("No sql parameters provided for insert query.")

        'initialize new sql command
        _dataAdapter.InsertCommand = New SqlCommand(storedProcedure, _connection) With {
            .CommandType = CommandType.StoredProcedure}
        'add all parameters to sql parameter collection
        For Each parameter In sqlParameters
            _dataAdapter.InsertCommand.Parameters.Add(parameter)
        Next

        Try
            'open connection
            _connection.Open()
            'execute and return number of rows effected.
            Return _dataAdapter.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            'thow this. Will be handled down the line
            Throw
        Finally
            'close the connection
            _connection.Close()
        End Try
    End Function
    ''' <summary>
    ''' Reads data from database and returns a list of single result set
    ''' Reference: https://stackoverflow.com/questions/619767/set-object-property-using-reflection
    ''' Reference: https://stackoverflow.com/questions/9893028/c-sharp-foreach-property-in-object-is-there-a-simple-way-of-doing-this
    ''' </summary>
    ''' <typeparam name="T">Type of result list to return</typeparam>
    ''' <param name="storedProcedure">stored procedure name</param>
    ''' <param name="sqlParameters">Optional: list of sql parameters</param>
    ''' <returns>List of T</returns>
    Public Function Read(Of T As New)(storedProcedure As String, Optional sqlParameters As List(Of SqlParameter) = Nothing) As List(Of T)
        Dim isParametersRequiredForQuery As Boolean = True
        'check method parameters
        If String.IsNullOrEmpty(storedProcedure) Then Throw New Exception("Stored procedure not provided for database call.")
        If sqlParameters Is Nothing Then isParametersRequiredForQuery = False

        'initialize new sql command
        _dataAdapter.SelectCommand = New SqlCommand(storedProcedure, _connection) With {
            .CommandType = CommandType.StoredProcedure}
        'IF REQUIRED: add all parameters to sql parameter collection
        If isParametersRequiredForQuery Then
            For Each parameter In sqlParameters
                _dataAdapter.SelectCommand.Parameters.Add(parameter)
            Next
        End If
        'instantiate return type T
        Dim output As T = New T
        Dim outputList As List(Of T) = New List(Of T)
        Dim propertyInfo() As PropertyInfo = output.GetType().GetProperties()
        Try
            'open connection
            _connection.Open()
            'get datareader and read data
            Dim reader As SqlDataReader = _dataAdapter.SelectCommand.ExecuteReader()
            While reader.Read()
                'read the results into a generic instance
                For index = 1 To propertyInfo.Length - 1
                    propertyInfo(index).SetValue(output, reader(index))
                Next
                'add the instance to generic list
                outputList.Add(output)
                'reinitialize generic instance
                output = New T
            End While
            'close reader and return generic list
            reader.Close()
            Return outputList
        Catch ex As Exception
            'any exceptions will be handled down the line
            Throw
        Finally
            _connection.Close()
        End Try

    End Function
    Public Function Update(storedProcedure As String, sqlParameters As List(Of SqlParameter)) As Integer
        'check method parameters
        If String.IsNullOrEmpty(storedProcedure) Then Throw New Exception("Stored procedure not provided for database call.")
        If sqlParameters Is Nothing Then Throw New Exception("No sql parameters provided for update query.")

        'initialize new sql command
        _dataAdapter.UpdateCommand = New SqlCommand(storedProcedure, _connection) With {
            .CommandType = CommandType.StoredProcedure}
        'add all parameters to sql parameter collection
        For Each parameter In sqlParameters
            _dataAdapter.UpdateCommand.Parameters.Add(parameter)
        Next

        Try
            'open connection
            _connection.Open()
            'execute and return number of rows effected.
            Return _dataAdapter.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            'thow this. Will be handled down the line
            Throw
        Finally
            _connection.Close()
        End Try
    End Function
End Class
