<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class ECG_MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ECG_MainForm))
        TSHeartGuide = New ToolStripButton()
        TSPlayOnline = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        TSRRFFT = New ToolStripButton()
        TSRR = New ToolStripButton()
        TSCoherGra = New ToolStripButton()
        TSRawECGFFT = New ToolStripButton()
        TSCepHist = New ToolStripButton()
        TSCep = New ToolStripButton()
        TSHome = New ToolStripButton()
        LoPhi_Toolstrip_Select_Input = New ToolStripButton()
        LoPhi_ToolStrip = New ToolStrip()
        TSECG = New ToolStripButton()
        TSFFT3 = New ToolStripButton()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        Settings_Tool_Themes = New ToolStripMenuItem()
        GrayToolStripMenuItem1 = New ToolStripMenuItem()
        BlueToolStripMenuItem1 = New ToolStripMenuItem()
        CadetBlueGrayToolStripMenuItem = New ToolStripMenuItem()
        SaveLayoutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        RecallToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        SaveToolStripMenuItem1 = New ToolStripMenuItem()
        RecallToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        SaveToolStripMenuItem2 = New ToolStripMenuItem()
        RecallToolStripMenuItem2 = New ToolStripMenuItem()
        ExportECGToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ChangeHRVDataLengthToolStripMenuItem = New ToolStripMenuItem()
        HRVFFTPanel = New Panel()
        Frame_RR_FFT_Resize = New PictureBox()
        Frame_RR_FFT_Close_Button = New PictureBox()
        TaskBarRRIntervalFFTX = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        HRVFFTGraph = New ScottPlot.FormsPlot()
        ToolStripHRVFFT = New ToolStrip()
        ToolStripLabel13 = New ToolStripLabel()
        ToolStripSeparator8 = New ToolStripSeparator()
        ToolStripDropDownButton8 = New ToolStripDropDownButton()
        Scale00X04ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripMenuItem()
        ToolStripMenuItem8 = New ToolStripMenuItem()
        CurrentRatioToolStripMenuItem1 = New ToolStripMenuItem()
        Frame_RR_FFT_Score = New ToolStripLabel()
        ToolStripHRVCurrentRatio = New ToolStripLabel()
        ScorePanel = New Panel()
        Frame_Coherence_Graph_Close_Button = New PictureBox()
        Frame_Coherence_Graph_Resize = New PictureBox()
        TaskBarCoherenceGraphX = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        ScoreBasedPlot = New ScottPlot.FormsPlot()
        ToolStripScoreGraph = New ToolStrip()
        ToolStripLabel9 = New ToolStripLabel()
        ToolStripSeparator5 = New ToolStripSeparator()
        ToolStripDropDownButton2 = New ToolStripDropDownButton()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        RRPanel = New Panel()
        Frame_Beat_To_Beat_Display_Length = New NumericUpDown()
        Frame_Beat_To_Beat_Resize = New PictureBox()
        Frame_Beat_To_Beat_Close_Button = New PictureBox()
        TaskBarRRIntervalX = New PictureBox()
        PictureBox3 = New PictureBox()
        RRGraph = New ScottPlot.FormsPlot()
        ToolStripRRIntevalHRV = New ToolStrip()
        ToolStripLabel2 = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripLabel1 = New ToolStripLabel()
        CepstrumPanel = New Panel()
        Frame_Cepstrum_Data_Close_Button = New PictureBox()
        Frame_Cepstrum_Data_Resize = New PictureBox()
        TaskBarCepX = New PictureBox()
        CepstrumGraph = New ScottPlot.FormsPlot()
        ToolStripCepstrum = New ToolStrip()
        ToolStripLabel10 = New ToolStripLabel()
        ToolStripSeparator6 = New ToolStripSeparator()
        ToolStripDropDownButton3 = New ToolStripDropDownButton()
        MaxCepstrumTrackingToolStripMenuItem = New ToolStripMenuItem()
        OnToolStripMenuItem1 = New ToolStripMenuItem()
        OffToolStripMenuItem1 = New ToolStripMenuItem()
        ResetToolStripMenuItem1 = New ToolStripMenuItem()
        LowPassFilterToolStripMenuItem = New ToolStripMenuItem()
        SizeToolStripMenuItem = New ToolStripMenuItem()
        HzONOFFToolStripMenuItem = New ToolStripMenuItem()
        EnablePHIScoreToolStripMenuItem = New ToolStripMenuItem()
        cepstrum_score_txt = New ToolStripLabel()
        HeartGuidePanel = New Panel()
        Frame_HRV_Guide_Close_Button = New PictureBox()
        Frame_HRV_Guide_Resize = New PictureBox()
        Frame_HRV_Guide_Height_Setting = New NumericUpDown()
        TaskBarHRVGuideX = New PictureBox()
        Frame_HRV_Guide_Frequency_Setting = New NumericUpDown()
        HeartGuidePlot = New ScottPlot.FormsPlot()
        ToolStripHeartGuide = New ToolStrip()
        ToolStripLabel3 = New ToolStripLabel()
        ToolStripSeparator3 = New ToolStripSeparator()
        ToolStripLabel4 = New ToolStripLabel()
        ToolStripLabel5 = New ToolStripLabel()
        ToolStripDropDownButton1 = New ToolStripDropDownButton()
        PHIToolStripMenuItem = New ToolStripMenuItem()
        OctaveToolStripMenuItem = New ToolStripMenuItem()
        SineToolStripMenuItem = New ToolStripMenuItem()
        ECGPanel = New Panel()
        Frame_RawECG_Close_Button = New PictureBox()
        Frame_ECG_Resize = New PictureBox()
        Frame_RawECG_Threshold = New NumericUpDown()
        RawECGGraph = New ScottPlot.FormsPlot()
        TaskBarRawECGX = New PictureBox()
        ToolStripECGData = New ToolStrip()
        ToolStripLabel6 = New ToolStripLabel()
        ToolStripSeparator4 = New ToolStripSeparator()
        BPMtoolstripLabel = New ToolStripLabel()
        ToolStripDropDownButton5 = New ToolStripDropDownButton()
        DataCaptureToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripLabel7 = New ToolStripLabel()
        CepstrumHistoryGraph = New ScottPlot.FormsPlot()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        TaskBarCepHistoryX = New PictureBox()
        Frame_Cepstrum_History_Amount_Setting = New NumericUpDown()
        CepstrumHistoryPanel = New Panel()
        Frame_Cepstrum_History_Resize = New PictureBox()
        Frame_Cepstrum_History_Close_Button = New PictureBox()
        ToolStripCepstrumHistory = New ToolStrip()
        ToolStripLabel15 = New ToolStripLabel()
        ToolStripSeparator9 = New ToolStripSeparator()
        ToolStripDropDownButton10 = New ToolStripDropDownButton()
        ToolStripMenuItem9 = New ToolStripMenuItem()
        ONOFFToolStripMenuItem = New ToolStripMenuItem()
        XToolStripMenuItem = New ToolStripMenuItem()
        YToolStripMenuItem = New ToolStripMenuItem()
        ToolStripLabel16 = New ToolStripLabel()
        FFTPanel = New Panel()
        Frame_RawFFT_Data_Close_Button = New PictureBox()
        Frame_RawFFT_Data_Resize = New PictureBox()
        DanwinterLink = New LinkLabel()
        TaskBarRawFFTX = New PictureBox()
        FFTGraph = New ScottPlot.FormsPlot()
        ToolStripFFT = New ToolStrip()
        ToolStripLabel11 = New ToolStripLabel()
        ToolStripSeparator7 = New ToolStripSeparator()
        ToolStripDropDownButton6 = New ToolStripDropDownButton()
        PeaklinesONOFFToolStripMenuItem = New ToolStripMenuItem()
        LowPassFilterToolStripMenuItem1 = New ToolStripMenuItem()
        ScaleToolStripMenuItem = New ToolStripMenuItem()
        XScaleToolStripMenuItem = New ToolStripMenuItem()
        YScaleToolStripMenuItem1 = New ToolStripMenuItem()
        CurrentRatioToolStripMenuItem = New ToolStripMenuItem()
        Frame_RawFFT_Data_Score = New ToolStripLabel()
        ToolStripCurrentRatio = New ToolStripLabel()
        FFT3Panel = New Panel()
        FFT3Plottable = New ScottPlot.FormsPlot()
        Frame_FFT3Coherence_Resize = New PictureBox()
        Frame_FFT3_Coherence_Close_Button = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        ToolStripFFT3Coherence = New ToolStrip()
        ToolStripLabel8 = New ToolStripLabel()
        ToolStripSeparator10 = New ToolStripSeparator()
        PlayOnlinePanel = New Panel()
        Frame_PlayOnline_Close_Button = New PictureBox()
        CepHistory_Resize = New PictureBox()
        PlayOnlineGraph = New ScottPlot.FormsPlot()
        RBPublicRoom = New RadioButton()
        RBjoinSession = New RadioButton()
        RBcreateSession = New RadioButton()
        Label1 = New Label()
        btnJoinSession = New Button()
        Session_ID_TXT = New TextBox()
        btnCreateSession = New Button()
        ChatBox = New TextBox()
        Label2 = New Label()
        PictureBox27 = New PictureBox()
        PictureBox28 = New PictureBox()
        PictureBox29 = New PictureBox()
        PictureBox30 = New PictureBox()
        PictureBox31 = New PictureBox()
        PictureBox32 = New PictureBox()
        PictureBox33 = New PictureBox()
        ToolStripOnlinePlay = New ToolStrip()
        ToolStripLabel14 = New ToolStripLabel()
        ToolStripSeparator12 = New ToolStripSeparator()
        ToolStripDropDownButton4 = New ToolStripDropDownButton()
        ChangeNameToolStripMenuItem = New ToolStripMenuItem()
        HeightToolStripMenuItem = New ToolStripMenuItem()
        HeightDownToolStripMenuItem = New ToolStripMenuItem()
        AutoScaleToolStripMenuItem = New ToolStripMenuItem()
        messageTxt = New TextBox()
        btnSend = New Button()
        LoPhi_ToolStrip.SuspendLayout()
        HRVFFTPanel.SuspendLayout()
        CType(Frame_RR_FFT_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_RR_FFT_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarRRIntervalFFTX, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripHRVFFT.SuspendLayout()
        ScorePanel.SuspendLayout()
        CType(Frame_Coherence_Graph_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_Coherence_Graph_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarCoherenceGraphX, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripScoreGraph.SuspendLayout()
        RRPanel.SuspendLayout()
        CType(Frame_Beat_To_Beat_Display_Length, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_Beat_To_Beat_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_Beat_To_Beat_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarRRIntervalX, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripRRIntevalHRV.SuspendLayout()
        CepstrumPanel.SuspendLayout()
        CType(Frame_Cepstrum_Data_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_Cepstrum_Data_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarCepX, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripCepstrum.SuspendLayout()
        HeartGuidePanel.SuspendLayout()
        CType(Frame_HRV_Guide_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_HRV_Guide_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_HRV_Guide_Height_Setting, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarHRVGuideX, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_HRV_Guide_Frequency_Setting, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripHeartGuide.SuspendLayout()
        ECGPanel.SuspendLayout()
        CType(Frame_RawECG_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_ECG_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_RawECG_Threshold, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarRawECGX, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripECGData.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarCepHistoryX, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_Cepstrum_History_Amount_Setting, ComponentModel.ISupportInitialize).BeginInit()
        CepstrumHistoryPanel.SuspendLayout()
        CType(Frame_Cepstrum_History_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_Cepstrum_History_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripCepstrumHistory.SuspendLayout()
        FFTPanel.SuspendLayout()
        CType(Frame_RawFFT_Data_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_RawFFT_Data_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBarRawFFTX, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripFFT.SuspendLayout()
        FFT3Panel.SuspendLayout()
        CType(Frame_FFT3Coherence_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frame_FFT3_Coherence_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripFFT3Coherence.SuspendLayout()
        PlayOnlinePanel.SuspendLayout()
        CType(Frame_PlayOnline_Close_Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(CepHistory_Resize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox27, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox28, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox29, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox30, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox31, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox32, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox33, ComponentModel.ISupportInitialize).BeginInit()
        ToolStripOnlinePlay.SuspendLayout()
        SuspendLayout()
        ' 
        ' TSHeartGuide
        ' 
        TSHeartGuide.Image = My.Resources.Resources.healthcare_icon
        TSHeartGuide.ImageTransparentColor = Color.Magenta
        TSHeartGuide.Name = "TSHeartGuide"
        TSHeartGuide.Size = New Size(90, 22)
        TSHeartGuide.Tag = "HeartGuidePanel"
        TSHeartGuide.Text = "Heart Guide"
        ' 
        ' TSPlayOnline
        ' 
        TSPlayOnline.Image = My.Resources.Resources.rose_aroma_icon
        TSPlayOnline.ImageTransparentColor = Color.Magenta
        TSPlayOnline.Name = "TSPlayOnline"
        TSPlayOnline.Size = New Size(84, 22)
        TSPlayOnline.Tag = "PlayOnlinePanel"
        TSPlayOnline.Text = "PlayOnline"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Margin = New Padding(4, 0, 10, 0)
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' TSRRFFT
        ' 
        TSRRFFT.Image = My.Resources.Resources.bar_chart_icon
        TSRRFFT.ImageTransparentColor = Color.Magenta
        TSRRFFT.Name = "TSRRFFT"
        TSRRFFT.Size = New Size(71, 22)
        TSRRFFT.Tag = "HRVFFTPanel"
        TSRRFFT.Text = "HRV FFT"
        ' 
        ' TSRR
        ' 
        TSRR.Image = My.Resources.Resources.analyze_sound_wave_icon
        TSRR.ImageTransparentColor = Color.Magenta
        TSRR.Name = "TSRR"
        TSRR.Size = New Size(50, 22)
        TSRR.Tag = "RRPanel"
        TSRR.Text = "HRV"
        ' 
        ' TSCoherGra
        ' 
        TSCoherGra.Image = My.Resources.Resources.goal_icon
        TSCoherGra.ImageTransparentColor = Color.Magenta
        TSCoherGra.Name = "TSCoherGra"
        TSCoherGra.Size = New Size(90, 22)
        TSCoherGra.Tag = "ScorePanel"
        TSCoherGra.Text = "Score graph"
        ' 
        ' TSRawECGFFT
        ' 
        TSRawECGFFT.Image = My.Resources.Resources.graph_icon
        TSRawECGFFT.ImageTransparentColor = Color.Magenta
        TSRawECGFFT.Name = "TSRawECGFFT"
        TSRawECGFFT.Size = New Size(70, 22)
        TSRawECGFFT.Tag = "FFTPanel"
        TSRawECGFFT.Text = "ECG FFT"
        ' 
        ' TSCepHist
        ' 
        TSCepHist.Image = My.Resources.Resources.challenge_target_icon
        TSCepHist.ImageTransparentColor = Color.Magenta
        TSCepHist.Name = "TSCepHist"
        TSCepHist.Size = New Size(120, 22)
        TSCepHist.Tag = "CepstrumHistoryPanel"
        TSCepHist.Text = "Cepstrum History"
        ' 
        ' TSCep
        ' 
        TSCep.Image = My.Resources.Resources.fitness_icon
        TSCep.ImageTransparentColor = Color.Magenta
        TSCep.Name = "TSCep"
        TSCep.Size = New Size(79, 22)
        TSCep.Tag = "CepstrumPanel"
        TSCep.Text = "Cepstrum"
        ' 
        ' TSHome
        ' 
        TSHome.Image = My.Resources.Resources.home_icon
        TSHome.ImageTransparentColor = Color.Plum
        TSHome.Name = "TSHome"
        TSHome.RightToLeft = RightToLeft.No
        TSHome.Size = New Size(99, 22)
        TSHome.Text = "Home Layout"
        ' 
        ' LoPhi_Toolstrip_Select_Input
        ' 
        LoPhi_Toolstrip_Select_Input.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LoPhi_Toolstrip_Select_Input.ImageTransparentColor = Color.Magenta
        LoPhi_Toolstrip_Select_Input.Name = "LoPhi_Toolstrip_Select_Input"
        LoPhi_Toolstrip_Select_Input.Size = New Size(79, 22)
        LoPhi_Toolstrip_Select_Input.Text = "Select Input"
        ' 
        ' LoPhi_ToolStrip
        ' 
        LoPhi_ToolStrip.BackColor = SystemColors.GradientActiveCaption
        LoPhi_ToolStrip.GripStyle = ToolStripGripStyle.Hidden
        LoPhi_ToolStrip.Items.AddRange(New ToolStripItem() {LoPhi_Toolstrip_Select_Input, TSHome, TSECG, TSRR, TSRRFFT, TSRawECGFFT, TSHeartGuide, TSCep, TSCepHist, TSFFT3, TSCoherGra, ToolStripSeparator2, TSPlayOnline, ToolStripSplitButton1})
        LoPhi_ToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        LoPhi_ToolStrip.Location = New Point(0, 0)
        LoPhi_ToolStrip.Name = "LoPhi_ToolStrip"
        LoPhi_ToolStrip.Padding = New Padding(10, 0, 0, 0)
        LoPhi_ToolStrip.Size = New Size(1433, 25)
        LoPhi_ToolStrip.Stretch = True
        LoPhi_ToolStrip.TabIndex = 77
        LoPhi_ToolStrip.Text = "ToolStrip"
        ' 
        ' TSECG
        ' 
        TSECG.Image = My.Resources.Resources.heart_beat_icon
        TSECG.ImageTransparentColor = Color.Magenta
        TSECG.Name = "TSECG"
        TSECG.Size = New Size(73, 22)
        TSECG.Tag = "ECGPanel"
        TSECG.Text = "ECG Plot"
        ' 
        ' TSFFT3
        ' 
        TSFFT3.Image = My.Resources.Resources.four_squares_icon
        TSFFT3.ImageTransparentColor = Color.Magenta
        TSFFT3.Name = "TSFFT3"
        TSFFT3.Size = New Size(51, 22)
        TSFFT3.Tag = "FFT3Panel"
        TSFFT3.Text = "FFT3"
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.DropDownItems.AddRange(New ToolStripItem() {Settings_Tool_Themes, SaveLayoutToolStripMenuItem, ExportECGToolStripMenuItem, ToolStripMenuItem1, ChangeHRVDataLengthToolStripMenuItem})
        ToolStripSplitButton1.Image = My.Resources.Resources.gear_icon
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Margin = New Padding(0, 1, 10, 2)
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(81, 22)
        ToolStripSplitButton1.Text = "Settings"
        ' 
        ' Settings_Tool_Themes
        ' 
        Settings_Tool_Themes.DropDownItems.AddRange(New ToolStripItem() {GrayToolStripMenuItem1, BlueToolStripMenuItem1, CadetBlueGrayToolStripMenuItem})
        Settings_Tool_Themes.Name = "Settings_Tool_Themes"
        Settings_Tool_Themes.Size = New Size(208, 22)
        Settings_Tool_Themes.Text = "Theme(s)"
        ' 
        ' GrayToolStripMenuItem1
        ' 
        GrayToolStripMenuItem1.Name = "GrayToolStripMenuItem1"
        GrayToolStripMenuItem1.Size = New Size(180, 22)
        GrayToolStripMenuItem1.Text = "Gray"
        ' 
        ' BlueToolStripMenuItem1
        ' 
        BlueToolStripMenuItem1.Name = "BlueToolStripMenuItem1"
        BlueToolStripMenuItem1.Size = New Size(180, 22)
        BlueToolStripMenuItem1.Text = "Blue"
        ' 
        ' CadetBlueGrayToolStripMenuItem
        ' 
        CadetBlueGrayToolStripMenuItem.Name = "CadetBlueGrayToolStripMenuItem"
        CadetBlueGrayToolStripMenuItem.Size = New Size(180, 22)
        CadetBlueGrayToolStripMenuItem.Text = "Cadet Blue & Gray"
        ' 
        ' SaveLayoutToolStripMenuItem
        ' 
        SaveLayoutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem3, ToolStripMenuItem4, ToolStripMenuItem5})
        SaveLayoutToolStripMenuItem.Name = "SaveLayoutToolStripMenuItem"
        SaveLayoutToolStripMenuItem.Size = New Size(208, 22)
        SaveLayoutToolStripMenuItem.Text = "Save/Recall Layout"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.DropDownItems.AddRange(New ToolStripItem() {SaveToolStripMenuItem, RecallToolStripMenuItem})
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(80, 22)
        ToolStripMenuItem3.Text = "1"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(105, 22)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' RecallToolStripMenuItem
        ' 
        RecallToolStripMenuItem.Name = "RecallToolStripMenuItem"
        RecallToolStripMenuItem.Size = New Size(105, 22)
        RecallToolStripMenuItem.Text = "Recall"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.DropDownItems.AddRange(New ToolStripItem() {SaveToolStripMenuItem1, RecallToolStripMenuItem1})
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(80, 22)
        ToolStripMenuItem4.Text = "2"
        ' 
        ' SaveToolStripMenuItem1
        ' 
        SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        SaveToolStripMenuItem1.Size = New Size(105, 22)
        SaveToolStripMenuItem1.Text = "Save"
        ' 
        ' RecallToolStripMenuItem1
        ' 
        RecallToolStripMenuItem1.Name = "RecallToolStripMenuItem1"
        RecallToolStripMenuItem1.Size = New Size(105, 22)
        RecallToolStripMenuItem1.Text = "Recall"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.DropDownItems.AddRange(New ToolStripItem() {SaveToolStripMenuItem2, RecallToolStripMenuItem2})
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(80, 22)
        ToolStripMenuItem5.Text = "3"
        ' 
        ' SaveToolStripMenuItem2
        ' 
        SaveToolStripMenuItem2.Name = "SaveToolStripMenuItem2"
        SaveToolStripMenuItem2.Size = New Size(105, 22)
        SaveToolStripMenuItem2.Text = "Save"
        ' 
        ' RecallToolStripMenuItem2
        ' 
        RecallToolStripMenuItem2.Name = "RecallToolStripMenuItem2"
        RecallToolStripMenuItem2.Size = New Size(105, 22)
        RecallToolStripMenuItem2.Text = "Recall"
        ' 
        ' ExportECGToolStripMenuItem
        ' 
        ExportECGToolStripMenuItem.Name = "ExportECGToolStripMenuItem"
        ExportECGToolStripMenuItem.Size = New Size(208, 22)
        ExportECGToolStripMenuItem.Text = "Export ECG Data"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(208, 22)
        ToolStripMenuItem1.Text = "Export HRV Data"
        ' 
        ' ChangeHRVDataLengthToolStripMenuItem
        ' 
        ChangeHRVDataLengthToolStripMenuItem.Name = "ChangeHRVDataLengthToolStripMenuItem"
        ChangeHRVDataLengthToolStripMenuItem.Size = New Size(208, 22)
        ChangeHRVDataLengthToolStripMenuItem.Text = "Change HRV Data Length"
        ' 
        ' HRVFFTPanel
        ' 
        HRVFFTPanel.BackColor = SystemColors.ActiveBorder
        HRVFFTPanel.BorderStyle = BorderStyle.FixedSingle
        HRVFFTPanel.Controls.Add(Frame_RR_FFT_Resize)
        HRVFFTPanel.Controls.Add(Frame_RR_FFT_Close_Button)
        HRVFFTPanel.Controls.Add(TaskBarRRIntervalFFTX)
        HRVFFTPanel.Controls.Add(PictureBox4)
        HRVFFTPanel.Controls.Add(PictureBox5)
        HRVFFTPanel.Controls.Add(HRVFFTGraph)
        HRVFFTPanel.Controls.Add(ToolStripHRVFFT)
        HRVFFTPanel.Location = New Point(722, 505)
        HRVFFTPanel.Name = "HRVFFTPanel"
        HRVFFTPanel.Size = New Size(700, 223)
        HRVFFTPanel.TabIndex = 84
        ' 
        ' Frame_RR_FFT_Resize
        ' 
        Frame_RR_FFT_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_RR_FFT_Resize.BackColor = Color.Transparent
        Frame_RR_FFT_Resize.Cursor = Cursors.SizeNWSE
        Frame_RR_FFT_Resize.Location = New Point(688, 210)
        Frame_RR_FFT_Resize.Name = "Frame_RR_FFT_Resize"
        Frame_RR_FFT_Resize.Size = New Size(11, 12)
        Frame_RR_FFT_Resize.TabIndex = 98
        Frame_RR_FFT_Resize.TabStop = False
        ' 
        ' Frame_RR_FFT_Close_Button
        ' 
        Frame_RR_FFT_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_RR_FFT_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_RR_FFT_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_RR_FFT_Close_Button.Location = New Point(680, 0)
        Frame_RR_FFT_Close_Button.Name = "Frame_RR_FFT_Close_Button"
        Frame_RR_FFT_Close_Button.Size = New Size(18, 18)
        Frame_RR_FFT_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_RR_FFT_Close_Button.TabIndex = 95
        Frame_RR_FFT_Close_Button.TabStop = False
        ' 
        ' TaskBarRRIntervalFFTX
        ' 
        TaskBarRRIntervalFFTX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarRRIntervalFFTX.Location = New Point(1176, 0)
        TaskBarRRIntervalFFTX.Name = "TaskBarRRIntervalFFTX"
        TaskBarRRIntervalFFTX.Size = New Size(18, 17)
        TaskBarRRIntervalFFTX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarRRIntervalFFTX.TabIndex = 68
        TaskBarRRIntervalFFTX.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox4.Location = New Point(1672, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(18, 17)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 66
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox5.BackColor = SystemColors.ScrollBar
        PictureBox5.Location = New Point(2167, 0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(18, 18)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 59
        PictureBox5.TabStop = False
        ' 
        ' HRVFFTGraph
        ' 
        HRVFFTGraph.AutoSizeMode = AutoSizeMode.GrowAndShrink
        HRVFFTGraph.Dock = DockStyle.Fill
        HRVFFTGraph.Location = New Point(0, 22)
        HRVFFTGraph.Margin = New Padding(0)
        HRVFFTGraph.Name = "HRVFFTGraph"
        HRVFFTGraph.Size = New Size(698, 199)
        HRVFFTGraph.TabIndex = 17
        ' 
        ' ToolStripHRVFFT
        ' 
        ToolStripHRVFFT.AutoSize = False
        ToolStripHRVFFT.BackColor = SystemColors.ScrollBar
        ToolStripHRVFFT.GripMargin = New Padding(0)
        ToolStripHRVFFT.GripStyle = ToolStripGripStyle.Hidden
        ToolStripHRVFFT.Items.AddRange(New ToolStripItem() {ToolStripLabel13, ToolStripSeparator8, ToolStripDropDownButton8, Frame_RR_FFT_Score, ToolStripHRVCurrentRatio})
        ToolStripHRVFFT.Location = New Point(0, 0)
        ToolStripHRVFFT.Name = "ToolStripHRVFFT"
        ToolStripHRVFFT.Padding = New Padding(0)
        ToolStripHRVFFT.Size = New Size(698, 22)
        ToolStripHRVFFT.TabIndex = 111
        ToolStripHRVFFT.Text = "ToolStrip2"
        ' 
        ' ToolStripLabel13
        ' 
        ToolStripLabel13.Name = "ToolStripLabel13"
        ToolStripLabel13.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel13.Size = New Size(101, 19)
        ToolStripLabel13.Text = "HRV FFT"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(6, 22)
        ' 
        ' ToolStripDropDownButton8
        ' 
        ToolStripDropDownButton8.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton8.DropDownItems.AddRange(New ToolStripItem() {Scale00X04ToolStripMenuItem, ToolStripMenuItem7, ToolStripMenuItem8, CurrentRatioToolStripMenuItem1})
        ToolStripDropDownButton8.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton8.Name = "ToolStripDropDownButton8"
        ToolStripDropDownButton8.Size = New Size(62, 19)
        ToolStripDropDownButton8.Text = "Options"
        ' 
        ' Scale00X04ToolStripMenuItem
        ' 
        Scale00X04ToolStripMenuItem.Name = "Scale00X04ToolStripMenuItem"
        Scale00X04ToolStripMenuItem.Size = New Size(168, 22)
        Scale00X04ToolStripMenuItem.Text = "Scale 0.0 > x < 0.4"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(168, 22)
        ToolStripMenuItem7.Text = "Peaklines"
        ' 
        ' ToolStripMenuItem8
        ' 
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New Size(168, 22)
        ToolStripMenuItem8.Text = "Show color"
        ' 
        ' CurrentRatioToolStripMenuItem1
        ' 
        CurrentRatioToolStripMenuItem1.Name = "CurrentRatioToolStripMenuItem1"
        CurrentRatioToolStripMenuItem1.Size = New Size(168, 22)
        CurrentRatioToolStripMenuItem1.Text = "Current Ratio"
        ' 
        ' Frame_RR_FFT_Score
        ' 
        Frame_RR_FFT_Score.Margin = New Padding(40, 1, 0, 2)
        Frame_RR_FFT_Score.Name = "Frame_RR_FFT_Score"
        Frame_RR_FFT_Score.Size = New Size(48, 19)
        Frame_RR_FFT_Score.Text = "Score  0"
        ' 
        ' ToolStripHRVCurrentRatio
        ' 
        ToolStripHRVCurrentRatio.Margin = New Padding(30, 1, 0, 2)
        ToolStripHRVCurrentRatio.Name = "ToolStripHRVCurrentRatio"
        ToolStripHRVCurrentRatio.Size = New Size(80, 19)
        ToolStripHRVCurrentRatio.Text = "Current Ratio "
        ToolStripHRVCurrentRatio.Visible = False
        ' 
        ' ScorePanel
        ' 
        ScorePanel.BackColor = SystemColors.ActiveBorder
        ScorePanel.BorderStyle = BorderStyle.FixedSingle
        ScorePanel.Controls.Add(Frame_Coherence_Graph_Close_Button)
        ScorePanel.Controls.Add(Frame_Coherence_Graph_Resize)
        ScorePanel.Controls.Add(TaskBarCoherenceGraphX)
        ScorePanel.Controls.Add(PictureBox10)
        ScorePanel.Controls.Add(PictureBox11)
        ScorePanel.Controls.Add(ScoreBasedPlot)
        ScorePanel.Controls.Add(ToolStripScoreGraph)
        ScorePanel.Location = New Point(126, 256)
        ScorePanel.Name = "ScorePanel"
        ScorePanel.Size = New Size(700, 223)
        ScorePanel.TabIndex = 85
        ' 
        ' Frame_Coherence_Graph_Close_Button
        ' 
        Frame_Coherence_Graph_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_Coherence_Graph_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_Coherence_Graph_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_Coherence_Graph_Close_Button.Location = New Point(680, 0)
        Frame_Coherence_Graph_Close_Button.Name = "Frame_Coherence_Graph_Close_Button"
        Frame_Coherence_Graph_Close_Button.Size = New Size(18, 18)
        Frame_Coherence_Graph_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_Coherence_Graph_Close_Button.TabIndex = 93
        Frame_Coherence_Graph_Close_Button.TabStop = False
        ' 
        ' Frame_Coherence_Graph_Resize
        ' 
        Frame_Coherence_Graph_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_Coherence_Graph_Resize.BackColor = Color.Transparent
        Frame_Coherence_Graph_Resize.Cursor = Cursors.SizeNWSE
        Frame_Coherence_Graph_Resize.Location = New Point(687, 210)
        Frame_Coherence_Graph_Resize.Name = "Frame_Coherence_Graph_Resize"
        Frame_Coherence_Graph_Resize.Size = New Size(11, 12)
        Frame_Coherence_Graph_Resize.TabIndex = 98
        Frame_Coherence_Graph_Resize.TabStop = False
        ' 
        ' TaskBarCoherenceGraphX
        ' 
        TaskBarCoherenceGraphX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarCoherenceGraphX.Location = New Point(1176, 1)
        TaskBarCoherenceGraphX.Name = "TaskBarCoherenceGraphX"
        TaskBarCoherenceGraphX.Size = New Size(18, 17)
        TaskBarCoherenceGraphX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarCoherenceGraphX.TabIndex = 71
        TaskBarCoherenceGraphX.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox10.Location = New Point(1672, 0)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(18, 17)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 66
        PictureBox10.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox11.BackColor = SystemColors.ScrollBar
        PictureBox11.Location = New Point(2167, 0)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(18, 18)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 59
        PictureBox11.TabStop = False
        ' 
        ' ScoreBasedPlot
        ' 
        ScoreBasedPlot.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ScoreBasedPlot.Dock = DockStyle.Fill
        ScoreBasedPlot.Location = New Point(0, 22)
        ScoreBasedPlot.Margin = New Padding(0)
        ScoreBasedPlot.Name = "ScoreBasedPlot"
        ScoreBasedPlot.Size = New Size(698, 199)
        ScoreBasedPlot.TabIndex = 17
        ' 
        ' ToolStripScoreGraph
        ' 
        ToolStripScoreGraph.AutoSize = False
        ToolStripScoreGraph.BackColor = SystemColors.ScrollBar
        ToolStripScoreGraph.GripMargin = New Padding(0)
        ToolStripScoreGraph.GripStyle = ToolStripGripStyle.Hidden
        ToolStripScoreGraph.Items.AddRange(New ToolStripItem() {ToolStripLabel9, ToolStripSeparator5, ToolStripDropDownButton2})
        ToolStripScoreGraph.Location = New Point(0, 0)
        ToolStripScoreGraph.Name = "ToolStripScoreGraph"
        ToolStripScoreGraph.Padding = New Padding(0)
        ToolStripScoreGraph.Size = New Size(698, 22)
        ToolStripScoreGraph.TabIndex = 104
        ToolStripScoreGraph.Text = "ToolStrip2"
        ' 
        ' ToolStripLabel9
        ' 
        ToolStripLabel9.Name = "ToolStripLabel9"
        ToolStripLabel9.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel9.Size = New Size(121, 19)
        ToolStripLabel9.Text = "Score Graph"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(6, 22)
        ' 
        ' ToolStripDropDownButton2
        ' 
        ToolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton2.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem6})
        ToolStripDropDownButton2.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton2.Margin = New Padding(5, 1, 0, 2)
        ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        ToolStripDropDownButton2.Size = New Size(51, 19)
        ToolStripDropDownButton2.Text = "Mode"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(105, 22)
        ToolStripMenuItem2.Text = "Chart"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(105, 22)
        ToolStripMenuItem6.Text = "Game"
        ' 
        ' RRPanel
        ' 
        RRPanel.BackColor = SystemColors.ActiveBorder
        RRPanel.BorderStyle = BorderStyle.FixedSingle
        RRPanel.Controls.Add(Frame_Beat_To_Beat_Display_Length)
        RRPanel.Controls.Add(Frame_Beat_To_Beat_Resize)
        RRPanel.Controls.Add(Frame_Beat_To_Beat_Close_Button)
        RRPanel.Controls.Add(TaskBarRRIntervalX)
        RRPanel.Controls.Add(PictureBox3)
        RRPanel.Controls.Add(RRGraph)
        RRPanel.Controls.Add(ToolStripRRIntevalHRV)
        RRPanel.Location = New Point(714, 572)
        RRPanel.Name = "RRPanel"
        RRPanel.Size = New Size(700, 223)
        RRPanel.TabIndex = 83
        ' 
        ' Frame_Beat_To_Beat_Display_Length
        ' 
        Frame_Beat_To_Beat_Display_Length.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_Beat_To_Beat_Display_Length.Font = New Font("Segoe UI", 7.0F, FontStyle.Regular, GraphicsUnit.Point)
        Frame_Beat_To_Beat_Display_Length.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Frame_Beat_To_Beat_Display_Length.Location = New Point(617, 51)
        Frame_Beat_To_Beat_Display_Length.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Frame_Beat_To_Beat_Display_Length.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Frame_Beat_To_Beat_Display_Length.Name = "Frame_Beat_To_Beat_Display_Length"
        Frame_Beat_To_Beat_Display_Length.Size = New Size(57, 20)
        Frame_Beat_To_Beat_Display_Length.TabIndex = 61
        Frame_Beat_To_Beat_Display_Length.Value = New Decimal(New Integer() {50, 0, 0, 0})
        ' 
        ' Frame_Beat_To_Beat_Resize
        ' 
        Frame_Beat_To_Beat_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_Beat_To_Beat_Resize.BackColor = Color.Transparent
        Frame_Beat_To_Beat_Resize.Cursor = Cursors.SizeNWSE
        Frame_Beat_To_Beat_Resize.Location = New Point(687, 210)
        Frame_Beat_To_Beat_Resize.Name = "Frame_Beat_To_Beat_Resize"
        Frame_Beat_To_Beat_Resize.Size = New Size(11, 12)
        Frame_Beat_To_Beat_Resize.TabIndex = 98
        Frame_Beat_To_Beat_Resize.TabStop = False
        ' 
        ' Frame_Beat_To_Beat_Close_Button
        ' 
        Frame_Beat_To_Beat_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_Beat_To_Beat_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_Beat_To_Beat_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_Beat_To_Beat_Close_Button.Location = New Point(681, 0)
        Frame_Beat_To_Beat_Close_Button.Name = "Frame_Beat_To_Beat_Close_Button"
        Frame_Beat_To_Beat_Close_Button.Size = New Size(18, 18)
        Frame_Beat_To_Beat_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_Beat_To_Beat_Close_Button.TabIndex = 94
        Frame_Beat_To_Beat_Close_Button.TabStop = False
        ' 
        ' TaskBarRRIntervalX
        ' 
        TaskBarRRIntervalX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarRRIntervalX.Location = New Point(1176, 0)
        TaskBarRRIntervalX.Name = "TaskBarRRIntervalX"
        TaskBarRRIntervalX.Size = New Size(18, 17)
        TaskBarRRIntervalX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarRRIntervalX.TabIndex = 66
        TaskBarRRIntervalX.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox3.BackColor = SystemColors.ScrollBar
        PictureBox3.Location = New Point(1671, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(18, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 59
        PictureBox3.TabStop = False
        ' 
        ' RRGraph
        ' 
        RRGraph.AutoSizeMode = AutoSizeMode.GrowAndShrink
        RRGraph.Dock = DockStyle.Fill
        RRGraph.Location = New Point(0, 22)
        RRGraph.Margin = New Padding(0)
        RRGraph.Name = "RRGraph"
        RRGraph.Size = New Size(698, 199)
        RRGraph.TabIndex = 17
        ' 
        ' ToolStripRRIntevalHRV
        ' 
        ToolStripRRIntevalHRV.AutoSize = False
        ToolStripRRIntevalHRV.BackColor = SystemColors.ScrollBar
        ToolStripRRIntevalHRV.GripMargin = New Padding(0)
        ToolStripRRIntevalHRV.GripStyle = ToolStripGripStyle.Hidden
        ToolStripRRIntevalHRV.Items.AddRange(New ToolStripItem() {ToolStripLabel2, ToolStripSeparator1, ToolStripLabel1})
        ToolStripRRIntevalHRV.Location = New Point(0, 0)
        ToolStripRRIntevalHRV.Name = "ToolStripRRIntevalHRV"
        ToolStripRRIntevalHRV.Padding = New Padding(0)
        ToolStripRRIntevalHRV.Size = New Size(698, 22)
        ToolStripRRIntevalHRV.TabIndex = 100
        ToolStripRRIntevalHRV.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel2.Size = New Size(139, 19)
        ToolStripLabel2.Text = "RR Interval HRV"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 22)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(77, 19)
        ToolStripLabel1.Text = "Data Length: "
        ' 
        ' CepstrumPanel
        ' 
        CepstrumPanel.BackColor = SystemColors.ActiveBorder
        CepstrumPanel.BorderStyle = BorderStyle.FixedSingle
        CepstrumPanel.Controls.Add(Frame_Cepstrum_Data_Close_Button)
        CepstrumPanel.Controls.Add(Frame_Cepstrum_Data_Resize)
        CepstrumPanel.Controls.Add(TaskBarCepX)
        CepstrumPanel.Controls.Add(CepstrumGraph)
        CepstrumPanel.Controls.Add(ToolStripCepstrum)
        CepstrumPanel.Location = New Point(8, 506)
        CepstrumPanel.Name = "CepstrumPanel"
        CepstrumPanel.Size = New Size(700, 223)
        CepstrumPanel.TabIndex = 81
        ' 
        ' Frame_Cepstrum_Data_Close_Button
        ' 
        Frame_Cepstrum_Data_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_Cepstrum_Data_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_Cepstrum_Data_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_Cepstrum_Data_Close_Button.Location = New Point(681, 0)
        Frame_Cepstrum_Data_Close_Button.Name = "Frame_Cepstrum_Data_Close_Button"
        Frame_Cepstrum_Data_Close_Button.Size = New Size(18, 18)
        Frame_Cepstrum_Data_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_Cepstrum_Data_Close_Button.TabIndex = 90
        Frame_Cepstrum_Data_Close_Button.TabStop = False
        ' 
        ' Frame_Cepstrum_Data_Resize
        ' 
        Frame_Cepstrum_Data_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_Cepstrum_Data_Resize.BackColor = Color.Transparent
        Frame_Cepstrum_Data_Resize.Cursor = Cursors.SizeNWSE
        Frame_Cepstrum_Data_Resize.Location = New Point(688, 210)
        Frame_Cepstrum_Data_Resize.Name = "Frame_Cepstrum_Data_Resize"
        Frame_Cepstrum_Data_Resize.Size = New Size(11, 12)
        Frame_Cepstrum_Data_Resize.TabIndex = 99
        Frame_Cepstrum_Data_Resize.TabStop = False
        ' 
        ' TaskBarCepX
        ' 
        TaskBarCepX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarCepX.BackColor = SystemColors.ScrollBar
        TaskBarCepX.Location = New Point(1175, 0)
        TaskBarCepX.Name = "TaskBarCepX"
        TaskBarCepX.Size = New Size(18, 18)
        TaskBarCepX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarCepX.TabIndex = 59
        TaskBarCepX.TabStop = False
        ' 
        ' CepstrumGraph
        ' 
        CepstrumGraph.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CepstrumGraph.Dock = DockStyle.Fill
        CepstrumGraph.Location = New Point(0, 22)
        CepstrumGraph.Margin = New Padding(0)
        CepstrumGraph.Name = "CepstrumGraph"
        CepstrumGraph.Size = New Size(698, 199)
        CepstrumGraph.TabIndex = 60
        ' 
        ' ToolStripCepstrum
        ' 
        ToolStripCepstrum.AutoSize = False
        ToolStripCepstrum.BackColor = SystemColors.ScrollBar
        ToolStripCepstrum.GripMargin = New Padding(0)
        ToolStripCepstrum.GripStyle = ToolStripGripStyle.Hidden
        ToolStripCepstrum.Items.AddRange(New ToolStripItem() {ToolStripLabel10, ToolStripSeparator6, ToolStripDropDownButton3, cepstrum_score_txt})
        ToolStripCepstrum.Location = New Point(0, 0)
        ToolStripCepstrum.Name = "ToolStripCepstrum"
        ToolStripCepstrum.Padding = New Padding(0)
        ToolStripCepstrum.Size = New Size(698, 22)
        ToolStripCepstrum.TabIndex = 108
        ToolStripCepstrum.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel10
        ' 
        ToolStripLabel10.Name = "ToolStripLabel10"
        ToolStripLabel10.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel10.Size = New Size(109, 19)
        ToolStripLabel10.Text = "Cepstrum"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(6, 22)
        ' 
        ' ToolStripDropDownButton3
        ' 
        ToolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton3.DropDownItems.AddRange(New ToolStripItem() {MaxCepstrumTrackingToolStripMenuItem, LowPassFilterToolStripMenuItem, SizeToolStripMenuItem, EnablePHIScoreToolStripMenuItem})
        ToolStripDropDownButton3.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        ToolStripDropDownButton3.Size = New Size(62, 19)
        ToolStripDropDownButton3.Text = "Options"
        ' 
        ' MaxCepstrumTrackingToolStripMenuItem
        ' 
        MaxCepstrumTrackingToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OnToolStripMenuItem1, OffToolStripMenuItem1, ResetToolStripMenuItem1})
        MaxCepstrumTrackingToolStripMenuItem.Name = "MaxCepstrumTrackingToolStripMenuItem"
        MaxCepstrumTrackingToolStripMenuItem.Size = New Size(199, 22)
        MaxCepstrumTrackingToolStripMenuItem.Text = "Max Cepstrum Tracking"
        ' 
        ' OnToolStripMenuItem1
        ' 
        OnToolStripMenuItem1.Name = "OnToolStripMenuItem1"
        OnToolStripMenuItem1.Size = New Size(102, 22)
        OnToolStripMenuItem1.Text = "On"
        ' 
        ' OffToolStripMenuItem1
        ' 
        OffToolStripMenuItem1.Name = "OffToolStripMenuItem1"
        OffToolStripMenuItem1.Size = New Size(102, 22)
        OffToolStripMenuItem1.Text = "Off"
        ' 
        ' ResetToolStripMenuItem1
        ' 
        ResetToolStripMenuItem1.Name = "ResetToolStripMenuItem1"
        ResetToolStripMenuItem1.Size = New Size(102, 22)
        ResetToolStripMenuItem1.Text = "Reset"
        ' 
        ' LowPassFilterToolStripMenuItem
        ' 
        LowPassFilterToolStripMenuItem.Name = "LowPassFilterToolStripMenuItem"
        LowPassFilterToolStripMenuItem.Size = New Size(199, 22)
        LowPassFilterToolStripMenuItem.Text = "LowPassFilter"
        ' 
        ' SizeToolStripMenuItem
        ' 
        SizeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HzONOFFToolStripMenuItem})
        SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        SizeToolStripMenuItem.Size = New Size(199, 22)
        SizeToolStripMenuItem.Text = "Scale"
        ' 
        ' HzONOFFToolStripMenuItem
        ' 
        HzONOFFToolStripMenuItem.Name = "HzONOFFToolStripMenuItem"
        HzONOFFToolStripMenuItem.Size = New Size(127, 22)
        HzONOFFToolStripMenuItem.Text = "0.01-1.1hz"
        ' 
        ' EnablePHIScoreToolStripMenuItem
        ' 
        EnablePHIScoreToolStripMenuItem.Name = "EnablePHIScoreToolStripMenuItem"
        EnablePHIScoreToolStripMenuItem.Size = New Size(199, 22)
        EnablePHIScoreToolStripMenuItem.Text = "Enable PHI Score"
        ' 
        ' cepstrum_score_txt
        ' 
        cepstrum_score_txt.Margin = New Padding(20, 1, 0, 2)
        cepstrum_score_txt.Name = "cepstrum_score_txt"
        cepstrum_score_txt.Size = New Size(36, 19)
        cepstrum_score_txt.Text = "Score"
        cepstrum_score_txt.Visible = False
        ' 
        ' HeartGuidePanel
        ' 
        HeartGuidePanel.BackColor = SystemColors.ActiveBorder
        HeartGuidePanel.BorderStyle = BorderStyle.FixedSingle
        HeartGuidePanel.Controls.Add(Frame_HRV_Guide_Close_Button)
        HeartGuidePanel.Controls.Add(Frame_HRV_Guide_Resize)
        HeartGuidePanel.Controls.Add(Frame_HRV_Guide_Height_Setting)
        HeartGuidePanel.Controls.Add(TaskBarHRVGuideX)
        HeartGuidePanel.Controls.Add(Frame_HRV_Guide_Frequency_Setting)
        HeartGuidePanel.Controls.Add(HeartGuidePlot)
        HeartGuidePanel.Controls.Add(ToolStripHeartGuide)
        HeartGuidePanel.Location = New Point(8, 268)
        HeartGuidePanel.Name = "HeartGuidePanel"
        HeartGuidePanel.Size = New Size(700, 223)
        HeartGuidePanel.TabIndex = 80
        ' 
        ' Frame_HRV_Guide_Close_Button
        ' 
        Frame_HRV_Guide_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_HRV_Guide_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_HRV_Guide_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_HRV_Guide_Close_Button.Location = New Point(680, -1)
        Frame_HRV_Guide_Close_Button.Name = "Frame_HRV_Guide_Close_Button"
        Frame_HRV_Guide_Close_Button.Size = New Size(18, 18)
        Frame_HRV_Guide_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_HRV_Guide_Close_Button.TabIndex = 89
        Frame_HRV_Guide_Close_Button.TabStop = False
        ' 
        ' Frame_HRV_Guide_Resize
        ' 
        Frame_HRV_Guide_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_HRV_Guide_Resize.BackColor = Color.Transparent
        Frame_HRV_Guide_Resize.Cursor = Cursors.SizeNWSE
        Frame_HRV_Guide_Resize.Location = New Point(687, 209)
        Frame_HRV_Guide_Resize.Name = "Frame_HRV_Guide_Resize"
        Frame_HRV_Guide_Resize.Size = New Size(11, 12)
        Frame_HRV_Guide_Resize.TabIndex = 97
        Frame_HRV_Guide_Resize.TabStop = False
        ' 
        ' Frame_HRV_Guide_Height_Setting
        ' 
        Frame_HRV_Guide_Height_Setting.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_HRV_Guide_Height_Setting.Font = New Font("Segoe UI", 7.0F, FontStyle.Regular, GraphicsUnit.Point)
        Frame_HRV_Guide_Height_Setting.Location = New Point(626, 45)
        Frame_HRV_Guide_Height_Setting.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Frame_HRV_Guide_Height_Setting.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Frame_HRV_Guide_Height_Setting.Name = "Frame_HRV_Guide_Height_Setting"
        Frame_HRV_Guide_Height_Setting.Size = New Size(47, 20)
        Frame_HRV_Guide_Height_Setting.TabIndex = 62
        Frame_HRV_Guide_Height_Setting.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' TaskBarHRVGuideX
        ' 
        TaskBarHRVGuideX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarHRVGuideX.BackColor = SystemColors.ScrollBar
        TaskBarHRVGuideX.Location = New Point(1175, 0)
        TaskBarHRVGuideX.Name = "TaskBarHRVGuideX"
        TaskBarHRVGuideX.Size = New Size(18, 18)
        TaskBarHRVGuideX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarHRVGuideX.TabIndex = 59
        TaskBarHRVGuideX.TabStop = False
        ' 
        ' Frame_HRV_Guide_Frequency_Setting
        ' 
        Frame_HRV_Guide_Frequency_Setting.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_HRV_Guide_Frequency_Setting.DecimalPlaces = 2
        Frame_HRV_Guide_Frequency_Setting.Font = New Font("Segoe UI", 7.0F, FontStyle.Regular, GraphicsUnit.Point)
        Frame_HRV_Guide_Frequency_Setting.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Frame_HRV_Guide_Frequency_Setting.Location = New Point(523, 45)
        Frame_HRV_Guide_Frequency_Setting.Maximum = New Decimal(New Integer() {50, 0, 0, 131072})
        Frame_HRV_Guide_Frequency_Setting.Minimum = New Decimal(New Integer() {2, 0, 0, 131072})
        Frame_HRV_Guide_Frequency_Setting.Name = "Frame_HRV_Guide_Frequency_Setting"
        Frame_HRV_Guide_Frequency_Setting.Size = New Size(47, 20)
        Frame_HRV_Guide_Frequency_Setting.TabIndex = 26
        Frame_HRV_Guide_Frequency_Setting.Value = New Decimal(New Integer() {2, 0, 0, 65536})
        ' 
        ' HeartGuidePlot
        ' 
        HeartGuidePlot.AutoSizeMode = AutoSizeMode.GrowAndShrink
        HeartGuidePlot.Dock = DockStyle.Fill
        HeartGuidePlot.Location = New Point(0, 22)
        HeartGuidePlot.Margin = New Padding(0)
        HeartGuidePlot.Name = "HeartGuidePlot"
        HeartGuidePlot.Size = New Size(698, 199)
        HeartGuidePlot.TabIndex = 60
        ' 
        ' ToolStripHeartGuide
        ' 
        ToolStripHeartGuide.AutoSize = False
        ToolStripHeartGuide.BackColor = SystemColors.ScrollBar
        ToolStripHeartGuide.GripMargin = New Padding(0)
        ToolStripHeartGuide.GripStyle = ToolStripGripStyle.Hidden
        ToolStripHeartGuide.Items.AddRange(New ToolStripItem() {ToolStripLabel3, ToolStripSeparator3, ToolStripLabel4, ToolStripLabel5, ToolStripDropDownButton1})
        ToolStripHeartGuide.Location = New Point(0, 0)
        ToolStripHeartGuide.Name = "ToolStripHeartGuide"
        ToolStripHeartGuide.Padding = New Padding(0)
        ToolStripHeartGuide.Size = New Size(698, 22)
        ToolStripHeartGuide.TabIndex = 101
        ToolStripHeartGuide.Text = "ToolStrip2"
        ' 
        ' ToolStripLabel3
        ' 
        ToolStripLabel3.Name = "ToolStripLabel3"
        ToolStripLabel3.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel3.Size = New Size(120, 19)
        ToolStripLabel3.Text = "Heart Guide"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 22)
        ' 
        ' ToolStripLabel4
        ' 
        ToolStripLabel4.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel4.Name = "ToolStripLabel4"
        ToolStripLabel4.Size = New Size(66, 19)
        ToolStripLabel4.Text = "Amplitude:"
        ' 
        ' ToolStripLabel5
        ' 
        ToolStripLabel5.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel5.Name = "ToolStripLabel5"
        ToolStripLabel5.Size = New Size(129, 19)
        ToolStripLabel5.Text = "Frequency Component"
        ' 
        ' ToolStripDropDownButton1
        ' 
        ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton1.DropDownItems.AddRange(New ToolStripItem() {PHIToolStripMenuItem, OctaveToolStripMenuItem, SineToolStripMenuItem})
        ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton1.Margin = New Padding(5, 1, 0, 2)
        ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        ToolStripDropDownButton1.Size = New Size(51, 19)
        ToolStripDropDownButton1.Text = "Mode"
        ' 
        ' PHIToolStripMenuItem
        ' 
        PHIToolStripMenuItem.Name = "PHIToolStripMenuItem"
        PHIToolStripMenuItem.Size = New Size(111, 22)
        PHIToolStripMenuItem.Text = "PHI"
        ' 
        ' OctaveToolStripMenuItem
        ' 
        OctaveToolStripMenuItem.Name = "OctaveToolStripMenuItem"
        OctaveToolStripMenuItem.Size = New Size(111, 22)
        OctaveToolStripMenuItem.Text = "Octave"
        ' 
        ' SineToolStripMenuItem
        ' 
        SineToolStripMenuItem.Name = "SineToolStripMenuItem"
        SineToolStripMenuItem.Size = New Size(111, 22)
        SineToolStripMenuItem.Text = "Sine"
        ' 
        ' ECGPanel
        ' 
        ECGPanel.BackColor = SystemColors.ActiveBorder
        ECGPanel.BorderStyle = BorderStyle.FixedSingle
        ECGPanel.Controls.Add(Frame_RawECG_Close_Button)
        ECGPanel.Controls.Add(Frame_ECG_Resize)
        ECGPanel.Controls.Add(Frame_RawECG_Threshold)
        ECGPanel.Controls.Add(RawECGGraph)
        ECGPanel.Controls.Add(TaskBarRawECGX)
        ECGPanel.Controls.Add(ToolStripECGData)
        ECGPanel.Location = New Point(9, 31)
        ECGPanel.Name = "ECGPanel"
        ECGPanel.Size = New Size(700, 223)
        ECGPanel.TabIndex = 79
        ' 
        ' Frame_RawECG_Close_Button
        ' 
        Frame_RawECG_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_RawECG_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_RawECG_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_RawECG_Close_Button.Location = New Point(680, 0)
        Frame_RawECG_Close_Button.Margin = New Padding(0)
        Frame_RawECG_Close_Button.Name = "Frame_RawECG_Close_Button"
        Frame_RawECG_Close_Button.Size = New Size(18, 18)
        Frame_RawECG_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_RawECG_Close_Button.TabIndex = 87
        Frame_RawECG_Close_Button.TabStop = False
        ' 
        ' Frame_ECG_Resize
        ' 
        Frame_ECG_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_ECG_Resize.BackColor = Color.Transparent
        Frame_ECG_Resize.Cursor = Cursors.SizeNWSE
        Frame_ECG_Resize.Location = New Point(687, 210)
        Frame_ECG_Resize.Name = "Frame_ECG_Resize"
        Frame_ECG_Resize.Size = New Size(11, 12)
        Frame_ECG_Resize.TabIndex = 95
        Frame_ECG_Resize.TabStop = False
        ' 
        ' Frame_RawECG_Threshold
        ' 
        Frame_RawECG_Threshold.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_RawECG_Threshold.BackColor = SystemColors.Window
        Frame_RawECG_Threshold.Font = New Font("Segoe UI", 7.0F, FontStyle.Regular, GraphicsUnit.Point)
        Frame_RawECG_Threshold.Location = New Point(620, 45)
        Frame_RawECG_Threshold.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Frame_RawECG_Threshold.Name = "Frame_RawECG_Threshold"
        Frame_RawECG_Threshold.Size = New Size(57, 20)
        Frame_RawECG_Threshold.TabIndex = 16
        Frame_RawECG_Threshold.Value = New Decimal(New Integer() {30, 0, 0, 0})
        ' 
        ' RawECGGraph
        ' 
        RawECGGraph.AutoSizeMode = AutoSizeMode.GrowAndShrink
        RawECGGraph.Dock = DockStyle.Fill
        RawECGGraph.ForeColor = SystemColors.ControlText
        RawECGGraph.Location = New Point(0, 22)
        RawECGGraph.Margin = New Padding(0)
        RawECGGraph.Name = "RawECGGraph"
        RawECGGraph.Size = New Size(698, 199)
        RawECGGraph.TabIndex = 0
        ' 
        ' TaskBarRawECGX
        ' 
        TaskBarRawECGX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarRawECGX.BackColor = SystemColors.ScrollBar
        TaskBarRawECGX.Location = New Point(1175, 0)
        TaskBarRawECGX.Name = "TaskBarRawECGX"
        TaskBarRawECGX.Size = New Size(18, 18)
        TaskBarRawECGX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarRawECGX.TabIndex = 59
        TaskBarRawECGX.TabStop = False
        ' 
        ' ToolStripECGData
        ' 
        ToolStripECGData.AutoSize = False
        ToolStripECGData.BackColor = SystemColors.ScrollBar
        ToolStripECGData.GripMargin = New Padding(0)
        ToolStripECGData.GripStyle = ToolStripGripStyle.Hidden
        ToolStripECGData.Items.AddRange(New ToolStripItem() {ToolStripLabel6, ToolStripSeparator4, BPMtoolstripLabel, ToolStripDropDownButton5, ToolStripLabel7})
        ToolStripECGData.Location = New Point(0, 0)
        ToolStripECGData.Name = "ToolStripECGData"
        ToolStripECGData.Padding = New Padding(0)
        ToolStripECGData.Size = New Size(698, 22)
        ToolStripECGData.TabIndex = 107
        ToolStripECGData.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel6
        ' 
        ToolStripLabel6.Name = "ToolStripLabel6"
        ToolStripLabel6.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel6.Size = New Size(106, 19)
        ToolStripLabel6.Text = "ECG Data"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 22)
        ' 
        ' BPMtoolstripLabel
        ' 
        BPMtoolstripLabel.Margin = New Padding(5, 1, 5, 2)
        BPMtoolstripLabel.Name = "BPMtoolstripLabel"
        BPMtoolstripLabel.Size = New Size(32, 19)
        BPMtoolstripLabel.Text = "BPM"
        ' 
        ' ToolStripDropDownButton5
        ' 
        ToolStripDropDownButton5.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton5.DropDownItems.AddRange(New ToolStripItem() {DataCaptureToolStripMenuItem1})
        ToolStripDropDownButton5.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton5.Margin = New Padding(5, 1, 0, 2)
        ToolStripDropDownButton5.Name = "ToolStripDropDownButton5"
        ToolStripDropDownButton5.Size = New Size(47, 19)
        ToolStripDropDownButton5.Text = "Scale"
        ' 
        ' DataCaptureToolStripMenuItem1
        ' 
        DataCaptureToolStripMenuItem1.Name = "DataCaptureToolStripMenuItem1"
        DataCaptureToolStripMenuItem1.Size = New Size(141, 22)
        DataCaptureToolStripMenuItem1.Text = "Window Size"
        ' 
        ' ToolStripLabel7
        ' 
        ToolStripLabel7.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel7.Name = "ToolStripLabel7"
        ToolStripLabel7.Size = New Size(115, 19)
        ToolStripLabel7.Text = "Beat Detection Line: "
        ' 
        ' CepstrumHistoryGraph
        ' 
        CepstrumHistoryGraph.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CepstrumHistoryGraph.Dock = DockStyle.Fill
        CepstrumHistoryGraph.Location = New Point(0, 22)
        CepstrumHistoryGraph.Margin = New Padding(0)
        CepstrumHistoryGraph.Name = "CepstrumHistoryGraph"
        CepstrumHistoryGraph.Size = New Size(698, 199)
        CepstrumHistoryGraph.TabIndex = 17
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox8.BackColor = SystemColors.ScrollBar
        PictureBox8.Location = New Point(2663, 0)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(18, 18)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 59
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox7.Location = New Point(2168, 0)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(18, 17)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 66
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox6.Location = New Point(1672, 0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(18, 17)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 68
        PictureBox6.TabStop = False
        ' 
        ' TaskBarCepHistoryX
        ' 
        TaskBarCepHistoryX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarCepHistoryX.Location = New Point(1177, 0)
        TaskBarCepHistoryX.Name = "TaskBarCepHistoryX"
        TaskBarCepHistoryX.Size = New Size(18, 17)
        TaskBarCepHistoryX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarCepHistoryX.TabIndex = 72
        TaskBarCepHistoryX.TabStop = False
        ' 
        ' Frame_Cepstrum_History_Amount_Setting
        ' 
        Frame_Cepstrum_History_Amount_Setting.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_Cepstrum_History_Amount_Setting.Font = New Font("Segoe UI", 7.0F, FontStyle.Regular, GraphicsUnit.Point)
        Frame_Cepstrum_History_Amount_Setting.Location = New Point(619, 21)
        Frame_Cepstrum_History_Amount_Setting.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Frame_Cepstrum_History_Amount_Setting.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Frame_Cepstrum_History_Amount_Setting.Name = "Frame_Cepstrum_History_Amount_Setting"
        Frame_Cepstrum_History_Amount_Setting.Size = New Size(57, 20)
        Frame_Cepstrum_History_Amount_Setting.TabIndex = 72
        Frame_Cepstrum_History_Amount_Setting.Value = New Decimal(New Integer() {11, 0, 0, 0})
        ' 
        ' CepstrumHistoryPanel
        ' 
        CepstrumHistoryPanel.BackColor = SystemColors.ActiveBorder
        CepstrumHistoryPanel.BorderStyle = BorderStyle.FixedSingle
        CepstrumHistoryPanel.Controls.Add(Frame_Cepstrum_History_Resize)
        CepstrumHistoryPanel.Controls.Add(Frame_Cepstrum_History_Close_Button)
        CepstrumHistoryPanel.Controls.Add(Frame_Cepstrum_History_Amount_Setting)
        CepstrumHistoryPanel.Controls.Add(TaskBarCepHistoryX)
        CepstrumHistoryPanel.Controls.Add(PictureBox6)
        CepstrumHistoryPanel.Controls.Add(PictureBox7)
        CepstrumHistoryPanel.Controls.Add(PictureBox8)
        CepstrumHistoryPanel.Controls.Add(CepstrumHistoryGraph)
        CepstrumHistoryPanel.Controls.Add(ToolStripCepstrumHistory)
        CepstrumHistoryPanel.Location = New Point(4, 624)
        CepstrumHistoryPanel.Name = "CepstrumHistoryPanel"
        CepstrumHistoryPanel.Size = New Size(700, 223)
        CepstrumHistoryPanel.TabIndex = 86
        ' 
        ' Frame_Cepstrum_History_Resize
        ' 
        Frame_Cepstrum_History_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_Cepstrum_History_Resize.BackColor = Color.Transparent
        Frame_Cepstrum_History_Resize.Cursor = Cursors.SizeNWSE
        Frame_Cepstrum_History_Resize.Location = New Point(687, 210)
        Frame_Cepstrum_History_Resize.Name = "Frame_Cepstrum_History_Resize"
        Frame_Cepstrum_History_Resize.Size = New Size(11, 12)
        Frame_Cepstrum_History_Resize.TabIndex = 99
        Frame_Cepstrum_History_Resize.TabStop = False
        ' 
        ' Frame_Cepstrum_History_Close_Button
        ' 
        Frame_Cepstrum_History_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_Cepstrum_History_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_Cepstrum_History_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_Cepstrum_History_Close_Button.Location = New Point(680, 0)
        Frame_Cepstrum_History_Close_Button.Name = "Frame_Cepstrum_History_Close_Button"
        Frame_Cepstrum_History_Close_Button.Size = New Size(18, 18)
        Frame_Cepstrum_History_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_Cepstrum_History_Close_Button.TabIndex = 92
        Frame_Cepstrum_History_Close_Button.TabStop = False
        ' 
        ' ToolStripCepstrumHistory
        ' 
        ToolStripCepstrumHistory.AutoSize = False
        ToolStripCepstrumHistory.BackColor = SystemColors.ScrollBar
        ToolStripCepstrumHistory.GripMargin = New Padding(0)
        ToolStripCepstrumHistory.GripStyle = ToolStripGripStyle.Hidden
        ToolStripCepstrumHistory.Items.AddRange(New ToolStripItem() {ToolStripLabel15, ToolStripSeparator9, ToolStripDropDownButton10, ToolStripLabel16})
        ToolStripCepstrumHistory.Location = New Point(0, 0)
        ToolStripCepstrumHistory.Name = "ToolStripCepstrumHistory"
        ToolStripCepstrumHistory.Padding = New Padding(0)
        ToolStripCepstrumHistory.Size = New Size(698, 22)
        ToolStripCepstrumHistory.TabIndex = 105
        ToolStripCepstrumHistory.Text = "ToolStrip2"
        ' 
        ' ToolStripLabel15
        ' 
        ToolStripLabel15.Name = "ToolStripLabel15"
        ToolStripLabel15.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel15.Size = New Size(150, 19)
        ToolStripLabel15.Text = "Cepstrum History"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(6, 22)
        ' 
        ' ToolStripDropDownButton10
        ' 
        ToolStripDropDownButton10.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton10.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem9})
        ToolStripDropDownButton10.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton10.Margin = New Padding(5, 1, 0, 2)
        ToolStripDropDownButton10.Name = "ToolStripDropDownButton10"
        ToolStripDropDownButton10.Size = New Size(51, 19)
        ToolStripDropDownButton10.Text = "Mode"
        ' 
        ' ToolStripMenuItem9
        ' 
        ToolStripMenuItem9.DropDownItems.AddRange(New ToolStripItem() {ONOFFToolStripMenuItem, XToolStripMenuItem, YToolStripMenuItem})
        ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        ToolStripMenuItem9.Size = New Size(145, 22)
        ToolStripMenuItem9.Text = "Waterfall Plot"
        ' 
        ' ONOFFToolStripMenuItem
        ' 
        ONOFFToolStripMenuItem.Name = "ONOFFToolStripMenuItem"
        ONOFFToolStripMenuItem.Size = New Size(118, 22)
        ONOFFToolStripMenuItem.Text = "ON/OFF"
        ' 
        ' XToolStripMenuItem
        ' 
        XToolStripMenuItem.Name = "XToolStripMenuItem"
        XToolStripMenuItem.Size = New Size(118, 22)
        XToolStripMenuItem.Text = "X"
        ' 
        ' YToolStripMenuItem
        ' 
        YToolStripMenuItem.Name = "YToolStripMenuItem"
        YToolStripMenuItem.Size = New Size(118, 22)
        YToolStripMenuItem.Text = "Y"
        ' 
        ' ToolStripLabel16
        ' 
        ToolStripLabel16.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel16.Name = "ToolStripLabel16"
        ToolStripLabel16.Size = New Size(77, 19)
        ToolStripLabel16.Text = "Data Length: "
        ' 
        ' FFTPanel
        ' 
        FFTPanel.BackColor = SystemColors.ActiveBorder
        FFTPanel.BorderStyle = BorderStyle.FixedSingle
        FFTPanel.Controls.Add(Frame_RawFFT_Data_Close_Button)
        FFTPanel.Controls.Add(Frame_RawFFT_Data_Resize)
        FFTPanel.Controls.Add(DanwinterLink)
        FFTPanel.Controls.Add(TaskBarRawFFTX)
        FFTPanel.Controls.Add(FFTGraph)
        FFTPanel.Controls.Add(ToolStripFFT)
        FFTPanel.Location = New Point(721, 30)
        FFTPanel.Name = "FFTPanel"
        FFTPanel.Size = New Size(700, 461)
        FFTPanel.TabIndex = 82
        ' 
        ' Frame_RawFFT_Data_Close_Button
        ' 
        Frame_RawFFT_Data_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_RawFFT_Data_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_RawFFT_Data_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_RawFFT_Data_Close_Button.Location = New Point(680, 0)
        Frame_RawFFT_Data_Close_Button.Name = "Frame_RawFFT_Data_Close_Button"
        Frame_RawFFT_Data_Close_Button.Size = New Size(18, 18)
        Frame_RawFFT_Data_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_RawFFT_Data_Close_Button.TabIndex = 91
        Frame_RawFFT_Data_Close_Button.TabStop = False
        ' 
        ' Frame_RawFFT_Data_Resize
        ' 
        Frame_RawFFT_Data_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_RawFFT_Data_Resize.BackColor = Color.Transparent
        Frame_RawFFT_Data_Resize.Cursor = Cursors.SizeNWSE
        Frame_RawFFT_Data_Resize.Location = New Point(687, 448)
        Frame_RawFFT_Data_Resize.Name = "Frame_RawFFT_Data_Resize"
        Frame_RawFFT_Data_Resize.Size = New Size(11, 12)
        Frame_RawFFT_Data_Resize.TabIndex = 98
        Frame_RawFFT_Data_Resize.TabStop = False
        ' 
        ' DanwinterLink
        ' 
        DanwinterLink.AutoSize = True
        DanwinterLink.Location = New Point(200, 23)
        DanwinterLink.Name = "DanwinterLink"
        DanwinterLink.Size = New Size(127, 15)
        DanwinterLink.TabIndex = 44
        DanwinterLink.TabStop = True
        DanwinterLink.Text = "Inspired By Dan Winter"
        ' 
        ' TaskBarRawFFTX
        ' 
        TaskBarRawFFTX.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TaskBarRawFFTX.Location = New Point(1155, 0)
        TaskBarRawFFTX.Name = "TaskBarRawFFTX"
        TaskBarRawFFTX.Size = New Size(18, 17)
        TaskBarRawFFTX.SizeMode = PictureBoxSizeMode.StretchImage
        TaskBarRawFFTX.TabIndex = 59
        TaskBarRawFFTX.TabStop = False
        ' 
        ' FFTGraph
        ' 
        FFTGraph.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FFTGraph.BackColor = SystemColors.ActiveBorder
        FFTGraph.Dock = DockStyle.Fill
        FFTGraph.Location = New Point(0, 22)
        FFTGraph.Margin = New Padding(4, 3, 4, 3)
        FFTGraph.Name = "FFTGraph"
        FFTGraph.Size = New Size(698, 437)
        FFTGraph.TabIndex = 10
        ' 
        ' ToolStripFFT
        ' 
        ToolStripFFT.AutoSize = False
        ToolStripFFT.BackColor = SystemColors.ScrollBar
        ToolStripFFT.GripMargin = New Padding(0)
        ToolStripFFT.GripStyle = ToolStripGripStyle.Hidden
        ToolStripFFT.Items.AddRange(New ToolStripItem() {ToolStripLabel11, ToolStripSeparator7, ToolStripDropDownButton6, Frame_RawFFT_Data_Score, ToolStripCurrentRatio})
        ToolStripFFT.Location = New Point(0, 0)
        ToolStripFFT.Name = "ToolStripFFT"
        ToolStripFFT.Padding = New Padding(0)
        ToolStripFFT.Size = New Size(698, 22)
        ToolStripFFT.TabIndex = 110
        ToolStripFFT.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel11
        ' 
        ToolStripLabel11.Name = "ToolStripLabel11"
        ToolStripLabel11.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel11.Size = New Size(75, 19)
        ToolStripLabel11.Text = "FFT"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(6, 22)
        ' 
        ' ToolStripDropDownButton6
        ' 
        ToolStripDropDownButton6.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton6.DropDownItems.AddRange(New ToolStripItem() {PeaklinesONOFFToolStripMenuItem, LowPassFilterToolStripMenuItem1, ScaleToolStripMenuItem, CurrentRatioToolStripMenuItem})
        ToolStripDropDownButton6.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton6.Margin = New Padding(5, 1, 0, 2)
        ToolStripDropDownButton6.Name = "ToolStripDropDownButton6"
        ToolStripDropDownButton6.Size = New Size(62, 19)
        ToolStripDropDownButton6.Text = "Options"
        ' 
        ' PeaklinesONOFFToolStripMenuItem
        ' 
        PeaklinesONOFFToolStripMenuItem.Name = "PeaklinesONOFFToolStripMenuItem"
        PeaklinesONOFFToolStripMenuItem.Size = New Size(145, 22)
        PeaklinesONOFFToolStripMenuItem.Text = "Peaklines"
        ' 
        ' LowPassFilterToolStripMenuItem1
        ' 
        LowPassFilterToolStripMenuItem1.Name = "LowPassFilterToolStripMenuItem1"
        LowPassFilterToolStripMenuItem1.Size = New Size(145, 22)
        LowPassFilterToolStripMenuItem1.Text = "LowPassFilter"
        ' 
        ' ScaleToolStripMenuItem
        ' 
        ScaleToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {XScaleToolStripMenuItem, YScaleToolStripMenuItem1})
        ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem"
        ScaleToolStripMenuItem.Size = New Size(145, 22)
        ScaleToolStripMenuItem.Text = "Scale"
        ' 
        ' XScaleToolStripMenuItem
        ' 
        XScaleToolStripMenuItem.Name = "XScaleToolStripMenuItem"
        XScaleToolStripMenuItem.Size = New Size(110, 22)
        XScaleToolStripMenuItem.Text = "X scale"
        ' 
        ' YScaleToolStripMenuItem1
        ' 
        YScaleToolStripMenuItem1.Name = "YScaleToolStripMenuItem1"
        YScaleToolStripMenuItem1.Size = New Size(110, 22)
        YScaleToolStripMenuItem1.Text = "Y scale"
        ' 
        ' CurrentRatioToolStripMenuItem
        ' 
        CurrentRatioToolStripMenuItem.Name = "CurrentRatioToolStripMenuItem"
        CurrentRatioToolStripMenuItem.Size = New Size(145, 22)
        CurrentRatioToolStripMenuItem.Text = "Current Ratio"
        ' 
        ' Frame_RawFFT_Data_Score
        ' 
        Frame_RawFFT_Data_Score.Margin = New Padding(30, 1, 0, 2)
        Frame_RawFFT_Data_Score.Name = "Frame_RawFFT_Data_Score"
        Frame_RawFFT_Data_Score.Size = New Size(48, 19)
        Frame_RawFFT_Data_Score.Text = "Score  0"
        ' 
        ' ToolStripCurrentRatio
        ' 
        ToolStripCurrentRatio.Margin = New Padding(30, 1, 0, 2)
        ToolStripCurrentRatio.Name = "ToolStripCurrentRatio"
        ToolStripCurrentRatio.Size = New Size(80, 19)
        ToolStripCurrentRatio.Text = "Current Ratio "
        ToolStripCurrentRatio.Visible = False
        ' 
        ' FFT3Panel
        ' 
        FFT3Panel.BackColor = SystemColors.ActiveBorder
        FFT3Panel.BorderStyle = BorderStyle.FixedSingle
        FFT3Panel.Controls.Add(FFT3Plottable)
        FFT3Panel.Controls.Add(Frame_FFT3Coherence_Resize)
        FFT3Panel.Controls.Add(Frame_FFT3_Coherence_Close_Button)
        FFT3Panel.Controls.Add(PictureBox1)
        FFT3Panel.Controls.Add(PictureBox2)
        FFT3Panel.Controls.Add(PictureBox9)
        FFT3Panel.Controls.Add(PictureBox12)
        FFT3Panel.Controls.Add(PictureBox13)
        FFT3Panel.Controls.Add(ToolStripFFT3Coherence)
        FFT3Panel.Location = New Point(714, 168)
        FFT3Panel.Name = "FFT3Panel"
        FFT3Panel.Size = New Size(700, 223)
        FFT3Panel.TabIndex = 88
        FFT3Panel.Visible = False
        ' 
        ' FFT3Plottable
        ' 
        FFT3Plottable.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FFT3Plottable.Dock = DockStyle.Fill
        FFT3Plottable.Location = New Point(0, 22)
        FFT3Plottable.Margin = New Padding(0)
        FFT3Plottable.Name = "FFT3Plottable"
        FFT3Plottable.Size = New Size(698, 199)
        FFT3Plottable.TabIndex = 107
        ' 
        ' Frame_FFT3Coherence_Resize
        ' 
        Frame_FFT3Coherence_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Frame_FFT3Coherence_Resize.BackColor = Color.Transparent
        Frame_FFT3Coherence_Resize.Cursor = Cursors.SizeNWSE
        Frame_FFT3Coherence_Resize.Location = New Point(687, 210)
        Frame_FFT3Coherence_Resize.Name = "Frame_FFT3Coherence_Resize"
        Frame_FFT3Coherence_Resize.Size = New Size(11, 12)
        Frame_FFT3Coherence_Resize.TabIndex = 106
        Frame_FFT3Coherence_Resize.TabStop = False
        ' 
        ' Frame_FFT3_Coherence_Close_Button
        ' 
        Frame_FFT3_Coherence_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_FFT3_Coherence_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_FFT3_Coherence_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_FFT3_Coherence_Close_Button.Location = New Point(680, 0)
        Frame_FFT3_Coherence_Close_Button.Name = "Frame_FFT3_Coherence_Close_Button"
        Frame_FFT3_Coherence_Close_Button.Size = New Size(18, 18)
        Frame_FFT3_Coherence_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_FFT3_Coherence_Close_Button.TabIndex = 105
        Frame_FFT3_Coherence_Close_Button.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.SizeNWSE
        PictureBox1.Location = New Point(1185, 331)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(11, 12)
        PictureBox1.TabIndex = 98
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.BackColor = SystemColors.ScrollBar
        PictureBox2.Location = New Point(1178, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(18, 18)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 93
        PictureBox2.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox9.Location = New Point(1674, 1)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(18, 17)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 71
        PictureBox9.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox12.Location = New Point(2170, 0)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(18, 17)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 66
        PictureBox12.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox13.BackColor = SystemColors.ScrollBar
        PictureBox13.Location = New Point(2665, 0)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(18, 18)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 59
        PictureBox13.TabStop = False
        ' 
        ' ToolStripFFT3Coherence
        ' 
        ToolStripFFT3Coherence.AutoSize = False
        ToolStripFFT3Coherence.BackColor = SystemColors.ScrollBar
        ToolStripFFT3Coherence.GripMargin = New Padding(0)
        ToolStripFFT3Coherence.GripStyle = ToolStripGripStyle.Hidden
        ToolStripFFT3Coherence.Items.AddRange(New ToolStripItem() {ToolStripLabel8, ToolStripSeparator10})
        ToolStripFFT3Coherence.Location = New Point(0, 0)
        ToolStripFFT3Coherence.Name = "ToolStripFFT3Coherence"
        ToolStripFFT3Coherence.Padding = New Padding(0)
        ToolStripFFT3Coherence.Size = New Size(698, 22)
        ToolStripFFT3Coherence.TabIndex = 104
        ToolStripFFT3Coherence.Text = "ToolStrip2"
        ' 
        ' ToolStripLabel8
        ' 
        ToolStripLabel8.Name = "ToolStripLabel8"
        ToolStripLabel8.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel8.Size = New Size(141, 19)
        ToolStripLabel8.Text = "FFT3 Coherence"
        ' 
        ' ToolStripSeparator10
        ' 
        ToolStripSeparator10.Name = "ToolStripSeparator10"
        ToolStripSeparator10.Size = New Size(6, 22)
        ' 
        ' PlayOnlinePanel
        ' 
        PlayOnlinePanel.BackColor = SystemColors.ActiveBorder
        PlayOnlinePanel.BorderStyle = BorderStyle.FixedSingle
        PlayOnlinePanel.Controls.Add(Frame_PlayOnline_Close_Button)
        PlayOnlinePanel.Controls.Add(CepHistory_Resize)
        PlayOnlinePanel.Controls.Add(PlayOnlineGraph)
        PlayOnlinePanel.Controls.Add(RBPublicRoom)
        PlayOnlinePanel.Controls.Add(RBjoinSession)
        PlayOnlinePanel.Controls.Add(RBcreateSession)
        PlayOnlinePanel.Controls.Add(Label1)
        PlayOnlinePanel.Controls.Add(btnJoinSession)
        PlayOnlinePanel.Controls.Add(Session_ID_TXT)
        PlayOnlinePanel.Controls.Add(btnCreateSession)
        PlayOnlinePanel.Controls.Add(ChatBox)
        PlayOnlinePanel.Controls.Add(Label2)
        PlayOnlinePanel.Controls.Add(PictureBox27)
        PlayOnlinePanel.Controls.Add(PictureBox28)
        PlayOnlinePanel.Controls.Add(PictureBox29)
        PlayOnlinePanel.Controls.Add(PictureBox30)
        PlayOnlinePanel.Controls.Add(PictureBox31)
        PlayOnlinePanel.Controls.Add(PictureBox32)
        PlayOnlinePanel.Controls.Add(PictureBox33)
        PlayOnlinePanel.Controls.Add(ToolStripOnlinePlay)
        PlayOnlinePanel.Controls.Add(messageTxt)
        PlayOnlinePanel.Controls.Add(btnSend)
        PlayOnlinePanel.Location = New Point(82, 256)
        PlayOnlinePanel.Name = "PlayOnlinePanel"
        PlayOnlinePanel.Size = New Size(1094, 439)
        PlayOnlinePanel.TabIndex = 89
        PlayOnlinePanel.Visible = False
        ' 
        ' Frame_PlayOnline_Close_Button
        ' 
        Frame_PlayOnline_Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Frame_PlayOnline_Close_Button.BackColor = SystemColors.ScrollBar
        Frame_PlayOnline_Close_Button.Image = My.Resources.Resources.close_button4
        Frame_PlayOnline_Close_Button.Location = New Point(1073, 1)
        Frame_PlayOnline_Close_Button.Margin = New Padding(0)
        Frame_PlayOnline_Close_Button.Name = "Frame_PlayOnline_Close_Button"
        Frame_PlayOnline_Close_Button.Size = New Size(18, 18)
        Frame_PlayOnline_Close_Button.SizeMode = PictureBoxSizeMode.StretchImage
        Frame_PlayOnline_Close_Button.TabIndex = 108
        Frame_PlayOnline_Close_Button.TabStop = False
        ' 
        ' CepHistory_Resize
        ' 
        CepHistory_Resize.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        CepHistory_Resize.BackColor = Color.Transparent
        CepHistory_Resize.Cursor = Cursors.SizeNWSE
        CepHistory_Resize.Location = New Point(1081, 425)
        CepHistory_Resize.Name = "CepHistory_Resize"
        CepHistory_Resize.Size = New Size(11, 12)
        CepHistory_Resize.TabIndex = 179
        CepHistory_Resize.TabStop = False
        ' 
        ' PlayOnlineGraph
        ' 
        PlayOnlineGraph.Dock = DockStyle.Right
        PlayOnlineGraph.Location = New Point(295, 22)
        PlayOnlineGraph.Margin = New Padding(0)
        PlayOnlineGraph.Name = "PlayOnlineGraph"
        PlayOnlineGraph.Size = New Size(797, 415)
        PlayOnlineGraph.TabIndex = 176
        ' 
        ' RBPublicRoom
        ' 
        RBPublicRoom.AutoSize = True
        RBPublicRoom.FlatStyle = FlatStyle.System
        RBPublicRoom.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        RBPublicRoom.Location = New Point(118, 31)
        RBPublicRoom.Name = "RBPublicRoom"
        RBPublicRoom.Size = New Size(95, 18)
        RBPublicRoom.TabIndex = 175
        RBPublicRoom.Text = "Public Room"
        RBPublicRoom.UseVisualStyleBackColor = True
        ' 
        ' RBjoinSession
        ' 
        RBjoinSession.AutoSize = True
        RBjoinSession.FlatStyle = FlatStyle.System
        RBjoinSession.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        RBjoinSession.Location = New Point(212, 31)
        RBjoinSession.Name = "RBjoinSession"
        RBjoinSession.Size = New Size(94, 18)
        RBjoinSession.TabIndex = 174
        RBjoinSession.Text = "Join Session"
        RBjoinSession.UseVisualStyleBackColor = True
        ' 
        ' RBcreateSession
        ' 
        RBcreateSession.AutoSize = True
        RBcreateSession.Checked = True
        RBcreateSession.FlatStyle = FlatStyle.System
        RBcreateSession.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        RBcreateSession.ForeColor = SystemColors.ControlText
        RBcreateSession.Location = New Point(11, 29)
        RBcreateSession.Name = "RBcreateSession"
        RBcreateSession.Size = New Size(106, 18)
        RBcreateSession.TabIndex = 173
        RBcreateSession.TabStop = True
        RBcreateSession.Text = "Create Session"
        RBcreateSession.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 15)
        Label1.TabIndex = 172
        Label1.Text = "No Session Created"
        ' 
        ' btnJoinSession
        ' 
        btnJoinSession.ForeColor = SystemColors.ControlText
        btnJoinSession.Location = New Point(105, 52)
        btnJoinSession.Name = "btnJoinSession"
        btnJoinSession.Size = New Size(101, 23)
        btnJoinSession.TabIndex = 170
        btnJoinSession.Text = "Join Session"
        btnJoinSession.UseVisualStyleBackColor = True
        ' 
        ' Session_ID_TXT
        ' 
        Session_ID_TXT.Location = New Point(11, 52)
        Session_ID_TXT.Name = "Session_ID_TXT"
        Session_ID_TXT.Size = New Size(88, 23)
        Session_ID_TXT.TabIndex = 169
        Session_ID_TXT.Text = "Enter Session ID"
        ' 
        ' btnCreateSession
        ' 
        btnCreateSession.Location = New Point(11, 52)
        btnCreateSession.Name = "btnCreateSession"
        btnCreateSession.Size = New Size(195, 23)
        btnCreateSession.TabIndex = 171
        btnCreateSession.Text = "Create Session"
        btnCreateSession.UseVisualStyleBackColor = True
        ' 
        ' ChatBox
        ' 
        ChatBox.Location = New Point(11, 161)
        ChatBox.Multiline = True
        ChatBox.Name = "ChatBox"
        ChatBox.ReadOnly = True
        ChatBox.Size = New Size(228, 214)
        ChatBox.TabIndex = 166
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 167
        Label2.Text = "Message:"
        ' 
        ' PictureBox27
        ' 
        PictureBox27.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox27.BackColor = Color.Transparent
        PictureBox27.Cursor = Cursors.SizeNWSE
        PictureBox27.Location = New Point(1579, 547)
        PictureBox27.Name = "PictureBox27"
        PictureBox27.Size = New Size(11, 12)
        PictureBox27.TabIndex = 106
        PictureBox27.TabStop = False
        ' 
        ' PictureBox28
        ' 
        PictureBox28.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox28.BackColor = SystemColors.ScrollBar
        PictureBox28.Location = New Point(1572, 0)
        PictureBox28.Name = "PictureBox28"
        PictureBox28.Size = New Size(18, 18)
        PictureBox28.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox28.TabIndex = 105
        PictureBox28.TabStop = False
        ' 
        ' PictureBox29
        ' 
        PictureBox29.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox29.BackColor = Color.Transparent
        PictureBox29.Cursor = Cursors.SizeNWSE
        PictureBox29.Location = New Point(2077, 668)
        PictureBox29.Name = "PictureBox29"
        PictureBox29.Size = New Size(11, 12)
        PictureBox29.TabIndex = 98
        PictureBox29.TabStop = False
        ' 
        ' PictureBox30
        ' 
        PictureBox30.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox30.BackColor = SystemColors.ScrollBar
        PictureBox30.Location = New Point(2070, 0)
        PictureBox30.Name = "PictureBox30"
        PictureBox30.Size = New Size(18, 18)
        PictureBox30.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox30.TabIndex = 93
        PictureBox30.TabStop = False
        ' 
        ' PictureBox31
        ' 
        PictureBox31.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox31.Location = New Point(2566, 1)
        PictureBox31.Name = "PictureBox31"
        PictureBox31.Size = New Size(18, 17)
        PictureBox31.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox31.TabIndex = 71
        PictureBox31.TabStop = False
        ' 
        ' PictureBox32
        ' 
        PictureBox32.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox32.Location = New Point(3062, 0)
        PictureBox32.Name = "PictureBox32"
        PictureBox32.Size = New Size(18, 17)
        PictureBox32.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox32.TabIndex = 66
        PictureBox32.TabStop = False
        ' 
        ' PictureBox33
        ' 
        PictureBox33.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox33.BackColor = SystemColors.ScrollBar
        PictureBox33.Location = New Point(3557, 0)
        PictureBox33.Name = "PictureBox33"
        PictureBox33.Size = New Size(18, 18)
        PictureBox33.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox33.TabIndex = 59
        PictureBox33.TabStop = False
        ' 
        ' ToolStripOnlinePlay
        ' 
        ToolStripOnlinePlay.AutoSize = False
        ToolStripOnlinePlay.BackColor = SystemColors.ScrollBar
        ToolStripOnlinePlay.GripMargin = New Padding(0)
        ToolStripOnlinePlay.GripStyle = ToolStripGripStyle.Hidden
        ToolStripOnlinePlay.Items.AddRange(New ToolStripItem() {ToolStripLabel14, ToolStripSeparator12, ToolStripDropDownButton4})
        ToolStripOnlinePlay.Location = New Point(0, 0)
        ToolStripOnlinePlay.Name = "ToolStripOnlinePlay"
        ToolStripOnlinePlay.Padding = New Padding(0)
        ToolStripOnlinePlay.Size = New Size(1092, 22)
        ToolStripOnlinePlay.TabIndex = 104
        ToolStripOnlinePlay.Text = "ToolStrip2"
        ' 
        ' ToolStripLabel14
        ' 
        ToolStripLabel14.Name = "ToolStripLabel14"
        ToolStripLabel14.Padding = New Padding(50, 0, 0, 0)
        ToolStripLabel14.Size = New Size(117, 19)
        ToolStripLabel14.Text = "Play Online"
        ' 
        ' ToolStripSeparator12
        ' 
        ToolStripSeparator12.Name = "ToolStripSeparator12"
        ToolStripSeparator12.Size = New Size(6, 22)
        ' 
        ' ToolStripDropDownButton4
        ' 
        ToolStripDropDownButton4.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton4.DropDownItems.AddRange(New ToolStripItem() {ChangeNameToolStripMenuItem, HeightToolStripMenuItem, HeightDownToolStripMenuItem, AutoScaleToolStripMenuItem})
        ToolStripDropDownButton4.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        ToolStripDropDownButton4.Size = New Size(62, 19)
        ToolStripDropDownButton4.Text = "Options"
        ToolStripDropDownButton4.ToolTipText = "Options"
        ' 
        ' ChangeNameToolStripMenuItem
        ' 
        ChangeNameToolStripMenuItem.Name = "ChangeNameToolStripMenuItem"
        ChangeNameToolStripMenuItem.Size = New Size(150, 22)
        ChangeNameToolStripMenuItem.Text = "Change Name"
        ' 
        ' HeightToolStripMenuItem
        ' 
        HeightToolStripMenuItem.Name = "HeightToolStripMenuItem"
        HeightToolStripMenuItem.Size = New Size(150, 22)
        HeightToolStripMenuItem.Text = "Height-Up"
        ' 
        ' HeightDownToolStripMenuItem
        ' 
        HeightDownToolStripMenuItem.Name = "HeightDownToolStripMenuItem"
        HeightDownToolStripMenuItem.Size = New Size(150, 22)
        HeightDownToolStripMenuItem.Text = "Height-Down"
        ' 
        ' AutoScaleToolStripMenuItem
        ' 
        AutoScaleToolStripMenuItem.Name = "AutoScaleToolStripMenuItem"
        AutoScaleToolStripMenuItem.Size = New Size(150, 22)
        AutoScaleToolStripMenuItem.Text = "Auto-Scale"
        ' 
        ' messageTxt
        ' 
        messageTxt.Location = New Point(10, 381)
        messageTxt.Name = "messageTxt"
        messageTxt.Size = New Size(165, 23)
        messageTxt.TabIndex = 177
        ' 
        ' btnSend
        ' 
        btnSend.Location = New Point(181, 381)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(57, 23)
        btnSend.TabIndex = 178
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' ECG_MainForm
        ' 
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1433, 739)
        Controls.Add(HeartGuidePanel)
        Controls.Add(ScorePanel)
        Controls.Add(RRPanel)
        Controls.Add(FFT3Panel)
        Controls.Add(CepstrumHistoryPanel)
        Controls.Add(CepstrumPanel)
        Controls.Add(ECGPanel)
        Controls.Add(LoPhi_ToolStrip)
        Controls.Add(FFTPanel)
        Controls.Add(HRVFFTPanel)
        Controls.Add(PlayOnlinePanel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ECG_MainForm"
        Text = "Take a step onto the other side - Dan Winter Made By: Nick"
        LoPhi_ToolStrip.ResumeLayout(False)
        LoPhi_ToolStrip.PerformLayout()
        HRVFFTPanel.ResumeLayout(False)
        CType(Frame_RR_FFT_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_RR_FFT_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarRRIntervalFFTX, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ToolStripHRVFFT.ResumeLayout(False)
        ToolStripHRVFFT.PerformLayout()
        ScorePanel.ResumeLayout(False)
        CType(Frame_Coherence_Graph_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_Coherence_Graph_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarCoherenceGraphX, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ToolStripScoreGraph.ResumeLayout(False)
        ToolStripScoreGraph.PerformLayout()
        RRPanel.ResumeLayout(False)
        CType(Frame_Beat_To_Beat_Display_Length, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_Beat_To_Beat_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_Beat_To_Beat_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarRRIntervalX, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ToolStripRRIntevalHRV.ResumeLayout(False)
        ToolStripRRIntevalHRV.PerformLayout()
        CepstrumPanel.ResumeLayout(False)
        CType(Frame_Cepstrum_Data_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_Cepstrum_Data_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarCepX, ComponentModel.ISupportInitialize).EndInit()
        ToolStripCepstrum.ResumeLayout(False)
        ToolStripCepstrum.PerformLayout()
        HeartGuidePanel.ResumeLayout(False)
        CType(Frame_HRV_Guide_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_HRV_Guide_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_HRV_Guide_Height_Setting, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarHRVGuideX, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_HRV_Guide_Frequency_Setting, ComponentModel.ISupportInitialize).EndInit()
        ToolStripHeartGuide.ResumeLayout(False)
        ToolStripHeartGuide.PerformLayout()
        ECGPanel.ResumeLayout(False)
        CType(Frame_RawECG_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_ECG_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_RawECG_Threshold, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarRawECGX, ComponentModel.ISupportInitialize).EndInit()
        ToolStripECGData.ResumeLayout(False)
        ToolStripECGData.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarCepHistoryX, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_Cepstrum_History_Amount_Setting, ComponentModel.ISupportInitialize).EndInit()
        CepstrumHistoryPanel.ResumeLayout(False)
        CType(Frame_Cepstrum_History_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_Cepstrum_History_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        ToolStripCepstrumHistory.ResumeLayout(False)
        ToolStripCepstrumHistory.PerformLayout()
        FFTPanel.ResumeLayout(False)
        FFTPanel.PerformLayout()
        CType(Frame_RawFFT_Data_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_RawFFT_Data_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBarRawFFTX, ComponentModel.ISupportInitialize).EndInit()
        ToolStripFFT.ResumeLayout(False)
        ToolStripFFT.PerformLayout()
        FFT3Panel.ResumeLayout(False)
        CType(Frame_FFT3Coherence_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(Frame_FFT3_Coherence_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        ToolStripFFT3Coherence.ResumeLayout(False)
        ToolStripFFT3Coherence.PerformLayout()
        PlayOnlinePanel.ResumeLayout(False)
        PlayOnlinePanel.PerformLayout()
        CType(Frame_PlayOnline_Close_Button, ComponentModel.ISupportInitialize).EndInit()
        CType(CepHistory_Resize, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox27, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox28, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox29, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox30, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox31, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox32, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox33, ComponentModel.ISupportInitialize).EndInit()
        ToolStripOnlinePlay.ResumeLayout(False)
        ToolStripOnlinePlay.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TSHeartGuide As ToolStripButton
    Friend WithEvents TSPlayOnline As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TSRRFFT As ToolStripButton
    Friend WithEvents TSRR As ToolStripButton
    Friend WithEvents TSCoherGra As ToolStripButton
    Friend WithEvents TSRawECGFFT As ToolStripButton
    Friend WithEvents TSCepHist As ToolStripButton
    Friend WithEvents TSCep As ToolStripButton
    Friend WithEvents TSHome As ToolStripButton
    Friend WithEvents LoPhi_Toolstrip_Select_Input As ToolStripButton
    Friend WithEvents LoPhi_ToolStrip As ToolStrip
    Friend WithEvents HRVFFTPanel As Panel
    Friend WithEvents TaskBarRRIntervalFFTX As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents HRVFFTGraph As ScottPlot.FormsPlot
    Friend WithEvents ScorePanel As Panel
    Friend WithEvents TaskBarCoherenceGraphX As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents ScoreBasedPlot As ScottPlot.FormsPlot
    Friend WithEvents RRPanel As Panel
    Friend WithEvents TaskBarRRIntervalX As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Frame_Beat_To_Beat_Display_Length As NumericUpDown
    Friend WithEvents CepstrumPanel As Panel
    Friend WithEvents TaskBarCepX As PictureBox
    Friend WithEvents CepstrumGraph As ScottPlot.FormsPlot
    Friend WithEvents HeartGuidePanel As Panel
    Friend WithEvents TaskBarHRVGuideX As PictureBox
    Friend WithEvents Frame_HRV_Guide_Frequency_Setting As NumericUpDown
    Friend WithEvents HeartGuidePlot As ScottPlot.FormsPlot
    Friend WithEvents ECGPanel As Panel
    Friend WithEvents Frame_RawECG_Close_Button As PictureBox
    Friend WithEvents Frame_RawECG_Threshold As NumericUpDown
    Friend WithEvents RawECGGraph As ScottPlot.FormsPlot
    Friend WithEvents TaskBarRawECGX As PictureBox
    Friend WithEvents Frame_RawECG_TaskBar As PictureBox
    Friend WithEvents ThisPlotsECGRawData As Timer
    Friend WithEvents CepstrumHistoryGraph As ScottPlot.FormsPlot
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TaskBarCepHistoryX As PictureBox
    Friend WithEvents Frame_Cepstrum_History_Amount_Setting As NumericUpDown
    Friend WithEvents CepstrumHistoryPanel As Panel
    Friend WithEvents Two_Second_Render As Timer
    Friend WithEvents Frame_HRV_Guide_Height_Setting As NumericUpDown
    Friend WithEvents Frame_RR_FFT_Close_Button As PictureBox
    Friend WithEvents Frame_Coherence_Graph_Close_Button As PictureBox
    Friend WithEvents Frame_Beat_To_Beat_Close_Button As PictureBox
    Friend WithEvents Frame_Cepstrum_Data_Close_Button As PictureBox
    Friend WithEvents Frame_HRV_Guide_Close_Button As PictureBox
    Friend WithEvents Frame_Cepstrum_History_Close_Button As PictureBox
    Friend WithEvents RRGraph As ScottPlot.FormsPlot
    Friend WithEvents FFTPanel As Panel
    Friend WithEvents Frame_RawFFT_Data_Close_Button As PictureBox
    Friend WithEvents DanwinterLink As LinkLabel
    Friend WithEvents TaskBarRawFFTX As PictureBox
    Friend WithEvents FFTGraph As ScottPlot.FormsPlot
    Friend WithEvents sampleRateTimer As Timer
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents Settings_Tool_Themes As ToolStripMenuItem
    Friend WithEvents Frame_ECG_Resize As PictureBox
    Friend WithEvents Frame_HRV_Guide_Resize As PictureBox
    Friend WithEvents GrayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Frame_Cepstrum_Data_Resize As PictureBox
    Friend WithEvents Frame_RR_FFT_Resize As PictureBox
    Friend WithEvents Frame_Coherence_Graph_Resize As PictureBox
    Friend WithEvents Frame_Beat_To_Beat_Resize As PictureBox
    Friend WithEvents Frame_RawFFT_Data_Resize As PictureBox
    Friend WithEvents Frame_Cepstrum_History_Resize As PictureBox
    Friend WithEvents ExportECGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TSECG As ToolStripButton
    Friend WithEvents SaveLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RecallToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RecallToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripRRIntevalHRV As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripHeartGuide As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents PHIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OctaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripECGData As ToolStrip
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents BPMtoolstripLabel As ToolStripLabel
    Friend WithEvents ToolStripScoreGraph As ToolStrip
    Friend WithEvents ToolStripLabel9 As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripCepstrum As ToolStrip
    Friend WithEvents ToolStripLabel10 As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents MaxCepstrumTrackingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LowPassFilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton5 As ToolStripDropDownButton
    Friend WithEvents DataCaptureToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripHRVFFT As ToolStrip
    Friend WithEvents ToolStripLabel13 As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton8 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents Frame_RR_FFT_Score As ToolStripLabel
    Friend WithEvents ToolStripCepstrumHistory As ToolStrip
    Friend WithEvents ToolStripLabel15 As ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton10 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel16 As ToolStripLabel
    Friend WithEvents ToolStripFFT As ToolStrip
    Friend WithEvents ToolStripLabel11 As ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton6 As ToolStripDropDownButton
    Friend WithEvents PeaklinesONOFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LowPassFilterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Frame_RawFFT_Data_Score As ToolStripLabel
    Friend WithEvents ONOFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HzONOFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cepstrum_score_txt As ToolStripLabel
    Friend WithEvents Scale00X04ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnablePHIScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YScaleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CurrentRatioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripHRVCurrentRatio As ToolStripLabel
    Friend WithEvents CurrentRatioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripCurrentRatio As ToolStripLabel
    Friend WithEvents FFT3Panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents ToolStripFFT3Coherence As ToolStrip
    Friend WithEvents ToolStripLabel8 As ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents Frame_FFT3_Coherence_Close_Button As PictureBox
    Friend WithEvents Frame_FFT3Coherence_Resize As PictureBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents CadetBlueGrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeHRVDataLengthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayOnlinePanel As Panel
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
    Friend WithEvents PictureBox30 As PictureBox
    Friend WithEvents PictureBox31 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents PictureBox33 As PictureBox
    Friend WithEvents ToolStripOnlinePlay As ToolStrip
    Friend WithEvents ToolStripLabel14 As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents RBPublicRoom As RadioButton
    Friend WithEvents RBjoinSession As RadioButton
    Friend WithEvents RBcreateSession As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnJoinSession As Button
    Friend WithEvents Session_ID_TXT As TextBox
    Friend WithEvents btnCreateSession As Button
    Friend WithEvents ChatBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents messageTxt As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents PlayOnlineGraph As ScottPlot.FormsPlot
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents ChangeNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeightDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CepHistory_Resize As PictureBox
    Friend WithEvents Frame_PlayOnline_Close_Button As PictureBox
    Friend WithEvents AutoScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RawECGTimer As Timer
    Friend WithEvents RRintervalTimer As Timer
    Friend WithEvents HeartGuideTimer As Timer
    Friend WithEvents TSFFT3 As ToolStripButton
    Friend WithEvents RefreshRateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FFT3Plottable As ScottPlot.FormsPlot
End Class
