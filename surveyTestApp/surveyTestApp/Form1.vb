Imports MySql.Data.MySqlClient


Public Class Form1

    Dim dbConnect As New MySqlConnection("server=localhost;userid=root;password=;database=survey")
    Dim table As New DataTable()
    Dim qIndex As Integer = 0



    Public Sub showData(position As Integer)
        Dim cmd As New MySqlCommand(
            "SELECT     question_text
            FROM        survey.survey s
            JOIN        survey.questions q ON s.idsurvey = q.survey_id
            WHERE       idsurvey = 1
            ORDER BY    idquestions ASC", dbConnect)
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(table)

        TextBox1.Text = table.Rows(position)(0).ToString()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData(qIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        qIndex += 1
        If qIndex > table.Rows.Count() - 1 Then
            qIndex = table.Rows.Count() - 1
        End If
        showData(qIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        qIndex -= 1
        If qIndex < 0 Then
            qIndex = 0
        End If
        showData(qIndex)
    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    dbConnect = New MySqlConnection
    '    dbConnect.ConnectionString = connString
    '    dbConnect.Open()

    '    dbCommand = New MySqlCommand(
    '        "SELECT     question_text
    '        FROM        survey.survey s
    '        JOIN        survey.questions q ON s.idsurvey = q.survey_id
    '        WHERE       idsurvey = 1
    '        ORDER BY    idquestions ASC", dbConnect)

    '    Dim adapter As New MySqlDataAdapter(dbCommand)
    '    Dim table As New DataTable
    '    Dim setData As New DataSet

    '    dbConnect.Close()
    'End Sub
End Class
