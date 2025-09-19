Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class frmMotivational

    ' Run once when the form loads
    Private Sub frmMotivational_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure TLS 1.2 for HTTPS requests
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    End Sub

    ' When the user clicks Generate, fetch a quote from ZenQuotes
    Private Async Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        lblQuote.Text = "Fetching quote..."
        Try
            Dim quoteText As String = Await GetZenQuote()
            lblQuote.Text = quoteText
        Catch ex As Exception
            Dim innerMsg As String = If(ex.InnerException IsNot Nothing,
                                        " (" & ex.InnerException.Message & ")", "")
            lblQuote.Text = "Error: " & ex.Message & innerMsg
        End Try
    End Sub

    ' Fetch a random quote from ZenQuotes
    Private Async Function GetZenQuote() As Task(Of String)
        Using client As New HttpClient()
            client.Timeout = TimeSpan.FromSeconds(10)

            Dim response As HttpResponseMessage = Await client.GetAsync("https://zenquotes.io/api/quotes/random")
            response.EnsureSuccessStatusCode()

            Dim json As String = Await response.Content.ReadAsStringAsync()

            ' ZenQuotes returns an array with one object
            Dim data As JArray = JArray.Parse(json)
            Dim quoteObj As JObject = data(0)

            Dim quote As String = quoteObj("q").ToString()
            Dim author As String = quoteObj("a").ToString()

            Return $"""{quote}"" — {author}"
        End Using
    End Function

    ' Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class
