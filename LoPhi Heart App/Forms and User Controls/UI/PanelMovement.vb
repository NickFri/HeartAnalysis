Imports System.Runtime.InteropServices

Partial Public Class ECG_MainForm
    <DllImport("user32.dll")>
    Private Shared Function SetCapture(hWnd As IntPtr) As Integer
    End Function

    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Integer
    End Function

    Private IsMouseDown As Boolean = False
    Private Pos2 As Point

    Private Sub Frame_TaskBar_MouseDown(sender As Object, e As MouseEventArgs) Handles _
            ToolStripRRIntevalHRV.MouseDown,
            ToolStripHeartGuide.MouseDown,
            ToolStripScoreGraph.MouseDown,
            ToolStripECGData.MouseDown,
            ToolStripCepstrum.MouseDown,
            ToolStripHRVFFT.MouseDown,
            ToolStripFFT.MouseDown,
            ToolStripCepstrumHistory.MouseDown,
            ToolStripFFT3Coherence.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            IsMouseDown = True
            Pos2 = MousePosition
            SetCapture(DirectCast(sender, Control).Handle)
        End If
    End Sub

    Private Sub Frame_TaskBar_MouseUp(sender As Object, e As MouseEventArgs) Handles _
            ToolStripRRIntevalHRV.MouseUp,
            ToolStripHeartGuide.MouseUp,
            ToolStripScoreGraph.MouseUp,
            ToolStripECGData.MouseUp,
            ToolStripCepstrum.MouseUp,
            ToolStripHRVFFT.MouseUp,
            ToolStripFFT.MouseUp,
            ToolStripCepstrumHistory.MouseUp,
            ToolStripFFT3Coherence.MouseUp

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            IsMouseDown = False
            ReleaseCapture()
        End If
    End Sub

    Private Sub Frame_TaskBar_MouseMove(sender As Object, e As MouseEventArgs) Handles _
            ToolStripRRIntevalHRV.MouseMove,
            ToolStripHeartGuide.MouseMove,
            ToolStripScoreGraph.MouseMove,
            ToolStripECGData.MouseMove,
            ToolStripCepstrum.MouseMove,
            ToolStripHRVFFT.MouseMove,
            ToolStripFFT.MouseMove,
            ToolStripCepstrumHistory.MouseMove,
            ToolStripFFT3Coherence.MouseMove

        If IsMouseDown AndAlso e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim ToolStrip = DirectCast(sender, Control)
            Dim frame = ToolStrip.Parent
            frame.Location += MousePosition - Pos2
            frame.BringToFront()
            Pos2 = MousePosition
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles _
        Frame_HRV_Guide_Close_Button.Click,
        Frame_Cepstrum_Data_Close_Button.Click,
        Frame_Beat_To_Beat_Close_Button.Click,
        Frame_RawFFT_Data_Close_Button.Click,
        Frame_Cepstrum_History_Close_Button.Click,
        Frame_Coherence_Graph_Close_Button.Click,
        Frame_RR_FFT_Close_Button.Click,
        Frame_RawECG_Close_Button.Click,
        Frame_FFT3_Coherence_Close_Button.Click,
        Frame_PlayOnline_Close_Button.Click

        Dim frame = DirectCast(sender, Control).Parent
        frame.Visible = False
    End Sub

    Private allowResize As Boolean = False
    Private resizingFrame As Control = Nothing

    Private Sub Frame_Resize_MouseDown(sender As Object, e As MouseEventArgs) Handles Frame_FFT3Coherence_Resize.MouseDown, Frame_ECG_Resize.MouseDown, Frame_HRV_Guide_Resize.MouseDown, Frame_Cepstrum_Data_Resize.MouseDown, Frame_RawFFT_Data_Resize.MouseDown, Frame_Coherence_Graph_Resize.MouseDown, Frame_RR_FFT_Resize.MouseDown, Frame_Cepstrum_History_Resize.MouseDown, Frame_Beat_To_Beat_Resize.MouseDown
        allowResize = True
        resizingFrame = DirectCast(sender, Control).Parent
    End Sub

    Private Sub Frame_Resize_MouseUp(sender As Object, e As MouseEventArgs) Handles Frame_FFT3Coherence_Resize.MouseUp, Frame_ECG_Resize.MouseUp, Frame_HRV_Guide_Resize.MouseUp, Frame_Cepstrum_Data_Resize.MouseUp, Frame_RawFFT_Data_Resize.MouseUp, Frame_Coherence_Graph_Resize.MouseUp, Frame_RR_FFT_Resize.MouseUp, Frame_Cepstrum_History_Resize.MouseUp, Frame_Beat_To_Beat_Resize.MouseUp
        allowResize = False
        If resizingFrame IsNot Nothing Then
            resizingFrame.BringToFront()
            resizingFrame = Nothing
        End If
    End Sub

    Private Sub Frame_Resize_MouseMove(sender As Object, e As MouseEventArgs) Handles Frame_FFT3Coherence_Resize.MouseMove, Frame_ECG_Resize.MouseMove, Frame_HRV_Guide_Resize.MouseMove, Frame_Cepstrum_Data_Resize.MouseMove, Frame_RawFFT_Data_Resize.MouseMove, Frame_Coherence_Graph_Resize.MouseMove, Frame_RR_FFT_Resize.MouseMove, Frame_Cepstrum_History_Resize.MouseMove, Frame_Beat_To_Beat_Resize.MouseMove
        If allowResize AndAlso resizingFrame IsNot Nothing Then
            resizingFrame.Height = DirectCast(sender, Control).Top + e.Y
            resizingFrame.Width = DirectCast(sender, Control).Left + e.X
        End If
    End Sub

    Private Sub ToolStripOnlinePlay_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStripOnlinePlay.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            IsMouseDown = True
            Pos2 = MousePosition
            SetCapture(DirectCast(sender, Control).Handle)
        End If
    End Sub

    Private Sub ToolStripOnlinePlay_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripOnlinePlay.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            IsMouseDown = False
            ReleaseCapture()
        End If
    End Sub

    Private Sub ToolStripOnlinePlay_MouseMove(sender As Object, e As MouseEventArgs) Handles ToolStripOnlinePlay.MouseMove
        If IsMouseDown AndAlso e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim ToolStrip = DirectCast(sender, Control)
            Dim frame = ToolStrip.Parent
            frame.Location += MousePosition - Pos2
            frame.BringToFront()
            Pos2 = MousePosition
        End If
    End Sub
    Private Sub CepHistory_Resize_MouseDown(sender As Object, e As MouseEventArgs) Handles CepHistory_Resize.MouseDown
        allowResize = True
        resizingFrame = DirectCast(sender, Control).Parent
    End Sub

    Private Sub CepHistory_Resize_MouseUp(sender As Object, e As MouseEventArgs) Handles CepHistory_Resize.MouseUp
        allowResize = False
        If resizingFrame IsNot Nothing Then
            resizingFrame.BringToFront()
            resizingFrame = Nothing
        End If
    End Sub

    Private Sub CepHistory_Resize_MouseMove(sender As Object, e As MouseEventArgs) Handles CepHistory_Resize.MouseMove
        If allowResize AndAlso resizingFrame IsNot Nothing Then
            resizingFrame.Height = DirectCast(sender, Control).Top + e.Y
            resizingFrame.Width = DirectCast(sender, Control).Left + e.X
        End If
    End Sub
End Class
