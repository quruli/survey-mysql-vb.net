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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.surveyListBox = New System.Windows.Forms.ListBox()
        Me.yesBtn = New System.Windows.Forms.Button()
        Me.noBtn = New System.Windows.Forms.Button()
        Me.userIdLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'question_textbox
        '
        Me.question_textbox.Location = New System.Drawing.Point(8, 136)
        Me.question_textbox.Multiline = True
        Me.question_textbox.Name = "question_textbox"
        Me.question_textbox.ReadOnly = True
        Me.question_textbox.Size = New System.Drawing.Size(448, 208)
        Me.question_textbox.TabIndex = 4
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.Location = New System.Drawing.Point(392, 16)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(65, 20)
        Me.logout.TabIndex = 14
        Me.logout.TabStop = True
        Me.logout.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Home"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(312, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 20)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "|"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "|"
        '
        'surveyListBox
        '
        Me.surveyListBox.FormattingEnabled = True
        Me.surveyListBox.Location = New System.Drawing.Point(8, 56)
        Me.surveyListBox.Name = "surveyListBox"
        Me.surveyListBox.Size = New System.Drawing.Size(448, 69)
        Me.surveyListBox.TabIndex = 28
        '
        'yesBtn
        '
        Me.yesBtn.Location = New System.Drawing.Point(104, 360)
        Me.yesBtn.Name = "yesBtn"
        Me.yesBtn.Size = New System.Drawing.Size(112, 32)
        Me.yesBtn.TabIndex = 29
        Me.yesBtn.Text = "Yes"
        Me.yesBtn.UseVisualStyleBackColor = True
        '
        'noBtn
        '
        Me.noBtn.Location = New System.Drawing.Point(232, 360)
        Me.noBtn.Name = "noBtn"
        Me.noBtn.Size = New System.Drawing.Size(112, 32)
        Me.noBtn.TabIndex = 30
        Me.noBtn.Text = "No"
        Me.noBtn.UseVisualStyleBackColor = True
        '
        'userIdLabel
        '
        Me.userIdLabel.AutoSize = True
        Me.userIdLabel.Location = New System.Drawing.Point(8, 8)
        Me.userIdLabel.Name = "userIdLabel"
        Me.userIdLabel.Size = New System.Drawing.Size(39, 13)
        Me.userIdLabel.TabIndex = 31
        Me.userIdLabel.Text = "User #"
        '
        'questionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 409)
        Me.Controls.Add(Me.userIdLabel)
        Me.Controls.Add(Me.noBtn)
        Me.Controls.Add(Me.yesBtn)
        Me.Controls.Add(Me.surveyListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.question_textbox)
        Me.Name = "questionForm"
        Me.Text = "Questions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents question_textbox As TextBox
    Friend WithEvents logout As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents surveyListBox As ListBox
    Friend WithEvents yesBtn As Button
    Friend WithEvents noBtn As Button
    Friend WithEvents userIdLabel As Label
End Class
