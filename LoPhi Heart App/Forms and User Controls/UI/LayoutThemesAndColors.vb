Partial Public Class ECG_MainForm
    Private Sub CadetBlueGrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadetBlueGrayToolStripMenuItem.Click
        'Me.BackColor = ColorTranslator.FromHtml(TextBox3.Text)
        'changePanelsBackground(ColorTranslator.FromHtml(TextBox2.Text))
        'changePanelsTabColor(ColorTranslator.FromHtml(TextBox1.Text))

        Me.BackColor = Color.CadetBlue
        changePanelsBackground(Color.FromArgb(180, 180, 180))
        changePanelsTabColor(Color.FromArgb(200, 200, 200))
    End Sub

    Private Sub changePanelsBackground(color As Color)
        RRPanel.BackColor = color
        CepstrumPanel.BackColor = color
        CepstrumHistoryPanel.BackColor = color
        ScorePanel.BackColor = color
        HeartGuidePanel.BackColor = color
        ECGPanel.BackColor = color
        HRVFFTPanel.BackColor = color
        ScoreBasedPlot.BackColor = color
        FFTPanel.BackColor = color
    End Sub

    Private Sub changePanelsTabColor(color As Color)
        'Frame_Beat_To_Beat_TaskBar.BackColor = color
        'Frame_Cepstrum_Data_TaskBar.BackColor = color
        'Frame_Cepstrum_History_TaskBar.BackColor = color
        ' Frame_Coherence_Graph_TaskBar.BackColor = color
        'Frame_HRV_Guide_TaskBar.BackColor = color
        'Frame_RawECG_TaskBar2.BackColor = color
        'Frame_RR_FFT_TaskBar.BackColor = color
        'Frame_RawFFT_Data_TaskBar.BackColor = color
    End Sub

    Dim RawECGpoint As New Point
    Dim HRVGuidepoint As New Point
    Dim CepDatapoint As New Point
    Dim CepHistorypoint As New Point
    Dim RawFFTpoint As New Point
    Dim Scorepoint As New Point
    Dim HRVpoint As New Point
    Dim HRVFFTpoint As New Point
    Dim Onlinepoint As New Point
    Dim FFT3PanelPoint As New Point
    Dim MyHeight As Integer

    Private Sub HomeTab()

        Dim MyHeight As Integer = Me.Height
        Dim homeTabLayouts As New List(Of PanelLayoutClass) From {
        New PanelLayoutClass(ECGPanel, New Size(700, 223), True, RawECGpoint),
        New PanelLayoutClass(HeartGuidePanel, New Size(700, 223), True, HRVGuidepoint),
        New PanelLayoutClass(CepstrumPanel, New Size(700, 223), True, CepDatapoint),
        New PanelLayoutClass(FFTPanel, New Size(700, 461), True, RawFFTpoint),
        New PanelLayoutClass(RRPanel, New Size(700, 223), False, HRVpoint),
        New PanelLayoutClass(HRVFFTPanel, New Size(700, 223), True, HRVFFTpoint),
        New PanelLayoutClass(CepstrumHistoryPanel, New Size(700, 223), False, CepHistorypoint),
        New PanelLayoutClass(ScorePanel, New Size(700, 223), False, Scorepoint),
        New PanelLayoutClass(PlayOnlinePanel, New Size(1094, 439), False, Onlinepoint),
        New PanelLayoutClass(FFT3Panel, New Size(700, 223), False, FFT3PanelPoint)}

        ApplyLayout(homeTabLayouts, MyHeight)
    End Sub

    Private Sub ApplyLayout(panelLayouts As List(Of PanelLayoutClass), layoutHeight As Integer)
        For Each Panel In panelLayouts
            Panel.SetPanelLayout()
        Next
        Me.Height = layoutHeight
    End Sub



    Private Sub DefaultBolFontLoad()
        HzONOFFToolStripMenuItem.Font = New Font(HzONOFFToolStripMenuItem.Font, FontStyle.Bold)
        ToolStripMenuItem8.Font = New Font(ToolStripMenuItem8.Font, FontStyle.Bold)
        Scale00X04ToolStripMenuItem.Font = New Font(Scale00X04ToolStripMenuItem.Font, FontStyle.Bold)
        AutoScaleToolStripMenuItem.Font = New Font(AutoScaleToolStripMenuItem.Font, FontStyle.Bold)
    End Sub

    Private Sub DefaulPositionLoader()
        'setup default locations
        RawECGpoint.X = Me.ECGPanel.Location.X
        RawECGpoint.Y = Me.ECGPanel.Location.Y


        HRVGuidepoint.X = HeartGuidePanel.Location.X
        HRVGuidepoint.Y = HeartGuidePanel.Location.Y

        CepDatapoint.X = CepstrumPanel.Location.X
        CepDatapoint.Y = CepstrumPanel.Location.Y

        RawFFTpoint.X = FFTPanel.Location.X
        RawFFTpoint.Y = FFTPanel.Location.Y

        HRVFFTpoint.X = HRVFFTPanel.Location.X
        HRVFFTpoint.Y = HRVFFTPanel.Location.Y

        Onlinepoint.X = PlayOnlinePanel.Location.X
        Onlinepoint.Y = PlayOnlinePanel.Location.Y

        FFT3PanelPoint.X = FFT3Panel.Location.X
        FFT3PanelPoint.Y = FFT3Panel.Location.Y

        CepHistorypoint.X = CepstrumHistoryPanel.Location.X
        CepHistorypoint.Y = CepstrumHistoryPanel.Location.Y

        Scorepoint.X = ScorePanel.Location.X
        Scorepoint.Y = ScorePanel.Location.Y

        HRVpoint.X = RRPanel.Location.X
        HRVpoint.Y = RRPanel.Location.Y

        Dim MyHeight As Integer

        MyHeight = Me.Height

        If My.Settings("fft_LP") = 0 Or IsNothing(My.Settings("fft_LP")) Then
            My.Settings("fft_LP") = Convert.ToDecimal(30.0)
            My.Settings.Save()
        End If
        If My.Settings("cep_LP") = 0 Or IsNothing(My.Settings("cep_LP")) Then
            My.Settings("cep_LP") = Convert.ToDecimal(10.0)
            My.Settings.Save()
        End If
        If My.Settings("fft_Y") = 0 Or IsNothing(My.Settings("fft_Y")) Then
            My.Settings("fft_Y") = Convert.ToDecimal(235.0)
            My.Settings.Save()
        End If

    End Sub

End Class