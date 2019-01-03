'Imports System.Data.SqlClient

'Public Class VBNET_SQL_Navigation

'        Dim connection As New SqlConnection("Server= SAMSNG-PC; Database = TestDB; Integrated Security = true")
'        Dim index As Integer = 0
'        Dim table As New DataTable()


'        Private Sub VBNET_SQL_Navigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'            showData(index)

'        End Sub

'        Public Sub showData(position As Integer)

'            Dim command As New SqlCommand("select * from Users", connection)
'            Dim adapter As New SqlDataAdapter(command)

'            adapter.Fill(table)

'            TextBoxID.Text = table.Rows(position)(0).ToString()
'            TextBoxFN.Text = table.Rows(position)(1).ToString()
'            TextBoxLN.Text = table.Rows(position)(2).ToString()
'            TextBoxAGE.Text = table.Rows(position)(3).ToString()

'        End Sub


'        Private Sub BTN_FIRST_Click(sender As Object, e As EventArgs) Handles BTN_FIRST.Click

'            index = 0
'            showData(index)

'        End Sub

'        Private Sub BTN_NEXT_Click(sender As Object, e As EventArgs) Handles BTN_NEXT.Click

'            index += 1
'            If index > table.Rows.Count() - 1 Then

'                index = table.Rows.Count() - 1

'            End If
'            showData(index)

'        End Sub

'        Private Sub BTN_PREVIOUS_Click(sender As Object, e As EventArgs) Handles BTN_PREVIOUS.Click

'            index -= 1
'            If index < 0 Then
'                index = 0
'            End If
'            showData(index)

'        End Sub

'        Private Sub BTN_LAST_Click(sender As Object, e As EventArgs) Handles BTN_LAST.Click

'            index = table.Rows.Count() - 1
'            showData(index)

'        End Sub
'End Class