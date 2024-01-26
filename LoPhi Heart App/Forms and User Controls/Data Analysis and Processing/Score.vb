
Public Class ScoreClass
    Private ReadOnly _frequency As Double()
    Private ReadOnly _data As Double()

    Public Sub New(frequency() As Double, data() As Double)

        _frequency = frequency
        _data = data

    End Sub

    Public Function FFT() As (List(Of Double), Double, Double) ' Return (highestFrequencies, normalized_score, averageRatio)

        ' of the 10 highest peaks, we will choose 4 closest ratios to 1.68 to calculate your score.
        Dim highestCount As Integer = 3 'amountofPeaks ' compare the 3 highest amplitudes 10
        Dim ofhighestCount As Integer = 3 ' plus 1
        Dim sortedData As List(Of Double) = _data.ToList()
        sortedData.Sort()
        sortedData.Reverse()

        Dim highestAmplitudes As List(Of Double) = sortedData.Take(100).ToList()

        Dim highestFrequencies As New List(Of Double)
        Dim freqIndex As Integer = 0

        Do While highestFrequencies.Count < highestCount

            If (highestFrequencies.Count + freqIndex) > (highestAmplitudes.Count - 1) Then
                Return (New List(Of Double), 0, 0)
            End If


            Dim Amp As Double = highestAmplitudes(highestFrequencies.Count + freqIndex)
            Dim index As Integer = Array.IndexOf(_data, Amp)
            Dim frequency As Double = _frequency(index)

            ' Check if the frequency is at least 0.6 apart from all existing frequencies
            If frequency <> 0 AndAlso highestFrequencies.All(Function(freq) Math.Abs(frequency - freq) >= 0.4) Then
                highestFrequencies.Add(frequency)
            Else
                freqIndex += 1
            End If
        Loop


        'sort
        Dim sortedfreq As List(Of Double) = highestFrequencies
        sortedfreq.Sort()
        sortedfreq.Reverse()

        Dim outputratios As List(Of Double) = New List(Of Double)

        For i = 0 To sortedfreq.Count - 1
            If i + 1 > sortedfreq.Count - 1 Then Exit For
            outputratios.Add(sortedfreq(i) / sortedfreq(i + 1))
        Next

        Dim averageRatio As Double = outputratios.Average()
        'Dim goldenRatio As Double = 1.6180339875
        Dim maxDeviationFromGoldenRatio As Double = 0.35 ' 500% deviation from the golden ratio

        'Dim deviation As Double = Math.Abs(averageRatio - goldenRatio) / goldenRatio


        Dim minDeviation As Double = Double.MaxValue ' initialize the minimum deviation to a large value
        Dim bestGoldenRatio As Double = 0 ' initialize the best golden ratio to 0

        For n As Integer = -1 To 3 ' loop through values of n from -2 to 2
            If n <> 0 Then
                Dim goldenRatio As Double = Math.Pow(1.618, n)

                Dim deviation As Double = Math.Abs(averageRatio - goldenRatio) / goldenRatio

                If deviation < minDeviation Then ' if the deviation is smaller than the current minimum
                    minDeviation = deviation ' update the minimum deviation
                    bestGoldenRatio = goldenRatio ' update the best golden ratio
                End If
            End If
        Next

        'Dim goldenRatio As Double = 1.6180339875
        'Dim deviation As Double = Math.Abs(averageRatio - goldenRatio) / goldenRatio
        'Dim normalized_score As Double = 100 * (1 - deviation / maxDeviationFromGoldenRatio)

        Dim normalized_score As Double = 100 * (1 - minDeviation / maxDeviationFromGoldenRatio)


        If minDeviation > maxDeviationFromGoldenRatio Then
            normalized_score = 0 ' set score to 0 if too far from golden ratio
        End If

        Return (highestFrequencies, normalized_score, averageRatio)
    End Function


    Public Function cepstrum() As (Score As Integer, Index1 As Integer, Index2 As Integer) ' Return the score and the index of the highest frequency values

        Dim sortedArray As Double() = _data.OrderByDescending(Function(x) x).ToArray()

        Dim highestValue1 As Double = sortedArray(0) ' first value
        Dim highestValue2 As Double = sortedArray(1) ' second value

        Dim index1 As Integer = Array.IndexOf(_data, highestValue1)
        Dim index2 As Integer = 0

        Dim i As Integer = 2

        Do Until Math.Abs(_frequency(Array.IndexOf(_data, highestValue1)) - _frequency(Array.IndexOf(_data, highestValue2))) > 0.09
            highestValue2 = sortedArray(i)
            i += 1
        Loop

        index2 = Array.IndexOf(_data, highestValue2)

        Dim idealRatio As Double = 1.618
        Dim maxDeviation As Double = 0.6
        Dim ratio As Double = 0
        If _frequency(index1) > _frequency(index2) Then
            ratio = _frequency(index1) / _frequency(index2)
        Else
            ratio = _frequency(index2) / _frequency(index1)
        End If
        Dim deviation As Double = Math.Abs(ratio - idealRatio) / idealRatio
        Dim normalizedScore As Double = 100 * (1 - deviation / maxDeviation)
        If deviation > maxDeviation Then
            normalizedScore = 0
        End If

        '' Return the score and the index of the highest frequency values
        Return (normalizedScore, index1, index2)
    End Function

    Public Function HRVFFT() As (List(Of Double), Integer, Double) ' Return (highestFrequencies, normalized_score, averageRatio)
        ' of the 10 highest peaks, we will choose 4 closest ratios to 1.68 to calculate your score.
        Dim highestCount As Integer = 3 'amountofPeaks ' compare the 3 highest amplitudes 10
        Dim ofhighestCount As Integer = 3

        'sort
        Dim sortedData As List(Of Double) = _data.ToList()
        sortedData.Sort()
        sortedData.Reverse()

        'take highest frequencies
        Dim highestAmplitudes As List(Of Double) = sortedData.Take(49).ToList()

        Dim highestFrequencies As New List(Of Double)
        Dim freqIndex As Integer = 0

        'find highest frequencies spaced some value apart. should be in try catch to return 0 if can't be done
        Do While highestFrequencies.Count < highestCount
            Dim Amp As Double = highestAmplitudes(highestFrequencies.Count + freqIndex)
            Dim index As Integer = Array.IndexOf(_data, Amp)
            Dim frequency As Double = _frequency(index)

            ' Check if the frequency is at least 0.6 apart from all existing frequencies
            If frequency <> 0 AndAlso highestFrequencies.All(Function(freq) Math.Abs(frequency - freq) >= 0.02) Then
                highestFrequencies.Add(frequency)
            Else
                freqIndex += 1
            End If
        Loop

        'sort
        Dim sortedfreq As List(Of Double) = highestFrequencies
        sortedfreq.Sort()
        sortedfreq.Reverse()

        Dim outputratios As List(Of Double) = New List(Of Double)

        For i = 0 To sortedfreq.Count - 1
            If i + 1 > sortedfreq.Count - 1 Then Exit For
            outputratios.Add(sortedfreq(i) / sortedfreq(i + 1))
        Next

        Dim averageRatio As Double = outputratios.Average()
        'Dim goldenRatio As Double = 1.618
        Dim maxDeviationFromGoldenRatio As Double = 0.2 ' 500% deviation from the golden ratio


        Dim goldenRatio As Double = 1.6180339875
        Dim deviation As Double = Math.Abs(averageRatio - goldenRatio) / goldenRatio
        Dim normalized_score As Double = 100 * (1 - deviation / maxDeviationFromGoldenRatio)


        If deviation > maxDeviationFromGoldenRatio Then
            normalized_score = 0 ' set score to 0 if too far from golden ratio
        End If



        Return (highestFrequencies, normalized_score, averageRatio)
    End Function

End Class
