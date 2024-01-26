Public Class ToolStripRenderer
    Inherits ToolStripProfessionalRenderer

    Public Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        If Not (TypeOf e.ToolStrip Is ToolStrip) Then
            MyBase.OnRenderToolStripBorder(e)
        End If
    End Sub
End Class