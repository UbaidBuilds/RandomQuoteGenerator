Public Class frmHome
    Private Sub btnMotivational_Click(sender As Object, e As EventArgs) Handles btnMotivational.Click
        Dim f As New frmMotivational()
        f.Show()
    End Sub

    Private Sub btnJokes_Click(sender As Object, e As EventArgs) Handles btnJokes.Click
        Dim f As New frmJokes()
        f.Show()
    End Sub

    Private Sub btnFacts_Click(sender As Object, e As EventArgs) Handles btnFacts.Click
        Dim f As New frmFacts()
        f.Show()
    End Sub
End Class
