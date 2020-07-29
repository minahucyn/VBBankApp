<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditManagementView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelBirthdate = New System.Windows.Forms.Label()
        Me.DateTimePickerBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonCustomerAddSave = New System.Windows.Forms.Button()
        Me.ButtonCustomerModify = New System.Windows.Forms.Button()
        Me.DataGridViewCustomerCredits = New System.Windows.Forms.DataGridView()
        Me.DataGridViewSecurity = New System.Windows.Forms.DataGridView()
        Me.SecId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Security = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Worth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewRepayments = New System.Windows.Forms.DataGridView()
        Me.RepaymentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepaymentCreditsId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Principle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonModifyCreditDetails = New System.Windows.Forms.Button()
        Me.ButtonAddPayments = New System.Windows.Forms.Button()
        Me.ButtonAddCreditDetails = New System.Windows.Forms.Button()
        Me.ButtonAddSecurityDetails = New System.Windows.Forms.Button()
        Me.ButtonModifySecurity = New System.Windows.Forms.Button()
        Me.ButtonModifyPayments = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExtendedTextBoxUsername = New VBBankApp.ExtendedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxNidPp = New VBBankApp.ExtendedTextBox()
        Me.TextBoxGender = New VBBankApp.ExtendedTextBox()
        Me.TextBoxPhoneNumber = New VBBankApp.ExtendedTextBox()
        Me.TextBoxCustomerName = New VBBankApp.ExtendedTextBox()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipleAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewCustomerCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewRepayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(131, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(8, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Natioanl Id / Passport"
        '
        'LabelBirthdate
        '
        Me.LabelBirthdate.AutoSize = True
        Me.LabelBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBirthdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelBirthdate.Location = New System.Drawing.Point(131, 123)
        Me.LabelBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelBirthdate.Name = "LabelBirthdate"
        Me.LabelBirthdate.Size = New System.Drawing.Size(55, 15)
        Me.LabelBirthdate.TabIndex = 21
        Me.LabelBirthdate.Text = "Birthdate"
        '
        'DateTimePickerBirthdate
        '
        Me.DateTimePickerBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerBirthdate.Location = New System.Drawing.Point(135, 140)
        Me.DateTimePickerBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerBirthdate.Name = "DateTimePickerBirthdate"
        Me.DateTimePickerBirthdate.Size = New System.Drawing.Size(115, 25)
        Me.DateTimePickerBirthdate.TabIndex = 21
        '
        'ButtonCustomerAddSave
        '
        Me.ButtonCustomerAddSave.Location = New System.Drawing.Point(94, 318)
        Me.ButtonCustomerAddSave.Name = "ButtonCustomerAddSave"
        Me.ButtonCustomerAddSave.Size = New System.Drawing.Size(75, 26)
        Me.ButtonCustomerAddSave.TabIndex = 10
        Me.ButtonCustomerAddSave.Text = "Save (F3)"
        Me.ButtonCustomerAddSave.UseVisualStyleBackColor = True
        '
        'ButtonCustomerModify
        '
        Me.ButtonCustomerModify.Location = New System.Drawing.Point(175, 318)
        Me.ButtonCustomerModify.Name = "ButtonCustomerModify"
        Me.ButtonCustomerModify.Size = New System.Drawing.Size(75, 26)
        Me.ButtonCustomerModify.TabIndex = 11
        Me.ButtonCustomerModify.Text = "Modify (F4)"
        Me.ButtonCustomerModify.UseVisualStyleBackColor = True
        '
        'DataGridViewCustomerCredits
        '
        Me.DataGridViewCustomerCredits.AllowUserToAddRows = False
        Me.DataGridViewCustomerCredits.AllowUserToDeleteRows = False
        Me.DataGridViewCustomerCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewCustomerCredits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewCustomerCredits.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewCustomerCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerCredits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Description, Me.PrincipleAmount, Me.InterestAmount, Me.LastUpdated, Me.ColumnTimeStamp})
        Me.DataGridViewCustomerCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewCustomerCredits.Location = New System.Drawing.Point(3, 18)
        Me.DataGridViewCustomerCredits.Name = "DataGridViewCustomerCredits"
        Me.DataGridViewCustomerCredits.ReadOnly = True
        Me.DataGridViewCustomerCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCustomerCredits.Size = New System.Drawing.Size(635, 194)
        Me.DataGridViewCustomerCredits.TabIndex = 0
        '
        'DataGridViewSecurity
        '
        Me.DataGridViewSecurity.AllowUserToAddRows = False
        Me.DataGridViewSecurity.AllowUserToDeleteRows = False
        Me.DataGridViewSecurity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewSecurity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewSecurity.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSecurity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SecId, Me.Security, Me.CreditId, Me.Worth})
        Me.DataGridViewSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSecurity.Location = New System.Drawing.Point(3, 18)
        Me.DataGridViewSecurity.Name = "DataGridViewSecurity"
        Me.DataGridViewSecurity.ReadOnly = True
        Me.DataGridViewSecurity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSecurity.Size = New System.Drawing.Size(263, 140)
        Me.DataGridViewSecurity.TabIndex = 0
        '
        'SecId
        '
        Me.SecId.DataPropertyName = "Id"
        Me.SecId.HeaderText = "Id"
        Me.SecId.Name = "SecId"
        Me.SecId.ReadOnly = True
        Me.SecId.Visible = False
        Me.SecId.Width = 41
        '
        'Security
        '
        Me.Security.DataPropertyName = "Description"
        Me.Security.HeaderText = "Security"
        Me.Security.Name = "Security"
        Me.Security.ReadOnly = True
        Me.Security.Width = 72
        '
        'CreditId
        '
        Me.CreditId.DataPropertyName = "CreditId"
        Me.CreditId.HeaderText = "Credit Id"
        Me.CreditId.Name = "CreditId"
        Me.CreditId.ReadOnly = True
        Me.CreditId.Visible = False
        Me.CreditId.Width = 71
        '
        'Worth
        '
        Me.Worth.DataPropertyName = "Worth"
        Me.Worth.HeaderText = "Worth"
        Me.Worth.Name = "Worth"
        Me.Worth.ReadOnly = True
        Me.Worth.Width = 65
        '
        'DataGridViewRepayments
        '
        Me.DataGridViewRepayments.AllowUserToAddRows = False
        Me.DataGridViewRepayments.AllowUserToDeleteRows = False
        Me.DataGridViewRepayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewRepayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewRepayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewRepayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRepayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepaymentId, Me.RepaymentCreditsId, Me.Principle, Me.Interest, Me.TimeStamp})
        Me.DataGridViewRepayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRepayments.Location = New System.Drawing.Point(3, 18)
        Me.DataGridViewRepayments.Name = "DataGridViewRepayments"
        Me.DataGridViewRepayments.ReadOnly = True
        Me.DataGridViewRepayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRepayments.Size = New System.Drawing.Size(357, 137)
        Me.DataGridViewRepayments.TabIndex = 0
        '
        'RepaymentId
        '
        Me.RepaymentId.DataPropertyName = "Id"
        Me.RepaymentId.HeaderText = "Id"
        Me.RepaymentId.Name = "RepaymentId"
        Me.RepaymentId.ReadOnly = True
        Me.RepaymentId.Visible = False
        Me.RepaymentId.Width = 41
        '
        'RepaymentCreditsId
        '
        Me.RepaymentCreditsId.DataPropertyName = "CreditsId"
        Me.RepaymentCreditsId.HeaderText = "Credit Id"
        Me.RepaymentCreditsId.Name = "RepaymentCreditsId"
        Me.RepaymentCreditsId.ReadOnly = True
        Me.RepaymentCreditsId.Visible = False
        Me.RepaymentCreditsId.Width = 71
        '
        'Principle
        '
        Me.Principle.DataPropertyName = "Principle"
        Me.Principle.HeaderText = "Principle Amount"
        Me.Principle.Name = "Principle"
        Me.Principle.ReadOnly = True
        Me.Principle.Width = 110
        '
        'Interest
        '
        Me.Interest.DataPropertyName = "Interest"
        Me.Interest.HeaderText = "Interest"
        Me.Interest.Name = "Interest"
        Me.Interest.ReadOnly = True
        Me.Interest.Width = 71
        '
        'TimeStamp
        '
        Me.TimeStamp.DataPropertyName = "TimeStamp"
        Me.TimeStamp.HeaderText = "Repayment Date"
        Me.TimeStamp.Name = "TimeStamp"
        Me.TimeStamp.ReadOnly = True
        Me.TimeStamp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TimeStamp.Width = 106
        '
        'ButtonModifyCreditDetails
        '
        Me.ButtonModifyCreditDetails.Location = New System.Drawing.Point(97, 26)
        Me.ButtonModifyCreditDetails.Name = "ButtonModifyCreditDetails"
        Me.ButtonModifyCreditDetails.Size = New System.Drawing.Size(75, 26)
        Me.ButtonModifyCreditDetails.TabIndex = 12
        Me.ButtonModifyCreditDetails.Text = "Modify (F6)"
        Me.ButtonModifyCreditDetails.UseVisualStyleBackColor = True
        '
        'ButtonAddPayments
        '
        Me.ButtonAddPayments.Location = New System.Drawing.Point(6, 27)
        Me.ButtonAddPayments.Name = "ButtonAddPayments"
        Me.ButtonAddPayments.Size = New System.Drawing.Size(89, 26)
        Me.ButtonAddPayments.TabIndex = 13
        Me.ButtonAddPayments.Text = "Add (F9)"
        Me.ButtonAddPayments.UseVisualStyleBackColor = True
        '
        'ButtonAddCreditDetails
        '
        Me.ButtonAddCreditDetails.Location = New System.Drawing.Point(16, 26)
        Me.ButtonAddCreditDetails.Name = "ButtonAddCreditDetails"
        Me.ButtonAddCreditDetails.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAddCreditDetails.TabIndex = 14
        Me.ButtonAddCreditDetails.Text = "Add (F5)"
        Me.ButtonAddCreditDetails.UseVisualStyleBackColor = True
        '
        'ButtonAddSecurityDetails
        '
        Me.ButtonAddSecurityDetails.Location = New System.Drawing.Point(16, 27)
        Me.ButtonAddSecurityDetails.Name = "ButtonAddSecurityDetails"
        Me.ButtonAddSecurityDetails.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAddSecurityDetails.TabIndex = 15
        Me.ButtonAddSecurityDetails.Text = "Add (F7)"
        Me.ButtonAddSecurityDetails.UseVisualStyleBackColor = True
        '
        'ButtonModifySecurity
        '
        Me.ButtonModifySecurity.Location = New System.Drawing.Point(97, 27)
        Me.ButtonModifySecurity.Name = "ButtonModifySecurity"
        Me.ButtonModifySecurity.Size = New System.Drawing.Size(75, 26)
        Me.ButtonModifySecurity.TabIndex = 16
        Me.ButtonModifySecurity.Text = "Modify (F8)"
        Me.ButtonModifySecurity.UseVisualStyleBackColor = True
        '
        'ButtonModifyPayments
        '
        Me.ButtonModifyPayments.Location = New System.Drawing.Point(98, 26)
        Me.ButtonModifyPayments.Name = "ButtonModifyPayments"
        Me.ButtonModifyPayments.Size = New System.Drawing.Size(89, 26)
        Me.ButtonModifyPayments.TabIndex = 17
        Me.ButtonModifyPayments.Text = "Modify (F10)"
        Me.ButtonModifyPayments.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonModifyCreditDetails)
        Me.GroupBox1.Controls.Add(Me.ButtonAddCreditDetails)
        Me.GroupBox1.Location = New System.Drawing.Point(283, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 68)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credit Details Functions"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonModifySecurity)
        Me.GroupBox2.Controls.Add(Me.ButtonAddSecurityDetails)
        Me.GroupBox2.Location = New System.Drawing.Point(506, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 68)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security Details Functions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonModifyPayments)
        Me.GroupBox3.Controls.Add(Me.ButtonAddPayments)
        Me.GroupBox3.Location = New System.Drawing.Point(728, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 68)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Details Functions"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridViewCustomerCredits)
        Me.GroupBox4.Location = New System.Drawing.Point(283, 77)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(641, 215)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Credit details"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridViewSecurity)
        Me.GroupBox5.Location = New System.Drawing.Point(286, 295)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(269, 161)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Security Details"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridViewRepayments)
        Me.GroupBox6.Location = New System.Drawing.Point(561, 298)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(363, 158)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Payment Details"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(270, 67)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Search Customer (Nid / Pp)"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(13, 25)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(237, 22)
        Me.TextBoxSearch.TabIndex = 1
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.ExtendedTextBoxUsername)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.TextBoxNidPp)
        Me.GroupBox8.Controls.Add(Me.ButtonCustomerAddSave)
        Me.GroupBox8.Controls.Add(Me.TextBoxGender)
        Me.GroupBox8.Controls.Add(Me.ButtonCustomerModify)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.TextBoxPhoneNumber)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBox8.Controls.Add(Me.DateTimePickerBirthdate)
        Me.GroupBox8.Controls.Add(Me.LabelBirthdate)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 77)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(274, 379)
        Me.GroupBox8.TabIndex = 23
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Customer Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(7, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Username"
        '
        'ExtendedTextBoxUsername
        '
        Me.ExtendedTextBoxUsername.AutoValidate = False
        Me.ExtendedTextBoxUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtendedTextBoxUsername.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxUsername.IsPasswordField = False
        Me.ExtendedTextBoxUsername.Location = New System.Drawing.Point(10, 191)
        Me.ExtendedTextBoxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.ExtendedTextBoxUsername.MinimumValidLength = 0
        Me.ExtendedTextBoxUsername.Name = "ExtendedTextBoxUsername"
        Me.ExtendedTextBoxUsername.NullText = "Gender"
        Me.ExtendedTextBoxUsername.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBoxUsername.Size = New System.Drawing.Size(116, 25)
        Me.ExtendedTextBoxUsername.TabIndex = 28
        Me.ExtendedTextBoxUsername.Text = "username"
        Me.ExtendedTextBoxUsername.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxUsername.TextValidColor = System.Drawing.Color.Honeydew
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "New  (F2)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxNidPp
        '
        Me.TextBoxNidPp.AutoValidate = False
        Me.TextBoxNidPp.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNidPp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNidPp.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxNidPp.IsPasswordField = False
        Me.TextBoxNidPp.Location = New System.Drawing.Point(11, 40)
        Me.TextBoxNidPp.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNidPp.MinimumValidLength = 0
        Me.TextBoxNidPp.Name = "TextBoxNidPp"
        Me.TextBoxNidPp.NullText = "Nid/Pp"
        Me.TextBoxNidPp.RegexListToValidateCSV = Nothing
        Me.TextBoxNidPp.Size = New System.Drawing.Size(239, 25)
        Me.TextBoxNidPp.TabIndex = 4
        Me.TextBoxNidPp.Text = "Nid/Pp"
        Me.TextBoxNidPp.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxNidPp.TextValidColor = System.Drawing.Color.Honeydew
        '
        'TextBoxGender
        '
        Me.TextBoxGender.AutoValidate = False
        Me.TextBoxGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGender.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxGender.IsPasswordField = False
        Me.TextBoxGender.Location = New System.Drawing.Point(11, 140)
        Me.TextBoxGender.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxGender.MinimumValidLength = 0
        Me.TextBoxGender.Name = "TextBoxGender"
        Me.TextBoxGender.NullText = "Gender"
        Me.TextBoxGender.RegexListToValidateCSV = Nothing
        Me.TextBoxGender.Size = New System.Drawing.Size(115, 25)
        Me.TextBoxGender.TabIndex = 1
        Me.TextBoxGender.Text = "Gender"
        Me.TextBoxGender.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxGender.TextValidColor = System.Drawing.Color.Honeydew
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.AutoValidate = False
        Me.TextBoxPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhoneNumber.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxPhoneNumber.IsPasswordField = False
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(134, 191)
        Me.TextBoxPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPhoneNumber.MinimumValidLength = 0
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.NullText = "Phone Number"
        Me.TextBoxPhoneNumber.RegexListToValidateCSV = Nothing
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxPhoneNumber.TabIndex = 2
        Me.TextBoxPhoneNumber.Text = "Phone Number"
        Me.TextBoxPhoneNumber.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxPhoneNumber.TextValidColor = System.Drawing.Color.Honeydew
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.AutoValidate = False
        Me.TextBoxCustomerName.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCustomerName.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxCustomerName.IsPasswordField = False
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(10, 91)
        Me.TextBoxCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCustomerName.MinimumValidLength = 0
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.NullText = "Customer name"
        Me.TextBoxCustomerName.RegexListToValidateCSV = Nothing
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(240, 25)
        Me.TextBoxCustomerName.TabIndex = 1
        Me.TextBoxCustomerName.Text = "CUSTOMER NAME"
        Me.TextBoxCustomerName.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxCustomerName.TextValidColor = System.Drawing.Color.Honeydew
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 42
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 91
        '
        'PrincipleAmount
        '
        Me.PrincipleAmount.DataPropertyName = "PrincipleAmount"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PrincipleAmount.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrincipleAmount.HeaderText = "Principle Amount"
        Me.PrincipleAmount.Name = "PrincipleAmount"
        Me.PrincipleAmount.ReadOnly = True
        Me.PrincipleAmount.Width = 110
        '
        'InterestAmount
        '
        Me.InterestAmount.DataPropertyName = "InterestAmount"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.InterestAmount.DefaultCellStyle = DataGridViewCellStyle2
        Me.InterestAmount.HeaderText = "Interest Amount"
        Me.InterestAmount.Name = "InterestAmount"
        Me.InterestAmount.ReadOnly = True
        Me.InterestAmount.Width = 105
        '
        'LastUpdated
        '
        Me.LastUpdated.DataPropertyName = "LastUpdated"
        Me.LastUpdated.HeaderText = "Last Updated"
        Me.LastUpdated.Name = "LastUpdated"
        Me.LastUpdated.ReadOnly = True
        Me.LastUpdated.Width = 92
        '
        'ColumnTimeStamp
        '
        Me.ColumnTimeStamp.DataPropertyName = "TimeStamp"
        Me.ColumnTimeStamp.HeaderText = "Time Stamp"
        Me.ColumnTimeStamp.Name = "ColumnTimeStamp"
        Me.ColumnTimeStamp.ReadOnly = True
        Me.ColumnTimeStamp.Width = 84
        '
        'CreditManagementView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 457)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditManagementView"
        Me.Tag = "CreditManagementViewAccess"
        Me.Text = "CreditManagementView"
        CType(Me.DataGridViewCustomerCredits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewRepayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxPhoneNumber As ExtendedTextBox
    Friend WithEvents TextBoxNidPp As ExtendedTextBox
    Friend WithEvents TextBoxGender As ExtendedTextBox
    Friend WithEvents TextBoxCustomerName As ExtendedTextBox
    Friend WithEvents ButtonCustomerAddSave As Button
    Friend WithEvents ButtonCustomerModify As Button
    Friend WithEvents ButtonModifyCreditDetails As Button
    Friend WithEvents ButtonAddPayments As Button
    Friend WithEvents ButtonAddCreditDetails As Button
    Friend WithEvents ButtonAddSecurityDetails As Button
    Friend WithEvents ButtonModifySecurity As Button
    Friend WithEvents ButtonModifyPayments As Button
    Friend WithEvents DataGridViewCustomerCredits As DataGridView
    Friend WithEvents DataGridViewSecurity As DataGridView
    Friend WithEvents DataGridViewRepayments As DataGridView
    Friend WithEvents SecId As DataGridViewTextBoxColumn
    Friend WithEvents Security As DataGridViewTextBoxColumn
    Friend WithEvents CreditId As DataGridViewTextBoxColumn
    Friend WithEvents Worth As DataGridViewTextBoxColumn
    Friend WithEvents RepaymentId As DataGridViewTextBoxColumn
    Friend WithEvents RepaymentCreditsId As DataGridViewTextBoxColumn
    Friend WithEvents Principle As DataGridViewTextBoxColumn
    Friend WithEvents Interest As DataGridViewTextBoxColumn
    Friend WithEvents TimeStamp As DataGridViewTextBoxColumn
    Friend WithEvents LabelBirthdate As Label
    Friend WithEvents DateTimePickerBirthdate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ExtendedTextBoxUsername As ExtendedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents PrincipleAmount As DataGridViewTextBoxColumn
    Friend WithEvents InterestAmount As DataGridViewTextBoxColumn
    Friend WithEvents LastUpdated As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTimeStamp As DataGridViewTextBoxColumn
End Class
