<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabledListBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ListBoxLabel = New System.Windows.Forms.Label()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxLabel
        '
        Me.ListBoxLabel.AutoSize = True
        Me.ListBoxLabel.Location = New System.Drawing.Point(3, 0)
        Me.ListBoxLabel.Name = "ListBoxLabel"
        Me.ListBoxLabel.Size = New System.Drawing.Size(67, 13)
        Me.ListBoxLabel.TabIndex = 0
        Me.ListBoxLabel.Text = "ListBoxLabel"
        '
        'ListBox
        '
        Me.ListBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(0, 16)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(497, 95)
        Me.ListBox.TabIndex = 1
        '
        'LabledListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.ListBoxLabel)
        Me.Name = "LabledListBox"
        Me.Size = New System.Drawing.Size(497, 111)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxLabel As Label
    Friend WithEvents ListBox As ListBox
End Class
