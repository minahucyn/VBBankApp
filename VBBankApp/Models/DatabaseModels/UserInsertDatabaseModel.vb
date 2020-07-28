Public Class UserInsertDatabaseModel
    Private _gender As String
    Private _roleId As String
    Private _genderForInsert As Integer
    Private _rolesIdForInsert As Integer
    Public Property Fullname As String
    Public Property NidPp As String
    Public Property Birthdate As Date
    Public Property GenderForInsert As Integer
        Get
            Return _genderForInsert
        End Get
        Private Set
            _genderForInsert = Value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set
            _gender = Value
            _genderForInsert = GetGenderId(Value)
        End Set
    End Property
    Public Property PhoneNumber As String
    Public Property RolesIdForInsert As Integer
        Get
            Return _rolesIdForInsert
        End Get
        Private Set
            _rolesIdForInsert = Value
        End Set
    End Property

    Public Property Role As String
        Get
            Return _roleId
        End Get
        Set
            _roleId = Value
            _rolesIdForInsert = GetRolesId(Value)
        End Set
    End Property

    Public Property Username As String

    Private Function GetGenderId(value As String) As Integer
        Select Case True
            Case value.Trim().ToLower() = EGender.male.ToString
                Return EGender.male
            Case value.Trim().ToLower() = EGender.female.ToString
                Return EGender.female
            Case Else

        End Select
    End Function
    Private Function GetRolesId(value As String) As String
        Select Case True
            Case value.Trim().ToLower() = ERoles.admin.ToString
                Return ERoles.admin
            Case value.Trim().ToLower() = ERoles.customer.ToString
                Return ERoles.customer
            Case value.Trim().ToLower() = ERoles.normal.ToString
                Return ERoles.normal
            Case Else

        End Select
    End Function
    Private Enum EGender
        male
        female
    End Enum
    Private Enum ERoles
        admin = 1
        customer
        normal
    End Enum
End Class

