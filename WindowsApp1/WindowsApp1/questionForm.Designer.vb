<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class questionForm
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
        Me.question_textbox = New System.Windows.Forms.TextBox()
        Me.logout = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'question_textbox
        '
        Me.question_textbox.Location = New System.Drawing.Point(16, 56)
        Me.question_textbox.Multiline = True
        Me.question_textbox.Name = "question_textbox"
        Me.question_textbox.ReadOnly = True
        Me.question_textbox.Size = New System.Drawing.Size(576, 216)
        Me.question_textbox.TabIndex = 4
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Location = New System.Drawing.Point(552, 8)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(40, 13)
        Me.logout.TabIndex = 14
        Me.logout.TabStop = True
        Me.logout.Text = "Logout"
        '
        'questionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 450)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.question_textbox)
        Me.Name = "questionForm"
        Me.Text = "Questions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents question_textbox As TextBox
    Friend WithEvents logout As LinkLabel
End Class
