<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
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
        Me.regBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.firstName_TextBox = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.Label()
        Me.lastName_TextBox = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.username_TextBox = New System.Windows.Forms.TextBox()
        Me.userName = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.password_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'regBtn
        '
        Me.regBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regBtn.Location = New System.Drawing.Point(59, 192)
        Me.regBtn.Name = "regBtn"
        Me.regBtn.Size = New System.Drawing.Size(130, 42)
        Me.regBtn.TabIndex = 0
        Me.regBtn.Text = "Register"
        Me.regBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(195, 192)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(130, 42)
        Me.closeBtn.TabIndex = 1
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'firstName_TextBox
        '
        Me.firstName_TextBox.Location = New System.Drawing.Point(120, 112)
        Me.firstName_TextBox.Name = "firstName_TextBox"
        Me.firstName_TextBox.Size = New System.Drawing.Size(239, 20)
        Me.firstName_TextBox.TabIndex = 2
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(18, 112)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(96, 20)
        Me.firstName.TabIndex = 3
        Me.firstName.Text = "First Name"
        '
        'lastName_TextBox
        '
        Me.lastName_TextBox.Location = New System.Drawing.Point(120, 136)
        Me.lastName_TextBox.Name = "lastName_TextBox"
        Me.lastName_TextBox.Size = New System.Drawing.Size(239, 20)
        Me.lastName_TextBox.TabIndex = 4
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(19, 136)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(95, 20)
        Me.lastName.TabIndex = 5
        Me.lastName.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User Registration"
        '
        'username_TextBox
        '
        Me.username_TextBox.Location = New System.Drawing.Point(120, 64)
        Me.username_TextBox.Name = "username_TextBox"
        Me.username_TextBox.Size = New System.Drawing.Size(239, 20)
        Me.username_TextBox.TabIndex = 7
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.Location = New System.Drawing.Point(16, 64)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(91, 20)
        Me.userName.TabIndex = 8
        Me.userName.Text = "Username"
        Me.userName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(18, 88)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(86, 20)
        Me.password.TabIndex = 10
        Me.password.Text = "Password"
        '
        'password_TextBox
        '
        Me.password_TextBox.Location = New System.Drawing.Point(120, 88)
        Me.password_TextBox.Name = "password_TextBox"
        Me.password_TextBox.Size = New System.Drawing.Size(239, 20)
        Me.password_TextBox.TabIndex = 9
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 246)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.password_TextBox)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.username_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.lastName_TextBox)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.firstName_TextBox)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.regBtn)
        Me.Name = "registerForm"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents regBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents firstName_TextBox As TextBox
    Friend WithEvents firstName As Label
    Friend WithEvents lastName_TextBox As TextBox
    Friend WithEvents lastName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username_TextBox As TextBox
    Friend WithEvents userName As Label
    Friend WithEvents password As Label
    Friend WithEvents password_TextBox As TextBox
End Class
