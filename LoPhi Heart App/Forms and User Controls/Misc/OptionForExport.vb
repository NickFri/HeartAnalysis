Imports System.IO

Partial Public Class ECG_MainForm
    Private Sub ExportECGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportECGToolStripMenuItem.Click

        Dim saveFileDialog As New SaveFileDialog()

        ' Set the default file name and extension
        saveFileDialog.FileName = "raw_ecg_data.txt"
        saveFileDialog.DefaultExt = "txt"

        ' Set the filter for file types
        saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

        ' Show the dialog box and check if the user clicked the "OK" button
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file name and path
            Dim ECGexportPath As String = saveFileDialog.FileName

            ' Sample Rate
            '  Dim SAMPLERATE As String = calculatesamplerate().ToString : If SAMPLERATE = "0" Then Return

            ' Create a new StreamWriter instance to write to a text file
            Using writer As New StreamWriter(ECGexportPath)

                ' Loop through
                For i As Integer = 1 To _30SecondDataBuffer.Count - 1
                    writer.WriteLine(_30SecondDataBuffer(i).ToString())
                Next
            End Using

            Dim code As String = "import numpy as np" & vbCrLf &
                             "from pyedflib import highlevel" & vbCrLf &
                             "data = np.loadtxt('raw_ecg_data.txt')" & vbCrLf &
                             "signals = data.reshape(1, -1)" & vbCrLf &
                             "channel_names = ['ch1']" & vbCrLf &
                             "signal_headers = highlevel.make_signal_headers(channel_names, physical_min=0, physical_max=4096, sample_frequency=" + "" + ")" & vbCrLf &
                             "header = highlevel.make_header(patientname='patient_x', gender='Female')" & vbCrLf &
                             "highlevel.write_edf('edf_file.edf', signals, signal_headers, header)"
            System.IO.File.WriteAllText(Path.GetDirectoryName(ECGexportPath) & "\toEDF.py", code)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim saveFileDialog As New SaveFileDialog()

        ' Set the default file name and extension
        saveFileDialog.FileName = "RR_Intervals_ms.txt"
        saveFileDialog.DefaultExt = "txt"

        ' Set the filter for file types
        saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

        ' Show the dialog box and check if the user clicked the "OK" button
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file name and path
            Dim HRVexportPath As String = saveFileDialog.FileName
            ' Create a new StreamWriter instance to write to a text file
            Using writer As New StreamWriter(HRVexportPath)
                ' Loop through each beat time and write the time difference in milliseconds to the file
                For i As Integer = 1 To beatTimes.Count - 1
                    Dim timeDiff As Double = (beatTimes(i) - beatTimes(i - 1)) * 1000 ' Convert to milliseconds
                    writer.WriteLine(timeDiff.ToString())
                Next
            End Using
        End If
    End Sub

End Class
