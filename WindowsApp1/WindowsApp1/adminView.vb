Public Class adminView
    Private Sub userBtn_Click(sender As Object, e As EventArgs) Handles userBtn.Click
        adminUserListView.Show()
        Hide()
    End Sub

    Private Sub responseBtn_Click(sender As Object, e As EventArgs) Handles responseBtn.Click
        adminFormResponseView.Show()
        Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Application.Exit()

    End Sub

    Private Sub surveyBtn_Click(sender As Object, e As EventArgs) Handles surveyBtn.Click
        adminSurveyView.Show()
        Hide()
    End Sub
End Class