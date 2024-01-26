Partial Public Class ECG_MainForm

    Private Sub RenderCepstrum(_CepstrumFrequency() As Double, _CepstrumData() As Double, samplerate As Double)
        Try
            If Not CepstrumPanel.Visible Then Return

            Dim scaledFrequency() As Double
            Dim scaledData() As Double

            If CepstrumScaling Then

                Dim filteredResult() As Double = ComputaionLibrary.Filterdata(_CepstrumData, samplerate)

                Dim scaledResult As Object = ComputaionLibrary.ScaleFrequency(_CepstrumFrequency, filteredResult, 0.3, 1.1)

                scaledFrequency = scaledResult(0)
                scaledData = scaledResult(1)


                If CepstrumHistoryPanel.Visible Then
                    Cepstrum_History_Plot(scaledFrequency, scaledData)
                End If

                If PlayOnlinePanel.Visible Then
                    Dim filteredResultOnline() As Double = ComputaionLibrary.Filterdata(_CepstrumData, samplerate)
                    Dim scaledResultOnline As Object = ComputaionLibrary.ScaleFrequency(_CepstrumFrequency, filteredResultOnline, 0.3, 2.7)
                    PlayOnlineModule.sendGraphUpdate(scaledResultOnline)
                End If

            Else

                Dim filteredResult() As Double = ComputaionLibrary.Filterdata(_CepstrumData, samplerate)

                Dim scaledResult As Object = ComputaionLibrary.ScaleFrequency(_CepstrumFrequency, filteredResult, 0.3, 2.7)

                scaledFrequency = scaledResult(0)
                scaledData = scaledResult(1)


                If CepstrumHistoryPanel.Visible Then
                    Cepstrum_History_Plot(scaledFrequency, scaledData)
                End If

                If PlayOnlinePanel.Visible Then
                    PlayOnlineModule.sendGraphUpdate(scaledResult)
                End If

            End If

            CepstrumGraph.Plot.Clear()
            CepstrumGraph.Plot.AddScatterLines(scaledFrequency, scaledData, ColorTranslator.FromHtml("#3b88be"))

            If CepstrumPhiScore Then

                Dim score As New ScoreClass(scaledFrequency, scaledData)
                Dim scoreResults As Object = score.cepstrum

                Dim scoreNumeric As Double = scoreResults.item1
                Dim Index1 As Integer = scoreResults.item2
                Dim Index2 As Integer = scoreResults.item3

                cepstrum_score_txt.Text = "Score " + scoreNumeric.ToString

                CepstrumGraph.Plot.AddVerticalLine(scaledFrequency(Index1), ColorTranslator.FromHtml("#5882FA"), 2, ScottPlot.LineStyle.Solid)
                CepstrumGraph.Plot.AddVerticalLine(scaledFrequency(Index2), ColorTranslator.FromHtml("#5882FA"), 2, ScottPlot.LineStyle.Solid)
            Else

                cepstrum_score_txt.Text = "Score " + "0"
            End If

            If CepTracking Then
                Dim maxVal As Double = scaledData.Max
                If maxVal > HighestCepstrum Then HighestCepstrum = maxVal
                CepstrumGraph.Plot.AddHorizontalLine(HighestCepstrum, color:=System.Drawing.ColorTranslator.FromHtml("#bcbd22"))
            End If

            CepstrumGraph.Render()
        Catch
            Dim a As String = "you got an error"
        End Try
    End Sub

    '''''''''' UI ''''''''''
    ' Create Controls
    Public Frame_Cepstrum_Data_LowPassValue As New NumericUpDown

    Private Sub CepstrumUIRenderer()

        ToolStripCepstrum.Renderer = New ToolStripRenderer

        ' Frame_Cepstrum_Data_LowPassValue
        Frame_Cepstrum_Data_LowPassValue.DecimalPlaces = 1
        Frame_Cepstrum_Data_LowPassValue.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Frame_Cepstrum_Data_LowPassValue.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Frame_Cepstrum_Data_LowPassValue.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Frame_Cepstrum_Data_LowPassValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Frame_Cepstrum_Data_LowPassValue.Name = "Frame_Cepstrum_Data_LowPassValue"
        Frame_Cepstrum_Data_LowPassValue.Size = New System.Drawing.Size(57, 20)
        Frame_Cepstrum_Data_LowPassValue.Value = My.Settings("cep_LP")

        ' Add a handler for the ValueChanged event
        AddHandler Frame_Cepstrum_Data_LowPassValue.ValueChanged, AddressOf Frame_Cepstrum_Data_LowPassValue_ValueChanged


        Dim CepstrumLowPassFilter As New ToolStripControlHost(Frame_Cepstrum_Data_LowPassValue)
        LowPassFilterToolStripMenuItem.DropDownItems.Insert(0, CepstrumLowPassFilter)
    End Sub

    Public CepstrumPhiScore As Boolean = False
    Private Sub EnablePHIScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnablePHIScoreToolStripMenuItem.Click
        ' Cepstrum Enable PHI Score
        If CepstrumPhiScore Then
            EnablePHIScoreToolStripMenuItem.Font = New Font(EnablePHIScoreToolStripMenuItem.Font, FontStyle.Regular)
            cepstrum_score_txt.Visible = False
            CepstrumPhiScore = False
        ElseIf CepstrumPhiScore = False Then
            EnablePHIScoreToolStripMenuItem.Font = New Font(EnablePHIScoreToolStripMenuItem.Font, FontStyle.Bold)
            cepstrum_score_txt.Visible = True
            CepstrumPhiScore = True
        End If
    End Sub

    Public CepTracking As Boolean = False
    Private Sub OnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem1.Click
        ' Cepstrum Tracking ON
        OnToolStripMenuItem1.Font = New Font(OnToolStripMenuItem1.Font, FontStyle.Bold)
        OffToolStripMenuItem1.Font = New Font(OffToolStripMenuItem1.Font, FontStyle.Regular)
        CepTracking = True
    End Sub

    Private Sub OffToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OffToolStripMenuItem1.Click
        ' Cepstrum Tracking OFF
        OffToolStripMenuItem1.Font = New Font(OffToolStripMenuItem1.Font, FontStyle.Bold)
        OnToolStripMenuItem1.Font = New Font(OnToolStripMenuItem1.Font, FontStyle.Regular)
        CepTracking = False
    End Sub

    Public HighestCepstrum As Double = 0
    Private Sub ResetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem1.Click
        ' Cepstrum Tracking Reset
        HighestCepstrum = 0
    End Sub

    Public CepstrumScaling As Boolean = True
    Private Sub HzONOFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HzONOFFToolStripMenuItem.Click
        ' Cepstrum Scaling Hz
        If CepstrumScaling Then
            CepstrumScaling = False
            HzONOFFToolStripMenuItem.Font = New Font(HzONOFFToolStripMenuItem.Font, FontStyle.Regular)
        ElseIf CepstrumScaling = False Then
            CepstrumScaling = True
            HzONOFFToolStripMenuItem.Font = New Font(HzONOFFToolStripMenuItem.Font, FontStyle.Bold)
        End If
    End Sub

    Public Sub Frame_Cepstrum_Data_LowPassValue_ValueChanged(sender As Object, e As EventArgs)
        My.Settings("cep_LP") = Frame_Cepstrum_Data_LowPassValue.Value
        My.Settings.Save()
    End Sub

End Class