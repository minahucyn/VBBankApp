<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreditManagementView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelBirthdate = New System.Windows.Forms.Label()
        Me.DateTimePickerBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewCustomerCredits = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipleAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBoxCreditDetailsAdd = New System.Windows.Forms.GroupBox()
        Me.PanelAddCredit = New System.Windows.Forms.Panel()
        Me.ButtonCancelCredit = New System.Windows.Forms.Button()
        Me.ButtonSaveNewCredit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxInterestAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxPrincipleAmount = New System.Windows.Forms.TextBox()
        Me.ComboBoxCredits = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelGridCredit = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExtendedTextBoxUsername = New VBBankApp.ExtendedTextBox()
        Me.TextBoxNidPp = New VBBankApp.ExtendedTextBox()
        Me.TextBoxGender = New VBBankApp.ExtendedTextBox()
        Me.TextBoxPhoneNumber = New VBBankApp.ExtendedTextBox()
        Me.TextBoxCustomerName = New VBBankApp.ExtendedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepaymentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedCreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedSecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBoxCustomerSearch = New System.Windows.Forms.ComboBox()
        Me.GroupBoxCreditDisplay = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridViewCustomerCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewRepayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxCreditDetailsAdd.SuspendLayout()
        Me.PanelAddCredit.SuspendLayout()
        Me.PanelGridCredit.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxCreditDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(136, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(10, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(136, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nid /  Pp"
        '
        'LabelBirthdate
        '
        Me.LabelBirthdate.AutoSize = True
        Me.LabelBirthdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBirthdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelBirthdate.Location = New System.Drawing.Point(133, 90)
        Me.LabelBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelBirthdate.Name = "LabelBirthdate"
        Me.LabelBirthdate.Size = New System.Drawing.Size(54, 13)
        Me.LabelBirthdate.TabIndex = 21
        Me.LabelBirthdate.Text = "Birthdate"
        '
        'DateTimePickerBirthdate
        '
        Me.DateTimePickerBirthdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerBirthdate.Location = New System.Drawing.Point(137, 107)
        Me.DateTimePickerBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerBirthdate.Name = "DateTimePickerBirthdate"
        Me.DateTimePickerBirthdate.Size = New System.Drawing.Size(115, 22)
        Me.DateTimePickerBirthdate.TabIndex = 21
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
        Me.DataGridViewCustomerCredits.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewCustomerCredits.Name = "DataGridViewCustomerCredits"
        Me.DataGridViewCustomerCredits.ReadOnly = True
        Me.DataGridViewCustomerCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCustomerCredits.Size = New System.Drawing.Size(666, 223)
        Me.DataGridViewCustomerCredits.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 41
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
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PrincipleAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrincipleAmount.HeaderText = "Principle Amount"
        Me.PrincipleAmount.Name = "PrincipleAmount"
        Me.PrincipleAmount.ReadOnly = True
        Me.PrincipleAmount.Width = 110
        '
        'InterestAmount
        '
        Me.InterestAmount.DataPropertyName = "InterestAmount"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.InterestAmount.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.DataGridViewSecurity.Size = New System.Drawing.Size(407, 197)
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
        Me.DataGridViewRepayments.Size = New System.Drawing.Size(521, 198)
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
        'GroupBoxCreditDetailsAdd
        '
        Me.GroupBoxCreditDetailsAdd.Controls.Add(Me.PanelAddCredit)
        Me.GroupBoxCreditDetailsAdd.Location = New System.Drawing.Point(1058, 27)
        Me.GroupBoxCreditDetailsAdd.Name = "GroupBoxCreditDetailsAdd"
        Me.GroupBoxCreditDetailsAdd.Size = New System.Drawing.Size(672, 244)
        Me.GroupBoxCreditDetailsAdd.TabIndex = 24
        Me.GroupBoxCreditDetailsAdd.TabStop = False
        Me.GroupBoxCreditDetailsAdd.Text = "Credit details"
        '
        'PanelAddCredit
        '
        Me.PanelAddCredit.Controls.Add(Me.ButtonCancelCredit)
        Me.PanelAddCredit.Controls.Add(Me.ButtonSaveNewCredit)
        Me.PanelAddCredit.Controls.Add(Me.Label8)
        Me.PanelAddCredit.Controls.Add(Me.Label7)
        Me.PanelAddCredit.Controls.Add(Me.TextBoxInterestAmount)
        Me.PanelAddCredit.Controls.Add(Me.TextBoxPrincipleAmount)
        Me.PanelAddCredit.Controls.Add(Me.ComboBoxCredits)
        Me.PanelAddCredit.Controls.Add(Me.Label6)
        Me.PanelAddCredit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAddCredit.Location = New System.Drawing.Point(3, 18)
        Me.PanelAddCredit.Name = "PanelAddCredit"
        Me.PanelAddCredit.Size = New System.Drawing.Size(666, 223)
        Me.PanelAddCredit.TabIndex = 0
        '
        'ButtonCancelCredit
        '
        Me.ButtonCancelCredit.Location = New System.Drawing.Point(96, 142)
        Me.ButtonCancelCredit.Name = "ButtonCancelCredit"
        Me.ButtonCancelCredit.Size = New System.Drawing.Size(75, 26)
        Me.ButtonCancelCredit.TabIndex = 36
        Me.ButtonCancelCredit.Text = "Cancel"
        Me.ButtonCancelCredit.UseVisualStyleBackColor = True
        '
        'ButtonSaveNewCredit
        '
        Me.ButtonSaveNewCredit.Location = New System.Drawing.Point(15, 142)
        Me.ButtonSaveNewCredit.Name = "ButtonSaveNewCredit"
        Me.ButtonSaveNewCredit.Size = New System.Drawing.Size(75, 26)
        Me.ButtonSaveNewCredit.TabIndex = 15
        Me.ButtonSaveNewCredit.Text = "Save"
        Me.ButtonSaveNewCredit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(161, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Interest Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(12, 67)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Principle Amount"
        '
        'TextBoxInterestAmount
        '
        Me.TextBoxInterestAmount.Enabled = False
        Me.TextBoxInterestAmount.Location = New System.Drawing.Point(164, 89)
        Me.TextBoxInterestAmount.Name = "TextBoxInterestAmount"
        Me.TextBoxInterestAmount.Size = New System.Drawing.Size(143, 22)
        Me.TextBoxInterestAmount.TabIndex = 33
        '
        'TextBoxPrincipleAmount
        '
        Me.TextBoxPrincipleAmount.Enabled = False
        Me.TextBoxPrincipleAmount.Location = New System.Drawing.Point(15, 89)
        Me.TextBoxPrincipleAmount.Name = "TextBoxPrincipleAmount"
        Me.TextBoxPrincipleAmount.Size = New System.Drawing.Size(143, 22)
        Me.TextBoxPrincipleAmount.TabIndex = 32
        '
        'ComboBoxCredits
        '
        Me.ComboBoxCredits.FormattingEnabled = True
        Me.ComboBoxCredits.Location = New System.Drawing.Point(15, 35)
        Me.ComboBoxCredits.Name = "ComboBoxCredits"
        Me.ComboBoxCredits.Size = New System.Drawing.Size(211, 21)
        Me.ComboBoxCredits.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(12, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Select Credit Type"
        '
        'PanelGridCredit
        '
        Me.PanelGridCredit.Controls.Add(Me.DataGridViewCustomerCredits)
        Me.PanelGridCredit.Location = New System.Drawing.Point(6, 18)
        Me.PanelGridCredit.Name = "PanelGridCredit"
        Me.PanelGridCredit.Size = New System.Drawing.Size(666, 223)
        Me.PanelGridCredit.TabIndex = 37
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridViewSecurity)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 277)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(413, 218)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Security Details"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridViewRepayments)
        Me.GroupBox6.Location = New System.Drawing.Point(431, 277)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(527, 219)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Payment Details"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.ExtendedTextBoxUsername)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.TextBoxNidPp)
        Me.GroupBox8.Controls.Add(Me.TextBoxGender)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.TextBoxPhoneNumber)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBox8.Controls.Add(Me.DateTimePickerBirthdate)
        Me.GroupBox8.Controls.Add(Me.LabelBirthdate)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(274, 244)
        Me.GroupBox8.TabIndex = 23
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Customer Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Username"
        '
        'ExtendedTextBoxUsername
        '
        Me.ExtendedTextBoxUsername.AutoValidate = False
        Me.ExtendedTextBoxUsername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtendedTextBoxUsername.ForeColor = System.Drawing.Color.Gray
        Me.ExtendedTextBoxUsername.IsPasswordField = False
        Me.ExtendedTextBoxUsername.Location = New System.Drawing.Point(15, 164)
        Me.ExtendedTextBoxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.ExtendedTextBoxUsername.MinimumValidLength = 0
        Me.ExtendedTextBoxUsername.Name = "ExtendedTextBoxUsername"
        Me.ExtendedTextBoxUsername.NullText = "Gender"
        Me.ExtendedTextBoxUsername.RegexListToValidateCSV = Nothing
        Me.ExtendedTextBoxUsername.Size = New System.Drawing.Size(115, 22)
        Me.ExtendedTextBoxUsername.TabIndex = 28
        Me.ExtendedTextBoxUsername.Text = "username"
        Me.ExtendedTextBoxUsername.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.ExtendedTextBoxUsername.TextValidColor = System.Drawing.Color.Honeydew
        '
        'TextBoxNidPp
        '
        Me.TextBoxNidPp.AutoValidate = False
        Me.TextBoxNidPp.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNidPp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNidPp.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxNidPp.IsPasswordField = False
        Me.TextBoxNidPp.Location = New System.Drawing.Point(13, 53)
        Me.TextBoxNidPp.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNidPp.MinimumValidLength = 0
        Me.TextBoxNidPp.Name = "TextBoxNidPp"
        Me.TextBoxNidPp.NullText = "Nid/Pp"
        Me.TextBoxNidPp.RegexListToValidateCSV = Nothing
        Me.TextBoxNidPp.Size = New System.Drawing.Size(115, 22)
        Me.TextBoxNidPp.TabIndex = 4
        Me.TextBoxNidPp.Text = "Nid/Pp"
        Me.TextBoxNidPp.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxNidPp.TextValidColor = System.Drawing.Color.Honeydew
        '
        'TextBoxGender
        '
        Me.TextBoxGender.AutoValidate = False
        Me.TextBoxGender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGender.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxGender.IsPasswordField = False
        Me.TextBoxGender.Location = New System.Drawing.Point(13, 107)
        Me.TextBoxGender.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxGender.MinimumValidLength = 0
        Me.TextBoxGender.Name = "TextBoxGender"
        Me.TextBoxGender.NullText = "Gender"
        Me.TextBoxGender.RegexListToValidateCSV = Nothing
        Me.TextBoxGender.Size = New System.Drawing.Size(115, 22)
        Me.TextBoxGender.TabIndex = 1
        Me.TextBoxGender.Text = "Gender"
        Me.TextBoxGender.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxGender.TextValidColor = System.Drawing.Color.Honeydew
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.AutoValidate = False
        Me.TextBoxPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhoneNumber.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxPhoneNumber.IsPasswordField = False
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(139, 164)
        Me.TextBoxPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPhoneNumber.MinimumValidLength = 0
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.NullText = "Phone Number"
        Me.TextBoxPhoneNumber.RegexListToValidateCSV = Nothing
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(115, 22)
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
        Me.TextBoxCustomerName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCustomerName.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxCustomerName.IsPasswordField = False
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(136, 53)
        Me.TextBoxCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCustomerName.MinimumValidLength = 0
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.NullText = "Customer name"
        Me.TextBoxCustomerName.RegexListToValidateCSV = Nothing
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(115, 22)
        Me.TextBoxCustomerName.TabIndex = 1
        Me.TextBoxCustomerName.Text = "CUSTOMER NAME"
        Me.TextBoxCustomerName.TextInvalidColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxCustomerName.TextValidColor = System.Drawing.Color.Honeydew
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAdd, Me.ModifyToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(961, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItemAdd
        '
        Me.ToolStripMenuItemAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCreditsToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.RepaymentDetailsToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd"
        Me.ToolStripMenuItemAdd.Size = New System.Drawing.Size(41, 20)
        Me.ToolStripMenuItemAdd.Text = "Add"
        '
        'AddCreditsToolStripMenuItem
        '
        Me.AddCreditsToolStripMenuItem.Name = "AddCreditsToolStripMenuItem"
        Me.AddCreditsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddCreditsToolStripMenuItem.Text = "Credit Details"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ModifyToolStripMenuItem.Text = "Security Details"
        '
        'RepaymentDetailsToolStripMenuItem
        '
        Me.RepaymentDetailsToolStripMenuItem.Name = "RepaymentDetailsToolStripMenuItem"
        Me.RepaymentDetailsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RepaymentDetailsToolStripMenuItem.Text = "Repayment Details"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ModifyToolStripMenuItem1
        '
        Me.ModifyToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectedCreditToolStripMenuItem, Me.SelectedSecurityToolStripMenuItem, Me.SelectedPaymentToolStripMenuItem, Me.SelectedCustomerToolStripMenuItem})
        Me.ModifyToolStripMenuItem1.Name = "ModifyToolStripMenuItem1"
        Me.ModifyToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.ModifyToolStripMenuItem1.Text = "Modify"
        '
        'SelectedCreditToolStripMenuItem
        '
        Me.SelectedCreditToolStripMenuItem.Name = "SelectedCreditToolStripMenuItem"
        Me.SelectedCreditToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SelectedCreditToolStripMenuItem.Text = "Selected Credit"
        '
        'SelectedSecurityToolStripMenuItem
        '
        Me.SelectedSecurityToolStripMenuItem.Name = "SelectedSecurityToolStripMenuItem"
        Me.SelectedSecurityToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SelectedSecurityToolStripMenuItem.Text = "Selected Security"
        '
        'SelectedPaymentToolStripMenuItem
        '
        Me.SelectedPaymentToolStripMenuItem.Name = "SelectedPaymentToolStripMenuItem"
        Me.SelectedPaymentToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SelectedPaymentToolStripMenuItem.Text = "Selected Payment"
        '
        'SelectedCustomerToolStripMenuItem
        '
        Me.SelectedCustomerToolStripMenuItem.Name = "SelectedCustomerToolStripMenuItem"
        Me.SelectedCustomerToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SelectedCustomerToolStripMenuItem.Text = "Selected Customer"
        '
        'ComboBoxCustomerSearch
        '
        Me.ComboBoxCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCustomerSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCustomerSearch.FormattingEnabled = True
        Me.ComboBoxCustomerSearch.Location = New System.Drawing.Point(1, 0)
        Me.ComboBoxCustomerSearch.Name = "ComboBoxCustomerSearch"
        Me.ComboBoxCustomerSearch.Size = New System.Drawing.Size(275, 28)
        Me.ComboBoxCustomerSearch.TabIndex = 1
        '
        'GroupBoxCreditDisplay
        '
        Me.GroupBoxCreditDisplay.Controls.Add(Me.PanelGridCredit)
        Me.GroupBoxCreditDisplay.Location = New System.Drawing.Point(286, 27)
        Me.GroupBoxCreditDisplay.Name = "GroupBoxCreditDisplay"
        Me.GroupBoxCreditDisplay.Size = New System.Drawing.Size(672, 244)
        Me.GroupBoxCreditDisplay.TabIndex = 25
        Me.GroupBoxCreditDisplay.TabStop = False
        Me.GroupBoxCreditDisplay.Text = "Credit details"
        '
        'CreditManagementView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 498)
        Me.Controls.Add(Me.GroupBoxCreditDisplay)
        Me.Controls.Add(Me.ComboBoxCustomerSearch)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBoxCreditDetailsAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditManagementView"
        Me.Tag = "CreditManagementViewAccess"
        Me.Text = "CreditManagementView"
        CType(Me.DataGridViewCustomerCredits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewRepayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxCreditDetailsAdd.ResumeLayout(False)
        Me.PanelAddCredit.ResumeLayout(False)
        Me.PanelAddCredit.PerformLayout()
        Me.PanelGridCredit.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxCreditDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPhoneNumber As ExtendedTextBox
    Friend WithEvents TextBoxNidPp As ExtendedTextBox
    Friend WithEvents TextBoxGender As ExtendedTextBox
    Friend WithEvents TextBoxCustomerName As ExtendedTextBox
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
    Friend WithEvents GroupBoxCreditDetailsAdd As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents ExtendedTextBoxUsername As ExtendedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelAddCredit As Panel
    Friend WithEvents ButtonCancelCredit As Button
    Friend WithEvents ButtonSaveNewCredit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxInterestAmount As TextBox
    Friend WithEvents TextBoxPrincipleAmount As TextBox
    Friend WithEvents ComboBoxCredits As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItemAdd As ToolStripMenuItem
    Friend WithEvents AddCreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents PrincipleAmount As DataGridViewTextBoxColumn
    Friend WithEvents InterestAmount As DataGridViewTextBoxColumn
    Friend WithEvents LastUpdated As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTimeStamp As DataGridViewTextBoxColumn
    Friend WithEvents RepaymentDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectedCreditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedSecurityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelGridCredit As Panel
    Friend WithEvents ComboBoxCustomerSearch As ComboBox
    Friend WithEvents GroupBoxCreditDisplay As GroupBox
End Class
