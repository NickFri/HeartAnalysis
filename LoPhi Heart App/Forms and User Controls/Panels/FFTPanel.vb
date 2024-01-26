'Public Class FFTPanelClass

'    Private ReadOnly _plot As ScottPlot.FormsPlot
'    Private _mainForm As ECG_MainForm
'    Public _FFTfrequency() As Double
'    Public _FFTdata() As Double

'    Private Structure FFTModel
'        Public Frequency() As Double
'        Public Data() As Double
'    End Structure

'    Public Sub New(plot As ScottPlot.FormsPlot, ByVal mainFormInstance As ECG_MainForm) ', fftFrequency() As Double, fftData() As Double)

'        _plot = plot
'        _mainForm = mainFormInstance

'    End Sub

'    Public Sub plot()

'        Dim params As New FFTModel With {
'        .Frequency = _FFTfrequency,
'        .Data = _FFTdata
'        }

'        _mainForm.uiContext.Post(AddressOf FFTRenderOnUIThread, params)
'    End Sub

'    Private Sub FFTRenderOnUIThread(state As Object)
'        Dim params As FFTModel = DirectCast(state, FFTModel)

'        _plot.Plot.Clear()
'        _plot.Plot.AddScatterLines(params.Frequency, params.Data, ColorTranslator.FromHtml("#3b88be"))
'        _plot.Plot.SetAxisLimits(0, _mainForm.FFTScaleWidth.Value, 0, _mainForm.FFTScaleHeight.Value)

'        Dim score As New ScoreClass(_FFTfrequency, _FFTdata)
'        Dim scoreObj = score.FFT()

'        Dim highestFrequenciesList As List(Of Double) = scoreObj.Item1
'        Dim normalizedScore As Double = scoreObj.Item2
'        Dim averageRatio As Double = scoreObj.Item3

'        If _mainForm.FFTPeakLines Then
'            For i = 0 To highestFrequenciesList.Count - 1
'                _plot.Plot.AddVerticalLine(highestFrequenciesList(i), ColorTranslator.FromHtml("#5882FA"), 2, ScottPlot.LineStyle.Solid)
'            Next
'        End If

'        _plot.Plot.SetAxisLimits(0, _mainForm.FFTScaleWidth.Value, 0, _mainForm.FFTScaleHeight.Value)
'        _plot.Render()

'        _mainForm.Frame_RawFFT_Data_Score.Text = "Golden Ratio Score: " + Math.Round(normalizedScore, 4).ToString
'        If _mainForm.FFTCurrentRatio Then _mainForm.ToolStripCurrentRatio.Text = "Current Ratio " + averageRatio.ToString("0.000")

'        _mainForm.HandleScoreBasedGraph(normalizedScore)

'    End Sub

'End Class

Partial Public Class ECG_MainForm
    Public Sub RenderFFT(_FFTfrequency() As Double, _FFTdata() As Double, samplerate As Double)

        Dim lowPassData As Double() = FftSharp.Filter.LowPass(_FFTdata, samplerate, Convert.ToDouble(FFTLowPassValue.Value))
        Dim scaledValues As Object = ScaleFrequency(_FFTfrequency, lowPassData, 0.4, FFTScaleWidth.Value)

        _FFTfrequency = scaledValues(0)
        _FFTdata = scaledValues(1)

        FFTGraph.Plot.Clear()
        FFTGraph.Plot.AddScatterLines(_FFTfrequency, _FFTdata, ColorTranslator.FromHtml("#3b88be"))
        FFTGraph.Plot.SetAxisLimits(0, FFTScaleWidth.Value, 0, FFTScaleHeight.Value)

        Dim score As New ScoreClass(_FFTfrequency, _FFTdata)
        Dim scoreObj = score.FFT()

        Dim highestFrequenciesList As List(Of Double) = scoreObj.Item1
        Dim normalizedScore As Double = scoreObj.Item2
        Dim averageRatio As Double = scoreObj.Item3

        If FFTPeakLines Then
            For i = 0 To highestFrequenciesList.Count - 1
                FFTGraph.Plot.AddVerticalLine(highestFrequenciesList(i), ColorTranslator.FromHtml("#5882FA"), 2, ScottPlot.LineStyle.Solid)
            Next
        End If

        FFTGraph.Plot.SetAxisLimits(0, FFTScaleWidth.Value, 0, FFTScaleHeight.Value)
        FFTGraph.Render()

        Frame_RawFFT_Data_Score.Text = "Golden Ratio Score: " + Math.Round(normalizedScore, 4).ToString
        If FFTCurrentRatio Then ToolStripCurrentRatio.Text = "Current Ratio " + averageRatio.ToString("0.000")

        HandleScoreBasedGraph(normalizedScore)
    End Sub

    '''''''''' UI ''''''''''
    ' Create Controls
    Public FFTScaleWidth As New NumericUpDown
    Public FFTScaleHeight As New NumericUpDown
    Public FFTLowPassValue As New NumericUpDown

    Private Sub FFTUIRenderer()

        ToolStripFFT.Renderer = New ToolStripRenderer


        FFTScaleHeight.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        FFTScaleHeight.Increment = 5 'New Decimal(New Integer() {5, 0, 0, 0})
        FFTScaleHeight.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        FFTScaleHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        FFTScaleHeight.Name = "Frame_RawFFT_Data_Y_Scale"
        FFTScaleHeight.Size = New System.Drawing.Size(58, 20)
        FFTScaleHeight.Value = My.Settings("fft_Y")


        ' Add a handler for the ValueChanged event
        AddHandler FFTScaleHeight.ValueChanged, AddressOf Frame_RawFFT_Data_Y_Scale_ValueChanged


        FFTScaleWidth.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        FFTScaleHeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        FFTScaleWidth.Maximum = New Decimal(New Integer() {35, 0, 0, 0})
        FFTScaleWidth.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        FFTScaleWidth.Name = "Frame_RawFFT_Data_X_Scale"
        FFTScaleWidth.Size = New System.Drawing.Size(58, 20)
        FFTScaleWidth.Value = New Decimal(New Integer() {18, 0, 0, 0})


        'Frame_RawFFT_Data_LowPassValue
        FFTLowPassValue.DecimalPlaces = 1
        FFTLowPassValue.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        FFTLowPassValue.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        FFTLowPassValue.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
        FFTLowPassValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        FFTLowPassValue.Name = "Frame_RawFFT_Data_LowPassValue"
        FFTLowPassValue.Size = New System.Drawing.Size(57, 20)
        FFTLowPassValue.Value = My.Settings("fft_LP")


        ' Add a handler for the ValueChanged event
        AddHandler FFTLowPassValue.ValueChanged, AddressOf Frame_RawFFT_Data_LowPassValue_ValueChanged


        Dim FFTLosPass As New ToolStripControlHost(FFTLowPassValue)
        FFTLosPass.AutoSize = False
        LowPassFilterToolStripMenuItem1.DropDown.Items.Insert(0, FFTLosPass)
        Dim FFTXScale As New ToolStripControlHost(FFTScaleWidth)
        FFTXScale.AutoSize = False
        XScaleToolStripMenuItem.DropDown.Items.Insert(0, FFTXScale)
        Dim FFTYSCale As New ToolStripControlHost(FFTScaleHeight)
        FFTYSCale.AutoSize = False
        YScaleToolStripMenuItem1.DropDown.Items.Insert(0, FFTYSCale)
    End Sub

    ' Current Ratio UI
    Public FFTCurrentRatio As Boolean = False
    Private Sub CurrentRatioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentRatioToolStripMenuItem.Click
        ' Show FFT Current Ratio
        If FFTCurrentRatio Then
            CurrentRatioToolStripMenuItem.Font = New Font(CurrentRatioToolStripMenuItem.Font, FontStyle.Regular)
            ToolStripCurrentRatio.Visible = False
            FFTCurrentRatio = False
        ElseIf FFTCurrentRatio = False Then
            CurrentRatioToolStripMenuItem.Font = New Font(CurrentRatioToolStripMenuItem.Font, FontStyle.Bold)
            ToolStripCurrentRatio.Visible = True
            FFTCurrentRatio = True
        End If
    End Sub


    Public FFTPeakLines As Boolean = False
    Private Sub PeaklinesONOFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeaklinesONOFFToolStripMenuItem.Click
        ' FFT Peak Lines
        If FFTPeakLines Then
            FFTPeakLines = False
            PeaklinesONOFFToolStripMenuItem.Font = New Font(PeaklinesONOFFToolStripMenuItem.Font, FontStyle.Regular)
        ElseIf FFTPeakLines = False Then
            FFTPeakLines = True
            PeaklinesONOFFToolStripMenuItem.Font = New Font(PeaklinesONOFFToolStripMenuItem.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub Frame_RawFFT_Data_Y_Scale_ValueChanged(sender As Object, e As EventArgs)
        My.Settings("fft_Y") = FFTScaleHeight.Value
        My.Settings.Save()
    End Sub

    Private Sub Frame_RawFFT_Data_LowPassValue_ValueChanged(sender As Object, e As EventArgs)
        My.Settings("fft_LP") = FFTLowPassValue.Value
        My.Settings.Save()
    End Sub
End Class
