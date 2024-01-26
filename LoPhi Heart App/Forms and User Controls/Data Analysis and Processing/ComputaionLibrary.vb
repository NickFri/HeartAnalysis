Public Module ComputaionLibrary
    Public Function InterpolateData(FFT_size_ As Integer, XLength As Double, y() As Double) As Double()
        Dim interpolateddata_(FFT_size_ - 1) As Double
        Dim x(XLength - 1) As Double
        For i = 0 To x.Length - 1
            x(i) = i
        Next
        Dim spline As MathNet.Numerics.Interpolation.CubicSpline = MathNet.Numerics.Interpolation.CubicSpline.InterpolateNatural(x, y)
        Dim b As Double = (x.Length - 1) / FFT_size_
        Dim c As Double = b
        For i = 0 To interpolateddata_.Length - 1
            interpolateddata_(i) = spline.Interpolate(b)
            b += c
        Next

        Return interpolateddata_
    End Function

    Public Function ScaleFrequency(freqData() As Double, data() As Double, beginning As Double, ending As Double, Optional specialCut As Int16 = 0) As Object
        Dim startIndex As Int32 = 0
        Dim endIndex As Int32 = 0

        For i = 0 To freqData.Length - 1
            If freqData(i) >= beginning Then
                startIndex = i
                Exit For
            End If
        Next

        For i = 0 To freqData.Length - 1
            If freqData(i) >= ending Then
                endIndex = i
                Exit For
            End If
        Next

        If endIndex = 0 Then endIndex = freqData.Length - 1
        If startIndex = 1 Then startIndex = 0

        Dim dataDone((endIndex - startIndex) - 1) As Double
        Dim freqDataDone((endIndex - startIndex) - 1) As Double
        Array.Copy(data, startIndex, dataDone, 0, endIndex - startIndex)
        Array.Copy(freqData, startIndex, freqDataDone, 0, endIndex - startIndex)
        Return {freqDataDone, dataDone}
    End Function

    Public Sub NormalizeData(data As Double())
        'Z scaling
        Dim mean As Double = data.Average()
        Dim stdDev As Double = Math.Sqrt(data.Select(Function(x) (x - mean) ^ 2).Average())

        ' Normalize the data using Z-score normalization
        For i As Integer = 0 To data.Length - 1
            data(i) = 1000 * (data(i) - mean) / stdDev
        Next
    End Sub

    Public Function ComputeFFT(data() As Double, samplerate As Double) As Double()
        Dim fftdata() As Double = FftSharp.Transform.FFTmagnitude(data)
        Array.Resize(Of Double)(fftdata, fftdata.Length - 1)
        Return fftdata
    End Function

    Public Function ComputeCepstrum(fftdata() As Double, fftfreq() As Double) As Double()
        Dim cepstrum() As Double = FftSharp.Transform.FFTmagnitude(fftdata)
        Array.Resize(Of Double)(cepstrum, cepstrum.Length - 1)
        Return cepstrum
    End Function

    Public Function Filterdata(data() As Double, samplerate As Double) As Double()
        Dim a As Double() = data
        Dim h As Double() = FftSharp.Filter.LowPass(a, samplerate, Convert.ToDouble(ECG_MainForm.Frame_Cepstrum_Data_LowPassValue.Value))
        Return h
    End Function

    'Public Function FilterAndInterpolate(data() As Double, samplerate As Double) As Double()
    '    Dim a As Double() = data
    '    If a.Length < 10 Then
    '        MsgBox("halt")
    '    End If
    '    Dim g As Double() = InterpolateData(2 ^ 10, a.Length, a)
    '    Dim h As Double() = FftSharp.Filter.LowPass(g, samplerate, Convert.ToDouble(ECG_MainForm.Frame_Cepstrum_Data_LowPassValue.Value))
    '    If a.Length < 10 Then
    '        MsgBox("halt")
    '    End If
    '    Dim q As Double() = InterpolateData(a.Length, h.Length, h)
    '    Return q
    'End Function

End Module
