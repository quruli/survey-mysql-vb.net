<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.regBtn = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.user_idLabel = New System.Windows.Forms.Label()
        Me.first_nameLabel = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(55, 159)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(130, 47)
        Me.loginBtn.TabIndex = 0
        Me.loginBtn.Text = "Log in"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mina", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome!"
        '
        'regBtn
        '
        Me.regBtn.Location = New System.Drawing.Point(191, 159)
        Me.regBtn.Name = "regBtn"
        Me.regBtn.Size = New System.Drawing.Size(130, 47)
        Me.regBtn.TabIndex = 2
        Me.regBtn.Text = "Register"
        Me.regBtn.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(136, 80)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(187, 20)
        Me.username.TabIndex = 3
        '
        'user_idLabel
        '
        Me.user_idLabel.AutoSize = True
        Me.user_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_idLabel.Location = New System.Drawing.Point(40, 80)
        Me.user_idLabel.Name = "user_idLabel"
        Me.user_idLabel.Size = New System.Drawing.Size(83, 20)
        Me.user_idLabel.TabIndex = 4
        Me.user_idLabel.Text = "Username"
        '
        'first_nameLabel
        '
        Me.first_nameLabel.AutoSize = True
        Me.first_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_nameLabel.Location = New System.Drawing.Point(47, 120)
        Me.first_nameLabel.Name = "first_nameLabel"
        Me.first_nameLabel.Size = New System.Drawing.Size(78, 20)
        Me.first_nameLabel.TabIndex = 6
        Me.first_nameLabel.Text = "Password"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(134, 120)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(187, 20)
        Me.password.TabIndex = 5
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 233)
        Me.Controls.Add(Me.first_nameLabel)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.user_idLabel)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.regBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginBtn)
        Me.Name = "mainForm"
        Me.Text = "Survey by MRosario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents regBtn As Button
    Friend WithEvents username As TextBox
    Friend WithEvents user_idLabel As Label
    Friend WithEvents first_nameLabel As Label
    Friend WithEvents password As TextBox
End Class
