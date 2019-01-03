Imports MySql.Data.MySqlClient

Public Class questionForm
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String
    Dim connString As String
    Dim read As MySqlDataReader
    Public Property SurveyId As Integer
    Public Property UserId As Integer

    Private Sub questionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "server=localhost;userid=root;password=;database=survey"
        conn = New MySqlConnection
        conn.ConnectionString = connString
        conn.Open()

        query = "select * from survey.survey"



        Try
            cmd = New MySqlCommand(query, conn)
            read = cmd.ExecuteReader()
            surveyListBox.Items.Clear()


            While (read.Read())
                surveyListBox.Items.Add(read.GetString("title"))
            End While
            read.Close()
        Catch ex As Exception

            conn.Close()
        End Try

    End Sub

    Private Sub surveyListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles surveyListBox.SelectedIndexChanged
        connString = "server=localhost;userid=root;password=;database=survey"
        conn = New MySqlConnection
        conn.ConnectionString = connString
        conn.Open()

        query = "select * from survey.survey where title='" & surveyListBox.Text & "'"

        Try
            cmd = New MySqlCommand(query, conn)
            read = cmd.ExecuteReader()
            Dim getDesc As String
            getDesc = ""

            While (read.Read())
                question_textbox.Text = read.GetString("description")
            End While

        Catch ex As Exception

        End Try

    End Sub

    Private Sub logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logout.LinkClicked
        conn.Dispose()
        conn.Close()
        Hide()
        mainForm.Show()
    End Sub
End Class