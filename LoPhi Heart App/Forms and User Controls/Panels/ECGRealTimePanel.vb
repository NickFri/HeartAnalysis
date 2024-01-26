'Public Class ECGRealTimePanelClass
'    Private ReadOnly _plot As FormsPlot
'    Private ReadOnly _mainForm As ECG_MainForm

'    Private ReadOnly fontSize As Integer = 8
'    Private ReadOnly xPositions As Double() = {0, 1000, 2000, 3000, 4000, 5000}
'    Private ReadOnly xLabels As String() = {"0", "1", "2", "3", "4", "5"}
'    Private ReadOnly yPositions As Double() = {0, 512, 1024, 1536, 2048, 2560, 3072, 3584, 4096}
'    Private ReadOnly yLabels As String() = {"0", "5", "10", "15", "20", "25", "30", "35", "40"}

'    Public Sub New(plot As FormsPlot, mainFormInstance As ECG_MainForm)
'        _plot = plot
'        _mainForm = mainFormInstance
'    End Sub

'    Public Sub RenderECGTimer(sender As Object, e As EventArgs)

'    End Sub
'End Class

Partial Public Class ECG_MainForm
    '''''''''' UI ''''''''''
    Public ECG_Window_Size_Value As New NumericUpDown

    Private ECGwindowWidth As Integer = 5000
    Public WithEvents updateECGTimer As New Timer()
    Private busyRendering As Boolean = False

    Dim xPositions As Double() = {0, 1000, 2000, 3000, 4000, 5000}
    Dim xLabels As String() = {"0", "1", "2", "3", "4", "5"}
    Dim yPositions As Double() = {0, 512, 1024, 1536, 2048, 2560, 3072, 3584, 4096}
    Dim yLabels As String() = {"0", "5", "10", "15", "20", "25", "30", "35", "40"}

    Public asdf As Double() = Enumerable.Repeat(1024.0, 5000).ToArray()

    Private Sub IntializeECGGraph()
        updateECGTimer.Interval = 30
        ' the issue is with this timer firing. when it is pulling variables
        ' its with beathreshold
        ' replaced it here with the Frame_RawECG_Threshold.Value
        ' have to be warry of what variables I am pulling from the COM port high speed protocol
        updateECGTimer.Start()
    End Sub

    Public Sub updateUITimer_Tick(sender As Object, e As EventArgs) Handles updateECGTimer.Tick
        If busyRendering Then Return
        busyRendering = True

        RawECGGraph.Plot.Clear()
        RawECGGraph.Plot.AddSignalConst(_5SecondECGBuffer, color:=ColorTranslator.FromHtml("#d62728"))
        RawECGGraph.Plot.AddVerticalLine(CDbl(_bufferPosition), color:=ColorTranslator.FromHtml("#636363"))
        RawECGGraph.Plot.AddHorizontalLine(Frame_RawECG_Threshold.Value * 102, color:=ColorTranslator.FromHtml("#bcbd22"))
        RawECGGraph.Plot.SetAxisLimits(0, 5000)
        RawECGGraph.Plot.XAxis.ManualTickPositions(xPositions, xLabels)
        RawECGGraph.Plot.YAxis.ManualTickPositions(yPositions, yLabels)

        RawECGGraph.Render()
        busyRendering = False
    End Sub

    Private Sub ECGUIRenderer()
        ToolStripECGData.Renderer = New ToolStripRenderer

        ECG_Window_Size_Value.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        ECG_Window_Size_Value.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        ECG_Window_Size_Value.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        ECG_Window_Size_Value.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        ECG_Window_Size_Value.Name = "ECG_Window_Size_Value"
        ECG_Window_Size_Value.Size = New System.Drawing.Size(45, 20)
        ECG_Window_Size_Value.Value = New Decimal(New Integer() {5000, 0, 0, 0})

        Dim ECGwindowSize As New ToolStripControlHost(ECG_Window_Size_Value)
        DataCaptureToolStripMenuItem1.DropDownItems.Insert(0, ECGwindowSize)

        Dim ECGthreasholdValue As New ToolStripControlHost(Frame_RawECG_Threshold)
        ECGthreasholdValue.AutoSize = False ' Add this line
        ECGthreasholdValue.Margin = New Padding(0, 0, 22, 0)
        ECGthreasholdValue.Alignment = ToolStripItemAlignment.Right
        ToolStripECGData.Items.Insert(2, ECGthreasholdValue)

    End Sub

    'Handles nudThreasholdChanged
    Dim er As Int16 = 0 ' error first load
    Private Sub Frame_RawECG_Threshold_ValueChanged(sender As Object, e As EventArgs) Handles Frame_RawECG_Threshold.ValueChanged
        er = er + 1
        If er > 1 Then beatThreshold = Convert.ToInt16(Frame_RawECG_Threshold.Value * 102)
        er = 2
    End Sub

End Class
