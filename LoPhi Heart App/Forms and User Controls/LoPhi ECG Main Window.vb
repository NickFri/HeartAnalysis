Imports System.Threading

Partial Public Class ECG_MainForm
    Private comPort As String

    Private Shared ReadOnly CurrentVersion As New Version("1.0.3") ' Change this to your current version
    Private Shared ReadOnly UpdateUrl As String = "http://metacafebliss.com/ecg/update_info.txt" ' Change this to your update information URL
    ''' Graphing Settings
    Public interpolationLength As Integer = 2 ^ 13
    Public interpolationLengthHRV As Integer = 2 ^ 12

    Private Sub LoPhi_MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckAndUpdate()
        checksettings()

        LoadToolStrips()
        DefaultBolFontLoad()
        CepstrumHistoryUIRenderer()
        CepstrumUIRenderer()
        ECGUIRenderer()
        FFTUIRenderer()
        HeartGuideUIRenderer()
        HRVUIRenderer()

        DefaulPositionLoader()
        HomeTab()

        SelectCOMPort()
    End Sub

    Public Sub RenderOnBeat(bufferThirtySeconds As Double(), beatRates As List(Of Double), samplerateBeforeInterpolation As Double)
        If Not Me.IsDisposed Then
            Me.Invoke(Sub()
                          Dim sampleRate As Double = interpolationLength / (bufferThirtySeconds.Count / samplerateBeforeInterpolation)

                          Dim interpolateddata() As Double = ComputaionLibrary.InterpolateData(interpolationLength, bufferThirtySeconds.Length, bufferThirtySeconds)
                          ComputaionLibrary.NormalizeData(interpolateddata)

                          Dim fftdata() As Double = ComputaionLibrary.ComputeFFT(interpolateddata, sampleRate)
                          Dim fftfreq As Double() = FftSharp.Transform.FFTfreq(sampleRate, fftdata.Length)

                          Dim cepstrumData() As Double = ComputaionLibrary.ComputeCepstrum(fftdata, fftfreq)
                          Dim cepstrumFrequency As Double() = FftSharp.Transform.FFTfreq(1 / fftfreq(1) - fftfreq(0), cepstrumData.Length)

                          ' needs cepstrum data
                          HandleFFT3Coherence(cepstrumData)
                          'needs cepstrum / fft data
                          RenderCepstrum(cepstrumFrequency, cepstrumData, sampleRate)
                          RenderFFT(fftfreq, fftdata, sampleRate)
                          ' uses beatrates/beattimes
                          PlotHeartGuide()
                          HandleHRVFFTGraph()
                          UpdateBPMLabel()
                          UpdateBeatToBeatGraph()
                      End Sub)
        End If
    End Sub

    Private Sub SelectCOMPort()
        Using frm As FormCOMPort = New FormCOMPort()
            frm.ShowDialog()
            comPort = frm.comPort
        End Using

        If comPort < "" Then
            MessageBox.Show("No input device was selected, so nothing will be graphed.", "ERROR")
        Else
            StartListeningECG()
        End If
    End Sub

    Private Sub StartListeningECG()
        Try
            Initialize_COM_Communication(comPort)
        Catch
            MsgBox("Error: Could not connect to device. Please check your connection and try again.", MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
    End Sub

    Private Sub LoPhi_MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Save settings / Cancel the running tasks
        If cancellationTokenSource IsNot Nothing AndAlso Not cancellationTokenSource.Token.IsCancellationRequested Then
            cancellationTokenSource.Cancel()
            ' Wait for the tasks to complete
            Dim updateMessagesTask As Task = Task.Run(Sub() UpdateMessages(cancellationTokenSource.Token))
            Dim updateGraphGraphicsTask As Task = Task.Run(Sub() UpdateGraphGraphics(cancellationTokenSource.Token))
            Task.WaitAll(updateMessagesTask, updateGraphGraphicsTask)
        End If
    End Sub

End Class
