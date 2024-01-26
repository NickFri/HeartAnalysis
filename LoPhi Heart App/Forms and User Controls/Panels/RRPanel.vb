'Public Class HeartRateOverTimePanelClass
'    Private ReadOnly _plot As ScottPlot.FormsPlot
'    Private comPortInstance As COMPORT
'    Private mainForm As ECG_MainForm
'    Private busyRendering As Boolean = False

'    Public Sub New(plot As ScottPlot.FormsPlot, ByVal mainFormInstance As ECG_MainForm)
'        _plot = plot
'        ' comPortInstance = CaptureECGviaCOMport.Instance
'        mainForm = mainFormInstance
'    End Sub

'    Public Sub RRintervalTimer(sender As Object, e As EventArgs)
'        If busyRendering Then Return
'        busyRendering = True

'        Try
'            If comPortInstance.beatRates.Count > 4 Then
'                UpdateBPMLabel()
'                UpdateBeatToBeatGraph()
'            End If
'        Finally
'            busyRendering = False
'        End Try
'    End Sub

'    Private Sub UpdateBPMLabel()
'        mainForm.BPMtoolstripLabel.Text = $"{comPortInstance.beatRates.LastOrDefault():0.0} BPM"
'    End Sub

'    Private Sub UpdateBeatToBeatGraph()
'        If mainForm.HRVPanel.Visible Then
'            _plot.Plot.Clear()
'            Dim dataLength As Integer = CInt(mainForm.Frame_Beat_To_Beat_Display_Length.Value)
'            Dim datanew(dataLength - 1) As Double

'            If comPortInstance.beatRates.Count >= dataLength Then
'                Array.Copy(comPortInstance.beatRates.ToArray(), comPortInstance.beatRates.Count - dataLength, datanew, 0, dataLength)
'            End If

'            Dim xAxis(dataLength - 1) As Double
'            For i = 0 To xAxis.Length - 1
'                xAxis(i) = i
'            Next

'            _plot.Plot.AddScatterLines(xAxis, datanew, color:=System.Drawing.ColorTranslator.FromHtml("#FF0000"))
'            _plot.Refresh()
'        End If
'    End Sub
'End Class

Partial Public Class ECG_MainForm
    Private Sub UpdateBPMLabel()
        BPMtoolstripLabel.Text = $"{beatRates.LastOrDefault():0.0} BPM"
    End Sub

    Private Sub UpdateBeatToBeatGraph()
        If RRPanel.Visible Then
            RRGraph.Plot.Clear()
            Dim datanew(Frame_Beat_To_Beat_Display_Length.Value - 1) As Double

            If beatRates.ToArray.Length >= Frame_Beat_To_Beat_Display_Length.Value Then
                ' got a source array not long enough. data new 50 ecg.beatrates 298
                Array.Copy(beatRates.ToArray, beatRates.ToArray.Length - Convert.ToInt32(Frame_Beat_To_Beat_Display_Length.Value), datanew, 0, Convert.ToInt32(Frame_Beat_To_Beat_Display_Length.Value))
            End If

            If beatRates.ToArray.Length < Frame_Beat_To_Beat_Display_Length.Value Then
                Dim xAxis(beatRates.ToArray.Length - 1) As Double
                For i = 0 To xAxis.Length - 1
                    xAxis(i) = i
                Next
                RRGraph.Plot.AddScatterLines(xAxis, beatRates.ToArray, color:=System.Drawing.ColorTranslator.FromHtml("#FF0000"))
            Else
                Dim xAxis(datanew.Length - 1) As Double
                For i = 0 To xAxis.Length - 1
                    xAxis(i) = i
                Next
                RRGraph.Plot.AddScatterLines(xAxis, datanew, color:=System.Drawing.ColorTranslator.FromHtml("#FF0000"))
            End If
            RRGraph.Refresh()
        End If
    End Sub

    '''''''''' UI ''''''''''
    Private Sub HRVUIRenderer()
        ToolStripHRVFFT.Renderer = New ToolStripRenderer

        Dim toolStripItemHRV As New ToolStripControlHost(Frame_Beat_To_Beat_Display_Length)
        toolStripItemHRV.AutoSize = False ' Add this line
        toolStripItemHRV.Margin = New Padding(0, 0, 40, 0)
        toolStripItemHRV.Alignment = ToolStripItemAlignment.Right
        ToolStripRRIntevalHRV.Items.Insert(ToolStripRRIntevalHRV.Items.Count - 1, toolStripItemHRV)
    End Sub

End Class