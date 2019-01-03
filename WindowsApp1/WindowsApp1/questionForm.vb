Imports MySql.Data.MySqlClient

Public Class questionForm
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String
    Dim connString As String
    Dim read As MySqlDataReader

    'get necessary IDs
    Dim getSurveyId As Integer
    Dim getUserId As Integer
    Dim setOptionId As Integer

    Private Sub questionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "server=localhost;userid=root;password=;database=survey"
        conn = New MySqlConnection
        conn.ConnectionString = connString
        conn.Open()

        query = "select * from survey.survey"

        'get userIdLabel data as Int
        getUserId = Convert.ToInt32(userIdLabel.Text)

        'displays list of surveys
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

        'get data of surveyId and userId
        Try
            cmd = New MySqlCommand(query, conn)
            read = cmd.ExecuteReader()
            Dim getDesc As String
            getDesc = ""

            While (read.Read())
                'get question desc
                question_textbox.Text = read.GetString("description")

                'get surveyId
                getSurveyId = read.GetInt32("idsurvey")
            End While
            read.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logout.LinkClicked
        conn.Dispose()
        conn.Close()
        Hide()
        mainForm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Hide()
        'pass userId to userProfile userId Textbox
        userProfile.userIdTextBox.Text = userIdLabel.Text
        userProfile.Show()
    End Sub

    Private Sub yesBtn_Click(sender As Object, e As EventArgs) Handles yesBtn.Click
        'set 1 for YES
        setOptionId = 1

        connString = "server=localhost;userid=root;password=;database=survey"
        conn = New MySqlConnection
        conn.ConnectionString = connString
        conn.Open()

        'check if item is selected
        If surveyListBox.Text = "" Then
            MessageBox.Show("Please select a survey.")
        Else
            query = "INSERT INTO 
                    `survey`.`responses` (`user_iduser`, `survey_idsurvey`, `options_idoptions`) 
                VALUES (@userid, @surveyid, @optionid);"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@userid", MySqlDbType.Int32).Value = getUserId
            cmd.Parameters.Add("@surveyid", MySqlDbType.Int32).Value = getSurveyId
            cmd.Parameters.Add("@optionid", MySqlDbType.Int32).Value = setOptionId

            If cmd.ExecuteNonQuery = 1 Then
                MessageBox.Show("Answer saved")
            End If

        End If
    End Sub

    Private Sub noBtn_Click(sender As Object, e As EventArgs) Handles noBtn.Click
        'set 2 for NO
        setOptionId = 2

        connString = "server=localhost;userid=root;password=;database=survey"
        conn = New MySqlConnection
        conn.ConnectionString = connString
        conn.Open()

        'check if item is selected
        If surveyListBox.Text = "" Then
            MessageBox.Show("Please select a survey.")
        Else
            query = "INSERT INTO 
                    `survey`.`responses` (`user_iduser`, `survey_idsurvey`, `options_idoptions`) 
                VALUES (@userid, @surveyid, @optionid);"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@userid", MySqlDbType.Int32).Value = getUserId
            cmd.Parameters.Add("@surveyid", MySqlDbType.Int32).Value = getSurveyId
            cmd.Parameters.Add("@optionid", MySqlDbType.Int32).Value = setOptionId

            If cmd.ExecuteNonQuery = 1 Then
                MessageBox.Show("Answer saved")
            End If
        End If
    End Sub
End Class