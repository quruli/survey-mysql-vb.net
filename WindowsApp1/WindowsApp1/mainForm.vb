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

            'check roles/authentication
            If count = 1 Then
                If userRole = "user" Then
                    questionForm.userIdLabel.Text = getId
                    Hide()
                    questionForm.Show()
                Else
                    adminView.Show()
                End If
            Else
                MessageBox.Show("Incorrect username/password.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            username.Text = ""
            password.Text = ""
            conn.Dispose()
        End Try
        conn.Close()
    End Sub

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        registerForm.Show()
    End Sub

End Class
