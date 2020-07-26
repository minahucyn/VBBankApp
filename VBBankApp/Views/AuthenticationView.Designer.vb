<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class AuthenticationView
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuthenticationView))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LabelLockedAlert = New System.Windows.Forms.Label()
        Me.PanelAuth = New System.Windows.Forms.Panel()
        Me.PanelAnimation = New System.Windows.Forms.Panel()
        Me.PictureBoxAnimation = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAuth.SuspendLayout()
        Me.PanelAnimation.SuspendLayout()
        CType(Me.PictureBoxAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(175, 27)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(175, 84)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(177, 47)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 22)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(177, 104)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 22)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(200, 163)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(303, 163)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'LabelLockedAlert
        '
        Me.LabelLockedAlert.BackColor = System.Drawing.SystemColors.Control
        Me.LabelLockedAlert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLockedAlert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelLockedAlert.Location = New System.Drawing.Point(178, 128)
        Me.LabelLockedAlert.Name = "LabelLockedAlert"
        Me.LabelLockedAlert.Size = New System.Drawing.Size(219, 34)
        Me.LabelLockedAlert.TabIndex = 6
        Me.LabelLockedAlert.Text = "THE USER IS LOCKED! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLEASE CONTACT YOUR ADMIN."
        Me.LabelLockedAlert.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelAuth
        '
        Me.PanelAuth.Controls.Add(Me.UsernameTextBox)
        Me.PanelAuth.Controls.Add(Me.PasswordTextBox)
        Me.PanelAuth.Controls.Add(Me.LogoPictureBox)
        Me.PanelAuth.Controls.Add(Me.LabelLockedAlert)
        Me.PanelAuth.Controls.Add(Me.UsernameLabel)
        Me.PanelAuth.Controls.Add(Me.Cancel)
        Me.PanelAuth.Controls.Add(Me.PasswordLabel)
        Me.PanelAuth.Controls.Add(Me.OK)
        Me.PanelAuth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAuth.Location = New System.Drawing.Point(0, 0)
        Me.PanelAuth.Name = "PanelAuth"
        Me.PanelAuth.Size = New System.Drawing.Size(408, 196)
        Me.PanelAuth.TabIndex = 7
        '
        'PanelAnimation
        '
        Me.PanelAnimation.Controls.Add(Me.PictureBoxAnimation)
        Me.PanelAnimation.Location = New System.Drawing.Point(474, 0)
        Me.PanelAnimation.Name = "PanelAnimation"
        Me.PanelAnimation.Size = New System.Drawing.Size(408, 196)
        Me.PanelAnimation.TabIndex = 8
        '
        'PictureBoxAnimation
        '
        Me.PictureBoxAnimation.Location = New System.Drawing.Point(0, 29)
        Me.PictureBoxAnimation.Name = "PictureBoxAnimation"
        Me.PictureBoxAnimation.Size = New System.Drawing.Size(408, 139)
        Me.PictureBoxAnimation.TabIndex = 0
        Me.PictureBoxAnimation.TabStop = False
        '
        'AuthenticationView
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(408, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelAnimation)
        Me.Controls.Add(Me.PanelAuth)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AuthenticationView"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "AuthViewAccess"
        Me.Text = "AuthenticationView"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAuth.ResumeLayout(False)
        Me.PanelAuth.PerformLayout()
        Me.PanelAnimation.ResumeLayout(False)
        CType(Me.PictureBoxAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelLockedAlert As Label
    Friend WithEvents PanelAuth As Panel
    Friend WithEvents PanelAnimation As Panel
    Friend WithEvents PictureBoxAnimation As PictureBox
End Class
