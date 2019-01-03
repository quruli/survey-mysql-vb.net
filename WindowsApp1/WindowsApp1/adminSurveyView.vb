Imports MySql.Data.MySqlClient
Public Class adminSurveyView

    Dim connect As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cb As MySqlCommandBuilder
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim bSource As BindingSource

    Private Sub adminSurveyView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()

    End Sub

    Private Sub loadData()
        bSource = New BindingSource
        table = New DataTable
        adapter = New MySqlDataAdapter
        connect = New MySqlConnection
        connect.ConnectionString = "server=localhost;userid=root;password=;database=survey"
        connect.Open()
        Dim query As String = "SELECT * from survey.survey"
        cmd = New MySqlCommand(query, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        bSource.DataSource = table
        userGrid.DataSource = bSource
        adapter.Update(table)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Hide()
        adminView.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        connect.Close()
        Hide()
        mainForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class