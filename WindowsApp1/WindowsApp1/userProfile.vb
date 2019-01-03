Imports MySql.Data.MySqlClient

Public Class userProfile
    Dim cmd As MySqlCommand
    Dim conn As MySqlConnection
    Dim getId As Integer

    'log out
    'show mainForm
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        conn.Close()
        Hide()
        mainForm.Show()
    End Sub

    Private Sub userProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=survey"
        conn.Open()



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        questionForm.Show()
        Hide()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click

        'convert string to int for query
        getId = Convert.ToInt32(userIdTextBox.Text)

        'needs multiple condition to avoid erasing data in the table
        'for fixing
        cmd = New MySqlCommand("UPDATE 
                                    `survey`.`user` 
                                SET 
                                    `first_name`=@first, `last_name`=@last, `password`=@pw 
                                WHERE 
                                    `iduser`=@id;", conn)
        cmd.Parameters.Add("@first", MySqlDbType.VarChar).Value = firstNameTextBox.Text
        cmd.Parameters.Add("@last", MySqlDbType.VarChar).Value = lastNameTextBox.Text
        cmd.Parameters.Add("@pw", MySqlDbType.VarChar).Value = passwordTextBox.Text
        cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = getId

        If cmd.ExecuteNonQuery = 1 Then
            MessageBox.Show("Update successful")
        Else
            MessageBox.Show("Try again")
        End If
    End Sub
End Class