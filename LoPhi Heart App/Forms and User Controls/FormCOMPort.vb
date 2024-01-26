Imports System.IO.Ports

Public Class FormCOMPort
    Inherits Form
    Public deviceNumber As Integer
    Public comPort As String
    Private Sub FormSoundCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScanCOMPorts()
    End Sub

    Private Sub btnControlPanel_Click(sender As Object, e As EventArgs)
        Dim controlPanelPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe")
        System.Diagnostics.Process.Start(controlPanelPath, "sysdm.cpl")
    End Sub
    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        ScanCOMPorts()
    End Sub
    Private Sub ScanCOMPorts()
        Log("Scanning COM ports...")
        listBox1.Items.Clear()
        btnSelect.Enabled = False
        comPort = ""

        For Each port As String In SerialPort.GetPortNames()
            listBox1.Items.Add(port)
        Next
        If listBox1.Items.Count > 0 Then
            Log($"Identified {listBox1.Items.Count} active COM ports. Select the one you wish to use from the list.")
        Else
            Log($"ERROR: no active COM ports were found! Check your connections and ensure your device is properly connected.", True)
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        comPort = listBox1.SelectedItem.ToString()
        Me.Close()
    End Sub
    Public Sub Log(ByVal message As String, ByVal Optional [error] As Boolean = False)
        tbMessage.Text = message
    End Sub
    Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox1.SelectedIndexChanged
        btnSelect.Enabled = True
    End Sub
End Class