Partial Public Class ECG_MainForm
    Public Sub HandleHRVFFTGraph()

        Dim _FFTfrequencyHRV As Double()
        Dim _FFTdataHRV As Double()

        Dim samplerateHRVFFT As Double, Data As Double(), interpolationLength As Double
        interpolationLength = interpolationLengthHRV
        samplerateHRVFFT = interpolationLength / (beatTimes(beatTimes.Count - 1) - beatTimes(0))
        Data = beatRates.ToArray


        HRVFFTGraph.Plot.Clear()

        Dim interpolated = InterpolateData(interpolationLength, Data.Length, Data)
        Dim window = New FftSharp.Windows.Hanning()
        window.ApplyInPlace(interpolated)
        _FFTdataHRV = FftSharp.Transform.FFTmagnitude(interpolated)
        _FFTfrequencyHRV = FftSharp.Transform.FFTfreq(samplerateHRVFFT, _FFTdataHRV.Length)

        Dim fftscalefactor As Double = If(scaleHRVFFT, 0.4, 1.5)
        Dim scaledvalues = ScaleFrequency(_FFTfrequencyHRV, _FFTdataHRV, 0.02, fftscalefactor)

        If showColorHRV Then
            HRVFFTGraph.Plot.AddHorizontalSpan(0, 0.047, ColorTranslator.FromHtml("#ef9a9a"))
            HRVFFTGraph.Plot.AddHorizontalSpan(0.047, 0.102, ColorTranslator.FromHtml("#9fa8da"))
            HRVFFTGraph.Plot.AddHorizontalSpan(0.102, 0.157, ColorTranslator.FromHtml("#b3e5fc"))

            Dim maxFreq = If(scaleHRVFFT, 0.4, 1.5)
            HRVFFTGraph.Plot.AddHorizontalSpan(0.157, maxFreq, ColorTranslator.FromHtml("#e1bee7"))
        End If

        HRVFFTGraph.Plot.AddScatterLines(scaledvalues(0), scaledvalues(1))
        plotScorePeaksAndCurrentRatio(scaledvalues(0), scaledvalues(1))
        HRVFFTGraph.Refresh()
        HRVFFTGraph.Render()

    End Sub

    Private Sub plotScorePeaksAndCurrentRatio(_FFTfrequencyHRV As Double(), _FFTdataHRV As Double())
        If _FFTfrequencyHRV.Count > 25 Then


            Dim score As New ScoreClass(_FFTfrequencyHRV, _FFTdataHRV)

            Dim scoreObj As Object
            scoreObj = score.HRVFFT()


            Dim highestFrequenciesList As New List(Of Double)
            highestFrequenciesList = scoreObj.Item1
            Dim normalizedScore As Double = scoreObj.Item2
            Dim averageRatio As Double = scoreObj.Item3


            Frame_RR_FFT_Score.Text = "Score " + Math.Round(normalizedScore).ToString
            If HRVCurrentRatio Then ToolStripHRVCurrentRatio.Text = "Current Ratio " + averageRatio.ToString("0.000")


            If showPeaks Then
                For i = 0 To highestFrequenciesList.Count - 1
                    HRVFFTGraph.Plot.AddVerticalLine(highestFrequenciesList(i), Color.Gray, 2, ScottPlot.LineStyle.Solid)
                Next
            End If
        Else
            ' score 0
            Frame_RR_FFT_Score.Text = "Score " + Math.Round(0).ToString
        End If

    End Sub

End Class


Partial Public Class ECG_MainForm
    Public HRVCurrentRatio As Boolean = False

    Private Sub CurrentRatioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CurrentRatioToolStripMenuItem1.Click
        ' Show HRV Current Ratio
        If HRVCurrentRatio Then
            CurrentRatioToolStripMenuItem1.Font = New Font(CurrentRatioToolStripMenuItem1.Font, FontStyle.Regular)
            ToolStripHRVCurrentRatio.Visible = False
            HRVCurrentRatio = False
        ElseIf HRVCurrentRatio = False Then
            CurrentRatioToolStripMenuItem1.Font = New Font(CurrentRatioToolStripMenuItem1.Font, FontStyle.Bold)
            ToolStripHRVCurrentRatio.Visible = True
            HRVCurrentRatio = True
        End If
    End Sub

    Public showColorHRV As Boolean = True

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        If showColorHRV Then
            showColorHRV = False
            ToolStripMenuItem8.Font = New Font(ToolStripMenuItem8.Font, FontStyle.Regular)
        ElseIf showColorHRV = False Then
            showColorHRV = True
            ToolStripMenuItem8.Font = New Font(ToolStripMenuItem8.Font, FontStyle.Bold)
        End If
    End Sub

    Public showPeaks As Boolean = False

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        If showPeaks Then
            showPeaks = False
            ToolStripMenuItem7.Font = New Font(ToolStripMenuItem7.Font, FontStyle.Regular)
        ElseIf showPeaks = False Then
            showPeaks = True
            ToolStripMenuItem7.Font = New Font(ToolStripMenuItem7.Font, FontStyle.Bold)
        End If
    End Sub

    Public scaleHRVFFT As Boolean = True

    Private Sub Scale00X04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Scale00X04ToolStripMenuItem.Click
        If scaleHRVFFT Then
            scaleHRVFFT = False
            Scale00X04ToolStripMenuItem.Font = New Font(Scale00X04ToolStripMenuItem.Font, FontStyle.Regular)
        ElseIf scaleHRVFFT = False Then
            scaleHRVFFT = True
            Scale00X04ToolStripMenuItem.Font = New Font(Scale00X04ToolStripMenuItem.Font, FontStyle.Bold)
        End If
    End Sub

End Class