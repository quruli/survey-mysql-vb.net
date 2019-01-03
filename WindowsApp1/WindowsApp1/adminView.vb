Public Class adminView
    Private Sub userBtn_Click(sender As Object, e As EventArgs) Handles userBtn.Click
        adminUserListView.Show()
    End Sub

    Private Sub responseBtn_Click(sender As Object, e As EventArgs) Handles responseBtn.Click
        adminFormResponseView.Show()
    End Sub
End Class