Public Class LoginPage
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ViewPage.Show()
    End Sub

    Private Sub linkaccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaccount.LinkClicked
        CreateAccount.Show()
    End Sub
End Class
