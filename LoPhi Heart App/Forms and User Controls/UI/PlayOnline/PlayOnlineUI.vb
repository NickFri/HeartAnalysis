Imports Newtonsoft.Json
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Threading

Partial Public Class ECG_MainForm
    Public Async Sub btnCreateSession_Click(sender As Object, e As EventArgs)
        PlayOnlineModule.updateBtnDisabled()
        Try
            ' Send a POST request to create a new session and retrieve a session key
            Dim response As HttpResponseMessage = Await httpClient.PostAsync(siteURL + "/create_session", Nothing)
            PlayOnlineModule.sessionKey = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(Await response.Content.ReadAsStringAsync())("session_key")

            ' Update the form Controls
            Session_ID_TXT.Text = sessionKey
            Label1.Text = "Your session key: " + sessionKey
            ChatBox.AppendText("Session Created!" & Environment.NewLine)

            ' Send a POST request to the connect endpoint with the session key
            response = Await httpClient.PostAsync($"PlayOnlineModule.{siteURL}/connect/{sessionKey}?user_id={userId}", New StringContent(JsonConvert.SerializeObject(New Dictionary(Of String, String) From {{"Name", userId}}), Encoding.UTF8, "application/json"))

            Dim jsonResponse As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(Await response.Content.ReadAsStringAsync())

            ' Check if the returned JSON contains an error
            If jsonResponse.ContainsKey("error") Then
                PlayOnlineModule.renableWithMessage($"{jsonResponse("error")}")
                Return
            End If

            If response.StatusCode <> HttpStatusCode.OK Then
                PlayOnlineModule.renableWithMessage("Failed to join session. Please try again.")
                Return
            End If

            ' ChatBox.AppendText("Host joined!" & Environment.NewLine)
            PlayOnlineModule.UpdateMessages(cancellationTokenSource.Token)
            PlayOnlineModule.UpdateGraphGraphics(cancellationTokenSource.Token)

        Catch ex As Exception
            ChatBox.AppendText("Failed Starting" & Environment.NewLine)
            PlayOnlineModule.renableWithMessage()
        End Try
    End Sub

    Public Async Sub btnJoinSession_Click(sender As Object, e As EventArgs)
        PlayOnlineModule.updateBtnDisabled()
        Try
            Dim enteredSessionKey As String
            If RBPublicRoom.Checked Then enteredSessionKey = "public_session" Else enteredSessionKey = Session_ID_TXT.Text
            Dim response As HttpResponseMessage = Await httpClient.PostAsync($"{siteURL}/connect/{enteredSessionKey}?user_id={userId}", New StringContent(JsonConvert.SerializeObject(New Dictionary(Of String, String) From {{"Name", userId}}), Encoding.UTF8, "application/json"))
            Dim connectResponse As ConnectResponse = JsonConvert.DeserializeObject(Of ConnectResponse)(Await response.Content.ReadAsStringAsync())

            If Not String.IsNullOrEmpty(connectResponse.errorResponse) Then
                PlayOnlineModule.renableWithMessage($"{connectResponse.errorResponse}")
                Return
            End If

            If response.StatusCode <> HttpStatusCode.OK Then
                PlayOnlineModule.renableWithMessage("Failed to join session. Please try again.")
                Return
            Else
                ChatBox.AppendText("Joined!" & Environment.NewLine)
            End If
            sessionKey = enteredSessionKey
            PlayOnlineModule.UpdateMessages(cancellationTokenSource.Token)
            PlayOnlineModule.UpdateGraphGraphics(cancellationTokenSource.Token)
        Catch ex As Exception
            PlayOnlineModule.renableWithMessage("Failed Joining.")
        End Try
    End Sub

    Public Async Sub btnSend_Click(sender As Object, e As EventArgs)
        PlayOnlineModule.SendMessage()
    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
Loop_:
        Try
            Dim Player_Name As String = InputBox("Enter Your Name, then create, or Join a session. Your name will be saved for future sessions.",
                                        "Enter Your Name", "")
            ' Check if the string is not Nothing and is a string
            If TypeOf Player_Name Is String AndAlso Not String.IsNullOrEmpty(Player_Name) Then
                userId = Player_Name
            Else
                GoTo Loop_
            End If
        Catch
            userId = "Unknown"
        End Try
        My.Settings("Name") = userId
        My.Settings.Save()
    End Sub

    Private Sub Session_ID_TXT_Clicked(sender As Object, e As EventArgs) Handles Session_ID_TXT.Click
        Session_ID_TXT.Text = ""
    End Sub

    Private Sub RBcreateSession_CheckedChanged(sender As Object, e As EventArgs) Handles RBcreateSession.CheckedChanged
        ChatBox.Clear()

        If RBcreateSession.Checked Then
            ' window handling
            Session_ID_TXT.Visible = False
            btnJoinSession.Visible = False
            btnCreateSession.Visible = True
            Label1.Visible = True

            RBjoinSession.Checked = False
            RBPublicRoom.Checked = False
        End If
    End Sub

    Private Sub RBjoinSession_CheckedChanged(sender As Object, e As EventArgs) Handles RBjoinSession.CheckedChanged
        ChatBox.Clear()

        If RBjoinSession.Checked Then
            ' window handling
            btnCreateSession.Visible = False
            Session_ID_TXT.Visible = True
            btnJoinSession.Visible = True
            Label1.Visible = False

            RBcreateSession.Checked = False
            RBPublicRoom.Checked = False
        End If
    End Sub
    Private Sub RBPublicRoom_CheckedChanged(sender As Object, e As EventArgs) Handles RBPublicRoom.CheckedChanged
        ChatBox.Clear()

        If RBPublicRoom.Checked Then
            ' window handling
            btnCreateSession.Visible = False
            Session_ID_TXT.Visible = False
            btnJoinSession.Visible = False
            Label1.Visible = False
            Label1.Text = "No Session Created"

            btnJoinSession_Click(btnJoinSession, EventArgs.Empty)
            RBcreateSession.Checked = False
            RBjoinSession.Checked = False
        End If
    End Sub

    Private Sub messageTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles messageTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Set SuppressKeyPress to True to prevent the ding sound
            SendMessage()
        End If
    End Sub

    Public AutoScaleOnline As Boolean = True
    Private Sub AutoScaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoScaleToolStripMenuItem.Click
        If AutoScaleOnline Then
            AutoScaleToolStripMenuItem.Font = New Font(AutoScaleToolStripMenuItem.Font, FontStyle.Regular)
            AutoScaleOnline = False
        ElseIf AutoScaleOnline = False Then
            AutoScaleToolStripMenuItem.Font = New Font(AutoScaleToolStripMenuItem.Font, FontStyle.Bold)
            AutoScaleOnline = True
        End If
    End Sub



    ''''''''' CREATE UI ''''''''
    Public CepstrumHeight1TB As New NumericUpDown
    Public CepstrumHeight2TB As New NumericUpDown

    Private Sub PlayOnlineUIRenderer()

        'Cepstrum height
        CepstrumHeight1TB.DecimalPlaces = 1
        CepstrumHeight1TB.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        CepstrumHeight1TB.Increment = 0.1 'New Decimal(New Integer() {0.1, 0, 0, 65536})
        CepstrumHeight1TB.Maximum = 10 'New Decimal(New Integer() {20, 0, 0, 0})
        CepstrumHeight1TB.Minimum = 0 'New Decimal(New Integer() {0, 0, 0, 0})
        CepstrumHeight1TB.Name = "CepstrumHeightTB"
        CepstrumHeight1TB.Size = New System.Drawing.Size(57, 20)
        CepstrumHeight1TB.Value = 2 'New Decimal(New Integer() {0.6, 0, 0, 65536})

        Dim CepstrumHeightTC As New ToolStripControlHost(CepstrumHeight1TB)
        CepstrumHeightTC.AutoSize = False

        'Cepstrum height
        CepstrumHeight2TB.DecimalPlaces = 1
        CepstrumHeight2TB.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        CepstrumHeight2TB.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        CepstrumHeight2TB.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        CepstrumHeight2TB.Minimum = -20
        CepstrumHeight2TB.Name = "CepstrumHeight2TB"
        CepstrumHeight2TB.Size = New System.Drawing.Size(57, 20)
        CepstrumHeight2TB.Value = 0

        Dim CepstrumHeight2TC As New ToolStripControlHost(CepstrumHeight2TB)
        CepstrumHeight2TC.AutoSize = False

        HeightDownToolStripMenuItem.DropDown.Items.Insert(0, CepstrumHeight2TC)
        HeightToolStripMenuItem.DropDown.Items.Insert(0, CepstrumHeightTC)

    End Sub

End Class