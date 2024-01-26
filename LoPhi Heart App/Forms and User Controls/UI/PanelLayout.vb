Public Class PanelLayoutClass
    Public Property Panel As Control
    Public Property Size As Size
    Public Property Visible As Boolean
    Public Property Location As Point

    Public Sub New(panel As Control, size As Size, isVisible As Boolean, location As Point)
        Me.Panel = panel
        Me.Size = size
        Me.Visible = isVisible
        Me.Location = location
    End Sub

    Public Sub SetPanelLayout()
        Panel.Size = Size
        Panel.Visible = Visible
        Panel.Location = Location
    End Sub
End Class
