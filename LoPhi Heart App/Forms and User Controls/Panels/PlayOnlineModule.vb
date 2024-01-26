Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Threading
Imports ScottPlot
Imports System.Text

Public Module PlayOnlineModule
    'Private ReadOnly _plot As FormsPlot
    'Private ReadOnly _CepstrumFrequency As Double()
    'Private ReadOnly _CepstrumData As Double()
    'Private _HighestCepstrum As Double = 0

    Public httpClient As HttpClient = New HttpClient()
    Public sessionKey As String = ""
    Public userId As String
    Public siteURL As String = "http://metacafebliss.com/MultiplayerHeartBeat" '66.29.131.108:5000
    ' Add cancellationTokenSource field to the class
    Public cancellationTokenSource As CancellationTokenSource

    Public Class ConnectResponse
        Public Property errorResponse As String
    End Class

    Public Sub renableWithMessage(Optional msg As String = "")
        ' Cancel the running tasks
        cancellationTokenSource.Cancel()

        ' Wait for the tasks to complete
        Dim updateMessagesTask As Task = Task.Run(Sub() UpdateMessages(cancellationTokenSource.Token))
        Dim updateGraphGraphicsTask As Task = Task.Run(Sub() UpdateGraphGraphics(cancellationTokenSource.Token))
        Task.WaitAll(updateMessagesTask, updateGraphGraphicsTask)

        'Enable Buttons
        sessionKey = ""
        ECG_MainForm.Label1.Text = "No Session Created"
        ECG_MainForm.btnJoinSession.Enabled = True
        ECG_MainForm.btnCreateSession.Enabled = True
        If Not msg = "" Then ECG_MainForm.ChatBox.AppendText(msg & Environment.NewLine)
    End Sub
    Public Sub updateBtnDisabled(Optional msg As String = "")
        cancellationTokenSource = New CancellationTokenSource()
        ECG_MainForm.btnJoinSession.Enabled = False
        ECG_MainForm.btnCreateSession.Enabled = False
        If Not msg = "" Then ECG_MainForm.ChatBox.AppendText(msg & Environment.NewLine)
    End Sub

    Public Async Sub SendMessage()
        If sessionKey = "" Then Return
        Try
            Dim message As String = ECG_MainForm.messageTxt.Text
            ECG_MainForm.ChatBox.AppendText($"{userId}:  {message}{Environment.NewLine}")
            ECG_MainForm.messageTxt.Text = ""

            Dim response As HttpResponseMessage = Await httpClient.PostAsync($"{siteURL}/send_message/{sessionKey}?user_id={userId}", New StringContent(JsonConvert.SerializeObject(New Dictionary(Of String, String) From {{"message", message}}), Encoding.UTF8, "application/json"))
            Dim jsonString As String = Await response.Content.ReadAsStringAsync()
            Dim jsonToken As JToken = JToken.Parse(jsonString)

            If jsonToken("error") IsNot Nothing Then
                ECG_MainForm.ChatBox.AppendText($"Error: {jsonToken("error")}{Environment.NewLine}")
            End If

            If Not response.StatusCode = HttpStatusCode.OK Then
                renableWithMessage("Failed to send message. Please Try rejoining Session.")
            End If
        Catch ex As Exception
            renableWithMessage("Failed to send message. Please Try rejoining Session.")
        End Try
    End Sub

    Private lastMessageTimestamp As Double = 0
    Public Async Sub UpdateMessages(cancellationToken As CancellationToken)
        If sessionKey = "" Then Return

        Try
            While True
                If cancellationToken.IsCancellationRequested Then Exit While
                Try
                    Dim response As HttpResponseMessage = Await httpClient.GetAsync($"{siteURL}/get_messages/{sessionKey}?user_id={userId}")

                    If response.StatusCode = HttpStatusCode.OK Then
                        Dim jsonString As String = Await response.Content.ReadAsStringAsync()
                        Dim jsonToken As JToken = JToken.Parse(jsonString)
                        ' Check if the JSON token is an object and has an error key
                        If TypeOf jsonToken Is JObject AndAlso jsonToken("error") IsNot Nothing Then
                            renableWithMessage($"Error: {jsonToken("error")}")
                        Else
                            Dim messages As List(Of Dictionary(Of String, String)) = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(jsonString)
                            For Each msg In messages
                                Dim messageTimestamp As Double = CDbl(msg("timestamp"))
                                Dim senderId As String = msg("user_id")
                                ' Append only new messages to the ChatBox and exclude messages from the current user
                                If messageTimestamp > lastMessageTimestamp AndAlso Not senderId.Equals(userId) Then
                                    ECG_MainForm.ChatBox.AppendText($"{senderId}: {msg("message")}{Environment.NewLine}")
                                    lastMessageTimestamp = messageTimestamp
                                End If
                            Next
                        End If
                    Else
                        renableWithMessage("Failed loading messages. Please Try rejoining Session.")
                    End If
                    Await Task.Delay(200)
                Catch ex As Exception
                    renableWithMessage("Failed loading messages. Please Try rejoining Session.")
                End Try
            End While
        Catch ex As Exception
            renableWithMessage("Failed loading messages. Please Try rejoining Session.")
        End Try
    End Sub

    Dim userColorDict As New Dictionary(Of String, Color)
    Public Async Sub UpdateGraphGraphics(cancellationToken As CancellationToken)
        If sessionKey = "" Then Return
        Try
            While True
                If cancellationToken.IsCancellationRequested Then Exit While
                Try
                    Dim response As HttpResponseMessage = Await httpClient.GetAsync($"{siteURL}/get_graphs/{sessionKey}?user_id={userId}")

                    If response.StatusCode = HttpStatusCode.OK Then
                        Dim jsonString As String = Await response.Content.ReadAsStringAsync()
                        Dim jsonToken As JToken = JToken.Parse(jsonString)

                        ' Check if the JSON token is an object and has an error key
                        If TypeOf jsonToken Is JObject AndAlso jsonToken("error") IsNot Nothing Then
                            ECG_MainForm.ChatBox.AppendText($"Error: {jsonToken("error")}")
                        Else
                            Dim graphs As Dictionary(Of String, Dictionary(Of String, String)) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Dictionary(Of String, String)))(jsonString)
                            ECG_MainForm.PlayOnlineGraph.Plot.Clear()
                            Try
                                For Each user In graphs.Keys
                                    Dim Player As Dictionary(Of String, String) = graphs(user)
                                    ' Process the graph data for the user
                                    Dim json As String = Player("graph")
                                    Dim values As Double()() = JsonConvert.DeserializeObject(Of Double()())(json)
                                    Dim dataX As Double() = values(0)
                                    Dim dataY As Double() = values(1)
                                    'If normalizeCB.Checked Then NormalizeData(dataY)
                                    'NormalizeData(dataY)

                                    ' Check if user ID is already in dictionary, if not, generate a new color
                                    Dim userColor As Color
                                    If userColorDict.ContainsKey(user) Then
                                        userColor = userColorDict(user)
                                    Else
                                        userColor = GetRandomColor()
                                        userColorDict.Add(user, userColor)
                                    End If

                                    ' Plot scatter lines with the user's color
                                    ECG_MainForm.PlayOnlineGraph.Plot.AddScatterLines(dataX, dataY, userColor)

                                    ' Add tooltip for user's maximum data point
                                    Dim YmaxIndex As Integer = Array.IndexOf(dataY, dataY.Max)
                                    Dim tt2 As ScottPlot.Plottable.Tooltip
                                    tt2 = ECG_MainForm.PlayOnlineGraph.Plot.AddTooltip(user, dataX(YmaxIndex), dataY(YmaxIndex))
                                    tt2.Font.Name = "Comic Sans MS"
                                    tt2.Font.Bold = True
                                Next

                            Catch ex As Exception
                                Console.Write(ex.ToString)
                            End Try
                            If ECG_MainForm.AutoScaleOnline Then
                                ECG_MainForm.PlayOnlineGraph.Plot.AxisAuto()
                            Else
                                ECG_MainForm.PlayOnlineGraph.Plot.SetAxisLimitsY(ECG_MainForm.CepstrumHeight2TB.Value, ECG_MainForm.CepstrumHeight1TB.Value)
                            End If
                            ECG_MainForm.PlayOnlineGraph.Refresh()
                        End If
                    Else
                        renableWithMessage("Failed loading Graphs. Please Try rejoining Session.")
                    End If

                    Await Task.Delay(860)
                Catch ex As Exception
                    renableWithMessage("Failed loading Graphs. Please Try rejoining Session.")
                End Try
            End While
        Catch ex As Exception
            renableWithMessage("Failed loading Graphs. Please Try rejoining Session.")
        End Try
    End Sub
    Private Function GetRandomColor() As Color
        Dim r As New Random()
        Return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))
    End Function

    Private Sub NormalizeData(data As Double())
        'Z scaling
        ' Calculate mean and standard deviation
        Dim mean As Double = data.Average()
        Dim stdDev As Double = Math.Sqrt(data.Select(Function(x) (x - mean) ^ 2).Average())

        ' Normalize the data using Z-score normalization
        For i As Integer = 0 To data.Length - 1
            data(i) = 1000 * (data(i) - mean) / stdDev
        Next
    End Sub

    Private lastSendTime As DateTime = DateTime.MinValue
    Private sendInterval As TimeSpan = TimeSpan.FromSeconds(0.8)

    Public Async Sub sendGraphUpdate(dataObj As Object)
        If sessionKey = "" Then Return

        ' Check if enough time has passed since the last function call
        Dim now As DateTime = DateTime.UtcNow
        Dim timeSinceLastSend As TimeSpan = now - lastSendTime
        If timeSinceLastSend < sendInterval Then
            Return
        End If

        ' Update the last send time
        lastSendTime = now

        ' Send the graph update
        Try
            Dim myXData As Double() = dataObj(0)
            Dim myYData As Double() = dataObj(1)

            Dim graph_data As String = JsonConvert.SerializeObject(dataObj)

            Dim response As HttpResponseMessage = Await httpClient.PostAsync($"{siteURL}/send_graph/{sessionKey}?user_id={userId}", New StringContent(JsonConvert.SerializeObject(New Dictionary(Of String, String) From {{"graph", graph_data}}), Encoding.UTF8, "application/json"))

            If Not response.StatusCode = HttpStatusCode.OK Then
                sessionKey = ""
                renableWithMessage("Failed To send message. Please Try rejoining Session.")
            End If
        Catch ex As Exception
            renableWithMessage("Failed To send message. Please Try rejoining Session.")
        End Try
    End Sub

End Module
