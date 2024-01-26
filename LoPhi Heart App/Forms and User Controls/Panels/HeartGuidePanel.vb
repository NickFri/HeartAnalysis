'Public Class HeartGuidePanelClass
'    Private ReadOnly _plot As ScottPlot.FormsPlot
'    Private _comPortInstance As COMPORT
'    Private _mainForm As ECG_MainForm
'    Private waveformArray(50 - 1) As Double
'    Private xValue(50 - 1) As Double

'    Public Sub New(plot As ScottPlot.FormsPlot, ByVal mainFormInstance As ECG_MainForm)

'        _plot = plot
'        _mainForm = mainFormInstance
'        '   _comPortInstance = CaptureECGviaCOMport.Instance

'        ' Populate xValue with 1-50
'        For i = 0 To xValue.Length - 1
'            xValue(i) = i
'        Next
'    End Sub

'    Public Sub HeartGuideTimer(sender As Object, e As EventArgs)
'        If _mainForm._busyRendering Then Return
'        _mainForm._busyRendering = True

'        If _mainForm.HeartGuidePanel.Visible = True And _comPortInstance.beatRates.Count > 4 Then
'            PlotHeartGuide()
'        End If

'        _mainForm._busyRendering = False
'    End Sub

'    Private Sub PlotHeartGuide()
'        If _mainForm._busyRendering Then Return
'        _mainForm._busyRendering = True

'        If Not _mainForm.HeartGuidePanel.Visible = True And Not _comPortInstance.beatRates.Count > 4 Then Return

'        _plot.Plot.Clear()

'        ' Working with ecg.fifty_beat_buffer
'        Dim length As Integer = _comPortInstance.fifty_beat_buffer.Count
'        ' Take length because the count is happening on another thread
'        Dim xAxis(length - 1) As Double
'        For i = 0 To xAxis.Length - 1
'            xAxis(i) = i
'        Next

'        _plot.Plot.AddScatterLines(xAxis, _comPortInstance.fifty_beat_buffer.Take(length).ToArray, color:=System.Drawing.ColorTranslator.FromHtml("#FF0000"))
'        Dim startXValue As Double = _comPortInstance.startValue_master 'master value put into temporary variable
'        Dim endXValue As Double = _comPortInstance.startValue_master + 50
'        Dim Average As Double = _comPortInstance.beatRates.ToArray.Average ' converts to array to copy data that might otherwise be changed by another thread
'        Dim Hieght As Double = _mainForm.Frame_HRV_Guide_Height_Setting.Value
'        Dim f As Double = _mainForm.Frame_HRV_Guide_Frequency_Setting.Value
'        Dim m As Double = 1
'        Dim p As Double = 1

'        If _mainForm.HeartGuideMode = 2 Then
'            m = 2
'        ElseIf _mainForm.HeartGuideMode = 1 Then
'            m = 1.61803398875
'            p = m
'        End If
'        If _mainForm.HeartGuideMode = 0 Then
'            Dim x As Int32 = 0
'            Do While startXValue < endXValue
'                Dim Result As Double = Average + (Hieght * Math.Sin(f * m * startXValue + p))
'                waveformArray(x) = Result
'                x += 1
'                startXValue += 1
'            Loop
'        Else
'            Dim x As Int32 = 0
'            Do While startXValue < endXValue
'                Dim Result As Double = Average + (Hieght * (Math.Sin(f * m * startXValue + p) + Math.Sin(f * m ^ 2 * startXValue + p) + Math.Sin(f * m ^ 3 * startXValue + p)))
'                waveformArray(x) = Result
'                x += 1
'                startXValue += 1
'            Loop
'        End If

'        _plot.Plot.AddScatterLines(xValue, waveformArray)
'        _plot.Plot.SetAxisLimitsY(waveformArray.Min - 5, waveformArray.Max + 5)
'        _plot.Refresh()

'        _mainForm._busyRendering = False

'    End Sub

'End Class

Partial Public Class ECG_MainForm
    Private waveformArray(50 - 1) As Double
    Private xValue = Enumerable.Range(1, 50).Select(Function(i) CDbl(i)).ToArray()

    Private Sub PlotHeartGuide()
        If HeartGuidePanel.Visible = False And beatRates.Count < 4 Then Return

        HeartGuidePlot.Plot.Clear()

        ' Working with ecg.fifty_beat_buffer
        Dim length As Integer = fifty_beat_buffer.Count
        ' Take length because the count is happening on another thread
        Dim xAxis(length - 1) As Double
        For i = 0 To xAxis.Length - 1
            xAxis(i) = i
        Next

        HeartGuidePlot.Plot.AddScatterLines(xAxis, fifty_beat_buffer.Take(length).ToArray, color:=System.Drawing.ColorTranslator.FromHtml("#FF0000"))
        Dim startXValue As Double = startValue_master 'master value put into temporary variable
        Dim endXValue As Double = startValue_master + 50
        Dim Average As Double = beatRates.ToArray.Average ' converts to array to copy data that might otherwise be changed by another thread
        Dim Hieght As Double = Frame_HRV_Guide_Height_Setting.Value
        Dim f As Double = Frame_HRV_Guide_Frequency_Setting.Value
        Dim m As Double = 1
        Dim p As Double = 1

        If HeartGuideMode = 2 Then
            m = 2
        ElseIf HeartGuideMode = 1 Then
            m = 1.61803398875
            p = m
        End If
        If HeartGuideMode = 0 Then
            Dim x As Int32 = 0
            Do While startXValue < endXValue
                Dim Result As Double = Average + (Hieght * Math.Sin(f * m * startXValue + p))
                waveformArray(x) = Result
                x += 1
                startXValue += 1
            Loop
        Else
            Dim x As Int32 = 0
            Do While startXValue < endXValue
                Dim Result As Double = Average + (Hieght * (Math.Sin(f * m * startXValue + p) + Math.Sin(f * m ^ 2 * startXValue + p) + Math.Sin(f * m ^ 3 * startXValue + p)))
                waveformArray(x) = Result
                x += 1
                startXValue += 1
            Loop
        End If

        HeartGuidePlot.Plot.AddScatterLines(xValue, waveformArray)
        HeartGuidePlot.Plot.SetAxisLimitsY(waveformArray.Min - 5, waveformArray.Max + 5)
        HeartGuidePlot.Refresh()
    End Sub

    '''''''''' UI ''''''''''
    Private Sub HeartGuideUIRenderer()
        ToolStripHeartGuide.Renderer = New ToolStripRenderer

        Dim toolStripItemHeartGuideAmplitude As New ToolStripControlHost(Frame_HRV_Guide_Height_Setting)
        toolStripItemHeartGuideAmplitude.AutoSize = False ' Add this line
        toolStripItemHeartGuideAmplitude.Margin = New Padding(0, 0, 22, 0)
        toolStripItemHeartGuideAmplitude.Alignment = ToolStripItemAlignment.Right
        ToolStripHeartGuide.Items.Insert(2, toolStripItemHeartGuideAmplitude)

        Dim toolStripItemHeartGuideFrequency As New ToolStripControlHost(Frame_HRV_Guide_Frequency_Setting)
        toolStripItemHeartGuideFrequency.AutoSize = False ' Add this line
        toolStripItemHeartGuideFrequency.Margin = New Padding(2, 0, 8, 0)
        toolStripItemHeartGuideFrequency.Alignment = ToolStripItemAlignment.Right
        ToolStripHeartGuide.Items.Insert(4, toolStripItemHeartGuideFrequency)
    End Sub

    Public HeartGuideMode As Int16 = 1
    Private Sub PHIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PHIToolStripMenuItem.Click
        Frame_HRV_Guide_Frequency_Setting.Value = 0.2
        HeartGuideMode = 1
    End Sub

    Private Sub OctaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OctaveToolStripMenuItem.Click
        Frame_HRV_Guide_Frequency_Setting.Value = 0.07
        HeartGuideMode = 2
    End Sub

    Private Sub SineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SineToolStripMenuItem.Click
        Frame_HRV_Guide_Frequency_Setting.Value = 0.1
        HeartGuideMode = 0
    End Sub

End Class