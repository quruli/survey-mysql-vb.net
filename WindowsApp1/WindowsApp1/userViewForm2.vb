Imports MySql.Data.MySqlClient

Public Class questionForm
    Dim dbConnect As New MySqlConnection("server=localhost;userid=root;password=;database=survey")
    Dim index As Integer = 0
    Dim setOptionId As Integer = 0
    Dim table As New DataTable()

    Public Property SurveyId As Integer
    Public Property UserId As Integer

    Public Sub showData(position As Integer)
        Dim cmd As New MySqlCommand(
            "SELECT     question_text
            FROM        survey.survey s
            JOIN        survey.questions q ON s.idsurvey = q.survey_id
            WHERE       idsurvey = @id
            ORDER BY    idquestions ASC", dbConnect)
        cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = SurveyId
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(table)

        question_textbox.Text = table.Rows(position)(0).ToString()
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        'Dim cmd As New MySqlCommand("
        '    insert into     responses
        '    (user_iduser, survey_idsurvey, questions_idquestions, options_idoptions)
        '    VALUES (@userid, @surveyid, @questionid, @optionid)", dbConnect)
        'cmd.Parameters.Add("@userid", MySqlDbType.Int16).Value = UserId
        'cmd.Parameters.Add("@surveyid", MySqlDbType.Int16).Value = SurveyId
        'cmd.Parameters.Add("@questionid", MySqlDbType.Int16).Value = UserId

        'If RadioButton1.Checked = True Then
        '    setOptionId = 1
        'ElseIf RadioButton2.Checked = True Then
        '    setOptionId = 2
        'ElseIf RadioButton3.Checked = True Then
        '    setOptionId = 3
        'ElseIf RadioButton4.Checked = True Then
        '    setOptionId = 4
        'ElseIf RadioButton5.Checked = True Then
        '    setOptionId = 5
        'ElseIf RadioButton6.Checked = True Then
        '    setOptionId = 6
        'End If
        'While index <= table.Rows.Count()
        index += 1
            If index > table.Rows.Count() - 1 Then
                index = table.Rows.Count() - 1
            End If
            showData(index)
        'End While

        'MessageBox.Show(index)
    End Sub

    Private Sub prevBtn_Click(sender As Object, e As EventArgs) Handles prevBtn.Click
        index -= 1
        If index < 0 Then
            index = 0
        End If


        showData(index)
    End Sub

    Private Sub questionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(UserId)
        showData(index)
    End Sub
End Class