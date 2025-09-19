Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class frmJokes

    ' Ensure TLS for HTTPS requests
    Private Sub frmJokes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    End Sub

    ' Fetch a random joke when Generate is clicked
    Private Async Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        lblJoke.Text = "Fetching joke..."
        Try
            Dim jokeText As String = Await GetRandomJoke()
            lblJoke.Text = jokeText
        Catch ex As Exception
            Dim innerMsg As String = If(ex.InnerException IsNot Nothing,
                                        " (" & ex.InnerException.Message & ")", "")
            lblJoke.Text = "Error: " & ex.Message & innerMsg
        End Try
    End Sub

    ' Call the joke API
    Private Async Function GetRandomJoke() As Task(Of String)
        Using client As New HttpClient()
            client.Timeout = TimeSpan.FromSeconds(10)

            Dim response As HttpResponseMessage = Await client.GetAsync("https://official-joke-api.appspot.com/random_joke")
            response.EnsureSuccessStatusCode()

            Dim json As String = Await response.Content.ReadAsStringAsync()
            Dim data As JObject = JObject.Parse(json)

            Dim setup As String = data("setup").ToString()
            Dim punchline As String = data("punchline").ToString()

            Return setup & Environment.NewLine & Environment.NewLine & punchline
        End Using
    End Function

    ' Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class
