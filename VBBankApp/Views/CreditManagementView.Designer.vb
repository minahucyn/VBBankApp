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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageCredits = New System.Windows.Forms.TabPage()
        Me.DataGridViewCustomerCredits = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipleDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipleOutstanding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestOutstanding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Outstanding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewSecurity = New System.Windows.Forms.DataGridView()
        Me.SecId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Security = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Worth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ButtonCustomerSearch = New System.Windows.Forms.Button()
        Me.ButtonCustomerAddSave = New System.Windows.Forms.Button()
        Me.ButtonCustomerModify = New System.Windows.Forms.Button()
        Me.ButtonModifyCreditDetails = New System.Windows.Forms.Button()
        Me.ButtonAddPayments = New System.Windows.Forms.Button()
        Me.ButtonAddCreditDetails = New System.Windows.Forms.Button()
        Me.ButtonAddSecurityDetails = New System.Windows.Forms.Button()
        Me.ButtonModifySecurity = New System.Windows.Forms.Button()
        Me.ButtonModifyPayments = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPageCreditSecurity = New System.Windows.Forms.TabPage()
        Me.ExtendedGroupBoxPaymentFunctions = New VBBankApp.ExtendedGroupBox()
        Me.ExtendedGroupBoxCustomerFunctions = New VBBankApp.ExtendedGroupBox()
        Me.TextBox1 = New VBBankApp.ExtendedTextBox()
        Me.TextBoxPhoneNumber = New VBBankApp.ExtendedTextBox()
        Me.TextBoxAge = New VBBankApp.ExtendedTextBox()
        Me.TextBoxGender = New VBBankApp.ExtendedTextBox()
        Me.TextBoxBirthdate = New VBBankApp.ExtendedTextBox()
        Me.TextBoxNidPp = New VBBankApp.ExtendedTextBox()
        Me.ExtendedGroupBox1 = New VBBankApp.ExtendedGroupBox()
        Me.ExtendedGroupBoxCreditFunctions = New VBBankApp.ExtendedGroupBox()
        Me.ExtendedGroupBoxSecurityFunctions = New VBBankApp.ExtendedGroupBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageCredits.SuspendLayout()
        CType(Me.DataGridViewCustomerCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPageCreditSecurity.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBoxPhoneNumber)
        Me.Panel1.Controls.Add(Me.TextBoxAge)
        Me.Panel1.Controls.Add(Me.TextBoxGender)
        Me.Panel1.Controls.Add(Me.TextBoxBirthdate)
        Me.Panel1.Controls.Add(Me.TextBoxNidPp)
        Me.Panel1.Location = New System.Drawing.Point(9, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 174)
        Me.Panel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageCredits)
        Me.TabControl1.Location = New System.Drawing.Point(338, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(814, 203)
        Me.TabControl1.TabIndex = 7
        '
        'TabPageCredits
        '
        Me.TabPageCredits.Controls.Add(Me.DataGridViewCustomerCredits)
        Me.TabPageCredits.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCredits.Name = "TabPageCredits"
        Me.TabPageCredits.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCredits.Size = New System.Drawing.Size(806, 177)
        Me.TabPageCredits.TabIndex = 0
        Me.TabPageCredits.Text = "Credit Management"
        Me.TabPageCredits.UseVisualStyleBackColor = True
        '
        'DataGridViewCustomerCredits
        '
        Me.DataGridViewCustomerCredits.AllowUserToAddRows = False
        Me.DataGridViewCustomerCredits.AllowUserToDeleteRows = False
        Me.DataGridViewCustomerCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewCustomerCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerCredits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Description, Me.PrincipleDue, Me.InterestDue, Me.TotalDue, Me.PrincipleOutstanding, Me.InterestOutstanding, Me.Outstanding, Me.CreditAmount})
        Me.DataGridViewCustomerCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewCustomerCredits.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewCustomerCredits.Name = "DataGridViewCustomerCredits"
        Me.DataGridViewCustomerCredits.ReadOnly = True
        Me.DataGridViewCustomerCredits.Size = New System.Drawing.Size(800, 171)
        Me.DataGridViewCustomerCredits.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 41
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 85
        '
        'PrincipleDue
        '
        Me.PrincipleDue.DataPropertyName = "PrincipleDue"
        Me.PrincipleDue.HeaderText = "Principle Due"
        Me.PrincipleDue.Name = "PrincipleDue"
        Me.PrincipleDue.ReadOnly = True
        Me.PrincipleDue.Width = 95
        '
        'InterestDue
        '
        Me.InterestDue.DataPropertyName = "InterestDue"
        Me.InterestDue.HeaderText = "Interest Due"
        Me.InterestDue.Name = "InterestDue"
        Me.InterestDue.ReadOnly = True
        Me.InterestDue.Width = 90
        '
        'TotalDue
        '
        Me.TotalDue.DataPropertyName = "TotalDue"
        Me.TotalDue.HeaderText = "Total Due"
        Me.TotalDue.Name = "TotalDue"
        Me.TotalDue.ReadOnly = True
        Me.TotalDue.Width = 79
        '
        'PrincipleOutstanding
        '
        Me.PrincipleOutstanding.DataPropertyName = "PrincipleOutstanding"
        Me.PrincipleOutstanding.HeaderText = "Principle Outstanding"
        Me.PrincipleOutstanding.Name = "PrincipleOutstanding"
        Me.PrincipleOutstanding.ReadOnly = True
        Me.PrincipleOutstanding.Width = 121
        '
        'InterestOutstanding
        '
        Me.InterestOutstanding.DataPropertyName = "InterestOutstanding"
        Me.InterestOutstanding.HeaderText = "Inerest Outstanding"
        Me.InterestOutstanding.Name = "InterestOutstanding"
        Me.InterestOutstanding.ReadOnly = True
        Me.InterestOutstanding.Width = 114
        '
        'Outstanding
        '
        Me.Outstanding.DataPropertyName = "Outstanding"
        Me.Outstanding.HeaderText = "Outstanding"
        Me.Outstanding.Name = "Outstanding"
        Me.Outstanding.ReadOnly = True
        Me.Outstanding.Width = 89
        '
        'CreditAmount
        '
        Me.CreditAmount.DataPropertyName = "CreditAmount"
        Me.CreditAmount.HeaderText = "Credit Amount"
        Me.CreditAmount.Name = "CreditAmount"
        Me.CreditAmount.ReadOnly = True
        Me.CreditAmount.Width = 90
        '
        'DataGridViewSecurity
        '
        Me.DataGridViewSecurity.AllowUserToAddRows = False
        Me.DataGridViewSecurity.AllowUserToDeleteRows = False
        Me.DataGridViewSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSecurity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SecId, Me.Security, Me.CreditId, Me.Worth})
        Me.DataGridViewSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSecurity.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewSecurity.Name = "DataGridViewSecurity"
        Me.DataGridViewSecurity.ReadOnly = True
        Me.DataGridViewSecurity.Size = New System.Drawing.Size(313, 170)
        Me.DataGridViewSecurity.TabIndex = 0
        '
        'SecId
        '
        Me.SecId.DataPropertyName = "Id"
        Me.SecId.HeaderText = "Id"
        Me.SecId.Name = "SecId"
        Me.SecId.ReadOnly = True
        '
        'Security
        '
        Me.Security.DataPropertyName = "Description"
        Me.Security.HeaderText = "Security"
        Me.Security.Name = "Security"
        Me.Security.ReadOnly = True
        '
        'CreditId
        '
        Me.CreditId.DataPropertyName = "CreditId"
        Me.CreditId.HeaderText = "Credit Id"
        Me.CreditId.Name = "CreditId"
        Me.CreditId.ReadOnly = True
        Me.CreditId.Visible = False
        '
        'Worth
        '
        Me.Worth.DataPropertyName = "Worth"
        Me.Worth.HeaderText = "Worth"
        Me.Worth.Name = "Worth"
        Me.Worth.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(800, 170)
        Me.DataGridView2.TabIndex = 0
        '
        'ButtonCustomerSearch
        '
        Me.ButtonCustomerSearch.Location = New System.Drawing.Point(154, 455)
        Me.ButtonCustomerSearch.Name = "ButtonCustomerSearch"
        Me.ButtonCustomerSearch.Size = New System.Drawing.Size(75, 26)
        Me.ButtonCustomerSearch.TabIndex = 9
        Me.ButtonCustomerSearch.Text = "Search (F2)"
        Me.ButtonCustomerSearch.UseVisualStyleBackColor = True
        '
        'ButtonCustomerAddSave
        '
        Me.ButtonCustomerAddSave.Location = New System.Drawing.Point(235, 455)
        Me.ButtonCustomerAddSave.Name = "ButtonCustomerAddSave"
        Me.ButtonCustomerAddSave.Size = New System.Drawing.Size(86, 26)
        Me.ButtonCustomerAddSave.TabIndex = 10
        Me.ButtonCustomerAddSave.Text = "Add/Save (F3)"
        Me.ButtonCustomerAddSave.UseVisualStyleBackColor = True
        '
        'ButtonCustomerModify
        '
        Me.ButtonCustomerModify.Location = New System.Drawing.Point(327, 455)
        Me.ButtonCustomerModify.Name = "ButtonCustomerModify"
        Me.ButtonCustomerModify.Size = New System.Drawing.Size(75, 26)
        Me.ButtonCustomerModify.TabIndex = 11
        Me.ButtonCustomerModify.Text = "Modify (F4)"
        Me.ButtonCustomerModify.UseVisualStyleBackColor = True
        '
        'ButtonModifyCreditDetails
        '
        Me.ButtonModifyCreditDetails.Location = New System.Drawing.Point(509, 455)
        Me.ButtonModifyCreditDetails.Name = "ButtonModifyCreditDetails"
        Me.ButtonModifyCreditDetails.Size = New System.Drawing.Size(75, 26)
        Me.ButtonModifyCreditDetails.TabIndex = 12
        Me.ButtonModifyCreditDetails.Text = "Modify (F6)"
        Me.ButtonModifyCreditDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonModifyCreditDetails.UseVisualStyleBackColor = True
        '
        'ButtonAddPayments
        '
        Me.ButtonAddPayments.Location = New System.Drawing.Point(801, 452)
        Me.ButtonAddPayments.Name = "ButtonAddPayments"
        Me.ButtonAddPayments.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAddPayments.TabIndex = 13
        Me.ButtonAddPayments.Text = "Add (F9)"
        Me.ButtonAddPayments.UseVisualStyleBackColor = True
        '
        'ButtonAddCreditDetails
        '
        Me.ButtonAddCreditDetails.Location = New System.Drawing.Point(428, 455)
        Me.ButtonAddCreditDetails.Name = "ButtonAddCreditDetails"
        Me.ButtonAddCreditDetails.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAddCreditDetails.TabIndex = 14
        Me.ButtonAddCreditDetails.Text = "Add (F5)"
        Me.ButtonAddCreditDetails.UseVisualStyleBackColor = True
        '
        'ButtonAddSecurityDetails
        '
        Me.ButtonAddSecurityDetails.Location = New System.Drawing.Point(616, 452)
        Me.ButtonAddSecurityDetails.Name = "ButtonAddSecurityDetails"
        Me.ButtonAddSecurityDetails.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAddSecurityDetails.TabIndex = 15
        Me.ButtonAddSecurityDetails.Text = "Add (F7)"
        Me.ButtonAddSecurityDetails.UseVisualStyleBackColor = True
        '
        'ButtonModifySecurity
        '
        Me.ButtonModifySecurity.Location = New System.Drawing.Point(699, 453)
        Me.ButtonModifySecurity.Name = "ButtonModifySecurity"
        Me.ButtonModifySecurity.Size = New System.Drawing.Size(75, 26)
        Me.ButtonModifySecurity.TabIndex = 16
        Me.ButtonModifySecurity.Text = "Modify (F8)"
        Me.ButtonModifySecurity.UseVisualStyleBackColor = True
        '
        'ButtonModifyPayments
        '
        Me.ButtonModifyPayments.Location = New System.Drawing.Point(882, 452)
        Me.ButtonModifyPayments.Name = "ButtonModifyPayments"
        Me.ButtonModifyPayments.Size = New System.Drawing.Size(75, 26)
        Me.ButtonModifyPayments.TabIndex = 17
        Me.ButtonModifyPayments.Text = "Modify (F10)"
        Me.ButtonModifyPayments.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Location = New System.Drawing.Point(338, 212)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(814, 202)
        Me.TabControl2.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(806, 176)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Repayments For Selected Credit"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPageCreditSecurity)
        Me.TabControl3.Location = New System.Drawing.Point(9, 212)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(327, 202)
        Me.TabControl3.TabIndex = 22
        '
        'TabPageCreditSecurity
        '
        Me.TabPageCreditSecurity.Controls.Add(Me.DataGridViewSecurity)
        Me.TabPageCreditSecurity.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCreditSecurity.Name = "TabPageCreditSecurity"
        Me.TabPageCreditSecurity.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCreditSecurity.Size = New System.Drawing.Size(319, 176)
        Me.TabPageCreditSecurity.TabIndex = 0
        Me.TabPageCreditSecurity.Text = "Selected Credit Security"
        Me.TabPageCreditSecurity.UseVisualStyleBackColor = True
        '
        'ExtendedGroupBoxPaymentFunctions
        '
        Me.ExtendedGroupBoxPaymentFunctions.Caption = "Payments Details Fuctions"
        Me.ExtendedGroupBoxPaymentFunctions.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBoxPaymentFunctions.Location = New System.Drawing.Point(793, 424)
        Me.ExtendedGroupBoxPaymentFunctions.Name = "ExtendedGroupBoxPaymentFunctions"
        Me.ExtendedGroupBoxPaymentFunctions.Size = New System.Drawing.Size(168, 67)
        Me.ExtendedGroupBoxPaymentFunctions.TabIndex = 20
        '
        'ExtendedGroupBoxCustomerFunctions
        '
        Me.ExtendedGroupBoxCustomerFunctions.Caption = "Customer Functions"
        Me.ExtendedGroupBoxCustomerFunctions.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBoxCustomerFunctions.Location = New System.Drawing.Point(139, 424)
        Me.ExtendedGroupBoxCustomerFunctions.Name = "ExtendedGroupBoxCustomerFunctions"
        Me.ExtendedGroupBoxCustomerFunctions.Size = New System.Drawing.Size(272, 67)
        Me.ExtendedGroupBoxCustomerFunctions.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(12, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NullText = "Customer name"
        Me.TextBox1.Size = New System.Drawing.Size(254, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Customer name"
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(12, 143)
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.NullText = "Phone Number"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxPhoneNumber.TabIndex = 2
        Me.TextBoxPhoneNumber.Text = "Phone Number"
        '
        'TextBoxAge
        '
        Me.TextBoxAge.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxAge.Location = New System.Drawing.Point(12, 65)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.NullText = "Age"
        Me.TextBoxAge.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxAge.TabIndex = 1
        Me.TextBoxAge.Text = "Age"
        '
        'TextBoxGender
        '
        Me.TextBoxGender.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxGender.Location = New System.Drawing.Point(12, 91)
        Me.TextBoxGender.Name = "TextBoxGender"
        Me.TextBoxGender.NullText = "Gender"
        Me.TextBoxGender.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxGender.TabIndex = 1
        Me.TextBoxGender.Text = "Gender"
        '
        'TextBoxBirthdate
        '
        Me.TextBoxBirthdate.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxBirthdate.Location = New System.Drawing.Point(12, 117)
        Me.TextBoxBirthdate.Name = "TextBoxBirthdate"
        Me.TextBoxBirthdate.NullText = "Birthdate"
        Me.TextBoxBirthdate.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxBirthdate.TabIndex = 3
        Me.TextBoxBirthdate.Text = "Birthdate"
        '
        'TextBoxNidPp
        '
        Me.TextBoxNidPp.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxNidPp.ForeColor = System.Drawing.Color.Gray
        Me.TextBoxNidPp.Location = New System.Drawing.Point(12, 13)
        Me.TextBoxNidPp.Name = "TextBoxNidPp"
        Me.TextBoxNidPp.NullText = "Nid/Pp"
        Me.TextBoxNidPp.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxNidPp.TabIndex = 4
        Me.TextBoxNidPp.Text = "Nid/Pp"
        '
        'ExtendedGroupBox1
        '
        Me.ExtendedGroupBox1.Caption = "Customer Details"
        Me.ExtendedGroupBox1.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.ExtendedGroupBox1.Name = "ExtendedGroupBox1"
        Me.ExtendedGroupBox1.Size = New System.Drawing.Size(326, 203)
        Me.ExtendedGroupBox1.TabIndex = 2
        '
        'ExtendedGroupBoxCreditFunctions
        '
        Me.ExtendedGroupBoxCreditFunctions.Caption = "Credit Details Fuctions"
        Me.ExtendedGroupBoxCreditFunctions.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBoxCreditFunctions.Location = New System.Drawing.Point(417, 424)
        Me.ExtendedGroupBoxCreditFunctions.Name = "ExtendedGroupBoxCreditFunctions"
        Me.ExtendedGroupBoxCreditFunctions.Size = New System.Drawing.Size(182, 67)
        Me.ExtendedGroupBoxCreditFunctions.TabIndex = 18
        '
        'ExtendedGroupBoxSecurityFunctions
        '
        Me.ExtendedGroupBoxSecurityFunctions.Caption = "Security Details Fuctions"
        Me.ExtendedGroupBoxSecurityFunctions.CaptionAlignment = VBBankApp.ExtendedGroupBox.Alignment.Center
        Me.ExtendedGroupBoxSecurityFunctions.Location = New System.Drawing.Point(605, 424)
        Me.ExtendedGroupBoxSecurityFunctions.Name = "ExtendedGroupBoxSecurityFunctions"
        Me.ExtendedGroupBoxSecurityFunctions.Size = New System.Drawing.Size(182, 67)
        Me.ExtendedGroupBoxSecurityFunctions.TabIndex = 19
        '
        'CreditManagementView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 496)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.ButtonModifyPayments)
        Me.Controls.Add(Me.ButtonAddPayments)
        Me.Controls.Add(Me.ExtendedGroupBoxPaymentFunctions)
        Me.Controls.Add(Me.ButtonModifySecurity)
        Me.Controls.Add(Me.ButtonAddSecurityDetails)
        Me.Controls.Add(Me.ButtonAddCreditDetails)
        Me.Controls.Add(Me.ButtonModifyCreditDetails)
        Me.Controls.Add(Me.ButtonCustomerModify)
        Me.Controls.Add(Me.ButtonCustomerAddSave)
        Me.Controls.Add(Me.ButtonCustomerSearch)
        Me.Controls.Add(Me.ExtendedGroupBoxCustomerFunctions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ExtendedGroupBox1)
        Me.Controls.Add(Me.ExtendedGroupBoxCreditFunctions)
        Me.Controls.Add(Me.ExtendedGroupBoxSecurityFunctions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditManagementView"
        Me.Tag = "CreditManagementViewAccess"
        Me.Text = "CreditManagementView"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageCredits.ResumeLayout(False)
        CType(Me.DataGridViewCustomerCredits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPageCreditSecurity.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxPhoneNumber As ExtendedTextBox
    Friend WithEvents TextBoxBirthdate As ExtendedTextBox
    Friend WithEvents TextBoxNidPp As ExtendedTextBox
    Friend WithEvents TextBoxGender As ExtendedTextBox
    Friend WithEvents TextBoxAge As ExtendedTextBox
    Friend WithEvents TextBox1 As ExtendedTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExtendedGroupBox1 As ExtendedGroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageCredits As TabPage
    Friend WithEvents ExtendedGroupBoxCustomerFunctions As ExtendedGroupBox
    Friend WithEvents ButtonCustomerSearch As Button
    Friend WithEvents ButtonCustomerAddSave As Button
    Friend WithEvents ButtonCustomerModify As Button
    Friend WithEvents ButtonModifyCreditDetails As Button
    Friend WithEvents ButtonAddPayments As Button
    Friend WithEvents ButtonAddCreditDetails As Button
    Friend WithEvents ButtonAddSecurityDetails As Button
    Friend WithEvents ButtonModifySecurity As Button
    Friend WithEvents ButtonModifyPayments As Button
    Friend WithEvents ExtendedGroupBoxCreditFunctions As ExtendedGroupBox
    Friend WithEvents ExtendedGroupBoxSecurityFunctions As ExtendedGroupBox
    Friend WithEvents ExtendedGroupBoxPaymentFunctions As ExtendedGroupBox
    Friend WithEvents DataGridViewCustomerCredits As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents PrincipleDue As DataGridViewTextBoxColumn
    Friend WithEvents InterestDue As DataGridViewTextBoxColumn
    Friend WithEvents TotalDue As DataGridViewTextBoxColumn
    Friend WithEvents PrincipleOutstanding As DataGridViewTextBoxColumn
    Friend WithEvents InterestOutstanding As DataGridViewTextBoxColumn
    Friend WithEvents Outstanding As DataGridViewTextBoxColumn
    Friend WithEvents CreditAmount As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewSecurity As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SecId As DataGridViewTextBoxColumn
    Friend WithEvents Security As DataGridViewTextBoxColumn
    Friend WithEvents CreditId As DataGridViewTextBoxColumn
    Friend WithEvents Worth As DataGridViewTextBoxColumn
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPageCreditSecurity As TabPage
End Class
