Partial Public Class ECG_MainForm
    Public FFT3CoherenceList As List(Of Double) = New List(Of Double)

    Private Sub HandleFFT3Coherence(cepstrum() As Double)
        If FFT3Panel.Visible Then

            ' Compute fft3
            Dim cepstrum_copy() As Double = cepstrum
            'Array.Resize(Of Double)(cepstrum_copy, cepstrum_copy.Length - 1)
            Dim fft3() As Double = FftSharp.Transform.FFTmagnitude(cepstrum_copy)

            ' plot
            FFT3Plottable.Plot.Clear()
            For i = 0 To 5
                fft3(i) = 0
            Next
            FFT3CoherenceList.Add(fft3.Average())
            Dim fiveSecondValuesRawECG As Double() = Enumerable.Repeat(1024.0, 5000).ToArray()
            Dim length As Integer = FFT3CoherenceList.Count

            Dim xAxis(length - 1) As Double
            For i = 0 To xAxis.Length - 1
                xAxis(i) = i
            Next
            FFT3Plottable.Plot.AddScatterLines(xAxis, FFT3CoherenceList.ToArray, color:=System.Drawing.ColorTranslator.FromHtml("#d62728"))
            ' FFT3Plottable.Plot.AddSignalConst(fiveSecondValuesRawECG, color:=System.Drawing.ColorTranslator.FromHtml("#d62728"))
            ' FFT3Plottable.Plot.AddSignalConst(FFT3CoherenceList.ToArray, color:=System.Drawing.ColorTranslator.FromHtml("#d62728"))
            FFT3Plottable.Plot.AxisAuto()
            FFT3Plottable.Render()

            If FFT3CoherenceList.Count > 250 Then
                FFT3CoherenceList.Clear()
            End If
        End If
    End Sub
End Class