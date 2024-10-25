Public Class help_form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub help_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetRoundedCorner(PanelHelpChild, 30)
    End Sub
    Private Sub SetRoundedCorner(panel As Panel, radius As Integer)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(New Rectangle(0, 0, radius * 2, radius * 2), 180, 90)
        path.AddArc(New Rectangle(panel.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90)
        path.AddArc(New Rectangle(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2), 0, 90)
        path.AddArc(New Rectangle(0, panel.Height - radius * 2, radius * 2, radius * 2), 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub

End Class