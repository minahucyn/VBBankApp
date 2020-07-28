Public Class UserUpdateDatebaseModel
    Inherits UserInsertDatabaseModel
    Public Shared Function GetUserInsertModel(updateModel As UserManagementModel)
        Return New UserUpdateDatebaseModel() With {
            .Birthdate = updateModel.Birthdate,
            .Fullname = updateModel.Fullname,
            .Gender = updateModel.Gender,
            .IsActive = updateModel.IsActive,
            .NidPp = updateModel.NidPp,
            .PhoneNumber = updateModel.PhoneNumber,
            .Role = updateModel.Role,
            .UserId = updateModel.Id,
            .Username = updateModel.Username}
    End Function
    Public Property UserId As Integer
    Public Property IsActive As Boolean
End Class

