Imports MySql.Data.MySqlClient

Public Class registerForm
    Dim dbConnect As MySqlConnection
    Dim dbCommand As MySqlCommand

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect = New MySqlConnection
        dbConnect.ConnectionString = "server=localhost;userid=root;password=;database=survey"

    End Sub

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        dbCommand = New MySqlCommand("INSERT INTO `user` (`username`, `password`, `first_name`, `last_name`) VALUES (@username, @password, @first, @last);", dbConnect)
        dbCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = username_TextBox.Text
        dbCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_TextBox.Text
        dbCommand.Parameters.Add("@first", MySqlDbType.VarChar).Value = firstName_TextBox.Text
        dbCommand.Parameters.Add("@last", MySqlDbType.VarChar).Value = lastName_TextBox.Text

        dbConnect.Open()
        If dbCommand.ExecuteNonQuery = 1 Then
            MessageBox.Show("Registration successful")
            Hide()
        Else
            MessageBox.Show("Invalid")
        End If


    End Sub

End Class