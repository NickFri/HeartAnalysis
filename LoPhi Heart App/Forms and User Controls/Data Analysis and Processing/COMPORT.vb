Imports System.Collections.Concurrent
Imports System.IO.Ports
Imports System.Timers

Partial Public Class ECG_MainForm

    Private _serialPort As SerialPort
    Private _30SecondDataBuffer As New ConcurrentQueue(Of Double) 'Changed from Double to Integer
    Private _5SecondECGBuffer As Integer() = Enumerable.Repeat(1024, 5000).ToArray() 'Renamed for clarity
    Private ReadOnly _pairDataByte As Byte = 67
    Private _bufferCleanupTimer As Timers.Timer
    Private _beatCheckTimer As Timers.Timer
    Private _isBeatDetected As Boolean = False
    Private _bufferPosition As Integer
    Private _sampleCount As Integer
    Public beatThreshold As Integer = 3000
    Private _isAboveThreshold As Boolean
    Private _startTime As DateTime
    Private _previousSampleTime As DateTime? = Nothing
    Private ReadOnly _sampleIntervals As New Queue(Of Double)(5000)
    Private ReadOnly _sampleRateAverageCount As Integer = 5000
    Private _sampleIntervalsLock As New Object


    Private Sub Initialize_COM_Communication(comPort As String)
        ' Serial port initialization
        _serialPort = New SerialPort(comPort) With {.BaudRate = 115200}
        _bufferCleanupTimer = New Timers.Timer With {.Interval = 30000}
        _beatCheckTimer = New Timers.Timer With {.Interval = 2200, .AutoReset = False}
        _bufferPosition = 0
        _sampleCount = 0

        ' Event handlers
        AddHandler _bufferCleanupTimer.Elapsed, AddressOf CleanupOldBufferData
        AddHandler _beatCheckTimer.Elapsed, AddressOf checkForNoBeat
        AddHandler _serialPort.DataReceived, AddressOf OnDataReceived

        _startTime = DateTime.Now
        IntializeECGGraph()
        _beatCheckTimer.Start()
        _bufferCleanupTimer.Start()

        ' Start communication
        Try
            Console.WriteLine($"Starting serial port...")
            _serialPort.Open()
        Catch
            Application.Exit()
        End Try
        _serialPort.BaseStream.WriteByte(_pairDataByte)
    End Sub


    Private Sub OnDataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        ' extract value
        Dim value As Integer

        Try
            value = Convert.ToInt32(_SerialPort.ReadLine())
        Catch ex As TimeoutException
            Console.WriteLine("Error: Serial Port read timed out.")
            _SerialPort.BaseStream.WriteByte(_pairDataByte)
            Exit Sub
        Catch ex As Exception
            Console.WriteLine($"Error reading serial data: {ex.Message}")
            _SerialPort.BaseStream.WriteByte(_pairDataByte)
            Exit Sub
        End Try

        ' add to buffers
        _sampleCount += 1

        ' Calculate the interval from the last sample
        Dim currentSampleTimea = DateTime.Now
        If _previousSampleTime.HasValue Then
            SyncLock _sampleIntervalsLock
                Dim intervalInSeconds = (currentSampleTimea - _previousSampleTime.Value).TotalSeconds
                _sampleIntervals.Enqueue(intervalInSeconds)

                '' Ensure we only keep the last 'sampleRateMovingAverageCount' intervals
                'If _sampleIntervals.Count > _sampleRateAverageCount Then
                '    _sampleIntervals.Dequeue()
                'End If


                ' Operations on _sampleIntervals
                _sampleIntervals.Enqueue(intervalInSeconds)
                If _sampleIntervals.Count > _sampleRateAverageCount Then
                    _sampleIntervals.Dequeue()
                End If
            End SyncLock
        End If
        _previousSampleTime = currentSampleTimea

        ' don't go any futher if no beat detected
        If _isBeatDetected = False Then
            If value > beatThreshold Then
                Dim currentSampleTime = DateTime.Now
                Dim elapsedTime = currentSampleTime - _startTime
                BeatDetected(elapsedTime.TotalSeconds)
                _isAboveThreshold = True
                _isBeatDetected = True
                If Not _beatCheckTimer.Enabled Then
                    _beatCheckTimer.Stop()
                    _beatCheckTimer.Start()
                End If
            End If
            Try
                _SerialPort.BaseStream.WriteByte(_pairDataByte)
            Catch
                Application.Exit()
            End Try

            Exit Sub
        End If

        If _bufferPosition >= 5000 Then
            _bufferPosition = 0
        End If
        _5SecondECGBuffer(_bufferPosition) = value
        _bufferPosition += 1

        _30SecondDataBuffer.Enqueue(value)


        If value > beatThreshold Then
            If Not _isAboveThreshold Then
                Dim currentSampleTime = DateTime.Now
                Dim elapsedTime = currentSampleTime - _startTime
                BeatDetected(elapsedTime.TotalSeconds)
                _isAboveThreshold = True
                If Not _beatCheckTimer.Enabled Then
                    _beatCheckTimer.Stop()
                    _beatCheckTimer.Start()
                End If
            End If
        Else
            _isAboveThreshold = False
        End If

        ' try again
        Try
            _SerialPort.BaseStream.WriteByte(_pairDataByte)
        Catch
            Application.Exit()
        End Try
    End Sub

    Private Sub CleanupOldBufferData()
        Dim samplesToRetain = 30 * GetEstimatedSampleRate()
        While _30SecondDataBuffer.Count > samplesToRetain
            Dim removedValue As Integer
            _30SecondDataBuffer.TryDequeue(removedValue)
        End While
    End Sub

    Private Function GetEstimatedSampleRate() As Double
        If _sampleIntervals.Count = 0 Then
            Return 0 ' or any default value indicating no rate available yet
        End If
        SyncLock _sampleIntervalsLock
            Dim averageInterval = _sampleIntervals.Average()
            Return 1 / averageInterval
        End SyncLock
    End Function

    Private Sub checkForNoBeat(ByVal sender As Object, ByVal e As ElapsedEventArgs)
        _isBeatDetected = False
        Dim g As String = "asdf"
        Try
            _SerialPort.BaseStream.WriteByte(_pairDataByte)
        Catch
            Application.Exit()
        End Try
    End Sub


    ''' BEAT DETECTION
    Public beatTimes As List(Of Double) = New List(Of Double)()
    Public beatRates As List(Of Double) = New List(Of Double)()
    Public fifty_beat_buffer As List(Of Double) = New List(Of Double)()
    Public startValue_master As Double = -36
    Dim abc As List(Of Double) = New List(Of Double)
    Dim abcd As List(Of Double) = New List(Of Double)

    Private Sub BeatDetected(ByVal timeSec As Double)
        Dim beatRate As Double = 0
        If beatTimes.Count > 0 Then
            Dim beatToBeatTime As Double = timeSec - beatTimes(beatTimes.Count - 1)
            beatRate = 1.0 / beatToBeatTime * 60
            If beatRate > 250 Then Return
        End If

        beatTimes.Add(timeSec)
        If beatTimes.Count >= 2 Then
            beatRates.Add(beatRate)
            fifty_beat_buffer.Add(beatRate)
        End If

        While beatRates.Count > HRV_Beat_Count_Data '50 '
            '
            '
            '
            '_Beat_Count_Data
            beatRates.RemoveAt(0)
            beatTimes.RemoveAt(0)
        End While


        If fifty_beat_buffer.Count = 50 Then
            fifty_beat_buffer.RemoveRange(0, fifty_beat_buffer.Count - 5)
            startValue_master += 50 - 5
        End If


        If beatRates.Count > 4 Then
            Dim dataArray As Double() = _30SecondDataBuffer.ToArray()
            Dim samplerateBeforeInterpolation As Double = GetEstimatedSampleRate()
            RenderOnBeat(dataArray, beatRates, samplerateBeforeInterpolation)
            abc.Add(GetEstimatedSampleRate())
        End If
    End Sub

End Class
