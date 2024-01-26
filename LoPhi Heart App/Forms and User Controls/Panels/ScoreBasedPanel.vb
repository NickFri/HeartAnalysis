Partial Public Class ECG_MainForm
    ' Graph = ScoreBasedPlot

    Public Sub HandleScoreBasedGraph(_score As Double)

        If Not ScorePanel.Visible Then Return

        ScoreBasedPlot.Plot.Clear()

        If Chart = False Then
            UpdateCirclePositions(Int(_score))
        End If

        If Chart Then
            ScoreBasedPlot.Plot.Clear()
            Frame_Score_Graph_Plot_X.Add(Frame_Score_Graph_Plot_Val)
            Frame_Score_Graph_Plot_Y.Add(_score)
            Frame_Score_Graph_Plot_Val += 1
            ScoreBasedPlot.Plot.AddScatter(Frame_Score_Graph_Plot_X.ToArray, Frame_Score_Graph_Plot_Y.ToArray)
            ScoreBasedPlot.Refresh()
            If Frame_Score_Graph_Plot_Val > 150 Then
                Frame_Score_Graph_Plot_Val = 0
                Frame_Score_Graph_Plot_X.Clear()
                Frame_Score_Graph_Plot_Y.Clear()
            End If
        End If

    End Sub
End Class

Partial Public Class ECG_MainForm
    '''''''''' GLOBALS FOR MAIN INSTANCE ''''''''''
    Public Frame_Score_Graph_Plot_X As List(Of Double) = New List(Of Double)
    Public Frame_Score_Graph_Plot_Y As List(Of Double) = New List(Of Double)
    Public Frame_Score_Graph_Plot_Val As Int16 = 0

    Public Chart As Boolean = True
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Chart = True
        setGame(False)
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Chart = False
        setGame(True)
    End Sub

    Private Sub setGame(ByVal set1 As Boolean)

        Dim chartSize = New Size(700, 223)
        Dim gameSize = New Size(223, 500) ' set vertical
        If set1 Then
            ScorePanel.Size = gameSize
            ScoreBasedPlot.Visible = False
        Else
            ScorePanel.Size = chartSize
            ScoreBasedPlot.Visible = True
        End If
    End Sub

    Public Sub UpdateCirclePositions(value As Integer)
        Dim distance As Integer = 40 ' Distance between the circle balls
        Dim centerX As Integer = ScorePanel.ClientSize.Width / 2 ' X coordinate of the center of the panel
        Dim centerY As Integer = ScorePanel.ClientSize.Height / 2 ' Y coordinate of the center of the panel

        Using graphics As Graphics = ScorePanel.CreateGraphics()
            graphics.Clear(ScorePanel.BackColor)

            For i As Integer = 0 To 6
                Dim diameter As Integer = 20
                Dim x As Integer
                Dim y As Integer = centerY - distance * 3 + i * distance

                ' Set the color of the circle ball
                Dim colorValue As Integer = Math.Max(0, Math.Min(255, value * 2.55))
                Dim color As Color = Color.FromArgb(255 - colorValue, colorValue, 0)

                ' Set the x coordinate based on the value
                If value = 100 Then
                    x = centerX - diameter / 2
                Else
                    Dim factor As Integer = 0.6 ' Adjust this value to change how far the circle balls move
                    If i Mod 2 = 0 Then
                        x = centerX - diameter / 2 - (100 - value) * factor
                    Else
                        x = centerX - diameter / 2 + (100 - value) * factor
                    End If
                End If

                ' Draw the circle ball
                DrawCircleBall1(graphics, x, y, diameter, color)
            Next
        End Using
    End Sub
    Private Sub DrawCircleBall1(ByVal graphics As Graphics, ByVal x As Integer, ByVal y As Integer, ByVal diameter As Integer, ByVal color As Color)
        Using brush As New SolidBrush(color)
            graphics.FillEllipse(brush, x, y, diameter, diameter)
        End Using
    End Sub

End Class
