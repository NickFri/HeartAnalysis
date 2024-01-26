Partial Public Class ECG_MainForm
    ' Create NumericUpDowns
    Private Sub LoadToolStrips()
        ToolStripRRIntevalHRV.Renderer = New ToolStripRenderer

        ToolStripScoreGraph.Renderer = New ToolStripRenderer

    End Sub

    Private Sub TSToolStripButton_Click(sender As Object, e As EventArgs) Handles TSECG.Click, TSCep.Click, TSCepHist.Click, TSRawECGFFT.Click, TSHeartGuide.Click, TSCoherGra.Click, TSRR.Click, TSRRFFT.Click, TSPlayOnline.Click, TSFFT3.Click

        Dim frame = Me.Controls(DirectCast(sender, ToolStripButton).Tag.ToString())
        frame.Visible = Not frame.Visible
        If frame.Visible Then
            frame.BringToFront()
        End If
        If frame.Name = "Frame_Cepstrum_History" Then
            Frame_Cepstrum_History_X.Value = 2
            Frame_Cepstrum_History_Y.Value = 6
        End If
        If frame.Name = "PlayOnlinePanel" Then
            PlayOnlinePanel.Location = Onlinepoint
            'load play online stuff

            RBcreateSession.Checked = True
            If My.Settings("Name") = "" Or My.Settings("Name") Is Nothing Then
                Try
                    Dim Player_Name As String = InputBox("Enter Your Name, then create, or Join a session. Your name will be saved for future sessions.",
                                                "Enter Your Name", "")
                    ' Check if the string is not Nothing and is a string
                    If TypeOf Player_Name Is String AndAlso Not String.IsNullOrEmpty(Player_Name) Then
                        userId = Player_Name
                    Else
                        ' generate random string name
                        Dim chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
                        Dim random = New Random()
                        Dim result = New String(Enumerable.Repeat(chars, 10).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
                        userId = result
                    End If
                Catch
                    userId = "Unknown"
                End Try
                My.Settings("Name") = userId
                My.Settings.Save()
            End If
            userId = My.Settings("Name")
        End If
    End Sub

    Dim HRV_Beat_Count_Data As Integer = 300
    Private Sub ChangeHRVDataLengthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeHRVDataLengthToolStripMenuItem.Click
Loop_:
        Try
            Dim myValue As Int16 = InputBox("Enter Value between 300 and 5000, this is a measure of how many beats will be captured and stored in the HRV data.",
                                                "Enter Value", "")
            If myValue > 5000 Or myValue < 300 Then
                GoTo Loop_
            Else
                HRV_Beat_Count_Data = myValue
            End If
        Catch
            HRV_Beat_Count_Data = 300
        End Try
    End Sub

    Private Sub TSHome_Click(sender As Object, e As EventArgs) Handles TSHome.Click
        HomeTab()
    End Sub

    Private Sub LoPhi_Toolstrip_Select_Input_Click(sender As Object, e As EventArgs) Handles LoPhi_Toolstrip_Select_Input.Click
        Dim processStartInfo As New ProcessStartInfo(Application.ExecutablePath)
        Process.Start(processStartInfo)
        Application.Exit()
    End Sub

    Private Sub DanwinterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DanwinterLink.LinkClicked
        Try
            Process.Start("http://www.fractalfield.com")
        Catch
            MsgBox("http://www.fractalfield.com")
        End Try
    End Sub

End Class
