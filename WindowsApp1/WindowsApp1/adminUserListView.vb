Imports MySql.Data.MySqlClient

Public Class adminUserListView
    Dim connect As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cb As MySqlCommandBuilder
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim bSource As BindingSource

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim view As DataView
        loadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        loadData()

        connect.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cb = New MySqlCommandBuilder(adapter)
        adapter.Update(table)

    End Sub

    Private Sub loadData()
        bSource = New BindingSource
        table = New DataTable
        adapter = New MySqlDataAdapter
        connect = New MySqlConnection
        connect.ConnectionString = "server=localhost;userid=root;password=;database=survey"
        connect.Open()
        Dim query As String = "SELECT * from survey.user where role = 'user' "
        cmd = New MySqlCommand(query, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        bSource.DataSource = table
        userGrid.DataSource = bSource
        adapter.Update(table)
    End Sub
End Class