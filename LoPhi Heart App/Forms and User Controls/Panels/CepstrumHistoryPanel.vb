Partial Public Class ECG_MainForm
    Private Sub Cepstrum_History_Plot(_CepstrumFrequency() As Double, _CepstrumData() As Double)
        CepstrumHistoryGraph.Plot.Clear()
        Cepstrum_History_Plots.Add(CepstrumHistoryGraph.Plot.AddScatterLines(_CepstrumFrequency, _CepstrumData, ColorTranslator.FromHtml("#3b88be")))

        If Cepstrum_History_Plots.Count >= Frame_Cepstrum_History_Amount_Setting.Value Then
            Cepstrum_History_Plots.RemoveRange(0, Cepstrum_History_Plots.Count - Frame_Cepstrum_History_Amount_Setting.Value)
        End If

        If WaterfallON Then
            Dim setbarX As Double = Cepstrum_History_Plots(0).Xs.Max / 40
            Dim setbarY As Double = Cepstrum_History_Plots(0).Ys.Max / 5
            Dim adjustX As Double = Frame_Cepstrum_History_X.Value / 4 * setbarX
            Dim adjustY As Double = Frame_Cepstrum_History_Y.Value / 4 * setbarY
            Dim Xheight As Double = adjustX
            Dim Yheight As Double = adjustY

            For i = 0 To Cepstrum_History_Plots.Count - 1
                Cepstrum_History_Plots(i).OffsetX = Xheight
                Cepstrum_History_Plots(i).OffsetY = Yheight
                CepstrumHistoryGraph.Plot.Add(Cepstrum_History_Plots(i))
                Xheight += adjustX
                Yheight += adjustY
            Next
        Else
            For i = 0 To Cepstrum_History_Plots.Count - 1
                CepstrumHistoryGraph.Plot.Add(Cepstrum_History_Plots(i))
            Next
        End If

        CepstrumHistoryGraph.Plot.AxisAuto()
        CepstrumHistoryGraph.Render()

    End Sub
End Class

Partial Public Class ECG_MainForm
    '''''''''' GLOBALS FOR MAIN INSTANCE ''''''''''
    Public Cepstrum_History_Plots As List(Of ScottPlot.Plottable.ScatterPlot) = New List(Of ScottPlot.Plottable.ScatterPlot)

    '''''''''' UI ''''''''''
    ' Create Controls
    Public Frame_Cepstrum_History_Y As New HScrollBar
    Public Frame_Cepstrum_History_X As New HScrollBar

    Private Sub CepstrumHistoryUIRenderer()

        ToolStripCepstrumHistory.Renderer = New ToolStripRenderer

        'Frame_Cepstrum_History_Y
        '
        Frame_Cepstrum_History_Y.LargeChange = 1
        Frame_Cepstrum_History_Y.SmallChange = 1
        Frame_Cepstrum_History_Y.Maximum = 14
        Frame_Cepstrum_History_Y.Minimum = 0
        Frame_Cepstrum_History_Y.Name = "Frame_Cepstrum_History_Y"
        Frame_Cepstrum_History_Y.Size = New System.Drawing.Size(89, 17)
        Frame_Cepstrum_History_Y.Value = 5
        '
        'Frame_Cepstrum_History_X
        '
        Frame_Cepstrum_History_X.LargeChange = 1
        Frame_Cepstrum_History_X.SmallChange = 1
        Frame_Cepstrum_History_X.Maximum = 8
        Frame_Cepstrum_History_X.Minimum = 0
        Frame_Cepstrum_History_X.Name = "Frame_Cepstrum_History_X"
        Frame_Cepstrum_History_X.Size = New System.Drawing.Size(89, 17)
        Frame_Cepstrum_History_X.Value = 1

        Dim Cepstrum_History_X As New ToolStripControlHost(Frame_Cepstrum_History_X)
        Dim Cepstrum_History_Y As New ToolStripControlHost(Frame_Cepstrum_History_Y)
        XToolStripMenuItem.DropDownItems.Insert(0, Cepstrum_History_X)
        YToolStripMenuItem.DropDownItems.Insert(0, Cepstrum_History_Y)

        Dim CepstrumHistoryAmount As New ToolStripControlHost(Frame_Cepstrum_History_Amount_Setting)
        CepstrumHistoryAmount.AutoSize = False ' Add this line
        CepstrumHistoryAmount.Margin = New Padding(0, 0, 22, 0)
        CepstrumHistoryAmount.Alignment = ToolStripItemAlignment.Right
        ToolStripCepstrumHistory.Items.Insert(2, CepstrumHistoryAmount)

    End Sub


    Public WaterfallON As Boolean = False

    Private Sub ONOFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ONOFFToolStripMenuItem.Click
        ' Waterfall ON/OFF
        If WaterfallON Then
            WaterfallON = False
            ONOFFToolStripMenuItem.Font = New Font(ONOFFToolStripMenuItem.Font, FontStyle.Regular)
        ElseIf WaterfallON = False Then
            WaterfallON = True
            ONOFFToolStripMenuItem.Font = New Font(ONOFFToolStripMenuItem.Font, FontStyle.Bold)
        End If
    End Sub

End Class