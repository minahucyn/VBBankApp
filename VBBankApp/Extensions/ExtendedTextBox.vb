Imports System.Text.RegularExpressions

Public Class ExtendedTextBox
    Inherits TextBox
    Private _nulltext As String
    Private _initialForeColor As Color
    Private _initialBackColor As Color
    Private _IsPasswordField As Boolean
    Private _isFocused As Boolean = True
    Private _autoValidate As Boolean
    Private _regexListToValidate As String
    Private _regexList As List(Of String)

    Public Event LengthRequirementChanged As EventHandler(Of Boolean)
    Public Event RegexEvaluated As EventHandler(Of RegexValidEventArgs)

    Public Sub New()
        'new-up the textbox
        MyBase.New()
        'Set the password character property as false. IsPasswordField is used instead
        UseSystemPasswordChar = False
        'instantiate regex list 
        _regexList = New List(Of String)
        'minimum valid length by default is 0
        MinimumValidLength = 0
        'set default text valid and Invalid Color
        TextValidColor = Color.Honeydew
        TextInvalidColor = Color.LavenderBlush

        'subscribe for events from base
        AddHandler Leave, AddressOf ManageNullText
        AddHandler MyBase.TextChanged, AddressOf ManageAutoValidation
        AddHandler Enter, AddressOf ManageGotFocus
        SubscribeToForeColorChanged()
    End Sub

    Private Sub ManageAutoValidation(sender As Object, e As EventArgs)
        'Ignore if autovalidation is false
        If Not AutoValidate Then Return
        'if no content to validate, return
        If String.IsNullOrEmpty(Text) Or Text = NullText Then
            'Set default back color
            BackColor = _initialBackColor
            Return
        End If

        'Run validations
        If RunAllValidations() Then
            BackColor = TextValidColor
        Else
            BackColor = TextInvalidColor
        End If
    End Sub

    Private Function RunAllValidations() As Boolean
        'IsAllValidationsPassed: This is set as false if even one evaluation is false and is never set to true
        'even when an evaluation is true. Therefore this can indicate if one or more evealuation failed.
        Dim IsAllValidationsPassed As Boolean = True
        'The tracker is dynamic and cannot be used to determine whether all validations passed.
        Dim IsValidTracker As Boolean = False

        'Run length check first, that is less costly.
        If Text.Length > MinimumValidLength Then
            IsValidTracker = True
        Else
            IsAllValidationsPassed = False
            IsValidTracker = False
        End If
        RaiseEvent LengthRequirementChanged(Me, IsValidTracker)

        'tacking current index
        Dim index As Integer = 0
        'validate against all expressions
        For Each expression In _regexList
            'Instantiate and evaluate expression
            Dim regex As New Regex(expression)
            IsValidTracker = regex.IsMatch(Text)
            'setting IsAllValidationsPassed if regex evaluation failed
            If Not IsValidTracker Then IsAllValidationsPassed = IsValidTracker
            'raise event to tell notify evaluationStatus for regex at index
            RaiseEvent RegexEvaluated(Me, New RegexValidEventArgs() With {.Isvalid = IsValidTracker, .RegexIndex = index})
            index += 1
        Next
        Return IsAllValidationsPassed
    End Function

    Private Sub GetInitialForeColor(sender As Object, e As EventArgs)
        'set the initial forecolor and back color
        _initialForeColor = Me.ForeColor
        _initialBackColor = Me.BackColor
        'manage properties depending on Text property being not / equal to NullText
        ManageNullText(Me, EventArgs.Empty)
    End Sub

    Private Sub ManageGotFocus(sender As Object, e As EventArgs)
        'Set text as empty string if Text = NullText
        If Text = NullText Then
            Text = String.Empty

            If IsPasswordField Then
                ManagePasswordProperty(True)
            End If
        End If
        UnSubscribeToForeColorChanged()
        ForeColor = Color.Black
        SubscribeToForeColorChanged()

    End Sub

    Private Sub ManagePasswordProperty(isMasked As Boolean)
        UseSystemPasswordChar = isMasked
    End Sub

    ''' <summary>
    ''' Sets the nulltext property to text if text is null or empty on
    ''' loosing focus and sets the fore color to gray
    ''' </summary>
    Private Sub ManageNullText(sender As Object, e As EventArgs)
        'check if the Text is null or empty
        If String.IsNullOrEmpty(Text) Or Text = NullText Then
            'Set fore color as gray
            ForeColor = Color.Gray
            'Sets the Text property to NullText value if assigned.
            Text = NullText
            ManagePasswordProperty(False)
        End If
        Me.Refresh()
    End Sub

    Public Property NullText() As String
        Get
            Return _nulltext
        End Get
        Set(ByVal value As String)
            _nulltext = value
            ManageNullText(Me, EventArgs.Empty)
        End Set
    End Property

    Public Property IsPasswordField() As Boolean
        Get
            Return _IsPasswordField
        End Get
        Set(ByVal value As Boolean)
            _IsPasswordField = value
        End Set
    End Property

    ''' <summary>
    ''' Comma separated regex statements for validation. This is used with AutoValidate 
    ''' property as True
    ''' </summary>
    Public Property RegexListToValidateCSV() As String
        Get
            Return _regexListToValidate
        End Get
        Set(ByVal value As String)
            _regexListToValidate = value
            InitializeRegexList(value)
        End Set
    End Property

    ''' <summary>
    ''' tries to initialize the regex list from user supplied CSV. 
    ''' Ignores any errors
    ''' </summary>
    ''' <param name="value">User supplied CSV regex statements</param>
    Private Sub InitializeRegexList(value As String)
        Try
            _regexList = value.Split(ChrW(44)).ToList()
        Catch ex As Exception
            'ignore
        End Try
    End Sub

    Public Property AutoValidate() As Boolean
        Get
            Return _autoValidate
        End Get
        Set(ByVal value As Boolean)
            _autoValidate = value
        End Set
    End Property
    Private _minimumValidLength As Integer
    Public Property MinimumValidLength() As Integer
        Get
            Return _minimumValidLength
        End Get
        Set(ByVal value As Integer)
            _minimumValidLength = value
        End Set
    End Property
    Private _textValidColor As Color
    Public Property TextValidColor() As Color
        Get
            Return _textValidColor
        End Get
        Set(ByVal value As Color)
            _textValidColor = value
        End Set
    End Property
    Private _textInvalidColor As Color
    Public Property TextInvalidColor() As Color
        Get
            Return _textInvalidColor
        End Get
        Set(ByVal value As Color)
            _textInvalidColor = value
        End Set
    End Property
    Sub UnSubscribeToForeColorChanged()
        RemoveHandler ForeColorChanged, AddressOf GetInitialForeColor
    End Sub
    Sub SubscribeToForeColorChanged()
        AddHandler ForeColorChanged, AddressOf GetInitialForeColor
    End Sub
End Class


Public Class RegexValidEventArgs
    Inherits EventArgs
    Public Property RegexIndex As Integer
    Public Property Isvalid As Boolean
End Class