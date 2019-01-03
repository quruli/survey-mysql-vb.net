<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminUserListView
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
        Me.userGrid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.homeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.logoutLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.userGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userGrid
        '
        Me.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userGrid.Location = New System.Drawing.Point(8, 80)
        Me.userGrid.Name = "userGrid"
        Me.userGrid.Size = New System.Drawing.Size(832, 264)
        Me.userGrid.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(600, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 39)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Load Table"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(728, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 39)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Update Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'homeLinkLabel
        '
        Me.homeLinkLabel.AutoSize = True
        Me.homeLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLinkLabel.Location = New System.Drawing.Point(704, 16)
        Me.homeLinkLabel.Name = "homeLinkLabel"
        Me.homeLinkLabel.Size = New System.Drawing.Size(56, 20)
        Me.homeLinkLabel.TabIndex = 16
        Me.homeLinkLabel.TabStop = True
        Me.homeLinkLabel.Text = "Home"
        '
        'logoutLinkLabel
        '
        Me.logoutLinkLabel.AutoSize = True
        Me.logoutLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLinkLabel.Location = New System.Drawing.Point(776, 16)
        Me.logoutLinkLabel.Name = "logoutLinkLabel"
        Me.logoutLinkLabel.Size = New System.Drawing.Size(65, 20)
        Me.logoutLinkLabel.TabIndex = 17
        Me.logoutLinkLabel.TabStop = True
        Me.logoutLinkLabel.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(760, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "User Information"
        '
        'adminUserListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 411)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logoutLinkLabel)
        Me.Controls.Add(Me.homeLinkLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.userGrid)
        Me.Name = "adminUserListView"
        Me.Text = "User List"
        CType(Me.userGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userGrid As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents homeLinkLabel As LinkLabel
    Friend WithEvents logoutLinkLabel As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
