<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminView
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
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.userBtn = New System.Windows.Forms.Button()
        Me.surveyBtn = New System.Windows.Forms.Button()
        Me.logoutLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.responseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Location = New System.Drawing.Point(8, 8)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(58, 13)
        Me.welcomeLabel.TabIndex = 0
        Me.welcomeLabel.Text = "Welcome, "
        '
        'userBtn
        '
        Me.userBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBtn.Location = New System.Drawing.Point(56, 96)
        Me.userBtn.Name = "userBtn"
        Me.userBtn.Size = New System.Drawing.Size(128, 40)
        Me.userBtn.TabIndex = 1
        Me.userBtn.Text = "Users"
        Me.userBtn.UseVisualStyleBackColor = True
        '
        'surveyBtn
        '
        Me.surveyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surveyBtn.Location = New System.Drawing.Point(344, 96)
        Me.surveyBtn.Name = "surveyBtn"
        Me.surveyBtn.Size = New System.Drawing.Size(128, 40)
        Me.surveyBtn.TabIndex = 3
        Me.surveyBtn.Text = "Surveys"
        Me.surveyBtn.UseVisualStyleBackColor = True
        '
        'logoutLinkLabel
        '
        Me.logoutLinkLabel.AutoSize = True
        Me.logoutLinkLabel.Location = New System.Drawing.Point(480, 8)
        Me.logoutLinkLabel.Name = "logoutLinkLabel"
        Me.logoutLinkLabel.Size = New System.Drawing.Size(40, 13)
        Me.logoutLinkLabel.TabIndex = 4
        Me.logoutLinkLabel.TabStop = True
        Me.logoutLinkLabel.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Home"
        '
        'responseBtn
        '
        Me.responseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.responseBtn.Location = New System.Drawing.Point(200, 96)
        Me.responseBtn.Name = "responseBtn"
        Me.responseBtn.Size = New System.Drawing.Size(128, 40)
        Me.responseBtn.TabIndex = 2
        Me.responseBtn.Text = "Responses"
        Me.responseBtn.UseVisualStyleBackColor = True
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 198)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logoutLinkLabel)
        Me.Controls.Add(Me.surveyBtn)
        Me.Controls.Add(Me.responseBtn)
        Me.Controls.Add(Me.userBtn)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Name = "adminView"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welcomeLabel As Label
    Friend WithEvents userBtn As Button
    Friend WithEvents surveyBtn As Button
    Friend WithEvents logoutLinkLabel As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents responseBtn As Button
End Class
