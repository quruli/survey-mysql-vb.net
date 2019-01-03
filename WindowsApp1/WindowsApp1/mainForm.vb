Imports MySql.Data.MySqlClient

Public Class mainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim conn As MySqlConnection
        Dim cmd As MySqlCommand

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=survey"
        conn.Open()

        Try
            cmd = New MySqlCommand("SELECT * FROM user where username = @username and password = @password", conn)
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.Text
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text

            Dim read As MySqlDataReader
            read = cmd.ExecuteReader()

            Dim count As Integer
            Dim userRole As String
            Dim getId As Integer
            userRole = ""
            getId = 0
            count = 0

            'fetch role
            While read.Read()
                count = count + 1
                userRole = read.GetString("role")
                getId = read.GetString("iduser")
            End While

            'check roles
            If count = 1 Then
                If userRole = "user" Then
                    userViewForm.Show()
                Else
                    adminForm.Show()
                End If
            End If

            Dim form As New questionForm
            form.UserId = getId

            'Dim dbAdapter As New MySqlDataAdapter(dbCommand)
            ''Dim readData As MySqlDataReader
            'Dim dbTable As New DataTable()


            'dbAdapter.Fill(dbTable)
            'If dbTable.Rows.Count = 0 Then
            '    MessageBox.Show("Invalid Username or Password")
            'Else
            '    userViewForm.Show()
            '    Hide()
            'End If

            ''get id based on username
            'dbCommand2 = New MySqlCommand("select iduser from user where username = @username", dbConnect)
            'dbCommand2.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.Text

            'Dim getUserId As Integer
            'getUserId = Integer.Parse(dbCommand2.ExecuteScalar)
            'MessageBox.Show(getUserId)

            'Dim form As New questionForm
            'form.UserId = getUserId

            ''Dim dbAdapter2 As New MySqlDataAdapter(dbCommand2)
            ''readData = dbCommand2.ExecuteReader
            ''If readData.Read Then
            ''    getUserId = readData.GetValue(1)
            ''End If
            ''pass value to UserId in questionForm

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            conn.Dispose()
        End Try
        conn.Close()
    End Sub

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        registerForm.Show()
    End Sub

End Class
