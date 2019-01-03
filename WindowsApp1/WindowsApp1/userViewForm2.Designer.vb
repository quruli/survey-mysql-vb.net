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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.prevBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(160, 288)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(121, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Completely Disagree"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(160, 320)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Somewhat Disagree"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(160, 352)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Neither disagree, nor agree"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(352, 288)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(105, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Somewhat agree"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(352, 320)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Completely agree"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(352, 352)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(135, 17)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Don't know/No opinion"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'prevBtn
        '
        Me.prevBtn.Location = New System.Drawing.Point(216, 400)
        Me.prevBtn.Name = "prevBtn"
        Me.prevBtn.Size = New System.Drawing.Size(75, 23)
        Me.prevBtn.TabIndex = 11
        Me.prevBtn.Text = "Previous"
        Me.prevBtn.UseVisualStyleBackColor = True
        '
        'nextBtn
        '
        Me.nextBtn.Location = New System.Drawing.Point(320, 400)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(75, 23)
        Me.nextBtn.TabIndex = 12
        Me.nextBtn.Text = "Next"
        Me.nextBtn.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 15
        '
        'questionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.prevBtn)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.question_textbox)
        Me.Name = "questionForm"
        Me.Text = "Questions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents question_textbox As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents prevBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents logout As LinkLabel
    Friend WithEvents TextBox1 As TextBox
End Class
