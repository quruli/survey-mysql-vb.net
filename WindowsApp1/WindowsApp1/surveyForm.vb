Imports MySql.Data.MySqlClient

Public Class userViewForm
    Dim dbConnect As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim readData As MySqlDataReader
    Dim dbDataSet As New DataTable
    Dim connString As String = "server=localhost;userid=root;password=;database=survey"
    Dim query As String

    Private Sub userViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect = New MySqlConnection
        dbConnect.ConnectionString = connString

        'declarations
        Dim adapter As New MySqlDataAdapter
        Dim bSource As New BindingSource

        dbConnect.Open()
        query = "select title, description from survey.survey"
        dbCommand = New MySqlCommand(query, dbConnect)
        adapter.SelectCommand = dbCommand
        adapter.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        surveyListView.DataSource = bSource
        adapter.Update(dbDataSet)


        dbConnect.Close()

    End Sub

    Private Sub searchTxtBox_TextChanged(sender As Object, e As EventArgs) Handles searchTxtBox.TextChanged
        Dim dataView As New DataView(dbDataSet)
        'dataView.RowFilter = String.Format("title like '% " & searchTxtBox.Text & " %'")
        dataView.RowFilter = String.Format("title like '%{0}%'", searchTxtBox.Text)
        surveyListView.DataSource = dataView
    End Sub



    Private Sub selectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click
        Dim getSurveyId As Integer
        getSurveyId = Integer.Parse(surveyid_textbox.Text)

        Dim form2 As New questionForm
        form2.SurveyId = getSurveyId
        form2.Show()
        'getSurveyId.surveyId = surveyid_textbox.Text()
        Hide()
    End Sub

End Class