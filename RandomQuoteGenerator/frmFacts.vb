Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class frmFacts

    Private Async Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        lblFact.Text = "Fetching fact..."
        Try
            Dim factText As String = Await GetRandomFact()
            lblFact.Text = factText
        Catch ex As Exception
            lblFact.Text = "Error: " & ex.Message
        End Try
    End Sub

    Private Async Function GetRandomFact() As Task(Of String)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("https://thefact.space/random")
            response.EnsureSuccessStatusCode()

            Dim json As String = Await response.Content.ReadAsStringAsync()

            ' Try parse as object first
            Try
                Dim data As JObject = JObject.Parse(json)
                ' Look for "fact" or "text" key
                If data("fact") IsNot Nothing Then
                    Return data("fact").ToString()
                ElseIf data("text") IsNot Nothing Then
                    Return data("text").ToString()
                Else
                    Return "Could not find a fact in the response."
                End If
            Catch
                ' If parsing as object fails, maybe it's an array
                Try
                    Dim dataArray As JArray = JArray.Parse(json)
                    If dataArray.Count > 0 Then
                        Dim first = dataArray(0)
                        If first("fact") IsNot Nothing Then
                            Return first("fact").ToString()
                        ElseIf first("text") IsNot Nothing Then
                            Return first("text").ToString()
                        End If
                    End If
                Catch
                    Return "Could not parse the fact response."
                End Try
            End Try

            Return "No fact found."
        End Using
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class
