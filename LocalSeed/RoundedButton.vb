Imports System.Drawing.Drawing2D
Public Class RoundedButton
    Inherits Button

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim graphicsPath As New GraphicsPath()
        Dim myPen As New Pen(Me.ForeColor)

        Dim radius As Integer = 20
        Dim rectangle As New Rectangle(0, 0, Me.Width, Me.Height)

        graphicsPath.AddArc(New Rectangle(rectangle.X, rectangle.Y, radius, radius), 180, 90)
        graphicsPath.AddArc(New Rectangle(rectangle.Width - radius, rectangle.Y, radius, radius), 270, 90)
        graphicsPath.AddArc(New Rectangle(rectangle.Width - radius, rectangle.Height - radius, radius, radius), 0, 90)
        graphicsPath.AddArc(New Rectangle(rectangle.X, rectangle.Height - radius, radius, radius), 90, 90)
        graphicsPath.CloseAllFigures()

        e.Graphics.DrawPath(myPen, graphicsPath)
        e.Graphics.FillPath(New SolidBrush(Me.BackColor), graphicsPath)

        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), rectangle, stringFormat)

        Me.Region = New Region(graphicsPath)
    End Sub
End Class

