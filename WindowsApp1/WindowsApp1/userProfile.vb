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

        'cast string to int for query
        getId = Convert.ToInt32(userIdTextBox.Text)



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        questionForm.Show()
        Hide()
    End Sub
End Class