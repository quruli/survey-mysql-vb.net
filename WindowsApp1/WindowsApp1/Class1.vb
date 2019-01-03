'Public Class Class1
'    Private Sub extra()
'        Dim getQuestionIndexQuery As String
'        getQuestionIndexQuery = "select count(*) from survey.question where idsurvey = @idsurvey"

'        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM YOURTABLENAME ", con)
'        Dim i As Integer = cmd.ExecuteScalar()
'        cmd = Nothing
'        con.Close()
'        txt_count.Text = i

'        Try
'            dbConnect.Open()
'            Dim query As String
'            query = "Select * from survey.survey"
'            dbCommand = New MySqlCommand(query, dbConnect)
'            readData.SelectCommand = dbCommand
'            readData.Fill(dbDataSet)
'            bSource.DataSource = dbDataSet
'            DataGridView1.DataSource = bSource
'            readData.Update(dbDataSet)

'            dbConnect.Close()
'        Catch ex As MySqlException
'            MessageBox.Show(ex.Message)
'        Finally
'            dbConnect.Dispose()
'        End Try

'        Dim qtnQuery As String
'        qtnQuery = "SELECT `q_text` FROM question where title.survey = @survey_title"
'        dbCommand.Parameters.Add("@survey_title", MySqlDbType.VarChar).Value = ComboBox1.SelectedItem
'        dbCommand = New MySqlCommand(qtnQuery, dbConnect)

'        readData = dbCommand.ExecuteReader
'        While readData.Read
'            Dim getTitle = readData.GetString("title")
'            MessageBox.Show(getTitle)
'        End While

'        Dim qtxtQuery As String
'        qtxtQuery = "SELECT q_text FROM survey.question where idsurvey = @id"

'    End Sub

'    Private Sub loadTable()
'        dbConnect = New MySqlConnection
'        dbConnect.ConnectionString = "server=localhost;userid=root;password=;database=survey"

'        Try
'            dbConnect.Open()
'            Dim queryStr As String
'            queryStr = "select `title` from survey.survey"
'            dbCommand = New MySqlCommand(queryStr, dbConnect)
'            readData = dbCommand.ExecuteReader
'            While readData.Read
'                Dim getTitle = readData.GetString("title")
'                ComboBox1.Items.Add(getTitle)
'            End While
'            dbConnect.Close()
'        Catch ex As MySqlException
'            MessageBox.Show(ex.Message)
'        Finally
'            dbConnect.Dispose()
'        End Try

'    End Sub

'    Private Sub loadSurvey()
'        dbConnect = New MySqlConnection
'        dbConnect.ConnectionString = "server=localhost;userid=root;password=;database=survey"
'        dbConnect.Open()

'        Try
'            'get index for the next command
'            Dim getSurveyIndex As Integer
'            getSurveyIndex = ComboBox1.SelectedIndex

'            'query every idquestion from @idsurvey
'            dbCommand = New MySqlCommand("SELECT idquestion FROM survey.question where idsurvey = @idsurvey", dbConnect)
'            dbCommand.Parameters.Add("@idsurvey", MySqlDbType.Int16).Value = getSurveyIndex

'            Dim dbAdapter As New MySqlDataAdapter(dbCommand)
'            Dim table As New DataTable
'            Dim row As DataRow

'            Dim getQuestionId As Integer
'            getQuestionId = 1 'get 1st key of the question then show one by one


'            dbAdapter.Fill(table)
'            'row = table.Rows.Find(getQuestionId)
'            'If row IsNot Nothing Then 'check if row != null
'            dbCommand = New MySqlCommand("SELECT q_text FROM survey.question where idquestion = @idquestion", dbConnect)
'            dbCommand.Parameters.Add("idquestion", MySqlDbType.Int16).Value = getQuestionId
'            readData = dbCommand.ExecuteReader
'            While readData.Read
'                Dim getQ_text = readData.GetString("q_text")
'                TextBox1.Text = getQ_text

'            End While
'            'End If

'            dbConnect.Close()
'        Catch ex As MySqlException
'            MessageBox.Show(ex.Message)
'        Finally
'            dbConnect.Dispose()
'        End Try
'    End Sub


'    Private Sub surveyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        loadTable()
'    End Sub

'    Private Sub selectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click
'        loadSurvey()
'    End Sub
'End Class
