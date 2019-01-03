<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userViewForm
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
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.surveyListView = New System.Windows.Forms.DataGridView()
        Me.selectBtn = New System.Windows.Forms.Button()
        Me.viewProfile = New System.Windows.Forms.LinkLabel()
        Me.logout = New System.Windows.Forms.LinkLabel()
        Me.surveyid_textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.surveyListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchTxtBox
        '
        Me.searchTxtBox.Location = New System.Drawing.Point(24, 32)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(272, 20)
        Me.searchTxtBox.TabIndex = 0
        '
        'surveyListView
        '
        Me.surveyListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.surveyListView.Location = New System.Drawing.Point(24, 64)
        Me.surveyListView.Name = "surveyListView"
        Me.surveyListView.Size = New System.Drawing.Size(272, 192)
        Me.surveyListView.TabIndex = 1
        '
        'selectBtn
        '
        Me.selectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectBtn.Location = New System.Drawing.Point(224, 264)
        Me.selectBtn.Name = "selectBtn"
        Me.selectBtn.Size = New System.Drawing.Size(72, 24)
        Me.selectBtn.TabIndex = 2
        Me.selectBtn.Text = "Load"
        Me.selectBtn.UseVisualStyleBackColor = True
        '
        'viewProfile
        '
        Me.viewProfile.AutoSize = True
        Me.viewProfile.Location = New System.Drawing.Point(184, 8)
        Me.viewProfile.Name = "viewProfile"
        Me.viewProfile.Size = New System.Drawing.Size(53, 13)
        Me.viewProfile.TabIndex = 4
        Me.viewProfile.TabStop = True
        Me.viewProfile.Text = "My Profile"
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Location = New System.Drawing.Point(256, 8)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(40, 13)
        Me.logout.TabIndex = 5
        Me.logout.TabStop = True
        Me.logout.Text = "Logout"
        '
        'surveyid_textbox
        '
        Me.surveyid_textbox.Location = New System.Drawing.Point(160, 264)
        Me.surveyid_textbox.Name = "surveyid_textbox"
        Me.surveyid_textbox.Size = New System.Drawing.Size(56, 20)
        Me.surveyid_textbox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter Survey ID"
        '
        'userViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(322, 328)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.surveyid_textbox)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.viewProfile)
        Me.Controls.Add(Me.selectBtn)
        Me.Controls.Add(Me.surveyListView)
        Me.Controls.Add(Me.searchTxtBox)
        Me.Name = "userViewForm"
        Me.Text = "Home"
        CType(Me.surveyListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents surveyListView As DataGridView
    Friend WithEvents selectBtn As Button
    Friend WithEvents viewProfile As LinkLabel
    Friend WithEvents logout As LinkLabel
    Friend WithEvents surveyid_textbox As TextBox
    Friend WithEvents Label1 As Label
End Class
