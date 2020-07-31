Imports System.ComponentModel
Imports VBBankApp

Public Class UserManagementViewModel
    Inherits ViewModelBase

#Region "Private properties"
    Private _selectedNidPp As String
    Private _selectedUsername As String
    Private _selectedFullname As String
    Private _selectedPhoneNumber As String
    Private _selectedRole As String
    Private _selectedBirthdate As Date?
    Private _selectedGender As String
    Private _selectedIsActive As Boolean
    Private _selectedIsUnlocked As Boolean
    Private _isEditMode As Boolean
    Private _falseOnEditMode As Boolean
    Private _isCancelEditEnabledVisible As Boolean
    Private _isUnlockUserAvailable As Boolean
    Private _LastSelectedUser As UserManagementModel
    Private _userDataAccess As UserDataAccess = New UserDataAccess

#End Region

#Region "Default Constructor"
    Public Sub New()
        AllUsers = New BindingList(Of UserManagementModel)
        AllRoles = New List(Of String)
        AllGenders = New List(Of String)
        'handle events 
        AddHandler Me.PropertyChanged, AddressOf LogicOnMyPropertiesChanges
        'initialize with edit mode disabled
        IsEditMode = False
        CheckBoxIsActiveIsVisible = True
        'InitializeDemoData()
        AddGendersAndRolesDatasource()
        LoadAllUsers()
    End Sub

#End Region

#Region "Public Properties"
    Public Property AllUsers As BindingList(Of UserManagementModel)
    Public Property AllRoles As List(Of String)
    Public Property AllGenders As List(Of String)

#Region "Selected Row Data"
    Public Property SelectedNidPp() As String
        Get
            Return _selectedNidPp
        End Get
        Set(ByVal value As String)
            If value = _selectedNidPp Then Return
            _selectedNidPp = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedUsername() As String
        Get
            Return _selectedUsername
        End Get
        Set(ByVal value As String)
            If value = _selectedUsername Then Return
            _selectedUsername = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedFullname() As String
        Get
            Return _selectedFullname
        End Get
        Set(ByVal value As String)
            If value = _selectedFullname Then Return
            _selectedFullname = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedPhoneNumber() As String
        Get
            Return _selectedPhoneNumber
        End Get
        Set(ByVal value As String)
            If value = _selectedPhoneNumber Then Return
            _selectedPhoneNumber = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedRole() As String
        Get
            Return _selectedRole
        End Get
        Set(ByVal value As String)
            If value = _selectedRole Then Return
            _selectedRole = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedBirthdate() As Date?
        Get
            Return _selectedBirthdate
        End Get
        Set(ByVal value As Date?)
            If value = _selectedBirthdate Then Return
            _selectedBirthdate = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedGender() As String
        Get
            Return _selectedGender
        End Get
        Set(ByVal value As String)
            If value = _selectedGender Then Return
            _selectedGender = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedIsActive() As Boolean
        Get
            Return _selectedIsActive
        End Get
        Set(ByVal value As Boolean)
            If value = _selectedIsActive Then Return
            _selectedIsActive = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property SelectedIsUnlocked() As Boolean
        Get
            Return _selectedIsUnlocked
        End Get
        Set(ByVal value As Boolean)
            If value = _selectedIsUnlocked Then Return
            _selectedIsUnlocked = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property IsEditMode() As Boolean
        Get
            Return _isEditMode
        End Get
        Set(ByVal value As Boolean)
            _isEditMode = value
            'set cancel edit button visible status
            IsCancelEditEnabledVisible = IsEditMode
            'is edit button visible status
            FalseOnEditMode = Not IsEditMode
            OnPropertyChanged()
        End Set
    End Property

    Public Property IsCancelEditEnabledVisible() As Boolean
        Get
            Return _isCancelEditEnabledVisible
        End Get
        Set(ByVal value As Boolean)
            _isCancelEditEnabledVisible = value
            OnPropertyChanged()
        End Set
    End Property
    Public Property FalseOnEditMode() As Boolean
        Get
            Return _falseOnEditMode
        End Get
        Set(ByVal value As Boolean)
            _falseOnEditMode = value
            OnPropertyChanged()
        End Set
    End Property
    Private _isAddMode As Boolean

    Public Property IsAddMode() As Boolean
        Get
            Return _isAddMode
        End Get
        Set(ByVal value As Boolean)
            'Add mode implemeted by setting IsAddModeEnabled flag as true
            'but the UI Functionality is brought by internally setting edit mode to true
            _isAddMode = value
            If value = True Then
                IsEditMode = True
                ClearDisplayedUserDetails()
            Else
                IsEditMode = False
                ReAssignSelectedUserDetails(_LastSelectedUser)
            End If
        End Set
    End Property
    Public Property IsButtonUnlockUserVisible As Boolean
        Get
            Return _isUnlockUserAvailable
        End Get
        Set
            _isUnlockUserAvailable = Value
            OnPropertyChanged()
        End Set
    End Property

    Private _checkBoxIsActiveIsVisible As Boolean
    Public Property CheckBoxIsActiveIsVisible() As Boolean
        Get
            Return _checkBoxIsActiveIsVisible
        End Get
        Set(ByVal value As Boolean)
            _checkBoxIsActiveIsVisible = value
            OnPropertyChanged()
        End Set
    End Property
    Private _checkBoxIsUnlockedIsVisible As Boolean
    Public Property CheckBoxIsUnlockedIsVisible() As Boolean
        Get
            Return _checkBoxIsUnlockedIsVisible
        End Get
        Set(ByVal value As Boolean)
            _checkBoxIsUnlockedIsVisible = value
            OnPropertyChanged()
        End Set
    End Property
#End Region

#End Region

#Region "Public Methods"
    ''' <summary>
    ''' reset passed-in username's users password to default
    ''' </summary>
    Friend Sub ResetSelectedUserPassword(username As String)
        Try
            Dim noRowsEffected = _userDataAccess.ResetPassword(username)
            If noRowsEffected > 0 Then MsgBox("Password reset to default, successful.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend Sub Save()
        Select Case True
            Case Me.IsEditMode And Me.IsAddMode
                'add new user
                AddNewUser()
            Case Me.IsEditMode
                'update user
                UpdateUser()
            Case Else

        End Select

    End Sub

    Friend Sub EnableAddMode()
        'set add mode enabled flag
        IsAddMode = True
    End Sub
    ''' <summary>
    ''' Enabled databound edit mode flag
    ''' </summary>
    Friend Sub EnableEditMode(enabledStatus As Boolean)
        IsEditMode = enabledStatus
    End Sub
    ''' <summary>
    ''' Set selected user details to details that corresponding to passed in userId
    ''' </summary>
    ''' <param name="userId">The user id of the selected user</param>
    Friend Sub DisplaySelectedUser(userId As Integer)
        'cancel edit mode
        IsEditMode = False
        'Clear displayed user details
        ClearDisplayedUserDetails()
        Dim selectedUser = AllUsers.Where(Function(x)
                                              Return x.Id = userId
                                          End Function).FirstOrDefault
        'ignore if no results returned
        If selectedUser Is Nothing Then
            Return
        End If
        'make last selected user available class wide
        _LastSelectedUser = selectedUser
        'assign selected user details to selected user properties
        ReAssignSelectedUserDetails(selectedUser)
    End Sub

#End Region

#Region "Private Methods"
    ''' <summary>
    ''' Adds Roles and genders
    ''' </summary>
    Private Sub AddGendersAndRolesDatasource()
        AllRoles.Add("Admin")
        AllRoles.Add("Customer")
        AllRoles.Add("Normal")
        AllGenders.Add("Male")
        AllGenders.Add("Female")
    End Sub
    ''' <summary>
    ''' Unlocks a locked user
    ''' </summary>
    Friend Sub UnlockUser(username As String)
        Try
            Dim NoRowsEffected = _userDataAccess.UnlockUser(username)
            If NoRowsEffected > 0 Then
                LoadAllUsers()
                MsgBox("Successfully unlocked the user!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Handles some of the logic on changes of my properties
    ''' </summary>
    Private Sub LogicOnMyPropertiesChanges(sender As Object, e As PropertyChangedEventArgs)

        If e.PropertyName = NameOf(IsEditMode) Then
            'LOGIC: CheckBoxIsActive for Visiblity
            'if Add mode is active, checkbox should not be visible
            If IsAddMode Then
                CheckBoxIsActiveIsVisible = False
            Else
                CheckBoxIsActiveIsVisible = True
            End If

            'LOGIC: CheckBoxIsUnlockedIsVisible for Visiblity
            'if a user us not locked, Do not allow user to lock another user while in edit mode. 
            'Hide CheckBoxIsUnlocked, user gets locked only when password is mismatched 3 times
            Select Case True
                Case IsAddMode And IsEditMode
                    CheckBoxIsUnlockedIsVisible = False
                Case Not IsAddMode And IsEditMode
                    CheckBoxIsUnlockedIsVisible = False
                Case IsAddMode And Not IsEditMode
                    CheckBoxIsUnlockedIsVisible = False
                Case Not IsAddMode And Not IsEditMode
                    CheckBoxIsUnlockedIsVisible = True
            End Select

        End If

        If e.PropertyName = NameOf(SelectedIsUnlocked) Or e.PropertyName = NameOf(IsEditMode) Then

            'LOGIC: Visibility of Button UnlockUser
            Select Case True
                Case Not IsAddMode And Not IsEditMode And Not SelectedIsUnlocked
                    IsButtonUnlockUserVisible = True
                Case Not IsAddMode And Not IsEditMode And SelectedIsUnlocked
                    IsButtonUnlockUserVisible = False
                Case Else
                    IsButtonUnlockUserVisible = False
            End Select

        End If


    End Sub
    ''' <summary>
    ''' Load all users from database
    ''' </summary>
    Private Sub LoadAllUsers()
        Try
            Dim allUsers = _userDataAccess.ReadAllUsers()
            AddQueriedListToDatasource(allUsers)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddQueriedListToDatasource(allUsers As List(Of UserManagementDatabaseModel))
        'clear datasource
        Me.AllUsers.Clear()
        'all newly fetched users to datasource
        For Each user In allUsers
            Me.AllUsers.Add(UserManagementModel.GetUserManagementModel(user))
        Next
    End Sub

    Private Sub InitializeDemoData()
        'demo user 1
        Dim user1 = New UserManagementModel() With {
            .Id = 1,
            .NidPp = "A2626525",
            .Username = "minahucyn",
            .Fullname = "moomina hussain",
            .Birthdate = New DateTime(1998, 2, 2),
            .PhoneNumber = "765-7111",
            .Role = "Admin",
            .Gender = "Female",
            .IsActive = False,
            .IsUnlocked = True}
        'demo user 2
        Dim user2 = New UserManagementModel() With {
            .Id = 2,
            .NidPp = "A856585",
            .Username = "someoneelsea",
            .Fullname = "Someone Elsea",
            .Birthdate = New DateTime(1989, 9, 10),
            .PhoneNumber = "986-5811",
            .Role = "Normal",
            .Gender = "Male",
            .IsActive = True,
            .IsUnlocked = True}

        'add demo user1 and demo user2 to datasource
        AllUsers.Add(user1)
        AllUsers.Add(user2)

    End Sub
    ''' <summary>
    ''' assigns the passed in user details to selected user properties
    ''' </summary>
    ''' <param name="selectedUser">The model with selected user details</param>
    Private Sub ReAssignSelectedUserDetails(selectedUser As UserManagementModel)
        SelectedNidPp = selectedUser.NidPp
        SelectedUsername = selectedUser.Username
        SelectedFullname = selectedUser.Fullname
        SelectedPhoneNumber = selectedUser.PhoneNumber
        SelectedRole = selectedUser.Role
        SelectedBirthdate = selectedUser.Birthdate
        SelectedGender = selectedUser.Gender
        SelectedIsActive = selectedUser.IsActive
        SelectedIsUnlocked = selectedUser.IsUnlocked
    End Sub

    ''' <summary>
    ''' Clears all values assigned to selected properties
    ''' </summary>
    Private Sub ClearDisplayedUserDetails()
        SelectedNidPp = String.Empty
        SelectedUsername = String.Empty
        SelectedFullname = String.Empty
        SelectedPhoneNumber = String.Empty
        SelectedRole = String.Empty
        SelectedBirthdate = Nothing
        SelectedGender = String.Empty
        SelectedIsActive = False
        SelectedIsUnlocked = False
    End Sub
    Private Sub AddNewUser()
        'step: save new user
        'instantiate insert model
        Dim userInsert As New UserInsertDatabaseModel() With {
            .Fullname = SelectedFullname,
            .NidPp = SelectedNidPp,
            .Birthdate = SelectedBirthdate,
            .Gender = SelectedGender,
            .PhoneNumber = SelectedPhoneNumber,
            .Role = SelectedRole,
            .Username = SelectedUsername}

        Try
            'call create user function
            Me._userDataAccess.CreateUser(userInsert)
            'load all users
            LoadAllUsers()
        Catch ex As Exception
            'if any exceptions, show the error message
            If ex.Message.Contains("UNIQUE KEY") Then
                MsgBox("The user already exists in the database. Please check the username and/or national ID/Passport and, try again.")
                Return
            End If
            MsgBox(ex.Message)
        End Try

        'disable add mode
        _isAddMode = False
        EnableEditMode(False)
    End Sub

    Private Sub UpdateUser()
        'Construct updated user
        Dim updatedUser = New UserManagementModel() With {
            .Id = _LastSelectedUser.Id,
            .NidPp = SelectedNidPp,
            .Username = SelectedUsername,
            .Fullname = SelectedFullname,
            .PhoneNumber = SelectedPhoneNumber,
            .Role = SelectedRole,
            .Birthdate = SelectedBirthdate,
            .Gender = SelectedGender,
            .IsActive = SelectedIsActive,
            .IsUnlocked = SelectedIsUnlocked}
        'check for changes
        If updatedUser.Equals(_LastSelectedUser) Then
            MsgBox("User does not have any updates to be made.")
            Return
        End If
        'get userupdate database model
        Dim userUpdateDatabaseModel = UserUpdateDatebaseModel.GetUserInsertModel(updatedUser)
        'update details
        Try
            Dim NoRowsEffected = _userDataAccess.UpdateUser(userUpdateDatabaseModel)
            If NoRowsEffected > 0 Then MsgBox("User updated successfully.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'cancel edit mode
        EnableEditMode(False)
        'load data from datebase
        LoadAllUsers()
    End Sub
#End Region

End Class
