Partial Public Class ECG_MainForm
    Private Sub SavePanelLayout(ByVal settingsName As String)
        ' Save panel locations, visibility, and size
        Dim panelLocations As New Specialized.StringCollection
        Dim panelVisibility As New Specialized.StringCollection
        Dim panelSizes As New Specialized.StringCollection
        For Each panel As Panel In Me.Controls.OfType(Of Panel)()
            panelLocations.Add(panel.Location.X & "," & panel.Location.Y)
            panelVisibility.Add(panel.Visible.ToString())
            panelSizes.Add(panel.Size.Width & "," & panel.Size.Height)
        Next
        My.Settings(settingsName & "Locations") = panelLocations
        My.Settings(settingsName & "Visibility") = panelVisibility
        My.Settings(settingsName & "Sizes") = panelSizes
        My.Settings.Save()
    End Sub

    Private Sub RecallPanelLayout(ByVal settingsName As String)
        ' Load panel locations, visibility, and size on startup
        If My.Settings(settingsName & "Locations") IsNot Nothing AndAlso My.Settings(settingsName & "Visibility") IsNot Nothing AndAlso My.Settings(settingsName & "Sizes") IsNot Nothing Then
            Dim panelLocations = My.Settings(settingsName & "Locations")
            Dim panelVisibility = My.Settings(settingsName & "Visibility")
            Dim panelSizes = My.Settings(settingsName & "Sizes")
            For i As Integer = 0 To Math.Min(Me.Controls.OfType(Of Panel)().Count() - 1, panelLocations.Count - 1)
                Dim locationParts = panelLocations(i).Split(","c)
                Dim x = Integer.Parse(locationParts(0))
                Dim y = Integer.Parse(locationParts(1))
                Me.Controls.OfType(Of Panel)().ElementAt(i).Location = New Point(x, y)
                Me.Controls.OfType(Of Panel)().ElementAt(i).Visible = Boolean.Parse(panelVisibility(i))
                Dim sizeParts = panelSizes(i).Split(","c)
                Dim width = Integer.Parse(sizeParts(0))
                Dim height = Integer.Parse(sizeParts(1))
                Me.Controls.OfType(Of Panel)().ElementAt(i).Size = New Size(width, height)
            Next
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SavePanelLayout("Panel1")
    End Sub

    Private Sub RecallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecallToolStripMenuItem.Click
        RecallPanelLayout("Panel1")
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        SavePanelLayout("Panel2")
    End Sub

    Private Sub RecallToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecallToolStripMenuItem1.Click
        RecallPanelLayout("Panel2")
    End Sub

    Private Sub SaveToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem2.Click
        SavePanelLayout("Panel3")
    End Sub

    Private Sub RecallToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RecallToolStripMenuItem2.Click
        RecallPanelLayout("Panel3")
    End Sub
End Class